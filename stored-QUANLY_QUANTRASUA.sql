﻿CREATE PROC TAIKHOAN_DANGNHAP(
	@TENDANGNHAP VARCHAR(50),
	@MATKHAU VARCHAR(50)
)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE TENDANGNHAP=@TENDANGNHAP AND MATKHAU= @MATKHAU
END


CREATE PROC TAIKHOAN_DOIMK(
	@TENDANGNHAP VARCHAR(50),
	@MATKHAU VARCHAR(50)
)
AS
BEGIN
	UPDATE TAIKHOAN SET MATKHAU=@MATKHAU WHERE TENDANGNHAP=@TENDANGNHAP
END



CREATE PROC TAIKHOAN_SELECTALL
AS
BEGIN
	SELECT TENCHUTAIKHOAN,TENDANGNHAP,QUYEN FROM TAIKHOAN
END



CREATE PROC 

(
	@TENCHUTAIKHOAN NVARCHAR(50)
)
AS
BEGIN
	SELECT TENCHUTAIKHOAN,TENDANGNHAP,QUYEN FROM TAIKHOAN WHERE TENCHUTAIKHOAN=@TENCHUTAIKHOAN
END


CREATE PROC TAIKHOAN_INSERT(
	@TENDN VARCHAR(100),
	@MK VARCHAR(50),
	@TENCHUTK NVARCHAR(200),
	@QUYEN INT
)
AS
BEGIN
	DECLARE @KTTENDN INT= (SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP=@TENDN)
	IF(@KTTENDN > 0)
		SELECT N'Tên đăng nhập đã tồn tại !'
	ELSE
		INSERT INTO TAIKHOAN VALUES(@TENDN,@MK,@TENCHUTK,@QUYEN)
		SELECT N'Thêm tài khoản thành công !'
END


CREATE PROC TAIKHOAN_DELETE(
	@TENDN VARCHAR(100)
)
AS
BEGIN
	DECLARE @KTQUYEN INT = (SELECT QUYEN FROM TAIKHOAN WHERE TENDANGNHAP = @TENDN)
	DECLARE @KT INT = (SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP = @TENDN)
	IF(@KT = 0)
	BEGIN
		SELECT N'Tên đăng nhập không tồn tại'
	END
	ELSE IF(@KTQUYEN != 0)
	BEGIN
		SELECT N'Không thể xóa được tài khoản quản trị'
	END
	ELSE
	BEGIN
		DELETE FROM TAIKHOAN WHERE TENDANGNHAP=@TENDN
		SELECT N'Xóa tài khoản thành công !'
	END
END

-------------------------------------------------------------------------------------------


CREATE PROC LOAISANPHAM_SELECT
AS
BEGIN
	SELECT MALOAISP,TENLOAISP FROM LOAISANPHAM
END


CREATE PROC LOAISANPHAM_SELECTMA(
	@MALOAISP VARCHAR(50)
)
AS
BEGIN
	SELECT MALOAISP,TENLOAISP FROM LOAISANPHAM WHERE MALOAISP=@MALOAISP
END



CREATE PROC LOAISANPHAM_INSERT(
	@MALOAISP VARCHAR(50),
	@TENLOAISP NVARCHAR(200)
)
AS
BEGIN
	DECLARE @KTML INT = (SELECT COUNT(*) FROM LOAISANPHAM WHERE MALOAISP=@MALOAISP)
	DECLARE @KTTL INT = (SELECT COUNT(*) FROM LOAISANPHAM WHERE TENLOAISP=@TENLOAISP)
	IF(@KTML > 0)
	BEGIN
		SELECT N'Mã loại sản phẩm đã tồn tại'
	END
	ELSE IF(@KTTL > 0)
	BEGIN
		SELECT N'Tên loại sản phẩm đã tồn tại'
	END
	ELSE
	BEGIN
		INSERT INTO LOAISANPHAM VALUES(@MALOAISP,@TENLOAISP)
		SELECT N'Thêm loại sản phẩm thành công !'
	END
END


CREATE PROC LOAISANPHAM_DELETE(
	@MALOAISP VARCHAR(50)
)
AS
BEGIN
	DECLARE @KTML INT = (SELECT COUNT(*) FROM LOAISANPHAM WHERE MALOAISP=@MALOAISP)
	IF(@KTML > 0)
	BEGIN
		DELETE FROM LOAISANPHAM WHERE MALOAISP='TX'
		SELECT N'Xóa loại sản phẩm thành công !'
	END
	ELSE
	BEGIN
		SELECT N'Không tồn tại loại sản phẩm !'
	END
END


--------------------------------------------------------------------------------------------


CREATE PROC SANPHAM_SELECTMALOAI(
	@MALOAISP VARCHAR(50)
)
AS
BEGIN
	SELECT LOAISANPHAM.MALOAISP,TENLOAISP ,MASANPHAM,TENSANPHAM,GIA,THONGTIN
	FROM SANPHAM,LOAISANPHAM WHERE SANPHAM.MALOAISP=LOAISANPHAM.MALOAISP AND LOAISANPHAM.MALOAISP = @MALOAISP
END 

		--SELECT LOAISANPHAM.MALOAISP,TENLOAISP ,MASANPHAM,TENSANPHAM,GIA,THONGTIN
		--FROM SANPHAM,LOAISANPHAM WHERE SANPHAM.MALOAISP=LOAISANPHAM.MALOAISP AND LOAISANPHAM.MALOAISP = 'Aa'


CREATE PROC SANPHAM_SELECTMA(
	@MASANPHAM VARCHAR(50)
)
AS
BEGIN
	SELECT LOAISANPHAM.MALOAISP,TENLOAISP ,MASANPHAM,TENSANPHAM,GIA,THONGTIN
	FROM SANPHAM,LOAISANPHAM WHERE SANPHAM.MALOAISP=LOAISANPHAM.MALOAISP AND MASANPHAM=@MASANPHAM
END


CREATE PROC SANPHAM_SELECT
AS
BEGIN
	SELECT LOAISANPHAM.MALOAISP,TENLOAISP,MASANPHAM,TENSANPHAM,GIA,THONGTIN FROM SANPHAM,LOAISANPHAM 
	WHERE LOAISANPHAM.MALOAISP = SANPHAM.MALOAISP ORDER BY TENLOAISP
END


CREATE PROC SANPHAM_INSERT(
	@MASANPHAM VARCHAR(50),
	@TENSANPHAM NVARCHAR(200),
	@GIA FLOAT,
	@THONGTIN NVARCHAR(MAX),
	@MALOAISP VARCHAR(50)
)
AS
BEGIN
	DECLARE @KTMSP INT = (SELECT COUNT(*) FROM SANPHAM WHERE MASANPHAM=@MASANPHAM)
	DECLARE @KTTSP INT = (SELECT COUNT(*) FROM SANPHAM WHERE TENSANPHAM=@TENSANPHAM)
	IF(@KTMSP  > 0)
	BEGIN
		SELECT N'Mã sản phẩm đã tồn tại !'
	END
	ELSE IF(@KTTSP > 0)
	BEGIN
		SELECT N'Tên sản phẩm đã tồn tại !'
	END
	ELSE
	BEGIN
		INSERT INTO SANPHAM VALUES (@MASANPHAM,@TENSANPHAM,@GIA,@THONGTIN,@MALOAISP)
		SELECT N'Thêm sản phẩm thành công !'
	END
