Public Class DocGiaDTO
    Private strMaDG As String
    Private strTenDG As String
    Private iMaLDG As Integer
    Private dateNgaySinh As DateTime
    Private strDiaChi As String
    Private strEmail As String
    Private dateNgayLapThe As DateTime
    'Private strNguoiLapThe As String
    Private dateNgayHetHan As DateTime
    Private strGioiTinh As String
    Public Sub New()
    End Sub

    Public Sub New(strMaDG As Integer, strTenDG As String, iMaLDG As Integer, dateNgaySinh As DateTime, strDiaChi As String, strEmail As String, dateNgayLapThe As DateTime, dateNgayHetHan As DateTime, strGioiTinh As String)
        Me.strMaDG = strMaDG
        Me.strTenDG = strTenDG
        Me.iMaLDG = iMaLDG
        Me.dateNgaySinh = dateNgaySinh
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.dateNgayLapThe = dateNgayLapThe
        ' Me.strNguoiLapThe = strNguoiLapThe
        Me.dateNgayHetHan = dateNgayHetHan
        Me.strGioiTinh = strGioiTinh

    End Sub
    Public Property MaDG() As String
        Get
            Return strMaDG
        End Get
        Set(value As String)
            strMaDG = value
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
    Public Property MaLDG As Integer
        Get
            Return iMaLDG
        End Get
        Set(value As Integer)
            iMaLDG = value
        End Set
    End Property
    Public Property NgaySinh() As DateTime
        Get
            Return dateNgaySinh
        End Get
        Set(value As DateTime)
            dateNgaySinh = value
        End Set
    End Property
    Public Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property NgayLapThe() As DateTime
        Get
            Return dateNgayLapThe
        End Get
        Set(value As DateTime)
            dateNgayLapThe = value
        End Set
    End Property
    ' Public Property NguoiLapThe() As String
    'Get
    'Return strNguoiLapThe
    'End Get
    'Set(value As String)
    '       strNguoiLapThe = value
    'End Set
    'End Property
    Public Property NgayHetHan() As DateTime
        Get
            Return dateNgayHetHan
        End Get
        Set(value As DateTime)
            dateNgayHetHan = value
        End Set
    End Property
    Public Property GioiTinh() As String
        Get
            Return strGioiTinh
        End Get
        Set(value As String)
            strGioiTinh = value
        End Set
    End Property
End Class
