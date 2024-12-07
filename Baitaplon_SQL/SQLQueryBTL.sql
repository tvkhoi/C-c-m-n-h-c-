--1.Tạo thủ tục có tham số truyền vào là năm cho biết năm đó những nhân viên nào vào làm
create proc Nam_NV
@nam int
as
begin 
	select*from tblnhanvien where year(dngaysinh)=@nam
end
exec Nam_NV 2002

--2 tạo thủ tục cho biết sach của tác giả nào, với tham số truyền vào là mã tác giả
create proc sach_tacgia
@matg varchar(15)
as
begin
	select smatacgia,stensach from tblSach where sMaTacGia=@matg
end

exec sach_tacgia 'TG01'

--3 tạo thủ tục in ra danh sách sách có mã thể loại là tham số truyền vào
create proc sach_theloai
@matl varchar(15)
as
begin
	select smasach,stensach from tblSach where sMaLoaiSach=@matl
end
exec sach_theloai 'TL01'
--4 tạo thủ tục thêm nhân viên bao gồm(mã, tên,ngày sinh,địa chỉ) nếu trùng thì không cho thêm vào
alter proc them_NV
@manv varchar(30),
@tennv nvarchar(30),
@ngaysinh date,
@diachi nvarchar(50)
As
if exists(select * from tblNhanvien where sMaNhanVien = @manv)
		Begin
			Print N'Mã nhân viên đã có'
			return
		end	
else
Insert into tblNhanvien(sMaNhanVien, sTenNhanVien,dNgaySinh,sDiaChi)
Values (@manv, @tennv, @ngaysinh,@diachi)
exec them_NV 'NV01',N'Hoa','2/2/2001',N'Hoàng Mai'

--5 Proc sửa đổi số lượng và giá bán của bảng chi tiết hóa đơn nhập hàng với tham số truyền vào là iSoHDNH ,sMaSach
-- số lượng mới và giá bán mới
	create proc SuaDoi_SL_GB_ChiTietHDMH
		@isohdmh int,
		@smasach varchar(15),
		@fdongia float,
		@fsoluong float,
		@fgiamgia float
		as
		begin 
			if((@fsoluong > 0 and @fdongia > 0 and @fgiamgia > 0) )
			begin
			update tblChiTietHDMuaHang
			set fSoLuong = @fsoluong , fdongia = @fdongia,fgiamgia=@fgiamgia
			where isohdmh = @isohdmh and sMaSach = @smasach
			select * from tblChiTietHDNhapHang
			end
			else begin print(N'Vui lòng nhập lại số lượng và giá bán, giảm giá phải > 0') end
		end
		-- thực thi proc SuaDoi_SL_GB_ChiTietHDMH
		select * from tblChiTietHDMuaHang
		exec SuaDoi_SL_GB_ChiTietHDMH 1, 'Sach01',13000,10,1000

--6 tạo thủ tục thêm dữ liệu cho bảng tác giả với tham số truyền vào
create proc themTG
@matg varchar(20),
@tentg nvarchar(30)
as
begin
	insert into tblTacGia(sMaTacGia,sTenTacGia)
	values(@matg,@tentg)
end

exec themTG 'TG11',N'Trương Định'
select*from tbltacgia
--7 tạo thủ tục cập nhật thông tin khách hàng với tham số truyền vào là mã khách hàng
alter PROCEDURE CapNhatThongTinKhachHang
     @MaKhachHang varchar(30),
     @TenMoi NVARCHAR(50),
     @DiaChiMoi NVARCHAR(50),
     @SDTMoi VARCHAR(50)
as
BEGIN
    IF EXISTS (SELECT *FROM tblKhachHang WHERE sMaKhachHang = @MaKhachHang) 
       begin
	   -- Cập nhật thông tin khách hàng
        UPDATE tblKhachHang
        SET
            sTenKhachHang = @TenMoi,
            sDiaChi =@DiaChiMoi,
            sSDT = @SDTMoi
        WHERE sMaKhachHang = @MaKhachHang;
       print N'Thông tin khách hàng đã được cập nhật thành công!' 
	   end
	  else
       print N'Mã khách hàng không tồn tại' 
	  
END 
exec CapNhatThongTinKhachHang @Makhachhang='KH01', @TenMoi=N'Hải',@DiaChiMoi=N'Hà Nội',@SDTMoi='0982928123'
select*from tblKhachHang
