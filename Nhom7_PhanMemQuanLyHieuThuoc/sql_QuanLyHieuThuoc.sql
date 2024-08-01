
------------------------TẠO DATABASE--------------------------
use master 
go
CREATE DATABASE dtb_QuanLyHieuThuoc
go
USE dtb_QuanLyHieuThuoc
go

------------------------TẠO BẢNG------------------------------
SET DATEFORMAT dmy
--1. Bảng LOẠI
CREATE TABLE tbl_LOAI
(
	MaLoai VARCHAR(5) NOT NULL,
	TenLoai NVARCHAR(30),
	CONSTRAINT PK_LOAI PRIMARY KEY(MaLoai)
)
go
--2. BẢNG THUỐC
CREATE TABLE tbl_THUOC
(
	SoThuTu INT IDENTITY(1,1),
	MaSP AS 'SP' + RIGHT('000' + CAST(SoThuTu AS VARCHAR(3)), 3) PERSISTED NOT NULL,
	MaLoai VARCHAR(5) NOT NULL,
	CONSTRAINT PK_THUOC PRIMARY KEY(MaSP),
)
go

--3. BẢNG CHI TIẾT THUỐC
create table tbl_CTTHUOC
(
	MaSP varchar(5) NOT NULL,
	TenSP NVARCHAR(50) NOT NULL,
	ThanhPhan NVARCHAR(MaX),
	GiaNhap FLOAT,
	GiaBan FLOAT,
	SoLuongTon INT,
	CONSTRAINT PK_CTTHUOC PRIMARY KEY(MaSP),
)
go
--4.Bảng Quận huyện 
CREATE TABLE tbl_QUANHUYEN
(
	QuanHuyenId INT IDENTITY(1,1) NOT NULL,
	TenQuanHuyen NVARCHAR(30),
	constraint PK_tbl_QUANHUYEN PRIMARY KEY(QuanHuyenId)
)

go
--5.BẢNG NHÀ CUNG CẤP\/
Create TABLE tbl_NHACUNGCAP
(
	SoThuTu INT IDENTITY(1,1),
	MaNCC AS 'NCC' + RIGHT('00' + CAST(SoThuTu AS  VARCHAR(2)), 2) PERSISTED NOT NULL,
	TenNCC NVARCHAR(50),
	SDT VARCHAR(11),
	Email VARCHAR(50),
	SoNha NVARCHAR(MAX),
	QuanHuyenId INT,
	CONSTRAINT PK_NHACUNGCAP PRIMARY KEY(MaNCC)
)

go

--6.BẢNG KHÁCH HÀNG
Create TABLE tbl_KHACHHANG
(
	SoThuTu INT IDENTITY(1,1),
	MaKH AS 'KH' + right('000' + cast(SoThuTu AS VARCHAR(3)), 3) PERSISTED NOT NULL,
	TenKH NVARCHAR(50),
	SDT VARCHAR(11),
	GioiTinh NVARCHAR(5) NOT NULL,
	Email VARCHAR(50),
	SoNha NVARCHAR(MAX),
	QuanHuyenId INT,
	CONSTRAINT PK_KHACHHANG PRIMARY KEY(MaKH),
)
go

--7.BẢNG TÀI KHOẢN
CREATE TABLE tbl_TAIKHOAN
(
	TenDangNhap VARCHAR(50) NOT NULL,
	MatKhau VARCHAR(50) NOT NULL,
	VaiTro NVARCHAR(50),
	CONSTRAINT PK_TAIKHOAN PRIMARY KEY(TenDangNhap)
)
go
--8.BẢNG DƯỢC SĨ
Create TABLE tbl_DUOCSI
(
	SoThuTu INT IDENTITY(1,1),
	MaDuocSi AS 'DS' + RIGHT('000' + CAST(SoThuTu AS VARCHAR(3)), 3) PERSISTED NOT NULL,
	TenDangNhap VARCHAR(50) NOT NULL,
	CONSTRAINT PK_DUOCSI PRIMARY KEY(MaDuocSi),
)
go

--9.BẢNG CHI TIẾT TÀI KHOẢN
CREATE TABLE tbl_CHITIETTAIKHOAN
(
	TenDangNhap VARCHAR(50) NOT NULL,
	TenNguoiDung NVARCHAR(30),
	NgaySinh DATE,
	GioiTinh NVARCHAR(5) NOT NULL,
	SoNha NVARCHAR(MAX),
	QuanHuyenId INT,
	SoDienThoai VARCHAR(11),
	Email VARCHAR(30),
	CONSTRAINT PK_CHITIETTAIKHOAN PRIMARY KEY (TenDangNhap),
)
go


--10.BẢNG QUẢN LÝ
CREATE TABLE tbl_QUANLY
(
	SoThuTu INT IDENTITY(1,1),
	MaQuanLy AS 'QL' + RIGHT('000' + CAST(SoThuTu AS VARCHAR(3)), 3) PERSISTED NOT NULL,
	TenDangNhap VARCHAR(50),
	CONSTRAINT PK_QUANLY PRIMARY KEY (MaQuanLy),
)
go

--11.BẢNG HÓA ĐƠN
Create TABLE tbl_HOADON
(
	SoThuTu INT IDENTITY(1,1),
	MaHD AS 'HD' + RIGHT('000' + CAST(SoThuTu AS VARCHAR(3)), 3) PERSISTED NOT NULL,
	MaDuocSi VARCHAR(5) NOT NULL,
	NgayLap DATE,
	TongTien FLOAT,
	MaKH VARCHAR(5) NOT NULL,
	CONSTRAINT PK_HOADON PRIMARY KEY(MaHD),
)
go
--12. BẢNG CHI TIẾT HÓA ĐƠN
Create TABLE tbl_CTHOADON
(
	MaCTHD AS MaHD+'_'+MaSP PERSISTED NOT NULL,
	MaHD VARCHAR(5) NOT NULL,
	MaSP VARCHAR(5) NOT NULL,
	SoLuong INT,
	DonGia FLOAT,
	CONSTRAINT PK_CTHOADON PRIMaRY KEY(MaCTHD),
)
go

--13.BẢNG TRẠNG THÁI
CREATE TABLE tbl_TRANGTHAI
(
	MaTrangThai VARCHAR(5) NOT NULL,
	TenTrangThai NVARCHAR(30),
	CONSTRAINT PK_tbl_TRANGTHAI PRIMARY KEY(MaTrangThai)
)
go
--14,BẢNG PHIẾU NHẬP
Create TABLE tbl_PHIEUNHAP
(
	SoThuTu INT IDENTITY(1,1),
	MaPN AS 'PN' + RIGHT('000' + CAST(SoThuTu AS VARCHAR(3)), 3) PERSISTED NOT NULL,
	MaNCC VARCHAR(5) NOT NULL,
	MaDuocSi VARCHAR(5) NOT NULL,
	NgayNhap DATE,
	MaTrangThai VARCHAR(5),
	CONSTRAINT PK_PHIEUNHAP PRIMARY KEY(MaPN),
)
go

--15. BẢNG CHI TIẾT PHIẾU NHẬP
Create TABLE tbl_CTPHIEUNHAP
(
	MaCTPN as MaPN+'_'+MaSP persisted not null,
	MaPN VARCHAR(5) NOT NULL,
	MaSP VARCHAR(5) NOT NULL,
	SoLuongDat INT,
	SoLuongNhan INT,
	DonGiaNhap FLOAT,
	CONSTRAINT PK_CTPHIEUNHAP PRIMaRY KEY(MaCTPN),
)
go
--16. BẢNG BỆNH
CREATE table tbl_BENH
(
	MaBenh VARCHAR(5) NOT NULL,
	TenBenh NVARCHAR(30),
	CONSTRAINT PK_tbl_BENH PRIMARY KEY(MaBenh)
)
go
--17. BẢNG ĐIỀU TRỊ
CREATE TABLE tbl_DIEUTRI
(
	MaBenh VARCHAR(5) NOT NULL,
	MaSP VARCHAR(5) NOT NULL,
	CONSTRAINT PK_tbl_DUOCSI PRIMARY KEY(MaBenh,MaSP)
)
go


