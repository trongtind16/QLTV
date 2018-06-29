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

    Public Function insert(pms As PhieuMuonSachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [MuonTraSach] ([MaPhieu],[MaDG],[MaSach],[NgayMuon],[NgayHenTra],[NgayTra],[MaTTS],[TinhTrangPhieuMuon])"
        query &= "VALUES (@MaPhieu,@MaDG,@MaSach,@NgayMuon,@NgayHenTra,@NgayTra,@MaTTS,@TinhTrangPhieuMuon)"

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
                    .Parameters.AddWithValue("@NgayTra", pms.NgayHenTra)
                    .Parameters.AddWithValue("@MaTTS", pms.MaTTS)
                    .Parameters.AddWithValue("@TinhTrangTraSach", "Đang Mượn")
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    'System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Phiếu mượn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectAll(ByRef listPMS As List(Of PhieuMuonSachDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieu],[MaDG],[DocGia].[TenDG],[MaSach], [Sach].[TenSach], [NgayMuon], [NgayHenTra],[NgayTra],[TinhTrangSach].[TenTTS], [TinhTrangPhieuMuon] "
        query &= "FROM [MuonTraSach],[DocGia],[Sach],[TinhTrangSach] WHERE [MuonTraSach].[MaDG]=[DocGia].[MaDG] AND [MuonTraSach].[MaSach]=[Sach].[MaSach] AND [MuonTraSach].[MaTTS]=[TinhTrangSach].[MaTTS]"

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
                            listPMS.Add(New PhieuMuonSachDTO(reader("MaPhieu"), reader("MaDG"), reader("TenDG"), reader("MaSach"), reader("TenSach"), reader("NgayMuon"), reader("NgayHenTra"), reader("NgayTra"), reader("TenTTS"), reader("TinhTrangPhieuMuon")))
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

