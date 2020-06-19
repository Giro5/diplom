namespace service_center.Forms.FormsForReceiver
{
    partial class CreateOrder
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
            this.components = new System.ComponentModel.Container();
            this.CatalogDGV = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.NameClientTextBox = new System.Windows.Forms.TextBox();
            this.NameClientLabel = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.DateCheckDTP = new System.Windows.Forms.DateTimePicker();
            this.DateCheckLabel = new System.Windows.Forms.Label();
            this.PhoneClientTextBox = new System.Windows.Forms.TextBox();
            this.PhoneClientLabel = new System.Windows.Forms.Label();
            this.SpendButton = new System.Windows.Forms.Button();
            this.ProductInfoTextBox = new System.Windows.Forms.TextBox();
            this.ProductInfoLabel = new System.Windows.Forms.Label();
            this.ExceptionNameLabel = new System.Windows.Forms.Label();
            this.ExceptionSerialLabel = new System.Windows.Forms.Label();
            this.ExceptionPhoneLabel = new System.Windows.Forms.Label();
            this.ToolTipSpendButton = new System.Windows.Forms.ToolTip(this.components);
            this.ExceptionEmptyLabel = new System.Windows.Forms.Label();
            this.ExceptionWarrantyLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogDGV
            // 
            this.CatalogDGV.AllowUserToAddRows = false;
            this.CatalogDGV.AllowUserToDeleteRows = false;
            this.CatalogDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CatalogDGV.BackgroundColor = System.Drawing.Color.White;
            this.CatalogDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CatalogDGV.Location = new System.Drawing.Point(16, 66);
            this.CatalogDGV.Margin = new System.Windows.Forms.Padding(4);
            this.CatalogDGV.MultiSelect = false;
            this.CatalogDGV.Name = "CatalogDGV";
            this.CatalogDGV.RowHeadersVisible = false;
            this.CatalogDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatalogDGV.Size = new System.Drawing.Size(539, 519);
            this.CatalogDGV.TabIndex = 0;
            this.CatalogDGV.SelectionChanged += new System.EventHandler(this.CatalogDGV_SelectionChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(13, 9);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(135, 19);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Поиск по товарам:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(17, 32);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(538, 27);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // NameClientTextBox
            // 
            this.NameClientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameClientTextBox.Location = new System.Drawing.Point(578, 164);
            this.NameClientTextBox.Name = "NameClientTextBox";
            this.NameClientTextBox.Size = new System.Drawing.Size(538, 27);
            this.NameClientTextBox.TabIndex = 4;
            this.NameClientTextBox.TextChanged += new System.EventHandler(this.InfoBoxes_TextChanged);
            // 
            // NameClientLabel
            // 
            this.NameClientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameClientLabel.AutoSize = true;
            this.NameClientLabel.Location = new System.Drawing.Point(574, 141);
            this.NameClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameClientLabel.Name = "NameClientLabel";
            this.NameClientLabel.Size = new System.Drawing.Size(104, 19);
            this.NameClientLabel.TabIndex = 3;
            this.NameClientLabel.Text = "ФИО клиента:";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialNumberTextBox.Location = new System.Drawing.Point(578, 292);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(538, 27);
            this.SerialNumberTextBox.TabIndex = 12;
            this.SerialNumberTextBox.TextChanged += new System.EventHandler(this.InfoBoxes_TextChanged);
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(574, 269);
            this.SerialNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(133, 19);
            this.SerialNumberLabel.TabIndex = 11;
            this.SerialNumberLabel.Text = "Серийный номер:";
            // 
            // DateCheckDTP
            // 
            this.DateCheckDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCheckDTP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateCheckDTP.Location = new System.Drawing.Point(578, 96);
            this.DateCheckDTP.Name = "DateCheckDTP";
            this.DateCheckDTP.Size = new System.Drawing.Size(538, 27);
            this.DateCheckDTP.TabIndex = 13;
            this.DateCheckDTP.Value = new System.DateTime(2020, 6, 7, 5, 21, 35, 0);
            this.DateCheckDTP.ValueChanged += new System.EventHandler(this.InfoBoxes_TextChanged);
            // 
            // DateCheckLabel
            // 
            this.DateCheckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCheckLabel.AutoSize = true;
            this.DateCheckLabel.Location = new System.Drawing.Point(574, 73);
            this.DateCheckLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateCheckLabel.Name = "DateCheckLabel";
            this.DateCheckLabel.Size = new System.Drawing.Size(157, 19);
            this.DateCheckLabel.TabIndex = 14;
            this.DateCheckLabel.Text = "Дата покупки по чеку:";
            // 
            // PhoneClientTextBox
            // 
            this.PhoneClientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneClientTextBox.Location = new System.Drawing.Point(578, 228);
            this.PhoneClientTextBox.Name = "PhoneClientTextBox";
            this.PhoneClientTextBox.Size = new System.Drawing.Size(538, 27);
            this.PhoneClientTextBox.TabIndex = 16;
            this.PhoneClientTextBox.TextChanged += new System.EventHandler(this.InfoBoxes_TextChanged);
            // 
            // PhoneClientLabel
            // 
            this.PhoneClientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneClientLabel.AutoSize = true;
            this.PhoneClientLabel.Location = new System.Drawing.Point(574, 205);
            this.PhoneClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneClientLabel.Name = "PhoneClientLabel";
            this.PhoneClientLabel.Size = new System.Drawing.Size(130, 19);
            this.PhoneClientLabel.TabIndex = 15;
            this.PhoneClientLabel.Text = "Телефон клиента:";
            // 
            // SpendButton
            // 
            this.SpendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpendButton.Location = new System.Drawing.Point(761, 362);
            this.SpendButton.Name = "SpendButton";
            this.SpendButton.Size = new System.Drawing.Size(154, 62);
            this.SpendButton.TabIndex = 17;
            this.SpendButton.Text = "Провести заказ";
            this.SpendButton.UseVisualStyleBackColor = true;
            this.SpendButton.Click += new System.EventHandler(this.SpendButton_Click);
            // 
            // ProductInfoTextBox
            // 
            this.ProductInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductInfoTextBox.Location = new System.Drawing.Point(578, 32);
            this.ProductInfoTextBox.Name = "ProductInfoTextBox";
            this.ProductInfoTextBox.ReadOnly = true;
            this.ProductInfoTextBox.Size = new System.Drawing.Size(538, 27);
            this.ProductInfoTextBox.TabIndex = 19;
            this.ProductInfoTextBox.TextChanged += new System.EventHandler(this.InfoBoxes_TextChanged);
            // 
            // ProductInfoLabel
            // 
            this.ProductInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductInfoLabel.AutoSize = true;
            this.ProductInfoLabel.Location = new System.Drawing.Point(574, 9);
            this.ProductInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductInfoLabel.Name = "ProductInfoLabel";
            this.ProductInfoLabel.Size = new System.Drawing.Size(138, 19);
            this.ProductInfoLabel.TabIndex = 18;
            this.ProductInfoLabel.Text = "Выбранный товар:";
            // 
            // ExceptionNameLabel
            // 
            this.ExceptionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExceptionNameLabel.AutoSize = true;
            this.ExceptionNameLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionNameLabel.Location = new System.Drawing.Point(768, 141);
            this.ExceptionNameLabel.Name = "ExceptionNameLabel";
            this.ExceptionNameLabel.Size = new System.Drawing.Size(348, 19);
            this.ExceptionNameLabel.TabIndex = 20;
            this.ExceptionNameLabel.Text = "В этом поле должен быть минимум один пробел";
            this.ExceptionNameLabel.Visible = false;
            // 
            // ExceptionSerialLabel
            // 
            this.ExceptionSerialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExceptionSerialLabel.AutoSize = true;
            this.ExceptionSerialLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionSerialLabel.Location = new System.Drawing.Point(862, 269);
            this.ExceptionSerialLabel.Name = "ExceptionSerialLabel";
            this.ExceptionSerialLabel.Size = new System.Drawing.Size(254, 19);
            this.ExceptionSerialLabel.TabIndex = 21;
            this.ExceptionSerialLabel.Text = "Это поле должно быть уникальным";
            this.ExceptionSerialLabel.Visible = false;
            // 
            // ExceptionPhoneLabel
            // 
            this.ExceptionPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExceptionPhoneLabel.AutoSize = true;
            this.ExceptionPhoneLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionPhoneLabel.Location = new System.Drawing.Point(770, 205);
            this.ExceptionPhoneLabel.Name = "ExceptionPhoneLabel";
            this.ExceptionPhoneLabel.Size = new System.Drawing.Size(346, 19);
            this.ExceptionPhoneLabel.TabIndex = 22;
            this.ExceptionPhoneLabel.Text = "В этом поле должно быть минимум десять цифр";
            this.ExceptionPhoneLabel.Visible = false;
            // 
            // ToolTipSpendButton
            // 
            this.ToolTipSpendButton.ShowAlways = true;
            // 
            // ExceptionEmptyLabel
            // 
            this.ExceptionEmptyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExceptionEmptyLabel.AutoSize = true;
            this.ExceptionEmptyLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionEmptyLabel.Location = new System.Drawing.Point(732, 340);
            this.ExceptionEmptyLabel.Name = "ExceptionEmptyLabel";
            this.ExceptionEmptyLabel.Size = new System.Drawing.Size(214, 19);
            this.ExceptionEmptyLabel.TabIndex = 23;
            this.ExceptionEmptyLabel.Text = "Заполните все поля данными";
            this.ExceptionEmptyLabel.Visible = false;
            // 
            // ExceptionWarrantyLable
            // 
            this.ExceptionWarrantyLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExceptionWarrantyLable.AutoSize = true;
            this.ExceptionWarrantyLable.ForeColor = System.Drawing.Color.Red;
            this.ExceptionWarrantyLable.Location = new System.Drawing.Point(954, 74);
            this.ExceptionWarrantyLable.Name = "ExceptionWarrantyLable";
            this.ExceptionWarrantyLable.Size = new System.Drawing.Size(162, 19);
            this.ExceptionWarrantyLable.TabIndex = 24;
            this.ExceptionWarrantyLable.Text = "Гарантия закончилась";
            this.ExceptionWarrantyLable.Visible = false;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 598);
            this.Controls.Add(this.ExceptionWarrantyLable);
            this.Controls.Add(this.ExceptionEmptyLabel);
            this.Controls.Add(this.ExceptionPhoneLabel);
            this.Controls.Add(this.ExceptionSerialLabel);
            this.Controls.Add(this.ExceptionNameLabel);
            this.Controls.Add(this.ProductInfoTextBox);
            this.Controls.Add(this.ProductInfoLabel);
            this.Controls.Add(this.SpendButton);
            this.Controls.Add(this.PhoneClientTextBox);
            this.Controls.Add(this.PhoneClientLabel);
            this.Controls.Add(this.DateCheckLabel);
            this.Controls.Add(this.DateCheckDTP);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.NameClientTextBox);
            this.Controls.Add(this.NameClientLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.CatalogDGV);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateOrder";
            this.ShowIcon = false;
            this.Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.CatalogDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CatalogDGV;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox NameClientTextBox;
        private System.Windows.Forms.Label NameClientLabel;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.DateTimePicker DateCheckDTP;
        private System.Windows.Forms.Label DateCheckLabel;
        private System.Windows.Forms.TextBox PhoneClientTextBox;
        private System.Windows.Forms.Label PhoneClientLabel;
        private System.Windows.Forms.Button SpendButton;
        private System.Windows.Forms.TextBox ProductInfoTextBox;
        private System.Windows.Forms.Label ProductInfoLabel;
        private System.Windows.Forms.Label ExceptionNameLabel;
        private System.Windows.Forms.Label ExceptionSerialLabel;
        private System.Windows.Forms.Label ExceptionPhoneLabel;
        private System.Windows.Forms.ToolTip ToolTipSpendButton;
        private System.Windows.Forms.Label ExceptionEmptyLabel;
        private System.Windows.Forms.Label ExceptionWarrantyLable;
    }
}