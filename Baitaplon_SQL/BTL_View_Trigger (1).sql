--d. Tạo View hiện dữ liệu (10 view)

--1 View số sách của mỗi thể loại sách 
create or alter view View_SoSachCuaMoiTheLoaiSach
as 
select tls.sMaLoaiSach,tls.sTenTheLoai,count(s.sMaSach) as iSoLuongSach
from tblTheLoaiSach as tls left join tblSach as s
on tls.sMaLoaiSach=s.sMaLoaiSach
group by tls.sMaLoaiSach,tls.sTenTheLoai
go

select *
from View_SoSachCuaMoiTheLoaiSach
go

--2 View số lượng sách đã sáng tác của mỗi tác giả 
create or alter view View_SoLuongSachDaSangTacCuaMoiTacGia
as
select tg.sMaTacGia,tg.sTenTacGia,count(s.sMaSach) as iSoLuongSach
from tblTacGia as tg left join tblSach as s
on tg.sMaTacGia=s.sMaTacGia
group by tg.sMaTacGia,tg.sTenTacGia
go 

select *
from View_SoLuongSachDaSangTacCuaMoiTacGia
go

--3 View số lượng đơn hàng của mỗi khách hàng 
create or alter view View_SoDonHangCuaMoiKhachHang
as
select kh.sMaKhachHang,kh.sTenKhachHang, count(hdmh.iSoHDMH) as iSoLuongDonHang
from tblKhachHang as kh left join tblHoaDonMuaHang as hdmh
on kh.sMaKhachHang=hdmh.sMaKhachHang
group by kh.sMaKhachHang,kh.sTenKhachHang
go

select * 
from View_SoDonHangCuaMoiKhachHang
go

--4 View số lượng đơn hàng và tổng tiền mà mỗi nhân viên bán được 
create or alter view View_SoDonHangVaTongTienMoiNhanVienBanDuoc
as
select nv.sMaNhanVien,nv.sTenNhanVien,
		count(hdmh.iSoHDMH) as iSoLuongDonHang,
		sum(case when hdmh.iSoHDMH is not null then (cthdmh.fSoLuong*cthdmh.fDonGia-cthdmh.fSoLuong*cthdmh.fGiamGia) else 0 end) as iTongTien
from tblNhanVien as nv left join tblHoaDonMuaHang as hdmh
on nv.sMaNhanVien=hdmh.sMaNhanVien left join tblChiTietHDMuaHang as cthdmh
on hdmh.iSoHDMH=cthdmh.iSoHDMH
group by nv.sMaNhanVien,nv.sTenNhanVien
go

select * 
from View_SoDonHangVaTongTienMoiNhanVienBanDuoc
go

--5 View tổng tiền và số lượng hàng của mỗi hóa đơn nhập hàng 
create or alter view View_TongTienVaSoLuongHangCuaMoiHoaDonNhap
as 
select hdnh.iSoHDNH,hdnh.dNgayNhap,
		count(cthdnh.fSoLuongNhap) as iSoLuong,
		sum( case when cthdnh.iSoHDNH is not null then cthdnh.fSoLuongNhap*cthdnh.fGiaNhap else 0 end ) as fTongTien
from tblHoaDonNhapHang as hdnh left join tblChiTietHDNhapHang cthdnh
on hdnh.iSoHDNH=cthdnh.iSoHDNH
group by hdnh.iSoHDNH,hdnh.dNgayNhap
go

select *
from View_TongTienVaSoLuongHangCuaMoiHoaDonNhap
go

-- 6 View số lượng và tổng tiền sách của mỗi nhà xuất bản 
create or alter view View_SoLuongVaTongTienSachCuaMoiNhaXuatBan
as 
select nxb.sMaNXB,nxb.sTenNXB,
		count(s.sMaSach) as iSoLuongSach,
		sum(case when s.sMaSach is not null then s.fSoLuong*s.fGiaBan else 0 end) as fTongTienSach
from tblNhaXuatBan as nxb left join tblSach as s 
on nxb.sMaNXB=s.sMaNXB
group by nxb.sMaNXB,nxb.sTenNXB
go

select *
from View_SoLuongVaTongTienSachCuaMoiNhaXuatBan
go

-- 7 View trung bình số tiền bán hàng của mỗi nhân viên 
create or alter view View_TrungBinhSoTienBanDuocCuaMoiNhanVien
as
select nv.sMaNhanVien,nv.sTenNhanVien,
		avg(case when cthdmh.iSoHDMH is not null then (cthdmh.fSoLuong*cthdmh.fDonGia-cthdmh.fSoLuong*cthdmh.fGiamGia) else 0 end) as fSoTienTrungBinh
