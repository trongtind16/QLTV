﻿Imports System.Configuration
Imports BUS
Imports DTO
Imports Utility
Public Class LoaiDocGiaGUI

    Private ldgBus As LoaiDocGiaBUS
    Private Sub LoaiDocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ldgBus = New LoaiDocGiaBUS()
        loadListLoaiDocGia()

    End Sub
    Public Sub loadListLoaiDocGia()
        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachTLS.AutoGenerateColumns = False
        dgvDanhSachTLS.AllowUserToAddRows = False
        dgvDanhSachTLS.DataSource = listLoaiDocGia
    End Sub
    Private Sub dgvDanhSachLoaiDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTLS.SelectionChanged

        Dim currentRowIndex As Integer = dgvDanhSachTLS.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTLS.RowCount) Then
            Try
                Dim ldg = CType(dgvDanhSachTLS.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                txtMaLoai.Text = ldg.MaLDG
                txtTenLoai.Text = ldg.TenLDG
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim currentRowIndex As Integer = dgvDanhSachTLS.CurrentCellAddress.Y 'current row selected
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTLS.RowCount) Then
            Try
                Dim ldg As LoaiDocGiaDTO
                ldg = New LoaiDocGiaDTO()

                '1. Mapping data from GUI control
                ldg.MaLDG = Convert.ToInt32(txtMaLoai.Text)
                ldg.TenLDG = txtTenLoai.Text

                '2. Business .....
                If (ldgBus.isValidName(ldg) = False) Then
                    MessageBox.Show("Tên Loại Đọc Giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ldgBus.update(ldg)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListLoaiDocGia()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachTLS.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Loại Đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Select Case MsgBox("Bạn có thực sự muốn xóa loại Đọc giả có mã: " + txtMaLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldgBus.delete(Convert.ToInt32(txtMaLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListLoaiDocGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachTLS.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachTLS.Rows(currentRowIndex).Selected = True
                            End If
                            MessageBox.Show("Xóa Loại Đọc Giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        ThemLoaiDocGiaGUI.Show()
    End Sub
End Class