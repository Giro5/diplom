namespace service_center.Forms
{
    partial class ReceiverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiverForm));
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.PrintFormButton = new System.Windows.Forms.Button();
            this.OrderListButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.SideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.Controls.Add(this.PrintFormButton);
            this.SideBarPanel.Controls.Add(this.OrderListButton);
            this.SideBarPanel.Controls.Add(this.CreateOrderButton);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(181, 691);
            this.SideBarPanel.TabIndex = 1;
            // 
            // PrintFormButton
            // 
            this.PrintFormButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrintFormButton.FlatAppearance.BorderSize = 0;
            this.PrintFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintFormButton.Location = new System.Drawing.Point(0, 129);
            this.PrintFormButton.Name = "PrintFormButton";
            this.PrintFormButton.Size = new System.Drawing.Size(181, 57);
            this.PrintFormButton.TabIndex = 2;
            this.PrintFormButton.Tag = "2";
            this.PrintFormButton.Text = "Окно печати";
            this.PrintFormButton.UseVisualStyleBackColor = false;
            this.PrintFormButton.Visible = false;
            this.PrintFormButton.Click += new System.EventHandler(this.SideBarButton_Click);
            // 
            // OrderListButton
            // 
            this.OrderListButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OrderListButton.FlatAppearance.BorderSize = 0;
            this.OrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderListButton.Location = new System.Drawing.Point(0, 66);
            this.OrderListButton.Name = "OrderListButton";
            this.OrderListButton.Size = new System.Drawing.Size(181, 57);
            this.OrderListButton.TabIndex = 1;
            this.OrderListButton.Tag = "1";
            this.OrderListButton.Text = "Список заказов";
            this.OrderListButton.UseVisualStyleBackColor = false;
            this.OrderListButton.Click += new System.EventHandler(this.SideBarButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CreateOrderButton.FlatAppearance.BorderSize = 0;
            this.CreateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrderButton.Location = new System.Drawing.Point(0, 3);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(181, 57);
            this.CreateOrderButton.TabIndex = 0;
            this.CreateOrderButton.Tag = "0";
            this.CreateOrderButton.Text = "Создать заказ";
            this.CreateOrderButton.UseVisualStyleBackColor = false;
            this.CreateOrderButton.Click += new System.EventHandler(this.SideBarButton_Click);
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 691);
            this.Controls.Add(this.SideBarPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 730);
            this.Name = "ReceiverForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceiverForm_FormClosing);
            this.SideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Button PrintFormButton;
        private System.Windows.Forms.Button OrderListButton;
        private System.Windows.Forms.Button CreateOrderButton;
    }
}