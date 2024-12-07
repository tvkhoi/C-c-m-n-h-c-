
-------------Bai 4.1
----a
CREATE PROC sp_không_bán_được
@mahang_nam nvarchar(5)
AS
SELECT sMahang,sTenHang FROM tblMatHang
WHERE sMahang NOT IN(SELECT tblChiTietDatHang.sMahang 
FROM  tblChiTietDatHang INNER JOIN tblDonDatHang
ON tblChiTietDatHang.iSoHD = tblDonDatHang.iSoHD
WHERE YEAR(tblDonDatHang.dNgaydathang) = @mahang_nam)

EXECUTE sp_không_bán_được '2020'

----b
ALTER PROC TangLuong
@Soluong int,
@nam nvarchar(5)
AS
UPDATE tblNhanVien
SET fLuongcoban = fLuongcoban * 1.5
FROM tblNhanVien
WHERE iMaNV IN
(
	SELECT tblNhanVien.iMaNV
	FROM tblNhanVien, tblChiTietDatHang, tblDonDatHang
	WHERE tblNhanVien.iMaNV = tblDonDatHang.iMaNV
	AND tblChiTietDatHang.iSoHD = tblDonDatHang.iSoHD
	AND YEAR(dNgaydathang) = @nam
	GROUP BY tblNhanVien.iMaNV
	HAVING SUM(fSoluongmua) > @Soluong
)

EXEC TangLuong '0','2016'

-------------c
CREATE PROC tong_bansp
@Mahang nvarchar(10)
AS
SELECT @Mahang as N'Mã sản phẩm',SUM(tblChiTietDatHang.fSoluongmua) AS N'Tổng sản phẩm đã bán'
FROM tblMatHang INNER JOIN tblChiTietDatHang
ON tblMatHang.sMahang=tblChiTietDatHang.sMahang
WHERE @Mahang = tblChiTietDatHang.sMahang

EXEC tong_bansp 100

 -----------d
 CREATE PROC tổng_tiền_trong_năm
 @year nvarchar(5)
 AS
 SELECT @year AS N'Năm', SUM(fGiaban*fSoluongmua-fMucgiamgia) AS N'Doanh thu trong năm'
 FROM tblChiTietDatHang INNER JOIN tblDonDatHang
 ON tblChiTietDatHang.iSoHD=tblDonDatHang.iSoHD
 WHERE @year= YEAR(tblDonDatHang.dNgaydathang)

 EXEC tổng_tiền_trong_năm 2016

------------e
 CREATE TRIGGER test1 ON tblChiTietDatHang
 FOR INSERT, UPDATE
 AS
 BEGIN
	DECLARE @fGiaban FLOAT, @fGiagoc FLOAT, @sMahang nvarchar(10)
	SELECT @sMahang = sMahang, @fGiaban = fGiaban from INSERTED
	SELECT @fGiagoc=fGiahang FROM tblMathang WHERE sMahang=@sMahang
	IF(@fGiaban >= @fGiagoc)
		PRINT N'Cap nhat thanh cong'
	ELSE 
			PRINT N'Gia ban phai lon hon gia goc'
			ROLLBACK TRAN
   END

INSERT INTO tblChiTietDatHang
VALUES(3,'2',4000,1,89)

------------f
CREATE TRIGGER Luonghangbanra_nhohonluonghanghienco
ON tblChiTietDatHang
FOR INSERT,UPDATE
AS
	Declare @fSoluongban float, @fSoluongco float, @sMahang nvarchar(10)
	Select @sMahang = sMahang, @fSoluongban = fSoluongmua FROM INSERTED
	Select @fSoluongco = fSoluong FROM tblMathang WHERE @sMahang = sMahang
	IF(@fSoluongban <= @fSoluongco)
		PRINT N'Cap nhat thanh cong'
	ELSE
			PRINT N'So luong hang ban ra phai nho hon so hang hien co'
			ROLLBACK TRAN


INSERT INTO tblChiTietDatHang(iSoHD,sMahang,fGiaban,fSoluongmua,fMucgiamgia)
VALUES(17,'5',3,7,8)

