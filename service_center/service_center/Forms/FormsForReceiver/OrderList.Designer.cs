namespace service_center.Forms.FormsForReceiver
{
    partial class OrderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.PrintReportButton = new System.Windows.Forms.Button();
            this.UntilLabel = new System.Windows.Forms.Label();
            this.AtLabel = new System.Windows.Forms.Label();
            this.DateInEndDTP = new System.Windows.Forms.DateTimePicker();
            this.DateInLabel = new System.Windows.Forms.Label();
            this.DateInStartDTP = new System.Windows.Forms.DateTimePicker();
            this.WaitRepairCheckBox = new System.Windows.Forms.CheckBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.IssuedCheckBox = new System.Windows.Forms.CheckBox();
            this.DiagnostedCheckBox = new System.Windows.Forms.CheckBox();
            this.PrintActButton = new System.Windows.Forms.Button();
            this.SearchOrderLabel = new System.Windows.Forms.Label();
            this.SearchOrderTextBox = new System.Windows.Forms.TextBox();
            this.OrderListDGV = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.Controls.Add(this.PrintReportButton);
            this.TopBarPanel.Controls.Add(this.UntilLabel);
            this.TopBarPanel.Controls.Add(this.AtLabel);
            this.TopBarPanel.Controls.Add(this.DateInEndDTP);
            this.TopBarPanel.Controls.Add(this.DateInLabel);
            this.TopBarPanel.Controls.Add(this.DateInStartDTP);
            this.TopBarPanel.Controls.Add(this.WaitRepairCheckBox);
            this.TopBarPanel.Controls.Add(this.RefreshButton);
            this.TopBarPanel.Controls.Add(this.IssuedCheckBox);
            this.TopBarPanel.Controls.Add(this.DiagnostedCheckBox);
            this.TopBarPanel.Controls.Add(this.PrintActButton);
            this.TopBarPanel.Controls.Add(this.SearchOrderLabel);
            this.TopBarPanel.Controls.Add(this.SearchOrderTextBox);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1099, 104);
            this.TopBarPanel.TabIndex = 0;
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.Location = new System.Drawing.Point(868, 12);
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.Size = new System.Drawing.Size(115, 81);
            this.PrintReportButton.TabIndex = 12;
            this.PrintReportButton.Text = "Оформить отчет";
            this.PrintReportButton.UseVisualStyleBackColor = true;
            this.PrintReportButton.Click += new System.EventHandler(this.PrintReportButton_Click);
            // 
            // UntilLabel
            // 
            this.UntilLabel.AutoSize = true;
            this.UntilLabel.Location = new System.Drawing.Point(525, 66);
            this.UntilLabel.Name = "UntilLabel";
            this.UntilLabel.Size = new System.Drawing.Size(27, 19);
            this.UntilLabel.TabIndex = 11;
            this.UntilLabel.Text = "По";
            this.UntilLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AtLabel
            // 
            this.AtLabel.AutoSize = true;
            this.AtLabel.Location = new System.Drawing.Point(525, 33);
            this.AtLabel.Name = "AtLabel";
            this.AtLabel.Size = new System.Drawing.Size(18, 19);
            this.AtLabel.TabIndex = 10;
            this.AtLabel.Text = "С";
            this.AtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateInEndDTP
            // 
            this.DateInEndDTP.Location = new System.Drawing.Point(552, 60);
            this.DateInEndDTP.Name = "DateInEndDTP";
            this.DateInEndDTP.Size = new System.Drawing.Size(189, 27);
            this.DateInEndDTP.TabIndex = 9;
            this.DateInEndDTP.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            this.DateInEndDTP.ValueChanged += new System.EventHandler(this.SearchAndFilters_Changed);
            // 
            // DateInLabel
            // 
            this.DateInLabel.AutoSize = true;
            this.DateInLabel.Location = new System.Drawing.Point(534, 5);
            this.DateInLabel.Name = "DateInLabel";
            this.DateInLabel.Size = new System.Drawing.Size(178, 19);
            this.DateInLabel.TabIndex = 8;
            this.DateInLabel.Text = "Фильтр по дате прихода:";
            // 
            // DateInStartDTP
            // 
            this.DateInStartDTP.Location = new System.Drawing.Point(552, 27);
            this.DateInStartDTP.Name = "DateInStartDTP";
            this.DateInStartDTP.Size = new System.Drawing.Size(189, 27);
            this.DateInStartDTP.TabIndex = 7;
            this.DateInStartDTP.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateInStartDTP.ValueChanged += new System.EventHandler(this.SearchAndFilters_Changed);
            // 
            // WaitRepairCheckBox
            // 
            this.WaitRepairCheckBox.AutoSize = true;
            this.WaitRepairCheckBox.Location = new System.Drawing.Point(12, 70);
            this.WaitRepairCheckBox.Name = "WaitRepairCheckBox";
            this.WaitRepairCheckBox.Size = new System.Drawing.Size(179, 23);
            this.WaitRepairCheckBox.TabIndex = 6;
            this.WaitRepairCheckBox.Text = "Ожидающие ремонта";
            this.WaitRepairCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WaitRepairCheckBox.UseVisualStyleBackColor = true;
            this.WaitRepairCheckBox.CheckedChanged += new System.EventHandler(this.SearchAndFilters_Changed);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(433, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(86, 25);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.SearchAndFilters_Changed);
            // 
            // IssuedCheckBox
            // 
            this.IssuedCheckBox.AutoSize = true;
            this.IssuedCheckBox.Location = new System.Drawing.Point(417, 70);
            this.IssuedCheckBox.Name = "IssuedCheckBox";
            this.IssuedCheckBox.Size = new System.Drawing.Size(102, 23);
            this.IssuedCheckBox.TabIndex = 4;
            this.IssuedCheckBox.Text = "Выданные";
            this.IssuedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IssuedCheckBox.UseVisualStyleBackColor = true;
            this.IssuedCheckBox.CheckedChanged += new System.EventHandler(this.SearchAndFilters_Changed);
            // 
            // DiagnostedCheckBox
            // 
            this.DiagnostedCheckBox.AutoSize = true;
            this.DiagnostedCheckBox.Location = new System.Drawing.Point(197, 60);
            this.DiagnostedCheckBox.Name = "DiagnostedCheckBox";
            this.DiagnostedCheckBox.Size = new System.Drawing.Size(214, 42);
            this.DiagnostedCheckBox.TabIndex = 3;
            this.DiagnostedCheckBox.Text = "Диагностированные и/или\r\nотремонтированные";
            this.DiagnostedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiagnostedCheckBox.UseVisualStyleBackColor = true;
            this.DiagnostedCheckBox.CheckedChanged += new System.EventHandler(this.SearchAndFilters_Changed);
            // 
            // PrintActButton
            // 
            this.PrintActButton.Location = new System.Drawing.Point(747, 12);
            this.PrintActButton.Name = "PrintActButton";
            this.PrintActButton.Size = new System.Drawing.Size(115, 81);
            this.PrintActButton.TabIndex = 2;
            this.PrintActButton.Text = "Выбрать и оформить акт";
            this.PrintActButton.UseVisualStyleBackColor = true;
            this.PrintActButton.Click += new System.EventHandler(this.PrintActButton_Click);
            // 
            // SearchOrderLabel
            // 
            this.SearchOrderLabel.AutoSize = true;
            this.SearchOrderLabel.Location = new System.Drawing.Point(12, 5);
            this.SearchOrderLabel.Name = "SearchOrderLabel";
            this.SearchOrderLabel.Size = new System.Drawing.Size(134, 19);
            this.SearchOrderLabel.TabIndex = 1;
            this.SearchOrderLabel.Text = "Поиск по заказам:";
            // 
            // SearchOrderTextBox
            // 
            this.SearchOrderTextBox.Location = new System.Drawing.Point(12, 27);
            this.SearchOrderTextBox.Name = "SearchOrderTextBox";
            this.SearchOrderTextBox.Size = new System.Drawing.Size(507, 27);
            this.SearchOrderTextBox.TabIndex = 0;
            this.SearchOrderTextBox.TextChanged += new System.EventHandler(this.SearchAndFilters_Changed);
            // 
            // OrderListDGV
            // 
            this.OrderListDGV.AllowUserToAddRows = false;
            this.OrderListDGV.AllowUserToDeleteRows = false;
            this.OrderListDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderListDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderListDGV.Location = new System.Drawing.Point(0, 104);
            this.OrderListDGV.Margin = new System.Windows.Forms.Padding(4);
            this.OrderListDGV.MultiSelect = false;
            this.OrderListDGV.Name = "OrderListDGV";
            this.OrderListDGV.RowHeadersVisible = false;
            this.OrderListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderListDGV.Size = new System.Drawing.Size(1099, 608);
            this.OrderListDGV.TabIndex = 1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Excel Documents|*.xlsx";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 712);
            this.Controls.Add(this.OrderListDGV);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderList";
            this.ShowIcon = false;
            this.Text = "OrderList";
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button PrintActButton;
        private System.Windows.Forms.Label SearchOrderLabel;
        private System.Windows.Forms.TextBox SearchOrderTextBox;
        private System.Windows.Forms.DataGridView OrderListDGV;
        private System.Windows.Forms.CheckBox DiagnostedCheckBox;
        private System.Windows.Forms.CheckBox IssuedCheckBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.CheckBox WaitRepairCheckBox;
        private System.Windows.Forms.Label DateInLabel;
        private System.Windows.Forms.DateTimePicker DateInStartDTP;
        private System.Windows.Forms.Label UntilLabel;
        private System.Windows.Forms.Label AtLabel;
        private System.Windows.Forms.DateTimePicker DateInEndDTP;
        private System.Windows.Forms.Button PrintReportButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}