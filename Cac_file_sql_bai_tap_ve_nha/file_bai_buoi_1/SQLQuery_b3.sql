SELECT Lop.Tenlop AS[Tên lớp],COUNT(Sinhvien.MaSV) AS[Sô lượng sinh viên]
FROM Sinhvien,Lop,Khoa
WHERE Lop.Malop = Sinhvien.MaLop AND Khoa.MaK = Lop.MaK
GROUP BY Lop.Tenlo
SELECT COUNT(Mon.MaM) AS[Số lượng môn]
FROM Mon
WHERE Mon.SoTC>3
--------
SELECT Khoa.TenKhoa
FROM Khoa,Lop,Sinhvien
WHERE Khoa.MaK = Lop.MaK AND Sinhvien.MaLop = Lop.Malop AND Sinhvien.Gioitinh = N'Nữ'
GROUP BY TenKhoa
HAVING COUNT(Khoa.TenKhoa )> 100

SELECT Sinhvien.TenSV
FROM Sinhvien,Diem
WHERE 

-----------------------------------------------------------------------------------
ALTER VIEW cwDaSachSV_nu_Khoa 
AS SELECT TOP 100 PERCENT Khoa.TenKhoa AS[Tên khoa],Sinhvien.TenSV AS[Tên sinh viên]
FROM Khoa,Sinhvien,Lop
WHERE Lop.Malop = Sinhvien.MaLop AND Khoa.MaK = Lop.MaK AND Sinhvien.Gioitinh = N'Nữ'
ORDER BY Khoa.TenKhoa ASC
WITH CHECK OPTION
SELECT * FROM cwDaSachSV_nu_Khoa;
---------tuổi trung bình của tungừ lớp--------
ALTER VIEW cw_tuoi_tb_tung_lop
AS SELECT Lop.Tenlop,AVG(DATEDIFF(YEAR,Sinhvien.Ngaysinh,GETDATE())) AS[Tuổi trung bình của từng lớp]
FROM Lop,Sinhvien
WHERE Lop.Malop = Sinhvien.MaLop
GROUP BY Lop.Tenlop;
SELECT * FROM cw_tuoi_tb_tung_lop;
----------
ALTER VIEW cw_diem_mon_moi_sv
AS SELECT Sinhvien.MaSV AS[Mã sinh viên],Sinhvien.TenSV AS[Tên sinh viên]
,Mon.MaM AS[Mã môn],Mon.TenM AS[Tên môn],Mon.SoTC AS[Số tín chỉ], (Diem.DiemCC*0.1  + Diem.DiemGiuaKi*.2   +Diem.DiemThi*0.7 ) AS[Điểm môn]
FROM Mon, Diem,Sinhvien
WHERE Mon.MaM = Diem.MaMon AND Diem.MaSV = Sinhvien.MaSV;
SELECT * FROM cw_diem_mon_moi_sv;
-------dùng vwTinhDiem để tính DTBTL = tổng (SQTC*DiemMon)/tổng số tc 
-------Lấy vra số tín chỉ đã học
-------số tín chỉ đã học
SELECT (Diem.DiemCC*0.1  + Diem.DiemGiuaKi*.2   +Diem.DiemThi*0.7 ) 

-------dssv học vmoon A , tự nhập
--số lượng sinh viên chưa học và học lại của từng môn
--Dssv có số tín chỉ nợ >= 24
--dssv có dtbtl <1.0 trong khoảng thời gian 15/8/2022 - 1/12/2022
--dssv đạt học bổng : có SoTC trong kì >=18 và dtbtl trong kì >=7.0(theo khoảng thời gian tự chọn).
--dssv dự thi của từng môn theo thời gian.

