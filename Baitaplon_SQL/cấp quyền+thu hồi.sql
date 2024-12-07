--cấp quyền cho người dùng nguyenthimybinh quyền select,insert,update trên bảng tblKhachHang
grant select, insert,update
on tblKhachhang
to nguyenthimybinh
--cấp quyền cho người dùng nguyenthietdo quyền xem, tạo bảng, thủ tục,khung nhìn trên bảng tblNhanVien
grant select,create table,create proc,create view
on tblNhanVien
to nguyenthietdo

--cấp quyền cho người dùng tranvankhoi quyền delete, execute trên bảng tblTacGia
grant delete ,execute
on tblTacGia
to tranvankhoi
--cấp quyên cho người dùng tranvanhailam quyền thực thi tất cả trên bảng tblSach
grant all privileges
on tblsach
to tranvanhailam
--cấp quyền cho người dùng doducquy quyền select,update trên cột mã,tên,SĐT,Địa chỉ của bảng tblNhanVien và chuyển tiếp cho người dùng khác
grant select, update
on tblNhanVien(sMaNhanVien,sTenNhanVien,sDiaChi,sSDT)
to doducquy
with grant option

--Thu hồi quyền select của người dùng nguyenthimybinh
revoke select
on tblnhanvien
to nguyenthimybinh
--thu hồi quyền xem của người dùng nguyenthietdo
revoke select
on tblNhanvien
to nguyenthietdo
--thu hồi quyền delete của người dùng tranvankhoi
revoke delete 
on tblTacGia
to tranvankhoi
--thu hồi quyền insert, update của người dùng tranvanhailam
revoke insert,update
on tblsach
to tranvanhailam
--thu hồi quyền xem cột mã nhân viên của người dùng doducquy
revoke select
on tblNhanvien(sMaNhanVien)
to doducquy
cascade