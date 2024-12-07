
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
('NXB01',N'Tuổi Trẻ','0982123211',N'Hà Nội'),
('NXB02',N'Kim Đồng','0812762981',N'Bắc Ninh'),
('NXB03',N'Hội Nhà Văn','0328987612',N'Bắc Giang'),
('NXB04',N'Thanh Niên','0879738274',N'Hà Nội'),
('NXB05',N'Phụ Nữ Việt Nam','0987689872',N'Hà Nội'),
('NXB06',N'Lao Động','0398271872',N'Hà Nội'),
('NXB07',N'Nhã Nam','0982789182',N'TPHCM'),
('NXB08',N'Đông Á','0339798380',N'TPHCM'),
('NXB09',N'Thiếu Nhi','0321987789',N'TPHCM'),
('NXB10',N'Giáo Dục Việt Nam','0123212342',N'Hà Nội')


----10 bản ghi bảng Sách
INSERT INTO tblSach
VALUES
('Sach01',N'Dế mèn phiêu lưu ký ','NXB01','TG01','TL01',30,40000,'VND'),
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


insert into tblTacGia
values
('TG11',N'Ernest Hemingway'),
('TG12',N'Hector Malot'),
('TG13',N'Nikolai Ostrovsky'),
('TG14',N'Paulo Coelho'),
('TG15',N'Victor Hugo'),
('TG16',N'Dan Brown'),
('TG17',N'Arthur Conan Doyle'),
('TG18',N'Thomas Harris'),
('TG19',N'Agatha Christie'),
('TG20',N'Higashino Keigo'),
('TG21',N'Carlo Collodi'),
('TG22',N'Roald Dahl'),
('TG23',N'Luis Sepúlveda'),
('TG24',N'Grimm'),
('TG25',N'Hans Christian Andersen'),
('TG26',N'Nguyễn Đổng Chi')

INSERT INTO tblSach
VALUES
('Sach11',N'Ông Già Và Biển Cả','NXB02','TG11','TL04',15,32000,'VND'),
('Sach12',N'Không Gia Đình','NXB02','TG12','TL04',8,121000,'VND'),
('Sach13',N'Thép Đã Tôi Thế Đấy ','NXB03','TG13','TL04',5,123000,'VND'),
('Sach14',N'Nhà Giả Kim','NXB04','TG14','TL04',12,60000,'VND'),
('Sach15',N'Những Người Khốn Khổ','NXB02','TG15','TL04',10,250000,'VND'),
--
('Sach16',N'Mật mã Da Vinci','NXB05','TG16','TL01',21,85000,'VND'),
('Sach17',N'Sherlock Holmes','NXB05','TG16','TL01',5,350000,'VND'),
('Sach18',N'Sự im lặng của bầy cừu','NXB05','TG16','TL01',41,90000,'VND'),
('Sach19',N'Án mạng trên sông Nile','NXB05','TG16','TL01',10,100000,'VND'),
('Sach20',N'Phía sau Nghi can X','NXB05','TG16','TL01',34,87000,'VND'),
--
('Sach21',N'Những cuộc phiêu lưu của Pinocchio','NXB02','TG21','TL02',10,70000,'VND'),
('Sach22',N'Charlie và nhà máy chocolate','NXB02','TG22','TL02',16,60000,'VND'),
('Sach23',N'Chuyện con mèo dạy hải âu bay','NXB02','TG23','TL02',10,40000,'VND'),
--
('Sach24',N'Truyện cổ Grimm','NXB06','TG24','TL03',26,117000,'VND'),
('Sach25',N'Truyện cổ Andersen','NXB06','TG25','TL03',3,379000,'VND'),
('Sach26',N'Kho tàng truyện cổ tích Việt Nam','NXB06','TG26','TL03',5,550000,'VND')


---- TRUY VẤN LẤY DỮ LIỆU TỪ 1 BẢNG

--1. lấy ra các nhân viên nữ trong bảng tblNhanVien

select * from tblNhanVien
where sGioiTinh = N'nữ'

--2. lấy ra các nhân viên vào làm trước tháng 6/2023

select * from tblNhanVien
where month(dNgayVaoLam) <=6 and year(dNgayVaoLam) <= 2023

--3. lấy ra các cuốn sách có số lượng > 10

