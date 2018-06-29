Public Class TheLoaiSachDTO
    Private iMaTLS As Integer
    Private strTenTLS As String

    Public Sub New()
    End Sub
    Public Sub New(iMaTLS As Integer, strTenTLS As String)
        Me.iMaTLS = iMaTLS
        Me.strTenTLS = strTenTLS
    End Sub
    Property MaTLS() As Integer
        Get
            Return iMaTLS
        End Get
        Set(ByVal Value As Integer)
            iMaTLS = Value
        End Set
    End Property
    Property TenTLS() As String
        Get
            Return strTenTLS
        End Get
        Set(ByVal Value As String)
            strTenTLS = Value
        End Set
    End Property
End Class
