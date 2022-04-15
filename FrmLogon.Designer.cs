﻿
namespace MyHW
{
    partial class FrmLogon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogon));
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(482, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "建立帳號 (&A)";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cancel.Location = new System.Drawing.Point(308, 204);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 28);
            this.Cancel.TabIndex = 28;
            this.Cancel.Text = "取消(&C)";
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OK.Location = new System.Drawing.Point(208, 204);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(94, 28);
            this.OK.TabIndex = 27;
            this.OK.Text = "確定(&O)";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PasswordTextBox.Location = new System.Drawing.Point(212, 146);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 27);
            this.PasswordTextBox.TabIndex = 26;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UsernameTextBox.Location = new System.Drawing.Point(212, 90);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(220, 27);
            this.UsernameTextBox.TabIndex = 24;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PasswordLabel.Location = new System.Drawing.Point(211, 126);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(220, 23);
            this.PasswordLabel.TabIndex = 25;
            this.PasswordLabel.Text = "密碼(&P)";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UsernameLabel.Location = new System.Drawing.Point(211, 70);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(220, 23);
            this.UsernameLabel.TabIndex = 22;
            this.UsernameLabel.Text = "使用者名稱(&U)";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(26, 39);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(165, 193);
            this.LogoPictureBox.TabIndex = 23;
            this.LogoPictureBox.TabStop = false;
            // 
            // FrmLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "FrmLogon";
            this.Text = "FrmLogon";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
    }
}