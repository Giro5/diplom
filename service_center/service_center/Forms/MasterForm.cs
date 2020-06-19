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

namespace service_center.Forms
{
    public partial class MasterForm : Form
    {
        //экземпляр для подключения к бд
        ConnectionDB cn;
        public MasterForm(string name, string surname, string patronymic)
        {
            InitializeComponent();

            this.Text = $"Вы авторизированны как, мастер {surname} {name} {patronymic}";
            cn = new ConnectionDB();
            //заполнение и оформление списка заказов
            OrderListDGV.DataSource = cn.DisplayOrdersForMaster("", false);
            OrderListDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            OrderListDGV.Columns[0].HeaderText = "Код заказа";
            OrderListDGV.Columns[1].HeaderText = "Артикул";
            OrderListDGV.Columns[2].HeaderText = "Серийный номер";
            OrderListDGV.Columns[3].HeaderText = "Дата прихода";
            OrderListDGV.Columns[4].HeaderText = "Код статуса";
            OrderListDGV.Columns[5].HeaderText = "Статус";

            StatusComboBox.Items.Clear();
            StatusComboBox.Items.AddRange(cn.StatusListForMaster());
        }

        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //открытия форма авторизации при выходе
            Application.OpenForms["LoginForm"].Show();
        }

        private void OrderListDGV_SelectionChanged(object sender, EventArgs e)
        {
            //изменение выбора заказа и вставка его данных
            var selectedRows = OrderListDGV.SelectedRows;
            StatusComboBox.Enabled = true;
            if (selectedRows.Count > 0)
            {
                OrderIdTextBox.Text = selectedRows[0].Cells[0].Value.ToString();
                ArticleTextBox.Text = selectedRows[0].Cells[1].Value.ToString();
                TitleTextBox.Text = cn.TitleOrder(Convert.ToInt32(selectedRows[0].Cells[0].Value));
                SerialNumberTextBox.Text = selectedRows[0].Cells[2].Value.ToString();
                StatusComboBox.SelectedIndex = Convert.ToInt32(selectedRows[0].Cells[4].Value) - 1;
            }
            else
            {
                OrderIdTextBox.Text = "";
                ArticleTextBox.Text = "";
                TitleTextBox.Text = "";
                SerialNumberTextBox.Text = "";
                StatusComboBox.Enabled = false;
            }
        }

        private void SearchAndFilter_Changed(object sender, EventArgs e)
        {
            //обновление списка заказов по результату поиска
            OrderListDGV.DataSource = cn.DisplayOrdersForMaster(SearchOrderTextBox.Text, ActiveOrdersCheckBox.Checked);
        }

        private void ConfirmStatusButton_Click(object sender, EventArgs e)
        {
            //кнопка изменения статуса
            if (OrderIdTextBox.Text != "")
            {
                int orderId = Convert.ToInt32(OrderIdTextBox.Text),
                    statusId = StatusComboBox.SelectedIndex + 1,
                    statusIdOld = Convert.ToInt32(OrderListDGV.SelectedRows[0].Cells[4].Value);
                if (statusId != statusIdOld)//обновляет статус если он не такой же
                {
                    cn.UpdateStatus(orderId, statusId);
                    MessageBox.Show("Статус успешно изменен.", "Изменение статуса");
                    OrderListDGV.DataSource = cn.DisplayOrdersForMaster(SearchOrderTextBox.Text, ActiveOrdersCheckBox.Checked);
                }
                else
                {
                    MessageBox.Show("Нельзя изменить статус на такой же.", "Изменение статуса");
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ, чтобы изменить статус.", "Изменение статуса");
            }
        }
    }
}