CREATE DATABASE TRAM2;
USE TRAM2;

CREATE TABLE tblKhachHang1(
	iMaKH int NOT NULL,
	sTenKH nvarchar(30)NULL,
	sDiachi nvarchar(50)NULL CHECK (sDiachi = N'Sài Gòn'),
	sDienthoai nvarchar(12)NULL,
	dNgaysinh date
);
INSERT INTO tblKhachHang1 VALUES
(1,N'Trần Văn A',N'Sài Gòn',N'0963723421','2/12/2000'),
(2,N'Nguyễn Văn B',N'Sài Gòn',N'092688881','12/11/2001'),
(3,N'Nguyễn Thị N',N'Sài Gòn',N'096666347','11/2/1999');

select *from TRAM1.TRAM2.dbo.tblKhachhang1
union
select *from [DESKTOP-RS315K6\SQLEXPRESS].TRAM1.dbo.tblKhachhang1

--b

CREATE TABLE tblDonDatHang1(
	iSoHD INT NOT NULL,
	dNgaygiaohang DATE NULL,
	sDiachigiaohang NVARCHAR(50)
);

SELECT * FROM tblDonDatHang1;

INSERT INTO tblDonDatHang1  VALUES
(1,'2016-10-12',N'Hà Nội'),
(2,'2017-09-26',N'Quảng Ninh'),
(3,'2017-11-22',N'Hưng Yên');


SELECT *,YEAR(GETDATE())-YEAR(dNgaysinh) AS Tuoi FROM  TRAM1.TRAM2.DBO.tblKhachHang1
WHERE YEAR(GETDATE())-YEAR(dNgaysinh) BETWEEN 18 AND 25 AND (sDiachi=N'Sài Gòn' OR sDiachi=N'Ha Noi')
UNION
SELECT *,YEAR(GETDATE())-YEAR(dNgaysinh) FROM tblKhachHang1
WHERE YEAR(GETDATE())-YEAR(dNgaysinh) BETWEEN 18 AND 25 AND (sDiachi=N'Sài Gòn' OR sDiachi=N'Ha Noi')

--c
CREATE SYNONYM khachhang
FOR TRAM1.TRAM2.DBO.tblKhachHang1;

alter proc Themkhachhang
	@iMaKH INT,
	@sTenKH NVARCHAR(30),
	@sDiachi NVARCHAR(50),
	@sDienthoai NVARCHAR(12),
	@dNgaysinh DATE
AS
	begin 
		IF NOT EXISTS (SELECT * FROM tblKhachHang1,khachhang WHERE @iMaKH = tblKhachHang1.iMaKH AND @iMaKH=khachhang.iMaKH)
			BEGIN
				IF(@sDiachi = N'Sài Gòn')
					INSERT INTO tblKhachHang1 VALUES (@iMaKH,@sTenKH,@sDiachi,@sDienthoai,@dNgaysinh)
				ELSE
					INSERT INTO khachhang VALUES (@iMaKH,@sTenKH,@sDiachi,@sDienthoai,@dNgaysinh)
			END
	END
GO
	EXECUTE ThemkhachHang 5,N'Nguyễn Long Nhật',N'Sài Gòn',N'123456789','1999-05-04';
	EXECUTE ThemkhachHang 6,N'Nguyễn Long Nhật',N'Ha Noi',N'987654321','1999-04-06';
	EXECUTE ThemkhachHang 7,N'Nguyễn Long Nhật',N'Da Nang',N'123459876','1998-05-04';
 select *from tblkhachhang1
 union
 select *from khachhang
 --6.3
 CREATE TABLE tblThongtinGiaohang(
	iSoHD INT NOT NULL,
	dNgaygiaohang DATE NULL,
	sDiachigiaohang NVARCHAR(50) NULL,
	CONSTRAINT PK_tblDonDatHang PRIMARY KEY (iSoHD)
);
INSERT INTO tblThongtinGiaohang VALUES 
(1,'2017-07-08',N'Ha Noi');

CREATE SYNONYM DonDatHang
FOR TRAM1.TRAM2.DBO.tblDonDatHang;

SELECT tblThongtinGiaohang.*, DonDatHang.iMaNV, DonDatHang.iMaKH, DonDatHang.dNgayDatHang 
FROM tblThongtinGiaohang, DonDatHang
WHERE tblThongtinGiaohang.iSoHD = DonDatHang.iSoHD