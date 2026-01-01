using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Form_ThongKeDoanhThu : Form
    {
        private readonly Modify modify = new Modify();

        public Form_ThongKeDoanhThu()
        {
            InitializeComponent();
            CauHinhBanDau();
            ThongKeDoanhThu();
        }

        private void CauHinhBanDau()
        {
            cboLoaiThongKe.Items.AddRange(new string[] { "Theo Ngày", "Theo Tháng", "Theo Năm" });
            cboLoaiThongKe.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i);
            cboThang.SelectedItem = DateTime.Now.Month;

            int namHienTai = DateTime.Now.Year;
            for (int i = namHienTai - 5; i <= namHienTai + 1; i++)
                cboNam.Items.Add(i);
            cboNam.SelectedItem = namHienTai;

            CapNhatHienThiControl();
        }

        private void cboLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatHienThiControl();
            ThongKeDoanhThu();
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Chức năng xuất thống kê chưa được triển khai.",
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        }

        private void CapNhatHienThiControl()
        {
            string loai = cboLoaiThongKe.SelectedItem?.ToString() ?? "Theo Ngày";

            if (loai == "Theo Ngày")
            {
                dtpNgay.Visible = true;
                lblNgay.Visible = true;

                cboThang.Visible = false;
                lblThang.Visible = false;
                cboNam.Visible = false;
                lblNam.Visible = false;
            }
            else if (loai == "Theo Tháng")
            {
                dtpNgay.Visible = false;
                lblNgay.Visible = false;

                cboThang.Visible = true;
                lblThang.Visible = true;
                cboNam.Visible = true;
                lblNam.Visible = true;
            }
            else
            {
                dtpNgay.Visible = false;
                lblNgay.Visible = false;

                cboThang.Visible = false;
                lblThang.Visible = false;
                cboNam.Visible = true;
                lblNam.Visible = true;
            }

            if (cboThang.Visible && cboThang.SelectedItem == null)
                cboThang.SelectedItem = DateTime.Now.Month;

            if (cboNam.Visible && cboNam.SelectedItem == null)
                cboNam.SelectedItem = DateTime.Now.Year;
        }

        private void ThongKeDoanhThu()
        {
            try
            {
                DateTime tuNgay, denNgay;
                string loai = cboLoaiThongKe.SelectedItem?.ToString() ?? "Theo Ngày";

                if (loai == "Theo Ngày")
                {
                    DateTime ngay = dtpNgay.Value.Date;
                    tuNgay = ngay;
                    denNgay = ngay.AddDays(1).AddSeconds(-1);
                }
                else if (loai == "Theo Tháng")
                {
                    int thang = cboThang.SelectedItem != null ? (int)cboThang.SelectedItem : DateTime.Now.Month;
                    int nam = cboNam.SelectedItem != null ? (int)cboNam.SelectedItem : DateTime.Now.Year;

                    tuNgay = new DateTime(nam, thang, 1);
                    denNgay = tuNgay.AddMonths(1).AddSeconds(-1);
                }
                else
                {
                    int nam = cboNam.SelectedItem != null ? (int)cboNam.SelectedItem : DateTime.Now.Year;

                    tuNgay = new DateTime(nam, 1, 1);
                    denNgay = new DateTime(nam, 12, 31, 23, 59, 59);
                }

                DataTable dt = modify.ThongKeDoanhThuMon(tuNgay, denNgay);
                dgvThongKe.DataSource = dt;

                if (dt.Columns.Contains("tenMon"))
                {
                    dgvThongKe.Columns["tenMon"].HeaderText = "Tên Món";
                    dgvThongKe.Columns["SoLuongBan"].HeaderText = "Số Lượng Bán";
                    dgvThongKe.Columns["DoanhThu"].HeaderText = "Doanh Thu (đ)";
                }

                dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvThongKe.RowHeadersVisible = false;
                dgvThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                double tong = modify.TongDoanhThu(tuNgay, denNgay);
                lblTongDoanhThu.Text = $"TỔNG DOANH THU: {tong:N0} đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
