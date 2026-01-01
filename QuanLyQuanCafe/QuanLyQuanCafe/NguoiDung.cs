using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class NguoiDung
    {
        public int UserId { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public float LuongCoBan { get; set; }
        public int Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public NguoiDung(int userId, string maNV, string tenNV, string gioiTinh, DateTime? ngaySinh,
                    string soDienThoai, string email, string diaChi, float luongCoBan, int role,
                    string username, string password)
        {
            UserId = userId;
            MaNV = maNV ?? throw new ArgumentNullException(nameof(maNV));
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SoDienThoai = soDienThoai;
            Email = email;
            DiaChi = diaChi;
            LuongCoBan = luongCoBan;
            Role = role;
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public NguoiDung() { }

        public override string ToString()
        {
            return $"{TenNV} ({MaNV}) - {Username}";
        }
    }
}
