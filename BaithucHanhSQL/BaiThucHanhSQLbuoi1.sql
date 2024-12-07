CREATE DATABASE ThuchanhSQL_NguyenCongDuc_1810A01

USE ThuchanhSQL_NguyenCongDuc_1810A01

---------------BAI 1.1

--a. Tao database da cho va luu vao thu muc ThuchanhSQL_ten sinh vien_ Lop

CREATE TABLE tblLoaiHang
(
sMaloaihang NVARCHAR(10) NOT NULL,
sTenloaihang NVARCHAR(10) NOT NULL
);
ALTER TABLE tblLoaiHang ADD CONSTRAINT PK_sMaloaihang PRIMARY KEY(sMaloaihang);

CREATE TABLE tblNhaCungCap
(
iMaNCC int IDENTITY(1,1) NOT NULL,
sTenNhaCC NVARCHAR(50) NULL,
sTengiaodich NVARCHAR(50) NULL,
sDiachi NVARCHAR(50) NULL,
sDienthoai NVARCHAR(12) NULL,
CONSTRAINT PK_tblNhaCungCap PRIMARY KEY(iMaNCC)
);

CREATE TABLE tblMatHang
(
sMahang NVARCHAR(10) NOT NULL,
sTenhang NVARCHAR(30) NOT NULL,
iMaNCC INT NULL,
sMaloaihang NVARCHAR(10) NULL,
fSoluong FLOAT NULL,
fGiahang FLOAT NULL
);

ALTER TABLE tblMatHang
ADD CONSTRAINT PK_mathang PRIMARY KEY(sMahang),
CONSTRAINT FK_mathang_loaihang FOREIGN KEY(sMaloaihang) REFERENCES tblLoaiHang(sMaloaihang),
CONSTRAINT FK_mathang_nhacungcap FOREIGN KEY(iMaNCC) REFERENCES tblNhaCungCap(iMaNCC);

--b. Tao bang tblKhachHang va bang tblNhanVien theo cau truc da cho

CREATE TABLE tblKhachHang
(
iMaKH int NOT NULL,
sTenKH NVARCHAR(30) NOT NULL,
sDiachi NVARCHAR(50),
sDienthoai NVARCHAR(12),
CONSTRAINT PK_khachhang PRIMARY KEY(iMaKH)
)

CREATE TABLE tblNhanVien
(
iMaNV INT NOT NULL,
sTenNV NVARCHAR(30) NOT NULL,
sDiachi NVARCHAR(50),
sDienthoai NVARCHAR(12),
dNgaysinh DATETIME,
dNgayvaolam DATETIME,
fLuongcoban FLOAT,
fPhucap FLOAT,
CONSTRAINT PK_nhanvien PRIMARY KEY(iMaNV) 
)

--c. Them truong sCMND khong chua gia tri trung nhau vao bang tblNhanVien
ALTER TABLE tblNhanVien
ADD sCMND NVARCHAR(12) UNIQUE;

--d. Thiet lap rang buoc khoa chinh, khoa ngoai cho ca 2 bang tren
--e. Thiet lap rang buoc ngay vao lam viec so voi ngay sinh toi thieu du 18 tuoi
ALTER TABLE tblNhanVien
ADD CONSTRAINT CK_nhanvien CHECK(YEAR(dNgayvaolam)-YEAR(dNgaysinh) >= 18);

--f. Them cot sDonvitinh cho bang Mat hang
ALTER TABLE tblMatHang
ADD sDonvitinh NVARCHAR(10);

--g. Tao chi muc cho cot sTenhang trong bang tblMathang
CREATE INDEX ID_tenhang ON tblMatHang(sTenhang);


-----------------------BAI 1.2
--a. Tao bang tblDonNhapHang va bang tblChiTietNhapHang theo cau truc da cho
CREATE TABLE tblDonNhapHang
(
iSoHD INT NOT NULL,
iMaNV INT NOT NULL,
dNgaynhaphang DATETIME
)

CREATE TABLE tblChiTietNhapHang
(
iSoHD INT NOT NULL,
sMahang NVARCHAR(10) NOT NULL,
fGianhap FLOAT,
fSoluongnhap FLOAT
)

--b. Thiet lap rang buoc khoa chinh, khoa ngoai cho bang tblDonNhapHang va bang tblChiTietNhapHang vua tao
ALTER TABLE tblDonNhapHang
ADD CONSTRAINT PK_donnhaphang PRIMARY KEY(iSoHD),
CONSTRAINT FK_donnhaphang_nhanvien FOREIGN KEY(iMaNV) REFERENCES tblNhanVien(iMaNV);

