using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe
{
    public partial class Form_PhieuDatMon : Form
    {
        private string maNhanVien;
        private Modify modify = new Modify();
        private List<ChiTietPhieuTemp> danhSachChiTiet = new List<ChiTietPhieuTemp>();

        public Form_PhieuDatMon(string maNV)
        {
            InitializeComponent();
            maNhanVien = maNV;
        }

        private void Form_PhieuDatMon_Load(object sender, EventArgs e)
        {
            SinhMaPhieu();
            LoadMenu();
            CapNhatTongTien();
        }

        private void SinhMaPhieu()
        {
            DateTime now = DateTime.Now;
            string maPhieu = "PD" + now.ToString("ddMMyyyyHHmmss") + maNhanVien;
            txtMaPhieu.Text = maPhieu;
        }

        private void LoadMenu()
        {
            List<Menu> ds = modify.LayMenu();
            cbTenMon.DataSource = ds;
            cbTenMon.DisplayMember = "TenMon";
            cbTenMon.ValueMember = "MaMon";

            if (ds.Count > 0)
            {
                lblDonGiaHienTai.Text = ds[0].Gia.ToString("#,##0") + " đ";
            }
        }

        private void cbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenMon.SelectedItem is Menu mon)
            {
                lblDonGiaHienTai.Text = mon.Gia.ToString("#,##0") + " đ";
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cbTenMon.SelectedIndex == -1) return;

            Menu mon = cbTenMon.SelectedItem as Menu;
            int soLuong = (int)numSoLuong.Value;

            var existing = danhSachChiTiet.FirstOrDefault(x => x.MaMon == mon.MaMon);
            if (existing != null)
            {
                existing.SoLuong += soLuong;
                existing.ThanhTien = existing.SoLuong * existing.DonGia;
            }
            else
            {
                danhSachChiTiet.Add(new ChiTietPhieuTemp
                {
                    MaMon = mon.MaMon,
                    TenMon = mon.TenMon,
                    SoLuong = soLuong,
                    DonGia = (float)mon.Gia,
                    ThanhTien = soLuong * (float)mon.Gia
                });
            }

            CapNhatDataGridView();
            CapNhatTongTien();
            numSoLuong.Value = 1;
        }

        private void CapNhatDataGridView()
        {
            dgvChiTiet.Rows.Clear();
            foreach (var ct in danhSachChiTiet)
            {
                dgvChiTiet.Rows.Add(ct.TenMon, ct.SoLuong, ct.DonGia.ToString("#,##0"), ct.ThanhTien.ToString("#,##0"));
            }
        }

        private void CapNhatTongTien()
        {
            float tong = danhSachChiTiet.Sum(x => x.ThanhTien);
            txtThanhTien.Text = tong.ToString("#,##0") + " đ";
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow != null && dgvChiTiet.CurrentRow.Index >= 0)
            {
                int index = dgvChiTiet.CurrentRow.Index;
                danhSachChiTiet.RemoveAt(index);
                CapNhatDataGridView();
                CapNhatTongTien();
            }
        }

        private bool KiemTraToanSo(string chuoi)
        {
            return !string.IsNullOrWhiteSpace(chuoi) && chuoi.All(char.IsDigit);
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !KiemTraToanSo(sdt))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số và chỉ chứa số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (danhSachChiTiet.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một món vào phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float tongTien = danhSachChiTiet.Sum(x => x.ThanhTien);

            PhieuDatMon phieu = new PhieuDatMon(
                txtMaPhieu.Text,
                dtNgayDat.Value,
                tongTien,
                txtTrangThai.Text,
                maNhanVien
            );

            List<ChiTietPhieu> dsChiTiet = danhSachChiTiet.Select(ct => new ChiTietPhieu(
                txtMaPhieu.Text,
                ct.MaMon,
                ct.SoLuong,
                ct.DonGia,
                ct.ThanhTien,
                txtGhiChu.Text
            )).ToList();

            if (modify.LuuPhieu(phieu, dsChiTiet))
            {
                MessageBox.Show("Lưu phiếu đặt món thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Lưu phiếu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset()
        {
            txtTenKH.Clear();
            txtSDT.Clear();
            txtGhiChu.Clear();
            danhSachChiTiet.Clear();
            CapNhatDataGridView();
            CapNhatTongTien();
            SinhMaPhieu();
            numSoLuong.Value = 1;
            txtTenKH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    internal class ChiTietPhieuTemp
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
    }
}
