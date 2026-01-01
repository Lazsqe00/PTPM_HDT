using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    partial class Form_PhieuDatMon
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
            lblTitle = new Label();
            lblMaPhieu = new Label();
            lblNgayDat = new Label();
            lblTenKH = new Label();
            lblSDT = new Label();
            lblTrangThai = new Label();
            lblTenMon = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            lblThanhTien = new Label();
            lblGhiChu = new Label();
            txtMaPhieu = new TextBox();
            dtNgayDat = new DateTimePicker();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            txtTrangThai = new TextBox();
            cbTenMon = new ComboBox();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            txtThanhTien = new TextBox();
            txtGhiChu = new TextBox();
            btnLuuPhieu = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(362, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(567, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GIAO DIỆN PHIẾU ĐẶT MÓN";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(362, 139);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(74, 20);
            lblMaPhieu.TabIndex = 1;
            lblMaPhieu.Text = "Mã phiếu:";
            // 
            // lblNgayDat
            // 
            lblNgayDat.AutoSize = true;
            lblNgayDat.Location = new Point(362, 176);
            lblNgayDat.Name = "lblNgayDat";
            lblNgayDat.Size = new Size(73, 20);
            lblNgayDat.TabIndex = 2;
            lblNgayDat.Text = "Ngày đặt:";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(362, 213);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(114, 20);
            lblTenKH.TabIndex = 3;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(362, 251);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(118, 20);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "SĐT khách hàng:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(362, 289);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 5;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblTenMon
            // 
            lblTenMon.AutoSize = true;
            lblTenMon.Location = new Point(362, 326);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(69, 20);
            lblTenMon.TabIndex = 6;
            lblTenMon.Text = "Tên món:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(362, 363);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 7;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(362, 401);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(65, 20);
            lblDonGia.TabIndex = 8;
            lblDonGia.Text = "Đơn giá:";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(362, 439);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(81, 20);
            lblThanhTien.TabIndex = 9;
            lblThanhTien.Text = "Thành tiền:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(362, 476);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(61, 20);
            lblGhiChu.TabIndex = 10;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.ForeColor = SystemColors.HotTrack;
            txtMaPhieu.Location = new Point(492, 135);
            txtMaPhieu.Margin = new Padding(3, 4, 3, 4);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(389, 27);
            txtMaPhieu.TabIndex = 11;
            // 
            // dtNgayDat
            // 
            dtNgayDat.Location = new Point(492, 172);
            dtNgayDat.Margin = new Padding(3, 4, 3, 4);
            dtNgayDat.Name = "dtNgayDat";
            dtNgayDat.Size = new Size(389, 27);
            dtNgayDat.TabIndex = 12;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(492, 210);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(389, 27);
            txtTenKH.TabIndex = 13;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(492, 247);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(389, 27);
            txtSDT.TabIndex = 14;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(492, 285);
            txtTrangThai.Margin = new Padding(3, 4, 3, 4);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(389, 27);
            txtTrangThai.TabIndex = 15;
            txtTrangThai.Text = "Chờ xử lý";
            // 
            // cbTenMon
            // 
            cbTenMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenMon.FormattingEnabled = true;
            cbTenMon.Location = new Point(492, 322);
            cbTenMon.Margin = new Padding(3, 4, 3, 4);
            cbTenMon.Name = "cbTenMon";
            cbTenMon.Size = new Size(389, 28);
            cbTenMon.TabIndex = 16;
            cbTenMon.SelectedIndexChanged += cbTenMon_SelectedIndexChanged;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(492, 360);
            numSoLuong.Margin = new Padding(3, 4, 3, 4);
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(389, 27);
            numSoLuong.TabIndex = 17;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numDonGia
            // 
            numDonGia.Enabled = false;
            numDonGia.Location = new Point(492, 397);
            numDonGia.Margin = new Padding(3, 4, 3, 4);
            numDonGia.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(389, 27);
            numDonGia.TabIndex = 18;
            numDonGia.ThousandsSeparator = true;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(492, 435);
            txtThanhTien.Margin = new Padding(3, 4, 3, 4);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(389, 27);
            txtThanhTien.TabIndex = 19;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(492, 476);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = ScrollBars.Vertical;
            txtGhiChu.Size = new Size(389, 155);
            txtGhiChu.TabIndex = 20;
            // 
            // btnLuuPhieu
            // 
            btnLuuPhieu.BackColor = SystemColors.ActiveCaption;
            btnLuuPhieu.Location = new Point(650, 657);
            btnLuuPhieu.Margin = new Padding(3, 4, 3, 4);
            btnLuuPhieu.Name = "btnLuuPhieu";
            btnLuuPhieu.Size = new Size(114, 45);
            btnLuuPhieu.TabIndex = 22;
            btnLuuPhieu.Text = "Lưu phiếu";
            btnLuuPhieu.UseVisualStyleBackColor = false;
            btnLuuPhieu.Click += btnLuuPhieu_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.Control;
            btnThoat.Location = new Point(787, 657);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 45);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form_PhieuDatMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 728);
            Controls.Add(btnThoat);
            Controls.Add(btnLuuPhieu);
            Controls.Add(txtGhiChu);
            Controls.Add(txtThanhTien);
            Controls.Add(numDonGia);
            Controls.Add(numSoLuong);
            Controls.Add(cbTenMon);
            Controls.Add(txtTrangThai);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(dtNgayDat);
            Controls.Add(txtMaPhieu);
            Controls.Add(lblGhiChu);
            Controls.Add(lblThanhTien);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblTenMon);
            Controls.Add(lblTrangThai);
            Controls.Add(lblSDT);
            Controls.Add(lblTenKH);
            Controls.Add(lblNgayDat);
            Controls.Add(lblMaPhieu);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form_PhieuDatMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu đặt món";
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblGhiChu;

        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnThoat;
    }
}