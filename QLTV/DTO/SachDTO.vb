Public Class SachDTO
    Private strMaSach As String
    Private strTenSach As String
    Private strMaTLS As String
    Private strTenTG As String
    Private strNXB As String
    Private iNamXB As String
    Private dateNgayNhap As DateTime
    Private strMaTTS As String
    Private iTriGia As String

    Public Sub New()
    End Sub
    Public Sub New(strMaSach As String, strTenSach As String, strMaTLS As String, strTenTG As String, strNXB As String, iNamXB As String, dateNgayNhap As DateTime, strMaTTS As String, iTriGia As String)
        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.strMaTLS = strMaTLS
        Me.strTenTG = strTenTG
        Me.strNXB = strNXB
        Me.iNamXB = iNamXB
        Me.dateNgayNhap = dateNgayNhap
        Me.strMaTTS = strMaTTS
        Me.iTriGia = iTriGia


    End Sub

    Public Property MaSach() As String
        Get
            Return strMaSach
        End Get
        Set(value As String)
            strMaSach = value
        End Set
    End Property

    Public Property TenSach() As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property MaTLS() As String
        Get
            Return strMaTLS
        End Get
        Set(value As String)
            strMaTLS = value
        End Set
    End Property

    Public Property TenTG() As String
        Get
            Return strTenTG
        End Get
        Set(value As String)
            strTenTG = value
        End Set
    End Property

    Public Property NamXB() As String
        Get
            Return iNamXB
        End Get
        Set(value As String)
            iNamXB = value
        End Set
    End Property

    Public Property NXB() As String
        Get
            Return strNXB
        End Get
        Set(value As String)
            strNXB = value
        End Set
    End Property

    Public Property NgayNhap() As DateTime
        Get
            Return dateNgayNhap
        End Get
        Set(value As Date)
            dateNgayNhap = value
        End Set
    End Property

    Public Property TriGia() As String
        Get
            Return iTriGia
        End Get
        Set(value As String)
            iTriGia = value
        End Set
    End Property

    Public Property MaTTS() As String
        Get
            Return strMaTTS
        End Get
        Set(value As String)
            strMaTTS = value
        End Set
    End Property
End Class
