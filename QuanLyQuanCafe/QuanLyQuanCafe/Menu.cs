using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class Menu
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public string LoaiMon { get; set; }
        public float Gia { get; set; }
        public string DonViTinh { get; set; }
        public string MoTa { get; set; }

   
        public Menu(string maMon, string tenMon, string loaiMon, float gia, string donViTinh, string moTa)
        {
            MaMon = maMon;
            TenMon = tenMon;
            LoaiMon = loaiMon;
            Gia = gia;
            DonViTinh = donViTinh;
            MoTa = moTa;
        }

        public Menu() { }
    }
}