DECLARE @a INT, @b INT
SET @a = MONTH(GETDATE())
SELECT @b = @a + 1
SELECT @b AS [Tháng sau]
--Cấu trúc if và else -> giống trong lập trình
--vd:
DECLARE @a INT, @b INT
SET @a = MONTH(GETDATE())
IF @a = 12 SET @b = 1
ELSE SELECT @b = @a + 1
SELECT @b AS[Tháng sau]
---Lấy tháng hiện tại cho biết số ngày trong tháng là bao nhiêu
DECLARE @a INT, @b INT
SET @a = 2016
SET @b = 4
IF @a % 4 =0 and @a % 100=0 print N'Năm nhuận'
ELSE print N'Không phải năm nhuận'
--- Cấu trúc case có 2 dạng: Search Case và Simple Case
---Search case
---CASE WHEN điều kiện Then'Trả về kết quả'
--------WHEN điều kiện Then'Trả về kết quả'
--------ELSE 'Ngược lại với các điều kiện trên nó sẽ trả về kết quả'
--------END
---Simple case
---CASE biểu thức đầu vào
----When biểu thức_1 Then trả về kết quả 1
----When biểu thức_2 Then trả về kết quả 2
----..............
----ELSE kết quả khác
----END
Bài tập
CREATE VIEW cw_DTB
AS
SELECT [Mã sinh viên],[Tên sinh viên], SUM([Số tín chỉ]*([Điểm môn])) / SUM([Số tín chỉ]) AS DTB
FROM [dbo].[cw_diem_mon_moi_sv]
GROUP BY [Mã sinh viên],[Tên sinh viên]
SELECT * FROM cw_diem_mon_moi_sv;

-------xếp loại điểm tbl < 5 => xếp loại yếu và 5 < dtb<7 => trung bình và 7<= dtb < 8 => kha và 8<= dtb => giỏi
SELECT [Tên sinh viên],[DTB],
CASE WHEN [DTB] < 5 THEN N'Yếu'
     WHEN 5< [DTB] and [DTB] < 7 THEN N'Trung bình'
	 WHEN [DTB] >=7 and [DTB] < 8 THEN N'Khá'
	 WHEN [DTB] <= 8 THEN N'Giỏi'
END AS[Xếp loại]
FROM [dbo].[cw_DTB]
------- 
SELECT [sTenNV],DATEDIFF(day,[dNgaysinh],GETDATE())/365 AS[Tuổi],
CASE 
WHEN DATEDIFF(day,[dNgaysinh],GETDATE())/365 >=18 and DATEDIFF(day,[dNgaysinh],GETDATE())/365 <=30  THEN N'Thanh niên' 
WHEN DATEDIFF(day,[dNgaysinh],GETDATE())/365 >=31 and DATEDIFF(day,[dNgaysinh],GETDATE())/365 <=50  THEN N'Trung niên' 
WHEN DATEDIFF(day,[dNgaysinh],GETDATE())/365 >=51  THEN N'Người cao tuổi' 
END AS[Thuộc]
FROM [dbo].[tblNhanVien] 
----------------vòng lặp while 
------cấu trúc
------While ( điều kiện)
------Begin
------....................
------End
------- Tạo 1 Strored Procedure
CREATE PROCEDURE spTong2So
@a INT,
@b INT
AS SELECT @a+@b AS Tong

--------Thực thi truyền 2 tham số cho STrored Procedure spTong2So
EXECUTE spTong2So 2,3;
ALTER PROCEDURE tinh_diem_mon
@ten_mon nvarchar(50),
@diem_cc float,
@diem_gk float,
@diem_thi float
as
declare @diemmon float
if(@diem_cc<4 and @diem_gk < 4) print N'Không được thi' 


else 
	begin 
	set @diemmon = 0.15*@diem_cc+ 0.2*@diem_gk + 0.65*@diem_thi 
	if @diemmon >=4 print N'Đạt'
	else print N'Không đạt'
	end
EXECUTE tinh_diem_mon N'Khoa học máy tính',3,3,5;

ALTER PROC demSV
@sonam int output,
@sonu int output
as 
SET @sonam = 0
SET @sonu = 0
SELECT @sonu = COUNT(MaSV) FROM Sinhvien
WHERE Gioitinh = N'Nữ'
SELECT @sonam = COUNT(MaSV) from Sinhvien
WHERE Gioitinh = N'Nam'

