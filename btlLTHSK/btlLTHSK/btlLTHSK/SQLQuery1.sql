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

        -----a:-----
create table tblHoaDonMuaHang (
iSoHDMH int not null,
sMaNhanVien varchar(15) not null,
sMaKhachHang varchar(15) not null,
dNgayMuaHang date,
constraint PK_iSoHDMH primary key (iSoHDMH),
constraint FK_HoaDonMuaHang_NhanVien foreign key (sMaNhanVien) references tblNhanVien(sMaNhanVien),
constraint FK_HoaDonMuaHang_KhachHang foreign key (sMaKhachHang) references tblDoiTac(sMaDoiTac),
constraint CK_NgayMuaHang check (datediff(day, dNgayMuaHang, getdate()) <=0)
)

         -----b------
 
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

   select *from tblChiTietHDNhapHang;
   exec xoa_ChiTietPhieuNhap 1,"1";
    select *from tblChiTietHDNhapHang;
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
  create proc update_HoaDon_PhieuNhap
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
   
   ----- b: Xóa Bảng hóa đơn nhập và nhũng chi tiết hóa đơn của nó
   create proc delete_HoaDon_PhieuNhap
   @iSoHDNH int
   AS
   BEGIN
   delete tblChiTietHDNhapHang Where @iSoHDNH=iCTHDNH;  
   delete tblHoaDonNhapHang WHERE @iSoHDNH=iSoHDNH;
   END

  exec delete_HoaDon_PhieuNhap 2;
  select *from tblHoaDonNhapHang

  ----c: Tìm kiếm theo MaHD Nhap
  create proc tim_kiem_Ma_NV_Nhap
  @sMaNV varchar(15)
  AS
  begin
	SELECT * FROM tblHoaDonNhapHang
	WHERE sMaNhanVien Like '%' + @sMaNV +'%' ;
  end

  exec  tim_kiem_Ma_NV_Nhap "2"

  create proc tim_kiem_Ma_NCC
  @sMaNCC varchar(15)
  AS
  begin
	SELECT * FROM tblHoaDonNhapHang
	WHERE sMaNCC Like '%' + @sMaNCC +'%' ;
  end
   
  -- Yeu cau ngày nhập hàng phải nhỏ hơn ngày hiện tại--
  create trigger check_Tgian
  on tblHoaDonNhapHang
  AFTER INSERT
  AS
  BEGIN
  declare @dNgayNhap datetime
  select @dNgayNhap=dNgayNhap
  from inserted
  if (@dNgayNhap<=getdate())
    begin
    print'ngay sinh phai nho hon ngay hien tai'
    end
  else
    begin
    print'successful'
	end
  END

  create trigger tang_slkhi_nhap
  on tblChiTietHDNhapHang
  for INSERT
  AS
  BEGIN
  declare  
  @fSoLuong int,
  @sMaLapTop varchar(15)
  select @fSoLuong=fSoLuongNhap,@sMaLapTop=sMaLaptop from inserted
  update tblLaptop
  set fSoLuong=fSoLuong+@fSoLuong  Where tblLaptop.sMaLaptop=@sMaLapTop
   
  END

  select *from tblLaptop

 
  ------5:Bang tblHoaDonNhapHang---
  ----a:Xóa hóa đơn mua hàng---
  create proc delete_HoaDonMH
   @iSoHDMH int
   AS
   BEGIN
   delete tblChiTietHDMuaHang Where @iSoHDMH=iCTHDMH;  
   delete tblHoaDonMuaHang WHERE @iSoHDMH=iSoHDMH;
   END

  -----b:update Hóa Đơn Mua Hàng---
create proc update_HDMuaHang
@iCTHDMH int,
@sMaNhanVien nvarchar(15),
@sMaKhachHang nvarchar(15),
@dNgayMuaHang date
AS
Begin
 
	update  tblHoaDonMuaHang
	set  @sMaNhanVien = sMaNhanVien ,@sMaKhachHang=sMaKhachHang,@dNgayMuaHang =dNgayMuaHang
	where @iCTHDMH=iSoHDMH;
End