-------------Bai 4.2
----------a.
CREATE PROC ThemDLDondathang(
@iSoHD int,
@iMaNV int, 
@iMaKH int, 
@dNgaydathang datetime, 
@dNgaygiaohang datetime,
@sDiachigiaohang nvarchar(50))
AS
BEGIN
	IF EXISTS (Select * from tblDondathang Where @iSoHD = iSoHD)
		PRINT N'Mã hóa đơn đã tồn tại'
	ELSE
		IF NOT EXISTS (Select * from tblDondathang Where @iMaNV = iMaNV)
			PRINT N'Mã nhân viên không tồn tại'
		ELSE
			IF NOT EXISTS (Select * from tblDondathang Where @iMaKH = iMaKH)
				PRINT N'Mã khách hàng không tồn tại'
			ELSE
				IF NOT EXISTS (Select * from tblDondathang Where @dNgaydathang <= getdate() and @dNgaygiaohang >= @dNgaydathang)
					 PRINT N'Ngày đặt hàng phải nhỏ hơn hoặc bằng ngày hiền tại và ngày giao hàng phải lớn hơn hoặc bằng ngày đặt hàng'
				ELSE
						INSERT INTO tblDondathang(iSoHD,iMaNV,iMaKH,dNgaydathang,dNgaygiaohang,sDiachigiaohang)
						VALUES(@iSoHD,@iMaNV,@iMaKH,@dNgaydathang,@dNgaygiaohang,@sDiachigiaohang)
				
END   

EXEC ThemDLDondathang '19','110','1','2019/10/10','2019/10/16',N' Hà Nội'
SELECT *FROM dbo.tblNhanVien
SELECT *FROM dbo.tblDonDathang
SELECT *FROM dbo.tblKhachHang
-----------b.
 ALTER TABLE tblKhachHang
 ADD fTongTienHang FLOAT 

 UPDATE tblKhachHang
 SET fTongTienHang = 0

CREATE TRIGGER Tudongtang_Tongtienhang
ON tblChiTietDatHang
AFTER INSERT
AS
BEGIN
	Declare @MaKH int, @TongTien float
	Select @MaKH = (SELECT tblDondathang.iMaKH
					FROM tblDondathang INNER JOIN INSERTED ON tblDondathang.iSoHD = INSERTED.iSoHD)
	Select @TongTien = (SELECT sum(fGiaban*fSoluongmua-fMucgiamgia) AS[Tong tien]
						FROM INSERTED INNER JOIN tblDondathang ON INSERTED.iSoHD = tblDondathang.iSoHD)
	IF EXISTS (SELECT sTenKH FROM tblKhachHang WHERE @MaKH = iMaKH)	
			UPDATE tblKhachHang
			SET fTongTienHang = fTongTienHang + @TongTien
			WHERE @MaKH = iMaKH
	ELSE
			PRINT N'Khach hang chua dat hang'
			ROLLBACK TRAN
END

INSERT INTO tblChiTietDatHang(iSoHD,sMahang,fGiaban,fSoluongmua,fMucgiamgia)
VALUES('3','4','30','2','2')

DELETE FROM tblChiTietDatHang WHERE iSoHD = 3 and sMahang = 4

------------c.
CREATE PROC DSMatHang( @sTenNhaCC nvarchar(50), @dNam datetime)
AS 
BEGIN
 SELECT sTenhang
 FROM dbo.tblMatHang, dbo.tblNhaCungCap, dbo.tblDonNhapHang, dbo.tblChiTietNhapHang
 WHERE dbo.tblMatHang.iMaNCC= dbo.tblNhaCungCap.iMaNCC
 AND  dbo.tblMatHang.sMahang= dbo.tblChiTietNhapHang.sMahang
 AND dbo.tblChiTietNhapHang.iSoHD=dbo.tblDonNhapHang.iSoHD
 AND @sTenNhaCC = dbo.tblNhaCungCap.sTenNhaCC
 AND YEAR(@dNam)= YEAR(dNgaynhaphang)
END

--Kiểm tra
 
 EXEC DSMatHang 'Dell','2016'

 SELECT *FROM dbo.tblNhaCungCap
 SELECT *FROM dbo.tblMatHang
 SELECT *FROM dbo.tblDonNhapHang
 SELECT *FROM dbo.tblChiTietNhapHang

-------------d.

CREATE PROC TenNhaCC_NgayNhapHang( @sTenhang nvarchar(30))
AS 
BEGIN
 SELECT sTenNhaCC, dNgaynhaphang
 FROM dbo.tblMatHang, dbo.tblNhaCungCap, dbo.tblDonNhapHang, dbo.tblChiTietNhapHang
 WHERE dbo.tblMatHang.iMaNCC= dbo.tblNhaCungCap.iMaNCC
 AND  dbo.tblMatHang.sMahang= dbo.tblChiTietNhapHang.sMahang
 AND dbo.tblChiTietNhapHang.iSoHD=dbo.tblDonNhapHang.iSoHD
 AND @sTenhang= dbo.tblMatHang.sTenhang
END

-- kiểm tra
EXEC TenNhaCC_NgayNhapHang N'quan vai'

