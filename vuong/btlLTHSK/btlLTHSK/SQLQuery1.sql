CREATE DATABASE btl_hsk;

create table tblLoaiLaptop ( 
sMaLoai varchar(15) not null ,
sTenLoai nvarchar(50),
constraint PK_sMaLoai primary key (sMaLoai)
)


  --------------- Bảng Đối tác
create table tblDoiTac (
sMaDoiTac varchar(15) not null,
sTenDoiTac nvarchar(50) ,
sSDT varchar(12),
sDiaChi nvarchar(50),
constraint PK_sMaDoiTac primary key (sMaDoiTac)

)
 ------------------ Bảng Laptop
 create table tblLaptop (
 sMaLaptop varchar(15) not null ,
 sTenLaptop nvarchar(50),
 sMaNCC varchar(15) not null,
 --sMaTacGia varchar(15) not null ,
 sMaLoai varchar(15) not null,
 fSoLuong float,
 fGiaBan float,

 constraint PK_sMaLaptop primary key (sMaLaptop) ,
 constraint CK_SoLuong check (fSoLuong >=0),
 constraint CK_GiaBan check (fGiaBan >0),
 constraint FK_Laptop_Loai foreign key (sMaLoai) references tblLoaiLaptop(sMaLoai),
 constraint FK_Laptop_NXB foreign key (sMaNCC) references tblDoiTac(sMaDoiTac)
 )

 
-- Bảng Nhân Viên 
create table tblNhanVien (
sMaNhanVien varchar(15) not null,
sTenNhanVien nvarchar(50),
sGioiTinh nvarchar(5),
sDiaChi nvarchar(50),
sSDT varchar(12),
dNgaySinh date,
dNgayVaoLam date,
fLuongCoBan float,
fPhuCap float,
constraint PK_sMaNhanVien primary key (sMaNhanVien),
constraint CK_Tuoi check (DATEDIFF(day, dNgaySinh,dNgayVaoLam) /365 >= 18),
constraint CK_Luong check (fLuongCoBan>0),
constraint CK_PhuCap check (fPhuCap > 0),
constraint CK_GioiTinh check ( sGioiTinh = N'nam' or sGioiTinh = N'nữ')
)


-- Bảng Hóa Đơn Mua Hàng 
create table tblHoaDonMuaHang (
iSoHDMH int not null,
sMaNhanVien varchar(15) not null,
sMaKhachHang varchar(15) not null,
dNgayMuaHang date,
constraint PK_iSoHDMH primary key (iSoHDMH),
constraint FK_HoaDonMuaHang_NhanVien foreign key (sMaNhanVien) references tblNhanVien(sMaNhanVien),
constraint FK_HoaDonMuaHang_KhachHang foreign key (sMaKhachHang) references tblDoiTac(sMaDoiTac),
constraint CK_NgayMuaHang check (datediff(day, dNgayMuaHang, getdate()) >=0)
)
 
-- Bảng Chi Tiết HD Mua Hang
create table tblChiTietHDMuaHang(
iCTHDMH int not null,
sMaLaptop varchar(15) not null ,
fDonGia float,
fSoLuong float,
fGiamGia float,
constraint PK_iSoHDMH_sMaSach primary key (iCTHDMH, sMaLaptop),
constraint FK_tblChiTietHDMuaHang_iSoHDMH foreign key (iCTHDMH) references tblHoaDonMuaHang(iSoHDMH),
constraint FK_tblChiTietHDMuaHang_Sach foreign key (sMaLaptop) references tblLaptop(sMaLaptop),
constraint CK_DonGia check (fDonGia > 0),
constraint CK_SoLuongMua check (fSoLuong > 0)	
)

