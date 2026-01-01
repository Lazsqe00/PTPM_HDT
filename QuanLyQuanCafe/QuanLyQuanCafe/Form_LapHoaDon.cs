using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe
{
    public partial class Form_LapHoaDon : Form
    {
        private readonly Modify modify = new Modify();
        private readonly string maThuNgan;

        public Form_LapHoaDon(string _maThuNgan = "TN01")
        {
            InitializeComponent();
            maThuNgan = _maThuNgan;
            LoadDanhSachPhieu();
        }

        private void LoadDanhSachPhieu()
        {
            try
            {
                var dsPhieu = modify.LayPhieuDatMon()
                    .Where(p => p.TrangThai != "Đã thanh toán") 
                    .Select(p => new
                    {
                        p.MaPhieu,
                        p.NgayDat,
                        p.TongTien,
                        p.TrangThai,
                        TenNhanVien = modify.LayTenNhanVien(p.MaNhanVien)
                    })
                    .OrderByDescending(p => p.NgayDat)
                    .ToList();

                dgvPhieu.DataSource = dsPhieu;

                dgvPhieu.Columns["MaPhieu"]!.HeaderText = "Mã Phiếu";
                dgvPhieu.Columns["NgayDat"]!.HeaderText = "Ngày Đặt";
                dgvPhieu.Columns["NgayDat"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvPhieu.Columns["TongTien"]!.HeaderText = "Tổng Tiền (đ)";
                dgvPhieu.Columns["TongTien"]!.DefaultCellStyle.Format = "N0";
                dgvPhieu.Columns["TongTien"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPhieu.Columns["TrangThai"]!.HeaderText = "Trạng Thái";
                dgvPhieu.Columns["TenNhanVien"]!.HeaderText = "Nhân Viên Lập";

                dgvPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phiếu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maPhieu = dgvPhieu.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();

                Form_HoaDon frm = new Form_HoaDon(maPhieu, maThuNgan);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDanhSachPhieu(); 
                }
            }
        }
    }
}