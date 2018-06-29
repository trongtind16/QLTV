Imports DAL
Imports DTO
Imports Utility
Public Class DocGiaBUS
    Private dgDAL As DocGiaDAL
    Public Sub New()
        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValidName(dg As DocGiaDTO) As Boolean

        If (dg.TenDG.Trim = "") Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidAge1(dg As DocGiaDTO, qd As QuyDinhDTO) As Boolean
        Dim Now = DateTime.Now.Year
        If ((Now - dg.NgaySinh.Year) < qd.TuoiToiThieu) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidAge2(dg As DocGiaDTO, qd As QuyDinhDTO) As Boolean
        Dim Now = DateTime.Now.Year
        If ((Now - dg.NgaySinh.Year) > qd.TuoiToiDa) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(dg)
    End Function

    Public Function update(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(dg)
    End Function
    Public Function delete(MaDG As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.delete(MaDG)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return dgDAL.getNextID(nextID)
    End Function
    Public Function selectAll(ByRef listDG As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectAll(listDG)
    End Function

End Class
