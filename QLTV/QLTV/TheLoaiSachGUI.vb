Imports System.Configuration
Imports BUS
Imports DTO
Imports Utility
Public Class TheLoaiSachGUI

    Private tlsBus As TheLoaiSachBUS
    Private Sub TheLoaiSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tlsBus = New TheLoaiSachBUS()
        loadListTheLoaiSach()

    End Sub
    Public Sub loadListTheLoaiSach()
        ' Load LoaiDocGia list
        Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
        Dim result As Result
        result = tlsBus.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachTLS.AutoGenerateColumns = False
        dgvDanhSachTLS.AllowUserToAddRows = False
        dgvDanhSachTLS.DataSource = listTheLoaiSach
    End Sub
    Private Sub dgvDanhSachTLS_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTLS.SelectionChanged

        Dim currentRowIndex As Integer = dgvDanhSachTLS.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTLS.RowCount) Then
            Try
                Dim tls = CType(dgvDanhSachTLS.Rows(currentRowIndex).DataBoundItem, TheLoaiSachDTO)
                txtMaLoai.Text = tls.MaTLS
                txtTenLoai.Text = tls.TenTLS
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim currentRowIndex As Integer = dgvDanhSachTLS.CurrentCellAddress.Y 'current row selected
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTLS.RowCount) Then
            Try
                Dim tls As TheLoaiSachDTO
                tls = New TheLoaiSachDTO()

                '1. Mapping data from GUI control
                tls.MaTLS = Convert.ToInt32(txtMaLoai.Text)
                tls.TenTLS = txtTenLoai.Text

                '2. Business .....
                If (tlsBus.isValidName(tls) = False) Then
                    MessageBox.Show("Tên Thể loại sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = tlsBus.update(tls)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListTheLoaiSach()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachTLS.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Thể loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTLS.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTLS.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Thể loại sách: " + txtTenLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = tlsBus.delete(Convert.ToInt32(txtMaLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListTheLoaiSach()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachTLS.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachTLS.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa Thể loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ThemTheLoaiSachGUI.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class