HEAD
﻿﻿
--Tao database 

CREATE DATABASE [QuanLyThuvien]

GO
USE QuanLyThuVien

--Tạo PROC lấy ID và MK
GO
CREATE PROCEDURE proc_login
    @user CHAR(10), @pass NVARCHAR(10)
AS
BEGIN
    SELECT*
	FROM TaiKhoan 
	WHERE MaNV=@user AND MK=@pass
END

DROP PROC proc_login





--Tao Danh Sach PHIEU 

CREATE TABLE [dbo].[DanhSachPhieu](
	[MaPhieu] [char](10) NULL,
	[MaSach] [char](10) NULL,
	[SL] [int] NULL
) 
--Tao bang doc gia

CREATE TABLE [dbo].[Docgia](
	[MaDG] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[NgaySinh] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	PRIMARY KEY ([MaDG])
)	

--Tao bang Nhan vien

CREATE TABLE [dbo].[Nhanvien](
	[MaNV] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[NgaySinh] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhanQuyen] [nvarchar](20) NULL,
PRIMARY KEY ([MaNV])
) 
--Tao TABLE Phieu
CREATE TABLE [dbo].[Phieu](
	[MaPhieu] [char](10) NOT NULL,
	[MaDG] [char](10) NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
	[LoaiPhieu] [nvarchar](20) NULL,
	[Tong] [int] NULL,
		PRIMARY KEY ([MaPHIEU])
)

--Tao table quan ly phieu 
CREATE TABLE [dbo].[QuanLyPhieu](
	[MaNV] [char](10) NULL,
	[MaPH] [char](10) NULL
)

--Tao table quan ly sach 
CREATE TABLE [dbo].[QuanLySach](
	[MaNV] [char](10) NULL,
	[MaSach] [char](10) NULL
) 
--Tao bang   sach
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](10) NOT NULL,
	[TenSach] [nvarchar](100) NULL,
	[MaTL] [char](10) NULL,
	[SL] [int] NULL,
	[NXB] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[NoiDung] [nvarchar](max) NULL,
  PRIMARY KEY ([MaSach])
) 

--Tao bang  tac gia
CREATE TABLE [dbo].[TacGia](
	[MaTG] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiThieu] [nvarchar](max) NULL,
  PRIMARY KEY ([MaTG])
  )
 --Tao bang doc tac gia viet sach

CREATE TABLE [dbo].[TacGiaVietSach](
	[Masach] [char](10) NULL,
	[MaTG] [char](10) NULL
) 

--Tao bang Tai Khoan

CREATE TABLE [dbo].[TaiKhoan](
	[MaNV] [char](10) NULL,
	[MK] [nvarchar](10) NULL
)

--Tao bang  the loai


CREATE TABLE [dbo].[TheLoai](
	[MaTL] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[ThongTin] [nvarchar](max) NULL,
	  PRIMARY KEY ([MaTL])
)

INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100001  ', N'SG100008  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100001  ', N'SG100007  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100006  ', N'SG100009  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100000  ', N'SG100000  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100000  ', N'SG100007  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100000  ', N'SG100006  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100001  ', N'SG100004  ', 3)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100011  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100010  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100006  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100005  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100005  ', N'SG100005  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100004  ', 3)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100001  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100003  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100006  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100004  ', N'SG100004  ', 1)
GO
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071111', N'Pham Trong Truong 1', N'Nam', N'0353573467', CAST(N'2020-07-16' AS Date), N'Quận 9', N'truong@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071112', N'Trần Đức Vũ', N'Nam', N'0363636569', CAST(N'2000-07-01' AS Date), N'Quận 9', N'Tranducvu23@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071113', N'Trần Đức Bo', N'Nam', N'0365696844', CAST(N'1999-07-03' AS Date), N'Quận 10', N'Ducbo@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071114', N'Lê Thị Riêng', N'Nữ', N'0353656954', CAST(N'2002-07-03' AS Date), N'Quận 7', N'Rieng@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071115', N'Trần Phúc Long', N'Nam', N'0354585475', CAST(N'0200-07-23' AS Date), N'Quận 8', N'Longml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071116', N'Ngô Thanh Vân', N'Nữ', N'0365847584', CAST(N'1998-07-16' AS Date), N'Quận 9', N'Vanml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071117', N'Trần Thanh Trình', N'Nữ', N'0358585879', CAST(N'2000-07-17' AS Date), N'Quận 8', N'Trinhml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071118', N'Trần Thanh Quý', N'Nam', N'0356864975', CAST(N'2000-07-09' AS Date), N'Quận 9', N'Quyml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071119', N'Hoàng Huy Hậu', N'Nam', N'0358457589', CAST(N'2000-07-02' AS Date), N'Quận 9', N'Hauml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071120', N'Lê Thị Mỹ Trinh', N'Nữ', N'0965865458', CAST(N'1999-07-08' AS Date), N'Quận 9', N'Trinhml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071121', N'Lê Hoài Anh', N'Nam', N'0956854858', CAST(N'2000-07-09' AS Date), N'Quận 9', N'Anhml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071122', N'Nguyễn Tố Nữ', N'Nữ', N'0965865454', CAST(N'2000-07-10' AS Date), N'Quận 9', N'Numl@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071123', N'Trần Thị Tuyền', N'Nam', N'0356458547', CAST(N'2000-07-02' AS Date), N'Quận 10', N'Tuyenml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071124', N'Nguyễn Thanh Nam', N'Nam', N'0366585474', CAST(N'1999-07-15' AS Date), N'Quận 7', N'Namml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071125', N'Nguyễn Thành Long', N'Nam', N'0363636568', CAST(N'2000-07-03' AS Date), N'Quận 10', N'Longml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071126', N'Hồ Thị Tư', N'Nam', N'0356854857', CAST(N'2000-07-09' AS Date), N'Quận 8', N'Tuml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071127', N'Hoàng Văn A', N'Nam', N'0958654555', CAST(N'2000-07-02' AS Date), N'Quận 9', N'Aaaa@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071128', N'Lê Thị Tiên', N'Nữ', N'0958665585', CAST(N'2000-07-09' AS Date), N'Quận 9', N'Tienml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071129', N'Lê Anh Đào', N'Nữ', N'0365447458', CAST(N'2000-07-16' AS Date), N'Quận 6', N'Daoml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071130', N'Nguyễn Thanh An', N'Nữ', N'0369598547', CAST(N'2001-07-24' AS Date), N'Quận 7', N'Anml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071131', N'Trần Thị Quý', N'Nữ', N'0366666999', CAST(N'2000-07-24' AS Date), N'Quận 9', N'Quyml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071132', N'Nguyễn Thanh Ân', N'Nữ', N'0369598547', CAST(N'2001-07-24' AS Date), N'Quận 8', N'Anml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071133', N'Trần Phúc Hậu', N'Nữ', N'0354585444', CAST(N'0200-07-22' AS Date), N'Quận 10', N'Hauml1@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071134', N'Trần Thanh Bảo', N'Nữ', N'0358581111', CAST(N'2000-07-06' AS Date), N'Quận 9', N'Baoml11@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071135', N'Ngô Thanh Thảo', N'Nữ', N'0365847522', CAST(N'1999-07-16' AS Date), N'Quận 10', N'Thaoml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071136', N'Trần Thanh Vương', N'Nữ', N'0356277772', CAST(N'2000-07-01' AS Date), N'Quận 10', N'Vuongml123@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071137', N'Trần Đức Vũ', N'Nam', N'0363636569', CAST(N'2000-08-16' AS Date), N'Quận 9', N'Tranducvu23@gmail.com')
GO
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100000  ', N'Trường', N'Nam', N'0353573467', CAST(N'2020-07-10' AS Date), N'Quận 9', N'truong@gmail.com', N'Nhân Viên')
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100002  ', N'Tuấn', N'Nam', N'0369696896', CAST(N'2000-07-14' AS Date), N'Quận 9', N'Tuanml@gmail.com', N'Nhân Viên')
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100004  ', N'Vũ', N'Nam', N'0369696896', CAST(N'2000-03-14' AS Date), N'Quận 9', N'Vuml@gmail.com', N'Nhân Viên')
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100005  ', N'Nguyễn Hoàng Vương', N'Nam', N'0365868584', CAST(N'2000-04-12' AS Date), N'Quận 9', N'Vuongmk@gmail.com', N'Quản Lý')
GO
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100000  ', N'5951071111', CAST(N'2020-07-07' AS Date), CAST(N'2020-07-21' AS Date), N'Phieu Tra', 1)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100001  ', N'5951071119', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Tra', 5)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100002  ', N'5951071117', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Tra', 6)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100003  ', N'5951071120', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 4)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100004  ', N'5951071114', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 1)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100005  ', N'5951071112', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 1)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100006  ', N'5951071118', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 1)
GO
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100005  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100005  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100005  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100005  ')
GO
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100024  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100024  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100024  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100024  ')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100000  ', N'Lập trình và cuộc sống ', N'TL100004  ', 29, N'NXB Thanh Niên', CAST(N'2020-07-07' AS Date), N'Anh cần một cách để theo dõi sự phát triển của phần mềm theo thời gian-bất cứ điều gì anh ta nghĩ đến hoặc làm việc trên nó. Jeff đã nghiên cứu các chủ đề mà anh cảm thấy thú vị, sau đó ghi lại nghiên cứu của mình bằng một bài đăng trên blog mà anh có thể dễ dàng tìm lại và tham khải sau này.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100001  ', N'Giáo Trình C++ & Lập Trình Hướng Đối Tượng', N'TL100004  ', 18, N'NXB Hồng Đức', CAST(N'2020-07-07' AS Date), N'Giáo trình C++ & lập trình hướng đối tượng” trình bày một cách hệ thống các khái niệm của lập trình hướng đối tượng được cài đặt trong C++ như lớp, đối tượng, sự thừa kế, tính tương ứng bội và các khả năng mới trong xây dựng, sử dụng hàm như đối tham chiếu, đối mặc định, hàm trùng tên, hàm toán tử.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100002  ', N'Lập Trình Với C# ', N'TL100004  ', 20, N'NXB Thanh Niên', CAST(N'2020-07-07' AS Date), N'Trình bày các khai niên và xây dựng ứng dụng bằng ngôn ngữ c#')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100003  ', N'Những Câu Hỏi Lớn', N'TL100006  ', 12, N'NXB Dân Trí', CAST(N'2020-07-07' AS Date), N'NHỮNG CÂU HỎI LỚN đề cập đến những vấn đề cơ bản trong khoa học tự nhiên và xã hội, nhưng vẫn khiến những bộ óc vĩ đại trong lịch sử đau đầu.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100004  ', N'Một Thiên Tiểu Thuyết', N'TL100006  ', 17, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Hầu hết mọi người đều thích toán, tiếc là họ không biết điều này!
Bởi ai mà chẳng thấy hấp dẫn với những mẩu chuyện kỳ thú về toán: như “giáo phái” toán học kỳ lạ của Pythagoras thời cổ đại hay những cuộc thăm dò hệ mặt trời bằng công cụ toán học đầy kịch tính thời cận đại, hoặc gần đây hơn là sự kiện máy tính AlphaGo giành chiến thắng trước kỳ thủ cờ vây số một thế giới Lee Sedol bằng những nước đi “thần thánh” sử dụng lý thuyết xác suất
')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100005  ', N'A Mind For Numbers - Cách Chinh Phục Toán Và Khoa Học', N'TL100006  ', 25, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'A Mind for Numbers- Cách chinh phục Toán và Khoa học, đưa ra các cách thức giúp học sinh – sinh viên đang gặp rắc rối với môn toán và khoa học biết cách khai mở và sử dụng nguồn tài nguyên vô tận trong chính bộ não của mình, qua đó không chỉ chinh phục thành công bộ môn này mà đồng trời trở nên xuất sắc hơn bao giờ hết. Cuốn sách cũng giúp ích cho những người đã đi làm biết cách sáng tạo và sắp xếp công việc của mình, đồng thời phát triển nó lên một tầm cao mới, thông qua các kỹ thuật tư duy hoàn hảo.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100006  ', N'Những Điều Tưởng Chừng Bất Khả', N'TL100007  ', 27, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'trong Vật lý của những điều tưởng chừng bất khả, nhà vật lý Michio Kaku khám phá khả năng đưa những công nghệ và thiết bị từ lãnh địa của khoa học viễn tưởng vào cuộc sống thường nhật trong tương lai.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100007  ', N'Vật Lý Của Những Điều Tưởng Chừng Bất Khả', N'TL100007  ', 13, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Trong Vật lý của những điều tưởng chừng bất khả, nhà vật lý Michio Kaku khám phá khả năng đưa những công nghệ và thiết bị từ lãnh địa của khoa học viễn tưởng vào cuộc sống thường nhật trong tương lai.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100008  ', N'Bài Học Hay Nhất Về Vật Lý ', N'TL100007  ', 33, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Cuốn sách 7 bài học hay nhất về Vật lý là một bản tổng kết nhanh những tri thức quan trọng đã tạo nên cuộc cách mạng vĩ đại trong nền vật lý thế kỷ XX như thuyết tương đối rộng, cơ học lượng tử, vũ trụ học, hạt cơ bản, lý thuyết hấp dẫn lượng tử, hố đen. Cuốn sách cũng đề cập đến ý nghĩa của tất cả những tri thức ấy với nhận thức của con người ngày nay.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100009  ', N'Ngôi Nhà Việt', N'TL100008  ', 34, N'Nxb Tổng hợp TP.HCM', CAST(N'2020-07-07' AS Date), N'Tuy đã giảng dạy lâu năm về kiến trúc, nhưng khi được yêu cầu trình bày về ngôi nhà của thường dân người Việt, kiến trúc sư Thái thú nhận bản thân mình cũng lúng túng do chưa am hiểu thấu đáo về sự xuất hiện, tồn tại và biến chuyển của ngôi nhà. Chỉ gần đây, do yêu cầu viết một biên khảo về nếp ở của người Việt, anh mới tập trung nghiên cứu lại vấn đề một cách căn cơ hơn.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100010  ', N'Những Ngôi Nhà Kết Hợp Công Việc', N'TL100008  ', 39, N'Nxb Trẻ', CAST(N'2020-07-07' AS Date), N'Bộ sách dành cho bạn trẻ luôn mong muốn sau này chính tay mình dựng lên những tòa nhà trong mơ dành cho mình và người thân, bạn bè.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100011  ', N'Khám Phá Thiết Kế Đô Thị Hàn Quốc', N'TL100008  ', 26, N'NXB Văn hóa - Văn nghệ', CAST(N'2020-07-07' AS Date), N'Có thể nói rằng vấn đề của bản sắc đô thị Hàn Quốc nảy sinh từ chính sự thiếu nhận thức về bản thân chứ không phải từ điều gì khác. Điều này một phần cũng do những sai lầm lịch sử lâu dài bắt đầu từ thời Nhật đô hộ khi người Hàn Quốc dần quen nhìn nhận cuộc sống và không gian sống của bản thân bằng cái nhìn của người khác….')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100012  ', N'Cuộc Sống Diệu Kỳ Của Các Nguyên Tố', N'TL100009  ', 37, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Cuốn sách Cuộc Sống Diệu Kỳ Của Các Nguyên Tố thực sự là một sự kết hợp hoàn hảo giữa kiến thức khoa học kỳ thú và nghệ thuật vẽ truyện tranh đầy màu sắc. Dưới bàn tay khéo léo của họa sĩ Bunpei Yorifuji, thế giới siêu nhỏ của những hạt cơ bản trở nên sống động và gần gũi hơn bao giờ hết')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100013  ', N'Nguyên Tố - Khám Phá Các Nguyên Tử Trong Vũ Trụ Qua Hình Ảnh', N'TL100009  ', 25, N'Nxb Trẻ', CAST(N'2020-07-07' AS Date), N'Theodore Gray say mê bảng tuần hoàn. Và bộ sưu tập các nguyên tố của ông sáng ngang với bất kỳ viện bảo tàng nào. Với sự hóm hĩnh đặc trưng và kiến thức uyên bác. Và trên hết là những bức ảnh lộng lẫy, ông đã cho thấy những ví dụ hấp dẫn - trải dài từ những điều tầm thường đến những ngã rẽ quanh co - về các tính chất và ứng dụng của mỗi nguyên tố')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100014  ', N'Giáo Trình Hoá Học Đại Cương', N'TL100009  ', 22, N'Khoa học và kỹ thuật', CAST(N'2020-07-07' AS Date), N'Hoá học là một trong những lĩnh vực của khoa học tự nhiên nghiên cứu về thế giới vật chất và sự vận động của nó, nhằm tìm ra các quy luật vận động để vận dụng vào cuộc sống.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100015  ', N'Quản Lý Dự Án Xây Dựng - Cẩm Nang Hướng Dẫn Thực Hành Quản Lý Thi Công Tại Công Trường', N'TL100010  ', 37, N'Khoa học và kỹ thuậtNxb Tổng hợp TP.HCM', CAST(N'2020-07-07' AS Date), N'Cầu đường bộ với một bản dự toán chi phí hoàn chỉnh, bao gồm các đơn vị đo lường quốc tế SI, sẽ minh họa cụ thể từng nguyên tắc quản lý dự án. Bằng cách sử dụng thông tin cơ bản này và các tình huống nghiên cứu trong phần phụ lục, độc giả sẽ có cơ hội nhận diện các vấn đề trong quản lý dự án và trải nghiệm cách thức xử lý thực tiễn.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100019  ', N'Điều Khiển Xa Với ARDUINO & ESP32', N'TL100000  ', 34, N'Thanh Niên', CAST(N'2020-07-07' AS Date), N'Sách "Điều Khiển Xa Với ARDUINO & ESP32" giúp bạn bắt đầu làm việc với công nghệ phổ biến nhất trong thời điểm hiện tại (truyền thông không dây) để kết nối các thiết bị và hệ thống với Internet bằng cảm biến. ')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100020  ', N'Sổ Tay Kỹ Thuật Thi Công Nhà Ở Gia Đình', N'TL100010  ', 30, N'NXB Khoa học và kỹ thuật', CAST(N'2020-07-07' AS Date), N'Cuốn sổ tay này chủ yếu đề cập đến các yêu cầu và kỹ thuật thi công các bộ phận của nhà, đặc biệt là một số kinh nghiệm từ thực thể thi công chống thấm cho mái bằng, cho tường ngoài, cho tường khu phụ, cho bể nước,... chống nóng cho mái bằng và nhất là kỹ thuật thi công móng của các loại đất nền, móng khi xây chen, móng cọc tre, khắc phục hiện tượng cát chảy; làm bếp cải tiến xây bể tự hoại,..')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100021  ', N'Công Suất - Bộ Biến Đổi Cộng Hưởng Và Ballast Điện Tử', N'TL100000  ', 35, N'Thanh Niên', CAST(N'2020-07-07' AS Date), N': Điện tử công suất là môn học đã và đang được đưa vào giảng dạy tại các trường Cao đẳng, Đại học chuyên ngành điện. Môn học Điện tử công suất ngoài việc nghiên cứu bản chất vật lý, các quá trình diễn ra trong các linh kiện điện tử công suất như Diode, Thyristor, GTO, Triac, Mosfet công suất, IGBT, SID, MCT... làm việc ở chế độ chuyển mạch trong quá trình biến đổi điện năng. Khảo sát các tính năng kỹ thuật và những ứng dụng của các linh kiện này.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100022  ', N'. Cơ Sở Thiết Kế Và Gia Công Cơ Khí', N'TL100000  ', 38, N'Bách khoa Hà Nội', CAST(N'2020-07-07' AS Date), N'Cuốn sách này được biên soạn theo yêu cầu dạy học chuyên ngành lắp đặt và bảo trì sửa chữa thiết bị cơ điện cùng các chuyên ngành liên quan trong các trường trung cấp nghề hiện nay của Trung Quốc, có tham khảo các quy phạm thẩm định kỹ năng nghề của các ngành nghề liên quan và tiêu chuẩn cấp bậc công nhân kỹ thuật. ')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100023  ', N'Ngôi Nhà Hạnh Phúc', N'TL100008  ', 39, N'Nxb Tổng hợp TP.HCM', CAST(N'2020-07-07' AS Date), N'Tuy đã giảng dạy lâu năm về kiến trúc, nhưng khi được yêu cầu trình bày về ngôi nhà của thường dân người Việt, kiến trúc sư Thái thú nhận bản thân mình cũng lúng túng do chưa am hiểu thấu đáo về sự xuất hiện, tồn tại và biến chuyển của ngôi nhà. Chỉ gần đây, do yêu cầu viết một biên khảo về nếp ở của người Việt, anh mới tập trung nghiên cứu lại vấn đề một cách căn cơ hơn.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100024  ', N'Giai Tích', N'TL100006  ', 19, N'NXB Dân Trí', CAST(N'2020-07-07' AS Date), N'Toán học đại học .')
GO
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100000  ', N'Jeff Atwood', CAST(N'2020-09-07' AS Date), N'aaa')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100001  ', N'Tony Crilly', CAST(N'2020-10-07' AS Date), N'bb')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100002  ', N'Michio Kaku', CAST(N'2000-02-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100003  ', N'S. Keoki Sears Glenn', CAST(N'2000-10-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100004  ', N'Nguyễn Bá Đô', CAST(N'1991-02-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100006  ', N'Bunpei Yorifuji', CAST(N'2000-07-06' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100007  ', N'Nguyễn Hữu Thái', CAST(N'2000-08-07' AS Date), N'Tuy đã giảng dạy lâu năm về kiến trúc, nhưng khi được yêu cầu trình bày về ngôi nhà của thường dân người Việt, kiến trúc sư Thái thú nhận bản thân mình cũng lúng túng do chưa am hiểu thấu đáo về sự xuất hiện, tồn tại và biến chuyển của ngôi nhà. Chỉ gần đây, do yêu cầu viết một biên khảo về nếp ở của người Việt, anh mới tập trung nghiên cứu lại vấn đề một cách căn cơ hơn.')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100008  ', N'Carlo Rovelli', CAST(N'2020-07-02' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100009  ', N'Nguyễn thị Mi Sa', CAST(N'1999-07-22' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100010  ', N'Phạm Quang Huy', CAST(N'1990-07-15' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100011  ', N'Đàm Ngạn Phú', CAST(N'1888-07-22' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100012  ', N'Lê Trường Thông', CAST(N'1990-07-19' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100013  ', N'NXB Thanh Niên', CAST(N'1898-01-13' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100014  ', N'Nhã Phong', CAST(N'1896-01-19' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100015  ', N'Trần Thị Minh Hiếu', CAST(N'1768-01-06' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100016  ', N'Thới Ngọc Tuấn Quốc', CAST(N'1990-05-21' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100017  ', N'Theodore Gray', CAST(N'1898-07-13' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100019  ', N'A. Sears Richard H.Clough', CAST(N'1889-09-14' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100020  ', N'Lê Nguyễn Hồng Phong', CAST(N'1569-02-14' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100021  ', N'Phạm Quang Huy', CAST(N'1888-08-14' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100022  ', N'GS Phạm Văn Ất', CAST(N'2000-07-22' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100023  ', N'Mickaël Launay', CAST(N'2000-01-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100024  ', N'Gerry Bailey', CAST(N'1999-02-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100025  ', N'Kim Min-Soo', CAST(N'1888-07-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100026  ', N'Nguyễn Minh Tuyền', CAST(N'1887-10-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100027  ', N'Lê Sỹ Phong', CAST(N'1888-09-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100028  ', N'Nguyễn Bá Đô', CAST(N'1888-02-07' AS Date), N'Không có thông tin')
GO
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100011  ', N'TG100025  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100010  ', N'TG100024  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100006  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100005  ', N'TG100003  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100004  ', N'TG100023  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100000  ', N'TG100000  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100014  ', N'TG100026  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100014  ', N'TG100027  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100015  ', N'TG100003  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100015  ', N'TG100019  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100000  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100000  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100012  ', N'TG100006  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100013  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100013  ', N'TG100017  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100008  ', N'TG100008  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100007  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100001  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100003  ', N'TG100001  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100001  ', N'TG100022  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100009  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100024  ', N'TG100001  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100023  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100023  ', N'TG100024  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100024  ', N'TG100021  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100019  ', N'TG100010  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100019  ', N'TG100009  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100020  ', N'TG100004  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100021  ', N'TG100020  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100021  ', N'TG100021  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100022  ', N'TG100011  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100002  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100002  ', N'TG100006  ')
GO
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100000  ', N'123')
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100005  ', N'12345')
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100002  ', N'123')
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100004  ', N'123')
GO
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100000  ', N'Điện , Điện Tử , Tự Động Hóa', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100001  ', N'Khoa Học', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100003  ', N'Tham Khảo', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100004  ', N'CNTT', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100006  ', N'Toán', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100007  ', N'Vật Lý', N'1111111111111')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100008  ', N'Kiến Trúc', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100009  ', N'Hóa Học', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100010  ', N'Xây Dựng', N'Không có thông tin')
GO
ALTER TABLE [dbo].[DanhSachPhieu]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhieu_Phieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[DanhSachPhieu] CHECK CONSTRAINT [FK_DanhSachPhieu_Phieu]
GO
ALTER TABLE [dbo].[DanhSachPhieu]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhieu_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[DanhSachPhieu] CHECK CONSTRAINT [FK_DanhSachPhieu_Sach]
GO
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_Docgia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[Docgia] ([MaDG])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_Docgia]
GO
ALTER TABLE [dbo].[QuanLyPhieu]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyPhieu_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[QuanLyPhieu] CHECK CONSTRAINT [FK_QuanLyPhieu_Nhanvien]
GO
ALTER TABLE [dbo].[QuanLyPhieu]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyPhieu_Phieu] FOREIGN KEY([MaPH])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[QuanLyPhieu] CHECK CONSTRAINT [FK_QuanLyPhieu_Phieu]
GO
ALTER TABLE [dbo].[QuanLySach]  WITH CHECK ADD  CONSTRAINT [FK_QuanLySach_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[QuanLySach] CHECK CONSTRAINT [FK_QuanLySach_Nhanvien]
GO
ALTER TABLE [dbo].[QuanLySach]  WITH CHECK ADD  CONSTRAINT [FK_QuanLySach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[QuanLySach] CHECK CONSTRAINT [FK_QuanLySach_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoai]
GO
ALTER TABLE [dbo].[TacGiaVietSach]  WITH CHECK ADD  CONSTRAINT [FK_TacGiaVietSach_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[TacGiaVietSach] CHECK CONSTRAINT [FK_TacGiaVietSach_TacGia]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_Nhanvien]
GO
=======
﻿﻿
--Tao database 

create database [QuanLyThuvien]
go
use QuanLyThuVien
--Tao Danh Sach PHIEU 


CREATE TABLE [dbo].[DanhSachPhieu](
	[MaPhieu] [char](10) NULL,
	[MaSach] [char](10) NULL,
	[SL] [int] NULL
) 
--Tao bang doc gia

CREATE TABLE [dbo].[Docgia](
	[MaDG] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[NgaySinh] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	PRIMARY KEY ([MaDG])
)	

--Tao bang Nhan vien

CREATE TABLE [dbo].[Nhanvien](
	[MaNV] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[NgaySinh] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhanQuyen] [nvarchar](20) NULL,
PRIMARY KEY ([MaNV])
) 
--Tao TABLE Phieu
CREATE TABLE [dbo].[Phieu](
	[MaPhieu] [char](10) NOT NULL,
	[MaDG] [char](10) NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
	[LoaiPhieu] [nvarchar](20) NULL,
	[Tong] [int] NULL,
		PRIMARY KEY ([MaPHIEU])
)

--Tao table quan ly phieu 
CREATE TABLE [dbo].[QuanLyPhieu](
	[MaNV] [char](10) NULL,
	[MaPH] [char](10) NULL
)

--Tao table quan ly sach 
CREATE TABLE [dbo].[QuanLySach](
	[MaNV] [char](10) NULL,
	[MaSach] [char](10) NULL
) 
--Tao bang   sach
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](10) NOT NULL,
	[TenSach] [nvarchar](100) NULL,
	[MaTL] [char](10) NULL,
	[SL] [int] NULL,
	[NXB] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[NoiDung] [nvarchar](max) NULL,
  PRIMARY KEY ([MaSach])
) 

--Tao bang  tac gia
CREATE TABLE [dbo].[TacGia](
	[MaTG] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiThieu] [nvarchar](max) NULL,
  PRIMARY KEY ([MaTG])
  )
 --Tao bang doc tac gia viet sach

CREATE TABLE [dbo].[TacGiaVietSach](
	[Masach] [char](10) NULL,
	[MaTG] [char](10) NULL
) 

--Tao bang Tai Khoan

CREATE TABLE [dbo].[TaiKhoan](
	[MaNV] [char](10) NULL,
	[MK] [nvarchar](10) NULL
)

--Tao bang  the loai


CREATE TABLE [dbo].[TheLoai](
	[MaTL] [char](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[ThongTin] [nvarchar](max) NULL,
	  PRIMARY KEY ([MaTL])
)

INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100001  ', N'SG100008  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100001  ', N'SG100007  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100006  ', N'SG100009  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100000  ', N'SG100000  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100000  ', N'SG100007  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100000  ', N'SG100006  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100001  ', N'SG100004  ', 3)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100011  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100010  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100006  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100003  ', N'SG100005  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100005  ', N'SG100005  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100004  ', 3)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100001  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100003  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100002  ', N'SG100006  ', 1)
INSERT [dbo].[DanhSachPhieu] ([MaPhieu], [MaSach], [SL]) VALUES (N'PM100004  ', N'SG100004  ', 1)
GO
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071111', N'Pham Trong Truong 1', N'Nam', N'0353573467', CAST(N'2020-07-16' AS Date), N'Quận 9', N'truong@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071112', N'Trần Đức Vũ', N'Nam', N'0363636569', CAST(N'2000-07-01' AS Date), N'Quận 9', N'Tranducvu23@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071113', N'Trần Đức Bo', N'Nam', N'0365696844', CAST(N'1999-07-03' AS Date), N'Quận 10', N'Ducbo@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071114', N'Lê Thị Riêng', N'Nữ', N'0353656954', CAST(N'2002-07-03' AS Date), N'Quận 7', N'Rieng@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071115', N'Trần Phúc Long', N'Nam', N'0354585475', CAST(N'0200-07-23' AS Date), N'Quận 8', N'Longml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071116', N'Ngô Thanh Vân', N'Nữ', N'0365847584', CAST(N'1998-07-16' AS Date), N'Quận 9', N'Vanml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071117', N'Trần Thanh Trình', N'Nữ', N'0358585879', CAST(N'2000-07-17' AS Date), N'Quận 8', N'Trinhml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071118', N'Trần Thanh Quý', N'Nam', N'0356864975', CAST(N'2000-07-09' AS Date), N'Quận 9', N'Quyml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071119', N'Hoàng Huy Hậu', N'Nam', N'0358457589', CAST(N'2000-07-02' AS Date), N'Quận 9', N'Hauml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071120', N'Lê Thị Mỹ Trinh', N'Nữ', N'0965865458', CAST(N'1999-07-08' AS Date), N'Quận 9', N'Trinhml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071121', N'Lê Hoài Anh', N'Nam', N'0956854858', CAST(N'2000-07-09' AS Date), N'Quận 9', N'Anhml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071122', N'Nguyễn Tố Nữ', N'Nữ', N'0965865454', CAST(N'2000-07-10' AS Date), N'Quận 9', N'Numl@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071123', N'Trần Thị Tuyền', N'Nam', N'0356458547', CAST(N'2000-07-02' AS Date), N'Quận 10', N'Tuyenml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071124', N'Nguyễn Thanh Nam', N'Nam', N'0366585474', CAST(N'1999-07-15' AS Date), N'Quận 7', N'Namml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071125', N'Nguyễn Thành Long', N'Nam', N'0363636568', CAST(N'2000-07-03' AS Date), N'Quận 10', N'Longml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071126', N'Hồ Thị Tư', N'Nam', N'0356854857', CAST(N'2000-07-09' AS Date), N'Quận 8', N'Tuml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071127', N'Hoàng Văn A', N'Nam', N'0958654555', CAST(N'2000-07-02' AS Date), N'Quận 9', N'Aaaa@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071128', N'Lê Thị Tiên', N'Nữ', N'0958665585', CAST(N'2000-07-09' AS Date), N'Quận 9', N'Tienml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071129', N'Lê Anh Đào', N'Nữ', N'0365447458', CAST(N'2000-07-16' AS Date), N'Quận 6', N'Daoml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071130', N'Nguyễn Thanh An', N'Nữ', N'0369598547', CAST(N'2001-07-24' AS Date), N'Quận 7', N'Anml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071131', N'Trần Thị Quý', N'Nữ', N'0366666999', CAST(N'2000-07-24' AS Date), N'Quận 9', N'Quyml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071132', N'Nguyễn Thanh Ân', N'Nữ', N'0369598547', CAST(N'2001-07-24' AS Date), N'Quận 8', N'Anml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071133', N'Trần Phúc Hậu', N'Nữ', N'0354585444', CAST(N'0200-07-22' AS Date), N'Quận 10', N'Hauml1@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071134', N'Trần Thanh Bảo', N'Nữ', N'0358581111', CAST(N'2000-07-06' AS Date), N'Quận 9', N'Baoml11@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071135', N'Ngô Thanh Thảo', N'Nữ', N'0365847522', CAST(N'1999-07-16' AS Date), N'Quận 10', N'Thaoml@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071136', N'Trần Thanh Vương', N'Nữ', N'0356277772', CAST(N'2000-07-01' AS Date), N'Quận 10', N'Vuongml123@gmail.com')
INSERT [dbo].[Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email]) VALUES (N'5951071137', N'Trần Đức Vũ', N'Nam', N'0363636569', CAST(N'2000-08-16' AS Date), N'Quận 9', N'Tranducvu23@gmail.com')
GO
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100000  ', N'Trường', N'Nam', N'0353573467', CAST(N'2020-07-10' AS Date), N'Quận 9', N'truong@gmail.com', N'Nhân Viên')
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100002  ', N'Tuấn', N'Nam', N'0369696896', CAST(N'2000-07-14' AS Date), N'Quận 9', N'Tuanml@gmail.com', N'Nhân Viên')
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100004  ', N'Vũ', N'Nam', N'0369696896', CAST(N'2000-03-14' AS Date), N'Quận 9', N'Vuml@gmail.com', N'Nhân Viên')
INSERT [dbo].[Nhanvien] ([MaNV], [Ten], [GioiTinh], [SDT], [NgaySinh], [Diachi], [Email], [PhanQuyen]) VALUES (N'NV100005  ', N'Nguyễn Hoàng Vương', N'Nam', N'0365868584', CAST(N'2000-04-12' AS Date), N'Quận 9', N'Vuongmk@gmail.com', N'Quản Lý')
GO
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100000  ', N'5951071111', CAST(N'2020-07-07' AS Date), CAST(N'2020-07-21' AS Date), N'Phieu Tra', 1)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100001  ', N'5951071119', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Tra', 5)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100002  ', N'5951071117', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Tra', 6)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100003  ', N'5951071120', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 4)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100004  ', N'5951071114', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 1)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100005  ', N'5951071112', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 1)
INSERT [dbo].[Phieu] ([MaPhieu], [MaDG], [NgayMuon], [NgayTra], [LoaiPhieu], [Tong]) VALUES (N'PM100006  ', N'5951071118', CAST(N'2020-07-08' AS Date), CAST(N'2020-07-22' AS Date), N'Phieu Muon', 1)
GO
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100001  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100004  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100002  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100006  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100000  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100003  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100000  ', N'PM100005  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100005  ', N'PM100005  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100002  ', N'PM100005  ')
INSERT [dbo].[QuanLyPhieu] ([MaNV], [MaPH]) VALUES (N'NV100004  ', N'PM100005  ')
GO
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100000  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100005  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100006  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100007  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100008  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100009  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100010  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100011  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100012  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100013  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100014  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100015  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100001  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100002  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100003  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100004  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100019  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100020  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100021  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100022  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100023  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100000  ', N'SG100024  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100005  ', N'SG100024  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100002  ', N'SG100024  ')
INSERT [dbo].[QuanLySach] ([MaNV], [MaSach]) VALUES (N'NV100004  ', N'SG100024  ')
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100000  ', N'Lập trình và cuộc sống ', N'TL100004  ', 29, N'NXB Thanh Niên', CAST(N'2020-07-07' AS Date), N'Anh cần một cách để theo dõi sự phát triển của phần mềm theo thời gian-bất cứ điều gì anh ta nghĩ đến hoặc làm việc trên nó. Jeff đã nghiên cứu các chủ đề mà anh cảm thấy thú vị, sau đó ghi lại nghiên cứu của mình bằng một bài đăng trên blog mà anh có thể dễ dàng tìm lại và tham khải sau này.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100001  ', N'Giáo Trình C++ & Lập Trình Hướng Đối Tượng', N'TL100004  ', 18, N'NXB Hồng Đức', CAST(N'2020-07-07' AS Date), N'Giáo trình C++ & lập trình hướng đối tượng” trình bày một cách hệ thống các khái niệm của lập trình hướng đối tượng được cài đặt trong C++ như lớp, đối tượng, sự thừa kế, tính tương ứng bội và các khả năng mới trong xây dựng, sử dụng hàm như đối tham chiếu, đối mặc định, hàm trùng tên, hàm toán tử.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100002  ', N'Lập Trình Với C# ', N'TL100004  ', 20, N'NXB Thanh Niên', CAST(N'2020-07-07' AS Date), N'Trình bày các khai niên và xây dựng ứng dụng bằng ngôn ngữ c#')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100003  ', N'Những Câu Hỏi Lớn', N'TL100006  ', 12, N'NXB Dân Trí', CAST(N'2020-07-07' AS Date), N'NHỮNG CÂU HỎI LỚN đề cập đến những vấn đề cơ bản trong khoa học tự nhiên và xã hội, nhưng vẫn khiến những bộ óc vĩ đại trong lịch sử đau đầu.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100004  ', N'Một Thiên Tiểu Thuyết', N'TL100006  ', 17, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Hầu hết mọi người đều thích toán, tiếc là họ không biết điều này!
Bởi ai mà chẳng thấy hấp dẫn với những mẩu chuyện kỳ thú về toán: như “giáo phái” toán học kỳ lạ của Pythagoras thời cổ đại hay những cuộc thăm dò hệ mặt trời bằng công cụ toán học đầy kịch tính thời cận đại, hoặc gần đây hơn là sự kiện máy tính AlphaGo giành chiến thắng trước kỳ thủ cờ vây số một thế giới Lee Sedol bằng những nước đi “thần thánh” sử dụng lý thuyết xác suất
')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100005  ', N'A Mind For Numbers - Cách Chinh Phục Toán Và Khoa Học', N'TL100006  ', 25, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'A Mind for Numbers- Cách chinh phục Toán và Khoa học, đưa ra các cách thức giúp học sinh – sinh viên đang gặp rắc rối với môn toán và khoa học biết cách khai mở và sử dụng nguồn tài nguyên vô tận trong chính bộ não của mình, qua đó không chỉ chinh phục thành công bộ môn này mà đồng trời trở nên xuất sắc hơn bao giờ hết. Cuốn sách cũng giúp ích cho những người đã đi làm biết cách sáng tạo và sắp xếp công việc của mình, đồng thời phát triển nó lên một tầm cao mới, thông qua các kỹ thuật tư duy hoàn hảo.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100006  ', N'Những Điều Tưởng Chừng Bất Khả', N'TL100007  ', 27, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'trong Vật lý của những điều tưởng chừng bất khả, nhà vật lý Michio Kaku khám phá khả năng đưa những công nghệ và thiết bị từ lãnh địa của khoa học viễn tưởng vào cuộc sống thường nhật trong tương lai.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100007  ', N'Vật Lý Của Những Điều Tưởng Chừng Bất Khả', N'TL100007  ', 13, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Trong Vật lý của những điều tưởng chừng bất khả, nhà vật lý Michio Kaku khám phá khả năng đưa những công nghệ và thiết bị từ lãnh địa của khoa học viễn tưởng vào cuộc sống thường nhật trong tương lai.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100008  ', N'Bài Học Hay Nhất Về Vật Lý ', N'TL100007  ', 33, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Cuốn sách 7 bài học hay nhất về Vật lý là một bản tổng kết nhanh những tri thức quan trọng đã tạo nên cuộc cách mạng vĩ đại trong nền vật lý thế kỷ XX như thuyết tương đối rộng, cơ học lượng tử, vũ trụ học, hạt cơ bản, lý thuyết hấp dẫn lượng tử, hố đen. Cuốn sách cũng đề cập đến ý nghĩa của tất cả những tri thức ấy với nhận thức của con người ngày nay.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100009  ', N'Ngôi Nhà Việt', N'TL100008  ', 34, N'Nxb Tổng hợp TP.HCM', CAST(N'2020-07-07' AS Date), N'Tuy đã giảng dạy lâu năm về kiến trúc, nhưng khi được yêu cầu trình bày về ngôi nhà của thường dân người Việt, kiến trúc sư Thái thú nhận bản thân mình cũng lúng túng do chưa am hiểu thấu đáo về sự xuất hiện, tồn tại và biến chuyển của ngôi nhà. Chỉ gần đây, do yêu cầu viết một biên khảo về nếp ở của người Việt, anh mới tập trung nghiên cứu lại vấn đề một cách căn cơ hơn.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100010  ', N'Những Ngôi Nhà Kết Hợp Công Việc', N'TL100008  ', 39, N'Nxb Trẻ', CAST(N'2020-07-07' AS Date), N'Bộ sách dành cho bạn trẻ luôn mong muốn sau này chính tay mình dựng lên những tòa nhà trong mơ dành cho mình và người thân, bạn bè.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100011  ', N'Khám Phá Thiết Kế Đô Thị Hàn Quốc', N'TL100008  ', 26, N'NXB Văn hóa - Văn nghệ', CAST(N'2020-07-07' AS Date), N'Có thể nói rằng vấn đề của bản sắc đô thị Hàn Quốc nảy sinh từ chính sự thiếu nhận thức về bản thân chứ không phải từ điều gì khác. Điều này một phần cũng do những sai lầm lịch sử lâu dài bắt đầu từ thời Nhật đô hộ khi người Hàn Quốc dần quen nhìn nhận cuộc sống và không gian sống của bản thân bằng cái nhìn của người khác….')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100012  ', N'Cuộc Sống Diệu Kỳ Của Các Nguyên Tố', N'TL100009  ', 37, N'Nxb Thế giới', CAST(N'2020-07-07' AS Date), N'Cuốn sách Cuộc Sống Diệu Kỳ Của Các Nguyên Tố thực sự là một sự kết hợp hoàn hảo giữa kiến thức khoa học kỳ thú và nghệ thuật vẽ truyện tranh đầy màu sắc. Dưới bàn tay khéo léo của họa sĩ Bunpei Yorifuji, thế giới siêu nhỏ của những hạt cơ bản trở nên sống động và gần gũi hơn bao giờ hết')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100013  ', N'Nguyên Tố - Khám Phá Các Nguyên Tử Trong Vũ Trụ Qua Hình Ảnh', N'TL100009  ', 25, N'Nxb Trẻ', CAST(N'2020-07-07' AS Date), N'Theodore Gray say mê bảng tuần hoàn. Và bộ sưu tập các nguyên tố của ông sáng ngang với bất kỳ viện bảo tàng nào. Với sự hóm hĩnh đặc trưng và kiến thức uyên bác. Và trên hết là những bức ảnh lộng lẫy, ông đã cho thấy những ví dụ hấp dẫn - trải dài từ những điều tầm thường đến những ngã rẽ quanh co - về các tính chất và ứng dụng của mỗi nguyên tố')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100014  ', N'Giáo Trình Hoá Học Đại Cương', N'TL100009  ', 22, N'Khoa học và kỹ thuật', CAST(N'2020-07-07' AS Date), N'Hoá học là một trong những lĩnh vực của khoa học tự nhiên nghiên cứu về thế giới vật chất và sự vận động của nó, nhằm tìm ra các quy luật vận động để vận dụng vào cuộc sống.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100015  ', N'Quản Lý Dự Án Xây Dựng - Cẩm Nang Hướng Dẫn Thực Hành Quản Lý Thi Công Tại Công Trường', N'TL100010  ', 37, N'Khoa học và kỹ thuậtNxb Tổng hợp TP.HCM', CAST(N'2020-07-07' AS Date), N'Cầu đường bộ với một bản dự toán chi phí hoàn chỉnh, bao gồm các đơn vị đo lường quốc tế SI, sẽ minh họa cụ thể từng nguyên tắc quản lý dự án. Bằng cách sử dụng thông tin cơ bản này và các tình huống nghiên cứu trong phần phụ lục, độc giả sẽ có cơ hội nhận diện các vấn đề trong quản lý dự án và trải nghiệm cách thức xử lý thực tiễn.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100019  ', N'Điều Khiển Xa Với ARDUINO & ESP32', N'TL100000  ', 34, N'Thanh Niên', CAST(N'2020-07-07' AS Date), N'Sách "Điều Khiển Xa Với ARDUINO & ESP32" giúp bạn bắt đầu làm việc với công nghệ phổ biến nhất trong thời điểm hiện tại (truyền thông không dây) để kết nối các thiết bị và hệ thống với Internet bằng cảm biến. ')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100020  ', N'Sổ Tay Kỹ Thuật Thi Công Nhà Ở Gia Đình', N'TL100010  ', 30, N'NXB Khoa học và kỹ thuật', CAST(N'2020-07-07' AS Date), N'Cuốn sổ tay này chủ yếu đề cập đến các yêu cầu và kỹ thuật thi công các bộ phận của nhà, đặc biệt là một số kinh nghiệm từ thực thể thi công chống thấm cho mái bằng, cho tường ngoài, cho tường khu phụ, cho bể nước,... chống nóng cho mái bằng và nhất là kỹ thuật thi công móng của các loại đất nền, móng khi xây chen, móng cọc tre, khắc phục hiện tượng cát chảy; làm bếp cải tiến xây bể tự hoại,..')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100021  ', N'Công Suất - Bộ Biến Đổi Cộng Hưởng Và Ballast Điện Tử', N'TL100000  ', 35, N'Thanh Niên', CAST(N'2020-07-07' AS Date), N': Điện tử công suất là môn học đã và đang được đưa vào giảng dạy tại các trường Cao đẳng, Đại học chuyên ngành điện. Môn học Điện tử công suất ngoài việc nghiên cứu bản chất vật lý, các quá trình diễn ra trong các linh kiện điện tử công suất như Diode, Thyristor, GTO, Triac, Mosfet công suất, IGBT, SID, MCT... làm việc ở chế độ chuyển mạch trong quá trình biến đổi điện năng. Khảo sát các tính năng kỹ thuật và những ứng dụng của các linh kiện này.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100022  ', N'. Cơ Sở Thiết Kế Và Gia Công Cơ Khí', N'TL100000  ', 38, N'Bách khoa Hà Nội', CAST(N'2020-07-07' AS Date), N'Cuốn sách này được biên soạn theo yêu cầu dạy học chuyên ngành lắp đặt và bảo trì sửa chữa thiết bị cơ điện cùng các chuyên ngành liên quan trong các trường trung cấp nghề hiện nay của Trung Quốc, có tham khảo các quy phạm thẩm định kỹ năng nghề của các ngành nghề liên quan và tiêu chuẩn cấp bậc công nhân kỹ thuật. ')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100023  ', N'Ngôi Nhà Hạnh Phúc', N'TL100008  ', 39, N'Nxb Tổng hợp TP.HCM', CAST(N'2020-07-07' AS Date), N'Tuy đã giảng dạy lâu năm về kiến trúc, nhưng khi được yêu cầu trình bày về ngôi nhà của thường dân người Việt, kiến trúc sư Thái thú nhận bản thân mình cũng lúng túng do chưa am hiểu thấu đáo về sự xuất hiện, tồn tại và biến chuyển của ngôi nhà. Chỉ gần đây, do yêu cầu viết một biên khảo về nếp ở của người Việt, anh mới tập trung nghiên cứu lại vấn đề một cách căn cơ hơn.')
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTL], [SL], [NXB], [NgayNhap], [NoiDung]) VALUES (N'SG100024  ', N'Giai Tích', N'TL100006  ', 19, N'NXB Dân Trí', CAST(N'2020-07-07' AS Date), N'Toán học đại học .')
GO
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100000  ', N'Jeff Atwood', CAST(N'2020-09-07' AS Date), N'aaa')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100001  ', N'Tony Crilly', CAST(N'2020-10-07' AS Date), N'bb')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100002  ', N'Michio Kaku', CAST(N'2000-02-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100003  ', N'S. Keoki Sears Glenn', CAST(N'2000-10-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100004  ', N'Nguyễn Bá Đô', CAST(N'1991-02-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100006  ', N'Bunpei Yorifuji', CAST(N'2000-07-06' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100007  ', N'Nguyễn Hữu Thái', CAST(N'2000-08-07' AS Date), N'Tuy đã giảng dạy lâu năm về kiến trúc, nhưng khi được yêu cầu trình bày về ngôi nhà của thường dân người Việt, kiến trúc sư Thái thú nhận bản thân mình cũng lúng túng do chưa am hiểu thấu đáo về sự xuất hiện, tồn tại và biến chuyển của ngôi nhà. Chỉ gần đây, do yêu cầu viết một biên khảo về nếp ở của người Việt, anh mới tập trung nghiên cứu lại vấn đề một cách căn cơ hơn.')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100008  ', N'Carlo Rovelli', CAST(N'2020-07-02' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100009  ', N'Nguyễn thị Mi Sa', CAST(N'1999-07-22' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100010  ', N'Phạm Quang Huy', CAST(N'1990-07-15' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100011  ', N'Đàm Ngạn Phú', CAST(N'1888-07-22' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100012  ', N'Lê Trường Thông', CAST(N'1990-07-19' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100013  ', N'NXB Thanh Niên', CAST(N'1898-01-13' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100014  ', N'Nhã Phong', CAST(N'1896-01-19' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100015  ', N'Trần Thị Minh Hiếu', CAST(N'1768-01-06' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100016  ', N'Thới Ngọc Tuấn Quốc', CAST(N'1990-05-21' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100017  ', N'Theodore Gray', CAST(N'1898-07-13' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100019  ', N'A. Sears Richard H.Clough', CAST(N'1889-09-14' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100020  ', N'Lê Nguyễn Hồng Phong', CAST(N'1569-02-14' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100021  ', N'Phạm Quang Huy', CAST(N'1888-08-14' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100022  ', N'GS Phạm Văn Ất', CAST(N'2000-07-22' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100023  ', N'Mickaël Launay', CAST(N'2000-01-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100024  ', N'Gerry Bailey', CAST(N'1999-02-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100025  ', N'Kim Min-Soo', CAST(N'1888-07-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100026  ', N'Nguyễn Minh Tuyền', CAST(N'1887-10-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100027  ', N'Lê Sỹ Phong', CAST(N'1888-09-07' AS Date), N'Không có thông tin')
INSERT [dbo].[TacGia] ([MaTG], [Ten], [NgaySinh], [GioiThieu]) VALUES (N'TG100028  ', N'Nguyễn Bá Đô', CAST(N'1888-02-07' AS Date), N'Không có thông tin')
GO
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100011  ', N'TG100025  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100010  ', N'TG100024  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100006  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100005  ', N'TG100003  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100004  ', N'TG100023  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100000  ', N'TG100000  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100014  ', N'TG100026  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100014  ', N'TG100027  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100015  ', N'TG100003  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100015  ', N'TG100019  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100000  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100000  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100012  ', N'TG100006  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100013  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100013  ', N'TG100017  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100008  ', N'TG100008  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100007  ', N'TG100002  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100001  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100003  ', N'TG100001  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100001  ', N'TG100022  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100009  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100024  ', N'TG100001  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100023  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100023  ', N'TG100024  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100024  ', N'TG100021  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100019  ', N'TG100010  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100019  ', N'TG100009  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100020  ', N'TG100004  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100021  ', N'TG100020  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100021  ', N'TG100021  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100022  ', N'TG100011  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100002  ', N'TG100007  ')
INSERT [dbo].[TacGiaVietSach] ([Masach], [MaTG]) VALUES (N'SG100002  ', N'TG100006  ')
GO
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100000  ', N'123')
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100005  ', N'12345')
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100002  ', N'123')
INSERT [dbo].[TaiKhoan] ([MaNV], [MK]) VALUES (N'NV100004  ', N'123')
GO
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100000  ', N'Điện , Điện Tử , Tự Động Hóa', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100001  ', N'Khoa Học', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100003  ', N'Tham Khảo', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100004  ', N'CNTT', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100006  ', N'Toán', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100007  ', N'Vật Lý', N'1111111111111')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100008  ', N'Kiến Trúc', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100009  ', N'Hóa Học', N'Không có thông tin')
INSERT [dbo].[TheLoai] ([MaTL], [Ten], [ThongTin]) VALUES (N'TL100010  ', N'Xây Dựng', N'Không có thông tin')
GO
ALTER TABLE [dbo].[DanhSachPhieu]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhieu_Phieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[DanhSachPhieu] CHECK CONSTRAINT [FK_DanhSachPhieu_Phieu]
GO
ALTER TABLE [dbo].[DanhSachPhieu]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhieu_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[DanhSachPhieu] CHECK CONSTRAINT [FK_DanhSachPhieu_Sach]
GO
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_Docgia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[Docgia] ([MaDG])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_Docgia]
GO
ALTER TABLE [dbo].[QuanLyPhieu]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyPhieu_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[QuanLyPhieu] CHECK CONSTRAINT [FK_QuanLyPhieu_Nhanvien]
GO
ALTER TABLE [dbo].[QuanLyPhieu]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyPhieu_Phieu] FOREIGN KEY([MaPH])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[QuanLyPhieu] CHECK CONSTRAINT [FK_QuanLyPhieu_Phieu]
GO
ALTER TABLE [dbo].[QuanLySach]  WITH CHECK ADD  CONSTRAINT [FK_QuanLySach_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[QuanLySach] CHECK CONSTRAINT [FK_QuanLySach_Nhanvien]
GO
ALTER TABLE [dbo].[QuanLySach]  WITH CHECK ADD  CONSTRAINT [FK_QuanLySach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[QuanLySach] CHECK CONSTRAINT [FK_QuanLySach_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoai]
GO
ALTER TABLE [dbo].[TacGiaVietSach]  WITH CHECK ADD  CONSTRAINT [FK_TacGiaVietSach_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[TacGiaVietSach] CHECK CONSTRAINT [FK_TacGiaVietSach_TacGia]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_Nhanvien]
GO
master
