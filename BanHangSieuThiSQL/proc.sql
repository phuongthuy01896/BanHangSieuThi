--thêm nv
create proc themnv @manv varchar(20), @tennv nvarchar(50), @gt nvarchar(5), @diachi nvarchar(50), @sdt char(15)
as
begin
if exists(select maNV from nhanvien where maNV=@manv)
	print 'Da ton tai nhan vien'
else insert into nhanvien (maNV,tenNV,GT,SDT,diachi)
	values (@manv,@tennv,@gt,@sdt,@diachi)
end
--thêm KH
alter proc themkh @tenkh nvarchar(50), @gt nvarchar(5), @diachi nvarchar(50), @sdt char(15),@CMTND nchar(20)
as
begin
insert into khachhang (maKH,tenKH,GT,SDT,diachi,CMTND)
	values ('',@tenkh,@gt,@sdt,@diachi,@CMTND)
end
--proc xoa kh
create proc xoakh @makh varchar(20)
as
begin
update hoadonban set maKH=null where maKH=@makh
delete khachhang where maKH=@makh
end
--thêm hóa đơn
create proc themhoadon @maKH varchar(20), @ngayban datetime, @tongtien int, @maNV varchar(20)
as
begin
insert into hoadonban(maHDB,maKH,ngayban,tongtien,maNV)
	values ('',@maKH,@ngayban,@tongtien,@maNV)
end
delete chitietphieunhap where mapn='PN01' and tencc='B' and maLH='LH02' and tenSP='Khủng long mini'
--thêm chi tiết hóa đơn
create proc themchitiet @maHDB varchar(20), @maSP varchar(20), @soluong int, @dongia int, @thanhtien int
as
begin
select @dongia=giaban from sanpham where maSP=@maSP
insert into chitiethoadon values(@maHDB,@maSP,@soluong,@dongia,@thanhtien)
end
--thanh toán
create proc thanhtoan @maHDB varchar(20)
as
begin
update sanpham set soluong=soluong-(select soluong from chitiethoadon where sanpham.maSP=chitiethoadon.maSP and maHDB=@maHDB)
end
--trigger mã kh tự tăng
CREATE TRIGGER themkhachhang
ON khachhang
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(20),@NEWValue VARCHAR(20),@NEW_ID VARCHAR(20), @OLD_ID VARCHAR(20);
SELECT @MAXValue = MAX(maKH) FROM khachhang
select @OLD_ID = maKH from INSERTED
SET @NEWValue= REPLACE(@MaxValue,'KH','')+1
SET @NEW_ID = 'KH'+
    CASE
       WHEN LEN(@NEWValue)<3
          THEN REPLICATE('0',3-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
UPDATE khachhang SET maKH = @NEW_ID WHERE maKH = @OLD_ID
END
--trigger masp tự tăng
CREATE TRIGGER themsp
ON sanpham
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(20),@NEWValue VARCHAR(20),@NEW_ID VARCHAR(20), @OLD_ID VARCHAR(20);
SELECT @MAXValue = MAX(maSP) FROM sanpham
select @OLD_ID = maSP from INSERTED
SET @NEWValue= REPLACE(@MaxValue,'SP','')+1
SET @NEW_ID = 'SP'+
    CASE
       WHEN LEN(@NEWValue)<3
          THEN REPLICATE('0',3-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
UPDATE sanpham SET maSP = @NEW_ID WHERE maSP = @OLD_ID
END
--them phieunhap
create proc thempn @mapn varchar(20),@ngaynhap datetime,@maNV varchar(20)
as
begin
insert into phieunhap values(@mapn,@ngaynhap,@maNV)
end
--themchitietpn
create proc themchitietpn @mapn varchar(20),@tenSP nvarchar(50),@tencc nvarchar(50),@maLH varchar(20),@soluong int,
@dongia bigint,@thanhtien bigint
as
begin
insert into chitietphieunhap values(@mapn,@tenSP,@tencc,@maLH,@soluong,@dongia,@thanhtien)
if exists(select maLH,tencc,tenSP from sanpham where maLH=@maLH and tenSP=@tenSP and tencc=@tencc)
	update sanpham set soluong=soluong+@soluong where maLH=@maLH and tenSP=@tenSP and tencc=@tencc
else 
	insert into sanpham(maSP,tenSP,soluong,gianhap,tencc,maLH,giaban) values('',@tenSP,@soluong,@dongia,@tencc,@maLH,@dongia+@dongia/2)
end

--xoapn
create proc xoapn @mapn varchar(20)
as
begin
delete chitietphieunhap where mapn=@mapn
delete phieunhap where mapn=@mapn
end

--thong ke luu luong nhap hang
create proc luuluongnhap @thang int
as
begin
select maSP,sanpham.tenSP,chitietphieunhap.soluong,ngaynhap, manv, phieunhap.mapn 
from sanpham,chitietphieunhap,phieunhap
where month(ngaynhap)=@thang and sanpham.tenSP=chitietphieunhap.tenhang and chitietphieunhap.mapn=phieunhap.mapn
end
--thong ke luu luong xuat hang
create proc luuluongxuat @thang int
as
begin
select sanpham.maSP,tenSP,chitiethoadon.soluong,ngayban,manv
from sanpham,chitiethoadon,hoadonban
where sanpham.maSP=chitiethoadon.maSP and chitiethoadon.maHDB=hoadonban.maHDB and month(ngayban)=@thang
end
--trigger mã hdb tự tăng
CREATE TRIGGER themhdb
ON hoadonban
FOR INSERT
AS
BEGIN
DECLARE @MAXValue VARCHAR(20),@NEWValue VARCHAR(20),@NEW_ID VARCHAR(20), @OLD_ID VARCHAR(20);
SELECT @MAXValue = MAX(maHDB) FROM hoadonban
select @OLD_ID = maHDB from INSERTED
SET @NEWValue= REPLACE(@MaxValue,'HDB','')+1
SET @NEW_ID = 'HDB'+
    CASE
       WHEN LEN(@NEWValue)<3
          THEN REPLICATE('0',3-LEN(@newValue))
          ELSE ''
       END +
       @NEWValue
UPDATE hoadonban SET maHDB = @NEW_ID WHERE maHDB = @OLD_ID
END
--proc themuser
alter proc themuser @username varchar(20), @pass varchar(20)
as
begin
insert into dangnhap values(@username,@pass)
end   
themuser 'admin','admin'