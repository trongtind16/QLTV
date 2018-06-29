Imports DAL
Imports DTO
Imports Utility
Public Class TinhTrangSachBUS
    Private ttsDAL As TinhTrangSachDAL
    Public Sub New()
        ttsDAL = New TinhTrangSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        ttsDAL = New TinhTrangSachDAL(connectionString)
    End Sub
    Public Function isValidName(tts As TinhTrangSachDTO) As Boolean

        If (tts.TenTTS.Trim = "") Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(tts As TinhTrangSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttsDAL.insert(tts)
    End Function
    Public Function update(tts As TinhTrangSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttsDAL.update(tts)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttsDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listTinhTrangSach As List(Of TinhTrangSachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttsDAL.selectALL(listTinhTrangSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ttsDAL.getNextID(nextID)
    End Function
End Class