select * from tblSach
where fSoLuong > 10

--4. lấy ra các hóa đơn mua hàng được lập trong tháng 6/2023

 select * from tblHoaDonMuaHang
 where month(dNgayMuaHang) =6 and year(dNgayMuaHang) =2023

 --5. cho biết số tiền phải trả của từng đơn đặt hàng 
 select iSoHDMH as [Mã Hóa Đơn], 
	sum (fDonGia*fSoLuong - fGiamGia ) as [Tổng Tiền]
 from tblChiTietHDMuaHang
 group by iSoHDMH

 ---- TRUY VẤN LẤY DỮ LIỆU TỪ NHIỀU BẢNG

  --1. lấy ra các cuốn sách thuộc thể loại ' truyện cổ tích '

  select sTenSach as [Tên Sách], sTenTheLoai as [Thể loại] from tblSach, tblTheLoaiSach
  where tblSach.sMaLoaiSach = tblTheLoaiSach.sMaLoaiSach 
  and tblTheLoaiSach.sTenTheLoai = N'Truyện cổ tích'

  --2. lấy ra tên các cuốn sách được nhập trong năm 2023
  select sTenSach as [Tên Sách], dNgayNhap as [Tên Thể Loại] from tblSach, tblHoaDonNhapHang , tblChiTietHDNhapHang
  where tblSach.sMaSach = tblChiTietHDNhapHang.sMaSach and tblChiTietHDNhapHang.iSoHDNH = tblHoaDonNhapHang.iSoHDNH
  and year(dNgayNhap) = 2023

  --3. lấy danh sách khách hàng và tổng tiền đặt hàng của mỗi người
	select * from tblKhachHang
	select * from tblHoaDonMuaHang
	select * from tblChiTietHDMuaHang
	select tblKhachHang.sMaKhachHang as [Mã Khách Hàng], sTenKhachHang as [Tên Khách Hàng] ,
	(
	case 
		when sum(fDonGia*fSoLuong - fGiamGia) > 0 then sum(fDonGia*fSoLuong - fGiamGia)
		else 0
	end
	)
	as [Tổng Tiền Đặt Hàng]
	
	from tblKhachHang left join ( tblChiTietHDMuaHang left join tblHoaDonMuaHang on tblHoaDonMuaHang.iSoHDMH = tblChiTietHDMuaHang.iSoHDMH )
	on tblKhachHang.sMaKhachHang = tblHoaDonMuaHang.sMaKhachHang
	group by tblKhachHang.sMaKhachHang, sTenKhachHang

  --4. lấy ra những cuốn sách chỉ được mua 1 lần trong năm 2023

	select tblSach.sMaSach as [Mã Sách] , tblSach.sTenSach as [ Tên Sách]
	from tblChiTietHDMuaHang ,  tblHoaDonMuaHang , tblSach
	where YEAR(dNgayMuaHang) = 2023 and tblChiTietHDMuaHang.sMaSach = tblSach.sMaSach 
		and tblChiTietHDMuaHang.iSoHDMH = tblHoaDonMuaHang.iSoHDMH
	group by tblSach.sMaSach , sTenSach
	having (COUNT(tblChiTietHDMuaHang.sMaSach) = 1)

	--5. lấy ra tên sách ,số lượng đã được mua của từng cuốn sách
	select tblSach.sTenSach as [ Tên sách], 
		(case 
				when SUM(tblChiTietHDMuaHang.fSoLuong) > 0 then SUM(tblChiTietHDMuaHang.fSoLuong)
				else 0 
		end)   
	as [ Số Lượng Đặt Hàng]

	from tblSach  left join tblChiTietHDMuaHang 
	on tblChiTietHDMuaHang.sMaSach = tblSach.sMaSach
	group by tblSach.sTenSach

  ---- Tạo Stored Procedure (7 câu)

  --1. proc thêm 1 bản ghi nhà xuất bản