END


CREATE PROC SANPHAM_UPDATE(
	@MASANPHAM VARCHAR(50),
	@GIA FLOAT,
	@THONGTIN NVARCHAR(MAX)
)
AS
BEGIN
		UPDATE SANPHAM SET GIA=@GIA, THONGTIN = @THONGTIN
		WHERE MASANPHAM=@MASANPHAM
		SELECT N'Sửa thông tin sản phẩm thành công !'
END


CREATE PROC SANPHAM_DELETE(
	@MASANPHAM VARCHAR(50)
)
AS
BEGIN
	DELETE FROM SANPHAM WHERE MASANPHAM=@MASANPHAM
	SELECT N'Xóa thông tin sản phẩm thành công !'
END


-------------------------------------------------------------------------------------------------


CREATE PROC HOADON_INSERT(
	@TENDANGNHAP VARCHAR(100),
	@MAKHACHHANG VARCHAR(50)
)
AS
BEGIN
	DECLARE @KTHOADON INT = (SELECT COUNT(*) FROM HOADON)
	DECLARE @TONGTIEN INT = (SELECT TOP 1 TONGTIEN FROM HOADON ORDER BY MAHOADON DESC)
	IF(@KTHOADON = 0)
	BEGIN
		IF(@MAKHACHHANG = 'NULL')
			INSERT INTO HOADON(TENDANGNHAP,MAKHACHHANG) VALUES (@TENDANGNHAP,NULL)
		ELSE
			INSERT INTO HOADON(TENDANGNHAP,MAKHACHHANG) VALUES (@TENDANGNHAP,@MAKHACHHANG)
	END
	ELSE
	BEGIN
		IF(@TONGTIEN != '')
		BEGIN
			IF(@MAKHACHHANG = 'NULL')
				INSERT INTO HOADON(TENDANGNHAP,MAKHACHHANG) VALUES (@TENDANGNHAP,NULL)
			ELSE
				INSERT INTO HOADON(TENDANGNHAP,MAKHACHHANG) VALUES (@TENDANGNHAP,@MAKHACHHANG)
		END
	END
END


CREATE PROC HOADON_UPDATE(
	@TONGTIEN FLOAT,
	@GIAMGIA FLOAT,
	@PHIVANCHUYEN FLOAT,
	@THANHTOAN FLOAT,
	@KHACHDUA FLOAT,
	@TIENTHUA FLOAT
)
AS
BEGIN
	DECLARE @MAHOADON INT = (SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC)
	UPDATE HOADON 
	SET TONGTIEN=@TONGTIEN , GIAMGIA=@GIAMGIA , PHIVANCHUYEN=@PHIVANCHUYEN , THANHTOAN=@THANHTOAN ,
	KHACHDUA=@KHACHDUA , TIENTHUA=@TIENTHUA , THOIGIAN=GETDATE()
	WHERE MAHOADON=@MAHOADON
END


CREATE PROC HOADON_SELECTIN
AS
BEGIN
	DECLARE @MAHOADON INT = (SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC)
	DECLARE @KT INT = (SELECT COUNT(*)
		FROM HOADON,TAIKHOAN,KHACHHANG
		WHERE HOADON.TENDANGNHAP = TAIKHOAN.TENDANGNHAP AND KHACHHANG.MAKHACHHANG = HOADON.MAKHACHHANG 
		AND MAHOADON=(SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC))
	IF(@KT = 0)
	BEGIN
		SELECT MAHOADON,TENCHUTAIKHOAN,N'(Không có)' AS'TENKHACHHANG',TONGTIEN,GIAMGIA,PHIVANCHUYEN,THANHTOAN,KHACHDUA,TIENTHUA,THOIGIAN
		FROM HOADON,TAIKHOAN
		WHERE HOADON.TENDANGNHAP = TAIKHOAN.TENDANGNHAP
		AND MAHOADON=@MAHOADON
	END
	ELSE
	BEGIN
		SELECT MAHOADON,TENCHUTAIKHOAN,TENKHACHHANG,TONGTIEN,GIAMGIA,PHIVANCHUYEN,THANHTOAN,KHACHDUA,TIENTHUA,THOIGIAN
		FROM HOADON,TAIKHOAN,KHACHHANG
		WHERE HOADON.TENDANGNHAP = TAIKHOAN.TENDANGNHAP AND KHACHHANG.MAKHACHHANG = HOADON.MAKHACHHANG 
		AND MAHOADON=@MAHOADON
	END
END



--SELECT TENCHUTAIKHOAN ,SUM(TONGTIEN) AS N'TONGTIEN',SUM(GIAMGIA) AS N'GIAMGIA', SUM(PHIVANCHUYEN) AS PHIVANCHUYEN,
--SUM(THANHTOAN) AS SOHOADON,COUNT(MAHOADON) AS THANHTOAN,MIN(THOIGIAN) AS 'THOIGIANBD', GETDATE() AS 'THOIGIANKT'
--FROM HOADON,TAIKHOAN 
--WHERE HOADON.TENDANGNHAP = 'admin' AND TAIKHOAN.TENDANGNHAP=HOADON.TENDANGNHAP 
--AND CONVERT(DATE,THOIGIAN,102) = CONVERT(DATE,GETDATE(),102) 
--GROUP BY TENCHUTAIKHOAN



CREATE PROC HOADON_KTKHOASO(
	@TENDANGNHAP VARCHAR(100)
)
AS
BEGIN
	SELECT MAHOADON FROM HOADON WHERE CONVERT(DATE,THOIGIAN,102) = CONVERT(DATE,GETDATE(),102) 
	AND TENDANGNHAP = @TENDANGNHAP GROUP BY MAHOADON
END




