<div align="center">
  <h1>Quản Lý Quán Cafe</h1>
</div>
---

## Tính năng
### Đăng nhập
### Lập phiếu đặt món
### Lập hóa đơn
### Thống kê báo cáo doanh thu

---

## Cài đặt & Môi trường

### Yêu cầu
- **Windows**
- **SQL Server** (hoặc SQL Server Express)
- **Visual Studio 2019/2022** với C# WinForms

### Tải database
1. Mở file `SQL.sql` trong thư mục dự án.
2. Mở **SQL Server Management Studio (SSMS)**.
3. Chạy file SQL để tạo database và các bảng.

### Chuỗi kết nối

Để phần mềm kết nối với database, bạn cần **Connection String**.  

1. Mở **SQL Server Management Studio (SSMS)**.  
2. Trên menu **View → SQL server Object Explorer**.  
3. Trong mở rộng **Databases** → chọn **QuanLyQuanCafe**.  
4. Nhấn chuột phải vào database → **Properties** → xem **connection string**..

### Cấu hình chuỗi kết nối
Trong file `Connection.cs`, sửa chuỗi kết nối dán connection string:

```csharp
private string connectionString = @"Server=YOUR_SERVER;Database=QuanLyQuanCafe;Trusted_Connection=True;";
```
**💡 Thông tin đăng nhập (mặc định)**  
Dữ liệu này được lưu trong **database `QuanLyQuanCafe`**, bảng `Users`.  

 - **Admin:**  
>   - Username: `admin`  
>   - Password: `123`  
 - **Nhân viên thu ngân:**  
>   - Username: `thungan`  
>   - Password: `123`
 - **Nhân viên tiếp nhận đơn:**  
>   - Username: `tiepnhan`  
>   - Password: `123`

> [!NOTE]
Đây chỉ là bài tập nhỏ của môn học mô phỏng một số tính năng không phải dự án đầy đủ của hệ thống 