------------e.
--Thêm cột TongSoMatHang vào bảng
ALTER TABLE dbo.tblDonDathang
ADD fTongSoMatHang FLOAT 

UPDATE dbo.tblDonDathang
SET fTongSoMatHang =0


CREATE TRIGGER DonDatHang
ON dbo.tblChiTietDatHang
FOR INSERT 
AS 
BEGIN 
  DECLARE @fTongSoMatHang FLOAT ,@iSoHD INT
  SELECT @iSoHD= iSoHD FROM inserted
  SELECT @fTongSoMatHang=(SELECT fSoluongmua FROM inserted)

  UPDATE dbo.tblDonDathang
  SET fTongSoMatHang = fTongSoMatHang + @fTongSoMatHang
  WHERE @iSoHD=iSoHD
END


--Kiểm tra
INSERT INTO dbo.tblChiTietDatHang
        ( iSoHD ,
          sMahang ,
          fGiaban ,
          fSoluongmua ,
          fMucgiamgia
        )
VALUES  ( 8 , -- iSoHD - int
          N'12' , -- sMahang - nvarchar(10)
          2500 , -- fGiaban - float
          2 , -- fSoluongmua - float
          5  -- fMucgiamgia - float
        )
--
INSERT INTO dbo.tblChiTietDatHang
        ( iSoHD ,
          sMahang ,
          fGiaban ,
          fSoluongmua ,
          fMucgiamgia
        )
VALUES  ( 7 , -- iSoHD - int
          N'5' , -- sMahang - nvarchar(10)
          20, -- fGiaban - float
          3 , -- fSoluongmua - float
          0  -- fMucgiamgia - float
        )
 
SELECT *FROM dbo.tblDonDathang
SELECT *FROM dbo.tblChiTietDatHang
SELECT *FROM dbo.tblMatHang

---Bai 4.3
----------a.
CREATE PROC prtblMatHang(@sMahang nvarchar(10),@sTenhang nvarchar(30), @iMaNCC INT, @sMaloaihang nvarchar(10),
 @fSoluong float, @fGiahang float, @sDonvitinh nvarchar(10))
AS
BEGIN
  IF EXISTS( SELECT *FROM dbo.tblMatHang WHERE @sMahang=sMahang)
    PRINT N'Mã hàng đã tồn tại'
  ELSE
  IF EXISTS(SELECT *FROM dbo.tblMatHang WHERE @sTenhang=sTenhang)
     PRINT N'Tên hàng đã tồn tại'
  ELSE 
  IF NOT EXISTS(SELECT *FROM dbo.tblMatHang WHERE @iMaNCC=iMaNCC)
     PRINT N'Mã nhà cung cấp không tồn tại'
   ELSE 
   IF NOT EXISTS(SELECT *FROM dbo.tblMatHang WHERE @sMaloaihang=sMaloaihang)
     PRINT N'Mã loại hàng không tồn tại'
   ELSE 
      INSERT INTO dbo.tblMatHang(sMahang ,sTenhang ,iMaNCC ,sMaloaihang ,fSoluong ,fGiahang ,sDonvitinh)
      VALUES  (@sMahang,@sTenhang,@iMaNCC,@sMaloaihang,@fSoluong,@fGiahang,@sDonvitinh)
 END

-- Kiểm tra

INSERT INTO dbo.tblMatHang
        ( sMahang ,
          sTenhang ,
          iMaNCC ,
          sMaloaihang ,
          fSoluong ,
          fGiahang ,
          sDonvitinh
        )
VALUES  ( N'1' , -- sMahang - nvarchar(10)
          N'cam' , -- sTenhang - nvarchar(30)
          3 , -- iMaNCC - int
          N'ma4' , -- sMaloaihang - nvarchar(10)
          2, -- fSoluong - float
          1000, -- fGiahang - float
          N'qua'  -- sDonvitinh - nvarchar(10)
        )

SELECT *FROM dbo.tblMatHang

-----------b.
CREATE PROC Giamgia(@iGiatri int ,@fMucgiamgia float)
AS 
BEGIN
 UPDATE dbo.tblChiTietDatHang
 SET fMucgiamgia=@fMucgiamgia
 FROM dbo.tblChiTietDatHang, dbo.tblDonDathang
 WHERE (fGiaban*fSoluongmua)>=@iGiatri
 AND fMucgiamgia=0
 AND month(dNgaydathang)=month(GETDATE())
 AND dbo.tblChiTietDatHang.iSoHD= dbo.tblDonDathang.iSoHD
END  

--Kiểm tra
EXEC Giamgia '2000','300'
--
SELECT *FROM dbo.tblChiTietDatHang
SELECT *FROM dbo.tblDonDathang
SELECT *FROM dbo.tblMatHang

