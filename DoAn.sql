create database DoAnCuoiKii
use	DoAnCuoiKii
create table KeToan
(
	maID nvarchar(20) primary key,
	Tenketoan nvarchar(30),
	
	Diachi nvarchar(50),
	sodienthoai int

)
drop table KeToan
create table daily
(
	maDaily nvarchar(20) primary key,
	tenDaily nvarchar(25),
	diachi varchar(50),
	dienthoai int
)
drop table daily
create table Donhang
(
	maDonhang nvarchar(20) primary key,
	ngaydathang date,
	maDaily nvarchar(20),
	giaDon int,
	hinhthucthanhtoan nvarchar(25),
	trangthai nvarchar(20),
	foreign key(maDaily) references daily(maDaily)
)
drop table Donhang
create table Sanpham
(
	maSanpham nvarchar(20) primary key,
	theloai varchar(20),
	giatien float
)
drop table Sanpham
create table Phieunhapkho
(
	maPhieu nvarchar(20) primary key,
	
	maSanpham nvarchar(20),
	soluong int,
	maID nvarchar(20),

	foreign key(maSanpham) references Sanpham(maSanpham),
	
)
drop table Phieunhapkho
create table Phieuxuatkho
(
	maPhieuxuat nvarchar(20) primary key,
	ngayxuat date,
	giaca float,
	soluong int,
	maDonhang nvarchar(25),
	
	maID nvarchar(20),
	foreign key(maID) references KeToan(maID),
	
)
drop table Phieuxuatkho










