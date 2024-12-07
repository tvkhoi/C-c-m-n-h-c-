use ThucHanhSQL_NguyenCongDuc_1810A01

-------------Bài 5.1
--------a
create login Capnhat
with password ='111111'
--------b
create user Test01 for login Capnhat
Use ThucHanhSQL_NguyenCongDuc_1810A01
Grant insert, update, delete on tblNhanVien to Test01
--------c
select * from tblNhanVien
insert into tblNhanVien
values(10,N'Hoàng',N'Kim Mã','0192929992','09/01/2000','09/09/2019',3000,200,'030500012462')

delete tblNhanVien where iMaNV = 10

-------------Bài 5.2
----------a
create login Capnhat1
with password= '222222'
create user BanHang for login Capnhat1
Grant insert on tblDonDatHang to BanHang
Grant insert on tblChiTietDatHang to BanHang

----------b
create login Capnhat2
with password= '333333'
create user ThuTuc for login Capnhat2

Grant all on sp_không_bán_được to ThuTuc
Grant all on tăng_lương_cb to ThuTuc
Grant all on tong_bansp to ThuTuc
Grant all on TSLHang_MotMH to ThuTuc
Grant all on Tongtienhangthuduoc to ThuTuc
---------c
Grant select on tblMatHang to ThuTuc

---------Bài 5.3
------a
create login U1
with password= 'a1b2c3'
------b
create user Test02 for login U1
--------c
Grant all on tblKhachHang to Test02
--------d
create role BPNhapHang

Grant insert, select on tblNhaCungCap to BPNhapHang
Grant insert, select on tbllDonNhapHang to BPNhapHang
Grant insert, select on tblChiTietNhapHang to BPNhapHang
Grant select on tblNhanVien to BPNhapHang
Grant select on tblMatHang to BPNhapHang
----cấm 
REVOKE insert, update, delete on tblKhachHang FROM BPNhapHang;
Deny insert,update,delete on tblKhachHang to BPNhapHang;

-----------e
exec sp_addrolemember 'BPNhapHang','Test02';

insert into tblDonnhaphang 
values
(4,3,'2017-10-15'),
(5,2,'2017-09-29'),
(6,1,'2016-08-22');
insert into tblKhachHang 
values (12,N'Lê Văn Hùng',N'Nam Định',0899856222,1,2222);

--thêm khách hàng bất kì
create login NguyenCongDuc
with password= '012345'
create user NguyenCongDuc
 for login NguyenCongDuc
grant all to NguyenCongDuc