from tblNhanVien as nv left join tblHoaDonMuaHang as hdmh
on nv.sMaNhanVien=hdmh.sMaNhanVien left join tblChiTietHDMuaHang as cthdmh
on hdmh.iSoHDMH=cthdmh.iSoHDMH
group by nv.sMaNhanVien,nv.sTenNhanVien
go

select * 
from View_TrungBinhSoTienBanDuocCuaMoiNhanVien;
go 

-- 8 View tính số lượng nhan vien theo giới tính 
create or alter View View_SoLuongNhanVienTheoGioiTinh 
as
select  nv.sGioiTinh, count(nv.sMaNhanVien) as iSoLuongNhanVien
from tblNhanVien as nv 
group by  nv.sGioiTinh
go 

select * 
from View_SoLuongNhanVienTheoGioiTinh; 
go

--9 View 3 khách hàng mua hàng nhiều nhất 
create or alter view View_3KhachMuaHangNhieuNhat 
as 
select top 3 kh.sMaKhachHang,kh.sTenKhachHang, count(hdmh.iSoHDMH) as iSoDonHang
from tblKhachHang as kh inner join tblHoaDonMuaHang as hdmh
on kh.sMaKhachHang=hdmh.sMaKhachHang
group by kh.sMaKhachHang,kh.sTenKhachHang
order by count(hdmh.iSoHDMH) desc; 
go

select * 
from View_3KhachMuaHangNhieuNhat
go

--10 View so luong sach ban duoc cua moi the loai
create or alter view View_SoLuongSachBanDuocCuaMoiTheLoai
as
select tls.sMaLoaiSach,tls.sTenTheLoai, count(hdmh.iSoHDMH) as iSoLuongSachBanDuoc
from tblTheLoaiSach as tls left join tblSach as s 
on tls.sMaLoaiSach=s.sMaLoaiSach left join tblChiTietHDMuaHang as cthdmh
on s.sMaSach=cthdmh.sMaSach left join tblHoaDonMuaHang as hdmh
on cthdmh.iSoHDMH=hdmh.iSoHDMH
group by tls.sMaLoaiSach,tls.sTenTheLoai
go

select * 
from View_SoLuongSachBanDuocCuaMoiTheLoai
go




--f. Viết các Trigger cho phép kiểm soát ràng buộc dữ liệu, đồng bộ dữ liệu: đơn giản, phức tạp, IF_UPDATE (ít nhất 10 trigger)
--Viết lệnh kích hoạt các Trigger

--1 Viết trigger để số lượng sách bán ra không vượt quá số lượng sách hiện có

create or alter trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo
on tblChiTietHDMuaHang 
for insert, update
as 
declare @sMaSach nvarchar(15)  , @fSoLuong float
select @sMaSach=sMaSach, @fSoLuong=fSoLuong from inserted

declare Cursor_DemSoLuongSach cursor static
for select fSoLuong from tblChiTietHDMuaHang where sMaSach=@sMaSach

open Cursor_DemSoLuongSach
declare @fTongSoLuongSachMua float , @fSoLuongSach float
fetch next from Cursor_DemSoLuongSach into @fSoLuongSach
set @fTongSoLuongSachMua=0
while @@FETCH_STATUS=0
	begin
		set @fTongSoLuongSachMua=@fTongSoLuongSachMua+@fSoLuongSach
		fetch next from Cursor_DemSoLuongSach into @fSoLuongSach
	end

close Cursor_DemSoLuongSach
deallocate Cursor_DemSoLuongSach

if(@fTongSoLuongSachMua>(select fSoLuong from tblSach where @sMaSach=sMaSach))
	begin
		print 'So luong sach khong du de ban'
		rollback tran
	end

go
create or alter trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo
on tblChiTietHDMuaHang 
for insert, update
as 
declare @sMaSach nvarchar(15)  , @fSoLuong float, @fTongSoLuongSachHienCo float
select @sMaSach=sMaSach, @fSoLuong=fSoLuong from inserted
select @fTongSoLuongSachHienCo= count(s.sMaSach)
from tblSach as s 
where s.sMaSach=@sMaSach

if(@fTongSoLuongSachHienCo<(select sum(cthdmh.fSoLuong) from tblChiTietHDMuaHang as cthdmh where cthdmh.sMaSach=@sMaSach group by cthdmh.sMaSach))
	begin
		print 'So luong sach khong du de ban'
		rollback tran
	end

alter table tblChiTietHDMuaHang disable trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo
alter table tblChiTietHDMuaHang enable trigger Trigger_SoLuongSachBanRaKhongVuotQuaSoLuongSachHienCo

insert into tblChiTietHDMuaHang
values (1,'Sach07',12000,3,1200);
go

--2 Thêm fTongTienHang vào bảng tblKhachHang viết trigger khi khách hàng đến mua hàng thì tổng tiền hàng tự động tăng 

alter table tblKhachHang
add fTongTienHang float