---------------c.

CREATE PROC Xauhang(@chuoi nvarchar(256),@sMahang nvarchar(10)=null, @iSoHD int , @fGiaban float =null, @fSoluongmua int = null,
@fMucgiamgia float=0,@iMaNV int, @iMaKH int, @dNgaygiaohang nvarchar(20), @dNgaydathang nvarchar(20), @sDiachigiaohang nvarchar(20))
AS
BEGIN
	WHILE LEN(@chuoi) <> 0
	BEGIN
		SET @sMahang = SUBSTRING(@chuoi , 1 , CHARINDEX(',', @chuoi)-1)
		SET @chuoi = SUBSTRING(@chuoi ,CHARINDEX(',', @chuoi)+1, LEN(@chuoi))
		IF CHARINDEX(',', @chuoi) = 0
			BEGIN
				SET @fSoluongmua = SUBSTRING(@chuoi , 1 , LEN(@chuoi))
				SET @chuoi = ''
				SET @fGiaban = (SELECT fGiahang FROM tblMathang WHERE sMahang = @sMahang)
			END
		ELSE
				SET @fSoluongmua = SUBSTRING(@chuoi , 1 , CHARINDEX(',', @chuoi)-1)
				SET @chuoi = SUBSTRING(@chuoi ,CHARINDEX(',', @chuoi)+1, LEN(@chuoi))
				SET @fGiaban = (SELECT fGiahang FROM tblMathang WHERE sMahang = @sMahang)

				INSERT INTO tblDondathang(iSoHD,iMaNV,iMaKH,dNgaydathang,dNgaygiaohang,sDiachigiaohang)
				VALUES(@iSoHD,@iMaNV,@iMaKH,@dNgaydathang,@dNgaygiaohang,@sDiachigiaohang)
				INSERT INTO tblChiTietDatHang(iSoHD,sMahang,fGiaban,fSoluongmua,fMucgiamgia)
				VALUES(@iSoHD,@sMahang,@fGiaban,@fSoluongmua,@fMucgiamgia)
				SET @iSoHD = @iSoHD +1
	END
END
	
EXEC Xauhang @chuoi = '1,3,100,21,12,4', @iSoHD =20,@iMaNV=1, @iMaKH =2, @dNgaydathang =N'2017-10-11',
@dNgaygiaohang =N'2017-10-13', @sDiachigiaohang= N'Hà Nội'

------------d.
CREATE TRIGGER tg_DropNhanVien
ON tblNhanVien
AFTER INSERT
AS
BEGIN
	DECLARE @MaNVXoa int, @MaNVNhap int, @MaNVXuat int, @SoHDNVXNhap int, @SoHDNVXXuat int, @SoHDNVKNhap int, @SoHDNVKXuat int
	SELECT @MaNVXoa = (SELECT iMaNV FROM INSERTED)
	
	SELECT @SoHDNVXNhap = (SELECT count(iSoHD) FROM tblDondathang WHERE tblDondathang.iMaNV = @MaNVXoa)

	SELECT @SoHDNVXXuat = (SELECT count(iSoHD) FROM tblDonnhaphang WHERE tblDonnhaphang.iMaNV = @MaNVXoa)
	
	SELECT @SoHDNVKNhap = (SELECT TOP 1 count(iSoHD) FROM tblDondathang HAVING count(iSoHD) < @SoHDNVXNhap ORDER BY count(iSoHD) DESC)

	SELECT @SoHDNVKXuat = (SELECT TOP 1 count(iSoHD)  FROM tblDonnhaphang HAVING count(iSoHD) < @SoHDNVXXuat ORDER BY count(iSoHD) DESC)
	
	SELECT @MaNVNhap = (SELECT iMaNV from tblDondathang WHERE tblDondathang.iSoHD = @SoHDNVKNhap )
	SELECT @MaNVXuat = (SELECT iMaNV from tblDonnhaphang WHERE tblDonnhaphang.iSoHD = @SoHDNVKXuat )
	
	UPDATE tblDondathang SET iMaNV = @MaNVNhap where iMaNV = @MaNVXoa
	UPDATE tblDonnhaphang SET iMaNV = @MaNVXuat where iMaNV = @MaNVXoa
END

--
INSERT INTO dbo.tblDonNhapHang
        ( iSoHD, iMaNV, dNgaynhaphang )
VALUES  ( 8,5,GETDATE() ),
        ( 9,5,GETDATE() )
		
--- kiểm tra
DELETE FROM dbo.tblDonNhapHang
WHERE iMaNV = '5'
