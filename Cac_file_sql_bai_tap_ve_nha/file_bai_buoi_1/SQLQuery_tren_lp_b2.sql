CREATE TABLE Xe (
  Bienso int PRIMARY KEY,
  Sokhung int UNIQUE,
  Mauxe nvarchar(10) Check(Mauxe = N'Trắng' or Mauxe = N'Đen'),
  HangSX varchar(30),
  NamSX int
  );
  --Thêm cột chuxe vào bảng Xe
  GO
  ALTER TABLE Xe 
  ADD chuxe varchar(30)
  -- Xóa rằng buộc khóa chính ở cột Bienso để sửa kiểu dữ liệu cho cột
  GO
  ALTER TABLE Xe
  DROP CONSTRAINT PK__Xe__F700224F8456F657
  --Thay đổi kiểu dữ liệu varchar cho cột biển số
  GO
  ALTER TABLE Xe
  ALTER COLUMN Bienso varchar(30) not null
  --Xóa rằng buộc check của cột Mauxe
  ALTER TABLE Xe
  DROP CONSTRAINT CK__Xe__Mauxe__68487DD7
  --Xóa cột Mauxe
  GO
  ALTER TABLE Xe
  DROP COLUMN Mauxe
  GO
  -- Thêm rằng buộc năm sản xuất phải lơn hơn 2010
  ALTER TABLE Xe
  ADD CONSTRAINT NamSX CHECK(NamSX > 2010)
  GO
  -- Tạo bảng Loaixe(MaLoai,Tenloai)
  CREATE TABLE Loaixe (
  MaLoai varchar(30),
  Tenloai varchar(30) 
  );
  GO
  -- Thêm cột MaLoaixe vào bảng xe
  ALTER TABLE Xe
  ADD MaLoaixe varchar(30)

  ALTER TABLE Loaixe
   ALTER COLUMN MaLoai varchar(40) not null
  
   ALTER TABLE Loaixe
  ADD CONSTRAINT PK_khoa_chinh_bang_Loai_xe PRIMARY KEY (MaLoai)
  ALTER TABLE Loaixe
  DROP CONSTRAINT PK_khoa_chinh_bang_Loai_xe
 ALTER TABLE Loaixe
 ALTER COLUMN MaLoai varchar(30) not null
  GO
  --THêm rằng buộc Foreign Key cho cột MaLoaixe tham chiếu tới cột MaLoai của bảng loại xe
 ALTER TABLE Xe
 ADD CONSTRAINT FK_fjfjf FOREIGN KEY (MaLoaixe) REFERENCES Loaixe(MaLoai)  
 GO
 ALTER TABLE Loaixe
 ADD CONSTRAINT llllll  UNIQUE (Tenloai)
  --lấy ra thời gian
 SELECT GETDATE() 
  SELECT DATEPART(MONTH,GETDATE());
   SELECT DATEDIFF(MM,1/3/2004,1/10/2024)
   -----------*********Bài thực hành trên lớp************-------------
ALTER TABLE THELOAISACH
ADD CONSTRAINT UN_TenTheLoai UNIQUE (TenTheLoai);
ALTER TABLE DOCGIA
ADD CONSTRAINT CK_gioitinh_doc_Gia CHECK (Gioitinh = N'Nam' or Gioitinh = N'Nữ');
ALTER TABLE PHIEUMUON
ALTER COLUMN NgayMuon d
ALTER TABLE PHIEUMUON
ADD CONSTRAINT DF_Ngayhentra_PhieuMuon DEFAULT (DATEADD(day,7, NgayMuon)) FOR Ngayhethan;
SELECT DATEADD(day,7,'2019/04/16');
SELECT DATE_FORMAT('07/07/2023','%m/%d/%Y');
SELECT * FROM Lop;
ALTER TABLE Mon
ALTER COLUMN TenM nvarchar(50) not null;

INSERT INTO Lop
VALUES ('2','tm','3');
INSERT INTO Lop
VALUES ('3','tk','4');
INSERT INTO Mon
VALUES ('1',N'Khoa học máy tính','4'),('2',N'Tiếng anh cơ bản','3')
,('3',N'Cơ sở dữ liệu','4');
SELECT *FROM Mon;
--Môn giải tích tăng 1 tín chỉ
UPDATE Mon
SET  SoTC = SoTC + 1
WHERE TenM = N'Tiếng anh cơ bản';
--Nhập môn có số tín chỉ âm
INSERT INTO Mon
VALUES('124','Co so du lieu',-4);
--Nhập điểm chuyên cần = 0, = 10
INSERT INTO Diem
VALUES ('1','123','2/2/2023',4,5,0),('2','124','3/20/2023',4,5,10);
ALTER TABLE Sinhvien
ALTER COLUMN Gioitinh nvarchar(3) not null;
ALTER TABLE Diem
ADD CONSTRAINT FK_MaSV_Diem FOREIGN KEY (MaSV) REFERENCES Sinhvien(MaSV);
DELETE FROM Mon
WHERE SoTC < 0;
-- thêm 1 điểm giữa kì nếu điểm cc = 10;
UPDATE Diem
SET DiemGiuaKi = DiemGiuaKi + 1
WHERE DiemCC = 10;
DELETE FROM  Diem
FROM Sinhvien
WHERE DiemCC = 0 and Diem.MaSV = Sinhvien.MaS  V ;
SELECT * FROM Sinhvien
SELECT * FROM Diem
UPDATE Diem
SET DiemThi = DiemThi + 1
FROM Sinhvien,Mon
WHERE Sinhvien.Gioitinh = N'Nữ'and Sinhvien.MaSV = Diem.MaSV and Diem.MaMon = Mon.MaM and Mon.TenM = N'Cơ sở dữ liệu';


--Lấy ra danh sách nhân viên nữ của bảng NhanVien
SELECT MaSV,TenSV
FROM Sinhvien
WHERE Sinhvien.Gioitinh = N'Nữ';



