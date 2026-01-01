using System;
using System.Windows.Forms;
using QuanLyQuanCafe.Models;
using System.Collections.Generic;

namespace QuanLyQuanCafe
{
    public partial class Form_PhieuDatMon : Form
    {
        private string maNhanVien;
        private Modify modify = new Modify();

        public Form_PhieuDatMon(string maNV)
        {
            InitializeComponent();
            maNhanVien = maNV;
            SinhMaPhieu();
            LoadMenu();
            numSoLuong.ValueChanged += TinhThanhTien;
            numDonGia.ValueChanged += TinhThanhTien;
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
                numDonGia.Value = (decimal)ds[0].Gia;
        }

        private void TinhThanhTien(object sender, EventArgs e)
        {
            decimal soLuong = numSoLuong.Value;
            decimal donGia = numDonGia.Value;
            decimal thanhTien = soLuong * donGia;
            txtThanhTien.Text = thanhTien.ToString("#,##0") + " đ";
        }

        private void cbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenMon.SelectedItem is Menu mon)
                numDonGia.Value = (decimal)mon.Gia;

            TinhThanhTien(null, null);
        }

        private bool KiemTraToanSo(string chuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoi))
                return false;

            foreach (char c in chuoi)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                cbTenMon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !KiemTraToanSo(sdt))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số và chỉ chứa số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PhieuDatMon phieu = new PhieuDatMon(
                txtMaPhieu.Text,
                dtNgayDat.Value,
                (float)(numSoLuong.Value * numDonGia.Value),
                txtTrangThai.Text,
                maNhanVien
            );

            ChiTietPhieu ct = new ChiTietPhieu(
                txtMaPhieu.Text,
                (cbTenMon.SelectedItem as Menu).MaMon,
                (int)numSoLuong.Value,
                (float)numDonGia.Value,
                (float)(numSoLuong.Value * numDonGia.Value),
                txtGhiChu.Text
            );

            if (modify.LuuPhieu(phieu, ct))
            {
                MessageBox.Show("Lưu phiếu đặt món thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SinhMaPhieu();
                numSoLuong.Value = 1;
                txtGhiChu.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
