Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class QuyDinhDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function update(qd As QuyDinhDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [QuyDinh] SET"
        query &= " [TuoiToiThieu] = @TuoiToiThieu "
        query &= " ,[TuoiToiDa] = @TuoiToiDa "
        query &= " ,[ThoiGianSuDung] = @ThoiGianSuDung"
        query &= " ,[KhoangCachNamXuatBan] = @KhoangCachNamXuatBan"
        query &= " ,[SachMuonToiDa] = @SachMuonToiDa"
        query &= " ,[NgayMuonToiDa] = @NgayMuonToiDa"
        query &= " WHERE "
        query &= " [Id] = @Id "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TuoiToiThieu", qd.TuoiToiThieu)
                    .Parameters.AddWithValue("@TuoiToiDa", qd.TuoiToiDa)
                    .Parameters.AddWithValue("@ThoiGianSuDung", qd.ThoiGianSuDung)
                    .Parameters.AddWithValue("@KhoangCachNamXuatBan", qd.KhoangCachNamXuatBan)
                    .Parameters.AddWithValue("@Id", qd.ID)
                    .Parameters.AddWithValue("@SachMuonToiDa", qd.SachMuonToiDa)
                    .Parameters.AddWithValue("@NgayMuonToiDa", qd.NgayMuonToiDa)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef quydinh As List(Of QuyDinhDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [Id], [TuoiToiThieu], [TuoiToiDa], [ThoiGianSuDung], [KhoangCachNamXuatBan],[SachMuonToiDa],[NgayMuonToiDa]"
        query &= " FROM [QuyDinh]"


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
                        quydinh.Clear()
                        While reader.Read()
                            quydinh.Add(New QuyDinhDTO(reader("Id"), reader("TuoiToiThieu"), reader("TuoiToiDa"), reader("ThoiGianSuDung"), reader("KhoangCachNamXuatBan"), reader("SachMuonToiDa"), reader("NgayMuonToiDa")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function GetQuyDinh(ByRef GetTuoiToiThieu As Integer, ByRef GetTuoiToiDa As Integer, ByRef GetThoiGianSuDung As Integer, ByRef GetKhoangCachNamXuatBan As Integer, ByRef GetSachMuonToiDa As Integer, ByRef GetNgayMuonToiDa As Integer) As Result

        GetTuoiToiThieu = 0
        GetTuoiToiDa = 0
        GetThoiGianSuDung = 0
        GetKhoangCachNamXuatBan = 0
        GetSachMuonToiDa = 0
        GetNgayMuonToiDa = 0



        Dim query As String = String.Empty
        query &= "SELECT [TuoiToiThieu],[TuoiToiDa],[ThoiGianSuDung],[KhoangCachNamXuatBan],[SachMuonToiDa],[NgayMuonToiDa]"
        query &= "FROM [QuyDinh] "


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
                    Dim TuoiToiThieu As Integer
                    TuoiToiThieu = Nothing
                    Dim TuoiToiDa As Integer
                    TuoiToiDa = Nothing
                    Dim ThoiGianSuDung As Integer
                    ThoiGianSuDung = Nothing
                    Dim KhoangCachNamXuatBan As Integer
                    KhoangCachNamXuatBan = Nothing
                    Dim SachMuonToiDa As Integer
                    SachMuonToiDa = Nothing
                    Dim NgayMuonToiDa As Integer
                    NgayMuonToiDa = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            TuoiToiThieu = reader("TuoiToiThieu")
                            TuoiToiDa = reader("TuoiToiDa")
                            ThoiGianSuDung = reader("ThoiGianSuDung")
                            KhoangCachNamXuatBan = reader("KhoangCachNamXuatBan")
                            SachMuonToiDa = reader("SachMuonToiDa")
                            NgayMuonToiDa = reader("NgayMuonToiDa")
                        End While
                    End If

                    GetTuoiToiThieu = TuoiToiThieu
                    GetTuoiToiDa = TuoiToiDa
                    GetThoiGianSuDung = ThoiGianSuDung
                    GetKhoangCachNamXuatBan = KhoangCachNamXuatBan
                    GetSachMuonToiDa = SachMuonToiDa
                    GetNgayMuonToiDa = NgayMuonToiDa

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Độc Giả kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
