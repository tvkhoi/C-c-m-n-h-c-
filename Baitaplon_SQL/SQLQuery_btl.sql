---Tạo database bài tập lớn sql
CREATE DATABASE Quanli_cua_hang_sach ON (Name ='Quan_li_cua_hang_sach',
    FILENAME = 'D:\Baitaplon_SQL\quanlibanhang.mdf');
-----Tạo các bảng trong database
-- Bảng Thể Loại Sách
create table tblTheLoaiSach ( 
sMaLoaiSach varchar(15) not null ,
sTenTheLoai nvarchar(50) 
)
alter table tblTheLoaiSach
add constraint PK_sMaLoaiSach primary key (sMaLoaiSach)
 -- Bảng Sách

 create table tblSach (
 sMaSach varchar(15) not null ,
 sTenSach nvarchar(50),
 sMaNXB varchar(15) not null,
 sMaTacGia varchar(15) not null ,
 sMaLoaiSach varchar(15) not null,
 fSoLuong float,
 fGiaBan float,
 sDonViTinh varchar(5) default ( 'VND' )
 )
alter table tblSach
add constraint PK_sMaSach primary key (sMaSach) 

-- Bảng tác giả
 create table tblTacGia (
  sMaTacGia varchar(15) not null ,
  sTenTacGia nvarchar(50) 
  )
  alter table tblTacGia
add constraint PK_sMaTacGia primary key (sMaTacGia)

-- Bảng Nhà Xuất Bản 
create table tblNhaXuatBan (
sMaNXB varchar(15) not null,
sTenNXB nvarchar(50) 
)
alter table tblNhaXuatBan
add constraint PK_sMaNXB primary key (sMaNXB)

-- ràng buộc 

alter table tblSach
add constraint FK_Sach_LoaiSach foreign key (sMaLoaiSach) references tblTheLoaiSach(sMaLoaiSach),
	constraint FK_Sach_TacGia foreign key (sMaTacGia) references tblTacGia(sMaTacGia),
	constraint FK_Sach_NXB foreign key (sMaNXB) references tblNhaXuatBan(sMaNXB)

-- Bảng Khách Hàng 
create table tblKhachHang (
sMaKhachHang varchar(15) not null,
sTenKhachHang nvarchar(50),
sDiaChi nvarchar(50),
sSDT varchar(12)
)
alter table tblKhachHang
add constraint PK_sMaKhachHang primary key (sMaKhachHang)
-- Bảng Nhân Viên 
create table tblNhanVien (
sMaNhanVien varchar(15) not null,
sTenNhanVien nvarchar(50),
sDiaChi nvarchar(50),
sSDT varchar(12),
dNgaySinh date,
dNgayVaoLam date,
fLuongCoBan float,
fPhuCap float
)
alter table tblNhanVien 
add constraint PK_sMaNhanVien primary key (sMaNhanVien)
-- Bảng Hóa Đơn Mua Hàng 
create table tblHoaDonMuaHang (
iSoHDMH int not null,
sMaNhanVien varchar(15) not null,
sMaKhachHang varchar(15) not null,
dNgayMuaHang date
)
alter table tblHoaDonMuaHang
add constraint PK_iSoHDMH primary key (iSoHDMH),
	constraint FK_HoaDonMuaHang_NhanVien foreign key (sMaNhanVien) references tblNhanVien(sMaNhanVien),
	constraint FK_HoaDonMuaHang_KhachHang foreign key (sMaKhachHang) references tblKhachHang(sMaKhachHang)

-- Bảng Chi Tiết HD Mua Hang
create table tblChiTietHDMuaHang(
iSoHDMH int not null,
sMaSach varchar(15) not null ,
fDonGia float,
fSoLuong float,
fGiamGia float
)
alter table tblChiTietHDMuaHang
add constraint PK_iSoHDMH_sMaSach primary key (iSoHDMH, sMaSach),
	constraint FK_tblChiTietHDMuaHang_iSoHDMH foreign key (iSoHDMH) references tblHoaDonMuaHang(iSoHDMH),
	constraint FK_tblChiTietHDMuaHang_Sach foreign key (sMaSach) references tblSach(sMaSach)

