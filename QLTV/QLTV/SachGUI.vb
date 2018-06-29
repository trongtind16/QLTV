Imports System.Configuration
Imports System.Data.SqlClient
Imports BUS
Imports DTO
Imports Utility
Public Class SachGUI
    Private sBUS As SachBUS
    Private tlsBUS As TheLoaiSachBUS
    Private ttsBUS As TinhTrangSachBUS
    Dim sach As SachDTO
    Dim qd As QuyDinhDTO
    '''
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO
    Dim listQuyDinh = New List(Of QuyDinhDTO)
    Dim resul As Result
    Private Sub Sach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sBUS = New SachBUS()
        tlsBUS = New TheLoaiSachBUS()
        ttsBUS = New TinhTrangSachBUS()
        loadListSach()
        ''
        Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
        Dim result As Result
        result = tlsBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Thể loại Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbTheLoai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        cbTheLoai.DisplayMember = "MaTLS"
        cbTheLoai.ValueMember = "MaTLS"
        ''
        Dim listTinhTrangSach = New List(Of TinhTrangSachDTO)
        result = ttsBUS.selectAll(listTinhTrangSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Tình trạng Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbTinhTrang.DataSource = New BindingSource(listTinhTrangSach, String.Empty)
        cbTinhTrang.DisplayMember = "MaTTS"
        cbTinhTrang.ValueMember = "MaTTS"
    End Sub
    Public Sub loadListSach()
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        result = sBUS.selectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvlistSach.AutoGenerateColumns = False
        dgvlistSach.AllowUserToAddRows = False
        dgvlistSach.DataSource = listSach
    End Sub
    Private Sub dgvlistSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvlistSach.SelectionChanged
        Dim currentRowIndex As Integer = dgvlistSach.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvlistSach.RowCount) Then
            Try
                Dim Sach = CType(dgvlistSach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                txtMaSach.Text = Sach.MaSach
                txtTenSach.Text = Sach.TenSach
                cbTheLoai.Text = Sach.MaTLS
                txtTacGia.Text = Sach.TenTG
                txtNhaXuatBan.Text = Sach.NXB
                txtNamXuatBan.Text = Sach.NamXB
                dtpNgayNhap.Text = Sach.NgayNhap
                cbTinhTrang.Text = Sach.MaTTS
                txtTriGia.Text = Sach.TriGia

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        qdBus = New QuyDinhBUS()
        resul = qdBus.selectALL(listQuyDinh)
        quydinh = listQuyDinh(0)
        Dim KhoangCachNamXuatBan = quydinh.KhoangCachNamXuatBan
        ''
        Dim currentRowIndex As Integer = dgvlistSach.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvlistSach.RowCount) Then
            Try
                Dim sach As SachDTO
                sach = New SachDTO()
                '1. Mapping data from GUI control
                sach.MaSach = txtMaSach.Text
                sach.TenSach = txtTenSach.Text
                sach.MaTLS = cbTheLoai.SelectedValue
                sach.TenTG = txtTacGia.Text
                sach.NXB = txtNhaXuatBan.Text
                sach.NamXB = txtNamXuatBan.Text
                sach.NgayNhap = dtpNgayNhap.Value
                sach.MaTTS = cbTinhTrang.SelectedValue
                sach.TriGia = txtTriGia.Text
                '2. Business .....
                If (sBUS.isValidName(sach) = False) Then
                    MessageBox.Show("Tên Sách không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTenSach.Focus()
                    Return
                End If
                If (sBUS.isValidnamXB(sach, quydinh) = False) Then
                    MessageBox.Show("Khoảng cách năm xuất bản vượt quá quy định!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNamXuatBan.Focus()
                    Return
                End If

                '3. Insert to DB
                Dim result As Result
                result = sBUS.update(sach)
                If (result.FlagResult = True) Then

                    ' Hightlight the row has been updated on table
                    dgvlistSach.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Sửa Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.loadListSach()
                Else
                    MessageBox.Show("Sửa Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)

                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgvlistSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvlistSach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Sách có tên: " + txtTenSach.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = sBUS.delete(txtMaSach.Text)
                        If (result.FlagResult = True) Then



                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvlistSach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvlistSach.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.loadListSach()

                        Else
                            MessageBox.Show("Xóa Sách  không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Close()
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        ThemSachGUI.Show()
    End Sub
End Class