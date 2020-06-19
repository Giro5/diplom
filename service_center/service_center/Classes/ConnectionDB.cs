using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace service_center.Classes
{
    /// <summary>
    /// Класс для подключения к базе данных и реализацией всех запросов.
    /// </summary>
    class ConnectionDB
    {
        //экземпляр для подключения к бд
        private MySqlConnection cn;

        public ConnectionDB()
        {
            //инициализация подключения к бд и тестирование подключения
            cn = new MySqlConnection("port=3306;server=localhost;userid=root;password=123654;database=service_center");
            try
            {
                cn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка подключения");
            }
            finally
            {
                cn.Close();
            }
        }

        /// <summary>
        /// Метод для проверки данных для авторизации.
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="userData">Выходной параметр, возвращает данные пользователя</param>
        /// <returns>Возвращает булевое значение успешности авторизации</returns>
        public bool CheckLogin(string login, string password, out string[] userData)
        {
            bool statusLogin = false;
            userData = new[] { "", "", "", "" };
            try
            {
                cn.Open();

                MySqlCommand checkQuery = new MySqlCommand($"select * from users where login='{login}' and password='{password}';", cn);

                MySqlDataReader userReader = checkQuery.ExecuteReader();
                statusLogin = userReader.HasRows;
                if (statusLogin)
                {
                    userReader.Read();
                    userData = new[] { userReader.GetString("name"), userReader.GetString("surname"), userReader.GetString("patronymic"), userReader.GetString("role") };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка авторизации");
            }
            finally
            {
                cn.Close();
            }
            return statusLogin;
        }

        /// <summary>
        /// Метод отображет каталог.
        /// </summary>
        /// <param name="searchString">Поисковая строка</param>
        /// <returns>Возвращает таблицу по результатам поисковой строки в каталоге</returns>
        public DataTable DisplayCatalog(string searchString)
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();

                string query = $"select * from catalog where article like '%{searchString}%' or title like '%{searchString}%'";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, cn);
                mySqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка отображения каталога");
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }

        /// <summary>
        /// Метод проверяет отсутствие дубликатов серийного номера одного и того же товара.
        /// </summary>
        /// <param name="serial">Искомый серийный номер</param>
        /// <param name="article">Артикул товара</param>
        /// <returns>Возвращает true если дубликат существует, иначе false</returns>
        public bool CompareDublicatesSerialNumbers(string serial, int article)
        {
            bool IsDublicate = false;
            try
            {
                cn.Open();

                MySqlCommand mySqlCommand = new MySqlCommand($"select * from orders where serial_number = '{serial}' and article = '{article}'", cn);
                MySqlDataReader mySQLDataReader = mySqlCommand.ExecuteReader();
                IsDublicate = mySQLDataReader.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка серийных номеров");
            }
            finally
            {
                cn.Close();
            }
            return IsDublicate;
        }

        /// <summary>
        /// Метод вставляет запись клиента с указанными данными.
        /// </summary>
        /// <param name="name">Имя клиента</param>
        /// <param name="surname">Фамилия клиента</param>
        /// <param name="patronymic">Отчество клиента</param>
        /// <param name="phone">Телефон клиента</param>
        /// <returns>Возвращает код вставленной записи</returns>
        public int InsertingClients(string name, string surname, string patronymic, string phone)
        {
            int clientCode = -1;
            try
            {
                cn.Open();

                MySqlCommand mySqlCommand = new MySqlCommand($"insert into clients values (null, '{name}', '{surname}','{patronymic}','{phone}')", cn);
                mySqlCommand.ExecuteNonQuery();
                //получет код
                mySqlCommand = new MySqlCommand("select max(client_id) from clients", cn);
                MySqlDataReader mySQLDataReader = mySqlCommand.ExecuteReader();
                mySQLDataReader.Read();
                clientCode = mySQLDataReader.GetInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка вставки клиентов");
            }
            finally
            {
                cn.Close();
            }
            return clientCode;
        }

        /// <summary>
        /// Метод вставляет новый заказ.
        /// </summary>
        /// <param name="checkDate">Дата чека</param>
        /// <param name="article">Артикул товара</param>
        /// <param name="clientId">Код клиента</param>
        /// <param name="serial">Серийный номер</param>
        /// <returns>Возвращает код заказа</returns>
        public int InsertingOrder(DateTime checkDate, int article, int clientId, string serial)
        {
            string dateIn = DateTime.Today.ToString("yyyy-MM-dd"),
                dateCheck = checkDate.ToString("yyyy-MM-dd");
            int orderCode = -1;
            try
            {
                cn.Open();

                MySqlCommand mySqlCommand = new MySqlCommand($"insert into orders values (null, '{dateCheck}', '{article}','{clientId}','{serial}', '{dateIn}', null, 1)", cn);
                mySqlCommand.ExecuteNonQuery();
                //получет код
                mySqlCommand = new MySqlCommand("select max(order_id) from orders", cn);
                MySqlDataReader mySQLDataReader = mySqlCommand.ExecuteReader();
                mySQLDataReader.Read();
                orderCode = mySQLDataReader.GetInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка вставки заказа");
            }
            finally
            {
                cn.Close();
            }
            return orderCode;
        }

        /// <summary>
        /// Метод отображает список заказов.
        /// </summary>
        /// <param name="searchString">Поисковая строка</param>
        /// <param name="IsDiagnosted">Фильтр диагностированного</param>
        /// <param name="IsIssued">Фильтр выданного</param>
        /// <param name="IsWaitRepair">Фильтр ждущего ремонта</param>
        /// <param name="DateInStart">Фильтр даты начала периода</param>
        /// <param name="DateInEnd">Фильтр даты конца периода</param>
        /// <returns>Возвращает результирующию таблицу по поисковой строке и фильтрам</returns>
        public DataTable DisplayOrders(string searchString, bool IsDiagnosted, bool IsIssued, bool IsWaitRepair, DateTime DateInStart, DateTime DateInEnd)
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                //компоновка фильтров
                string StatusFilter = "";
                if (IsDiagnosted)//диагностированного
                {
                    StatusFilter = "2,4,5";
                }
                if (IsIssued)//выданного
                {
                    StatusFilter += StatusFilter == "" ? "6" : ",6";
                }
                if (IsWaitRepair)//ждущего ремонта
                {
                    StatusFilter += StatusFilter == "" ? "1,3" : ",1,3";
                }
                if (IsDiagnosted || IsIssued || IsWaitRepair)
                {
                    string temporaryStatusFilter = StatusFilter;
                    StatusFilter = $" and orders.status_id in ({StatusFilter})";
                }

                string query = $"select order_id, clients.name, surname, patronymic, phone, article, serial_number, date_in, date_out, statuses.name " +
                    $"from orders, clients, statuses where orders.client_id=clients.client_id and orders.status_id=statuses.status_id " +
                    $"and ((order_id like '%{searchString}%' or article like '%{searchString}%' or serial_number like '%{searchString}%'){StatusFilter}) " +
                    $"and date_in >= '{DateInStart.ToString("yyyy-MM-dd")}' and date_in <= '{DateInEnd.ToString("yyyy-MM-dd")}' " +
                    $"order by order_id";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, cn);
                mySqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу." , "Ошибка отображения заказов");
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }

        /// <summary>
        /// Метод для получения данных для форирования актов.
        /// </summary>
        /// <param name="orderId">Код заказа</param>
        /// <returns>Возвращает набор данных о заказе</returns>
        public string[] ActData(int orderId)
        {
            string[] data = new[] { "", "", "", "", "", "" };
            try
            {
                cn.Open();

                string query = $"SELECT name, surname, patronymic, phone, title, serial_number, date_in, date_out FROM orders, catalog, clients " +
                    $"WHERE orders.article = catalog.article AND orders.client_id = clients.client_id AND orders.order_id = {orderId}";
                MySqlCommand mySqlCommand = new MySqlCommand(query, cn);
                MySqlDataReader mySQLDataReader = mySqlCommand.ExecuteReader();
                mySQLDataReader.Read();
                //заполнение набора данных
                data[0] = mySQLDataReader.GetString(1) + " " + mySQLDataReader.GetString(0) + " " + mySQLDataReader.GetString(2); // full name
                data[1] = mySQLDataReader.GetString(3); // phone
                data[2] = mySQLDataReader.GetString(4); // title
                data[3] = mySQLDataReader.GetString(5); // serial_number
                data[4] = mySQLDataReader.GetDateTime(6).ToShortDateString(); // date_in
                if (mySQLDataReader.GetValue(7) != null && mySQLDataReader.GetValue(7).ToString() != "")
                    data[5] = mySQLDataReader.GetDateTime(7).ToShortDateString(); // date_out
                else
                    data[5] = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка отчета заказа");
            }
            finally
            {
                cn.Close();
            }
            return data;
        }

        /// <summary>
        /// Метод получает название товара.
        /// </summary>
        /// <param name="orderId">Код заказа</param>
        /// <returns>Возвращает строку названия товара</returns>
        public string TitleOrder(int orderId)
        {
            string title = "";
            try
            {
                cn.Open();

                string query = $"SELECT title FROM orders, catalog WHERE orders.article = catalog.article AND orders.order_id = '{orderId}'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, cn);
                MySqlDataReader mySQLDataReader = mySqlCommand.ExecuteReader();
                mySQLDataReader.Read();
                title = mySQLDataReader.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка получения названия устройства");
            }
            finally
            {
                cn.Close();
            }
            return title;
        }

        /// <summary>
        /// метод для получения списка статусов для мастера.
        /// </summary>
        /// <returns>Возвращает массив из статусов</returns>
        public string[] StatusListForMaster()
        {
            string[] list = new[] { "", "", "", "", "" };
            try
            {
                cn.Open();

                string query = $"SELECT * FROM statuses where status_id <> 6";
                MySqlCommand mySqlCommand = new MySqlCommand(query, cn);
                MySqlDataReader mySQLDataReader = mySqlCommand.ExecuteReader();
                int i = 0;
                while (mySQLDataReader.Read())
                {
                    list[i] = mySQLDataReader.GetString(1);
                    i++;
                }
                mySQLDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка списка статусов");
            }
            finally
            {
                cn.Close();
            }
            return list;
        }

        /// <summary>
        /// Метод для обновления статуса у заказа.
        /// </summary>
        /// <param name="orderId">Код заказа</param>
        /// <param name="statusId">Код нового статуса</param>
        public void UpdateStatus(int orderId, int statusId)
        {
            try
            {
                cn.Open();

                string query = $"update orders set status_id = '{statusId}' where order_id = '{orderId}'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, cn);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка обновления статуса");
            }
            finally
            {
                cn.Close();
            }
        }

        /// <summary>
        /// Метод для отображения заказов для мастера.
        /// </summary>
        /// <param name="searchString">Поисковая строка</param>
        /// <param name="IsActiveOrders">Фильтр активных заказов</param>
        /// <returns>Возвращает результирующую таблицу по поисковой строке и фильтра</returns>
        public DataTable DisplayOrdersForMaster(string searchString, bool IsActiveOrders)
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                string StatusFilter = "";
                if (IsActiveOrders)//Фильтр активных заказов
                {
                    StatusFilter = " and orders.status_id in (1,3)";
                }

                string query = $"select order_id, article, serial_number, date_in, orders.status_id, statuses.name from orders, statuses " +
                    $"where orders.status_id = statuses.status_id and orders.status_id <> 6{StatusFilter} and" +
                    $"(order_id like '%{searchString}%' or article like '%{searchString}%' or serial_number like '%{searchString}%') " +
                    $"order by order_id";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, cn);
                mySqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.\n" + ex, "Ошибка отображения заказов");
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }

        /// <summary>
        /// Метод задает дату выдачи заказа.
        /// </summary>
        /// <param name="OrderId">Код заказа</param>
        public void UpdateOrderSetDateOut(int OrderId)
        {
            string dateOut = DateTime.Today.ToString("yyyy-MM-dd");
            try
            {
                cn.Open();
                string query = $"update orders set date_out = '{dateOut}' where order_id = '{OrderId}'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, cn);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается подключиться к удаленному серверу.", "Ошибка вставки заказа");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}