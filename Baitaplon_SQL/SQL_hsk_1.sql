CREATE DATABASE hsk;
CREATE TABLE tblSINHVIEN (
iMaSV varchar(10) not null,
sHoTen nvarchar(50),
dNgaySinh date,
sDiaChi nvarchar(255),
sSoDienThoai varchar(30),
bGioiTinh bit
CONSTRAINT pK_iMaSV_tblSinhVien PRIMARY KEY (iMaSV) );
use hsk;
go
CREATE PROC nhap_du_lieu_tblSinhVien
@iMaSV varchar(10),
@sHoTen nvarchar(50),
@dNgaySinh date,
@sDiaChi varchar(255),
@sSoDienThoai varchar(30), 
@bGioiTinh bit
AS
INSERT INTO tblSINHVIEN 
VALUES (@iMaSV,@sHoTen,@dNgaySinh,@sDiaChi,@sSoDienThoai,@bGioiTinh);
SELECT * FROM tblSINHVIEN
go
CREATE or alter PRoc checkID_proc 
@sMaSV varchar(10)
AS
BEGIN
	if(EXISTS(SELECT iMaSV FROM tblSINHVIEN where iMaSV = @sMaSV))
	Begin
		select * from tblSINHVIEN where iMaSV = @sMaSV;
	end
	
		
END
Execute checkID_proc '1';

go
CREATE or ALTER PROC them_du_lieu 
@iMaSV varchar(10),
@sHoTen nvarchar(50),
@dNgaySinh date,
@sDiaChi varchar(255),
@sSoDienThoai varchar(30), 
@bGioiTinh bit
AS
BEGIN
	INSERT INTO tblSINHVIEN
	VALUES (@iMaSV,@sHoTen,@dNgaySinh,@sDiaChi,@sSoDienThoai,@bGioiTinh);
END



