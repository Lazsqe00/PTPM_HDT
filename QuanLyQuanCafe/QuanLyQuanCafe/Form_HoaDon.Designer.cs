using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    partial class Form_HoaDon
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
            lblMaHoaDonText = new Label();
            lblMaHoaDon = new Label();
            lblMaPhieuText = new Label();
            lblMaPhieu = new Label();
            lblNgayLapText = new Label();
            lblNgayLap = new Label();
            lblNgayDatText = new Label();
            lblNgayDat = new Label();
            lblThuNganText = new Label();
            lblThuNgan = new Label();
            lblNhanVienLapText = new Label();
            lblNhanVienLap = new Label();
            lblTongTienText = new Label();
            lblTongTien = new Label();
            dgvChiTiet = new DataGridView();
            btnLapHoaDon = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(27, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(372, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // lblMaHoaDonText
            // 
            lblMaHoaDonText.AutoSize = true;
            lblMaHoaDonText.Font = new Font("Microsoft Sans Serif", 11F);
            lblMaHoaDonText.Location = new Point(40, 108);
            lblMaHoaDonText.Margin = new Padding(4, 0, 4, 0);
            lblMaHoaDonText.Name = "lblMaHoaDonText";
            lblMaHoaDonText.Size = new Size(114, 24);
            lblMaHoaDonText.TabIndex = 30;
            lblMaHoaDonText.Text = "Số hóa đơn:";
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblMaHoaDon.ForeColor = Color.Blue;
            lblMaHoaDon.Location = new Point(200, 108);
            lblMaHoaDon.Margin = new Padding(4, 0, 4, 0);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(57, 24);
            lblMaHoaDon.TabIndex = 29;
            lblMaHoaDon.Text = "HD...";
            // 
            // lblMaPhieuText
            // 
            lblMaPhieuText.AutoSize = true;
            lblMaPhieuText.Font = new Font("Microsoft Sans Serif", 10F);
            lblMaPhieuText.Location = new Point(40, 154);
            lblMaPhieuText.Margin = new Padding(4, 0, 4, 0);
            lblMaPhieuText.Name = "lblMaPhieuText";
            lblMaPhieuText.Size = new Size(110, 20);
            lblMaPhieuText.TabIndex = 28;
            lblMaPhieuText.Text = "Mã phiếu đặt:";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Font = new Font("Microsoft Sans Serif", 10F);
            lblMaPhieu.Location = new Point(200, 154);
            lblMaPhieu.Margin = new Padding(4, 0, 4, 0);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(21, 20);
            lblMaPhieu.TabIndex = 27;
            lblMaPhieu.Text = "...";
            // 
            // lblNgayLapText
            // 
            lblNgayLapText.AutoSize = true;
            lblNgayLapText.Font = new Font("Microsoft Sans Serif", 10F);
            lblNgayLapText.Location = new Point(533, 108);
            lblNgayLapText.Margin = new Padding(4, 0, 4, 0);
            lblNgayLapText.Name = "lblNgayLapText";
            lblNgayLapText.Size = new Size(110, 20);
            lblNgayLapText.TabIndex = 26;
            lblNgayLapText.Text = "Ngày lập HD:";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Microsoft Sans Serif", 10F);
            lblNgayLap.Location = new Point(693, 108);
            lblNgayLap.Margin = new Padding(4, 0, 4, 0);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(21, 20);
            lblNgayLap.TabIndex = 25;
            lblNgayLap.Text = "...";
            // 
            // lblNgayDatText
            // 
            lblNgayDatText.AutoSize = true;
            lblNgayDatText.Font = new Font("Microsoft Sans Serif", 10F);
            lblNgayDatText.Location = new Point(533, 154);
            lblNgayDatText.Margin = new Padding(4, 0, 4, 0);
            lblNgayDatText.Name = "lblNgayDatText";
            lblNgayDatText.Size = new Size(117, 20);
            lblNgayDatText.TabIndex = 24;
            lblNgayDatText.Text = "Ngày đặt món:";
            // 
            // lblNgayDat
            // 
            lblNgayDat.AutoSize = true;
            lblNgayDat.Font = new Font("Microsoft Sans Serif", 10F);
            lblNgayDat.Location = new Point(693, 154);
            lblNgayDat.Margin = new Padding(4, 0, 4, 0);
            lblNgayDat.Name = "lblNgayDat";
            lblNgayDat.Size = new Size(21, 20);
            lblNgayDat.TabIndex = 23;
            lblNgayDat.Text = "...";
            // 
            // lblThuNganText
            // 
            lblThuNganText.AutoSize = true;
            lblThuNganText.Font = new Font("Microsoft Sans Serif", 10F);
            lblThuNganText.Location = new Point(40, 200);
            lblThuNganText.Margin = new Padding(4, 0, 4, 0);
            lblThuNganText.Name = "lblThuNganText";
            lblThuNganText.Size = new Size(83, 20);
            lblThuNganText.TabIndex = 22;
            lblThuNganText.Text = "Thu ngân:";
            // 
            // lblThuNgan
            // 
            lblThuNgan.AutoSize = true;
            lblThuNgan.Font = new Font("Microsoft Sans Serif", 10F);
            lblThuNgan.Location = new Point(200, 200);
            lblThuNgan.Margin = new Padding(4, 0, 4, 0);
            lblThuNgan.Name = "lblThuNgan";
            lblThuNgan.Size = new Size(21, 20);
            lblThuNgan.TabIndex = 21;
            lblThuNgan.Text = "...";
            // 
            // lblNhanVienLapText
            // 
            lblNhanVienLapText.AutoSize = true;
            lblNhanVienLapText.Font = new Font("Microsoft Sans Serif", 10F);
            lblNhanVienLapText.Location = new Point(533, 200);
            lblNhanVienLapText.Margin = new Padding(4, 0, 4, 0);
            lblNhanVienLapText.Name = "lblNhanVienLapText";
            lblNhanVienLapText.Size = new Size(160, 20);
            lblNhanVienLapText.TabIndex = 20;
            lblNhanVienLapText.Text = "Nhân viên lập phiếu:";
            // 
            // lblNhanVienLap
            // 
            lblNhanVienLap.AutoSize = true;
            lblNhanVienLap.Font = new Font("Microsoft Sans Serif", 10F);
            lblNhanVienLap.Location = new Point(760, 200);
            lblNhanVienLap.Margin = new Padding(4, 0, 4, 0);
            lblNhanVienLap.Name = "lblNhanVienLap";
            lblNhanVienLap.Size = new Size(21, 20);
            lblNhanVienLap.TabIndex = 19;
            lblNhanVienLap.Text = "...";
            // 
            // lblTongTienText
            // 
            lblTongTienText.AutoSize = true;
            lblTongTienText.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTongTienText.Location = new Point(667, 262);
            lblTongTienText.Margin = new Padding(4, 0, 4, 0);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(162, 29);
            lblTongTienText.TabIndex = 18;
            lblTongTienText.Text = "TỔNG TIỀN:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(840, 258);
            lblTongTien.Margin = new Padding(4, 0, 4, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(54, 31);
            lblTongTien.TabIndex = 17;
            lblTongTien.Text = "0 đ";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(40, 323);
            dgvChiTiet.Margin = new Padding(4, 5, 4, 5);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 30;
            dgvChiTiet.Size = new Size(1122, 431);
            dgvChiTiet.TabIndex = 14;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ScrollBars = ScrollBars.Both;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.BackColor = Color.Green;
            btnLapHoaDon.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Location = new Point(803, 785);
            btnLapHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(146, 64);
            btnLapHoaDon.TabIndex = 15;
            btnLapHoaDon.Text = "Lập Hóa Đơn";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.IndianRed;
            btnHuy.Font = new Font("Microsoft Sans Serif", 10F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(987, 785);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(139, 64);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // Form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 892);
            Controls.Add(btnHuy);
            Controls.Add(btnLapHoaDon);
            Controls.Add(dgvChiTiet);
            Controls.Add(lblTongTien);
            Controls.Add(lblTongTienText);
            Controls.Add(lblNhanVienLap);
            Controls.Add(lblNhanVienLapText);
            Controls.Add(lblThuNgan);
            Controls.Add(lblThuNganText);
            Controls.Add(lblNgayDat);
            Controls.Add(lblNgayDatText);
            Controls.Add(lblNgayLap);
            Controls.Add(lblNgayLapText);
            Controls.Add(lblMaPhieu);
            Controls.Add(lblMaPhieuText);
            Controls.Add(lblMaHoaDon);
            Controls.Add(lblMaHoaDonText);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form_HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaHoaDonText;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblMaPhieuText;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblNgayLapText;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblNgayDatText;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblThuNganText;
        private System.Windows.Forms.Label lblThuNgan;
        private System.Windows.Forms.Label lblNhanVienLapText;
        private System.Windows.Forms.Label lblNhanVienLap;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnHuy;
    }
}