-- Bảng HD Nhập Hàng 
create table tblHoaDonNhapHang (
iSoHDNH int not null,
sMaNhanVien varchar(15) not null,
dNgayNhap date)
alter table tblHoaDonNhapHang
add constraint PK_iSoHDNH primary key (iSoHDNH),
	constraint FK_HoaDonNhapHang_NhanVien foreign key (sMaNhanVien) references tblNhanVien(sMaNhanVien)

-- Bảng Chi Tiết HD Nhập Hàng
 create table tblChiTietHDNhapHang
( 
iSoHDNH int not null,
 sMaSach varchar(15) not null ,
 fSoLuongNhap float ,
 fGiaNhap float
 )
 alter table tblChiTietHDNhapHang
 add constraint PK_tblChiTietHDNhapHang primary key (iSoHDNH, sMaSach)	,
 constraint FK_tblChiTietHDNhapHang_iSoHDNH foreign key (iSoHDNH) references tblHoaDonNhapHang(iSoHDNH),
constraint FK_tblChiTietHDNhapHang_Sach foreign key (sMaSach) references tblSach(sMaSach)

----10 bản ghi bảng Sách

------------------- Bảng Thể Loại Sách
create table tblTheLoaiSach ( 
sMaLoaiSach varchar(15) not null ,
sTenTheLoai nvarchar(50),
constraint PK_sMaLoaiSach primary key (sMaLoaiSach)
)
------------------ Bảng tác giả
 create table tblTacGia (
  sMaTacGia varchar(15) not null ,
  sTenTacGia nvarchar(50) ,
  constraint PK_sMaTacGia primary key (sMaTacGia)
  )

  --------------- Bảng Nhà Xuất Bản 
create table tblNhaXuatBan (
sMaNXB varchar(15) not null,
sTenNXB nvarchar(50) ,
sSDT varchar(12),
sDiaChi nvarchar(50),
constraint PK_sMaNXB primary key (sMaNXB)

)
 ------------------ Bảng Sách
 create table tblSach (
 sMaSach varchar(15) not null ,
 sTenSach nvarchar(50),
 sMaNXB varchar(15) not null,
 sMaTacGia varchar(15) not null ,
 sMaLoaiSach varchar(15) not null,
 fSoLuong float,
 fGiaBan float,
 sDonViTinh varchar(5) default ( 'VND' ),
 constraint PK_sMaSach primary key (sMaSach) ,
 constraint CK_SoLuong check (fSoLuong >=0),
 constraint CK_GiaBan check (fGiaBan >0),
 constraint FK_Sach_LoaiSach foreign key (sMaLoaiSach) references tblTheLoaiSach(sMaLoaiSach),
 constraint FK_Sach_TacGia foreign key (sMaTacGia) references tblTacGia(sMaTacGia),
 constraint FK_Sach_NXB foreign key (sMaNXB) references tblNhaXuatBan(sMaNXB)
 )


-- Bảng Khách Hàng 
create table tblKhachHang (
sMaKhachHang varchar(15) not null,
sTenKhachHang nvarchar(50),
sDiaChi nvarchar(50),
sSDT varchar(12),
constraint PK_sMaKhachHang primary key (sMaKhachHang)
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
constraint FK_HoaDonMuaHang_KhachHang foreign key (sMaKhachHang) references tblKhachHang(sMaKhachHang),
constraint CK_NgayMuaHang check (datediff(day, dNgayMuaHang, getdate()) >=0)
)
 
-- Bảng Chi Tiết HD Mua Hang
create table tblChiTietHDMuaHang(
iSoHDMH int not null,
sMaSach varchar(15) not null ,
fDonGia float,
fSoLuong float,
fGiamGia float,
constraint PK_iSoHDMH_sMaSach primary key (iSoHDMH, sMaSach),
constraint FK_tblChiTietHDMuaHang_iSoHDMH foreign key (iSoHDMH) references tblHoaDonMuaHang(iSoHDMH),
constraint FK_tblChiTietHDMuaHang_Sach foreign key (sMaSach) references tblSach(sMaSach),
constraint CK_DonGia check (fDonGia > 0),
constraint CK_SoLuongMua check (fSoLuong > 0)	
)

-- Bảng HD Nhập Hàng 
create table tblHoaDonNhapHang (
iSoHDNH int not null,
sMaNhanVien varchar(15) not null,
sMaNXB varchar(15),
dNgayNhap date,
constraint PK_iSoHDNH primary key (iSoHDNH),
constraint FK_HoaDonNhapHang_NXB foreign key (sMaNXB) references tblNhaXuatBan(sMaNXB),
constraint FK_HoaDonNhapHang_NhanVien foreign key (sMaNhanVien) references tblNhanVien(sMaNhanVien),
constraint CK_NgayNhapHang check (datediff(day, dNgayNhap, getdate()) >=0)
)
 