go
	create proc insertNXB
	  @maMXB varchar(15), @tenNXB nvarchar(50), @SDT varchar(12), @Diachi nvarchar(50)
	as
	begin 
		insert into tblNhaXuatBan
		values (@maMXB,@tenNXB,@SDT,@Diachi)

		select * from tblNhaXuatBan
	end
	-- thực thi proc insertNXB
	exec insertNXB  'NXB11', N'Nhà Xuất Bản Hà Nội' , '038927382', N'Hà Nội'
  -- 2. xóa 1 cuốn sách khỏi bảng tblsach với tên cuốn sách được nhập
  go
		create proc deleteSach
		@tensach nvarchar(50)
		as
		begin
			delete from tblSach
			where @tensach = sTenSach
			select * from tblSach
		end

		-- thực thi proc deleteSach
		exec deleteSach N'Ông Già Và Biển Cả'
		

  --3. proc cho biết thể loại sách và nhà xuất bản của cuốn sách với tên cuốn sách được nhập
  go
	  create proc Sach_TheLoai_NXB
	  @tensach nvarchar(50)
	  as
	  begin
		select @tensach as [Tên Sách], sTenNXB as [Nhà Xuất Bản] ,  sTenTheLoai as [Thể Loại] 
		from tblNhaXuatBan inner join (tblSach inner join tblTheLoaiSach on tblSach.sMaLoaiSach = tblTheLoaiSach.sMaLoaiSach) 
		on tblSach.sMaNXB = tblNhaXuatBan.sMaNXB
		where @tensach = sTenSach
	  end
	  -- thực thi proc Sach_TheLoai_NXB
	  exec Sach_TheLoai_NXB N'Charlie và nhà máy chocolate'
  
  --4. proc tăng lương cho các nhân viên làm việc được 1 năm 
  go
	  create proc TangLuong
	  as
	  begin 
	  update tblNhanVien
	  set fLuongCoBan = fLuongCoBan * 1.5
	  where DATEDIFF(day, dNgayVaoLam, GETDATE())/365 >=1 
	  select * from tblNhanVien
	  end
	  -- thực thi proc TangLuong
	  select * from tblNhanVien
      exec TangLuong
  --5. proc cho biết tuổi cao nhất của nhân viên 
  go
		create proc LayTuoiMax
		@TuoiMax int output
		as
			set @TuoiMax = 0
			select @TuoiMax =  MAX (datediff(day, dNgaysinh, getdate() ))/365 
			from tblNhanVien
		-- thực thi proc LayTuoiMax
		declare @maxtuoi int
		exec LayTuoiMax @TuoiMax = @maxtuoi output 
		select @maxtuoi as [Tuổi Lớn Nhất]

 --6. proc đếm số nhân viên nam, nhân viên nữ và tổng số nhân viên 
   go
		create proc DemNhanVien
		@nam int output,
		@nu int output
		as	
			set @nam = 0
			set @nu = 0
			select @nam = COUNT(*) FROM tblNhanVien
			where sGioiTinh = N'Nam';
			select @nu = COUNT(*) FROM tblNhanVien
			where sGioiTinh = N'Nữ';
			return @nam + @nu 
		-- thực thi proc DemNhanVien
		 declare @sonam int, @sonu int  , @tong int
		 exec @tong = DemNhanVien 
			@nam = @sonam output, @nu = @sonu output 
			select @sonam as [ Số Nhân Viên Nam ] , @sonu as [ Số Nhân Viên Nữ ] , @tong as [Tổng Số Nhân Viên]

 --7. proc in ra tổng tiền thanh toán của hóa đơn nhập hàng với mã hóa đơn là tham số truyền vào
   go
		create proc TongTienTT
		@SoHDNH  int
		as
		begin
			select iSoHDNH as [Số Hóa Đơn] , sum([fSoLuongNhap]*[fGiaNhap]) as [Tổng Tiền Thanh Toán]from tblChiTietHDNhapHang
			where iSoHDNH = @SoHDNH		
			group by iSoHDNH
		end

		-- thực thi proc TongTienTT
		exec TongTienTT 3
