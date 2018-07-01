Imports DAL
Imports DTO
Imports Utility
Public Class PhieuMuonSachBUS
    Private pmsDAL As PhieuMuonSachDAL
    Public Sub New()
        pmsDAL = New PhieuMuonSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        pmsDAL = New PhieuMuonSachDAL(connectionString)
    End Sub
    Public Function isValidMaSach(s As PhieuMuonSachDTO) As Boolean

        If (s.MaSach.Trim = "") Then
            Return False
        End If
        Return True
    End Function
    Public Function isValidMaDocGia(s As PhieuMuonSachDTO) As Boolean

        If (s.MaDG.Trim = "") Then
            Return False
        End If
        Return True
    End Function


    Public Function insert(mpms As PhieuMuonSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pmsDAL.insert(mpms)
    End Function

    Public Function selectAll(ByRef listPMS As List(Of PhieuMuonSachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pmsDAL.selectAll(listPMS)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return pmsDAL.getNextID(nextID)
    End Function
End Class


