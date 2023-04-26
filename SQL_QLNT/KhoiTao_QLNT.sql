	--	Khởi tạo CSDL	--

IF NOT EXISTS ( SELECT name FROM sys.databases WHERE name = N'QLNT')
BEGIN
	CREATE DATABASE QLNT
	ON PRIMARY
	(
		NAME = 'NhaThuocPrimary',
		FILENAME = 'D:\QLNT\QuanLyNhaThuoc\SQL_QLNT\QLNT.mdf',
		SIZE = 10MB,
		FILEGROWTH = 20%,
		MAXSIZE = 50MB
	),
	FILEGROUP MedData
	(
		NAME= 'NhaThuocData',
		FILENAME= 'D:\QLNT\QuanLyNhaThuoc\SQL_QLNT\QLNTData.ndf',
		SIZE= 10MB,
		FILEGROWTH= 20%,
		MAXSIZE = 50MB
	)
	LOG ON
	(
		NAME = 'NhaThuoc_log',
		FILENAME = 'D:\QLNT\QuanLyNhaThuoc\SQL_QLNT\QLNT_log.ldf',
		SIZE = 10MB,
		FILEGROWTH = 20%,
		MAXSIZE = 50MB
	)
END 
GO

	--	Tạo bảng	--

use QLNT
go

IF OBJECT_ID('Loai', 'U') IS NULL AND OBJECT_ID('DuocPham', 'U') IS NULL AND OBJECT_ID('Nguoi', 'U') IS NULL
BEGIN
	create table Loai
	(
		MaLoai int identity(1,1) primary key not null,
		TenLoai nvarchar(20) unique null,
		GhiChu nvarchar(100) null
	) on MedData
	create table DuocPham
	(
		MaDP int identity(1,1) primary key not null,
		TenDP nvarchar(30) unique null,
		MoTa nvarchar(150) null
	)
	create table ChiTietDP
	(
		MaDP int foreign key references DuocPham(MaDP),
		MaLoai int foreign key references Loai(MaLoai),
		Primary Key (MaLoai, MaDP),
		HanSuDung Date null,
		SoLuong Int null,
		DonGia money null
	) on MedData
	create table Nguoi 
	(
		MaNg int identity(1,1) primary key not null,
		Ho nvarchar(30) null,
		Ten nvarchar(10) null,
		Sdt varchar(10) null,
		GhiChu nvarchar(50) null
	) on MedData
	create table KhachHang
	(
		MaKH int identity(1,1) primary key not null,
		MaNg int foreign key references Nguoi(MaNg),
		Co_KeDon bit null
	)
	create table NhanVien
	(
		MaNV int identity(1,1) primary key not null,
		MaNg int foreign key references Nguoi(MaNg),
		TaiKhoan varchar(20) unique,
		MatKhau varchar(10) null,
		La_Admin bit null
	)
	create table HoaDon
	(
		MaHD int identity(1,1) primary key NOT NULL,
		NgayLap Date null,
		MaKH int foreign key references KhachHang (MaKH),
		MaNV int foreign key references NhanVien (MaNV),
		ThanhTien money null default 0
	)
	create table ChiTietHD
	(
		MaDP int foreign key references DuocPham(MaDP),
		MaHD int foreign key references HoaDon(MaHD),
		Primary Key (MaDP, MaHD),
		SoLuong int null
	) on MedData
	create table NhaCungCap
	(
		MaNCC int identity(1,1) primary key,
		TenNCC nvarchar(20) unique null,
		DiaChi nvarchar(50) null,
		GhiChu nvarchar(50) null
	)
	create table PhieuNhap
	(
		MaPN int identity(1,1) primary key not null,
		MaNV int foreign key references NhanVien(MaNV),
		MaNCC int foreign key references NhaCungCap(MaNCC),
		NgayNhap date null
	)
	create table ChiTietPN
	(
		MaDP int foreign key references DuocPham(MaDP),
		MaPN int foreign key references PhieuNhap(MaPN),
		Primary key (MaDP, MaPN),
		SoLuong int null,
		GiaTien money null
	) on MedData
END
GO