--8. proc thêm 1 bản ghi chi tiết hóa đơn nhập hàng
	go
		create proc insertChiTietHDNH
		@iSoHDNH int,
		@sMaSach varchar(15),
		@fSoLuongNhap float,
		@fGiaNhap float
		as
		begin
			if exists (select * from tblHoaDonNhapHang where @iSoHDNH = iSoHDNH)
				begin
					if (not exists (select * from tblChiTietHDNhapHang where sMaSach = @sMaSach and iSoHDNH = @iSoHDNH))
						begin
							if((@fSoLuongNhap > 0 and @fGiaNhap > 0 ))
								begin
									insert tblChiTietHDNhapHang
									values(@iSoHDNH,@sMaSach,@fSoLuongNhap,@fGiaNhap)
									select * from tblChiTietHDNhapHang
								end
							else print(N'Số lượng phải > 0 và đơn giá phải > 0')
						end
					else print(N'Mã sách này đã tồn tại trong chi tiết hd nhập hàng')
				end
			else print(N'iSoHDMH chưa tồn tại')
		end
		-- thực thi proc insertChiTietHDNH
		exec insertChiTietHDNH 1,'Sach02',10,20000
--9. Proc xóa chi tiết hd nhập hàng với mã sách và iSoHDNH được truyền vào 
	go
		create proc XoaChiTietHDNH
		@isohdnh int,
		@smasach varchar(15)
		as
		begin
			delete from tblChiTietHDNhapHang 
			where iSoHDNH = @isohdnh and sMaSach = @smasach
			select * from tblChiTietHDNhapHang
		end
		-- thực thi proc XoaChiTietHD
		select * from tblChiTietHDNhapHang
		exec XoaChiTietHDNH 1 ,'Sach02'
--10. Proc sửa đổi số lượng và giá bán của bảng chi tiết hóa đơn nhập hàng với tham số truyền vào là iSoHDNH ,sMaSach
--, số lượng mới và giá bán mới iSoHDNH và sMaSach và số lượng mới 
    go
		create proc SuaDoi_SL_GB_ChiTietHDNH
		@isohdnh int,
		@smasach varchar(15),
		@fsoluongnhap float,
		@fgianhap float
		as
		begin 
			if((@fsoluongnhap > 0 and @fgianhap > 0) )
			begin
			update tblChiTietHDNhapHang
			set fSoLuongNhap = @fsoluongnhap , fGiaNhap = @fgianhap
			where iSoHDNH = @isohdnh and sMaSach = @smasach
			select * from tblChiTietHDNhapHang
			end
			else begin print(N'Vui lòng nhập lại số lượng và giá bán phải > 0') end
		end
		-- thực thi proc SuaDoi_SL_GB_ChiTietHDNH
		select * from tblChiTietHDNhapHang
		exec SuaDoi_SL_GB_ChiTietHDNH 1, 'Sach01',10,1000
--11. Proc thêm 1 bản ghi sách  
	go
		create proc insertSach
		@sMaSach varchar(15),
		@sTenSach nvarchar(50),
		@sMaNXB varchar(15),
        @sMaTacGia varchar(15),
        @sMaLoaiSach varchar(15),
        @fSoLuong float,
        @fGiaBan float,
        @sDonViTinh varchar(5)
		as
		begin
			if not exists (select * from tblSach where sMaSach = @sMaSach)
				begin
					if exists ((select * from tblNhaXuatBan,tblTacGia,tblTheLoaiSach
					where sMaNXB = @sMaNXB and sMaLoaiSach = @sMaLoaiSach and sMaTacGia = @sMaTacGia ))
					 begin
						 if ((@fSoLuong >= 0 and @fGiaBan > 0 ))
						 begin
					   		insert into tblSach
							values(@sMaSach,@sTenSach,@sMaNXB,@sMaTacGia,@sMaLoaiSach,@fSoLuong,@fGiaBan,@sDonViTinh)
							select * from tblSach
						 end
						 else print(N'Số lượng >=0 và giá bán phải > 0')			
					 end
					 else print(N'Kiểm tra xem mã NXB, mã TG, mã loại sách có tồn tại ko') 
				end
			else print(N'Mã sách này đã tồn tại')
		end
		-- thực thi proc insertSach
		exec insertSach 'Sach030',N'Dế mèn phiêu lưu ký 2','NXB01','TG01','TL01',10,1000,'VND'
