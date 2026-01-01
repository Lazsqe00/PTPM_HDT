namespace QuanLyQuanCafe
{
    partial class Form_ThongKeDoanhThu
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

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblLoai = new Label();
            cboLoaiThongKe = new ComboBox();
            lblNgay = new Label();
            dtpNgay = new DateTimePicker();
            lblThang = new Label();
            cboThang = new ComboBox();
            lblNam = new Label();
            cboNam = new ComboBox();
            btnThongKe = new Button();
            dgvThongKe = new DataGridView();
            lblTongDoanhThu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(429, 32);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(371, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THỐNG KÊ DOANH THU";
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Font = new Font("Microsoft Sans Serif", 10F);
            lblLoai.Location = new Point(40, 123);
            lblLoai.Margin = new Padding(4, 0, 4, 0);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(119, 20);
            lblLoai.TabIndex = 11;
            lblLoai.Text = "Thống kê theo:";
            // 
            // cboLoaiThongKe
            // 
            cboLoaiThongKe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiThongKe.Location = new Point(187, 118);
            cboLoaiThongKe.Margin = new Padding(4, 5, 4, 5);
            cboLoaiThongKe.Name = "cboLoaiThongKe";
            cboLoaiThongKe.Size = new Size(199, 28);
            cboLoaiThongKe.TabIndex = 1;
            cboLoaiThongKe.SelectedIndexChanged += cboLoaiThongKe_SelectedIndexChanged;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Microsoft Sans Serif", 10F);
            lblNgay.Location = new Point(429, 121);
            lblNgay.Margin = new Padding(4, 0, 4, 0);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(93, 20);
            lblNgay.TabIndex = 10;
            lblNgay.Text = "Chọn ngày:";
            // 
            // dtpNgay
            // 
            dtpNgay.Format = DateTimePickerFormat.Short;
            dtpNgay.Location = new Point(530, 119);
            dtpNgay.Margin = new Padding(4, 5, 4, 5);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(159, 27);
            dtpNgay.TabIndex = 2;
            dtpNgay.ValueChanged += dtpNgay_ValueChanged;
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Font = new Font("Microsoft Sans Serif", 10F);
            lblThang.Location = new Point(442, 121);
            lblThang.Margin = new Padding(4, 0, 4, 0);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(60, 20);
            lblThang.TabIndex = 9;
            lblThang.Text = "Tháng:";
            // 
            // cboThang
            // 
            cboThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThang.Location = new Point(519, 118);
            cboThang.Margin = new Padding(4, 5, 4, 5);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(92, 28);
            cboThang.TabIndex = 3;
            cboThang.SelectedIndexChanged += cboThang_SelectedIndexChanged;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Font = new Font("Microsoft Sans Serif", 10F);
            lblNam.Location = new Point(640, 121);
            lblNam.Margin = new Padding(4, 0, 4, 0);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(49, 20);
            lblNam.TabIndex = 8;
            lblNam.Text = "Năm:";
            // 
            // cboNam
            // 
            cboNam.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNam.Location = new Point(697, 118);
            cboNam.Margin = new Padding(4, 5, 4, 5);
            cboNam.Name = "cboNam";
            cboNam.Size = new Size(132, 28);
            cboNam.TabIndex = 4;
            cboNam.SelectedIndexChanged += cboNam_SelectedIndexChanged;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.RoyalBlue;
            btnThongKe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(961, 780);
            btnThongKe.Margin = new Padding(4, 5, 4, 5);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(160, 54);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Xuất Thông Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dgvThongKe
            // 
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.AllowUserToDeleteRows = false;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(40, 185);
            dgvThongKe.Margin = new Padding(4, 5, 4, 5);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.ReadOnly = true;
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.RowTemplate.Height = 30;
            dgvThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKe.Size = new Size(1120, 585);
            dgvThongKe.TabIndex = 6;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTongDoanhThu.ForeColor = Color.Green;
            lblTongDoanhThu.Location = new Point(40, 800);
            lblTongDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(296, 29);
            lblTongDoanhThu.TabIndex = 7;
            lblTongDoanhThu.Text = "TỔNG DOANH THU: 0 đ";
            // 
            // Form_ThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 862);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(dgvThongKe);
            Controls.Add(btnThongKe);
            Controls.Add(cboNam);
            Controls.Add(lblNam);
            Controls.Add(cboThang);
            Controls.Add(lblThang);
            Controls.Add(dtpNgay);
            Controls.Add(lblNgay);
            Controls.Add(cboLoaiThongKe);
            Controls.Add(lblLoai);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form_ThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoaiThongKe;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label lblTongDoanhThu;
    }
}