-------------------------------------------RÀNG BUỘC KHOÁ NGOẠI-----------------------------


--BẢNG THUỐC
ALTER TABLE tbl_THUOC
ADD CONSTRAINT FK_THUOC_LOAI FOREIGN KEY(MaLoai) REFERENCES tbl_LOAI(MaLoai)

--BẢNG CHI TIẾT THUỐC
ALTER TABLE tbl_CTTHUOC
ADD CONSTRAINT FK_CTTHUOC_THUOC FOREIGN KEY(MASP) REFERENCES tbl_THUOC(MaSP)

--BẢNG NHÀ CUNG CẤP
ALTER TABLE tbl_NHACUNGCAP
ADD CONSTRAINT FK_tbl_NHACUNGCAP_QUANHUYEN FOREIGN KEY(QuanHuyenId) REFERENCES tbl_QUANHUYEN(QuanHuyenId)

--BẢNG KHÁCH HÀNG
ALTER TABLE tbl_KHACHHANG
ADD CONSTRAINT FK_tbl_KHACHHANG_QUANHUYEN FOREIGN KEY(QuanHuyenId) REFERENCES tbl_QUANHUYEN(QuanHuyenId)

--BẢNG DƯỢC SĨ
ALTER TABLE tbl_DUOCSI
ADD	CONSTRAINT FK_DUOCSI_TAIKHOAN FOREIGN KEY(TenDangNhap) REFERENCES tbl_TAIKHOAN(TenDangNhap)

--BẢNG CHI TIẾT TÀI KHOẢN
ALTER TABLE tbl_CHITIETTAIKHOAN
ADD CONSTRAINT FK_CHITIETTAIKHOAN_TAIKHOAN FOREIGN KEY(TenDangNhap) REFERENCES tbl_TAIKHOAN(TenDangNhap)
ALTER TABLE tbl_CHITIETTAIKHOAN
ADD CONSTRAINT FK_tbl_CHITIETTAIKHOAN_QUANHUYEN FOREIGN KEY(QuanHuyenId) REFERENCES tbl_QUANHUYEN(QuanHuyenId)

--BẢNG QUẢN LÝ
ALTER TABLE tbl_QUANLY
ADD CONSTRAINT FK_QUANLY_TAIKHOAN FOREIGN KEY (TenDangNhap) REFERENCES tbl_TAIKHOAN(TenDangNhap)

--BẢNG HÓA ĐƠN
ALTER TABLE tbl_HOADON
ADD CONSTRAINT FK_HOADON_DUOCSI FOREIGN KEY(MaDuocSi) REFERENCES tbl_DUOCSI(MaDuocSi),
CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(MaKH) REFERENCES tbl_KHACHHANG(MaKH)

--BẢNG CHI TIẾT HÓA ĐƠN
ALTER TABLE tbl_CTHOADON
ADD CONSTRAINT FK_CTHOADON_HOADON FOREIGN KEY(MaHD) REFERENCES tbl_HOADON(MaHD),
CONSTRAINT FK_CTHOADON_THUOC FOREIGN KEY(MaSP) REFERENCES tbl_THUOC(MaSP)

--BẢNG PHIẾU NHẬP
ALTER TABLE tbl_PHIEUNHAP
ADD CONSTRAINT FK_tbl_PHIEUNHAP_TRANGTHAI FOREIGN KEY(MaTrangThai) REFERENCES tbl_TRANGTHAI(MaTrangThai),
CONSTRAINT FK_PHIEUNHAP_NHACUNGCAP FOREIGN KEY(MaNCC) REFERENCES tbl_NHACUNGCAP(MaNCC),
CONSTRAINT FK_PHIEUNHAP_DUOCSI FOREIGN KEY(MaDuocSi) REFERENCES tbl_DUOCSI(MaDuocSi)

--BẢNG CHI TIẾT PHIẾU NHẬP
ALTER TABLE tbl_CTPHIEUNHAP
ADD CONSTRAINT FK_CTPHIEUNHAP_PHIEUNHAP FOREIGN KEY(MaPN) REFERENCES tbl_PHIEUNHAP(MaPN),
CONSTRAINT FK_CTPHIEUNHAP_THUOC FOREIGN KEY(MaSP) REFERENCES tbl_THUOC(MaSP)

--BẢNG ĐIỀU TRỊ
ALTER TABLE tbl_DIEUTRI
ADD CONSTRAINT FK_tbl_DIEUTRI_THUOC FOREIGN KEY(MaSP) REFERENCES tbl_THUOC(MaSP)
ALTER TABLE tbl_DIEUTRI
ADD CONSTRAINT FK_tbl_DIEUTRI_BENH FOREIGN KEY(MaBenh) REFERENCES tbl_BENH(MaBenh)

-------------------------------------------RÀNG BUỘC UNIQUE,CHECK------------------------------
--LOẠI
ALTER TABLE tbl_LOAI
ADD CONSTRAINT UNI_tbl_LOAI_TENLOAI UNIQUE(TenLoai)

--Quận huyện
ALTER TABLE tbl_QUANHUYEN
ADD CONSTRAINT UNI_tbl_QUANHUYEN_TENQH UNIQUE(TenQuanHuyen)

--CTTHUOC
ALTER TABLE tbl_CTTHUOC
ADD CONSTRAINT UNI_tbl_CTTHUOC_TENSP UNIQUE(TenSP)

ALTER TABLE tbl_CTTHUOC
ADD CONSTRAINT CHK_tbl_CTTHUOC_SOLUONTON CHECK(SoLuongTon>=0) 


ALTER TABLE tbl_KHACHHANG
ADD CONSTRAINT CHK_tbl_KHACHHANG_GIOITINH CHECK(GioiTinh=N'Nam' OR GioiTinh=N'Nữ' OR GioiTinh=N'Khác')


--bảng tài khoản
ALTER TABLE tbl_TAIKHOAN
ADD CONSTRAINT CHK_tbl_TAIKHOAN_VAITRO CHECK(VaiTro=N'Dược sĩ' OR VaiTro=N'Quản lý')
--Chi tiết tài khoản
ALTER TABLE tbl_CHITIETTAIKHOAN
ADD CONSTRAINT CHK_tbl_CHITIETTAIKHOAN_GIOITINH CHECK(GioiTinh=N'Nam' OR GioiTinh=N'Nữ' OR GioiTinh=N'Khác')
--Hóa đơn
ALTER TABLE tbl_HOADON
ADD CONSTRAINT DF_tbl_HOADON_TONGTIEN DEFAULT 0 FOR TongTien

--Chi tiết hóa đơn
ALTER TABLE tbl_CTHOADON
ADD CONSTRAINT CHK_tbl_CTHOADON_SOLUONG CHECK(SoLuong>=0)

ALTER TABLE tbl_CTHOADON
ADD CONSTRAINT CHK_tbl_CTHOADON_DONGIA CHECK(DonGia>=0)

--Chi tiết Phiếu nhập
ALTER TABLE tbl_CTPHIEUNHAP
ADD CONSTRAINT CHK_tbl_CTPHIEUNHAP_SOLUONGDAT_SOLUONGNHAN CHECK(SoLuongDat>=SoLuongNhan AND SoLuongDat>=0 AND SoLuongNhan>=0)

--TRẠNG THÁI
ALTER TABLE tbl_TRANGTHAI
ADD CONSTRAINT CHK_tbl_TRANGTHAI_TENTRANGTHAI CHECK(TenTrangThai=N'Nhận đủ' OR TenTrangThai=N'Chưa nhận đủ')
--ALTER TABLE tbl_TRANGTHAI
--ADD CONSTRAINT UNI_tbl_TRANGTHAI_TENTRANGTHAI UNIQUE(TenTrangThai)
GO