declare @Nam int,@Nu int
exec demSV @sonam  = @Nam output,@sonu = @Nu output
SELECT @Nam AS[Số nam],@Nu AS[Số nữ]	
--Số lượng nhân viên sinh trong tháng với tháng là tham số truyền vào, số lượng là tham số trả  về
go
CREATE PROC soluongtheothang
@thang int,
@soluong int output
as
SET @soluong = 0
SELECT @soluong = COUNT(MaSV) FROM Sinhvien
WHERE MONTH(Ngaysinh) = @thang
go
DECLARE @Soluong int
EXEC soluongtheothang 11,@Soluong = @soluong output
SELECT @soluong
go
----viết thủ tục nhập vào tên môn,trả về số lượng sv chưa học và học

CREATE PROC soluongSV_chua_va_hoc
@tenmon nvarchar(30),
@soLuong int output
as 
SELECT COUNT ([dbo].[Sinhvien].MaSV) FROM Sinhvien left join Diem
on (Sinhvien.MaSV = Diem.MaSV)  left join Mon on  (Mon.MaM = Diem.MaMon)
WHERE TenM = N'Khoa hoc may tinh'
SELECT COUNT (*) FROM Sinhvien left join Diem
on (Sinhvien.MaSV = Diem.MaSV)  left join Mon on  (Mon.MaM = Diem.MaMon and Mon.TenM=N'Khoa hoc may tinh')
WHERE Diem.MaSV is null
-----DATABASE Quanlibanhang
-----Số lượng mathang thuộc mặt hàng
DECLARE soluongMathangfgh CURSOR STATIC
FOR SELECT [dbo].[tblMatHang].[sTenhang],[dbo].[tblMatHang].[fSoluong]
FROM [dbo].[tblMatHang]
OPEN soluongMathangfgh
DECLARE @soluongg float,@tenhang nvarchar(30)
FETCH ABSOLUTE 3 FROM soluongMathangfgh into @tenhang,@soluongg
PRINT @soluongg
PRINT @tenhang
CLOSE soluongMathangfgh
DEALLOCATE soluongMathangfgh
----------TRANSACTION _ GIAO TÁC (là các hành động cập nhật dữ liệu trên nhiều bảng khác nhau)

----------TRIGGER--------------
go
ALTER TRIGGER thongbao
on sinhvien
 for insert, delete,update
as 
print 'Ban da them du lieu'
SELECT * FROM inserted
SELECT * FROM deleted
go
INSERT INTO Sinhvien
VALUES('17','kk',N'nam','11/04/2004','123');

DELETE FROM Sinhvien WHERE MaSV='15'
SELECT * FROM Sinhvien

UPDATE Sinhvien
SET Gioitinh = 'nu'
WHERE Gioitinh = 'nam';
ALTER TABLE Lop
ALTER COLUMN Siso int not null;
---------------Tạo triggeer đưa ra cảnh báo chỉ cho phép giới tính của nhân viên là Nam hoặc nữ
CREATE TRIGGER thongbao_gioitinh
on Sinhvien
for insert, update
as 
declare @gt nvarchar(3)
SELECT @gt = Gioitinh FROM inserted
if(@gt = N'nam' or @gt = N'nu') print 'Bình thường'
else 
begin
print'Gioi tính chỉ nhận nam hoặc nu'
rollback
end

INSERT INTO Sinhvien values(18,'fjfjfjfj','aff','11/04/2004','123')

ALTER TRIGGER TangSoNV
ON Sinhvien
FOR INSERT ,UPDATE
AS 
BEGIN
 DECLARE @Malop varchar(20) , @MaSV varchar(50)
 SELECT @MaSV=MaSV, @Malop = MaLop  FROM INSERTED 
  if exists(SELECT * FROM Sinhvien WHERE @MaSV = MaSV) 
 BEGIN 
