----BAI 3.1
--a
SELECT * FROM tblMatHang
WHERE fSoluong < 100

--b
CREATE VIEW vwSoMatHang
AS
SELECT sTenloaihang, sum(fSoluong) as 'SoLuong'
FROM tblMatHang, tblLoaiHang
WHERE tblLoaiHang.sMaloaihang = tblMatHang.sMaloaihang
GROUP BY sTenloaihang

select * from vwSoMatHang

--c
select * from tblChiTietDatHang

SELECT iSoHD, SUM(fGiaban*fSoluongmua- fMucgiamgia) AS 'Số tiền'
FROM tblChiTietDatHang
GROUP BY iSoHD

--d
SELECT * FROM tblDonDatHang

SELECT MONTH(dNgaydathang) AS 'Tháng', SUM(fGiaban*fSoluongmua- fMucgiamgia) AS 'Số tiền'
FROM tblChiTietDatHang, tblDonDatHang
WHERE YEAR(dNgaydathang) = 2016
GROUP BY MONTH(dNgaydathang)

--e
select * from tblMatHang
select * from tblChiTietDatHang
select * from tblDonDatHang

SELECT tblChiTietDatHang.sMahang, sTenhang
FROM tblMatHang, tblChiTietDatHang, tblDonDatHang
WHERE tblMatHang.sMahang = tblChiTietDatHang.sMahang AND tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD 
AND YEAR(dNgaydathang) = 2016
GROUP BY tblChiTietDatHang.sMahang, sTenhang
HAVING COUNT(tblChiTietDatHang.sMahang) = 1 


---BAI 3.2
--a
CREATE VIEW vwTong
AS
SELECT tblChiTietNhapHang.iSoHD, SUM(fGianhap*fSoluongnhap) AS 'Tổng tiền', COUNT(sMahang) AS 'Tổng số mặt hàng' 
FROM tblChiTietNhapHang inner join tblDonNhapHang on tblChiTietNhapHang.iSoHD = tblDonNhapHang.iSoHD
GROUP BY tblChiTietNhapHang.iSoHD

--b
SELECT sTenhang
FROM tblMatHang
WHERE sTenhang NOT IN
(
SELECT sTenhang
FROM (tblMatHang left join tblChiTietNhapHang ON tblChiTietNhapHang.sMahang = tblMatHang.sMahang) left join 
tblDonNhapHang on tblDonNhapHang.iSoHD = tblChiTietNhapHang.iSoHD
WHERE MONTH(dNgaynhaphang) = 6 AND YEAR(dNgaynhaphang) = 2017
GROUP BY tblMatHang.sTenhang
)

--c
SELECT sTenNhaCC
FROM (tblMatHang inner join tblLoaiHang on tblMatHang.sMaloaihang = tblLoaiHang.sMaloaihang) inner join tblNhaCungCap
on tblNhaCungCap.iMaNCC = tblMatHang.iMaNCC
WHERE sTenloaihang = N'Thời trang'
GROUP BY sTenNhaCC

--d
CREATE VIEW vwSoluongban2016
AS
SELECT sTenloaihang AS 'Tên loại hàng', sum(fSoluongmua) AS 'Số lượng đã bán'
FROM tblMatHang, tblDonDatHang, tblChiTietDatHang, tblLoaiHang
WHERE dNgaygiaohang IS NOT NULL AND YEAR(dNgaydathang) = 2016 AND tblChiTietDatHang.iSoHD = tblDonDatHang.iSoHD
AND tblMatHang.sMahang = tblChiTietDatHang.sMahang AND tblLoaiHang.sMaloaihang = tblMatHang.sMaloaihang
GROUP BY sTenloaihang

--e
SELECT tblNhanVien.iMaNV AS 'Mã nhân viên', sTenNV AS 'Tên nhân viên', 
SUM(fSoluongmua*fGiaban-fMucgiamgia) AS 'Số tiền hàng đã bán'
FROM tblNhanVien left join (tblDonDatHang left join tblChiTietDatHang 
on tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD)
on tblNhanVien.iMaNV = tblDonDatHang.iMaNV
WHERE YEAR(dNgaydathang) = 2016 AND dNgaygiaohang IS NOT NULL
GROUP BY tblNhanVien.iMaNV, sTenNV


