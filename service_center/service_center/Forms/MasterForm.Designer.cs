namespace service_center.Forms
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.ArticleTextBox = new System.Windows.Forms.TextBox();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.SearchOrderTextBox = new System.Windows.Forms.TextBox();
            this.SearchOrderLabel = new System.Windows.Forms.Label();
            this.OrderListDGV = new System.Windows.Forms.DataGridView();
            this.ConfirmStatusButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ActiveOrdersCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Location = new System.Drawing.Point(13, 13);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(103, 19);
            this.OrderIdLabel.TabIndex = 0;
            this.OrderIdLabel.Text = "Номер заказа";
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(13, 36);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.ReadOnly = true;
            this.OrderIdTextBox.Size = new System.Drawing.Size(437, 27);
            this.OrderIdTextBox.TabIndex = 1;
            // 
            // ArticleTextBox
            // 
            this.ArticleTextBox.Location = new System.Drawing.Point(13, 91);
            this.ArticleTextBox.Name = "ArticleTextBox";
            this.ArticleTextBox.ReadOnly = true;
            this.ArticleTextBox.Size = new System.Drawing.Size(437, 27);
            this.ArticleTextBox.TabIndex = 3;
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Location = new System.Drawing.Point(13, 68);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(62, 19);
            this.ArticleLabel.TabIndex = 2;
            this.ArticleLabel.Text = "Артикул";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(13, 207);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.ReadOnly = true;
            this.SerialNumberTextBox.Size = new System.Drawing.Size(437, 27);
            this.SerialNumberTextBox.TabIndex = 5;
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(13, 184);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(129, 19);
            this.SerialNumberLabel.TabIndex = 4;
            this.SerialNumberLabel.Text = "Серийный номер";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 243);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 19);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Статус";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(13, 265);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(437, 27);
            this.StatusComboBox.TabIndex = 7;
            // 
            // SearchOrderTextBox
            // 
            this.SearchOrderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchOrderTextBox.Location = new System.Drawing.Point(471, 36);
            this.SearchOrderTextBox.Name = "SearchOrderTextBox";
            this.SearchOrderTextBox.Size = new System.Drawing.Size(681, 27);
            this.SearchOrderTextBox.TabIndex = 9;
            this.SearchOrderTextBox.TextChanged += new System.EventHandler(this.SearchAndFilter_Changed);
            // 
            // SearchOrderLabel
            // 
            this.SearchOrderLabel.AutoSize = true;
            this.SearchOrderLabel.Location = new System.Drawing.Point(467, 9);
            this.SearchOrderLabel.Name = "SearchOrderLabel";
            this.SearchOrderLabel.Size = new System.Drawing.Size(54, 19);
            this.SearchOrderLabel.TabIndex = 8;
            this.SearchOrderLabel.Text = "Поиск:";
            // 
            // OrderListDGV
            // 
            this.OrderListDGV.AllowUserToAddRows = false;
            this.OrderListDGV.AllowUserToDeleteRows = false;
            this.OrderListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderListDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderListDGV.Location = new System.Drawing.Point(471, 99);
            this.OrderListDGV.Margin = new System.Windows.Forms.Padding(4);
            this.OrderListDGV.MultiSelect = false;
            this.OrderListDGV.Name = "OrderListDGV";
            this.OrderListDGV.RowHeadersVisible = false;
            this.OrderListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderListDGV.Size = new System.Drawing.Size(681, 443);
            this.OrderListDGV.TabIndex = 10;
            this.OrderListDGV.SelectionChanged += new System.EventHandler(this.OrderListDGV_SelectionChanged);
            // 
            // ConfirmStatusButton
            // 
            this.ConfirmStatusButton.Location = new System.Drawing.Point(176, 298);
            this.ConfirmStatusButton.Name = "ConfirmStatusButton";
            this.ConfirmStatusButton.Size = new System.Drawing.Size(133, 77);
            this.ConfirmStatusButton.TabIndex = 11;
            this.ConfirmStatusButton.Text = "Подтвердить статус";
            this.ConfirmStatusButton.UseVisualStyleBackColor = true;
            this.ConfirmStatusButton.Click += new System.EventHandler(this.ConfirmStatusButton_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(13, 147);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(437, 27);
            this.TitleTextBox.TabIndex = 13;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(13, 124);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(154, 19);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Название устройства";
            // 
            // ActiveOrdersCheckBox
            // 
            this.ActiveOrdersCheckBox.AutoSize = true;
            this.ActiveOrdersCheckBox.Location = new System.Drawing.Point(471, 69);
            this.ActiveOrdersCheckBox.Name = "ActiveOrdersCheckBox";
            this.ActiveOrdersCheckBox.Size = new System.Drawing.Size(147, 23);
            this.ActiveOrdersCheckBox.TabIndex = 14;
            this.ActiveOrdersCheckBox.Text = "Активные заказы";
            this.ActiveOrdersCheckBox.UseVisualStyleBackColor = true;
            this.ActiveOrdersCheckBox.CheckedChanged += new System.EventHandler(this.SearchAndFilter_Changed);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 555);
            this.Controls.Add(this.ActiveOrdersCheckBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ConfirmStatusButton);
            this.Controls.Add(this.OrderListDGV);
            this.Controls.Add(this.SearchOrderTextBox);
            this.Controls.Add(this.SearchOrderLabel);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.ArticleTextBox);
            this.Controls.Add(this.ArticleLabel);
            this.Controls.Add(this.OrderIdTextBox);
            this.Controls.Add(this.OrderIdLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MasterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.TextBox ArticleTextBox;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox SearchOrderTextBox;
        private System.Windows.Forms.Label SearchOrderLabel;
        private System.Windows.Forms.DataGridView OrderListDGV;
        private System.Windows.Forms.Button ConfirmStatusButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.CheckBox ActiveOrdersCheckBox;
    }
}