-- Bảng HD Nhập Hàng 
create table tblHoaDonNhapHang (
iSoHDNH int not null,
sMaNhanVien varchar(15) not null,
sMaNCC varchar(15),
dNgayNhap date,
constraint PK_iSoHDNH primary key (iSoHDNH),
constraint FK_HoaDonNhapHang_NXB foreign key (sMaNCC) references tblDoiTac(sMaDoiTac),
constraint FK_HoaDonNhapHang_NhanVien foreign key (sMaNhanVien) references tblNhanVien(sMaNhanVien),
constraint CK_NgayNhapHang check (datediff(day, dNgayNhap, getdate()) >=0)
)
 
-- Bảng Chi Tiết HD Nhập Hàng
 create table tblChiTietHDNhapHang
( 
iCTHDNH int not null,
sMaLaptop varchar(15) not null ,
fSoLuongNhap float ,
fGiaNhap float,
constraint PK_tblChiTietHDNhapHang primary key (iCTHDNH, sMaLaptop),
constraint FK_tblChiTietHDNhapHang_iSoHDNH foreign key (iCTHDNH) references tblHoaDonNhapHang(iSoHDNH),
constraint FK_tblChiTietHDNhapHang_Sach foreign key (sMaLaptop) references tblLaptop(sMaLaptop),
constraint CK_GiaNhap check (fGiaNhap >0),
constraint CK_SoLuongNhap check (fSoLuongNhap>0) 

 )

 -------Nhân viên
go
create proc kiemtr_khoa_chinh_NhanVien
@maNV varchar(15),
@isExisting BIT OUTPUT
as
begin
	SET @isExisting = 0; -- ban đầu mã nhân viên không tồn tại
	if(EXISTS (select sMaNhanVien from tblNhanVien where @maNV = sMaNhanVien )) 
		begin
			SET @isExisting = 1; -- mã nhân viên đã tồn tại
		end
end
 --Xóa Nhân Viên---
go
create proc xoa_NhanVien
@maNV varchar(15),
@tenNV nvarchar(50),
@gioitinh nvarchar(5),
@diachi nvarchar(50),
@sdt varchar(12),
@ngaysinh date,
@ngayvaolam date,
@luong float,
@phucap float
AS
Begin
	delete tblNhanVien
	where @maNV = sMaNhanVien and @tenNV = sTenNhanVien and @diachi = sDiaChi and @sdt = sSDT
	and @ngaysinh = dNgaySinh and  @ngayvaolam = dNgayVaoLam and @luong = fLuongCoBan and @phucap = fPhuCap and @gioitinh = sGioiTinh;
End

  ------UPDATE NHÂN VIÊN
go 
create proc update_nhanVien
@maNV varchar(15),
@tenNV nvarchar(50),
@gioitinh nvarchar(5),
@diachi nvarchar(50),
@sdt varchar(12),
@ngaysinh date,
@ngayvaolam date,
@luong float,
@phucap float
AS
Begin
	update tblNhanVien 
	set sTenNhanVien = @tenNV, sGioiTinh = @gioitinh, sDiaChi = @diachi,sSDT = @sdt,
	dNgaySinh = @ngaysinh,dNgayVaoLam = @ngayvaolam, fLuongCoBan = @luong, fPhuCap = @phucap
	where sMaNhanVien = @maNV;
		
	
End

   ----Tìm kiếm Nhân Viên
go
create proc tim_kiem_ma_NV 
@maNV varchar(15)
AS
begin
	SELECT *
	FROM tblNhanVien
	WHERE sMaNhanVien LIKE '%'+@maNV +'%';
end

go
create proc tim_kiem_ten_NV 
@tenNV nvarchar(50)
AS
begin
	SELECT *
	FROM tblNhanVien
	WHERE sTenNhanVien LIKE '%'+@tenNV +'%';
end
go
create proc tim_kiem_DiaChi_NV
@diachi nvarchar(50)
AS
begin
	SELECT *
	FROM tblNhanVien
	WHERE sDiaChi LIKE '%'+@diachi +'%';
end

