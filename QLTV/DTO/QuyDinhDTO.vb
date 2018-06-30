Public Class QuyDinhDTO
    Private iID As Integer
    Private iTuoiToiDa As Integer
    Private iTuoiToiThieu As Integer
    Private iThoiGianSuDung As Integer
    Private iKhoangCachNamXuatBan As Integer
    Private iSachMuonToiDa As Integer
    Private iNgayMuonToiDa As Integer

    Public Sub New()
        ID = 0
        iTuoiToiDa = 0
        iTuoiToiThieu = 0
        iThoiGianSuDung = 0
        iKhoangCachNamXuatBan = 0
        iSachMuonToiDa = 0
        iNgayMuonToiDa = 0

    End Sub
    Public Sub New(id As Integer, iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iThoiGianSuDung As Integer, iKhoangCachNamXuatBan As Integer, iSachMuonToiDa As String, iNgayMuonToiDa As String)
        Me.iID = id
        Me.iTuoiToiThieu = iTuoiToiThieu
        Me.iTuoiToiDa = iTuoiToiDa
        Me.iThoiGianSuDung = iThoiGianSuDung
        Me.iKhoangCachNamXuatBan = iKhoangCachNamXuatBan
        Me.iSachMuonToiDa = iSachMuonToiDa
        Me.iNgayMuonToiDa = iNgayMuonToiDa
    End Sub
    Public Property NgayMuonToiDa As Integer
        Get
            Return iNgayMuonToiDa
        End Get
        Set(value As Integer)
            iNgayMuonToiDa = value
        End Set
    End Property
    Public Property SachMuonToiDa As Integer
        Get
            Return iSachMuonToiDa
        End Get
        Set(value As Integer)
            iSachMuonToiDa = value
        End Set
    End Property
    Public Property KhoangCachNamXuatBan As Integer
        Get
            Return iKhoangCachNamXuatBan
        End Get
        Set(value As Integer)
            iKhoangCachNamXuatBan = value
        End Set
    End Property
    Public Property TuoiToiThieu As Integer
        Get
            Return iTuoiToiThieu
        End Get
        Set(value As Integer)
            iTuoiToiThieu = value
        End Set
    End Property

    Public Property TuoiToiDa As Integer
        Get
            Return iTuoiToiDa
        End Get
        Set(value As Integer)
            iTuoiToiDa = value
        End Set
    End Property

    Public Property ThoiGianSuDung As Integer
        Get
            Return iThoiGianSuDung
        End Get
        Set(value As Integer)
            iThoiGianSuDung = value
        End Set
    End Property
    Public Property ID As Integer
        Get
            Return iID
        End Get
        Set(value As Integer)
            iID = value
        End Set
    End Property
End Class

