Imports System.Configuration
Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class LoaiDocGiaDAL
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
        query &= "Select TOP 1 [MaLDG] "
        query &= "From [LoaiDocGia] "
        query &= "Order By [MaLDG] DESC "

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
                            idOnDB = reader("MaLDG")
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
        query &= "Select TOP 1 [MaLDG] "
        query &= "From [LoaiDocGia] "
        query &= "Order By [MaLDG] DESC "

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
                            idOnDB = reader("MaLDG")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại Đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(ldg As LoaiDocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LoaiDocGia] ([MaLDG], [TenLDG])"
        query &= "VALUES (@MaLDG,@TenLDG)"

        ldg.MaLDG = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLDG", ldg.MaLDG)
                    .Parameters.AddWithValue("@TenLDG", ldg.TenLDG)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Đọc giả thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ldg As LoaiDocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LoaiDocGia] SET"
        query &= " [TenLDG] = @TenLDG "
        query &= " WHERE "
        query &= " [MaLDG] = @MaLDG "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLDG", ldg.MaLDG)
                    .Parameters.AddWithValue("@TenLDG", ldg.TenLDG)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maLoai As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [LoaiDocGia] "
        query &= " WHERE "
        query &= " [MaLDG] = @MaLDG "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLDG", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listLoaiDocGia As List(Of LoaiDocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLDG], [TenLDG]"
        query &= " FROM [LoaiDocGia]"


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
                        listLoaiDocGia.Clear()
                        While reader.Read()
                            listLoaiDocGia.Add(New LoaiDocGiaDTO(reader("MaLDG"), reader("TenLDG")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại Đọc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
