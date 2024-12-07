---2.1---
select * from tblLoaiHang
--a
insert into tblLoaiHang
values ('LH01', N'Điện Tử' ),('LH02', N'Đồ Chơi' ),('LH03', N'Thể Thao' )
--b
insert into tblMatHang ( sMahang,sTenhang,sMaloaihang,fSoluong,fGiaHang,sDonvitinh)
values ('MH01',N'Apple MacBook Air 15 inch','LH01',3,31000000,'VND'),
('MH02',N'Apple iPhone 14 Pro Max 256GB','LH01',10,29590000,'VND'),
('MH03',N'Apple AirPods 3rd','LH01',6,3990000,'VND'),
('MH04',N'Gấu Bông LENA Teddy','LH02',21,300000,'VND'),
('MH05',N'Đồ Chơi Xếp Hình','LH02',30,200000,'VND'),
('MH06',N'Bộ trò chơi Thám tử','LH02',25,275000,'VND'),
('MH07',N'Adidas Bóng đá Áo Đấu','LH03',88,1720000,'VND'),
('MH08',N'Adidas Bóng đá Quần Short','LH03',73,500000,'VN D'),
('MH09',N'Adidas Bóng đá Giày','LH03',12,1040000,'VND')
-- xóa các mặt hàng có số lượng = 0 
insert into tblMatHang
values ('MH10',N'Apple MacBook Air',1,'LH01',0,31000000,'VND')
--d
delete from tblMatHang
where fSoluong = 0 

-- tang phu cap cho nhan vien lam viec tren 5 nam
update tblNhanVien
set fphucap = fphucap * 1.1
where (Year(getdate()) - YEAR(dngayvaolam) >=5 ) 

---2.2---
select * from tblKhachHang 
select * from tblNhanVien
select * from tblDonDatHang
select * from tblChiTietDatHang
--a
INSERT INTO tblKhachHang
VALUES('1',N'Trần Quốc Huy ',N'Hà Nội','0983267820',1),

('2',N'Phùng Văn Long',N'Bắc Ninh','0982268873',1),

('3',N'Trần Thị Thu Hằng',N'TP.Hồ Chí Minh','0983265987',0)


INSERT INTO tblNhanVien
VALUES(1,N'Đặng Văn Sơn',N'Thái Bình','0778988830','250000','0.7','036200077309','12/06/1998','10/10/2016')

INSERT INTO tblNhanVien
VALUES(2,N'Lê Nam',N'Vĩnh Phúc','0978988844','220000','0.9','036200006542','12/12/2001','10/15/2020')

INSERT INTO tblNhanVien
VALUES(3,N'Nguyễn Hoàng Nhân',N'Hà Nội','0978988866','250000','0.4','036200076567','12/09/1999','10/05/2020')

--b
INSERT INTO tblDonDatHang
VALUES('1','1','2',default,'09/29/2023',N'Hà Nội'),
('2','1','1',default,'05/30/2020',N'Bắc Ninh'),
('3','2','3','09/2/2023','10/29/2023',N'Thái Bình')

--c
INSERT INTO tblChiTietDatHang
VALUES(1,'MH01',260000,2,0),
(1,'MH02',500000,1,0),
(2,'MH05',200000,2,0),
(2,'MH06',220000,1,0),
(3,'MH07',140000,2,0),
(3,'MH08',400000,1,0)

--d
update tblChiTietDatHang
set fMucgiamgia =  fMucgiamgia + (fGiaban * 0.1)
from tblDonDatHang , tblChiTietDatHang
where tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD 
and MONTH(tblDonDatHang.dNgaydathang) =9 and YEAR(tblDonDatHang.dNgaydathang) = 2023

--e
delete from tblChiTietDatHang
where iSoHD = 3 

-- bài 2.3---
select * from tblKhachHang
select * from tblDonDatHang
select * from tblChiTietDatHang
SELECT * FROM tblMatHang
--a

insert into tblDonDatHang
values ( 4 , 3, 1, '2023/05/15', '2023/10/19',N'Hà Nội') 
, ( 5 , 2, 1, '2023/05/25', '2023/10/30',N'Hà Nội') 
, ( 6 , 3, 1, '2023/07/15', '2023/10/21',N'Hà Nội') 
, ( 7 , 1, 2, '2023/05/05', '2023/10/19',N'Bắc Ninh') 
, ( 8 , 1, 2, '2023/01/02', '2023/10/20',N'Bắc Ninh') 
, ( 9 , 2, 2, '2023/03/15', '2023/10/16',N'Bắc Ninh') 