print 'Sinh vien nay da ton tai'
ROLLBACK --hủy bản ghi chứa nhân viên vừa thêm 
END 
 if exists(SELECT * FROM Lop WHERE @Malop = Malop)
  BEGIN
	UPDATE Lop
	SET Siso = Siso + 1 
	WHERE @Malop = Lop.Malop
END
END
INSERT INTO Sinhvien
VALUES ('22','fkfkfk',N'nam','10/05/2004','123')
SELECT * FROM Lop
---------Cho phép 1 lớp chi có tối đa 5 sv
---------Thêm cột ngayvaotruong vào bảng sinhvien;
-----viet trigger kiem soat sinh vien chỉ có điểm ngayvaotruong
-----nếu ngayvaotruong > ngayhoc
-----khi sv da vao trường

CREATE TRIGGER thongbao_toi_da_sv_1_lop
ON LOP
FOR INSERT,UPDATE,DELETE
AS
	DECLARE @Siso int,@Malop varchar(20)
	 SELECT @Siso = Siso,@Malop = Malop FROM inserted
	if(exists(SELECT * FROM Lop WHERE @Malop = Malop))
	Begin
	print' lớp này đã tồn tại'
	rollback
	end
	if(@Siso<=5)
	print'Thêm được'

	INSERT INTO Lop
	VALUES ('123','fjfjf','SQL',1)

-------Tạo 1 login
CREATE LOGIN test with password = 'khoi123';
-------Tạo user
CREATE USER Vanh FOR login test
------cấp quyền cho vanh
grant select, insert
on Diem
to vanh
-----xóa quyền
revoke select
on Diem
to vanh
alter user Vanh with DEFAULT_SCHEMA = [Quan_li_sinh_vien]
---cấp lại quyền
grant select
on Diem(DiemCC,DiemThi)
to vanh;
------ bài tập  tạo người dùng login là tensv
CREATE LOGIN tensv with password = '123'
CREATE USER tensv FOR login tensv with default_schema = Quanlibanhang;

------Tạo role
CREATE ROLE Giangvien

GRANT SELECT,UPDATE,INSERT,DELETE
on Diem
to Giangvien;

exec sp_addrolemember Giangvien, vanh;

exec soluongSV_chua_va_hoc N'fjfjfj',12;

--Bài tập
--1 Tạo người dùng login và khai thác DB QuanlySinhvien là tennguoidung(sv,gv,ad)
--2 Tạo Role: Sinhvien, Quantri, Giangvien
--3 Cấp quyền cho Role Sinhvien: xem Diem,xem Mon.
--4 Giảng viên: I,U,S Diem
--5 Quantri: có toàn bộ quyền trên tất cả các bảng
--6 Thêm người dùng đã tạo ở bước 1 vào Role tương ứng

CREATE LOGIN sv1 with password='123456'
CREATE USER sv1
for login sv1
With DEFAULT_SCHEMA = Quan_li_sinh_vien
CREATE ROLE SINHVIEN
GRANT SELECT
on Diem
to SINHVIEN
exec sp_addrolemember SINHVIEN, sv1;
SELECT * FROM Diem
DELETE Diem
WHERE MaSV='1*1'


CREATE PROCEDURE tinh_tong_2so
@a int output,
@b int output
With encryption
AS
if @a>0 print 'Chính xác'
Return 13;



ALTER PROC tinh_tong_2so
@a int,
@b int output
with encryption
As
SET @b = @a+10
Return 13;

DECLARE @e int =0 
EXEC tinh_tong_2so 1,@e 
SELECT @e;
SET @e = SELECT @b * FROM tinh_tong_2so;

DECLARE myCursorf CURSOR
FOR 
SELECT TenNv FROM NhanVien
OPEN myCursorf
DECLARE @tennv nvarchar(40) 
FETCH NEXT FROM myCursorf INTO @tennv
WHILE @@FETCH_STATUS = 0
BEGIN
   PRINT @tennv
   FETCH NEXT FROM myCursorf INTO @tennv
END

CLOSE myCursorf
DEALLOCATE myCursorf








