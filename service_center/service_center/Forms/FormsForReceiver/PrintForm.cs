using service_center.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WordApp = Microsoft.Office.Interop.Word;

namespace service_center.Forms.FormsForReceiver
{
    public partial class PrintForm : Form
    {
        //экземпляр для подключения к бд
        ConnectionDB cn;
        //данные о имени приемщика и номер заказа
        string nameReceiver = "";
        string orderIdString = "";
        public PrintForm(string nameReceiver, string orderIdString)
        {
            InitializeComponent();

            cn = new ConnectionDB();
            //заполнение виртуальных форм
            if (orderIdString != "")
            {
                int orderId = Convert.ToInt32(orderIdString);
                string[] orderData = cn.ActData(orderId);

                ActReceiveRTB.Text = $"Акт приема на диагностику и выполнение ремонтных работ № {orderId}\n" +
                    $"ФИО клиента:       {orderData[0]}\n" +
                    $"Телефон клиента:  {orderData[1]}\n" +
                    $"Устройство:          {orderData[2]}\n" +
                    $"Серийный номер:  {orderData[3]}\n" +
                    $"Дата приема:          {orderData[4]}\n" +
                    "\n" +
                    $"Принял {nameReceiver}";

                ActIssueRTB.Text = $"Акт выдачи оборудования после проведенных диагностических и ремонтных работ № {orderId}\n" +
                    $"ФИО клиента:       {orderData[0]}\n" +
                    $"Телефон клиента:  {orderData[1]}\n" +
                    $"Устройство:          {orderData[2]}\n" +
                    $"Серийный номер:  {orderData[3]}\n" +
                    $"Дата приема:          {orderData[4]}\n" +
                    $"Дата выдачи:          {(orderData?[5] != null && orderData?[5] == "" ? DateTime.Today.ToString("dd.MM.yyyy") + " (Сегодня)" : orderData?[5])}\n" +
                    "\n" +
                    $"Выдал {nameReceiver}";
            }
            else
            {
                ActReceiveRTB.Text = "Заказ не выбран, перейдите во вкладку \"Список заков\" и выберите заказ.";
                ActReceiveButton.Enabled = false;
                ActIssueButton.Enabled = false;
            }

            this.nameReceiver = nameReceiver;
            this.orderIdString = orderIdString;
        }

        /// <summary>
        /// Метод для замены данных в документе.
        /// </summary>
        /// <param name="stub">Строка, которую заменит заданный текст.</param>
        /// <param name="text">Строка, на которую замениться заданый шаблон.</param>
        /// <param name="worddoc">Документ, в котором производиться замена.</param>
        private void Replace(string stub, string text, WordApp.Document worddoc)
        {
            //метод для замены данных в документе
            var range = worddoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub, ReplaceWith: text);
        }

        private void ActReceiveButton_Click(object sender, EventArgs e)
        {
            //формирование акта приема
            if (orderIdString != "")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int orderId = Convert.ToInt32(orderIdString);

                    string[] orderData = cn.ActData(orderId);

                    var wordapp = new WordApp.Application();
                    wordapp.Visible = false;
                    try
                    {
                        var worddoc = wordapp.Documents.Open($@"{Application.StartupPath}\sample1.docx");
                        Replace("_OrderId_", orderId.ToString(), worddoc);
                        Replace("_NameClient_", orderData[0], worddoc);
                        Replace("_Phone_", orderData[1], worddoc);
                        Replace("_Title_", orderData[2], worddoc);
                        Replace("_Serial_", orderData[3], worddoc);
                        Replace("_DateIn_", orderData[4], worddoc);
                        Replace("_NameReceiver_", nameReceiver, worddoc);

                        worddoc.SaveAs(saveFileDialog.FileName);
                        worddoc.Close();
                        MessageBox.Show("Акт приема успешно создан.", "Печать актов");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        wordapp.Quit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран заказ.", "Печать актов");
            }
        }

        private void ActIssueButton_Click(object sender, EventArgs e)
        {
            //формирование акта выдачи
            if (orderIdString != "")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int orderId = Convert.ToInt32(orderIdString);
                    //обновление данных о заказе
                    string[] orderData = cn.ActData(orderId);
                    if(orderData[5] == null || orderData[5] == "")
                    {
                        cn.UpdateStatus(orderId, 6);
                        cn.UpdateOrderSetDateOut(orderId);
                        orderData = cn.ActData(orderId);
                    }

                    var wordapp = new WordApp.Application();
                    wordapp.Visible = false;
                    try
                    {
                        var worddoc = wordapp.Documents.Open($@"{Application.StartupPath}\sample2.docx");
                        Replace("_OrderId_", orderId.ToString(), worddoc);
                        Replace("_NameClient_", orderData[0], worddoc);
                        Replace("_Phone_", orderData[1], worddoc);
                        Replace("_Title_", orderData[2], worddoc);
                        Replace("_Serial_", orderData[3], worddoc);
                        Replace("_DateIn_", orderData[4], worddoc);
                        Replace("_DateOut_", orderData?[5], worddoc);
                        Replace("_NameReceiver_", nameReceiver, worddoc);

                        worddoc.SaveAs(saveFileDialog.FileName);
                        worddoc.Close();
                        MessageBox.Show("Акт выдачи успешно создан.", "Печать актов");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        wordapp.Quit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран заказ.", "Печать актов");
            }
        }

        private void BackToFormButton_Click(object sender, EventArgs e)
        {
            //возвращается назад по форме
            this.Hide();
        }
    }
}