----------------------------------------------TRIGGER-------------------------------------------------------------------
--Cho trạng thái là nhận đủ hàng khi Số lượng đặt bằng với số lượng nhận, MaTrangThai=1 có thể hiểu là nhận chưa đủ hàng
------------CHỈNH SỬA
--Cho trạng thái là nhận đủ hàng khi Số lượng đặt bằng với số lượng nhận, MaTrangThai=1 có thể hiểu là nhận chưa đủ hàng
CREATE TRIGGER TRG_TRANGTHAI_PHIEUNHAP_TENTRANGTHAI 
ON tbl_CTPHIEUNHAP
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @MaPN varchar(5), @SoLuongDat int, @SoLuongNhan int,@DemsoCTPN int=0, @DemsoCTPN_Du int=0

	SELECT @MaPN = MaPN, @SoLuongDat = SoLuongDat, @SoLuongNhan = SoLuongNhan,@DemsoCTPN=1
	FROM inserted

	--IF @SoLuongNhan < @SoLuongDat
	--BEGIN
	--	UPDATE tbl_PHIEUNHAP
	--	SET MaTrangThai = '1'
	--	WHERE MaPN = @MaPN
	--END
	--ELSE 
	IF @SoLuongNhan = @SoLuongDat
	BEGIN
		--UPDATE tbl_PHIEUNHAP
		--SET MaTrangThai = '2'
		--WHERE MaPN = @MaPN
		Set @DemsoCTPN_Du=1
	END
	DECLARE CS_DUYET CURSOR
	FOR SELECT MACTPN,SOLUONGNHAN,SOLUONGDAT FROM tbl_CTPHIEUNHAP WHERE MaPN=@MaPN
	DECLARE @MACTPN VARCHAR(15)
	OPEN CS_DUYET
	FETCH NEXT FROM CS_DUYET INTO @MACTPN,@SoLuongNhan,@SoLuongDat
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		Set @DemsoCTPN+=1
		IF @SoLuongNhan=@SoLuongDat
		BEGIN
			Set @DemsoCTPN_Du+=1
		END
		FETCH NEXT FROM CS_DUYET INTO @MACTPN,@SoLuongNhan,@SoLuongDat
	END
	CLOSE CS_DUYET
	DEALLOCATE CS_DUYET
	IF @DemsoCTPN_Du<@DemsoCTPN
	BEGIN
		UPDATE tbl_PHIEUNHAP
		SET MaTrangThai = '1'
		WHERE MaPN = @MaPN
	END
	ELSE IF @DemsoCTPN_Du=@DemsoCTPN
	BEGIN
		UPDATE tbl_PHIEUNHAP
		SET MaTrangThai = '2'
		WHERE MaPN = @MaPN
	END
END
GO
--GÁN ĐƠN GIÁ NHẬP Ở CT PHIẾU NHẬP BẰNG VỚI GIÁ NHẬP Ở SẢN PHẨM
CREATE TRIGGER TRG_GIANHAP_PHIEUNHAP_SANPHAM
ON tbl_CTPHIEUNHAP
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @MaSP varchar(5)
	DECLARE @GIANHAP FLOAT
	select @MaSP=i.MaSP, @GIANHAP=i.DonGiaNhap
	from inserted i
	UPDATE tbl_CTTHUOC
	SET GiaNhap=@GIANHAP 
	WHERE MaSP=@MaSP
END
GO
--TRIGGER RÀNG BUỘC GIÁ BÁN Ở SẢN PHẨM BẰNG GIÁ NHẬP * 1.2
CREATE TRIGGER TRG_UPDATEGIABAN
ON tbl_CTTHUOC
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @MASP VARCHAR(5)
	SELECT @MASP=i.MaSP
	FROM inserted i
	UPDATE tbl_CTTHUOC
	SET GiaBan=GiaNhap*1.2
	WHERE MaSP=@MASP
END
GO





--Tạo trigger số lượng tồn
create trigger TRG_SOLUONGTON
ON tbl_CTPHIEUNHAP
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @MASP VARCHAR(5), @SOLUONGNHAN INT
	SELECT @MASP=i.MaSP, @SOLUONGNHAN=i.SoLuongNhan
	FROM inserted i
	update tbl_CTTHUOC
	set SoLuongTon+=@SOLUONGNHAN
	where MaSP=@MASP
END
GO




----------------------------Các procedure------------------------------------

----------------------Quản lý khách hàng--------------------------------------

--Lấy thông tin quận huyện
create procedure quanhuyen
as
begin
	select *
	from tbl_QUANHUYEN
end
go
--Lấy thông tin của 1 khách hàng
CREATE PROCEDURE layThongTinKH
    @tenKH NVARCHAR(50)
AS
BEGIN
    SELECT
        TenKH,
        GioiTinh,
        SDT,
        Email,
        SoNha,
        QuanHuyenId
    FROM tbl_KHACHHANG
    WHERE TenKH = @tenKH;
END;
go

--lấy danh sách khách hàng
CREATE PROCEDURE dsKH
AS
BEGIN
  SELECT
    MaKH,
    TenKH,
    SDT,
    GioiTinh,
    Email,
    SoNha,
    QuanHuyenId
  FROM tbl_KHACHHANG;
END;
go
--thêm khách hàng
create PROCEDURE themKH
(
  @tenKH nvarchar(50),
  @sdt varchar(11),
  @gioiTinh nvarchar(5),
  @email varchar(50),
  @soNha nvarchar(MAX),
  @quanHuyenId int
)
AS
BEGIN
  INSERT INTO tbl_KHACHHANG (TenKH, SDT, GioiTinh, Email, SoNha, QuanHuyenId)
  VALUES (@tenKH, @sdt, @gioiTinh, @email, @soNha, @quanHuyenId);
END;
go

--xóa khách hàng
create PROCEDURE xoaKH
@maKH VARCHAR(10)
AS
BEGIN
  DELETE FROM tbl_KHACHHANG
  WHERE MaKH = @maKH;
END;
go
--exec xoaKH'KH005'

--sửa thông tin khách hàng
create PROCEDURE suaKH
@maKH Varchar(50),
@tenKH NVARCHAR(50),
@gioiTinh NVARCHAR(5),
@sdt VARCHAR(10),
@email VARCHAR(50),
@soNha NVARCHAR(200),
@quanHuyenId VARCHAR(50)
AS
BEGIN
  UPDATE tbl_KHACHHANG
  SET TenKH = @tenKH,
    GioiTinh = @gioiTinh,
    SDT = @sdt,
    Email = @email,
    SoNha = @soNha,
    QuanHuyenId = @quanHuyenId
  WHERE MaKH = @maKH;
END;
go

--tìm kiếm khách hàng
create PROCEDURE timKH
@value NVARCHAR(50)
AS
BEGIN
  SELECT
    TenKH,
    GioiTinh,
    SDT,
    Email,
    SoNha,
    QuanHuyenId
  FROM tbl_KHACHHANG
  WHERE 
   TenKH LIKE @value
END;
go
--Lọc
CREATE PROCEDURE sp_LayDanhSachKhachHangTheoQuanHuyen
@quanHuyenId int
AS
BEGIN
  SELECT
    MaKH,
    TenKH,
    SDT,
    GioiTinh,
    Email,
    SoNha,
    QuanHuyenId
  FROM tbl_KHACHHANG
  WHERE QuanHuyenId = @quanHuyenId;
END;
go
-------------------------------------------------------------------------------------------------------------
----------------------------------QUẢN LÝ NHÀ CUNG CẤP---------------------------------------------------------------------------

--lấy thông tin 1 nhà cung cấp
CREATE PROCEDURE sp_LayThongTinNhaCungCapTheoTen
    @tenNCC NVARCHAR(50)
AS
BEGIN
    SELECT
        MaNCC,
        TenNCC,
        SDT,
        Email,
        SoNha,
        QuanHuyenId
    FROM tbl_NHACUNGCAP
    WHERE TenNCC LIKE '%' + @tenNCC + '%';
END;
go
--Lấy danh sách nhà cung cấp
CREATE PROCEDURE sp_LayDanhSachNhaCungCap
AS
BEGIN
    SELECT
        MaNCC,
        TenNCC,
        SDT,
        Email,
        SoNha,
        QuanHuyenId
    FROM tbl_NHACUNGCAP;
END;
go
--EXEC sp_LayDanhSachNhaCungCap;

