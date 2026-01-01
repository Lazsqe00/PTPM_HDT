using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    partial class Form_Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            lbl_Forget = new Label();
            btn_Login = new Button();
            panel3 = new Panel();
            tbx_Username = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            tbx_Password = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 272);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_Forget);
            panel4.Controls.Add(btn_Login);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(804, 141);
            panel4.TabIndex = 0;
            // 
            // lbl_Forget
            // 
            lbl_Forget.AutoSize = true;
            lbl_Forget.Cursor = Cursors.Hand;
            lbl_Forget.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            lbl_Forget.ForeColor = Color.DodgerBlue;
            lbl_Forget.Location = new Point(529, 12);
            lbl_Forget.Name = "lbl_Forget";
            lbl_Forget.Size = new Size(137, 23);
            lbl_Forget.TabIndex = 0;
            lbl_Forget.Text = "Quên mật khẩu?";
            lbl_Forget.Click += lbl_Forget_Click;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI Semibold", 12F);
            btn_Login.Location = new Point(323, 0);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(161, 42);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbx_Username);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(69, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 43);
            panel3.TabIndex = 1;
            // 
            // tbx_Username
            // 
            tbx_Username.Font = new Font("Microsoft Sans Serif", 12F);
            tbx_Username.Location = new Point(254, 10);
            tbx_Username.Name = "tbx_Username";
            tbx_Username.Size = new Size(263, 30);
            tbx_Username.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(87, 10);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbx_Password);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(69, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 43);
            panel2.TabIndex = 2;
            // 
            // tbx_Password
            // 
            tbx_Password.Font = new Font("Microsoft Sans Serif", 12F);
            tbx_Password.Location = new Point(254, 6);
            tbx_Password.Name = "tbx_Password";
            tbx_Password.PasswordChar = '*';
            tbx_Password.Size = new Size(263, 30);
            tbx_Password.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(111, 6);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu:";
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(804, 236);
            panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo4;
            pictureBox1.Location = new Point(314, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(804, 37);
            label1.TabIndex = 1;
            label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI ỨNG DỤNG QUẢN LÝ CỦA QUÁN dd/mm/yyyy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Login
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 499);
            Controls.Add(panel5);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbx_Username;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Forget;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
