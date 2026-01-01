using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    internal class PhieuDatMon
    {
        public string MaPhieu { get; set; }
        public DateTime NgayDat { get; set; }
        public double TongTien { get; set; }  
        public string TrangThai { get; set; }
        public string MaNhanVien { get; set; }

        public PhieuDatMon(string ma, DateTime ngay, double tong, string tt, string nv) 
        {
            MaPhieu = ma;
            NgayDat = ngay;
            TongTien = tong;
            TrangThai = tt;
            MaNhanVien = nv;
        }
    }

    internal class ChiTietPhieu
    {
        public string MaPhieu { get; set; }
        public string MaMon { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }      
        public double ThanhTien { get; set; }   
        public string GhiChu { get; set; }

        public ChiTietPhieu(string maPhieu, string maMon, int sl, double dg, double tt, string gc) 
        {
            MaPhieu = maPhieu;
            MaMon = maMon;
            SoLuong = sl;
            DonGia = dg;
            ThanhTien = tt;
            GhiChu = gc;
        }
    }
}