--Thêm nhà cung cấp
CREATE PROCEDURE sp_ThemNhaCungCap
    @TenNCC NVARCHAR(50),
    @SDT VARCHAR(11),
    @Email VARCHAR(50),
    @SoNha NVARCHAR(MAX),
    @QuanHuyenId INT
AS
BEGIN
    INSERT INTO tbl_NHACUNGCAP (TenNCC, SDT, Email, SoNha, QuanHuyenId)
    VALUES (@TenNCC, @SDT, @Email, @SoNha, @QuanHuyenId);
END;
go
--EXEC sp_ThemNhaCungCap 
--    @TenNCC = 'TênNhacCungCap',
--    @SDT = '0987654321',
--    @Email = 'email@ncc.com',
--    @SoNha = '123 Đường ABC',
--    @QuanHuyenId = 1;

--Xóa 1 nhà cung cấp
CREATE PROCEDURE sp_XoaNhaCungCap
    @MaNCC VARCHAR(20)
AS
BEGIN
    DELETE FROM tbl_NHACUNGCAP
    WHERE MaNCC = @MaNCC;
END;
go
--EXEC sp_XoaNhaCungCap 
--    @MaNCC = 'MãNhacCungCap';

--Sửa 1 nhà cung cấp


--EXEC sp_SuaThongTinNhaCungCap 
--    @TenNCC = 'Pharmacity',
--    @SDT = '0987654321',
--    @Email = 'emailmoi@ncc.com',
--    @SoNha = '456 Đường XYZ',
--    @QuanHuyenId = 2;

create PROCEDURE sp_CapNhatThongTinNhaCungCap_test
    @MaNCC VARCHAR(20),
    @TenNCC NVARCHAR(50),
    @SDT VARCHAR(11),
    @Email VARCHAR(50),
    @SoNha NVARCHAR(MAX),
    @QuanHuyenId INT
AS
BEGIN
    UPDATE tbl_NHACUNGCAP
    SET 
        TenNCC = @TenNCC,
        SDT = @SDT,
        Email = @Email,
        SoNha = @SoNha,
        QuanHuyenId = @QuanHuyenId
    WHERE MaNCC = @MaNCC;
END;
go
--EXEC sp_CapNhatThongTinNhaCungCap_test
--    @MaNCC = 'Pharmacity',
--    @TenNCC = 'TenMoi',
--    @SDT = '0987654321',
--    @Email = 'emailmoi@ncc.com',
--    @SoNha = '456 Đường XYZ',
--    @QuanHuyenId = 2;

--tìm 1 nhà cung cấp theo tên
CREATE PROCEDURE sp_TimNhaCungCapTheoTen
    @TenNCC NVARCHAR(50)
AS
BEGIN
    SELECT
        MaNCC,
        TenNCC,
        SDT,
        Email,
        SoNha,
        QuanHuyenId
    FROM tbl_NHACUNGCAP
    WHERE TenNCC LIKE '%' + @TenNCC + '%';
END;
--Lọc nhà cung cấp theo quận huyện
go
CREATE PROCEDURE sp_LayDanhSachNCCTheoQuanHuyen
@quanHuyenId int
AS
BEGIN
  SELECT
		MaNCC,
        TenNCC,
        SDT,
        Email,
        SoNha,
        QuanHuyenId
  FROM tbl_NHACUNGCAP
  WHERE QuanHuyenId = @quanHuyenId;
END;
go

------------Thao tác trên bảng QUẢN LÝ, TÀI KHOẢN, CHI TIẾT TÀI KHOẢN, QUẬN HUYỆN, DƯỢC SĨ
create proc dsQuanHuyen
as
begin
	select * from tbl_QUANHUYEN
end
go

CREATE PROCEDURE sp_KiemTraTenDangNhap
    @TenDangNhap VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM tbl_TAIKHOAN WHERE TenDangNhap = @TenDangNhap)
    BEGIN
        SELECT 1
    END
    ELSE
    BEGIN
        SELECT 0
    END
END
go


CREATE PROCEDURE sp_ThemTaiKhoan
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(50),
    @VaiTro NVARCHAR(50),
    @TenNguoiDung NVARCHAR(30),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(5),
    @SoNha NVARCHAR(MAX),
    @QuanHuyenId INT,
    @SoDienThoai VARCHAR(11),
    @Email VARCHAR(30)
AS
BEGIN
    -- Thêm tài khoản vào bảng tbl_TAIKHOAN
    INSERT INTO tbl_TAIKHOAN (TenDangNhap, MatKhau, VaiTro)
    VALUES (@TenDangNhap, @MatKhau, @VaiTro)

    -- Thêm chi tiết tài khoản vào bảng tbl_CHITIETTAIKHOAN
    INSERT INTO tbl_CHITIETTAIKHOAN (TenDangNhap, TenNguoiDung, NgaySinh, GioiTinh, SoNha, QuanHuyenId, SoDienThoai, Email)
    VALUES (@TenDangNhap, @TenNguoiDung, @NgaySinh, @GioiTinh, @SoNha, @QuanHuyenId, @SoDienThoai, @Email)

    -- Kiểm tra vai trò và thêm vào bảng tương ứng
    IF @VaiTro = N'Quản lý'
    BEGIN
        INSERT INTO tbl_QUANLY (TenDangNhap)
        VALUES (@TenDangNhap)
    END
    ELSE IF @VaiTro = N'Dược sĩ'
    BEGIN
        INSERT INTO tbl_DUOCSI (TenDangNhap)
        VALUES (@TenDangNhap)
    END
END
go
CREATE PROCEDURE sp_HienThiThongTin
AS
BEGIN
    SELECT 
        TK.TenDangNhap,
        QL.MaQuanLy,
        DS.MaDuocSi,
        TK.VaiTro,
        CTTK.GioiTinh,
        CTTK.SoDienThoai,
        CTTK.TenNguoiDung,
        CTTK.SoNha,
        QH.TenQuanHuyen,
        CTTK.NgaySinh,
        CTTK.Email
    FROM 
        tbl_TAIKHOAN TK
    LEFT JOIN 
        tbl_DUOCSI DS ON TK.TenDangNhap = DS.TenDangNhap
    LEFT JOIN 
        tbl_QUANLY QL ON TK.TenDangNhap = QL.TenDangNhap
    INNER JOIN 
        tbl_CHITIETTAIKHOAN CTTK ON TK.TenDangNhap = CTTK.TenDangNhap
    INNER JOIN 
        tbl_QUANHUYEN QH ON CTTK.QuanHuyenId = QH.QuanHuyenId
END
go
CREATE PROCEDURE sp_XoaTaiKhoan
    @TenDangNhap VARCHAR(50)
AS
BEGIN
    -- Lấy vai trò của tài khoản
    DECLARE @VaiTro NVARCHAR(50);
    SELECT @VaiTro = VaiTro FROM tbl_TAIKHOAN WHERE TenDangNhap = @TenDangNhap;

    -- Kiểm tra vai trò và xóa tài khoản tương ứng
    IF @VaiTro = N'Quản lý'
    BEGIN
        DELETE FROM tbl_QUANLY WHERE TenDangNhap = @TenDangNhap;
    END
    ELSE IF @VaiTro = N'Dược sĩ'
    BEGIN
        DELETE FROM tbl_DUOCSI WHERE TenDangNhap = @TenDangNhap;
    END

    -- Xóa tài khoản từ bảng tbl_CHITIETTAIKHOAN
    DELETE FROM tbl_CHITIETTAIKHOAN WHERE TenDangNhap = @TenDangNhap;

    -- Xóa tài khoản từ bảng tbl_TAIKHOAN
    DELETE FROM tbl_TAIKHOAN WHERE TenDangNhap = @TenDangNhap;
END
go
create proc sp_capnhatthongtin
	@TenDangNhap VARCHAR(50),
    @TenNguoiDung NVARCHAR(30),
    @NgaySinh DATE,
    @SoNha NVARCHAR(MAX),
    @QuanHuyenId INT,
    @SoDienThoai VARCHAR(11),
    @Email VARCHAR(30)
