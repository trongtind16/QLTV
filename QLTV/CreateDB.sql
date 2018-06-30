USE [master]
	GO

	WHILE EXISTS(select NULL from sys.databases where name='QLTV')
	BEGIN
		DECLARE @SQL varchar(max)
		SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
		FROM MASTER..SysProcesses
		WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
		EXEC(@SQL)
		DROP DATABASE [QLTV]
	END
	GO

CREATE DATABASE [QLTV]
GO

USE [QLTV]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[LoaiDocGia](
	[MaLDG] [int] NOT NULL,
	[TenLDG] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[MaLDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [QLTV]
GO
INSERT INTO[dbo].[LoaiDocGia]([MaLDG],[TenLDG]) VALUES(1,N'X')
GO
INSERT INTO[dbo].[LoaiDocGia]([MaLDG],[TenLDG]) VALUES(2,N'Y')
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[DocGia](
	[MaDG] [nvarchar](10) NOT NULL,
	[MaLDG] [int] NOT NULL,
	[TenDG] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NgaySinh] datetime NOT NULL,
	[NgayLapThe] datetime NOT NULL,
	[NgayHetHan] datetime NOT NULL,
	[GioiTinh] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DocGia_tbl_LoaiDocGia] FOREIGN KEY([MaLDG])
REFERENCES [dbo].[LoaiDocGia] ([MaLDG])
GO

GO
USE [QLTV]
GO

INSERT INTO [dbo].[DocGia]([MaDG],[TenDG],[MaLDG],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NgayHetHan],[GioiTinh]) 
	VALUES(N'17000001',N'Nguyễn Văn An',1,'12/30/2017',N'134 Cộng Hòa, Quận Tân Bình, TP HCM','123@gmail.com','12/30/2017', '12/30/2017', N'Nam')
GO
INSERT INTO [dbo].[DocGia]([MaDG],[TenDG],[MaLDG],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NgayHetHan],[GioiTinh]) 
	VALUES(N'17000002',N'Nguyễn Văn',2,'12/30/2017',N'134 Cộng Hòa, Quận Tân Bình, TP HCM','123@gmail.com','12/30/2017', '12/30/2017', N'Nu')
GO
INSERT INTO [dbo].[DocGia]([MaDG],[TenDG],[MaLDG],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NgayHetHan],[GioiTinh]) 
	VALUES(N'17000005',N'Nguyễn Văn Anhhh',2,'12/30/2017',N'134 Cộng Hòa, Quận Tân Bình, TP HCM','123@gmail.com','12/30/2017', '12/30/2017', N'Nu')
GO

CREATE TABLE [dbo].[TinhTrangSach](
	[MaTTS] [int] NOT NULL,
	[TenTTS] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TinhTrangSach] PRIMARY KEY CLUSTERED 