--12. Proc thêm 1 bản ghi chi tiết hóa đơn mua hàng 
	go
		create or alter proc insertChiTietHDMH
		@iSoHDMH int,
		@sMaSach varchar(15),
		@fDonGia float,
		@fSoLuong float,
		@fGiamGia float
		as
		begin
			if exists (select * from tblHoaDonMuaHang where @iSoHDMH = iSoHDMH)
				begin
					if (not exists (select * from tblChiTietHDMuaHang where sMaSach = @sMaSach and iSoHDMH = @iSoHDMH))
						begin
							if((@fSoLuong > 0 and @fDonGia > 0 ))
								begin
									insert tblChiTietHDMuaHang
									values(@iSoHDMH,@sMaSach,@fDonGia,@fSoLuong,@fGiamGia)
									select * from tblChiTietHDMuaHang
								end
							else print(N'Số lượng phải > 0 và đơn giá phải > 0')
						end
					else print(N'Mã sách này đã tồn tại trong chi tiết hd mua hàng')
				end
			else print(N'iSoHDMH chưa tồn tại')
		end
		-- thực thi proc insertChiTietHDMH
		exec insertChiTietHDMH 1,Sach02,12000,2,0
--13. Proc cho biết nhân viên nào bán được nhiều (sách) nhất trong năm được nhập từ bàn phím 
	go
		create or alter proc NhanVienBanNhieuSach_theo_nam
		@nam date
		as
		begin
			select top 1  tblNhanVien.sMaNhanVien as[Mã nhân viên],sTenNhanVien as[Tên nhân viên]
			,sum([dbo].[tblChiTietHDMuaHang].[fSoLuong]) as[Số lượng sách đã bán]
			from tblNhanVien ,tblChiTietHDMuaHang,tblHoaDonMuaHang
			where (year(tblHoaDonMuaHang.dNgayMuaHang) = year(@nam)) and
			tblChiTietHDMuaHang.iSoHDMH = tblHoaDonMuaHang.iSoHDMH and
			tblHoaDonMuaHang.sMaNhanVien = tblNhanVien.sMaNhanVien
			group by tblNhanVien.sMaNhanVien , tblNhanVien.sTenNhanVien
			Order by sum([dbo].[tblChiTietHDMuaHang].[fSoLuong]) desc
		end 
		-- thực thi proc NhanVienBanNhieuSach_theo_nam
		exec NhanVienBanNhieuSach_theo_nam '2023'
--14. Proc thống kê số lượng nhân viên sinh năm nhập từ bàn phím
	go
		create proc ThongKeSoLuongNhanVien_SN
		@nam date
		as
		begin
			select tblNhanVien.sMaNhanVien as [Mã nhân viên], tblNhanVien.sTenNhanVien as [Tên nhân viên] , tblNhanVien.dNgaySinh as[Ngày sinh] from tblNhanVien
			where year(tblNhanVien.dNgaySinh) = year(@nam)
		end
		-- thực thi proc ThongKeSoLuongNhanVien_SN
		exec ThongKeSoLuongNhanVien_SN '2002'

  --d. Tạo View hiện dữ liệu (10 view)

--1 View số sách của mỗi thể loại sách 
go
create or alter view View_SoSachCuaMoiTheLoaiSach
as 
select tls.sMaLoaiSach,tls.sTenTheLoai,count(s.sMaSach) as iSoLuongSach
from tblTheLoaiSach as tls left join tblSach as s
on tls.sMaLoaiSach=s.sMaLoaiSach
group by tls.sMaLoaiSach,tls.sTenTheLoai
go

select *
from View_SoSachCuaMoiTheLoaiSach
go

--2 View số lượng sách đã sáng tác của mỗi tác giả 
create or alter view View_SoLuongSachDaSangTacCuaMoiTacGia
as
select tg.sMaTacGia,tg.sTenTacGia,count(s.sMaSach) as iSoLuongSach
from tblTacGia as tg left join tblSach as s
on tg.sMaTacGia=s.sMaTacGia
group by tg.sMaTacGia,tg.sTenTacGia
go 

select *
from View_SoLuongSachDaSangTacCuaMoiTacGia
go

--3 View số lượng đơn hàng của mỗi khách hàng 
create or alter view View_SoDonHangCuaMoiKhachHang
as
select kh.sMaKhachHang,kh.sTenKhachHang, count(hdmh.iSoHDMH) as iSoLuongDonHang
from tblKhachHang as kh left join tblHoaDonMuaHang as hdmh
on kh.sMaKhachHang=hdmh.sMaKhachHang
group by kh.sMaKhachHang,kh.sTenKhachHang
go
select * 
from View_SoDonHangCuaMoiKhachHang
go

