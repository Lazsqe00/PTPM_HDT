using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Media;
using System.Windows.Forms;
using QuanLyQuanCafe.Models;

namespace QuanLyQuanCafe
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tbx_Username.Text.Trim();
            string password = tbx_Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Modify modifyUser = new Modify();
            NguoiDung User = modifyUser.DangNhap(username, password);

            if (User != null)
            {
                if(User.Role == 0)
                {
                    playAudio();
                    Form_ThongKeDoanhThu f = new Form_ThongKeDoanhThu();
                    this.Hide();
                    f.ShowDialog();
                }
                else if(User.Role == 1)
                {
                    playAudio();
                    Form_PhieuDatMon f = new Form_PhieuDatMon(User.MaNV);
                    this.Hide();
                    f.ShowDialog();
                    
                }
                else
                {
                    playAudio();
                    Form_LapHoaDon f = new Form_LapHoaDon(User.MaNV);
                    this.Hide();
                    f.ShowDialog();
                }
                this.Show();
                resetFields();
            }
            else
            {
                DialogResult dialog = MessageBox.Show(
                    "Đăng nhập không thành công! Bạn có muốn tiếp tục đăng nhập?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation
                );
                if (dialog == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }

        void resetFields()
        {
            tbx_Username.Text = "";
            tbx_Password.Text = "";
            tbx_Username.Focus();
        }
        private void lbl_Forget_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chức năng quên mật khẩu chưa được triển khai.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        void playAudio()
        {
            Stream audio = Properties.Resources.success;
            SoundPlayer player = new SoundPlayer(audio);
            player.Play();
        }
    }
}
