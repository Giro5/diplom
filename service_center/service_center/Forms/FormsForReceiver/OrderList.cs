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

using ExcelApp = Microsoft.Office.Interop.Excel;

namespace service_center.Forms.FormsForReceiver
{
    public partial class OrderList : Form
    {
        //экземпляр для подключения к бд
        ConnectionDB cn;
        public OrderList()
        {
            InitializeComponent();

            cn = new ConnectionDB();
            DateInEndDTP.Value = DateTime.Today;
            //заполнение и оформление списка заказов
            OrderListDGV.DataSource = cn.DisplayOrders("", false, false, false, DateInStartDTP.Value, DateInEndDTP.Value);
            OrderListDGV.Columns[0].HeaderText = "Номер заказа";
            OrderListDGV.Columns[1].HeaderText = "Имя";
            OrderListDGV.Columns[2].HeaderText = "Фамилия";
            OrderListDGV.Columns[3].HeaderText = "Отчество";
            OrderListDGV.Columns[4].HeaderText = "Телефон";
            OrderListDGV.Columns[5].HeaderText = "Артикул";
            OrderListDGV.Columns[6].HeaderText = "Серийный номер";
            OrderListDGV.Columns[7].HeaderText = "Дата приема";
            OrderListDGV.Columns[8].HeaderText = "Дата выдачи";
            OrderListDGV.Columns[9].HeaderText = "Статус";
        }

        private void SearchAndFilters_Changed(object sender, EventArgs e)
        {
            //изменение в поисковой строке или переключения фильтров - обновляет список заказов
            OrderListDGV.DataSource = cn.DisplayOrders(SearchOrderTextBox.Text, DiagnostedCheckBox.Checked, IssuedCheckBox.Checked, 
                WaitRepairCheckBox.Checked, DateInStartDTP.Value, DateInEndDTP.Value);
        }

        private void PrintActButton_Click(object sender, EventArgs e)
        {
            //кнопка открывает окно оформления актов
            if (OrderListDGV.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(OrderListDGV.SelectedRows[0].Cells[0].Value);

                PrintForm printForm = new PrintForm(this.Text, orderId.ToString());
                printForm.MdiParent = this.MdiParent;
                printForm.AccessibleName = orderId.ToString();
                printForm.Dock = DockStyle.Fill;
                printForm.Text = this.Text;
                printForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите заказ.", "Оформление актов");
            }
        }

        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            //кнопка оформление отчета
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = (DataTable)OrderListDGV.DataSource;

                var excelapp = new ExcelApp.Application();
                excelapp.Visible = false;
                try
                {
                    //отчет будет сохранен как Excel файл
                    excelapp.SheetsInNewWorkbook = 1;
                    ExcelApp.Workbook workbook = excelapp.Workbooks.Add(Type.Missing);
                    excelapp.DisplayAlerts = false;
                    ExcelApp.Worksheet sheet = (ExcelApp.Worksheet)excelapp.Worksheets[1];
                    sheet.Name = $"Отчет";
                    //заполнение вводной информацией
                    sheet.Cells[1, 1] = $"Отчет с";
                    sheet.Cells[1, 2] = DateInStartDTP.Value.ToShortDateString();
                    sheet.Cells[1, 3] = "по";
                    sheet.Cells[1, 4] = DateInEndDTP.Value.ToShortDateString();
                    sheet.Cells[2, 1] = "Поисковая строка:";
                    sheet.Cells[2, 2] = $"\"{SearchOrderTextBox.Text}\"";
                    sheet.Cells[2, 3] = "Фильтр:";
                    sheet.Cells[2, 4] = WaitRepairCheckBox.Checked ? WaitRepairCheckBox.Text : "";
                    sheet.Cells[2, 5] = DiagnostedCheckBox.Checked ? "Диагностированные" : "";
                    sheet.Cells[2, 6] = IssuedCheckBox.Checked ? IssuedCheckBox.Text : "";
                    sheet.Cells[3, 1] = "Номер заказа";
                    sheet.Cells[3, 2] = "Имя";
                    sheet.Cells[3, 3] = "Фамилия";
                    sheet.Cells[3, 4] = "Отчество";
                    sheet.Cells[3, 5] = "Телефон";
                    sheet.Cells[3, 6] = "Артикул";
                    sheet.Cells[3, 7] = "Серийный номер";
                    sheet.Cells[3, 8] = "Дата приема";
                    sheet.Cells[3, 9] = "Дата выдачи";
                    sheet.Cells[3, 10] = "Статус";
                    //заполнение данными
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        for(int j = 0; j < dt.Columns.Count; j++)
                        {
                            sheet.Cells[i + 4, j + 1] = dt.Rows[i][j];
                        }
                    }
                    //марафет
                    sheet.Range[sheet.Cells[1,1], sheet.Cells[1, 10]].EntireColumn.AutoFit();
                    var DataRange = (ExcelApp.Range)sheet.Range[sheet.Cells[3, 1], sheet.Cells[dt.Rows.Count + 3, 10]];
                    DataRange.Borders.get_Item(ExcelApp.XlBordersIndex.xlEdgeBottom).LineStyle = ExcelApp.XlLineStyle.xlContinuous;
                    DataRange.Borders.get_Item(ExcelApp.XlBordersIndex.xlEdgeRight).LineStyle = ExcelApp.XlLineStyle.xlContinuous;
                    DataRange.Borders.get_Item(ExcelApp.XlBordersIndex.xlInsideHorizontal).LineStyle = ExcelApp.XlLineStyle.xlContinuous;
                    DataRange.Borders.get_Item(ExcelApp.XlBordersIndex.xlInsideVertical).LineStyle = ExcelApp.XlLineStyle.xlContinuous;
                    DataRange.Borders.get_Item(ExcelApp.XlBordersIndex.xlEdgeTop).LineStyle = ExcelApp.XlLineStyle.xlContinuous;

                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    MessageBox.Show("Отчет успешно создан.", "Формирование отчета");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Отчет не удалось сохранить.", "Ошибка сохранения");
                }
                finally
                {
                    excelapp.Quit();
                }
            }
        }
    }
}