as
begin
	update tbl_CHITIETTAIKHOAN
	set SoDienThoai = @SoDienThoai, TenNguoiDung = @TenNguoiDung, NgaySinh = @NgaySinh, SoNha = @SoNha, Email = @Email, QuanHuyenId = @QuanHuyenId
	where TenDangNhap = @TenDangNhap
end
go 
CREATE PROC sp_timDuocSi
	@TenNguoiDung nvarchar(50)
AS
BEGIN
	  SELECT 
        TK.TenDangNhap,
        QL.MaQuanLy,
        DS.MaDuocSi,
        TK.VaiTro,
        CTTK.GioiTinh,
        CTTK.SoDienThoai,
        CTTK.TenNguoiDung,
        CTTK.SoNha,
        QH.TenQuanHuyen,
        CTTK.NgaySinh,
        CTTK.Email
    FROM 
        tbl_TAIKHOAN TK
    LEFT JOIN 
        tbl_DUOCSI DS ON TK.TenDangNhap = DS.TenDangNhap
    LEFT JOIN 
        tbl_QUANLY QL ON TK.TenDangNhap = QL.TenDangNhap
    INNER JOIN 
        tbl_CHITIETTAIKHOAN CTTK ON TK.TenDangNhap = CTTK.TenDangNhap
    INNER JOIN 
        tbl_QUANHUYEN QH ON CTTK.QuanHuyenId = QH.QuanHuyenId
    WHERE
        CTTK.TenNguoiDung LIKE '%' + @TenNguoiDung + '%'
END
GO
CREATE PROC sp_timTheoVaiTro
	@VaiTro nvarchar(50)
AS
BEGIN
	  SELECT 
        TK.TenDangNhap,
        QL.MaQuanLy,
        DS.MaDuocSi,
        TK.VaiTro,
        CTTK.GioiTinh,
        CTTK.SoDienThoai,
        CTTK.TenNguoiDung,
        CTTK.SoNha,
        QH.TenQuanHuyen,
        CTTK.NgaySinh,
        CTTK.Email
    FROM 
        tbl_TAIKHOAN TK
    LEFT JOIN 
        tbl_DUOCSI DS ON TK.TenDangNhap = DS.TenDangNhap
    LEFT JOIN 
        tbl_QUANLY QL ON TK.TenDangNhap = QL.TenDangNhap
    INNER JOIN 
        tbl_CHITIETTAIKHOAN CTTK ON TK.TenDangNhap = CTTK.TenDangNhap
    INNER JOIN 
        tbl_QUANHUYEN QH ON CTTK.QuanHuyenId = QH.QuanHuyenId
    WHERE
        TK.VaiTro = @VaiTro
END
go

-- Kiểm Tra Email --
CREATE PROCEDURE sp_KiemTraEmail
    @Email VARCHAR(30)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM tbl_CHITIETTAIKHOAN WHERE Email = @Email)
    BEGIN
        SELECT 1
    END
    ELSE
    BEGIN
        SELECT 0
    END
END

-- Top 5 Thuốc Bán Chạy --
go
CREATE FUNCTION UF_TOP5THUOCBANCHAY(@THANG INT,@NAM INT)
RETURNS @DT TABLE(TENTHUOC NVARCHAR(50),SOLUONG INT)
AS
BEGIN
	DECLARE @TONGSL INT ,@TEN NVARCHAR(50)
	DECLARE CS_DUYET CURSOR
	FOR SELECT	TenSP , SUM(SoLuong)
		FROM tbl_HOADON AS HD
		JOIN tbl_CTHOADON AS CTHD ON CTHD.MaHD=HD.MaHD
		JOIN tbl_THUOC AS TH ON TH.MaSP=CTHD.MaSP
		JOIN tbl_CTTHUOC AS CTTH ON TH.MaSP=CTTH.MaSP
		WHERE MONTH(NgayLap)=@THANG AND YEAR(NgayLap)=@NAM
		GROUP BY TenSP
	OPEN CS_DUYET 
	FETCH NEXT FROM CS_DUYET INTO @TEN,@TONGSL
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		INSERT INTO @DT VALUES(@TEN,@TONGSL)
		FETCH NEXT FROM CS_DUYET INTO @TEN,@TONGSL
	END
	CLOSE CS_DUYET
	DEALLOCATE CS_DUYET
	RETURN
END

-- Doanh Thu --
go
CREATE FUNCTION UF_DOANHTHU(@NGAY INT,@THANG INT,@NAM INT)
RETURNS @DT TABLE(NGAY INT,THANG INT,NAM INT,TONGDOANHTHU INT)
AS
BEGIN
	DECLARE @TONGDOANHTHU INT = 0
	DECLARE CS_DUYET CURSOR
	FOR SELECT TONGTIEN FROM tbl_HOADON WHERE DAY(NGAYLAP)=@NGAY AND MONTH(NGAYLAP)=@THANG AND YEAR(NGAYLAP)=@NAM
	OPEN CS_DUYET
	DECLARE @TIEN INT
	FETCH NEXT FROM CS_DUYET INTO @TIEN
	WHILE(@@FETCH_STATUS =0)
	BEGIN
		SET @TONGDOANHTHU+=@TIEN
		FETCH NEXT FROM CS_DUYET INTO @TIEN
	END
	CLOSE CS_DUYET
	DEALLOCATE CS_DUYET
	INSERT INTO @DT VALUES(@NGAY,@THANG,@NAM,@TONGDOANHTHU)
	RETURN 
END

--------------------------------SẢN PHẨM----------------------------------------
--Insert Sản phẩm
--Proc bảng sản phẩm
--Bảng sản phẩm
go
CREATE PROCEDURE SP_Insert_THUOC_CTTHUOC
   @maloai varchar(10),
	@TenSP nvarchar(50), 
	@ThanhPhan nvarchar(50),
	@GiaNhap float,
	@GiaBan float ,
	@SoLuongTon int
AS
BEGIN 
	INSERT INTO tbl_thuoc(maloai)
	VALUES(@maloai)

	DECLARE @masp varchar(10) 
	SET @masp = (SELECT TOP 1 masp FROM tbl_thuoc ORDER BY SoThuTu DESC)

	INSERT INTO tbl_CTTHUOC (MaSP, TenSP, ThanhPhan, GiaNhap,GiaBan,SoLuongTon)
    VALUES (@MaSP, @TenSP, @ThanhPhan,@GiaNhap,@GiaBan,@SoLuongTon )	
END
go


--Tìm kiếm theo tên thuốc 
go
CREATE PROCEDURE SP_TimTheoTenThuoc
    @TenThuoc NVARCHAR(50)
AS
BEGIN
    SELECT
        MaSP,
        TenSP,
        ThanhPhan,
        GiaNhap,
        GiaBan,
        SoLuongTon
    FROM tbl_CTTHUOC
    WHERE TenSP LIKE '%' + @TenThuoc + '%';
END;
go
--Lọc theo loại thuốc
CREATE PROC SP_LocTheoLoaiThuoc
@LoaiThuoc nvarchar(5)
AS
BEGIN
	SELECT
        c.MaSP,
        TenSP,
        ThanhPhan,
        GiaNhap,
        GiaBan,
        SoLuongTon
    FROM tbl_CTTHUOC c
	INNER JOIN tbl_THUOC t ON c.MaSP=t.MaSP
    WHERE t.MaLoai=@LoaiThuoc
END
go
--Lọc theo tên bệnh
CREATE PROC SP_LocTheoTenBenh
@LoaiBenh varchar(5)
AS
BEGIN
	SELECT c.MaSP, TenSP, ThanhPhan, GiaNhap, GiaBan, SoLuongTon
	FROM tbl_BENH b,tbl_CTTHUOC c, tbl_DIEUTRI d
	WHERE b.MaBenh=@LoaiBenh AND b.MaBenh=d.MaBenh AND c.MaSP=d.MaSP
END
go
--Lọc theo tên bệnh lẫn loại
CREATE PROC SP_LocTheoBenh_Loai
@LoaiBenh varchar(5), @LoaiThuoc varchar(5)
AS
BEGIN
	SELECT c.MaSP, TenSP, ThanhPhan, GiaNhap, GiaBan, SoLuongTon
	FROM tbl_BENH b,tbl_CTTHUOC c, tbl_DIEUTRI d, tbl_THUOC t, tbl_LOAI l
	WHERE b.MaBenh=@LoaiBenh AND b.MaBenh=d.MaBenh AND c.MaSP=d.MaSP AND c.MaSP=t.MaSP AND l.MaLoai=@LoaiThuoc AND l.MaLoai=t.MaLoai