-------------Khách hàng
go
create proc kiemtr_khoa_chinh_KhachHang
@maKH varchar(15),
@isExisting BIT OUTPUT
as
begin
	SET @isExisting = 0; -- ban đầu mã nhân viên không tồn tại
	if(EXISTS (select sMaDoiTac from tblDoiTac where @maKH = sMaDoiTac )) 
		begin
			SET @isExisting = 1; -- mã nhân viên đã tồn tại
		end
end


go
create proc xoa_KhachHang
@maKH varchar(15),
@tenKH nvarchar(50),
@diachi nvarchar(50),
@sdt varchar(12)
AS
Begin
	delete tblDoiTac
	where @maKH = sMaDoiTac and @tenKH = sTenDoiTac and @diachi = sDiaChi and @sdt = sSDT;
End

go
create proc update_KhachHang
@maKH varchar(15),
@tenKH nvarchar(50),
@diachi nvarchar(50),
@sdt varchar(12)
AS
Begin
	update tblDoiTac
	set sTenDoiTac = @tenKH, sDiaChi = @diachi,sSDT = @sdt
	where sMaDoiTac = @maKH;
End


go
create proc tim_kiem_sdt_KH
@sdt varchar(12)
AS
begin
	SELECT *
	FROM tblDoiTac
	WHERE sSDT LIKE '%'+@sdt +'%' and sMaDoiTac like '%KH%';
end


go
create proc tim_kiem_ten_KH
@ten nvarchar(50)
AS
begin
	SELECT *
	FROM tblDoiTac
	WHERE sTenDoiTac LIKE '%'+@ten +'%' and sMaDoiTac like '%KH%';
end
 select *from tblNhanVien


 --Chi Tiết Hóa Đơn Nhập--

 --- a:UPDATE Hóa Đơn Nhập
  create proc update_ChiTiet_PhieuNhap
  @iCTHDNH int,
  @sMaLaptop nvarchar(50),
  @fSoLuongNhap float,
  @fGiaNhap FLOAT 
  AS
  BEGIN
      UPDATE tblChiTietHDNhapHang
      set sMaLaptop=@sMaLaptop ,fSoLuongNhap=@fSoLuongNhap, fGiaNhap=@fGiaNhap 
      WHERE  iCTHDNH= @iCTHDNH AND sMaLaptop=@sMaLaptop

  END
   ---Xóa hóa đơn nhập--
   create proc xoa_ChiTietPhieuNhap
   @iCTHDNH int,
   @sMaLaptop nvarchar(15)
   AS
   BEGIN
    delete tblChiTietHDNhapHang WHERE @iCTHDNH=iCTHDNH and @sMaLaptop=sMaLaptop
   END


   -- Lấy Tên Sản Phẩm---


   create proc lay_TenSP
   @MaSP VARCHAR(15),
   @isExisting nvarchar(50) OUTPUT
   AS
   BEGIN
     
     set @isExisting = (SELECT  sTenLaptop from tblLaptop where @MaSP=sMaLaptop );

   END
   exec lay_TenSP "1";

   -- Bảng tblHoaDonNhapHang
   --- a:UPDATE Hóa Đơn Nhập
  alter proc update_HoaDon_PhieuNhap
  @iSoHDNH int,
  @sMaNhanVien nvarchar(15),
  @sMaNCC varchar(15),
  @dNgayNhap date
  AS
  BEGIN
      UPDATE tblHoaDonNhapHang
      set  sMaNhanVien=@sMaNhanVien,sMaNCC=@sMaNCC,dNgayNhap=@dNgayNhap
	  WHERE iSoHDNH=@iSoHDNH;
     
  END
   
   alter proc delete_HoaDon_PhieuNhap
   @iSoHDNH int
   AS
   BEGIN
   delete tblChiTietHDNhapHang Where @iSoHDNH=iCTHDNH;  
   delete tblHoaDonNhapHang WHERE @iSoHDNH=iSoHDNH;
   END

  exec delete_HoaDon_PhieuNhap 2;
  select *from tblHoaDonNhapHang