CREATE PROC HOADON_KHOASO(
	@TENDANGNHAP VARCHAR(100)
)
AS
BEGIN
	DECLARE @MADOANHTHU INT = (SELECT COUNT(*) FROM DOANHTHU 
	WHERE CONVERT(DATE,THOIGIANKT,102) = CONVERT(DATE,GETDATE(),102) AND TENDANGNHAP = @TENDANGNHAP)
	IF(@MADOANHTHU = 0)
	BEGIN
		SELECT TENCHUTAIKHOAN ,SUM(TONGTIEN) AS N'TONGTIEN',SUM(GIAMGIA) AS N'GIAMGIA', SUM(PHIVANCHUYEN) AS 'PHIVANCHUYEN',
		COUNT(MAHOADON) AS SOHOADON,SUM(THANHTOAN) AS 'THANHTOAN',MIN(THOIGIAN) AS 'THOIGIANBD', GETDATE() AS 'THOIGIANKT'
		FROM HOADON,TAIKHOAN 
		WHERE TAIKHOAN.TENDANGNHAP = @TENDANGNHAP AND TAIKHOAN.TENDANGNHAP=HOADON.TENDANGNHAP 
		AND CONVERT(DATE,THOIGIAN,102) = CONVERT(DATE,GETDATE(),102) 
		GROUP BY TENCHUTAIKHOAN
	END
	ELSE
	BEGIN
		DECLARE @THOIGIANKT DATETIME = (SELECT MAX(THOIGIANKT) FROM DOANHTHU WHERE TENDANGNHAP=@TENDANGNHAP)
		SELECT TENCHUTAIKHOAN,SUM(TONGTIEN) AS 'TONGTIEN',SUM(GIAMGIA) AS 'GIAMGIA',SUM(PHIVANCHUYEN) AS 'PHIVANCHUYEN',
		COUNT(MAHOADON) AS 'SOHOADON',SUM(THANHTOAN) AS 'THANHTOAN', MIN(THOIGIAN) AS 'THOIGIANBD', GETDATE() AS 'THOIGIANKT'
		FROM TAIKHOAN,HOADON,DOANHTHU
		WHERE TAIKHOAN.TENDANGNHAP = HOADON.TENDANGNHAP AND DOANHTHU.TENDANGNHAP = TAIKHOAN.TENDANGNHAP 
		AND TAIKHOAN.TENDANGNHAP = @TENDANGNHAP
		AND THOIGIAN BETWEEN CAST(@THOIGIANKT AS DATETIME) AND CAST(GETDATE() AS DATETIME) 
		GROUP BY TAIKHOAN.TENCHUTAIKHOAN
	END
END




--------------------------------------------------------------------------------------------------



CREATE PROC CTHOADON_INSERT(
	@MASANPHAM VARCHAR(50),
	@DONGIA INT,
	@SOLUONG INT
)
AS
BEGIN
	DECLARE @MAHOADON INT = (SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC)
	INSERT INTO CTHOADON VALUES(@MAHOADON,@MASANPHAM,@DONGIA,@SOLUONG)
END


CREATE PROC CTHOADON_THANHTOAN(
	@MASANPHAM VARCHAR(50),
	@DONGIA INT,
	@SOLUONG INT
)
AS
BEGIN
	DECLARE @MAHOADON INT = (SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC)
	DECLARE @MACTHOADON INT = (SELECT TOP 1 MACTHOADON FROM CTHOADON WHERE MAHOADON=(SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC) ORDER BY MACTHOADON)
	IF(@MACTHOADON = '')
	BEGIN
		INSERT INTO CTHOADON VALUES(@MAHOADON,@MASANPHAM,@DONGIA,@SOLUONG)
	END
	ELSE
	BEGIN
		DELETE FROM CTHOADON WHERE MAHOADON=@MAHOADON
		INSERT INTO CTHOADON VALUES(@MAHOADON,@MASANPHAM,@DONGIA,@SOLUONG)
	END
END


CREATE PROC CTHOADON_DELETE
AS
BEGIN
	DECLARE @MAHOADON INT = (SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC)
	DECLARE @MACTHOADON INT = (SELECT TOP 1 MACTHOADON FROM CTHOADON WHERE MAHOADON=@MAHOADON)
	IF(@MACTHOADON != '')
	BEGIN
		DELETE FROM CTHOADON WHERE MAHOADON=@MAHOADON
	END
END


CREATE PROC CTHOADON_SELECTHD
AS
BEGIN
	DECLARE @MAHOADON INT = (SELECT TOP 1 MAHOADON FROM HOADON ORDER BY MAHOADON DESC)
	SELECT CTHOADON.MASANPHAM , TENSANPHAM , SOLUONG, GIA , (SOLUONG * GIA) AS 'THANHTIEN'
	FROM SANPHAM,CTHOADON
	WHERE SANPHAM.MASANPHAM = CTHOADON.MASANPHAM  AND MAHOADON=@MAHOADON
	GROUP BY CTHOADON.MASANPHAM, TENSANPHAM,SOLUONG,GIA	
	ORDER BY MASANPHAM DESC
END 



----------------------------------------------------------------------------------------------------------------------

CREATE PROC KHACHHANG_SELECT
AS
BEGIN 
	SELECT KHACHHANG.MAKHACHHANG,TENKHACHHANG,NGAYSINH,DIACHI,SDT,LOAIKHACHHANG,NGAYLAP,GHICHU, 
	(SELECT SUM(THANHTOAN) FROM HOADON WHERE MONTH(THOIGIAN)=MONTH(GETDATE()) AND MAKHACHHANG = KHACHHANG.MAKHACHHANG) AS'LUONGTIEN' 
	FROM KHACHHANG,HOADON GROUP BY KHACHHANG.MAKHACHHANG,TENKHACHHANG,NGAYSINH,DIACHI,SDT,LOAIKHACHHANG,NGAYLAP,GHICHU
END

SELECT KHACHHANG.MAKHACHHANG,TENKHACHHANG,NGAYSINH,SDT,LOAIKHACHHANG,NGAYLAP,GHICHU,DIACHI
	FROM KHACHHANG
	WHERE 
	GROUP BY KHACHHANG.MAKHACHHANG,TENKHACHHANG,NGAYSINH,SDT,LOAIKHACHHANG,NGAYLAP,GHICHU,DIACHI

