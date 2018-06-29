Imports DAL
Imports DTO
Imports Utility
Public Class TheLoaiSachBUS
    Private tlsDAL As TheLoaiSachDAL
    Public Sub New()
        tlsDAL = New TheLoaiSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        tlsDAL = New TheLoaiSachDAL(connectionString)
    End Sub
    Public Function isValidName(tls As TheLoaiSachDTO) As Boolean

        If (tls.TenTLS.Trim = "") Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(tls As TheLoaiSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tlsDAL.insert(tls)
    End Function
    Public Function update(tls As TheLoaiSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tlsDAL.update(tls)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tlsDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listTheLoaiSach As List(Of TheLoaiSachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tlsDAL.selectALL(listTheLoaiSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return tlsDAL.getNextID(nextID)
    End Function
End Class
