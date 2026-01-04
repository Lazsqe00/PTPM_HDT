using Microsoft.Data.SqlClient;
using QuanLyQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    internal class Modify
    {
        public NguoiDung DangNhap(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE username=@u AND password=@p";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new NguoiDung
                                {
                                    UserId = reader.GetInt32(reader.GetOrdinal("userId")),
                                    MaNV = reader.GetString(reader.GetOrdinal("maNV")),
                                    TenNV = reader.GetString(reader.GetOrdinal("tenNV")),
                                    GioiTinh = reader.GetString(reader.GetOrdinal("gioiTinh")),
                                    NgaySinh = reader.IsDBNull(reader.GetOrdinal("ngaySinh")) ? null : reader.GetDateTime(reader.GetOrdinal("ngaySinh")),
                                    SoDienThoai = reader.GetString(reader.GetOrdinal("soDienThoai")),
                                    Email = reader.GetString(reader.GetOrdinal("email")),
                                    DiaChi = reader.GetString(reader.GetOrdinal("diaChi")),
                                    LuongCoBan = (float)reader.GetDouble(reader.GetOrdinal("luongCoBan")), 
                                    Role = reader.GetInt32(reader.GetOrdinal("role")),
                                    Username = reader.GetString(reader.GetOrdinal("username")),
                                    Password = reader.GetString(reader.GetOrdinal("password"))
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            return null;
        }

        public List<PhieuDatMon> LayPhieuDatMon()
        {
            List<PhieuDatMon> ds = new List<PhieuDatMon>();
            string query = "SELECT maPhieu, ngayDat, tongTien, trangThai, maNhanVien FROM PhieuDatMon";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ds.Add(new PhieuDatMon(
                                    reader.GetString(0),
                                    reader.GetDateTime(1),
                                    (float)reader.GetDouble(2),  
                                    reader.GetString(3),
                                    reader.GetString(4)
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            return ds;
        }

        public List<ChiTietPhieu> LayChiTietPhieu(string maPhieu)
        {
            List<ChiTietPhieu> ds = new List<ChiTietPhieu>();
            string query = "SELECT maPhieu, maMon, soLuong, donGia, thanhTien, ghiChuMon FROM ChiTietPhieu WHERE maPhieu=@mp";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mp", maPhieu);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ds.Add(new ChiTietPhieu(
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    (float)reader.GetDouble(3),  
                                    (float)reader.GetDouble(4),  
                                    reader.IsDBNull(5) ? null : reader.GetString(5)
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            return ds;
        }

        public List<Menu> LayMenu()
        {
            List<Menu> ds = new List<Menu>();
            string query = "SELECT maMon, tenMon, loaiMon, gia, donViTinh, moTa FROM Menu";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ds.Add(new Menu(
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    (float)reader.GetDouble(3),  
                                    reader.GetString(4),
                                    reader.IsDBNull(5) ? null : reader.GetString(5)
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            return ds;
        }

        public string LayTenNhanVien(string maNV)
        {
            string tenNV = "";
            string query = "SELECT tenNV FROM Users WHERE maNV = @maNV";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maNV", maNV ?? "");
                        object result = cmd.ExecuteScalar();
                        if (result != null) tenNV = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi OK: " + ex.Message);
                }
            }
            return tenNV;
        }

        // public bool LuuPhieu(PhieuDatMon phieu, ChiTietPhieu ct)
        // { ... }


        public bool LuuPhieu(PhieuDatMon phieu, List<ChiTietPhieu> dsChiTiet)
        {
            string queryPhieu = "INSERT INTO PhieuDatMon VALUES (@maPhieu, @ngayDat, @tongTien, @trangThai, @maNV)";
            string queryCT = "INSERT INTO ChiTietPhieu VALUES (@maPhieu, @maMon, @soLuong, @donGia, @thanhTien, @ghiChu)";

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction(); 

 
                    using (SqlCommand cmd = new SqlCommand(queryPhieu, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@maPhieu", phieu.MaPhieu);
                        cmd.Parameters.AddWithValue("@ngayDat", phieu.NgayDat);
                        cmd.Parameters.AddWithValue("@tongTien", phieu.TongTien);
                        cmd.Parameters.AddWithValue("@trangThai", phieu.TrangThai);
                        cmd.Parameters.AddWithValue("@maNV", phieu.MaNhanVien);
                        cmd.ExecuteNonQuery();
                    }

          
                    using (SqlCommand cmd = new SqlCommand(queryCT, conn, transaction))
                    {
                        foreach (var ct in dsChiTiet)
                        {
                            cmd.Parameters.Clear(); 

                            cmd.Parameters.AddWithValue("@maPhieu", ct.MaPhieu);
                            cmd.Parameters.AddWithValue("@maMon", ct.MaMon);
                            cmd.Parameters.AddWithValue("@soLuong", ct.SoLuong);
                            cmd.Parameters.AddWithValue("@donGia", ct.DonGia);
                            cmd.Parameters.AddWithValue("@thanhTien", ct.ThanhTien);
                            cmd.Parameters.AddWithValue("@ghiChu", ct.GhiChu ?? (object)DBNull.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); 
                    return true;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback(); 
                    MessageBox.Show("Lỗi khi lưu phiếu đặt món: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool LapHoaDon(string maPhieu, string maThuNgan, out string soHoaDon)
        {
            soHoaDon = "";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            soHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                            float tongTien = 0;
                            string queryTong = "SELECT tongTien FROM PhieuDatMon WHERE maPhieu = @maPhieu";
                            using (SqlCommand cmd = new SqlCommand(queryTong, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@maPhieu", maPhieu);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    tongTien = (float)Convert.ToDouble(result); 
                                }
                            }

                            string queryHD = @"
                                INSERT INTO HoaDon (soHoaDon, ngayLap, tongTien, maBan, maThuNgan)
                                VALUES (@soHD, GETDATE(), @tongTien, NULL, @maThuNgan)";

                            using (SqlCommand cmd = new SqlCommand(queryHD, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@soHD", soHoaDon);
                                cmd.Parameters.AddWithValue("@tongTien", tongTien);
                                cmd.Parameters.AddWithValue("@maThuNgan", maThuNgan);
                                cmd.ExecuteNonQuery();
                            }

                            string queryCopy = @"
                                INSERT INTO ChiTietHoaDon (soHoaDon, maMon, soLuong, thanhTien)
                                SELECT @soHD, maMon, soLuong, thanhTien
                                FROM ChiTietPhieu WHERE maPhieu = @maPhieu";

                            using (SqlCommand cmd = new SqlCommand(queryCopy, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@soHD", soHoaDon);
                                cmd.Parameters.AddWithValue("@maPhieu", maPhieu);
                                cmd.ExecuteNonQuery();
                            }

                            string queryUpdate = "UPDATE PhieuDatMon SET trangThai = N'Đã thanh toán' WHERE maPhieu = @maPhieu";
                            using (SqlCommand cmd = new SqlCommand(queryUpdate, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@maPhieu", maPhieu);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            soHoaDon = "";
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lập hóa đơn: " + ex.Message);
                    soHoaDon = "";
                    return false;
                }
            }
        }

        public DataTable ThongKeDoanhThuMon(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            string query = @"
                            SELECT 
                                m.tenMon,
                                SUM(ct.soLuong) AS SoLuongBan,
                                SUM(ct.thanhTien) AS DoanhThu
                            FROM ChiTietHoaDon ct
                            JOIN HoaDon hd ON ct.soHoaDon = hd.soHoaDon
                            JOIN Menu m ON ct.maMon = m.maMon
                            WHERE hd.ngayLap BETWEEN @tuNgay AND @denNgay
                            GROUP BY m.tenMon
                            ORDER BY DoanhThu DESC";

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@denNgay", denNgay);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thống kê doanh thu: " + ex.Message);
                }
            }
            return dt;
        }

        public double TongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            double tong = 0;
            string query = "SELECT SUM(tongTien) FROM HoaDon WHERE ngayLap BETWEEN @tuNgay AND @denNgay";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@denNgay", denNgay);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            tong = Convert.ToDouble(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tính tổng doanh thu: " + ex.Message);
                }
            }
            return tong;
        }
    }
}
