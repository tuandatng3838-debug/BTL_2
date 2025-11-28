CREATE TABLE GiaoVien (
    MaSoCB NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    QueQuan NVARCHAR(200),
    DanToc NVARCHAR(50),
    TonGiao NVARCHAR(50),
    SDT NVARCHAR(20),
    TrinhDoChuyenMon NVARCHAR(100),
    TrinhDoLLCT NVARCHAR(100),
    DonViCongTac NVARCHAR(200),
    ChucVu NVARCHAR(100),
    CapBac NVARCHAR(100),
    HeSoLuong DECIMAL(5,2),
    ChucDanh NVARCHAR(100),
    HocHam NVARCHAR(100),
    HocVi NVARCHAR(100),
    LinhVucChuyenMon NVARCHAR(200),
    NamDayGioiGanNhat INT
);

CREATE TABLE HoiGiang (
    MaHoiGiang INT IDENTITY PRIMARY KEY,
    MaSoCB NVARCHAR(20) NOT NULL,
    HoTenGV NVARCHAR(100),
    CapBac NVARCHAR(100),
    DonViCongTac NVARCHAR(200),
    ChucDanhGiangDay NVARCHAR(50),
    TenBai NVARCHAR(200),
    ThuocHocPhan NVARCHAR(200),
    ThucHienTaiLop NVARCHAR(100),
    ThoiGianThucHien DATE,
    CapThucHien NVARCHAR(50),
    NamHoc NVARCHAR(20),
    CONSTRAINT FK_HoiGiang_GiaoVien FOREIGN KEY (MaSoCB) REFERENCES GiaoVien(MaSoCB)
);

CREATE TABLE HoiDong (
    MaHoiDong INT IDENTITY PRIMARY KEY,
    MaHoiGiang INT NOT NULL,
    GhiChu NVARCHAR(500),
    CONSTRAINT FK_HoiDong_HoiGiang FOREIGN KEY (MaHoiGiang) REFERENCES HoiGiang(MaHoiGiang)
);

CREATE TABLE HoiDong_ThanhVien (
    MaThanhVien INT IDENTITY PRIMARY KEY,
    MaHoiDong INT NOT NULL,
    MaSoCB NVARCHAR(20) NOT NULL,
    HoTen NVARCHAR(100),
    CapBac NVARCHAR(100),
    ChucDanhGiangDay NVARCHAR(50),
    ChucDanhTrongHoiDong NVARCHAR(50),
    CONSTRAINT FK_ThanhVien_HoiDong FOREIGN KEY (MaHoiDong) REFERENCES HoiDong(MaHoiDong),
    CONSTRAINT FK_ThanhVien_GiaoVien FOREIGN KEY (MaSoCB) REFERENCES GiaoVien(MaSoCB)
);

CREATE TABLE PhieuChamDiem (
    MaPhieu INT IDENTITY PRIMARY KEY,
    MaHoiGiang INT NOT NULL,
    MaSoCBThanhVien NVARCHAR(20) NOT NULL,
    DiemHieuBiet DECIMAL(5,2),
    DiemGioiThieu DECIMAL(5,2),
    DiemThucHanh DECIMAL(5,2),
    GhiChu NVARCHAR(500),
    CONSTRAINT FK_Phieu_HoiGiang FOREIGN KEY (MaHoiGiang) REFERENCES HoiGiang(MaHoiGiang),
    CONSTRAINT FK_Phieu_GiaoVien FOREIGN KEY (MaSoCBThanhVien) REFERENCES GiaoVien(MaSoCB)
);

CREATE TABLE KetQuaHoiGiang (
    MaKetQua INT IDENTITY PRIMARY KEY,
    MaHoiGiang INT NOT NULL UNIQUE,
    TongDiemHieuBiet DECIMAL(5,2),
    TongDiemGioiThieu DECIMAL(5,2),
    DiemThucHanhTrungBinh DECIMAL(5,2),
    TongDiem DECIMAL(5,2),
    XepLoai NVARCHAR(50),
    GiaiThuong NVARCHAR(50),
    CONSTRAINT FK_KetQua_HoiGiang FOREIGN KEY (MaHoiGiang) REFERENCES HoiGiang(MaHoiGiang)
);
