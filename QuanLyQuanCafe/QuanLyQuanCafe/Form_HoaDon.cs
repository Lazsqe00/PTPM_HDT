using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe
{
    public partial class Form_HoaDon : Form
    {
        private readonly Modify modify = new Modify();
        private readonly string maPhieu;
        private readonly string maThuNgan;
        private string maHoaDon; 

        public Form_HoaDon(string _maPhieu, string _maThuNgan = "TN01")
        {
            InitializeComponent();
            maPhieu = _maPhieu;
            maThuNgan = _maThuNgan;
            SinhMaHoaDon();
            LoadThongTinHoaDon();
        }

        private void SinhMaHoaDon()
        {
            maHoaDon = "HD" + DateTime.Now.ToString("ddMMyyyyHHmmss") + maThuNgan;
            lblMaHoaDon.Text = maHoaDon;
        }

        private void LoadThongTinHoaDon()
        {
            try
            {
                var phieu = modify.LayPhieuDatMon().FirstOrDefault(p => p.MaPhieu == maPhieu);
                if (phieu == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu đặt món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lblMaPhieu.Text = phieu.MaPhieu;
                lblNgayDat.Text = phieu.NgayDat.ToString("dd/MM/yyyy HH:mm");
                lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                lblThuNgan.Text = maThuNgan;
                lblNhanVienLap.Text = modify.LayTenNhanVien(phieu.MaNhanVien);
                lblTongTien.Text = string.Format("{0:N0} đ", phieu.TongTien);


                var chiTietList = modify.LayChiTietPhieu(maPhieu);
                var menuList = modify.LayMenu();

                var data = from ct in chiTietList
                           join m in menuList on ct.MaMon equals m.MaMon
                           select new
                           {
                               STT = chiTietList.IndexOf(ct) + 1,
                               TenMon = m.TenMon,
                               SoLuong = ct.SoLuong,
                               DonGia = ct.DonGia,
                               ThanhTien = ct.ThanhTien,
                               GhiChu = ct.GhiChu ?? ""
                           };

                dgvChiTiet.DataSource = data.ToList();

  
                dgvChiTiet.Columns["STT"]!.HeaderText = "STT";
                //dgvChiTiet.Columns["STT"]!.Width = 60;
                dgvChiTiet.Columns["TenMon"]!.HeaderText = "Tên Món";
                dgvChiTiet.Columns["SoLuong"]!.HeaderText = "SL";
                dgvChiTiet.Columns["DonGia"]!.HeaderText = "Đơn Giá";
                dgvChiTiet.Columns["ThanhTien"]!.HeaderText = "Thành Tiền";
                dgvChiTiet.Columns["GhiChu"]!.HeaderText = "Ghi Chú";

                dgvChiTiet.Columns["DonGia"]!.DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["ThanhTien"]!.DefaultCellStyle.Format = "N0";
                //dgvChiTiet.Columns["DonGia"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //dgvChiTiet.Columns["ThanhTien"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvChiTiet.Columns["SoLuong"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xác nhận lập hóa đơn {maHoaDon} cho phiếu {maPhieu}?", "Xác nhận lập hóa đơn",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string soHoaDon;
                if (modify.LapHoaDon(maPhieu, maThuNgan, out soHoaDon))
                {
                    MessageBox.Show($"Lập hóa đơn thành công!\nSố hóa đơn: {soHoaDon}", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lập hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}