update tblKhachHang
set fTongTienHang=0 
go

create or alter trigger Trigger_KhachHangDenMuaHangThiTongTienHangTuDongTang
on tblChiTietHDMuaHang
for insert, update
as
declare @iSoHDMH int, @fDonGia float, @fSoLuong float, @fGiamGia float 
select @iSoHDMH=iSoHDMH, @fDonGia=fDonGia, @fSoLuong=fSoLuong, @fGiamGia=fGiamGia from inserted
update tblKhachHang
set fTongTienHang=fTongTienHang +(@fSoLuong*@fDonGia-@fGiamGia)
from tblKhachHang as kh inner join tblHoaDonMuaHang as hdmh
on kh.sMaKhachHang=hdmh.sMaKhachHang inner join tblChiTietHDMuaHang as cthdmh
on hdmh.iSoHDMH=cthdmh.iSoHDMH and cthdmh.iSoHDMH=@iSoHDMH

insert into tblChiTietHDMuaHang
values (1,'Sach08',12000,3,1200);

alter table tblChiTietHDMuaHang disable trigger Trigger_KhachHangDenMuaHangThiTongTienHangTuDongTang
alter table tblChiTietHDMuaHang enable trigger Trigger_KhachHangDenMuaHangThiTongTienHangTuDongTang
go

--3  Viết trigger đảm bảo mỗi hóa đon chỉ được mua tối đa 3 sách khác nhau
create or alter trigger Trigger_MoiHoaDonChiDuocMuaToiDa3SachKhacNhau
on tblChiTietHDMuaHang
for insert , update
as
declare @iSoHDMH int , @sMaSach nvarchar(15)
select @iSoHDMH=iSoHDMH,@sMaSach=sMaSach  from inserted

if ((select count(sMaSach) from tblChiTietHDMuaHang where iSoHDMH=@iSoHDMH group by iSoHDMH)>3)
	begin
		print 'Moi hoa don chi duoc mua toi da ba sach khac nhau'
		rollback tran
	end

insert into tblChiTietHDMuaHang
values (1,'Sach08',12000,3,1200);
insert into tblChiTietHDMuaHang
values (1,'Sach07',12000,3,1200);
insert into tblChiTietHDMuaHang
values (1,'Sach06',12000,3,1200);

alter table tblChiTietHDMuaHang disable trigger Trigger_MoiHoaDonChiDuocMuaToiDa3SachKhacNhau
alter table tblChiTietHDMuaHang enable trigger Trigger_MoiHoaDonChiDuocMuaToiDa3SachKhacNhau
go

--4 Viết trigger mỗi nhân viên chỉ được lập 3 hóa đơn mua hang 1 ngày 
create or alter trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
on tblHoaDonMuaHang
for insert, update
as
declare @sMaNhanVien nvarchar(15), @dNgayMuaHang date
select @sMaNhanVien=sMaNhanVien, @dNgayMuaHang=dNgayMuaHang from inserted
if ((select count(sMaNhanVien) from tblHoaDonMuaHang where sMaNhanVien=@sMaNhanVien and dNgayMuaHang=@dNgayMuaHang group by sMaNhanVien,dNgayMuaHang)>3)
	begin 
		print 'Moi nhan vien chi duoc lap 3 hoa don mua hang trong 1 ngay'
		rollback tran
	end

insert into tblHoaDonMuaHang
values (11,'NV01','KH10','2023-10-22')
insert into tblHoaDonMuaHang
values (12,'NV01','KH10','2023-10-22')
insert into tblHoaDonMuaHang
values (13,'NV01','KH10','2023-10-22')
insert into tblHoaDonMuaHang
values (14,'NV01','KH10','2023-10-22')

alter table tblHoaDonMuaHang disable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
alter table tblHoaDonMuaHang enable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
go

-- 5 Thêm iSoDonHangBanDuoc cho tblNhanVien viết trigger khi nhân viên bán được 1 đon hàng cột số đơn hàng tự động tăng 
alter table tblNhanVien
add iSoDonHangBanDuoc int 

update tblNhanVien
set iSoDonHangBanDuoc=0; 
go

create or alter trigger Trigger_NhanVienBanDuocHangCotSoDonHangTuDongTang
on tblHoaDonMuaHang
for insert, update
as
declare @sMaNhanVien nvarchar(15)
select @sMaNhanVien=sMaNhanVien from inserted

update tblNhanVien
set iSoDonHangBanDuoc=iSoDonHangBanDuoc+1
where sMaNhanVien=@sMaNhanVien

insert into tblHoaDonMuaHang
values (11,'NV01','KH01','2023-01-01')


alter table tblHoaDonMuaHang disable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay
alter table tblHoaDonMuaHang enable trigger Trigger_MoiNhanVienChiDuocLap3HoaDonMuaHangMotNgay