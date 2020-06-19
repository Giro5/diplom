namespace service_center.Forms.FormsForReceiver
{
    partial class PrintForm
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
            this.ActReceiveButton = new System.Windows.Forms.Button();
            this.ActIssueButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ActReceiveRTB = new System.Windows.Forms.RichTextBox();
            this.ActIssueRTB = new System.Windows.Forms.RichTextBox();
            this.BackToFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActReceiveButton
            // 
            this.ActReceiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActReceiveButton.Location = new System.Drawing.Point(11, 321);
            this.ActReceiveButton.Margin = new System.Windows.Forms.Padding(4);
            this.ActReceiveButton.Name = "ActReceiveButton";
            this.ActReceiveButton.Size = new System.Drawing.Size(958, 35);
            this.ActReceiveButton.TabIndex = 1;
            this.ActReceiveButton.Text = "Сформировать акт приема";
            this.ActReceiveButton.UseVisualStyleBackColor = true;
            this.ActReceiveButton.Click += new System.EventHandler(this.ActReceiveButton_Click);
            // 
            // ActIssueButton
            // 
            this.ActIssueButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActIssueButton.Location = new System.Drawing.Point(13, 640);
            this.ActIssueButton.Margin = new System.Windows.Forms.Padding(4);
            this.ActIssueButton.Name = "ActIssueButton";
            this.ActIssueButton.Size = new System.Drawing.Size(958, 35);
            this.ActIssueButton.TabIndex = 2;
            this.ActIssueButton.Text = "Сформировать акт выдачи";
            this.ActIssueButton.UseVisualStyleBackColor = true;
            this.ActIssueButton.Click += new System.EventHandler(this.ActIssueButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Word Documents|*.docx";
            // 
            // ActReceiveRTB
            // 
            this.ActReceiveRTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActReceiveRTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActReceiveRTB.Location = new System.Drawing.Point(12, 44);
            this.ActReceiveRTB.Name = "ActReceiveRTB";
            this.ActReceiveRTB.ReadOnly = true;
            this.ActReceiveRTB.Size = new System.Drawing.Size(958, 270);
            this.ActReceiveRTB.TabIndex = 6;
            this.ActReceiveRTB.Text = "";
            // 
            // ActIssueRTB
            // 
            this.ActIssueRTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActIssueRTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActIssueRTB.Location = new System.Drawing.Point(12, 363);
            this.ActIssueRTB.Name = "ActIssueRTB";
            this.ActIssueRTB.ReadOnly = true;
            this.ActIssueRTB.Size = new System.Drawing.Size(958, 270);
            this.ActIssueRTB.TabIndex = 7;
            this.ActIssueRTB.Text = "";
            // 
            // BackToFormButton
            // 
            this.BackToFormButton.Location = new System.Drawing.Point(13, 6);
            this.BackToFormButton.Name = "BackToFormButton";
            this.BackToFormButton.Size = new System.Drawing.Size(75, 32);
            this.BackToFormButton.TabIndex = 8;
            this.BackToFormButton.Text = "Назад";
            this.BackToFormButton.UseVisualStyleBackColor = true;
            this.BackToFormButton.Click += new System.EventHandler(this.BackToFormButton_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 686);
            this.Controls.Add(this.BackToFormButton);
            this.Controls.Add(this.ActIssueRTB);
            this.Controls.Add(this.ActReceiveRTB);
            this.Controls.Add(this.ActIssueButton);
            this.Controls.Add(this.ActReceiveButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ActReceiveButton;
        private System.Windows.Forms.Button ActIssueButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox ActReceiveRTB;
        private System.Windows.Forms.RichTextBox ActIssueRTB;
        private System.Windows.Forms.Button BackToFormButton;
    }
}