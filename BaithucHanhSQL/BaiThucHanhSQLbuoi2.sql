---------BAI 2.1
--a. Viet lenh cho phep them 3 ban ghi vao bang tblLoaihang
INSERT INTO tblLoaiHang
VALUES('001','ao');

INSERT INTO tblLoaiHang
VALUES('002','quan');

INSERT INTO tblLoaiHang
VALUES('003','giay');

select * from tblloaihang
--b. Voi moi loai hang co trong bang tblLoaihang thuc hien them 3 mat hang cho moi loai hang tuong ung
INSERT INTO tblMatHang
VALUES('100','ao dai tay',1,'001',2,200000,'vnd');
INSERT INTO tblMatHang
VALUES('101','ao coc tay',2,'001',4,220000,'vnd');
INSERT INTO tblMatHang
VALUES('102','ao thun',3,'001',5,120000,'vnd');

INSERT INTO tblMatHang
VALUES('103','quan dai',1,'002',2,200000,'vnd');
INSERT INTO tblMatHang
VALUES('104','quan vai',2,'002',4,180000,'vnd');
INSERT INTO tblMatHang
VALUES('105','quan bo',3,'002',3,140000,'vnd');

INSERT INTO tblMatHang
VALUES('106','giay sneaker',1,'003',2,400000,'vnd');
INSERT INTO tblMatHang
VALUES('107','giay the thao',2,'003',4,350000,'vnd');
INSERT INTO tblMatHang
VALUES('108','giay da',3,'003',5,500000,'vnd');

select * from tblMatHang
select * from tblloaihang
select * from tblNhaCungCap
--c. Them 3 ban ghi cho bang Nha cung cap
INSERT INTO tblNhaCungCap
VALUES('Duc Anh','giao dich 1','Hoang Mai','0843927485');
INSERT INTO tblNhaCungCap
VALUES('Van Hiep','giao dich 2','Nam Tu Liem','0843928765');
INSERT INTO tblNhaCungCap
VALUES('Hoang Ha','giao dich 3','Dong Da','0843929873');


select * from tblNhaCungCap

--d. Xoa mat hang co so luong = 0
DELETE FROM tblMatHang WHERE fSoluong = 0;

--e. Tang phu cap 10% cho nhung nhan vien co tham nien lam viec 5 nam tro len
UPDATE tblNhanVien
SET fPhucap = fPhucap * 1.1
WHERE YEAR(GETDATE()) - YEAR(dNgayvaolam) >= 5

--------BAI 2.2
--a. Thuc hien cho phep them 3 ban ghi vao bang tblKhachHang va 3 ban ghi vao bang tblNhanvien
SELECT * FROM tblKhachHang

INSERT INTO tblKhachHang
VALUES('201',N'Nguyễn Công Đức',N'Nam Định','0983267819',1)

INSERT INTO tblKhachHang
VALUES('202',N'Nguyễn Văn Phong',N'Phú Thọ','0982267871',1)

INSERT INTO tblKhachHang
VALUES('203',N'Nguyễn Thị Hoài',N'Hà Nội','0983265421',0)

SELECT * FROM tblNhanVien

INSERT INTO tblNhanVien
VALUES('109',N'Đặng Văn Sơn',N'Thái Bình','0778988830','12/06/1998','10/10/2016','250000','0.7','036200077309')

INSERT INTO tblNhanVien
VALUES('111',N'Lê Nam',N'Vĩnh Phúc','0978988844','12/12/2001','10/15/2020','220000','0.9','036200006542')

INSERT INTO tblNhanVien
VALUES('112',N'Nguyễn Hoàng Nhân',N'Hà Nội','0978988866','12/09/1999','10/05/2020','250000','0.4','036200076567')

select * from tblNhanVien
select * from tblKhachHang

--b. Thuc hien them 3 ban ghi vao bang tblDondathang
SELECT * FROM tblDonDatHang

INSERT INTO tblDonDatHang
VALUES('1','110','201',default,'05/29/2020',N'Hà Nội')

INSERT INTO tblDonDatHang
VALUES('2','111','203',default,'05/30/2020',N'Hà Tĩnh')

INSERT INTO tblDonDatHang
VALUES('3','112','202',default,'05/29/2020',N'Thái Bình')

