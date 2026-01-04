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
            lblGhiChu = new Label();
            lblThanhTien = new Label();
            lblChonMon = new Label();
            lblDonGiaHienTai = new Label();
            txtMaPhieu = new TextBox();
            dtNgayDat = new DateTimePicker();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            txtTrangThai = new TextBox();
            txtThanhTien = new TextBox();
            txtGhiChu = new TextBox();
            cbTenMon = new ComboBox();
            numSoLuong = new NumericUpDown();
            btnThemMon = new Button();
            btnXoaMon = new Button();
            btnLuuPhieu = new Button();
            btnThoat = new Button();
            dgvChiTiet = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(324, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(529, 51);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "GIAO DIỆN PHIẾU ĐẶT MÓN";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(174, 101);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(74, 20);
            lblMaPhieu.TabIndex = 22;
            lblMaPhieu.Text = "Mã phiếu:";
            // 
            // lblNgayDat
            // 
            lblNgayDat.AutoSize = true;
            lblNgayDat.Location = new Point(174, 141);
            lblNgayDat.Name = "lblNgayDat";
            lblNgayDat.Size = new Size(73, 20);
            lblNgayDat.TabIndex = 21;
            lblNgayDat.Text = "Ngày đặt:";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(174, 181);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(114, 20);
            lblTenKH.TabIndex = 20;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(174, 221);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(118, 20);
            lblSDT.TabIndex = 19;
            lblSDT.Text = "SĐT khách hàng:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(174, 261);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 18;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(574, 712);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(61, 20);
            lblGhiChu.TabIndex = 3;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblThanhTien.Location = new Point(149, 708);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(169, 28);
            lblThanhTien.TabIndex = 5;
            lblThanhTien.Text = "Tổng thành tiền:";
            // 
            // lblChonMon
            // 
            lblChonMon.AutoSize = true;
            lblChonMon.Location = new Point(174, 311);
            lblChonMon.Name = "lblChonMon";
            lblChonMon.Size = new Size(80, 20);
            lblChonMon.TabIndex = 12;
            lblChonMon.Text = "Chọn món:";
            // 
            // lblDonGiaHienTai
            // 
            lblDonGiaHienTai.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDonGiaHienTai.ForeColor = Color.Red;
            lblDonGiaHienTai.Location = new Point(324, 359);
            lblDonGiaHienTai.Name = "lblDonGiaHienTai";
            lblDonGiaHienTai.Size = new Size(107, 30);
            lblDonGiaHienTai.TabIndex = 9;
            lblDonGiaHienTai.Text = "0 đ";
            lblDonGiaHienTai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(324, 97);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(400, 27);
            txtMaPhieu.TabIndex = 17;
            // 
            // dtNgayDat
            // 
            dtNgayDat.Location = new Point(324, 137);
            dtNgayDat.Name = "dtNgayDat";
            dtNgayDat.Size = new Size(400, 27);
            dtNgayDat.TabIndex = 16;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(324, 177);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(400, 27);
            txtTenKH.TabIndex = 15;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(324, 217);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(400, 27);
            txtSDT.TabIndex = 14;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(324, 257);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(400, 27);
            txtTrangThai.TabIndex = 13;
            txtTrangThai.Text = "Chờ xử lý";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtThanhTien.Location = new Point(324, 708);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(200, 34);
            txtThanhTien.TabIndex = 4;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(644, 708);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = ScrollBars.Vertical;
            txtGhiChu.Size = new Size(430, 100);
            txtGhiChu.TabIndex = 2;
            // 
            // cbTenMon
            // 
            cbTenMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenMon.Location = new Point(324, 307);
            cbTenMon.Name = "cbTenMon";
            cbTenMon.Size = new Size(300, 28);
            cbTenMon.TabIndex = 11;
            cbTenMon.SelectedIndexChanged += cbTenMon_SelectedIndexChanged;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(630, 309);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(100, 27);
            numSoLuong.TabIndex = 10;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(754, 305);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(100, 32);
            btnThemMon.TabIndex = 8;
            btnThemMon.Text = "Thêm món";
            btnThemMon.Click += btnThemMon_Click;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Location = new Point(841, 644);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(133, 43);
            btnXoaMon.TabIndex = 6;
            btnXoaMon.Text = "Xóa món";
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnLuuPhieu
            // 
            btnLuuPhieu.Location = new Point(824, 822);
            btnLuuPhieu.Name = "btnLuuPhieu";
            btnLuuPhieu.Size = new Size(120, 50);
            btnLuuPhieu.TabIndex = 1;
            btnLuuPhieu.Text = "Lưu phiếu";
            btnLuuPhieu.Click += btnLuuPhieu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(954, 822);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 50);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvChiTiet.Location = new Point(174, 418);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(800, 220);
            dgvChiTiet.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tên món";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Thành tiền";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 359);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 24;
            label1.Text = "Giá tiền";
            // 
            // Form_PhieuDatMon
            // 
            ClientSize = new Size(1187, 906);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnLuuPhieu);
            Controls.Add(txtGhiChu);
            Controls.Add(lblGhiChu);
            Controls.Add(txtThanhTien);
            Controls.Add(lblThanhTien);
            Controls.Add(btnXoaMon);
            Controls.Add(dgvChiTiet);
            Controls.Add(btnThemMon);
            Controls.Add(lblDonGiaHienTai);
            Controls.Add(numSoLuong);
            Controls.Add(cbTenMon);
            Controls.Add(lblChonMon);
            Controls.Add(txtTrangThai);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(dtNgayDat);
            Controls.Add(txtMaPhieu);
            Controls.Add(lblTrangThai);
            Controls.Add(lblSDT);
            Controls.Add(lblTenKH);
            Controls.Add(lblNgayDat);
            Controls.Add(lblMaPhieu);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_PhieuDatMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu đặt món";
            Load += Form_PhieuDatMon_Load;
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
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
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblChonMon;
        private System.Windows.Forms.Label lblDonGiaHienTai;

        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.NumericUpDown numSoLuong;

        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label1;
    }
}