END
go
-----------------INSERT DỮ LIỆU-----------------------
--Bảng loại
INSERT INTO tbl_LOAI
VALUES('L001',N'Thực phẩm chức năng')
INSERT INTO tbl_LOAI
VALUES('L002',N'Thiết bị y tế')
INSERT INTO tbl_LOAI
VALUES('L003',N'Dược phẩm')
INSERT INTO tbl_LOAI
VALUES('L004',N'Chăm sóc sức khỏe')

--Bảng bệnh
INSERT INTO tbl_BENH
VALUES('B001',N'Bệnh cảm sốt')
INSERT INTO tbl_BENH
VALUES('B002',N'Bệnh ho khan, bệnh')
insert into tbl_BENH
values('B003',N'Các bệnh ngoài da')
insert into tbl_BENH
values('B004',N'Các loại khác')

--Proc bảng sản phẩm
--Bảng sản phẩm

GO
exec SP_Insert_THUOC_CTTHUOC 'L001',N'Acetylcystein',N'Các chất tổng hợp',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L001',N'Avircrem',N'Các chất điều vị',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L001',N'Salonpas pain relief patch',N'Các Vitamin cần thiết',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L003',N'Dung dịch Natri clorid 0,9%',N'Các Chất khoáng, muối khoáng Natri clorua',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L003',N'Farzincol',N'Các Chất điều tiết nội tiết tố',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L003',N'Phosphalugel',N'Các Vitamin trị bệnh',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L002',N'Eszopiclone',N'Các Vitamin trị bệnh',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L002',N'5-Fluorouracil Ebewe',N'Các Vitamin trị bệnh',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L004',N'Que thử thai nhanh HCG Allissa',N'Các chất hóa học test nhanh',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L004',N'Băng keo cá nhân Urgo',N'Chất kết dính và các hợp chất khác',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L004',N'Bông y tế',N'Bông tổng hợp',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L004',N'Khẩu trang Mebiphar',N'Vải kháng khuẩn',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L004',N'Khẩu trang Kháng khuẩn',N'Vải kháng khuẩn',0,0,0
exec SP_Insert_THUOC_CTTHUOC 'L004',N'Máy đo huyết áp điện tử',Null,0,0,0
GO
--Bảng điều trị
--insert into tbl_DIEUTRI
--values

--Bảng quận huyện

insert into tbl_QUANHUYEN
values(N'Quận 1')
insert into tbl_QUANHUYEN
values(N'Thành phố Thủ Đức')
insert into tbl_QUANHUYEN
values(N'Quận 3')
insert into tbl_QUANHUYEN
values(N'Quận 4')
insert into tbl_QUANHUYEN
values(N'Quận 5')
insert into tbl_QUANHUYEN
values(N'Quận 6')
insert into tbl_QUANHUYEN
values(N'Quận 7')
insert into tbl_QUANHUYEN
values(N'Quận 8')
insert into tbl_QUANHUYEN
values(N'Quận 10')
insert into tbl_QUANHUYEN
values(N'Quận 11')
insert into tbl_QUANHUYEN
values(N'Quận 12')
insert into tbl_QUANHUYEN
values(N'Quận Bình Tân')
insert into tbl_QUANHUYEN
values(N'Quận Tân Bình')
insert into tbl_QUANHUYEN
values(N'Quận Tân Phú')
insert into tbl_QUANHUYEN
values(N'Quận Bình Thạnh')
insert into tbl_QUANHUYEN
values(N'Quận Phú Nhuận')
insert into tbl_QUANHUYEN
values(N'Quận Gò Vấp')
insert into tbl_QUANHUYEN
values(N'Huyện Hóc Môn')
insert into tbl_QUANHUYEN
values(N'Huyện Cần Giờ')
insert into tbl_QUANHUYEN
values(N'Huyện Nhà Bè')
insert into tbl_QUANHUYEN
values(N'Huyện Củ Chi')
insert into tbl_QUANHUYEN
values(N'Huyện Bình Chánh')
GO

--Thêm bảng Tài khoản, quản lý, dược sĩ và chi tiết tài khoản, sịn sịn
GO
exec sp_ThemTaiKhoan 'TranThanhLuan2003','123456',N'Quản lý',N'Trần Thành Luân','31-01-2003',N'Nam',N'123 Lê Trọng Tấn',14,'0913154112','tranthanhluan@gmail.com'
exec sp_ThemTaiKhoan 'HuynhKhanhNam2003','hihihi',N'Dược sĩ',N'Huỳnh Khánh Nam','11-11-2003',N'Nam',N'456 Lê Trọng Tấn',14,'0914165117','huynhkhanhnam@gmail.com'
exec sp_ThemTaiKhoan 'HuynhHuuKhanh317','hahaha',N'Dược sĩ',N'Huỳnh Vương Hữu Khánh','30-11-2003',N'Nam',N'49 Bùi Quang Là',17,'0908165166','huynhhuukhanh@gmail.com'
exec sp_ThemTaiKhoan 'LeMinhKhoa2003','huhuhu',N'Dược sĩ',N'Lê Minh Khoa','18-7-2003',N'Nam',N'789 Võ Thị Sáu',1,'0904176155','leminhkhoa@gmail.com'
exec sp_ThemTaiKhoan 'NguyenBaoLongAdmin','admin',N'Quản lý',N'Nguyễn Bảo Long','18-8-2003',N'Nam',N'789 Hương Lộ 2',18,'0904176155','nguyenbaolong@gmail.com'


--Thêm bảng Khách hàng
GO
exec themKH N'Võ Thị Hoài Anh','0903165166',N'Nam','hoaianh@gmail.com',N'17 Võ Văn Tần',9
exec themKH N'Võ Hoài Linh','0903165177',N'Nam','hoailinhdanhhai@gmail.com',N'17 Võ Thị Sáu',6
exec themKH N'Võ Vũ Trường Giang','0912166987',N'Nam','truonggiangdanhhai@gmail.com',N'13 Võ Thị Sáu',6
exec themKH N'Nguyễn Trần Trung Quân','0912166712',N'Nam','trungquanidol@gmail.com',N'13 Võ Văn Kiệt',9
--Thêm bảng Nhà cung cấp
exec sp_ThemNhaCungCap N'Sanduocpham.vn', '19003636', 'Sanduocphamvn@gmail.com', N'20 Lê Lai', 1
exec sp_ThemNhaCungCap N'Nhà thuốc 365', '19006366', 'nhathuoc365@gmail.com', N'20 Lý Chiêu Hoàng', 5
exec sp_ThemNhaCungCap N'Sàn thuốc Hapu', '19001515', 'nhathuochanu@gmail.com', N'165 Nguyễn Văn Luông', 5
exec sp_ThemNhaCungCap N'Chợ thuốc sỉ Quận 10', '19005151', 'chothuocq10@gmail.com', N'134 Tô Hiến Thành', 8
exec sp_ThemNhaCungCap N'Thuốc sĩ VN', '19001155', 'nhathuocsivn@gmail.com', N'90 Nguyễn Hoàng', 16
GO
--Thêm bảng trạng thái
INSERT INTO tbl_TRANGTHAI
VALUES('1',N'Chưa nhận đủ')
INSERT INTO tbl_TRANGTHAI
VALUES('2',N'Nhận đủ')


--Thêm phiếu nhập
SET DATEFORMAT dmy
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC01','DS001','15-11-2023','2')
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC02','DS001','15-11-2023','2')
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC01','DS002','15-11-2023','2')
--Thêm thông tin phiếu nhập
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC02','DS003','29-12-2023','2')
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC03','DS002','29-12-2023','2')
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC04','DS002','27-12-2023','2')
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC05','DS002','27-12-2023','2')
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC05','DS001','18-12-2023','2')
INSERT INTO tbl_PHIEUNHAP
VALUES('NCC05','DS003','18-12-2023','2')