--c. Thuc hien voi moi don dat hang trong bang tblDondathang cho phep them cac chi tiet don dat hang tuong ung, moi don dat hang
-- co it nhat 2 mat hang duoc them
select * from tblMatHang
select * from tblChiTietDatHang

INSERT INTO tblChiTietDatHang
VALUES(1,107,350000,2,50000)
INSERT INTO tblChiTietDatHang
VALUES(1,108,500000,1,50000)

INSERT INTO tblChiTietDatHang
VALUES(2,100,200000,2,30000)
INSERT INTO tblChiTietDatHang
VALUES(2,101,220000,1,0)

INSERT INTO tblChiTietDatHang
VALUES(3,105,140000,2,20000)
INSERT INTO tblChiTietDatHang
VALUES(3,106,400000,1,40000)

--d. Thuc hien dat cho phep muc giam gia la 10% cho cac mat hang ban trong thang 7 nam 2016
update tblChiTietDatHang
set fMucgiamgia = 0.1
from tblChiTietDatHang, tblDonDatHang
where month(dNgaydathang)= 7 and year(dNgaydathang)= 2016 and tblChiTietDatHang.iSoHD = tblDonDatHang.iSoHD

INSERT INTO tblDonDatHang
VALUES(4,110,201,'06/12/2020','05/20/2020',N'Hà Nội')

select * from tblDonDatHang
--e. Thuc hien xoa cac chi tiet don dat hang cua hoa don co ma don dat hang do sinh vien tu xac dinh
delete tblChiTietDatHang
where iSoHD = 1 

-----BAI 2.3
--a. 
--1.Nam     0.Nữ
select * from tblLoaiHang
select * from tblkhachhang
select * from tblDonDatHang

INSERT INTO tblDonDatHang
VALUES(4,110,201,'05/12/2020','05/20/2020',N'Hà Nội')

INSERT INTO tblDonDatHang
VALUES(5,111,201,'04/06/2020','04/29/2020',N'Hà Nội')

INSERT INTO tblDonDatHang
VALUES(6,111,201,'02/02/2020','02/10/2020',N'Hà Nội')

INSERT INTO tblDonDatHang
VALUES(7,110,202,'05/12/2020','05/20/2020',N'Thái Bình')

INSERT INTO tblDonDatHang
VALUES(8,110,202,'04/06/2020','04/27/2020',N'Thái Bình')

INSERT INTO tblDonDatHang
VALUES(9,112,202,'02/02/2020','02/12/2020',N'Thái Bình')

INSERT INTO tblChiTietDatHang
VALUES(4,100,200000,1,15000)

INSERT INTO tblChiTietDatHang
VALUES(4,106,400000,2,50000)

INSERT INTO tblChiTietDatHang
VALUES(4,105,140000,4,30000)

INSERT INTO tblChiTietDatHang
VALUES(5,102,120000,1,10000)

INSERT INTO tblChiTietDatHang
VALUES(5,103,200000,2,30000)

INSERT INTO tblChiTietDatHang
VALUES(5,108,500000,4,100000)

INSERT INTO tblChiTietDatHang
VALUES(6,102,120000,1,10000)

INSERT INTO tblChiTietDatHang
VALUES(6,103,200000,2,30000)

INSERT INTO tblChiTietDatHang
VALUES(6,108,500000,4,100000)

INSERT INTO tblChiTietDatHang
VALUES(7,102,120000,1,10000)

INSERT INTO tblChiTietDatHang
VALUES(7,103,200000,2,30000)

INSERT INTO tblChiTietDatHang
VALUES(7,106,400000,3,100000)

INSERT INTO tblChiTietDatHang
VALUES(8,106,400000,3,100000)

INSERT INTO tblChiTietDatHang
VALUES(8,103,200000,2,30000)

INSERT INTO tblChiTietDatHang
VALUES(8,102,120000,1,10000)

INSERT INTO tblChiTietDatHang
VALUES(9,106,400000,3,100000)

INSERT INTO tblChiTietDatHang
VALUES(9,103,200000,4,30000)

INSERT INTO tblChiTietDatHang
VALUES(9,102,120000,1,10000)

select * from tblMatHang
select * from tblChiTietDatHang

--b
select * from tblLoaiHang
INSERT INTO tblLoaiHang
VALUES('004',N'Thời trang')

ALTER TABLE tblLoaiHang
ALTER COLUMN sTenloaihang NVARCHAR(30) NOT NULL