-----Bảng tblChiTietMuaHang--
 ---- a:hiện Chi Tiết Hóa đơn Mua Hàng
  create proc tblChiTietHDMuaHang_GiamGia_Hien
  as
  BEGIN
  select iCTHDMH, tblChiTietHDMuaHang.sMaLapTop,sTenLapTop,fDonGia,tblChiTietHDMuaHang.fSoLuong,fGiamGia,
  (fDonGia*tblChiTietHDMuaHang.fSoLuong)-(fDonGia/100*fGiamGia*tblChiTietHDMuaHang.fSoLuong) as [TongThanhtoan]
  from tblChiTietHDMuaHang inner join tblLaptop on tblChiTietHDMuaHang.sMaLaptop=tblLaptop.sMaLaptop
  END
  exec tblChiTietHDMuaHang_GiamGia_Hien

  --b:UPDATE tblCHiTietHoaDon--
  create proc update_ChiTietHD_Ban
  @iCTHDMH int,
  @sMaLT varchar(15), 
  @fDonGia float,
  @fSoLuong float,
  @fGiamGia int
  AS
  BEGIN
      UPDATE tblChiTietHDMuaHang
      set sMaLaptop=@sMaLT,fSoLuong=@fSoLuong, fDonGia=@fDonGia, fGiamGia=@fGiamGia
      WHERE  iCTHDMH= @iCTHDMH and sMaLaptop=@sMaLT

  END
  ---c: Xóa Hóa đơn theo Mã HD và Mã SP----
  create proc xoa_ChiTietHDMuaHang
   @iCTHDMH int,
   @sMaLaptop nvarchar(15)
   AS
   BEGIN
    delete tblChiTietHDMuaHang WHERE @iCTHDMH=iCTHDMH and @sMaLaptop=sMaLaptop
   END

   exec xoa_ChiTietHDMuaHang @iCTHDMH='1',@sMaLaptop='LT02'
   select*from tblChiTietHDMuaHang

   ----d:Hiện chi tiết hóa đơn theo Mã HD-----
   create proc hien_ChitietMua_theoMa
   @iCTHDMH int
   as
   BEGIN
    select iCTHDMH, tblChiTietHDMuaHang.sMaLapTop,sTenLapTop,fDonGia,tblChiTietHDMuaHang.fSoLuong,fGiamGia,
     (fDonGia*tblChiTietHDMuaHang.fSoLuong)-(fDonGia/100*fGiamGia*tblChiTietHDMuaHang.fSoLuong) as [TongThanhtoan]
     from tblChiTietHDMuaHang inner join tblLaptop on tblChiTietHDMuaHang.sMaLaptop=tblLaptop.sMaLaptop
	 where @iCTHDMH=iCTHDMH
   END

 


   ----6:Bảng tblLapTop

   -- a:UPDATE SẢN PHẨM ( tblLapTop )
   create proc updateSp
    @MaLaptop varchar(15),
	@TenLaptop nvarchar(50),
	@sMaLoai varchar(15),
    @sMaNCC varchar(15),
    @fSoLuong float,
    @fGiaBan float
as
begin
    Set nocount on
    update tblLaptop 
	set sTenLaptop = @TenLaptop,sMaLoai=@sMaLoai,sMaNCC=@sMaNCC, 	
	fSoLuong = @fSoLuong, fGiaBan = @fGiaBan 
	where sMaLaptop = @MaLaptop ;
end;

   ----------b:Xóa Sản Phẩm-------
   create proc XoaSP
   @sMaSP varchar(15)
   as
   BEGIN
   delete tblChiTietHDMuaHang WHERE sMaLaptop=@sMaSP;
   END
   
   --------- III:Làm Về Xuất Hóa Đơn----------
  create proc xuat_hoadon_TheoMa
  @iMaHDN int
  AS
  BEGIN
  SELECT sTenDoiTac,CONVERT(varchar,dNgayNhap,103),sTenLapTop,iCTHDNH ,tblChiTietHDNhapHang.fSoLuongNhap,fGiaNhap,ROUND((fGiaNhap*fSoLuongNhap),0) as[sDonGia]  
  from tblHoaDonNhapHang inner join tblDoiTac on sMaDoiTac=sMaNCC
       inner join tblChiTietHDNhapHang on iCTHDNH=iSoHDNH
	   inner join tblLaptop on tblLaptop.sMaLaptop=tblChiTietHDNhapHang.sMaLaptop
	   Where iSoHDNH=@iMaHDN
  END
  exec  xuat_hoadon_TheoMa 1

  -- Xuất ALL Hóa đơn
  create proc xuat_hoadon_TheoMa_ALL  
  AS
  BEGIN
  SELECT sTenDoiTac,CONVERT(varchar,dNgayNhap,103) as [dNgayNhap],sTenLapTop,iCTHDNH ,tblChiTietHDNhapHang.fSoLuongNhap,fGiaNhap,ROUND((fGiaNhap*fSoLuongNhap),0) as[sDonGia]  
  from tblHoaDonNhapHang inner join tblDoiTac on sMaDoiTac=sMaNCC
       inner join tblChiTietHDNhapHang on iCTHDNH=iSoHDNH
	   inner join tblLaptop on tblLaptop.sMaLaptop=tblChiTietHDNhapHang.sMaLaptop
	  
  END
  exec  xuat_hoadon_TheoMa_ALL 



  
