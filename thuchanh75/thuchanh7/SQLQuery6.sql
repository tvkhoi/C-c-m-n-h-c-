create database KT
go
use KT
go
create table tblBenhNhan_VTL
(
	MaBN_VTL varchar(30) primary key,
	TenBN_VTL nvarchar(30)
)
create table tblHopDong_VTL
(
	Ngay_VTL date,
	MaBN_VTL varchar(30),
	DichVu_VTL nvarchar(100)
)
go
drop table tblHopDong_VTL

create table tblDichVu_VTL
(
	IDDV_VTL varchar(30) primary key,
	TenDV_VTL nvarchar(30)
)
go
alter table tblHopDong_VTL
 ADD CONSTRAINT FK_tblHopDong_VTL_tblBenhNhan_VTL FOREIGN KEY (MaBN_VTL) REFERENCES tblBenhNhan_VTL(MaBN_VTL)
 go
 insert tblBenhNhan_VTL
 values('01','Vu Van A')
  insert tblBenhNhan_VTL
 values('02','Vu Van B')
  insert tblBenhNhan_VTL
 values('03','Vu Van C')
  insert tblBenhNhan_VTL
 values('04','Vu Van D')
  insert tblBenhNhan_VTL
 values('05','Vu Van F')
 GO
insert tblDichVu_VTL
 values ('001',N'Lăn kim')
  insert tblDichVu_VTL
 values ('002',N'Triệt lông')
  insert tblDichVu_VTL
 values ('003',N'Nâng mũi')
  insert tblDichVu_VTL
 values ('004',N'Cắt môi trái tim')
  insert tblDichVu_VTL
 values ('005',N'Cắt mí mắt')
  insert tblDichVu_VTL
 values ('006',N'Xăm lông mày')
   insert tblDichVu_VTL
 values ('007',N'Xăm môi ')
 go
 create proc hienmabenhnhan1
 as
 select MaBN_VTL from tblBenhNhan_VTL
 go
 create proc hienchondichvu
 as
 select TenDV_VTL from tblDichVu_VTL
 go
 create PRoc checkID_proc
@sMaBN_VTL varchar(20)
AS
BEGIN
	if(EXISTS ( SELECT @sMaBN_VTL FROM tblBenhNhan_VTL where @sMaBN_VTL =  MaBN_VTL))
	select @sMaBN_VTL from tblBenhNhan_VTL
	END
alter proc select_sokhambenh
@MaBN nvarchar(20)
as
begin
	select BN.MaBN_VTL , BN.TenBN_VTL , HD.Ngay_VTL , HD.DichVu_VTL 
	from tblBenhNhan_VTL as BN , tblHopDong_VTL as HD 
	where BN.MaBN_VTL = HD.MaBN_VTL and BN.MaBN_VTL=@MaBN
end
go
alter proc select_DSKBTTG
as
begin
	SELECT 
    ROW_NUMBER() OVER (PARTITION BY HD.Ngay_VTL ORDER BY HD.Ngay_VTL) AS stt, 
    BN.MaBN_VTL, 
    BN.TenBN_VTL, 
    HD.Ngay_VTL, 
    HD.DichVu_VTL
FROM 
    tblBenhNhan_VTL AS BN
INNER JOIN 
    tblHopDong_VTL AS HD ON BN.MaBN_VTL = HD.MaBN_VTL

end
	
-- Tạo ràng buộc duy nhất cho cặp MaBN_VTL và Ngay_VTL
	select * from dbo.tblBenhNhan_VTL
	select * from dbo.tblHopDong_VTL
	select * from dbo.tblDichVu_VTL
	truncate table dbo.tblHopDong_VTL