-- Bảng Chi Tiết HD Nhập Hàng
 create table tblChiTietHDNhapHang
( 
iSoHDNH int not null,
sMaSach varchar(15) not null ,
fSoLuongNhap float ,
fGiaNhap float,
constraint PK_tblChiTietHDNhapHang primary key (iSoHDNH, sMaSach),
constraint FK_tblChiTietHDNhapHang_iSoHDNH foreign key (iSoHDNH) references tblHoaDonNhapHang(iSoHDNH),
constraint FK_tblChiTietHDNhapHang_Sach foreign key (sMaSach) references tblSach(sMaSach),
constraint CK_GiaNhap check (fGiaNhap >0),
constraint CK_SoLuongNhap check (fSoLuongNhap>0) 

 )
 

 --10 bản ghi bảng thể loại sách
insert into tblTheLoaiSach
values
('TL01',N'Truyện trinh tham'),
('TL02',N'Truyện thiếu nhi'),
('TL03',N'Truyện cổ tích'),
('TL04',N'Tiểu thuyết'),
('TL05',N'Sách tâm lý'),
('TL06',N'Sách văn học'),
('TL07',N'Sách kinh tế'),
('TL08',N'Sách chính trị'),
('TL09',N'Sách tâm lý'),
('TL10',N'Thơ ca')

--10 bản ghi bảng tác giả
insert into tblTacGia
values
('TG01',N'Tô Hoài'),
('TG02',N'Vũ Trọng Phụng'),
('TG03',N'Nam Cao'),
('TG04',N'Huy Cận'),
('TG05',N'Nguyễn Nhật Ánh'),
('TG06',N'Xuân Diệu'),
('TG07',N'Hoài Thanh'),
('TG08',N'Nguyễn Ngọc Tư'),
('TG09',N'Nguyễn Minh Châu'),
('TG10',N'Iris Cao')

--10 bản ghi bảng nhà xuất bản
insert into tblNhaXuatBan
values
('NXB01',N'Tuổi Trẻ','0982123211','Hà Nội'),
('NXB02',N'Kim Đồng','0812762981','Bắc Ninh'),
('NXB03',N'Hội Nhà Văn','0328987612','Bắc Giang'),
('NXB04',N'Thanh Niên','0879738274','Hà Nội'),
('NXB05',N'Phụ Nữ Việt Nam','0987689872','Hà Nội'),
('NXB06',N'Lao Động','0398271872','Hà Nội'),
('NXB07',N'Nhã Nam','0982789182','TPHCM'),
('NXB08',N'Đông Á','0339798380','TPHCM'),
('NXB09',N'Thiếu Nhi','0321987789','TPHCM'),
('NXB10',N'Giáo Dục Việt Nam','0123212342','Hà Nội')


