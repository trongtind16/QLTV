Public Class LoaiDocGiaDTO
    Private iMaLDG As Integer
    Private strTenLDG As String

    Public Sub New()
    End Sub
    Public Sub New(iMaLDG As Integer, strTenLDG As String)
        Me.iMaLDG = iMaLDG
        Me.strTenLDG = strTenLDG
    End Sub
    Property MaLDG() As Integer
        Get
            Return iMaLDG
        End Get
        Set(ByVal Value As Integer)
            iMaLDG = Value
        End Set
    End Property
    Property TenLDG() As String
        Get
            Return strTenLDG
        End Get
        Set(ByVal Value As String)
            strTenLDG = Value
        End Set
    End Property
End Class
