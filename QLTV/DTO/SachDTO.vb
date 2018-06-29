Public Class SachDTO
    Private strMaSach As String
    Private strTenSach As String
    Private iMaTLS As Integer
    Private strTenTG As String
    Private strNXB As String
    Private iNamXB As String
    Private dateNgayNhap As DateTime
    Private iMaTTS As Integer
    Private iTriGia As String

    Public Sub New()
    End Sub
    Public Sub New(strMaSach As String, strTenSach As String, iMaTLS As Integer, strTenTG As String, strNXB As String, iNamXB As String, dateNgayNhap As DateTime, iMaTTS As Integer, iTriGia As String)
        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.iMaTLS = iMaTLS
        Me.strTenTG = strTenTG
        Me.strNXB = strNXB
        Me.iNamXB = iNamXB
        Me.dateNgayNhap = dateNgayNhap
        Me.iMaTTS = iMaTTS
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

    Public Property MaTLS() As Integer
        Get
            Return iMaTLS
        End Get
        Set(value As Integer)
            iMaTLS = value
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

    Public Property MaTTS() As Integer
        Get
            Return iMaTTS
        End Get
        Set(value As Integer)
            iMaTTS = value
        End Set
    End Property
End Class
