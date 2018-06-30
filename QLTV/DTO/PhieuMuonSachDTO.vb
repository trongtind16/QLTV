Public Class PhieuMuonSachDTO
    Private strMaPhieu As String
    Private strMaDG As String
    Private strTenDG As String
    Private strMaSach As String
    Private strTenSach As String
    Private dateNgayMuon As DateTime
    Private dateNgayHenTra As DateTime
    Private dateNgayTra As DateTime
    Private strTinhTrangPhieuMuon As String
    Public Sub New()
    End Sub
    Public Sub New(strMaPhieu As String, strMaDG As String, strTenDG As String, strMaSach As String, strTenSach As String, dateNgayMuon As DateTime, dateNgayHenTra As DateTime, dateNgayTra As DateTime, strTinhTrangPhieuMuon As String)
        Me.strMaPhieu = strMaPhieu
        Me.strMaDG = strMaDG
        Me.strTenDG = strTenDG
        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.dateNgayMuon = dateNgayMuon
        Me.dateNgayTra = dateNgayTra
        Me.dateNgayHenTra = dateNgayHenTra
        Me.strTinhTrangPhieuMuon = strTinhTrangPhieuMuon
    End Sub
    Public Property TenSach() As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property
    Public Property TenDG() As String
        Get
            Return strTenDG
        End Get
        Set(value As String)
            strTenDG = value
        End Set
    End Property
    Public Property TinhTrangPhieuMuon() As String
        Get
            Return strTinhTrangPhieuMuon
        End Get
        Set(value As String)
            strTinhTrangPhieuMuon = value
        End Set
    End Property
    Public Property NgayTra() As DateTime
        Get
            Return dateNgayTra
        End Get
        Set(value As DateTime)
            dateNgayTra = value
        End Set
    End Property
    Public Property MaPhieu() As String
        Get
            Return strMaPhieu
        End Get
        Set(value As String)
            strMaPhieu = value
        End Set
    End Property

    Public Property MaDG() As String
        Get
            Return strMaDG
        End Get
        Set(value As String)
            strMaDG = value
        End Set
    End Property


    Public Property MaSach() As String
        Get
            Return strMaSach
        End Get
        Set(value As String)
            strMaSach = value
        End Set
    End Property

    Public Property NgayMuon() As DateTime
        Get
            Return dateNgayMuon
        End Get
        Set(value As Date)
            dateNgayMuon = value
        End Set
    End Property

    Public Property NgayHenTra As DateTime
        Get
            Return dateNgayHenTra
        End Get
        Set(value As Date)
            dateNgayHenTra = value
        End Set
    End Property
End Class

