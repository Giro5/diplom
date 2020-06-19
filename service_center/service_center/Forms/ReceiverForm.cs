using service_center.Classes;
using service_center.Forms.FormsForReceiver;
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
    public partial class ReceiverForm : Form
    {
        //экземпляр для подключения к бд
        ConnectionDB cn;
        //экземпляры форм
        CreateOrder createOrder;
        OrderList orderList;
        PrintForm printForm;
        public ReceiverForm(string name, string surname, string patronymic)
        {
            InitializeComponent();

            this.Text = $"Вы авторизированны как, приемщик {surname} {name} {patronymic}";
            cn = new ConnectionDB();
            //инициализация и настройка вложеных форм
            createOrder = new CreateOrder();
            createOrder.MdiParent = this;
            createOrder.Dock = DockStyle.Fill;
            createOrder.Text = $"{surname} {name} {patronymic}";

            orderList = new OrderList();
            orderList.MdiParent = this;
            orderList.Dock = DockStyle.Fill;
            orderList.Text = $"{surname} {name} {patronymic}";

            printForm = new PrintForm("", "");
            printForm.MdiParent = this;
            printForm.Dock = DockStyle.Fill;
            printForm.Text = $"{surname} {name} {patronymic}";

            createOrder.Show();
        }

        private void ReceiverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //открытия форма авторизации при выходе
            Application.OpenForms["LoginForm"].Show();
        }

        private void SideBarButton_Click(object sender, EventArgs e)
        {
            //кнопки на боковой панели - переключают вложенные формы
            var b = (Button)sender;

            CreateOrderButton.BackColor = Color.WhiteSmoke;
            OrderListButton.BackColor = Color.WhiteSmoke;
            PrintFormButton.BackColor = Color.WhiteSmoke;

            createOrder.Hide();
            orderList.Hide();
            printForm.Hide();

            b.BackColor = Color.Gainsboro;
            
            if ((string)b.Tag == "0")//форма создания заказов
            {
                createOrder.Show();
            }
            else if ((string)b.Tag == "1")//форма списка заказов
            {
                orderList.Show();
            }
            else if ((string)b.Tag == "2")//форма оформления актов
            {
                printForm.Show();
            }
            else
            {

            }
        }
    }
}