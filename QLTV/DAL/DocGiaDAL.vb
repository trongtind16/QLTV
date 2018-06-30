Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility
Public Class DocGiaDAL
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
        query &= "Select TOP 1 [MaDG] "
        query &= "From [DocGia] "
        query &= "Order By [MaDG] DESC "

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
                            idOnDB = reader("MaDG")
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
        query &= "Select TOP 1 [MaDG] "
        query &= "From [DocGia] "
        query &= "Order By [MaDG] DESC "

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
                            idOnDB = reader("MaDG")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Mã Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(dg As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [DocGia]([MaDG],[TenDG],[MaLDG],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NgayHetHan],[GioiTinh]) "
        query &= "VALUES (@MaDG,@TenDG,@MaLDG,@NgaySinh,@DiaChi,@Email,@NgayLapThe,@NgayHetHan,@GioiTinh)"

        dg.MaDG = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDG", dg.MaDG)
                    .Parameters.AddWithValue("@TenDG", dg.TenDG)
                    .Parameters.AddWithValue("@MaLDG", dg.MaLDG)
                    .Parameters.AddWithValue("@NgaySinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@DiaChi", dg.DiaChi)
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@NgayLapThe", dg.NgayLapThe)
                    .Parameters.AddWithValue("@NgayHetHan", dg.NgayHetHan)
                    .Parameters.AddWithValue("@GioiTinh", dg.GioiTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Độc không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(dg As DocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [DocGia] SET"
        query &= "  [TenDG] = @TenDG "
        query &= " ,[MaLDG] = @MaLDG "
        query &= " ,[NgaySinh] = @NgaySinh "
        query &= " ,[DiaChi] = @DiaChi "
        query &= " ,[Email] = @Email "
        query &= " ,[NgayLapThe] = @NgayLapThe "
        query &= " ,[NgayHetHan] = @NgayHetHan "
        query &= " ,[GioiTinh] = @GioiTinh "
        query &= " WHERE "
        query &= " [MaDG] = @MaDG "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDG", dg.MaDG)
                    .Parameters.AddWithValue("@TenDG", dg.TenDG)
                    .Parameters.AddWithValue("@MaLDG", dg.MaLDG)
                    .Parameters.AddWithValue("@NgaySinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@DiaChi", dg.DiaChi)
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@NgayLapThe", dg.NgayLapThe)
                    .Parameters.AddWithValue("@NgayHetHan", dg.NgayHetHan)
                    .Parameters.AddWithValue("@GioiTinh", dg.GioiTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Sửa Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(MaDG As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [DocGia] "
        query &= " WHERE "
        query &= " [MaDG] = @MaDG "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDG", MaDG)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectAll(ByRef listDG As List(Of DocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaDG],[TenDG],[TenLDG],[NgaySinh],[DiaChi],[Email],[NgayLapThe],[NgayHetHan],[GioiTinh]"
        query &= "FROM [DocGia],[LoaiDocGia] WHERE [DocGia].[MaLDG] = [LoaiDocGia].[MaLDG]"

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
                        listDG.Clear()
                        While reader.Read()
                            listDG.Add(New DocGiaDTO(reader("MaDG"), reader("TenDG"), reader("TenLDG"), reader("NgaySinh"), reader("DiaChi"), reader("Email"), reader("NgayLapThe"), reader("NgayHetHan"), reader("GioiTinh")))
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