--Thêm Chi tiết Phiếu nhập

--Nếu lỗi sửa thành PN001, PN002, PN003
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN001','SP001',120,120,145000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN002','SP002',120,120,195000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN003','SP003',200,200,225000)
-- Thêm thông tin Chi tiết phiếu nhập
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN001','SP004',200,200,100000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN001','SP005',200,200,110000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN001','SP007',300,300,170000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN002','SP006',30,30,120000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN002','SP010',35,35,220000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN004','SP011',34,34,270000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN005','SP012',40,40,70000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN003','SP008',340,340,20000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN003','SP009',70,70,225000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN003','SP011',300,300,275000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN003','SP012',300,300,155000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN003','SP013',300,300,275000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN006','SP008',100,100,255000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN007','SP009',100,100,195000)
INSERT INTO tbl_CTPHIEUNHAP
VALUES('PN008','SP014',10,10,195000)

--Thêm hóa đơn
INSERT INTO tbl_HOADON
VALUES('DS001','30-12-2023',0,'KH001')
INSERT INTO tbl_HOADON
VALUES('DS002','30-12-2023',0,'KH002')
INSERT INTO tbl_HOADON
VALUES('DS003','31-12-2023',0,'KH003')
INSERT INTO tbl_HOADON
VALUES('DS001','27-12-2023',0,'KH002')
INSERT INTO tbl_HOADON
VALUES('DS001','21-12-2023',0,'KH003')
INSERT INTO tbl_HOADON
VALUES('DS001','11-12-2023',0,'KH004')
INSERT INTO tbl_HOADON
VALUES('DS002','17-12-2023',0,'KH004')
INSERT INTO tbl_HOADON
VALUES('DS003','17-12-2023',0,'KH004')

--Thêm bảng điều trị
insert into tbl_DIEUTRI
values('B001','SP001')
insert into tbl_DIEUTRI
values('B001','SP002')
insert into tbl_DIEUTRI
values('B002','SP002')
insert into tbl_DIEUTRI
values('B001','SP004')
insert into tbl_DIEUTRI
values('B001','SP003')
insert into tbl_DIEUTRI
values('B002','SP005')
insert into tbl_DIEUTRI
values('B002','SP006')
insert into tbl_DIEUTRI
values('B003','SP007')
insert into tbl_DIEUTRI
values('B003','SP008')
insert into tbl_DIEUTRI
values('B001','SP009')
insert into tbl_DIEUTRI
values('B001','SP010')
insert into tbl_DIEUTRI
values('B002','SP011')
insert into tbl_DIEUTRI
values('B004','SP012')
insert into tbl_DIEUTRI
values('B004','SP013')
--insert into tbl_DIEUTRI
--values('B003','SP023')
--select * from tbl_CTTHUOC
--insert into tbl_DIEUTRI
--values('B003','SP024')
--insert into tbl_DIEUTRI
--values('B003','SP025')
--insert into tbl_DIEUTRI
--values('B003','SP026')
--insert into tbl_DIEUTRI
--values('B003','SP027')
--insert into tbl_DIEUTRI
--values('B004','SP015')
--insert into tbl_DIEUTRI
--values('B004','SP016')
--insert into tbl_DIEUTRI
--values('B004','SP017')
--insert into tbl_DIEUTRI
--values('B004','SP018')
--insert into tbl_DIEUTRI
--values('B004','SP019')
--insert into tbl_DIEUTRI
--values('B004','SP020')
--insert into tbl_DIEUTRI
--values('B004','SP021')
--insert into tbl_DIEUTRI
--values('B004','SP022')




----------PHẦN ĐẦU-------------------------------------------ĐẶNG HOÀNG PHÚC-----------------------------------
--------------CHỈNH SỬA
--Cho trạng thái là nhận đủ hàng khi Số lượng đặt bằng với số lượng nhận, MaTrangThai=1 có thể hiểu là nhận chưa đủ hàng
--ALTER TRIGGER TRG_TRANGTHAI_PHIEUNHAP_TENTRANGTHAI 
--ON tbl_CTPHIEUNHAP
--AFTER INSERT, UPDATE
--AS
--BEGIN
--	DECLARE @MaPN varchar(5), @SoLuongDat int, @SoLuongNhan int,@DemsoCTPN int=0, @DemsoCTPN_Du int=0

--	SELECT @MaPN = MaPN, @SoLuongDat = SoLuongDat, @SoLuongNhan = SoLuongNhan,@DemsoCTPN=1
--	FROM inserted

--	--IF @SoLuongNhan < @SoLuongDat
--	--BEGIN
--	--	UPDATE tbl_PHIEUNHAP
--	--	SET MaTrangThai = '1'
--	--	WHERE MaPN = @MaPN
--	--END
--	--ELSE 
--	IF @SoLuongNhan = @SoLuongDat
--	BEGIN
--		--UPDATE tbl_PHIEUNHAP
--		--SET MaTrangThai = '2'
--		--WHERE MaPN = @MaPN
--		Set @DemsoCTPN_Du=1
--	END
--	DECLARE CS_DUYET CURSOR
--	FOR SELECT MACTPN,SOLUONGNHAN,SOLUONGDAT FROM tbl_CTPHIEUNHAP WHERE MaPN=@MaPN
--	DECLARE @MACTPN VARCHAR(15)
--	OPEN CS_DUYET
--	FETCH NEXT FROM CS_DUYET INTO @MACTPN,@SoLuongNhan,@SoLuongDat
--	WHILE(@@FETCH_STATUS=0)
--	BEGIN
--		Set @DemsoCTPN+=1
--		IF @SoLuongNhan=@SoLuongDat
--		BEGIN
--			Set @DemsoCTPN_Du+=1
--		END
--		FETCH NEXT FROM CS_DUYET INTO @MACTPN,@SoLuongNhan,@SoLuongDat
--	END
--	CLOSE CS_DUYET
--	DEALLOCATE CS_DUYET
--	IF @DemsoCTPN_Du<@DemsoCTPN
--	BEGIN
--		UPDATE tbl_PHIEUNHAP
--		SET MaTrangThai = '1'
--		WHERE MaPN = @MaPN
--	END
--	ELSE IF @DemsoCTPN_Du=@DemsoCTPN
--	BEGIN
--		UPDATE tbl_PHIEUNHAP
--		SET MaTrangThai = '2'
--		WHERE MaPN = @MaPN
--	END
--END
-- Top 5 Thuốc Bán Chạy --
--go
--CREATE FUNCTION UF_TOP5THUOCBANCHAY(@THANG INT,@NAM INT)
--RETURNS @DT TABLE(TENTHUOC NVARCHAR(50),SOLUONG INT)
--AS
--BEGIN
--	DECLARE @TONGSL INT ,@TEN NVARCHAR(50)
--	DECLARE CS_DUYET CURSOR
--	FOR SELECT	TenSP , SUM(SoLuong)
--		FROM tbl_HOADON AS HD
--		JOIN tbl_CTHOADON AS CTHD ON CTHD.MaHD=HD.MaHD
--		JOIN tbl_THUOC AS TH ON TH.MaSP=CTHD.MaSP
--		JOIN tbl_CTTHUOC AS CTTH ON TH.MaSP=CTTH.MaSP
--		WHERE MONTH(NgayLap)=@THANG AND YEAR(NgayLap)=@NAM
--		GROUP BY TenSP
--	OPEN CS_DUYET 
--	FETCH NEXT FROM CS_DUYET INTO @TEN,@TONGSL
--	WHILE(@@FETCH_STATUS=0)
--	BEGIN
--		INSERT INTO @DT VALUES(@TEN,@TONGSL)
--		FETCH NEXT FROM CS_DUYET INTO @TEN,@TONGSL
--	END
--	CLOSE CS_DUYET
--	DEALLOCATE CS_DUYET
--	RETURN
--END
--GO
-- Doanh Thu --
--go
--CREATE FUNCTION UF_DOANHTHU(@NGAY INT,@THANG INT,@NAM INT)
--RETURNS @DT TABLE(NGAY INT,THANG INT,NAM INT,TONGDOANHTHU INT)
--AS
--BEGIN
--	DECLARE @TONGDOANHTHU INT = 0
--	DECLARE CS_DUYET CURSOR
--	FOR SELECT TONGTIEN FROM tbl_HOADON WHERE DAY(NGAYLAP)=@NGAY AND MONTH(NGAYLAP)=@THANG AND YEAR(NGAYLAP)=@NAM
--	OPEN CS_DUYET
--	DECLARE @TIEN INT
--	FETCH NEXT FROM CS_DUYET INTO @TIEN
--	WHILE(@@FETCH_STATUS =0)
--	BEGIN
--		SET @TONGDOANHTHU+=@TIEN
--		FETCH NEXT FROM CS_DUYET INTO @TIEN
--	END
--	CLOSE CS_DUYET
--	DEALLOCATE CS_DUYET
--	INSERT INTO @DT VALUES(@NGAY,@THANG,@NAM,@TONGDOANHTHU)
--	RETURN 
--END
--GO
--------------------------------PHIẾU NHẬP---------------------------------------
-------------------DANH SÁCH PHIẾU NHẬP
GO
CREATE PROC USP_DANHSACHPHIEUNHAP
AS 
BEGIN
	SELECT PN.SoThuTu AS N'STT',PN.MAPN AS N'Mã PN',TENNCC AS N'Tên nhà cung cấp',CTTK.TenNguoiDung AS N'Tên dược sỹ',NGAYNHAP AS N'Ngày nhập',TENTRANGTHAI AS N'Trạng thái'
	FROM TBL_PHIEUNHAP AS PN
	JOIN tbl_NHACUNGCAP AS NCC ON NCC.MANCC=PN.MANCC
	JOIN TBL_DUOCSI AS DS ON DS.MADUOCSI=PN.MADUOCSI
	JOIN TBL_TRANGTHAI AS TT ON TT.MATRANGTHAI=PN.MATRANGTHAI
	JOIN tbl_CHITIETTAIKHOAN AS CTTK ON CTTK.TenDangNhap=DS.TenDangNhap
