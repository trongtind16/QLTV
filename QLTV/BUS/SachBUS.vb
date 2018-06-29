Imports DAL
Imports DTO
Imports Utility
Public Class SachBUS
    Private sDAL As SachDAL
    Public Sub New()
        sDAL = New SachDAL()
    End Sub
    Public Sub New(connectionString As String)
        sDAL = New SachDAL(connectionString)
    End Sub
    Public Function isValidName(s As SachDTO) As Boolean

        If (s.TenSach.Trim = "") Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidnamXB(s As SachDTO, qd As QuyDinhDTO) As Boolean
        Dim Now = DateTime.Now.Year
        If ((Now - s.NamXB) > qd.KhoangCachNamXuatBan) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(s As SachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sDAL.insert(s)
    End Function

    Public Function update(s As SachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sDAL.update(s)
    End Function
    Public Function delete(MaSach As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sDAL.delete(MaSach)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return sDAL.getNextID(nextID)
    End Function
    Public Function selectAll(ByRef listS As List(Of SachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return sDAL.selectAll(listS)
    End Function
End Class
