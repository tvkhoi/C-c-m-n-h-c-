
CREATE TABLE Khoa (MaK Varchar(20) not null,
    TenKhoa Varchar(30) not null,
	SDT Varchar(12) not null,
	Diachi Varchar(40) not null
	PRIMARY KEY (MaK),
	UNIQUE (TenKhoa));
GO
CREATE TABLE Lop (
 Malop Varchar(20) not null,
 Tenlop Varchar(20) not null,
 MaK Varchar(30) not null,
 PRIMARY KEY (Malop),
 UNIQUE (Tenlop)  );
GO
CREATE TABLE Sinhvien (
 MaSV Varchar(20) not null,
 TenSV Varchar(30) not null,
 Gioitinh varchar not null,
 Ngaysinh Date not null,
 MaLop Varchar(20) not null,
 PRIMARY KEY (MaSV)
   );
GO

 GO
 CHECK (  YEAR (Ngaysinh)=YEAR(GETDATE()))
 CREATE TABLE Mon (
  MaM Varchar(20) not null,
  TenM Varchar(30) not null,
  SoTC Int not null,
  PRIMARY KEY (MaM),
  CHECK (SoTC <= 5 )   );
  GO
CREATE TABLE Diem (
  MaSV Varchar(20) not null,
  MaMon Varchar(20) not null,
  Ngayhoc Date not null,
  DiemGiuaKi Float not null CHECK (DiemGiuaKi Between 0 and 10),
  DiemThi Float not null CHECK (DiemThi Between 0 and 10),
  DiemCC Float not null CHECK (DiemCC Between 0 and 10),
  PRIMARY KEY (MaSV, MaMon,Ngayhoc)
  );
  GO
 
 