END
GO
-------------------LỌC DANH SÁCH PHIẾU NHẬP THEO NGÀY NHẬP
GO
CREATE PROC USP_LOCDANHSACHPHIEUNHAP
@NGAYNHAP DATETIME
AS 
BEGIN
	SELECT PN.SoThuTu AS N'STT',PN.MAPN AS N'Mã PN',TENNCC AS N'Tên nhà cung cấp',CTTK.TenNguoiDung AS N'Tên dược sỹ',NGAYNHAP AS N'Ngày nhập',TENTRANGTHAI AS N'Trạng thái'
	FROM TBL_PHIEUNHAP AS PN
	JOIN tbl_NHACUNGCAP AS NCC ON NCC.MANCC=PN.MANCC
	JOIN TBL_DUOCSI AS DS ON DS.MADUOCSI=PN.MADUOCSI
	JOIN TBL_TRANGTHAI AS TT ON TT.MATRANGTHAI=PN.MATRANGTHAI
	JOIN tbl_CHITIETTAIKHOAN AS CTTK ON CTTK.TenDangNhap=DS.TenDangNhap
	WHERE PN.NgayNhap=CAST(@NGAYNHAP AS DATE)
END
GO
-------------------TÌM PHIẾU NHẬP THEO TÊN NHÀ CUNG CẤP
GO
CREATE PROC USP_TIMPHIEUNHAPTHEOTENNCC
@TENNCC NVARCHAR(50)
AS
BEGIN
	SELECT PN.SoThuTu AS N'STT',PN.MAPN AS N'Mã PN',TENNCC AS N'Tên nhà cung cấp',CTTK.TenNguoiDung AS N'Tên dược sỹ',NGAYNHAP AS N'Ngày nhập',TENTRANGTHAI AS N'Trạng thái'
	FROM TBL_PHIEUNHAP AS PN
	JOIN TBL_CTPHIEUNHAP AS CTPN ON CTPN.MaPN=PN.MaPN
	JOIN tbl_NHACUNGCAP AS NCC ON NCC.MANCC=PN.MANCC
	JOIN TBL_DUOCSI AS DS ON DS.MADUOCSI=PN.MADUOCSI
	JOIN TBL_TRANGTHAI AS TT ON TT.MATRANGTHAI=PN.MATRANGTHAI
	JOIN tbl_TAIKHOAN AS TK ON TK.TenDangNhap=DS.TenDangNhap
	JOIN tbl_CHITIETTAIKHOAN AS CTTK ON CTTK.TenDangNhap=TK.TenDangNhap
	WHERE NCC.TenNCC=@TENNCC
END
Go
-------------------LẤY TÊN LOẠI THUỐC DỰ VÀO TÊN THUỐC
GO
CREATE PROC USP_LAYTENLOAITHUOC
@TenSP NVARCHAR(50)
AS
BEGIN
	SELECT L.TenLoai
	FROM tbl_LOAI AS L
	JOIN tbl_THUOC AS TH ON TH.MaLoai=L.MaLoai
	JOIN tbl_CTTHUOC AS CTTH ON CTTH.MaSP=TH.MaSP
	WHERE CTTH.TenSP=@TenSP
END
GO
-------------------DANH SÁCH CHI TIẾT PHIẾU NHẬP
GO 
CREATE PROC USP_DANHSACHCTPN
@MAPN VARCHAR(5)
AS
BEGIN
	SELECT MaCTPN AS N'Mã chi tiết phiếu nhập',TenSP AS N'Tên thuốc',
	SoLuongDat AS  N'Số lượng đặt', SoLuongNhan AS N'Số lượng nhận',DonGiaNhap AS N'Đơn giá'
	FROM tbl_CTPHIEUNHAP AS CTPN
	JOIN tbl_CTTHUOC AS CTTH ON CTTH.MaSP=CTPN.MaSP
	WHERE CTPN.MaPN=@MAPN
END
GO
-------------------THÊM PHIẾU NHẬP
GO
CREATE PROC USP_THEMPHIEUNHAP
@MANCC VARCHAR(5),@MADUOCSI VARCHAR(5)
AS
BEGIN
	INSERT INTO TBL_PHIEUNHAP VALUES(@MANCC,@MADUOCSI,GETDATE(),'1')
END
GO
-------------------XÓA PHIẾU NHẬP
GO
CREATE PROC USP_XOAPHIEUNHAP
@MAPN VARCHAR(5)
AS
BEGIN
	DECLARE @MACTPN VARCHAR(15)
	DECLARE CS_DUYET CURSOR
	FOR SELECT MaCTPN FROM tbl_CTPHIEUNHAP WHERE MaPN=@MAPN
	OPEN CS_DUYET
	FETCH NEXT FROM CS_DUYET INTO @MACTPN
	WHILE(@@FETCH_STATUS=0)
	BEGIN
		DELETE tbl_CTPHIEUNHAP WHERE MaCTPN=@MACTPN
		FETCH NEXT FROM CS_DUYET INTO @MACTPN
	END
	CLOSE CS_DUYET
	DEALLOCATE CS_DUYET
	DELETE tbl_PHIEUNHAP WHERE MaPN=@MAPN
END
GO
-------------------THÊM CTPN
GO
CREATE PROC USP_THEMCTPN
@MAPN VARCHAR(5), @MASP VARCHAR(5),@SOLUONGDAT INT,@SOLUONGNHAN INT,@DONGIANHAP INT
AS
BEGIN
	INSERT INTO tbl_CTPHIEUNHAP VALUES(@MAPN,@MASP,@SOLUONGDAT,@SOLUONGNHAN,@DONGIANHAP)
END
GO

-------------------DANH SÁCH THUỐC THEO LOẠI
GO
CREATE PROC USP_DANHSACHTHUOCTHEOLOAI
@MALOAI VARCHAR(5)
AS
BEGIN
	SELECT TH.MaSP,CTTH.TenSP
	FROM tbl_THUOC AS TH
	JOIN tbl_CTTHUOC AS CTTH ON CTTH.MaSP=TH.MaSP
	WHERE TH.MaLoai=@MALOAI
END
GO

