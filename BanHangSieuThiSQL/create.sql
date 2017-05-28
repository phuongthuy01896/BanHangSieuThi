create table nhanvien
(
maNV varchar(20) primary key,
tenNV nvarchar(50),
GT nvarchar(5),
diachi nvarchar(50),
SDT char(15)
)
create table loaihang
(
maLH varchar(20) primary key,
tenLH nvarchar(50)
)
create table nhacungcap
(
tencc nvarchar(50) primary key,
diachi nvarchar(50),
SDT char(15)
)
create table sanpham
(
maSP varchar(20) primary key,
tenSP nvarchar(50),
maLH varchar(20) foreign key(maLH) references loaihang(maLH),
soluong int,
gianhap bigint,
giaban bigint,
tencc nvarchar(50) foreign key(tencc) references nhacungcap(tencc)
)
create table phieunhap(
	mapn varchar(20) primary key (mapn),
	ngaynhap datetime,	
	maNV varchar(20) foreign key(maNV) references nhanvien(maNV)
)
create table chitietphieunhap(
	mapn varchar(20) foreign key(mapn) references phieunhap(mapn),
	tenhang nvarchar(50),
	tencc nvarchar(50)foreign key (tencc) references nhacungcap(tencc),	
	maLH varchar(20) foreign key (maLH) references loaihang(maLH),
	soluong int,
	dongia bigint,
	thanhtien bigint
)
create table khachhang
(
maKH varchar(20) primary key,
tenKH nvarchar(50),
GT nvarchar(5),
diachi nvarchar(50),
SDT char(15),
CMTND nchar(20)
)
create table hoadonban
(
maHDB varchar(20) primary key,
maKH varchar(20) foreign key(maKH) references khachhang(maKH),
ngayban datetime,
tongtien bigint,
maNV varchar(20) foreign key(maNV) references nhanvien(maNV)
)
create table chitiethoadon
(
maHDB varchar(20) foreign key(maHDB) references hoadonban(maHDB),
maSP varchar(20) foreign key(maSP) references sanpham(maSP),
soluong int,
dongia bigint,
thanhtien bigint
primary key(maHDB,maSP)
)
create table dangnhap
(
username varchar(20),
pass varchar(20),
id int primary key
)