--4 View số lượng đơn hàng và tổng tiền mà mỗi nhân viên bán được 
create or alter view View_SoDonHangVaTongTienMoiNhanVienBanDuoc
as
select nv.sMaNhanVien,nv.sTenNhanVien,
		count(hdmh.iSoHDMH) as iSoLuongDonHang,
		sum(case when hdmh.iSoHDMH is not null then (cthdmh.fSoLuong*cthdmh.fDonGia-cthdmh.fSoLuong*cthdmh.fGiamGia) else 0 end) as iTongTien
from tblNhanVien as nv left join tblHoaDonMuaHang as hdmh
on nv.sMaNhanVien=hdmh.sMaNhanVien left join tblChiTietHDMuaHang as cthdmh
on hdmh.iSoHDMH=cthdmh.iSoHDMH
group by nv.sMaNhanVien,nv.sTenNhanVien
go

select * 
from View_SoDonHangVaTongTienMoiNhanVienBanDuoc
go

--5 View tổng tiền và số lượng hàng của mỗi hóa đơn nhập hàng 
create or alter view View_TongTienVaSoLuongHangCuaMoiHoaDonNhap
as 
select hdnh.iSoHDNH,hdnh.dNgayNhap,
		count(cthdnh.fSoLuongNhap) as iSoLuong,
		sum( case when cthdnh.iSoHDNH is not null then cthdnh.fSoLuongNhap*cthdnh.fGiaNhap else 0 end ) as fTongTien
from tblHoaDonNhapHang as hdnh left join tblChiTietHDNhapHang cthdnh
on hdnh.iSoHDNH=cthdnh.iSoHDNH
group by hdnh.iSoHDNH,hdnh.dNgayNhap
go

select *
from View_TongTienVaSoLuongHangCuaMoiHoaDonNhap
go

-- 6 View số lượng và tổng tiền sách của mỗi nhà xuất bản 
create or alter view View_SoLuongVaTongTienSachCuaMoiNhaXuatBan
as 
select nxb.sMaNXB,nxb.sTenNXB,
		count(s.sMaSach) as iSoLuongSach,
		sum(case when s.sMaSach is not null then s.fSoLuong*s.fGiaBan else 0 end) as fTongTienSach
from tblNhaXuatBan as nxb left join tblSach as s 
on nxb.sMaNXB=s.sMaNXB
group by nxb.sMaNXB,nxb.sTenNXB
go

select *
from View_SoLuongVaTongTienSachCuaMoiNhaXuatBan
go

-- 7 View trung bình số tiền bán hàng của mỗi nhân viên 
create or alter view View_TrungBinhSoTienBanDuocCuaMoiNhanVien
as
select nv.sMaNhanVien,nv.sTenNhanVien,
		avg(case when cthdmh.iSoHDMH is not null then (cthdmh.fSoLuong*cthdmh.fDonGia-cthdmh.fSoLuong*cthdmh.fGiamGia) else 0 end) as fSoTienTrungBinh
from tblNhanVien as nv left join tblHoaDonMuaHang as hdmh
on nv.sMaNhanVien=hdmh.sMaNhanVien left join tblChiTietHDMuaHang as cthdmh
on hdmh.iSoHDMH=cthdmh.iSoHDMH
group by nv.sMaNhanVien,nv.sTenNhanVien
go

select * 
from View_TrungBinhSoTienBanDuocCuaMoiNhanVien;
go 

-- 8 View tính số lượng nhan vien theo giới tính 
create or alter View View_SoLuongNhanVienTheoGioiTinh 
as
select  nv.sGioiTinh, count(nv.sMaNhanVien) as iSoLuongNhanVien
from tblNhanVien as nv 
group by  nv.sGioiTinh
go 

select * 
from View_SoLuongNhanVienTheoGioiTinh; 
go

--9 View 3 khách hàng mua hàng nhiều nhất 
create or alter view View_3KhachMuaHangNhieuNhat 
as 
select top 3 kh.sMaKhachHang,kh.sTenKhachHang, count(hdmh.iSoHDMH) as iSoDonHang
from tblKhachHang as kh inner join tblHoaDonMuaHang as hdmh
on kh.sMaKhachHang=hdmh.sMaKhachHang
group by kh.sMaKhachHang,kh.sTenKhachHang
order by count(hdmh.iSoHDMH) desc; 
go

