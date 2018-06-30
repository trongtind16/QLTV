Imports System.Configuration
Imports BUS
Imports DTO
Imports Utility
Public Class TinhTrangSachGUI

    Private ttsBus As TinhTrangSachBUS
    Private Sub TinhTrangSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ttsBus = New TinhTrangSachBUS()
        loadListTinhTrangSach()

    End Sub
    Public Sub loadListTinhTrangSach()
        ' Load LoaiDocGia list
        Dim listTinhTrangSach = New List(Of TinhTrangSachDTO)
        Dim result As Result
        result = ttsBus.selectAll(listTinhTrangSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách  Tình Trạng sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachTTS.AutoGenerateColumns = False
        dgvDanhSachTTS.AllowUserToAddRows = False
        dgvDanhSachTTS.DataSource = listTinhTrangSach
    End Sub
    Private Sub dgvDanhSachTTS_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTTS.SelectionChanged

        Dim currentRowIndex As Integer = dgvDanhSachTTS.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTTS.RowCount) Then
            Try
                Dim tts = CType(dgvDanhSachTTS.Rows(currentRowIndex).DataBoundItem, TinhTrangSachDTO)
                txtMaLoai.Text = tts.MaTTS
                txtTenLoai.Text = tts.TenTTS
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btsua.Click
        Dim currentRowIndex As Integer = dgvDanhSachTTS.CurrentCellAddress.Y 'current row selected
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTTS.RowCount) Then
            Try
                Dim tts As TinhTrangSachDTO
                tts = New TinhTrangSachDTO()

                '1. Mapping data from GUI control
                tts.MaTTS = Convert.ToInt32(txtMaLoai.Text)
                tts.TenTTS = txtTenLoai.Text

                '2. Business .....
                If (ttsBus.isValidName(tts) = False) Then
                    MessageBox.Show("Tên  Tình Trạng sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ttsBus.update(tts)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListTinhTrangSach()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachTTS.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật  Tình Trạng sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật  Tình Trạng sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class