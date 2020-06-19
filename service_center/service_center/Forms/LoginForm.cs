using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using service_center.Classes;
using service_center.Forms;

namespace service_center
{
    public partial class LoginForm : Form
    {
        //экземпляр для подключения к бд
        ConnectionDB cn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginTextBox.Text = "admin";
            PasswordTextBox.Text = "123";

            cn = new ConnectionDB();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //кнопка входа - авторизирует пользователя
            string[] userData;
            if (cn.CheckLogin(LoginTextBox.Text, PasswordTextBox.Text, out userData))
            {
                ExceptionLabel.Visible = false;
                LoginTextBox.Text = "";
                PasswordTextBox.Text = "";
                this.Hide();

                if (userData[3] == "r")//роль приемщика
                {
                    ReceiverForm receiverForm = new ReceiverForm(userData[0], userData[1], userData[2]);
                    receiverForm.Show();
                }
                else if (userData[3] == "m")//роль мастера
                {
                    MasterForm masterForm = new MasterForm(userData[0], userData[1], userData[2]);
                    masterForm.Show();
                }
                else if (userData[3] == "a")//роль админа
                {
                    ReceiverForm receiverForm = new ReceiverForm(userData[0], userData[1], userData[2]);
                    receiverForm.Show();

                    MasterForm masterForm = new MasterForm(userData[0], userData[1], userData[2]);
                    masterForm.Show();
                }
                else
                {

                }
            }
            else
            {
                ExceptionLabel.Visible = true;
            }
        }
    }
}