----10 bản ghi bảng Sách
INSERT INTO tblSach
VALUES
('Sach01',N'Conan','NXB01','TG01','TL01',5,21000,'VND'),
('Sach02',N'Cô gái quàng khăn đỏ','NXB02','TG02','TL02',4,35000,'VND'),
('Sach03',N'Chiếc chuông vàng','NXB03','TG03','TL03',7,27000,'VND'),
('Sach04',N'Tình vùng trộm','NXB04','TG04','TL04',5,28000,'VND'),
('Sach05',N'Trà sửa cho tâm hồn','NXB05','TG05','TL05',5,10000,'VND'),
('Sach06',N'Hoàng tử bé','NXB06','TG06','TL06',9,19000,'VND'),
('Sach07',N'Kinh tế vĩ mô','NXB07','TG07','TL07',3,50000,'VND'),
('Sach08',N'Triết học','NXB08','TG08','TL08',10,90000,'VND'),
('Sach09',N'Sách cho bé','NXB09','TG09','TL08',15,120000,'VND'),
('Sach10',N'Ca dao dân ca','NXB10','TG10','TL10',25,820000,'VND')
----10 bản ghi bảng khách hàng
INSERT INTO tblKhachHang
VALUES 
('KH01',N'Hoàng',N'Thanh Hóa','0383838331'),
('KH02',N'Độ',N'Hải Phòng','0338768211'),
('KH03',N'Khởi',N'Hà Nam','0987123721'),
('KH04',N'Quý',N'Bình Định','0387928172'),
('KH05',N'Hải Lâm',N'Thái Nguyên','0892028731'),
('KH06',N'Trường',N'Hà Nội','0986482741'),
('KH07',N'Vương',N'Quảng Bình','0376827381'),
('KH08',N'Mùi',N'Cà Mau','0339283123'),
('KH09',N'Tuấn',N'Tuyên Quang','0987652911'),
('KH10',N'Hà',N'Hà Tĩnh','0976829182')
-----10 bản ghi bảng nhân viên
INSERT INTO tblNhanVien
VALUES 
('NV01',N'Khởi','Nam',N'Quảng Nam','0928765182','11/03/2004','4/10/2023',1500000,10000),
('NV02',N'Lan',N'Nữ',N'Hưng Yên','0987682731','5/03/2004','4/10/2023',1000000,1000),
('NV03',N'Quỳnh',N'Nữ',N'Thái Bình','0986727621','6/03/2004','4/10/2023',1200000,1000),
('NV04',N'Thái','Nam',N'Hà Nam','0327891823','11/03/2002','4/10/2023',1200000,1200),
('NV05',N'Sơn','Nam',N'Hải Phòng','0987598734','11/03/2003','4/10/2023',1300000,1500),
('NV06',N'Trường','Nam',N'Hà Tĩnh','0967928371','11/03/2001','4/10/2022',1500000,1000),
('NV07',N'Vinh','Nam',N'Cà Mau','0972587619','9/03/2004','8/19/2023',2000000,1200),
('NV08',N'Quang','Nam',N'Hà Nội','0981637861','10/03/2002','6/20/2021',1200000,1000),
('NV09',N'Khánh','Nam',N'Hà Nam','0983274287','1/03/2001','7/17/2020',1200000,2000),
('NV10',N'Vũ','Nam',N'Thanh Hóa','0338291231','11/03/2000','8/15/2020',1200000,10000)

--10 bản ghi bảng hóa đơn nhập hàng 
insert into tblHoaDonNhapHang
values(1,'NV01','NXB01','01/02/2023'),
		(2,'NV02','NXB02','02/03/2023'),
		(3,'NV03','NXB04','03/04/2021'),
		(4,'NV04','NXB02','02/02/2022'),
		(5,'NV05','NXB09','02/09/2021'),
		(6,'NV06','NXB07','10/12/2020'),
		(7,'NV07','NXB02','09/30/2019'),
		(8,'NV08','NXB03','05/23/2019'),
		(9,'NV09','NXB05','02/22/2023'),
		(10,'NV10','NXB03','07/01/2020')
-- 10 bản ghi bảng chi tiết hóa đơn nhập hàng
insert into tblChiTietHDNhapHang
values(1,'Sach01',10,12900),(2,'Sach02',299,33000),
	(3,'Sach03',35,11200),(4,'Sach04',29,12000),
	(5,'Sach05',32,10200),(6,'Sach06',99,15000),
	(7,'Sach07',28,18200),(8,'Sach08',15,100000),
	(9,'Sach09',70,11800),(10,'Sach10',10,320000)

--10 bản ghi hóa đơn mua hàng
insert into tblHoaDonMuaHang
values(1,'NV01','KH01','02/01/2023'),(2,'NV02','KH02','07/10/2023'),
(3,'NV03','KH03','10/01/2023'),(4,'NV04','KH04','02/01/2023'),
(5,'NV05','KH05','02/21/2023'),(6,'NV06','KH06','04/02/2023'),
(7,'NV07','KH05','03/11/2023'),(8,'NV05','KH08','06/12/2023'),
(9,'NV09','KH09','08/09/2023'),(10,'NV02','KH10','07/12/2023')

--10 bản ghi chi tiết hóa đơn mua hàng
insert into tblChiTietHDMuaHang
values(1,'Sach01',12000,2,0),(2,'Sach03',10000,3,1000),
(3,'Sach04',11000,1,0),(4,'Sach02',18000,2,1000),
(5,'Sach02',22000,3,1200),(6,'Sach09',30000,1,1500),
(7,'Sach03',14000,1,0),(8,'Sach07',24000,2,1000),
(9,'Sach06',11000,2,1000),(10,'Sach01',10000,1,1200)