INSERT INTO tblLoaiHang
VALUES('005',N'Chăm sóc sức khỏe')
--c
select * from tblMatHang
INSERT INTO tblMatHang
VALUES(109,N'áo dây',1,'004',5,440000,'vnd')

INSERT INTO tblMatHang
VALUES(110,N'quần lông mềm',1,'004',8,130000,'vnd')

INSERT INTO tblMatHang
VALUES(111,N'giầy cao gót',1,'004',10,280000,'vnd')

INSERT INTO tblMatHang
VALUES(112,N'mũ thời trang',1,'004',10,260000,'vnd')

INSERT INTO tblMatHang
VALUES(113,N'váy',1,'004',9,380000,'vnd')

--d
select * from tblKhachHang
select * from tblDonDatHang
select * from tblMatHang
select * from tblChiTietDatHang
 
INSERT INTO tblDonDatHang
VALUES(10,110,203,default,'05/30/2020',N'Hà Nội')

INSERT INTO tblChiTietDatHang
VALUES(10,109,440000,3,50000)

INSERT INTO tblChiTietDatHang
VALUES(10,110,130000,2,10000)

INSERT INTO tblChiTietDatHang
VALUES(10,111,280000,1,20000)

INSERT INTO tblChiTietDatHang
VALUES(10,112,260000,4,50000)

--e
UPDATE tblChiTietDatHang
SET fGiaban = fGiaban * 0.95
FROM tblMatHang, tblLoaiHang, tblDonDatHang
WHERE tblLoaiHang.sTenloaihang = N'Thời trang' AND tblLoaiHang.sMaloaihang = tblMatHang.sMaloaihang 
AND tblChiTietDatHang.sMahang = tblMatHang.sMahang
AND DATEDIFF(DAY,dNgaygiaohang,GETDATE()) > 0

select * from tblChiTietDatHang
--f
DELETE tblLoaiHang
WHERE sTenloaihang = N'Chăm sóc sức khỏe'

select * from tblLoaiHang
select * from tblChiTietDatHang
select * from tblDonDatHang
select * from tblMatHang

-----BAI 2.4
--a

INSERT INTO tblKhachHang
VALUES('204',N'Nguyễn Văn Vũ',N'Hà Tĩnh','0983267820',1)

INSERT INTO tblKhachHang
VALUES('205',N'Hoàng Thị Thanh',N'Hà Nam','0982268873',0)

INSERT INTO tblKhachHang
VALUES('206',N'Nguyễn Thị Hải',N'Nam Định','0983265987',0)

SELECT * FROM tblNhanVien

INSERT INTO tblNhanVien
VALUES('113',N'Nguyễn Đức Trung',N'Phú Thọ','0985423765','12/03/1998','03/05/2020','150000','0.5','036210076543')

INSERT INTO tblNhanVien
VALUES('114',N'Lê Nam Hà',N'Vĩnh Phúc','0978980098','12/12/2000','03/03/2020','130000','0.9','036200006201')

INSERT INTO tblNhanVien
VALUES('115',N'Lê Văn Dũng',N'Hà Nội','0978988869','01/20/1999','12/29/2019','250000','0.5','036200076500')

select * from tblKhachHang
select * from tblNhanVien

--b
select * from tblDonNhapHang

INSERT INTO tblDonNhapHang
VALUES(001,108,'11/10/2016')

INSERT INTO tblDonNhapHang
VALUES(003,109,'12/01/2016')

INSERT INTO tblDonNhapHang
VALUES(002,110,'12/11/2017')

--c
select * from tblChiTietNhapHang

INSERT INTO tblChiTietNhapHang
VALUES(1,103,100000,2)

INSERT INTO tblChiTietNhapHang
VALUES(1,104,100000,4)

INSERT INTO tblChiTietNhapHang
VALUES(2,102,100000,2)

INSERT INTO tblChiTietNhapHang
VALUES(2,104,100000,2)

INSERT INTO tblChiTietNhapHang
VALUES(3,106,200000,2)

INSERT INTO tblChiTietNhapHang
VALUES(3,107,220000,4)

--d
SELECT * FROM tblChiTietNhapHang
SELECT * FROM tblDonDatHang

DELETE tblChiTietNhapHang
FROM tblDonDatHang, tblChiTietDatHang
WHERE tblChiTietDatHang.iSoHD = 3 AND DATEDIFF(DAY,dNgaydathang,dNgaygiaohang) > 0



