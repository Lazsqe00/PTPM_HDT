<div align="center">
  <h1>Quản Lý Quán Cafe</h1>
</div>

---

**Tính năng**

- **Đăng nhập**
- **Lập phiếu đặt món**
- **Lập hóa đơn**
- **Thống kê báo cáo doanh thu**

---

**Cài đặt & Môi trường**

**Yêu cầu:**
- Windows
- SQL Server (hoặc SQL Server Express)
- Visual Studio 2019/2022 với C# WinForms

**Tải database:**
1. Mở file `SQL.sql` trong thư mục dự án.
2. Mở **SQL Server Management Studio (SSMS)**.
3. Chạy file SQL để tạo database và các bảng.

**Chuỗi kết nối**

Để phần mềm kết nối với database, bạn cần **Connection String**.

1. Mở **SQL Server Management Studio (SSMS)**.
2. Trên menu **View → SQL Server Object Explorer**.
3. Mở rộng **Databases** → chọn **QuanLyQuanCafe**.
4. Nhấn chuột phải vào database → **Properties** → xem **connection string**.

**Cấu hình chuỗi kết nối**  
Trong file `Connection.cs`, sửa chuỗi kết nối:

```csharp
private string connectionString = @"Server=YOUR_SERVER;Database=QuanLyQuanCafe;Trusted_Connection=True;";
