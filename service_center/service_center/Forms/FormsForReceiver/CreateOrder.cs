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

namespace service_center.Forms.FormsForReceiver
{
    public partial class CreateOrder : Form
    {
        //экземпляр для подключения к бд
        ConnectionDB cn;
        public CreateOrder()
        {
            InitializeComponent();

            cn = new ConnectionDB();
            //заполнение и оформление каталога товаров
            CatalogDGV.DataSource = cn.DisplayCatalog(SearchTextBox.Text);
            CatalogDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            CatalogDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CatalogDGV.ScrollBars = ScrollBars.Both;
            CatalogDGV.AllowUserToResizeColumns = true;
            CatalogDGV.Columns[0].HeaderText = "Артикул";
            CatalogDGV.Columns[1].HeaderText = "Название";
            CatalogDGV.Columns[2].HeaderText = "Период гарантии в месяцах";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //обновление каталога по результату поиска
            CatalogDGV.DataSource = cn.DisplayCatalog(SearchTextBox.Text);
        }

        private void CatalogDGV_SelectionChanged(object sender, EventArgs e)
        {
            //изменение выбора товара и вставка его данных
            var selectedRows = CatalogDGV.SelectedRows;
            if (selectedRows.Count > 0)
            {
                ProductInfoTextBox.Text = selectedRows[0].Cells[0].Value + " " + selectedRows[0].Cells[1].Value;
                CheckFillFields();
            }
            else
            {
                ProductInfoTextBox.Text = "";
                CheckFillFields();
            }
        }

        private void InfoBoxes_TextChanged(object sender, EventArgs e)
        {
            //изменение полей данных о заказе
            CheckFillFields();
        }

        /// <summary>
        /// Проверка заполненности и корректности полей данных.
        /// </summary>
        /// <returns>Возвращает true если валидация прошла успешно, иначе false.</returns>
        private bool CheckFillFields()
        {
            //проверка заполненности и корректности полей данных
            ExceptionNameLabel.Visible = false;
            ExceptionPhoneLabel.Visible = false;
            ExceptionSerialLabel.Visible = false;
            ExceptionEmptyLabel.Visible = false;
            ExceptionWarrantyLable.Visible = false;
            //проверка полей: товар, ФИО, телефон, серийный номер
            if (ProductInfoTextBox.Text == "" || NameClientTextBox.Text == "" || PhoneClientTextBox.Text == "" || SerialNumberTextBox.Text == "")
            {
                ExceptionEmptyLabel.Visible = true;
                return false;
            }
            //проверка продолжительности гарантии
            int warrantyPeriod = Convert.ToInt32(CatalogDGV.SelectedRows[0].Cells[2].Value.ToString());
            if (warrantyPeriod / 12 * 365 < DateTime.Today.Subtract(DateCheckDTP.Value).Days)
            {
                ExceptionWarrantyLable.Visible = true;
                return false;
            }
            //вторичная валидация поля ФИО
            if (!NameClientTextBox.Text.Contains(" "))
            {
                ExceptionNameLabel.Visible = true;
                return false;
            }
            //вторичная валидация поля телефон
            if (PhoneClientTextBox.Text.Length < 10)
            {
                ExceptionPhoneLabel.Visible = true;
                return false;
            }
            //вторичная валидация поля серийный номер
            int article = Convert.ToInt32(CatalogDGV.SelectedRows[0].Cells[0].Value);
            if (cn.CompareDublicatesSerialNumbers(SerialNumberTextBox.Text, article))
            {
                ExceptionSerialLabel.Visible = true;
                return false;
            }
            //все правильно
            return true;
        }

        private void SpendButton_Click(object sender, EventArgs e)
        {
            //кнопка проведения заказа
            //проверка заполненности и корректности полей данных
            if (!CheckFillFields())
            {
                MessageBox.Show("Чтобы провести заказ нужно корректно заполнить поля.", "Оформление заказа");
                return;
            }
            //заполнение данных
            int article = Convert.ToInt32(CatalogDGV.SelectedRows[0].Cells[0].Value);
            string name = NameClientTextBox.Text.Split(' ')[1],
                surname = NameClientTextBox.Text.Split(' ')[0],
                patronymic = "",
                phone = PhoneClientTextBox.Text;
            if (NameClientTextBox.Text.Split(' ').Length > 2)
            {
                patronymic = NameClientTextBox.Text.Split(' ')[2];
            }
            //вставка новых данных
            int clientId = cn.InsertingClients(name, surname, patronymic, phone),
                orderId = cn.InsertingOrder(DateCheckDTP.Value, article, clientId, SerialNumberTextBox.Text);
            if (MessageBox.Show("Заказ успешно проведен.\n\nОткрыть окно оформления актов?", "Оформление заказа", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //открытие формы оформления актов
                PrintForm printForm = new PrintForm(this.Text, orderId.ToString());
                printForm.MdiParent = this.MdiParent;
                printForm.Dock = DockStyle.Fill;
                printForm.Show();
            }
            NameClientTextBox.Text = "";
            PhoneClientTextBox.Text = "";
            SerialNumberTextBox.Text = "";
            DateCheckDTP.Value = DateTime.Today;
        }
    }
}