select * 
from View_3KhachMuaHangNhieuNhat
go

--10 View so luong sach ban duoc cua moi the loai
create or alter view View_SoLuongSachBanDuocCuaMoiTheLoai
as
select tls.sMaLoaiSach,tls.sTenTheLoai, count(hdmh.iSoHDMH) as iSoLuongSachBanDuoc
from tblTheLoaiSach as tls left join tblSach as s 
on tls.sMaLoaiSach=s.sMaLoaiSach left join tblChiTietHDMuaHang as cthdmh
on s.sMaSach=cthdmh.sMaSach left join tblHoaDonMuaHang as hdmh
on cthdmh.iSoHDMH=hdmh.iSoHDMH
group by tls.sMaLoaiSach,tls.sTenTheLoai
go

select * 
from View_SoLuongSachBanDuocCuaMoiTheLoai
go




--f. Viết các Trigger cho phép kiểm soát ràng buộc dữ liệu, đồng bộ dữ liệu: đơn giản, phức tạp, IF_UPDATE (ít nhất 10 trigger)
--Viết lệnh kích hoạt các Trigger

--1 Viết trigger để số lượng sách bán ra không vượt quá số lượng sách hiện có

create or alter trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo
on tblChiTietHDMuaHang 
for insert, update
as 
declare @sMaSach nvarchar(15)  , @fSoLuong float
select @sMaSach=sMaSach, @fSoLuong=fSoLuong from inserted

declare Cursor_DemSoLuongSach cursor static
for select fSoLuong from tblChiTietHDMuaHang where sMaSach=@sMaSach

open Cursor_DemSoLuongSach
declare @fTongSoLuongSachMua float , @fSoLuongSach float
fetch next from Cursor_DemSoLuongSach into @fSoLuongSach
set @fTongSoLuongSachMua=0
while @@FETCH_STATUS=0
	begin
		set @fTongSoLuongSachMua=@fTongSoLuongSachMua+@fSoLuongSach
		fetch next from Cursor_DemSoLuongSach into @fSoLuongSach
	end

close Cursor_DemSoLuongSach
deallocate Cursor_DemSoLuongSach

if(@fTongSoLuongSachMua>(select fSoLuong from tblSach where @sMaSach=sMaSach))
	begin
		print 'So luong sach khong du de ban'
		rollback tran
	end

go
create or alter trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo
on tblChiTietHDMuaHang 
for insert, update
as 
declare @sMaSach nvarchar(15)  , @fSoLuong float, @fTongSoLuongSachHienCo float
select @sMaSach=sMaSach, @fSoLuong=fSoLuong from inserted
select @fTongSoLuongSachHienCo= count(s.sMaSach)
from tblSach as s 
where s.sMaSach=@sMaSach

if(@fTongSoLuongSachHienCo<(select sum(cthdmh.fSoLuong) from tblChiTietHDMuaHang as cthdmh where cthdmh.sMaSach=@sMaSach group by cthdmh.sMaSach))
	begin
		print 'So luong sach khong du de ban'
		rollback tran
	end

alter table tblChiTietHDMuaHang disable trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo
alter table tblChiTietHDMuaHang enable trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo

insert into tblChiTietHDMuaHang
values (1,'Sach07',12000,3,1200);
go

--2 Thêm fTongTienHang vào bảng tblKhachHang viết trigger khi khách hàng đến mua hàng thì tổng tiền hàng tự động tăng 

alter table tblKhachHang
add fTongTienHang float

update tblKhachHang
set fTongTienHang=0 
go