------BAI 3.3
--a
SELECT tblKhachHang.iMaKH as 'Mã khách hàng', sTenKH as 'Tên khách hàng'
FROM tblKhachHang
WHERE bGioitinh = 0 AND iMaKH NOT IN
(
SELECT tblKhachHang.iMaKH
FROM tblKhachHang inner join tblDonDatHang on tblDonDatHang.iMaKH = tblKhachHang.iMaKH
GROUP BY tblKhachHang.iMaKH
)

--b
SELECT sTenhang, tblMatHang.sMahang, (CASE WHEN SUM(tblChiTietDatHang.fSoluongmua) > 0 THEN SUM(tblChiTietDatHang.fSoluongmua)
ELSE 0 END)  AS 'Số lượng đặt hàng'
FROM (tblMatHang left join tblLoaiHang on tblMatHang.sMaloaihang = tblLoaiHang.sMaloaihang) left join tblChiTietDatHang 
on tblChiTietDatHang.sMahang = tblMatHang.sMahang
WHERE sTenloaihang = N'Thời trang' AND tblMatHang.sMaloaihang = tblLoaiHang.sMaloaihang
GROUP BY sTenhang, tblMatHang.sMahang

--c
SELECT tblKhachHang.iMaKH, sTenKH, (CASE WHEN SUM(fGiaban*fSoluongmua-fMucgiamgia) > 0 THEN SUM(fGiaban*fSoluongmua-fMucgiamgia) ELSE 0 END)
AS 'Tổng tiền đặt hàng'
FROM tblKhachHang left join (tblChiTietDatHang left join tblDonDatHang on tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD)
on tblKhachHang.iMaKH = tblDonDatHang.iMaKH
WHERE bGioitinh = 1
GROUP BY tblKhachHang.iMaKH, sTenKH

--d
CREATE VIEW vwGiotinh
AS
SELECT (CASE WHEN bGioitinh= 1 THEN N'Nam' ELSE N'Nữ' END) as 'Giới tính' ,COUNT(bGioitinh) AS 'Số lượng khách hàng'
FROM tblKhachHang
GROUP BY bGioitinh

--e
CREATE VIEW vwTop3KhachhangMua
AS
SELECT TOP(3)
tblKhachHang.iMaKH, sTenKH, COUNT(tblDonDatHang.iMaKH) AS N'Số lần mua'
FROM tblKhachHang, tblDonDatHang, tblChiTietDatHang
WHERE tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD AND tblKhachHang.iMaKH = tblDonDatHang.iMaKH
GROUP BY tblKhachHang.iMaKH, sTenKH
ORDER BY COUNT(tblDonDatHang.iMaKH) DESC

--f
CREATE VIEW vwDsMHvsGiaTB
AS
SELECT tblMatHang.sMahang, sTenhang, AVG(fGiahang) AS 'Giá TB' 
FROM tblMatHang, tblChiTietDatHang
WHERE tblMatHang.sMahang = tblChiTietDatHang.sMahang
GROUP BY tblMatHang.sMahang, sTenhang 

--g
UPDATE tblMatHang
SET fGiaHang = fGiaHang * 1.1
FROM dbo.tblChiTietDatHang, dbo.tblDonDatHang, dbo.tblKhachHang
WHERE (fGiaHang) IN
(
SELECT MAX(fGiaHang)
FROM dbo.tblChiTietDatHang, dbo.tblDonDatHang, dbo.tblmatHang, dbo.tblKhachHang
WHERE DATEDIFF(DAY,dbo.tblDonDatHang.dNgayDatHang, GETDATE()) <= 30 
AND tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD
AND tblDonDatHang.iMaKH = tblKhachHang.iMaKH
AND tblChiTietDatHang.sMaHang = tblmatHang.sMaHang
AND dNgaygiaohang IS NOT NULL
GROUP BY tblChiTietDatHang.sMahang
)

select * from tblDonDatHang
select * from tblChiTietDatHang
select * from tblMatHang
