Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility
Public Class PhieuMuonSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID() As Integer
        Dim id As Integer
        id = 1

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaPhieu] "
        query &= "From [MuonTraSach] "
        query &= "Order By [MaPhieu] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaPhieu")
                        End While
                    End If
                    ' new ID = current ID + 1
                    id = idOnDB + 1
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return id ' thanh cong
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [MaPhieu] "
        query &= "From [MuonTraSach] "
        query &= "Order By [MaPhieu] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaPhieu")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Phiểu mượn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(pms As PhieuMuonSachDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [MuonTraSach]([MaPhieu],[MaDG],[MaSach],[NgayMuon],[NgayHenTra],[NgayTra],[TinhTrangPhieuMuon]) "
        query &= "VALUES (@MaPhieu,@MaDG,@MaSach,@NgayMuon,@NgayHenTra,@NgayTra,@TinhTrangPhieuMuon)"

        pms.MaPhieu = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieu", pms.MaPhieu)
                    .Parameters.AddWithValue("@MaDG", pms.MaDG)
                    .Parameters.AddWithValue("@MaSach", pms.MaSach)
                    .Parameters.AddWithValue("@NgayMuon", pms.NgayMuon)
                    .Parameters.AddWithValue("@NgayHenTra", pms.NgayHenTra)
                    .Parameters.AddWithValue("@NgayTra", pms.NgayTra)
                    .Parameters.AddWithValue("@TinhTrangPhieuMuon", pms.TinhTrangPhieuMuon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Phiếu mượn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectAll(ByRef listPMS As List(Of PhieuMuonSachDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieu],[DocGia].[MaDG],[DocGia].[TenDG], [Sach].[MaSach],[Sach].[TenSach], [NgayMuon], [NgayHenTra],[NgayTra], [TinhTrangPhieuMuon]  "
        query &= "FROM [MuonTraSach],[DocGia],[Sach] WHERE [MuonTraSach].[MaDG]=[DocGia].[MaDG] AND [MuonTraSach].[MaSach]=[Sach].[MaSach]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()


                    If reader.HasRows = True Then
                        listPMS.Clear()
                        While reader.Read()
                            listPMS.Add(New PhieuMuonSachDTO(reader("MaPhieu"), reader("MaDG"), reader("TenDG"), reader("MaSach"), reader("TenSach"), reader("NgayMuon"), reader("NgayHenTra"), reader("NgayTra"), reader("TinhTrangPhieuMuon")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class