CREATE PROC KHACHHANG_INSERT(
	@MAKHACHHANG VARCHAR(50),
	@TENKHACHHANG NVARCHAR(200),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(100),
	@SDT VARCHAR(50),
	@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	DECLARE @KTSDT INT = (SELECT COUNT(TENKHACHHANG) FROM KHACHHANG WHERE SDT=@SDT)
	DECLARE @KTMAKH INT = (SELECT COUNT(TENKHACHHANG) FROM KHACHHANG WHERE MAKHACHHANG=@MAKHACHHANG)
	IF(@KTSDT = 0)
	BEGIN
		IF(@KTMAKH = 0)
		BEGIN
			INSERT INTO KHACHHANG(MAKHACHHANG,TENKHACHHANG,NGAYSINH,DIACHI,SDT,LOAIKHACHHANG,NGAYLAP,GHICHU) VALUES(@MAKHACHHANG,@TENKHACHHANG,@NGAYSINH,@DIACHI,@SDT,N'Sơ cấp',CONVERT(DATE,GETDATE(),101),@GHICHU)
			SELECT N'Thêm khách hàng thành công'
		END
		ELSE
		BEGIN
			SELECT N'Mã khách hàng đã tồn tại'
		END
	END
	ELSE
	BEGIN
		SELECT N'Số điện thoại đã tồn tại'
	END
END


DROP PROC KHACHHANG_UPDATE

CREATE PROC KHACHHANG_UPDATE(
	@MAKHACHHANG VARCHAR(50),
	@TENKHACHHANG NVARCHAR(200),
	@NGAYSINH DATE,
	@DIACHI NVARCHAR(100),
	@SDT VARCHAR(50),
	@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	DECLARE @KTSDT INT = (SELECT COUNT(TENKHACHHANG) FROM KHACHHANG WHERE SDT=@SDT AND MAKHACHHANG != @MAKHACHHANG)
	DECLARE @KTMAKH INT = (SELECT COUNT(TENKHACHHANG) FROM KHACHHANG WHERE MAKHACHHANG=@MAKHACHHANG)
	IF(@KTSDT = 0)
	BEGIN
		UPDATE KHACHHANG SET TENKHACHHANG=@TENKHACHHANG , NGAYSINH=@NGAYSINH, DIACHI=@DIACHI, SDT=@SDT, GHICHU=@GHICHU
		WHERE MAKHACHHANG=@MAKHACHHANG
		SELECT '0'
	END
	ELSE
	BEGIN
		SELECT '1'
	END
END


DROP PROC KHACHHANG_SELECTSDT
CREATE PROC KHACHHANG_SELECTSDT(
	@SDT VARCHAR(50)
)
AS
BEGIN
	SELECT KHACHHANG.MAKHACHHANG,TENKHACHHANG,NGAYSINH,DIACHI,SDT,LOAIKHACHHANG,NGAYLAP,GHICHU, 
	(SELECT SUM(THANHTOAN) FROM HOADON WHERE MONTH(THOIGIAN)=MONTH(GETDATE()) AND MAKHACHHANG = KHACHHANG.MAKHACHHANG) AS'LUONGTIEN' 
	FROM KHACHHANG,HOADON WHERE SDT =@SDT
	GROUP BY KHACHHANG.MAKHACHHANG,TENKHACHHANG,NGAYSINH,DIACHI,SDT,LOAIKHACHHANG,NGAYLAP,GHICHU
END
BEGIN


CREATE PROC KHACHHANG_DELETE(
	@MAKHACHHANG VARCHAR(50)
)
AS
BEGIN
	DELETE FROM KHACHHANG WHERE MAKHACHHANG=@MAKHACHHANG
END



CREATE PROC KHACHHANG_CHAPNHAN(
	@MAKHACHHANG VARCHAR(50),
	@SDT VARCHAR(50)
)
AS
BEGIN
	IF(@MAKHACHHANG = NULL)
	BEGIN
		SELECT * FROM KHACHHANG WHERE SDT=@SDT
	END
	ELSE IF(@SDT = NULL)
	BEGIN
		SELECT * FROM KHACHHANG WHERE MAKHACHHANG=@MAKHACHHANG
	END
	ELSE
	BEGIN
		SELECT * FROM KHACHHANG WHERE SDT=@SDT
	END
END


CREATE PROC KHACHHANG_TANGHANGTC
AS
BEGIN
	DECLARE @MAKH VARCHAR(50) = (SELECT KHACHHANG.MAKHACHHANG FROM KHACHHANG,HOADON
									WHERE KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG AND MONTH(THOIGIAN) = MONTH(GETDATE())
									AND THANHTOAN > 1500000 AND LOAIKHACHHANG != N'Cao cấp'
									GROUP BY KHACHHANG.MAKHACHHANG)
	UPDATE KHACHHANG SET LOAIKHACHHANG=N'Trung cấp' WHERE MAKHACHHANG=@MAKH
END


DROP PROC KHACHHANG_TANGHANG
CREATE PROC KHACHHANG_TANGHANG(
	@MAKH VARCHAR(50)
)
AS
BEGIN
	DECLARE @THANHTOAN INT = (SELECT SUM(THANHTOAN) FROM KHACHHANG,HOADON WHERE KHACHHANG.MAKHACHHANG=HOADON.MAKHACHHANG 
	AND MONTH(THOIGIAN) = MONTH(GETDATE()) AND KHACHHANG.MAKHACHHANG=@MAKH)
	IF(@THANHTOAN > 1500000 AND @THANHTOAN < 3000000)
	BEGIN
		UPDATE KHACHHANG SET LOAIKHACHHANG=N'Trung cấp' WHERE MAKHACHHANG=@MAKH
	END
	ELSE IF(@THANHTOAN > 3000000)
	BEGIN
		UPDATE KHACHHANG SET LOAIKHACHHANG=N'Cao cấp' WHERE MAKHACHHANG=@MAKH
	END
END


----------------------------------------------------------------------------------------------------------------


CREATE PROC DOANHTHU_INSERT(
	@TENDANGNHAP VARCHAR(100),
	@TONGTIENBAN FLOAT,
	@TONGGIAMGIA FLOAT,
	@TONGVANCHUYEN FLOAT,
	@TONGHOADON INT,
	@TONGDOANHTHU FLOAT,
	@THOIGIANBD DATETIME,
	@THOIGIANKT DATETIME
)
AS
BEGIN
	INSERT INTO DOANHTHU 
	VALUES (@TENDANGNHAP,@TONGTIENBAN,@TONGGIAMGIA,@TONGVANCHUYEN,@TONGHOADON,@TONGDOANHTHU,@THOIGIANBD,@THOIGIANKT)
END



CREATE PROC DOANHTHU_KTCHUACHOT(
	@TENDANGNHAP VARCHAR(100)
)
AS
BEGIN
	DECLARE @KT INT = (SELECT COUNT(MAHOADON) FROM HOADON
	WHERE CONVERT(DATE,THOIGIAN,102) = CONVERT(DATE,GETDATE(),102) AND HOADON.TENDANGNHAP=@TENDANGNHAP)
	IF (@KT = 0)
	BEGIN
		SELECT '1'
	END
	ELSE
	BEGIN
		DECLARE @THOIGIAN DATETIME = (SELECT MAX(THOIGIAN) FROM HOADON 
		WHERE CONVERT(DATE,THOIGIAN,102) = CONVERT(DATE,GETDATE(),102) AND TENDANGNHAP=@TENDANGNHAP)
		SELECT * FROM DOANHTHU 
		WHERE THOIGIANKT BETWEEN CAST(@THOIGIAN AS DATETIME) AND CAST(GETDATE() AS DATETIME) AND TENDANGNHAP=@TENDANGNHAP
	END
END


	
	SELECT COUNT(*) FROM HOADON,DOANHTHU 
	WHERE HOADON.TENDANGNHAP= 'ABC' AND CONVERT(DATE,MAX(THOIGIAN),102) = CONVERT(DATE,GETDATE(),102)
	AND THOIGIAN BETWEEN CAST(MAX(THOIGIANKT) AS datetime) AND CAST(@THOIGIAN AS DATETIME)


	DECLARE @THOIGIAN DATETIME = (SELECT MAX(THOIGIAN) FROM HOADON 
	WHERE CONVERT(DATE,THOIGIAN,102) = CONVERT(DATE,GETDATE(),102) AND TENDANGNHAP='abc')
	SELECT * FROM DOANHTHU 
	WHERE THOIGIANKT BETWEEN CAST(@THOIGIAN AS DATETIME) AND CAST(GETDATE() AS DATETIME) AND TENDANGNHAP='abc'
----------------------------------------------------------------------------------------------------------------


CREATE PROC NGUYENLIEU_SELECTALL
AS
BEGIN
	SELECT TENNGUYENLIEU,DONVITINH,HANSUDUNG,TONKHO FROM NGUYENLIEU,CTNGUYENLIEU 
	WHERE NGUYENLIEU.MANGUYENLIEU=CTNGUYENLIEU.MANGUYENLIEU AND TONKHO != 0 ORDER BY HANSUDUNG
END


SELECT NGUYENLIEU.MANGUYENLIEU,TENNGUYENLIEU,(SELECT DONVITINH,HANSUDUNG,TONKHO FROM NGUYENLIEU,CTNGUYENLIEU 
											WHERE NGUYENLIEU.MANGUYENLIEU=CTNGUYENLIEU.MANGUYENLIEU)
FROM NGUYENLIEU 
	WHERE NGUYENLIEU.MANGUYENLIEU=CTNGUYENLIEU.MANGUYENLIEU



CREATE PROC NGUYENLIEU_SELECT
AS
BEGIN
	SELECT * FROM NGUYENLIEU
END

DROP PROC NGUYENLIEU_SELECTALLMA

CREATE PROC NGUYENLIEU_SELECTALLMA(
	@MANGUYENLIEU VARCHAR(50)
)
AS
BEGIN
	SELECT TENNGUYENLIEU,DONVITINH,HANSUDUNG,TONKHO FROM NGUYENLIEU,CTNGUYENLIEU 
	WHERE NGUYENLIEU.MANGUYENLIEU=CTNGUYENLIEU.MANGUYENLIEU AND NGUYENLIEU.MANGUYENLIEU=@MANGUYENLIEU AND TONKHO != 0 ORDER BY HANSUDUNG
END


CREATE PROC NGUYENLIEU_INSERT(
	@MANGUYENLIEU VARCHAR(50),
	@TENNGUYENLIEU NVARCHAR(200)
)
AS
BEGIN
	DECLARE @KTMNL INT = (SELECT COUNT(*) FROM NGUYENLIEU WHERE MANGUYENLIEU = @MANGUYENLIEU)
	DECLARE @KTTNL INT = (SELECT COUNT(*) FROM NGUYENLIEU WHERE TENNGUYENLIEU = @TENNGUYENLIEU)
	IF(@KTMNL > 0)
	BEGIN
		SELECT N'Mã nguyên liệu đã tồn tại'
	END
	ELSE IF(@KTTNL > 0)
	BEGIN
		SELECT N'Tên nguyên liệu đã tồn tại'
	END
	ELSE
	BEGIN
		INSERT INTO NGUYENLIEU VALUES(@MANGUYENLIEU,@TENNGUYENLIEU)
		SELECT N'Thêm nguyên liệu thành công !'
	END
END


CREATE PROC NGUYENLIEU_DELETE(
	@MANGUYENLIEU VARCHAR(50)
)
AS
BEGIN
	DECLARE @KTNL INT = (SELECT COUNT(*) FROM NGUYENLIEU,CTNGUYENLIEU WHERE NGUYENLIEU.MANGUYENLIEU=CTNGUYENLIEU.MANGUYENLIEU AND 
	NGUYENLIEU.MANGUYENLIEU = @MANGUYENLIEU) 
	IF(@KTNL > 0)
	BEGIN
		SELECT N'Đã tồn tại nguyên liệu trong kho, không thể xóa bỏ thông tin nguyên liệu'
	END
	ELSE
	BEGIN
		DELETE FROM NGUYENLIEU WHERE MANGUYENLIEU=@MANGUYENLIEU
		SELECT N'Xóa nguyên liệu thành công !'
	END
END



----------------------------------------------------------------------------------------------------------------


CREATE PROC CTNGUYENLIEU_DVT
AS
BEGIN
	SELECT DONVITINH FROM CTNGUYENLIEU GROUP BY DONVITINH
END


------------------------------------------------------------------------------------------------------------------
INSERT INTO NHAPNGUYENLIEU(NGAYNHAP,TONGTIEN) VALUES('2000-02-02','1')


--CREATE PROC NHAPNGUYENLIEU_INSERT(
--	@MANCC VARCHAR(50),
--	@NGAYNHAP DATE,
--	@TONGTIEN INT
--)
--AS
--BEGIN INSERT INTO NHAPNGUYENLIEU VALUES('3',getdate(),123)
--	INSERT INTO NHAPNGUYENLIEU VALUES(@MANCC,@NGAYNHAP,@TONGTIEN)
--	DECLARE @MANHAPNL INT = (SELECT TOP 1 MANHAPNL FROM NHAPNGUYENLIEU ORDER BY MANHAPNL DESC)
--	DELETE FROM CTNHAPNL WHERE MANHAPNL=@MANHAPNL
--END


DROP PROC NHAPNGUYENLIEU_INSERT
CREATE PROC NHAPNGUYENLIEU_INSERT(
	@MANCC VARCHAR(50),
	@TENDN VARCHAR(50),
	@NGAYNHAP DATE,
	@TONGTIEN INT
)
AS
BEGIN
	INSERT INTO NHAPNGUYENLIEU VALUES(@MANCC,@TENDN,@NGAYNHAP,@TONGTIEN)
END



CREATE PROC NHAPNGUYENLIEU_INHD
AS
BEGIN
	DECLARE @MANHAPNL INT = (SELECT TOP 1 MANHAPNL FROM NHAPNGUYENLIEU ORDER BY MANHAPNL DESC)
	SELECT MANHAPNL, TENNCC,TENCHUTAIKHOAN, NGAYNHAP,TONGTIEN FROM NHAPNGUYENLIEU,NHACUNGCAP,TAIKHOAN
	WHERE NHAPNGUYENLIEU.MANCC = NHACUNGCAP.MANCC AND MANHAPNL=@MANHAPNL 
	AND TAIKHOAN.TENDANGNHAP=NHAPNGUYENLIEU.TENDANGNHAP
END


CREATE PROC NHAPNGUYENLIEU_THONGKETHANG
AS
BEGIN
	SELECT MONTH(NGAYNHAP) AS N'Tháng',YEAR(NGAYNHAP) AS N'Năm', SUM(TONGTIEN) AS N'Tổng tiền' FROM NHAPNGUYENLIEU 
	GROUP BY MONTH(NGAYNHAP),YEAR(NGAYNHAP)
END


---------------------------------------------------------------------------------------------------------------
DROP PROC CTNHAPNL_INSERT


CREATE PROC CTNHAPNL_INSERT(
	@MANGUYENLIEU VARCHAR(50),
	@SOLUONG FLOAT,
	@DVT NVARCHAR(50),
	@HANSUDUNG DATE,
	@DONGIA INT
)
AS
BEGIN
	DECLARE @MANHAPNL INT = (SELECT TOP 1 MANHAPNL FROM NHAPNGUYENLIEU ORDER BY MANHAPNL DESC)
	INSERT INTO CTNHAPNL VALUES(@MANHAPNL,@MANGUYENLIEU,@SOLUONG,@DVT,CONVERT(VARCHAR(50),@HANSUDUNG,102),@DONGIA)
END


CREATE PROC CTNHAPNL_INHD
AS
BEGIN
	DECLARE @MANHAPNL INT = (SELECT TOP 1 MANHAPNL FROM NHAPNGUYENLIEU ORDER BY MANHAPNL DESC)
	SELECT CTNGUYENLIEU.MANGUYENLIEU, TENNGUYENLIEU,CTNHAPNL.DONVITINH, CONVERT(DATE,CTNHAPNL.HANSUDUNG,102) AS 'HANSUDUNG',SOLUONG, 
	DONGIA, SOLUONG*DONGIA AS 'THANHTIEN'  
	FROM CTNHAPNL,NGUYENLIEU,CTNGUYENLIEU
	WHERE NGUYENLIEU.MANGUYENLIEU=CTNHAPNL.MANGUYENLIEU AND NGUYENLIEU.MANGUYENLIEU=CTNGUYENLIEU.MANGUYENLIEU 
	AND MANHAPNL=@MANHAPNL 
	GROUP BY CTNGUYENLIEU.MANGUYENLIEU, TENNGUYENLIEU,CTNHAPNL.DONVITINH,CTNHAPNL.HANSUDUNG,SOLUONG,DONGIA
END
select * from CTNHAPNL where MANHAPNL='12'


CREATE PROC CTNHAPNL_INSERTNL(
	@MANL VARCHAR(50),
	@DVT NVARCHAR(50),
	@HSD DATE,
	@SOLUONG FLOAT
)
AS
BEGIN
	DECLARE @KT INT = (SELECT COUNT(*) FROM CTNGUYENLIEU WHERE MANGUYENLIEU=@MANL AND HANSUDUNG=@HSD AND DONVITINH=@DVT)
	IF(@KT > 0)
	BEGIN
		UPDATE CTNGUYENLIEU SET TONKHO=TONKHO + @SOLUONG WHERE MANGUYENLIEU=@MANL AND HANSUDUNG=@HSD AND DONVITINH=@DVT
	END
	ELSE
	BEGIN
		INSERT INTO CTNGUYENLIEU VALUES(@MANL,@DVT,@SOLUONG,@HSD)
	END
END


------------------------------------------------------------------------------------------------------------


CREATE PROC HUYNL_INSERT(
	@TENDN VARCHAR(50)
)
AS
BEGIN
	INSERT INTO HUYNL VALUES(@TENDN,CONVERT(DATE,GETDATE(),102))
END


CREATE PROC HUYNGUYENLIEU_INHD
AS
BEGIN
	DECLARE @MAHUYNL INT = (SELECT TOP 1 MAHUYNL FROM HUYNL ORDER BY MAHUYNL DESC)
	SELECT MAHUYNL, TENCHUTAIKHOAN, NGAYHUY FROM HUYNL,TAIKHOAN
	WHERE HUYNL.TENDANGNHAP=TAIKHOAN.TENDANGNHAP AND MAHUYNL=@MAHUYNL
END


------------------------------------------------------------------------------------------------------------


CREATE PROC CTHUYNL_INSERT(
	@TENNGUYENLIEU NVARCHAR(50),
	@DVT NVARCHAR(50),
	@SOLUONG FLOAT,
	@HANSUDUNG DATE,
	@LYDOHUY NVARCHAR(MAX)
)
AS
BEGIN
	DECLARE @MAHUYNL INT = (SELECT TOP 1 MAHUYNL FROM HUYNL ORDER BY MAHUYNL DESC)
	DECLARE @MANGUYENLIEU VARCHAR(50) = (SELECT MANGUYENLIEU FROM NGUYENLIEU WHERE TENNGUYENLIEU=@TENNGUYENLIEU)
	INSERT INTO CTHUYNL VALUES(@MAHUYNL,@MANGUYENLIEU,@DVT,@SOLUONG,CONVERT(VARCHAR(50),@HANSUDUNG,102),@LYDOHUY)
END


CREATE PROC CTHUYNL_INHD
AS
BEGIN
	DECLARE @MAHUYNL INT = (SELECT TOP 1 MAHUYNL FROM HUYNL ORDER BY MAHUYNL DESC)
	SELECT CTNGUYENLIEU.MANGUYENLIEU, TENNGUYENLIEU,CTHUYNL.DONVITINH,SOLUONG, CONVERT(DATE,CTHUYNL.HANSUDUNG,102) AS 'HANSUDUNG',LYDOHUY
	FROM CTHUYNL,NGUYENLIEU,CTNGUYENLIEU
	WHERE NGUYENLIEU.MANGUYENLIEU=CTHUYNL.MANGUYENLIEU AND NGUYENLIEU.MANGUYENLIEU=CTNGUYENLIEU.MANGUYENLIEU 
	AND MAHUYNL=@MAHUYNL 
	GROUP BY CTNGUYENLIEU.MANGUYENLIEU, TENNGUYENLIEU,CTHUYNL.DONVITINH,CTHUYNL.HANSUDUNG,SOLUONG,LYDOHUY
END



CREATE PROC CTHUYNL_DELETENL(
	@TENNL VARCHAR(50),
	@DVT NVARCHAR(50),
	@HSD DATE,
	@SOLUONG FLOAT
)
AS
BEGIN
	DECLARE @MANL VARCHAR(50) = (SELECT MANGUYENLIEU FROM NGUYENLIEU WHERE TENNGUYENLIEU=@TENNL)
	UPDATE CTNGUYENLIEU SET TONKHO=TONKHO - @SOLUONG WHERE MANGUYENLIEU=@MANL AND HANSUDUNG=@HSD AND DONVITINH=@DVT
END

--------------------------------------------------------------------------------------------------------------


CREATE PROC NHACC_SELECT
AS
BEGIN
	SELECT * FROM NHACUNGCAP
END


CREATE PROC NHACC_SELECTMA(
	@MANCC VARCHAR(50)
)
AS
BEGIN
	SELECT * FROM NHACUNGCAP WHERE MANCC=@MANCC
END


CREATE PROC NHACC_INSERT(
	@MANCC VARCHAR(50),
	@TENNCC NVARCHAR(200),
	@SDT VARCHAR(50),
	@DIACHI NVARCHAR(200)
)
AS
BEGIN
	DECLARE @KTMNCC INT = (SELECT COUNT(*) FROM NHACUNGCAP WHERE MANCC=@MANCC)
	IF(@KTMNCC > 0)
	BEGIN
		SELECT N'Mã nhà cung cấp đã tồn tại'
	END
	ELSE
	BEGIN
		INSERT INTO NHACUNGCAP VALUES(@MANCC,@TENNCC,@SDT,@DIACHI)
		SELECT N'Thêm nhà cung cấp thành công !'
	END
END


CREATE PROC NHACC_UPDATE(
	@MANCC VARCHAR(50),
	@TENNCC NVARCHAR(200),
	@SDT VARCHAR(50),
	@DIACHI NVARCHAR(200)
)
AS
BEGIN
	UPDATE NHACUNGCAP SET TENNCC=@TENNCC , SDT=@SDT, DIACHI=@DIACHI WHERE MANCC=@MANCC
	SELECT N'Sửa thông tin nhà cung cấp thành công !'
END


CREATE PROC NHACC_DELETE(
	@MANCC VARCHAR(50)
)
AS
BEGIN
	DECLARE @KTMNCC INT = (SELECT COUNT(*) FROM NHACUNGCAP WHERE MANCC=@MANCC)
	IF(@KTMNCC = 0)
	BEGIN
		SELECT N'Mã nhà cung cấp không tồn tại'
	END
	ELSE
	BEGIN
		DELETE FROM NHACUNGCAP WHERE MANCC=@MANCC
		SELECT N'Xóa nhà cung cấp thành công !'
	END
END


----------------------------------------------------------------------------------------------------------
SELECT * FROM CONGTHUC


CREATE PROC CONGTHUC_SELECTALL
AS
BEGIN
	SELECT TENSANPHAM, TENNGUYENLIEU, DONVITINH,TIEUHAO FROM CONGTHUC,SANPHAM,NGUYENLIEU
	WHERE SANPHAM.MASANPHAM = CONGTHUC.MASANPHAM AND CONGTHUC.MANGUYENLIEU=NGUYENLIEU.MANGUYENLIEU
	GROUP BY TENSANPHAM, TENNGUYENLIEU, DONVITINH,TIEUHAO
	ORDER BY TENSANPHAM
END


CREATE PROC CONGTHUC_SELECTALLMASP(
	@MASANPHAM VARCHAR(50)
)
AS
BEGIN
	SELECT TENSANPHAM, TENNGUYENLIEU, DONVITINH,TIEUHAO FROM CONGTHUC,SANPHAM,NGUYENLIEU
	WHERE SANPHAM.MASANPHAM = CONGTHUC.MASANPHAM AND CONGTHUC.MANGUYENLIEU=NGUYENLIEU.MANGUYENLIEU
	AND CONGTHUC.MASANPHAM=@MASANPHAM
	GROUP BY TENSANPHAM, TENNGUYENLIEU, DONVITINH,TIEUHAO
	ORDER BY TENSANPHAM
END


CREATE PROC CONGTHUC_TENSPKOCT
AS
BEGIN
	SELECT TENSANPHAM FROM SANPHAM WHERE MASANPHAM != ALL(SELECT MASANPHAM FROM CONGTHUC) 
END


CREATE PROC CONGTHUC_INSERT(
	@TENSANPHAM NVARCHAR(200),
	@TENNGUYENLIEU NVARCHAR(200),
	@TIEUHAO FLOAT,
	@DONVITINH NVARCHAR(50)
)
AS
BEGIN
	DECLARE @MASP VARCHAR(50) = (SELECT MASANPHAM FROM SANPHAM WHERE TENSANPHAM = @TENSANPHAM)
	DECLARE @KTMASP INT = COUNT(@MASP)
	DECLARE @MANL VARCHAR(50) = (SELECT MANGUYENLIEU FROM NGUYENLIEU WHERE TENNGUYENLIEU = @TENNGUYENLIEU)
	DECLARE @KTMANL INT = COUNT(@MANL)
	DECLARE @KTDONVITINH INT = (SELECT COUNT(*) FROM CTNGUYENLIEU WHERE DONVITINH=@DONVITINH AND MANGUYENLIEU = @MANL)
	DECLARE @KT INT = (SELECT COUNT(*) FROM CONGTHUC WHERE MASANPHAM=@MASP AND MANGUYENLIEU=@MANL 
	AND DONVITINH = @DONVITINH)
	IF(@KT > 0)
	BEGIN
		SELECT N'Công thức đã tồn tại'
	END
	ELSE IF(@KTMASP = 0)
	BEGIN
		SELECT N'Sản phẩm không tồn tại'
	END
	ELSE IF (@KTMANL = 0)
	BEGIN
		SELECT N'Nguyên liệu không tồn tại'
	END
	ELSE IF (@KTDONVITINH = 0)
	BEGIN
		SELECT N'Nguyên liệu không có đơn vị tính này'
	END
	ELSE
	BEGIN
		INSERT INTO CONGTHUC VALUES(@MASP,@MANL,@TIEUHAO,@DONVITINH)
		SELECT N'Thêm công thức thành công'
	END
END



CREATE PROC CONGTHUC_UPDATE(
	@TENSANPHAM NVARCHAR(200),
	@TENNGUYENLIEU NVARCHAR(200),
	@TIEUHAO FLOAT,
	@DONVITINH NVARCHAR(50)
)
AS
BEGIN
	DECLARE @MASP VARCHAR(50) = (SELECT MASANPHAM FROM SANPHAM WHERE TENSANPHAM = @TENSANPHAM)
	DECLARE @MANL VARCHAR(50) = (SELECT MANGUYENLIEU FROM NGUYENLIEU WHERE TENNGUYENLIEU = @TENNGUYENLIEU)
	DECLARE @KTDONVITINH INT = (SELECT COUNT(*) FROM CTNGUYENLIEU WHERE DONVITINH=@DONVITINH AND MANGUYENLIEU = @MANL)
	DECLARE @KT INT = (SELECT COUNT(*) FROM CONGTHUC WHERE MASANPHAM=@MASP AND MANGUYENLIEU=@MANL 
	AND DONVITINH = @DONVITINH)
	IF(@KT = 0)
	BEGIN
		SELECT N'Chưa có công thức để cập nhật'
	END
	ELSE
	BEGIN
		UPDATE CONGTHUC SET TIEUHAO = @TIEUHAO 
		WHERE MASANPHAM=@MASP AND MANGUYENLIEU=@MANL AND DONVITINH=@DONVITINH
		SELECT N'Cập nhật thành công'
	END
END


CREATE PROC CONGTHUC_DELETE(
	@TENSANPHAM NVARCHAR(200),
	@TENNGUYENLIEU NVARCHAR(200),
	@TIEUHAO FLOAT,
	@DONVITINH NVARCHAR(50)
)
AS
BEGIN
	DECLARE @MASP VARCHAR(50) = (SELECT MASANPHAM FROM SANPHAM WHERE TENSANPHAM = @TENSANPHAM)
	DECLARE @MANL VARCHAR(50) = (SELECT MANGUYENLIEU FROM NGUYENLIEU WHERE TENNGUYENLIEU = @TENNGUYENLIEU)
	DECLARE @KT INT = (SELECT COUNT(*) FROM CONGTHUC WHERE MASANPHAM=@MASP AND MANGUYENLIEU=@MANL 
	AND DONVITINH = @DONVITINH AND TIEUHAO=@TIEUHAO)
	IF(@KT = 0)
	BEGIN
		SELECT N'Thông tin công thức không đúng, không thể xóa'
	END
	ELSE
	BEGIN
		DELETE FROM CONGTHUC WHERE MASANPHAM=@MASP AND MANGUYENLIEU=@MANL AND TIEUHAO=@TIEUHAO AND DONVITINH=@DONVITINH
		SELECT N'Xóa công thức thành công'
	END
END


--CREATE PROC CONGTHUC_KTLUONGSP(
--	@MASANPHAM VARCHAR(50),
--	@SOLUONG INT
--)
--AS
--BEGIN
--	CREATE TABLE #T(MANL VARCHAR(50),TH FLOAT, DVT NVARCHAR(50), SL INT)
--	INSERT INTO #T SELECT MANGUYENLIEU,TIEUHAO,DONVITINH AS'SOLUONG' FROM CONGTHUC WHERE MASANPHAM = 'TSKCDl'
--	SELECT * FROM #T
--	DECLARE COUNTT INT = (SELECT COUNT(*) FROM #T)


drop proc CONGTHUC_KTLUONGSP
CREATE PROC CONGTHUC_KTLUONGSP(
	@MASANPHAM VARCHAR(50)
)
AS
BEGIN
	DECLARE @KT INT = (SELECT COUNT(*) FROM CONGTHUC WHERE MASANPHAM=@MASANPHAM)
	IF(@KT = 0)
	BEGIN
		(SELECT TENSANPHAM +  N' chưa tồn tại trong công thức','khong' FROM SANPHAM WHERE MASANPHAM=@MASANPHAM)
	END
	ELSE
	BEGIN
		SELECT MANGUYENLIEU,TIEUHAO,DONVITINH FROM CONGTHUC WHERE MASANPHAM = @MASANPHAM
	END
END


drop proc CONGTHUC_KTLUONGNL
CREATE PROC CONGTHUC_KTLUONGNL(
	@SOLUONG INT,
	@MASANPHAM VARCHAR(50),
	@MANGUYENLIEU VARCHAR(50),
	@TIEUHAO FLOAT,
	@DONVITINH NVARCHAR(50)
)
AS
BEGIN
	DECLARE @TONGTH FLOAT = @SOLUONG * @TIEUHAO
	DECLARE @TENSP NVARCHAR(200) = (SELECT TENSANPHAM FROM SANPHAM WHERE MASANPHAM=@MASANPHAM)
	DECLARE @TONKHO FLOAT = (SELECT SUM(TONKHO) FROM CTNGUYENLIEU WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH)
	IF(@TONGTH > @TONKHO)
	BEGIN
		SELECT @TENSP + N' không thể chọn vì ' + TENNGUYENLIEU  + N' không đủ nguyên liệu trong kho' FROM NGUYENLIEU 
		WHERE MANGUYENLIEU=@MANGUYENLIEU
	END
END



CREATE PROC CONGTHUC_THUCTHI(
	@SOLUONG INT,
	@MANGUYENLIEU VARCHAR(50),
	@DONVITINH NVARCHAR(100),
	@TIEUHAO FLOAT
)
AS
BEGIN
	DECLARE @HANSUDUNG DATE = (SELECT MIN(HANSUDUNG) FROM CTNGUYENLIEU WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH AND TONKHO != 0)
	DECLARE @TONKHO FLOAT = (SELECT TONKHO FROM CTNGUYENLIEU WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH 
	AND HANSUDUNG = @HANSUDUNG)
	DECLARE @TONGTH FLOAT = @SOLUONG * @TIEUHAO
	IF (@TONKHO >= @TONGTH)
	BEGIN
		UPDATE CTNGUYENLIEU SET TONKHO=TONKHO-@TONGTH 
		WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH 
		AND HANSUDUNG = @HANSUDUNG
	END
	--ELSE IF(@SOLUONG = @TIEUHAO)
	--BEGIN
	--	DELETE CTNGUYENLIEU WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH 
	--	AND HANSUDUNG = (SELECT MIN(HANSUDUNG) FROM CTNGUYENLIEU WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH)
	--END
	ELSE
	BEGIN
		UPDATE CTNGUYENLIEU SET TONKHO=0
		WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH 
		AND HANSUDUNG = @HANSUDUNG
		DECLARE @TIEUHAOSAU FLOAT = @TONGTH-@TONKHO
		EXEC CONGTHUC_THUCTHI '1',@MANGUYENLIEU,@DONVITINH,@TIEUHAOSAU
	END
		
		--DELETE CTNGUYENLIEU WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH 
		--AND HANSUDUNG = @HANSUDUNG
		--UPDATE CTNGUYENLIEU SET TONKHO=TONKHO-(@TIEUHAO-@SOLUONG) 
		--WHERE MANGUYENLIEU=@MANGUYENLIEU AND DONVITINH=@DONVITINH 
		--AND HANSUDUNG = @HANSUDUNG
END



-----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC THONGKE_DTTHANGTRONGNAM(
	@THOIGIAN DATETIME
)
AS
BEGIN
	SELECT SUM(TONGDOANHTHU) AS N'Doanh thu',SUM(TONGHOADON) AS N'Lượng hóa đơn',SUM(TONGGIAMGIA) AS N'Giảm giá',
	SUM(TONGVANCHUYEN) AS N'Phí vận chuyển', MONTH(THOIGIANKT) AS N'Tháng' 
	FROM DOANHTHU 
	WHERE YEAR(THOIGIANKT) = YEAR(@THOIGIAN)
	GROUP BY MONTH(THOIGIANKT)
END

DROP PROC THONGKE_DTCATRONGNGAY
CREATE PROC THONGKE_DTCATRONGNGAY(
	@THOIGIAN DATETIME
)
AS
BEGIN
	SELECT TENCHUTAIKHOAN AS N'Tên người oder', TONGDOANHTHU AS N'Doanh thu',TONGHOADON AS N'Lượng hóa đơn',
	TONGGIAMGIA AS N'Giảm giá',TONGVANCHUYEN AS N'Vận chuyển',THOIGIANBD AS N'Bắt đầu',THOIGIANKT AS N'Kết thúc'
	FROM TAIKHOAN,DOANHTHU
	WHERE TAIKHOAN.TENDANGNHAP=DOANHTHU.TENDANGNHAP AND CONVERT(DATE,THOIGIANKT,102) = CONVERT(DATE,'2018-11-12',102)
END


CREATE PROC THONGKE_DTNGAYTRONGTHANG(
	@THOIGIAN DATETIME
)
AS
BEGIN
	SELECT TONGDOANHTHU AS N'Doanh thu',TONGHOADON AS N'Lượng hóa đơn',
	TONGGIAMGIA AS N'Giảm giá',TONGVANCHUYEN AS N'Vận chuyển',THOIGIANBD AS N'Bắt đầu',THOIGIANKT AS N'Kết thúc'
	FROM DOANHTHU
	WHERE MONTH(THOIGIANKT)= MONTH(@THOIGIAN)
END


CREATE PROC THONGKE_DTNAM
AS
BEGIN
	SELECT SUM(TONGDOANHTHU) AS N'Doanh thu',SUM(TONGHOADON) AS N'Lượng hóa đơn', 
	SUM(TONGGIAMGIA) AS N'Giảm giá',SUM(TONGVANCHUYEN) AS N'Vận chuyển', YEAR(THOIGIANKT) AS N'Năm'
	FROM DOANHTHU
	GROUP BY YEAR(THOIGIANKT)
END
