Public Class TinhTrangSachDTO
    Private iMaTTS As Integer
    Private strTenTTS As String

    Public Sub New()
    End Sub
    Public Sub New(iMaTTS As Integer, strTenTTS As String)
        Me.iMaTTS = iMaTTS
        Me.strTenTTS = strTenTTS
    End Sub
    Property MaTTS() As Integer
        Get
            Return iMaTTS
        End Get
        Set(ByVal Value As Integer)
            iMaTTS = Value
        End Set
    End Property
    Property TenTTS() As String
        Get
            Return strTenTTS
        End Get
        Set(ByVal Value As String)
            strTenTTS = Value
        End Set
    End Property
End Class