create or alter trigger Trigger_KhachHangDenMuaHangThiTongTienHangTuDongTang
on tblChiTietHDMuaHang
for insert, update
as
declare @iSoHDMH int, @fDonGia float, @fSoLuong float, @fGiamGia float 
select @iSoHDMH=iSoHDMH, @fDonGia=fDonGia, @fSoLuong=fSoLuong, @fGiamGia=fGiamGia from inserted
update tblKhachHang
set fTongTienHang=fTongTienHang +(@fSoLuong*@fDonGia-@fGiamGia)
from tblKhachHang as kh inner join tblHoaDonMuaHang as hdmh
on kh.sMaKhachHang=hdmh.sMaKhachHang inner join tblChiTietHDMuaHang as cthdmh
on hdmh.iSoHDMH=cthdmh.iSoHDMH and cthdmh.iSoHDMH=@iSoHDMH

insert into tblChiTietHDMuaHang
values (1,'Sach08',12000,3,1200);

alter table tblChiTietHDMuaHang disable trigger Trigger_KhachHangDenMuaHangThiTongTienHangTuDongTang
alter table tblChiTietHDMuaHang enable trigger Trigger_KhachHangDenMuaHangThiTongTienHangTuDongTang
go

--3  Viết trigger đảm bảo mỗi hóa đon chỉ được mua tối đa 3 sách khác nhau
create or alter trigger Trigger_MoiHoaDonChiDuocMuaToiDa3SachKhacNhau
on tblChiTietHDMuaHang
for insert , update
as
declare @iSoHDMH int , @sMaSach nvarchar(15)
select @iSoHDMH=iSoHDMH,@sMaSach=sMaSach  from inserted

if ((select count(sMaSach) from tblChiTietHDMuaHang where iSoHDMH=@iSoHDMH group by iSoHDMH)>3)
	begin
		print 'Moi hoa don chi duoc mua toi da ba sach khac nhau'
		rollback tran
	end

insert into tblChiTietHDMuaHang
values (1,'Sach08',12000,3,1200);
insert into tblChiTietHDMuaHang
values (1,'Sach07',12000,3,1200);
insert into tblChiTietHDMuaHang
values (1,'Sach06',12000,3,1200);

alter table tblChiTietHDMuaHang disable trigger Trigger_MoiHoaDonChiDuocMuaToiDa3SachKhacNhau
alter table tblChiTietHDMuaHang enable trigger Trigger_MoiHoaDonChiDuocMuaToiDa3SachKhacNhau
go

--4 Viết trigger mỗi nhân viên chỉ được lập 3 hóa đơn mua hang 1 ngày 
create or alter trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
on tblHoaDonMuaHang
for insert, update
as
declare @sMaNhanVien nvarchar(15), @dNgayMuaHang date
select @sMaNhanVien=sMaNhanVien, @dNgayMuaHang=dNgayMuaHang from inserted
if ((select count(sMaNhanVien) from tblHoaDonMuaHang where sMaNhanVien=@sMaNhanVien and dNgayMuaHang=@dNgayMuaHang group by sMaNhanVien,dNgayMuaHang)>3)
	begin 
		print 'Moi nhan vien chi duoc lap 3 hoa don mua hang trong 1 ngay'
		rollback tran
	end

insert into tblHoaDonMuaHang
values (11,'NV01','KH10','2023-10-22')
insert into tblHoaDonMuaHang
values (12,'NV01','KH10','2023-10-22')
insert into tblHoaDonMuaHang
values (13,'NV01','KH10','2023-10-22')
insert into tblHoaDonMuaHang
values (14,'NV01','KH10','2023-10-22')

alter table tblHoaDonMuaHang disable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
alter table tblHoaDonMuaHang enable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
go

-- 5 Thêm iSoDonHangBanDuoc cho tblNhanVien viết trigger khi nhân viên bán được 1 đon hàng cột số đơn hàng tự động tăng 
alter table tblNhanVien
add iSoDonHangBanDuoc int 

update tblNhanVien
set iSoDonHangBanDuoc=0; 
go

create or alter trigger Trigger_NhanVienBanDuocHangCotSoDonHangTuDongTang
on tblHoaDonMuaHang
for insert, update
as
declare @sMaNhanVien nvarchar(15)
select @sMaNhanVien=sMaNhanVien from inserted

update tblNhanVien
set iSoDonHangBanDuoc=iSoDonHangBanDuoc+1
where sMaNhanVien=@sMaNhanVien

insert into tblHoaDonMuaHang
values (11,'NV01','KH01','2023-01-01')


alter table tblHoaDonMuaHang disable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
alter table tblHoaDonMuaHang enable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay