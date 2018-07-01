Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility
Public Class SachDAL
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
        query &= "Select TOP 1 [MaSach] "
        query &= "From [SACH] "
        query &= "Order By [MaSach] DESC "

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
                            idOnDB = reader("MaSach")
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
        query &= "Select TOP 1 [MaSach] "
        query &= "From [SACH] "
        query &= "Order By [MaSach] DESC "

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
                            idOnDB = reader("MaSach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Mã Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(s As SachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [SACH] ([MaSach],[TenSach],[MaTLS],[TenTG],[NXB],[NamXB],[NgayNhap],[MaTTS],[TriGia])"
        query &= "VALUES (@MaSach,@TenSach,@MaTLS,@TenTG,@NXB,@NamXB,@NgayNhap,@MaTTS,@TriGia)"
        s.MaSach = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", s.MaSach)
                    .Parameters.AddWithValue("@TenSach", s.TenSach)
                    .Parameters.AddWithValue("@MaTLS", s.MaTLS)
                    .Parameters.AddWithValue("@TenTG", s.TenTG)
                    .Parameters.AddWithValue("@NXB", s.NXB)
                    .Parameters.AddWithValue("@NamXB", s.NamXB)
                    .Parameters.AddWithValue("@NgayNhap", s.NgayNhap)
                    .Parameters.AddWithValue("@MaTTS", s.MaTTS)
                    .Parameters.AddWithValue("@TriGia", s.TriGia)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    'System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(s As SachDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [SACH] SET"
        query &= "  [TenSach] = @TenSach "
        query &= " ,[MaTLS] = @MaTLS "
        query &= " ,[TenTG] = @TenTG "
        query &= " ,[NXB] = @NXB "
        query &= " ,[NamXB] = @NamXB "
        query &= " ,[NgayNhap] = @NgayNhap "
        query &= " ,[MaTTS] = @MaTTS "
        query &= " ,[TriGia] = @TriGia "
        query &= " WHERE "
        query &= " [MaSach] = @MaSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", s.MaSach)
                    .Parameters.AddWithValue("@TenSach", s.TenSach)
                    .Parameters.AddWithValue("@MaTLS", s.MaTLS)
                    .Parameters.AddWithValue("@TenTG", s.TenTG)
                    .Parameters.AddWithValue("@NXB", s.NXB)
                    .Parameters.AddWithValue("@NamXB", s.NamXB)
                    .Parameters.AddWithValue("@NgayNhap", s.NgayNhap)
                    .Parameters.AddWithValue("@MaTTS", s.MaTTS)
                    .Parameters.AddWithValue("@TriGia", s.TriGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Sửa Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(MaSach As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [SACH] "
        query &= " WHERE "
        query &= " [MaSach] = @MaSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", MaSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectAll(ByRef listS As List(Of SachDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaSach],[TenSach],[TenTLS],[TenTG],[NXB],[NamXB],[NgayNhap],[TenTTS],[TriGia]"
        query &= "FROM [Sach],[TheLoaiSach],[TinhTrangSach] WHERE [Sach].[MaTLS] = [TheLoaiSach].[MaTLS] AND [Sach].[MaTTS] = [TinhTrangSach].[MaTTS] "
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
                        listS.Clear()
                        While reader.Read()
                            listS.Add(New SachDTO(reader("MaSach"), reader("TenSach"), reader("TenTLS"), reader("TenTG"), reader("NXB"), reader("NamXB"), reader("NgayNhap"), reader("TenTTS"), reader("TriGia")))
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

