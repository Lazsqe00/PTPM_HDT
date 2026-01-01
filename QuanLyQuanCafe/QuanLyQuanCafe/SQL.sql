USE master;
GO

IF DB_ID('QuanLyQuanCafe') IS NOT NULL
BEGIN
    ALTER DATABASE QuanLyQuanCafe SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyQuanCafe;
END
GO

CREATE DATABASE QuanLyQuanCafe;
GO

USE QuanLyQuanCafe;
GO

CREATE TABLE Users (
    userId INT IDENTITY PRIMARY KEY,
    maNV NVARCHAR(20) UNIQUE NOT NULL,
    tenNV NVARCHAR(100),
    gioiTinh NVARCHAR(10),
    ngaySinh DATE,
    soDienThoai NVARCHAR(15),
    email NVARCHAR(100),
    diaChi NVARCHAR(200),
    luongCoBan FLOAT,
    role INT NOT NULL,
    username NVARCHAR(50) UNIQUE NOT NULL,
    password NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Ban (
    maBan NVARCHAR(20) PRIMARY KEY,
    soBan INT,
    trangThai NVARCHAR(50)
);
GO

CREATE TABLE Menu (
    maMon NVARCHAR(20) PRIMARY KEY,
    tenMon NVARCHAR(100),
    loaiMon NVARCHAR(50),
    gia FLOAT,
    donViTinh NVARCHAR(20),
    moTa NVARCHAR(200)
);
GO

CREATE TABLE HoaDon (
    soHoaDon NVARCHAR(40) PRIMARY KEY,
    ngayLap DATETIME,
    tongTien FLOAT,
    maBan NVARCHAR(20),
    maThuNgan NVARCHAR(20),
    CONSTRAINT FK_HoaDon_Ban FOREIGN KEY (maBan) REFERENCES Ban(maBan),
    CONSTRAINT FK_HoaDon_ThuNgan FOREIGN KEY (maThuNgan) REFERENCES Users(maNV)
);
GO

CREATE TABLE ChiTietHoaDon (
    id INT IDENTITY PRIMARY KEY,
    soHoaDon NVARCHAR(40),
    maMon NVARCHAR(20),
    soLuong INT,
    thanhTien FLOAT,
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (soHoaDon) REFERENCES HoaDon(soHoaDon),
    CONSTRAINT FK_CTHD_Menu FOREIGN KEY (maMon) REFERENCES Menu(maMon)
);
GO

CREATE TABLE PhieuDatMon (
    maPhieu NVARCHAR(40) PRIMARY KEY,
    ngayDat DATETIME,
    tongTien FLOAT,
    trangThai NVARCHAR(50),
    maNhanVien NVARCHAR(20),
    CONSTRAINT FK_Phieu_User FOREIGN KEY (maNhanVien) REFERENCES Users(maNV)
);
GO

CREATE TABLE ChiTietPhieu (
    id INT IDENTITY PRIMARY KEY,
    maPhieu NVARCHAR(40),
    maMon NVARCHAR(20),
    soLuong INT,
    donGia FLOAT,
    thanhTien FLOAT,
    ghiChuMon NVARCHAR(200),
    CONSTRAINT FK_CTP_Phieu FOREIGN KEY (maPhieu) REFERENCES PhieuDatMon(maPhieu),
    CONSTRAINT FK_CTP_Menu FOREIGN KEY (maMon) REFERENCES Menu(maMon)
);
GO

CREATE TABLE BaoCao (
    maBaoCao NVARCHAR(20) PRIMARY KEY,
    ngayLap DATE,
    noiDung NVARCHAR(500),
    tongDoanhThu FLOAT,
    maQuanTri NVARCHAR(20),
    CONSTRAINT FK_BaoCao_Admin FOREIGN KEY (maQuanTri) REFERENCES Users(maNV)
);
GO


INSERT INTO Users (maNV, tenNV, gioiTinh, ngaySinh, soDienThoai, email, diaChi, luongCoBan, role, username, password) VALUES
('admin', N'Nguyễn Văn Admin', N'Nam', '1990-05-15', '0900000000', 'admin@cafe.com', N'TP.HCM', 20000000, 0, 'admin', 'admin'),

('TNN001', N'Trần Thị Mai', N'Nữ', '1998-03-20', '0911111001', 'mai.tnn@cafe.com', N'Quận 1, HCM', 9000000, 1, 'tiepnhan', '123'),
('TNN002', N'Lê Văn Hùng', N'Nam', '1997-07-10', '0911111002', 'hung.tnn@cafe.com', N'Quận 3, HCM', 9000000, 1, 'tiepnhan2', '123'),
('TNN003', N'Phạm Hồng Ngọc', N'Nữ', '1999-11-25', '0911111003', 'ngoc.tnn@cafe.com', N'Quận 7, HCM', 9500000, 1, 'tiepnhan3', '123'),
('TNN004', N'Hoàng Văn Lâm', N'Nam', '1996-01-08', '0911111004', 'lam.tnn@cafe.com', N'Bình Thạnh, HCM', 9000000, 1, 'tiepnhan4', '123'),
('TNN005', N'Vũ Thị Lan Anh', N'Nữ', '2000-09-12', '0911111005', 'lananh.tnn@cafe.com', N'Gò Vấp, HCM', 9200000, 1, 'tiepnhan5', '123'),

('TN001', N'Nguyễn Thị Kim Oanh', N'Nữ', '1995-04-18', '0922222001', 'oanh.tn@cafe.com', N'Quận 10, HCM', 10000000, 2, 'thungan', '123'),
('TN002', N'Đỗ Văn Minh', N'Nam', '1994-12-05', '0922222002', 'minh.tn@cafe.com', N'Tân Bình, HCM', 10500000, 2, 'thungan2', '123'),
('TN003', N'Bùi Thị Thu Hà', N'Nữ', '1998-08-30', '0922222003', 'ha.tn@cafe.com', N'Phú Nhuận, HCM', 10000000, 2, 'thungan3', '123'),
('TN004', N'Phan Văn Tuấn', N'Nam', '1993-06-22', '0922222004', 'tuan.tn@cafe.com', N'Quận 5, HCM', 10200000, 2, 'thungan4', '123');


INSERT INTO Ban (maBan, soBan, trangThai) VALUES
('B01', 1, N'Trống'),
('B02', 2, N'Có khách'),
('B03', 3, N'Trống'),
('B04', 4, N'Trống'),
('B05', 5, N'Có khách'),
('B06', 6, N'Trống'),
('B07', 7, N'Trống'),
('B08', 8, N'Có khách'),
('B09', 9, N'Trống'),
('B10', 10, N'Trống');


INSERT INTO Menu (maMon, tenMon, loaiMon, gia, donViTinh, moTa) VALUES
('M01', N'Cà phê sữa đá', N'Nước uống', 16000, N'Ly', N'Cà phê sữa đá truyền thống'),
('M02', N'Trà đào cam sả', N'Nước uống', 30000, N'Ly', N'Trà đào tươi mát'),
('M03', N'Bạc xỉu', N'Nước uống', 25000, N'Ly', N'Nhiều sữa ít cà phê'),
('M04', N'Sinh tố dâu', N'Nước uống', 35000, N'Ly', N'Sinh tố dâu tây tươi'),
('M05', N'Trà sữa trân châu', N'Nước uống', 32000, N'Ly', N'Trà sữa nhà làm'),
('M06', N'Bánh mì pate', N'Ăn vặt', 20000, N'Ổ', N'Bánh mì pate trứng'),
('M07', N'Bánh flan', N'Tráng miệng', 15000, N'Phần', N'Flan caramen mềm mịn'),
('M08', N'Cà phê đen đá', N'Nước uống', 20000, N'Ly', N'Cà phê đen nguyên chất'),
('M09', N'Sữa chua mít', N'Tráng miệng', 25000, N'Hũ', N'Sữa chua topping mít'),
('M10', N'Nước ép cam', N'Nước uống', 28000, N'Ly', N'Nước ép cam tươi');


INSERT INTO PhieuDatMon (maPhieu, ngayDat, tongTien, trangThai, maNhanVien) VALUES
('PD01012025103000TNN001', '2025-01-01 10:30:00', 52000, N'Đã thanh toán', 'TNN001'),
('PD02012025110000TNN002', '2025-01-02 11:00:00', 60000, N'Đã thanh toán', 'TNN002'),
('PD03012025140000TNN003', '2025-01-03 14:00:00', 70000, N'Đang xử lý', 'TNN003'),
('PD04012025153000TNN004', '2025-01-04 15:30:00', 45000, N'Đã thanh toán', 'TNN004'),
('PD05012025120000TNN005', '2025-01-05 12:00:00', 80000, N'Đã thanh toán', 'TNN005'),
('PD06012025090000TNN001', '2025-01-06 09:00:00', 35000, N'Đang xử lý', 'TNN001'),
('PD07012025180000TNN002', '2025-01-07 18:00:00', 90000, N'Đã thanh toán', 'TNN002'),
('PD08012025130000TNN003', '2025-01-08 13:00:00', 55000, N'Đã thanh toán', 'TNN003'),
('PD09012025160000TNN004', '2025-01-09 16:00:00', 42000, N'Đang xử lý', 'TNN004'),
('PD10012025110000TNN005', '2025-01-10 11:00:00', 65000, N'Đã thanh toán', 'TNN005');


INSERT INTO ChiTietPhieu (maPhieu, maMon, soLuong, donGia, thanhTien, ghiChuMon) VALUES
('PD01012025103000TNN001', 'M01', 2, 22000, 44000, N'Ít đá'),
('PD01012025103000TNN001', 'M07', 1, 15000, 15000, NULL),

('PD02012025110000TNN002', 'M02', 1, 30000, 30000, N'Nhiều đào'),
('PD02012025110000TNN002', 'M04', 1, 35000, 35000, NULL),

('PD03012025140000TNN003', 'M03', 2, 25000, 50000, N'Nhiều sữa'),
('PD03012025140000TNN003', 'M06', 1, 20000, 20000, NULL),

('PD04012025153000TNN004', 'M05', 1, 32000, 32000, N'Trân châu nhiều'),
('PD04012025153000TNN004', 'M09', 1, 25000, 25000, NULL),

('PD05012025120000TNN005', 'M01', 2, 22000, 44000, NULL),
('PD05012025120000TNN005', 'M02', 1, 30000, 30000, NULL),
('PD05012025120000TNN005', 'M10', 1, 28000, 28000, NULL),

('PD06012025090000TNN001', 'M08', 1, 20000, 20000, N'Ít đường'),
('PD06012025090000TNN001', 'M07', 1, 15000, 15000, NULL),

('PD07012025180000TNN002', 'M04', 2, 35000, 70000, NULL),
('PD07012025180000TNN002', 'M05', 1, 32000, 32000, NULL),

('PD08012025130000TNN003', 'M01', 1, 22000, 22000, NULL),
('PD08012025130000TNN003', 'M03', 1, 25000, 25000, NULL),
('PD08012025130000TNN003', 'M09', 1, 25000, 25000, NULL),

('PD09012025160000TNN004', 'M02', 1, 30000, 30000, NULL),
('PD09012025160000TNN004', 'M06', 1, 20000, 20000, NULL),

('PD10012025110000TNN005', 'M10', 2, 28000, 56000, NULL),
('PD10012025110000TNN005', 'M07', 1, 15000, 15000, NULL);


INSERT INTO HoaDon (soHoaDon, ngayLap, tongTien, maBan, maThuNgan) VALUES
('HD01012025104500TN001', '2025-01-01 10:45:00', 59000, 'B01', 'TN001'),
('HD02012025111500TN002', '2025-01-02 11:15:00', 65000, 'B02', 'TN002'),
('HD03012025142000TN003', '2025-01-03 14:20:00', 70000, 'B03', 'TN003'),
('HD04012025154500TN004', '2025-01-04 15:45:00', 57000, 'B04', 'TN004'),
('HD05012025121500TN001', '2025-01-05 12:15:00', 102000, 'B05', 'TN001'),
('HD07012025181500TN002', '2025-01-07 18:15:00', 102000, 'B06', 'TN002'),
('HD08012025131500TN003', '2025-01-08 13:15:00', 72000, 'B07', 'TN003'),
('HD10012025111500TN004', '2025-01-10 11:15:00', 71000, 'B08', 'TN004'),
('HD11012025093000TN001', '2025-01-11 09:30:00', 45000, 'B09', 'TN001'),
('HD12012025170000TN002', '2025-01-12 17:00:00', 88000, 'B10', 'TN002');


INSERT INTO ChiTietHoaDon (soHoaDon, maMon, soLuong, thanhTien) VALUES
('HD01012025104500TN001', 'M01', 2, 44000),
('HD01012025104500TN001', 'M07', 1, 15000),

('HD02012025111500TN002', 'M02', 1, 30000),
('HD02012025111500TN002', 'M04', 1, 35000),

('HD03012025142000TN003', 'M03', 2, 50000),
('HD03012025142000TN003', 'M06', 1, 20000),

('HD04012025154500TN004', 'M05', 1, 32000),
('HD04012025154500TN004', 'M09', 1, 25000),

('HD05012025121500TN001', 'M01', 2, 44000),
('HD05012025121500TN001', 'M02', 1, 30000),
('HD05012025121500TN001', 'M10', 1, 28000),

('HD07012025181500TN002', 'M04', 2, 70000),
('HD07012025181500TN002', 'M05', 1, 32000),

('HD08012025131500TN003', 'M01', 1, 22000),
('HD08012025131500TN003', 'M03', 1, 25000),
('HD08012025131500TN003', 'M09', 1, 25000),

('HD10012025111500TN004', 'M10', 2, 56000),
('HD10012025111500TN004', 'M07', 1, 15000),

('HD11012025093000TN001', 'M08', 1, 20000),
('HD11012025093000TN001', 'M06', 1, 25000),

('HD12012025170000TN002', 'M02', 2, 60000),
('HD12012025170000TN002', 'M05', 1, 28000);


INSERT INTO BaoCao (maBaoCao, ngayLap, noiDung, tongDoanhThu, maQuanTri) VALUES
('BC20250101', '2025-01-01', N'Báo cáo doanh thu ngày 01/01/2025', 59000, 'admin'),
('BC20250102', '2025-01-02', N'Báo cáo doanh thu ngày 02/01/2025', 65000, 'admin'),
('BC20250103', '2025-01-03', N'Báo cáo doanh thu ngày 03/01/2025', 70000, 'admin'),
('BC20250104', '2025-01-04', N'Báo cáo doanh thu ngày 04/01/2025', 57000, 'admin'),
('BC20250105', '2025-01-05', N'Báo cáo doanh thu ngày 05/01/2025', 102000, 'admin'),
('BC20250107', '2025-01-07', N'Báo cáo doanh thu ngày 07/01/2025', 102000, 'admin'),
('BC20250108', '2025-01-08', N'Báo cáo doanh thu ngày 08/01/2025', 72000, 'admin'),
('BC20250110', '2025-01-10', N'Báo cáo doanh thu ngày 10/01/2025', 71000, 'admin'),
('BC20250111', '2025-01-11', N'Báo cáo doanh thu ngày 11/01/2025', 45000, 'admin'),
('BC20250112', '2025-01-12', N'Báo cáo doanh thu ngày 12/01/2025', 88000, 'admin');

GO

INSERT INTO PhieuDatMon (maPhieu, ngayDat, tongTien, trangThai, maNhanVien) VALUES
('PD11012025103000TNN001', '2025-01-11 10:30:00', 78000, N'Đã thanh toán', 'TNN001'),
('PD12012025140000TNN002', '2025-01-12 14:00:00', 48000, N'Đã thanh toán', 'TNN002'),
('PD13012025170000TNN003', '2025-01-13 17:00:00', 95000, N'Đang xử lý', 'TNN003'),
('PD14012025110000TNN004', '2025-01-14 11:00:00', 62000, N'Đã thanh toán', 'TNN004'),
('PD15012025183000TNN005', '2025-01-15 18:30:00', 110000, N'Đã thanh toán', 'TNN005');
GO

INSERT INTO ChiTietPhieu (maPhieu, maMon, soLuong, donGia, thanhTien, ghiChuMon) VALUES

('PD11012025103000TNN001', 'M01', 3, 16000, 48000, N'Ít đá, ít đường'),
('PD11012025103000TNN001', 'M03', 1, 25000, 25000, NULL),
('PD11012025103000TNN001', 'M07', 1, 15000, 15000, NULL),

('PD12012025140000TNN002', 'M02', 1, 30000, 30000, N'Nhiều cam'),
('PD12012025140000TNN002', 'M09', 1, 25000, 25000, NULL),
('PD12012025140000TNN002', 'M06', 1, 20000, 20000, NULL),


('PD13012025170000TNN003', 'M04', 2, 35000, 70000, N'Nhiều dâu'),
('PD13012025170000TNN003', 'M05', 1, 32000, 32000, N'Trân châu dai'),
('PD13012025170000TNN003', 'M10', 1, 28000, 28000, NULL),


('PD14012025110000TNN004', 'M08', 2, 20000, 40000, N'Đen đá'),
('PD14012025110000TNN004', 'M01', 1, 16000, 16000, NULL),
('PD14012025110000TNN004', 'M07', 1, 15000, 15000, NULL),

('PD15012025183000TNN005', 'M05', 2, 32000, 64000, N'Thêm topping'),
('PD15012025183000TNN005', 'M02', 1, 30000, 30000, NULL),
('PD15012025183000TNN005', 'M04', 1, 35000, 35000, NULL),
('PD15012025183000TNN005', 'M09', 1, 25000, 25000, NULL);
GO