ALTER TABLE tblChiTietNhapHang
ADD CONSTRAINT PK_chitietnhaphang PRIMARY KEY(iSoHD, sMahang),
CONSTRAINT FK_chitietnhaphang_mathang FOREIGN KEY(sMahang) REFERENCES tblMatHang(sMahang),
CONSTRAINT FK_chitietnhaphang_donnhaphang FOREIGN KEY(iSoHD) REFERENCES tblDonNhapHang(iSoHD);

--c. Trong bang tblChitietnhaphang dam bao rang buoc co ban.
ALTER TABLE tblChiTietNhapHang
ADD CONSTRAINT CK_gianhap CHECK(fGianhap > 0),
CONSTRAINT CK_soluongnhap CHECK(fSoluongnhap > 0);

----------------------BAI 1.3
--a. Them truong bGioitinh(bit) vao bang tblKhachHang

ALTER TABLE tblKhachHang
ADD bGioitinh bit

--b. Tao bang tblDondathang theo cau truc va dam bao: dNgaydathang mac dinh bang thoi gian hien tai va luon nho hon hoac
--bang thoi gian hien tai	

CREATE TABLE tblDonDatHang
(
iSoHD INT not null,
iMaNV INT not null,
iMaKH INT not null,
dNgaydathang DATETIME,
dNgaygiaohang DATETIME,
sDiachigiaohang NVARCHAR(50),
CONSTRAINT PK_dondathang PRIMARY KEY(iSoHD)
)
ALTER TABLE tblDonDatHang
ADD CONSTRAINT CK_default DEFAULT GETDATE() FOR dNgaydathang,
CONSTRAINT CK_dathang_giaohang CHECK(dNgaygiaohang >= dNgaydathang),
CONSTRAINT CK_ngaydathang CHECK (dNgaydathang <= GETDATE())

SELECT * FROM tblDonDatHang
SELECT * FROM tblNhanVien
SELECT * FROM tblKhachHang

--c. Trong bang tblDonDatHang, dat truong iMaKh lam khoa ngoai, tham chieu sang tblKhachhang.iMakh
ALTER TABLE tblDonDatHang
ADD CONSTRAINT FK_dondathang_khachhang FOREIGN KEY(iMaKH) REFERENCES tblKhachHang(iMaKH)

--d. Trong bang tblDondathang, dat truong iManv lam khoa ngoai, tham chieu sang tblNhanVien.iMaNV

ALTER TABLE tblDonDatHang
ADD CONSTRAINT FK_dondathang_nhanvien FOREIGN KEY(iMaNV) REFERENCES tblNhanVien(iMaNV)


----------------------BAI 1.4
--a. Tao bang tblChiTietDatHang theo cau truc

CREATE TABLE tblChiTietDatHang
(
iSoHD INT NOT NULL,
sMahang NVARCHAR(20) NOT NULL,
fGiaban FLOAT,
fSoluongmua FLOAT,
fMucgiamgia FLOAT
)

--b. Trong bang tblChiTietDatHang, sua cau truc truong sMaHang sang kieu Ki tu co do dai 10

ALTER TABLE tblChiTietDatHang
ALTER COLUMN sMaHang NVARCHAR(10) NOT NULL;

--c. Trong bang tblChiTietDatHang, dat truong sMaHang lam khoa ngoai, tham chieu sang tblMatHang.sMaHang; dat truong 
--iSoHD lam khoa ngoai, tham chieu sang tblDonDatHang.iSoHD 

ALTER TABLE tblChiTietDatHang
ADD CONSTRAINT FK_chitietdathang_mathang FOREIGN KEY(sMahang) REFERENCES tblMatHang(sMahang),
CONSTRAINT FK_chitietdathang_dondathang FOREIGN KEY(iSoHD) REFERENCES tblDonDatHang(iSoHD);

--d. Trong bang tblChiTietDatHang, dat khoa chinh tren cap truong {iSoHD, sMaHang }

ALTER TABLE tblChiTietDatHang
ADD CONSTRAINT PK_chitietdathang PRIMARY KEY(iSoHD, sMaHang);

--e. Trong bang tblChiTietDatHang, dam bao: fGiaban > 0, fSoluongmua >0, fMucgiamgia >=0;

ALTER TABLE tblChiTietDatHang 
ADD CONSTRAINT CK_giaban CHECK(fGiaban > 0),
CONSTRAINT CK_fSoluongmua CHECK(fSoluongmua > 0),
CONSTRAINT CK_fMucgiamgia CHECK(fMucgiamgia >= 0)

SELECT * FROM tblChiTietDatHang

INSERT INTO tblChiTietDatHang
VALUES('1','101','10000','2','2000')