insert into tblChiTietDatHang
values ( 4 , 'MH01' , 31000000 , 1 , 0 ),( 4 , 'MH02' , 29590000 , 3 , 0 ),( 4 , 'MH08' , 500000 , 2 , 0 ), --4
( 5 , 'MH06' , 275000 , 12 , 0 ),( 5 , 'MH01' , 31000000 , 2 , 0 ),( 5 , 'MH04' , 300000 , 1 , 0 ),			--5
( 6 , 'MH09' , 1040000 , 1 , 0 ),( 6 , 'MH08' , 500000 , 2 , 0 ),( 6 , 'MH07' , 1720000 , 5 , 0 ),			--6
( 7 , 'MH01' , 31000000 , 3 , 0 ),( 7 , 'MH02' , 29590000 , 4 , 0 ),( 7 , 'MH03' , 3990000 , 2 , 0 ),		--7
( 8 , 'MH04' , 300000 , 4 , 0 ),( 8 , 'MH05' , 200000 , 5 , 0 ),( 8 , 'MH01' , 31000000 , 1 , 0 ),			--8
( 9 , 'MH03' , 3990000 , 2 , 0 ),( 9 , 'MH01' , 31000000 , 1 , 0 ),( 9 , 'MH05' , 300000 , 2 , 0 )			--9

select * from tblLoaiHang
--b
INSERT INTO tblLoaiHang
VALUES('LH04',N'Thời trang')

ALTER TABLE tblLoaiHang
ALTER COLUMN sTenloaihang NVARCHAR(30) NOT NULL

INSERT INTO tblLoaiHang
VALUES('LH05',N'Chăm sóc sức khỏe')
--c
select * from tblMatHang
INSERT INTO tblMatHang
VALUES('MH10',N'Áo dây',1,'LH04',5,440000,'VND')

INSERT INTO tblMatHang
VALUES('MH11',N'Quần lông mềm',1,'LH04',8,130000,'VND')

INSERT INTO tblMatHang
VALUES('MH12',N'Giầy cao gót',1,'LH04',10,280000,'VND')

INSERT INTO tblMatHang
VALUES('MH13',N'Mũ thời trang',1,'LH04',10,260000,'VND')

INSERT INTO tblMatHang
VALUES('MH14',N'Váy',1,'LH04',9,380000,'VND')
--D
select * from tblKhachHang
select * from tblDonDatHang
select * from tblMatHang
select * from tblChiTietDatHang
 
INSERT INTO tblDonDatHang
VALUES(10,2,3,default,'09/30/2023',N'Hà Nội')

INSERT INTO tblChiTietDatHang
VALUES(10,'MH10',440000,3,0),
(10,'MH11',130000,2,0),
(10,'MH12',280000,1,0),
(10,'MH13',260000,4,0)

--E
update tblChiTietDatHang
set fMucgiamgia = fMucgiamgia + fGiaban*0.05 
from tblChiTietDatHang, tblDonDatHang , tblLoaiHang, tblMatHang
where tblChiTietDatHang.iSoHD = tblDonDatHang.iSoHD 
and tblChiTietDatHang.sMahang = tblMatHang.sMahang
and tblLoaiHang.sMaloaihang = tblMatHang.sMaloaihang
and tblLoaiHang.sTenloaihang = N'Thời Trang'
and DATEDIFF(DAY,tblDonDatHang.dNgaydathang,GETDATE()) > 0
--f
DELETE tblLoaiHang
WHERE sTenloaihang = N'Chăm sóc sức khỏe'


---bài 2.4--
select * from tblKhachHang
select * from tblNhanVien
--a
INSERT INTO tblKhachHang
VALUES('4',N'Nguyễn Văn Vũ',N'Hà Nam','0983267820',1),

('5',N'Hoàng Thị Thanh',N'Quảng Ninh','0982268873',0),

('6',N'Nguyễn Thị Tâm',N'Nam Định','0983265987',0)


INSERT INTO tblNhanVien
VALUES(4,N'Nguyễn Đức Trung',N'Phú Thọ','0985423765','150000','0.5','036210076543','12/03/1998','03/05/2020'),

(5,N'Lê Thị Hồng',N'Bình Dương','0978980098','210000','0.9','036200006201','12/12/2000','03/03/2020'),

(6,N'Nguyễn Văn Dũng',N'Hà Nội','0978988869','250000','0.5','036200076500','01/20/1999','12/29/2019')

select * from tblDonNhapHang
--b
INSERT INTO tblDonNhapHang
VALUES(1,2,'11/10/2016'),
(2,3,'12/01/2016'),
(3,1,'12/11/2017')

--c
select * from tblChiTietNhapHang
select * from tblMatHang

INSERT INTO tblChiTietNhapHang
VALUES(1,'MH01',30000000,10),
(1,'MH02',25000000,12),
(2,'MH04',275000,100),
(2,'MH05',150000,20),
(3,'MH06',200000,22),
(3,'MH07',1000000,4)

--d
SELECT * FROM tblChiTietNhapHang

DELETE FROM tblChiTietNhapHang
WHERE tblChiTietNhapHang.iSoHD = 1