(
	[MaTTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[TinhTrangSach]([MaTTS], [TenTTS]) 
	VALUES(1, N'Còn')
Go
INSERT INTO [dbo].[TinhTrangSach]([MaTTS], [TenTTS]) 
	VALUES(2, N'Hết')
Go

CREATE TABLE [dbo].[TheLoaiSach](
	[MaTLS] [int] NOT NULL,
	[TenTLS] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaTLS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO [dbo].[TheLoaiSach]([MaTLS], [TenTLS]) 
	VALUES(1,N'Tiểu thuyết')
	
INSERT INTO [dbo].[TheLoaiSach]([MaTLS], [TenTLS]) 
	VALUES(2,N'Truyện tranh')
GO

CREATE TABLE [dbo].[Sach](
	[MaSach] [nvarchar](8) NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[MaTLS] [int] NOT NULL,
	[TenTG] [nvarchar](50) NOT NULL,
	[NXB] [nvarchar](50) NOT NULL,
	[NamXB] [int] NOT NULL,
	[NgayNhap] datetime NOT NULL,
    [MaTTS] [int] NOT NULL,
	[TriGia] [int] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sach_tbl_TheLoaiSach] FOREIGN KEY([MaTLS])
REFERENCES [dbo].[TheLoaiSach] ([MaTLS])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sach_tbl_TinhTrangSach] FOREIGN KEY([MaTTS])
REFERENCES [dbo].[TinhTrangSach] ([MaTTS])
GO

INSERT INTO [dbo].[Sach]([MaSach], [TenSach], [MaTLS], [TenTG],[NXB],[NamXB],[NgayNhap],[MaTTS], [TriGia]) 
	VALUES(N'18001',N'Nhà giả kim', 2, N'abc', N'xyz', 2018,'12/30/2017', 1, 50000)
Go

INSERT INTO [dbo].[Sach]([MaSach], [TenSach], [MaTLS], [TenTG],[NXB],[NamXB],[NgayNhap],[MaTTS], [TriGia]) 
	VALUES(N'18002',N'tây du ký', 1, N'abc', N'xyz', 2018,'12/30/2017', 2, 50000)
Go

INSERT INTO [dbo].[Sach]([MaSach], [TenSach], [MaTLS], [TenTG],[NXB],[NamXB],[NgayNhap],[MaTTS], [TriGia]) 
	VALUES(N'18003',N'Nhà Giàu', 2, N'abc', N'xyz', 2018,'12/30/2017', 1, 50000)
Go

CREATE TABLE [dbo].[QuyDinh](
	[Id] [int] NOT NULL,
	[TuoiToiThieu] [int] NOT NULL,
	[TuoiToiDa] [int] NOT NULL,
	[ThoiGianSuDung] [int] NOT NULL,
	[KhoangCachNamXuatBan] [int] NOT NULL,
	[SachMuonToiDa] [int] NOT NULL,
	[NgayMuonToiDa] [int] NOT NULL,
 CONSTRAINT [PK_QuyDinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT INTO [dbo].[QuyDinh]([Id], [TuoiToiThieu],[TuoiToiDa],[ThoiGianSuDung],[KhoangCachNamXuatBan],[SachMuonToiDa],[NgayMuonToiDa]) 
	VALUES(1,16,58,6,8,5,4)
GO
USE [QLTV]
GO
CREATE TABLE [dbo].[MuonTraSach](
	[MaPhieu] [nchar](20) NOT NULL,
	[MaDG] [nvarchar](10) NOT NULL,
	[MaSach] [nvarchar](8) NOT NULL,
	[NgayMuon] datetime NOT NULL,
	[NgayHenTra] datetime NOT NULL,
	[NgayTra] datetime NOT NULL,
	[TinhTrangPhieuMuon] nvarchar(25) NOT NULL,
 CONSTRAINT [PK_TRASACH] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].MuonTraSach  WITH CHECK ADD  CONSTRAINT [FK_tbl_MuonTraSach_tbl_DocGia] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].MuonTraSach  WITH CHECK ADD  CONSTRAINT [FK_tbl_MuonTraSach_tbl_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
USE [QLTV]
GO
INSERT INTO [dbo].MuonTraSach([MaPhieu],[MaDG],[MaSach],[NgayMuon],[NgayHenTra],[NgayTra],[TinhTrangPhieuMuon])
	 VALUES (N'10001',N'17000001',N'18001','05/02/2018','05/29/2018','06/01/2018',N'Quá Hạn')
GO
INSERT INTO [dbo].MuonTraSach([MaPhieu],[MaDG],[MaSach],[NgayMuon],[NgayHenTra],[NgayTra],[TinhTrangPhieuMuon])
	VALUES (N'10002',N'17000002',N'18001','05/04/2018','05/28/2018','01/01/2000',N'Đang Mượn')
GO
INSERT INTO [dbo].MuonTraSach([MaPhieu],[MaDG],[MaSach],[NgayMuon],[NgayHenTra],[NgayTra],[TinhTrangPhieuMuon]) 
	VALUES (N'10003',N'17000001',N'18001','05/03/2018','05/30/2018','01/01/2000',N'Đang Mượn')
GO
 INSERT INTO [dbo].MuonTraSach([MaPhieu],[MaDG],[MaSach],[NgayMuon],[NgayHenTra],[NgayTra],[TinhTrangPhieuMuon])
 VALUES (N'10004',N'17000005',N'18003','06/03/2017','05/30/2017','01/01/2001',N'ABC')
 Go
