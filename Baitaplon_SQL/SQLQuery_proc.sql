--8. proc thêm 1 bản ghi chi tiết hóa đơn nhập hàng
	go
		create proc insertChiTietHDNH
		@iSoHDNH int,
		@sMaSach varchar(15),
		@fSoLuongNhap float,
		@fGiaNhap float
		as
		begin
			if exists (select * from tblHoaDonNhapHang where @iSoHDNH = iSoHDNH)
				begin
					if (not exists (select * from tblChiTietHDNhapHang where sMaSach = @sMaSach and iSoHDNH = @iSoHDNH))
						begin
							if((@fSoLuongNhap > 0 and @fGiaNhap > 0 ))
								begin
									insert tblChiTietHDNhapHang
									values(@iSoHDNH,@sMaSach,@fSoLuongNhap,@fGiaNhap)
									select * from tblChiTietHDNhapHang
								end
							else print(N'Số lượng phải > 0 và đơn giá phải > 0')
						end
					else print(N'Mã sách này đã tồn tại trong chi tiết hd nhập hàng')
				end
			else print(N'iSoHDMH chưa tồn tại')
		end
		-- thực thi proc insertChiTietHDNH
		exec insertChiTietHDNH 1,'Sach02',10,20000
--9. Proc xóa chi tiết hd nhập hàng với mã sách và iSoHDNH được truyền vào 
	go
		create proc XoaChiTietHDNH
		@isohdnh int,
		@smasach varchar(15)
		as
		begin
			delete from tblChiTietHDNhapHang 
			where iSoHDNH = @isohdnh and sMaSach = @smasach
			select * from tblChiTietHDNhapHang
		end
		-- thực thi proc XoaChiTietHD
		select * from tblChiTietHDNhapHang
		exec XoaChiTietHDNH 1 ,'Sach02'
--10. Proc sửa đổi số lượng và giá bán của bảng chi tiết hóa đơn nhập hàng với tham số truyền vào là iSoHDNH ,sMaSach
--, số lượng mới và giá bán mới iSoHDNH và sMaSach và số lượng mới 
    go
		create proc SuaDoi_SL_GB_ChiTietHDNH
		@isohdnh int,
		@smasach varchar(15),
		@fsoluongnhap float,
		@fgianhap float
		as
		begin 
			if((@fsoluongnhap > 0 and @fgianhap > 0) )
			begin
			update tblChiTietHDNhapHang
			set fSoLuongNhap = @fsoluongnhap , fGiaNhap = @fgianhap
			where iSoHDNH = @isohdnh and sMaSach = @smasach
			select * from tblChiTietHDNhapHang
			end
			else begin print(N'Vui lòng nhập lại số lượng và giá bán phải > 0') end
		end
		-- thực thi proc SuaDoi_SL_GB_ChiTietHDNH
		select * from tblChiTietHDNhapHang
		exec SuaDoi_SL_GB_ChiTietHDNH 1, 'Sach01',10,1000
--11. Proc thêm 1 bản ghi sách  
	go
		create proc insertSach
		@sMaSach varchar(15),
		@sTenSach nvarchar(50),
		@sMaNXB varchar(15),
        @sMaTacGia varchar(15),
        @sMaLoaiSach varchar(15),
        @fSoLuong float,
        @fGiaBan float,
        @sDonViTinh varchar(5)
		as
		begin
			if not exists (select * from tblSach where sMaSach = @sMaSach)
				begin
					if exists ((select * from tblNhaXuatBan,tblTacGia,tblTheLoaiSach
					where sMaNXB = @sMaNXB and sMaLoaiSach = @sMaLoaiSach and sMaTacGia = @sMaTacGia ))
					 begin
						 if ((@fSoLuong >= 0 and @fGiaBan > 0 ))
						 begin
					   		insert into tblSach
							values(@sMaSach,@sTenSach,@sMaNXB,@sMaTacGia,@sMaLoaiSach,@fSoLuong,@fGiaBan,@sDonViTinh)
							select * from tblSach
						 end
						 else print(N'Số lượng >=0 và giá bán phải > 0')			
					 end
					 else print(N'Kiểm tra xem mã NXB, mã TG, mã loại sách có tồn tại ko') 
				end
			else print(N'Mã sách này đã tồn tại')
		end
		-- thực thi proc insertSach
		exec insertSach 'Sach030',N'Dế mèn phiêu lưu ký 2','NXB01','TG01','TL01',10,1000,'VND'
--12. Proc thêm 1 bản ghi chi tiết hóa đơn mua hàng 
	go
		create or alter proc insertChiTietHDMH
		@iSoHDMH int,
		@sMaSach varchar(15),
		@fDonGia float,
		@fSoLuong float,
		@fGiamGia float
		as
		begin
			if exists (select * from tblHoaDonMuaHang where @iSoHDMH = iSoHDMH)
				begin
					if (not exists (select * from tblChiTietHDMuaHang where sMaSach = @sMaSach and iSoHDMH = @iSoHDMH))
						begin
							if((@fSoLuong > 0 and @fDonGia > 0 ))
								begin
									insert tblChiTietHDMuaHang
									values(@iSoHDMH,@sMaSach,@fDonGia,@fSoLuong,@fGiamGia)
									select * from tblChiTietHDMuaHang
								end
							else print(N'Số lượng phải > 0 và đơn giá phải > 0')
						end
					else print(N'Mã sách này đã tồn tại trong chi tiết hd mua hàng')
				end
			else print(N'iSoHDMH chưa tồn tại')
		end
		-- thực thi proc insertChiTietHDMH
		exec insertChiTietHDMH 1,Sach02,12000,2,0
--13. Proc cho biết nhân viên nào bán được nhiều (sách) nhất trong năm được nhập từ bàn phím 
	go
		create or alter proc NhanVienBanNhieuSach_theo_nam
		@nam date
		as
		begin
			select top 1  tblNhanVien.sMaNhanVien as[Mã nhân viên],sTenNhanVien as[Tên nhân viên]
			,sum([dbo].[tblChiTietHDMuaHang].[fSoLuong]) as[Số lượng sách đã bán]
			from tblNhanVien ,tblChiTietHDMuaHang,tblHoaDonMuaHang
			where (year(tblHoaDonMuaHang.dNgayMuaHang) = year(@nam)) and
			tblChiTietHDMuaHang.iSoHDMH = tblHoaDonMuaHang.iSoHDMH and
			tblHoaDonMuaHang.sMaNhanVien = tblNhanVien.sMaNhanVien
			group by tblNhanVien.sMaNhanVien , tblNhanVien.sTenNhanVien
			Order by sum([dbo].[tblChiTietHDMuaHang].[fSoLuong]) desc
		end 
		-- thực thi proc NhanVienBanNhieuSach_theo_nam
		exec NhanVienBanNhieuSach_theo_nam '2023'
--14. Proc thống kê số lượng nhân viên sinh năm nhập từ bàn phím
	go
		create proc ThongKeSoLuongNhanVien_SN
		@nam date
		as
		begin
			select tblNhanVien.sMaNhanVien as [Mã nhân viên], tblNhanVien.sTenNhanVien as [Tên nhân viên] , tblNhanVien.dNgaySinh as[Ngày sinh] from tblNhanVien
			where year(tblNhanVien.dNgaySinh) = year(@nam)
		end
		-- thực thi proc ThongKeSoLuongNhanVien_SN
		exec ThongKeSoLuongNhanVien_SN '2002'