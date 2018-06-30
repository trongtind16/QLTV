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
    Private con As SqlConnection
    Private Sub SachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cbDoiTuong.Text = "Chọn..."
        ''
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
    Private Sub Connect()
        Dim conn As String = ConfigurationManager.AppSettings("ConnectionString")
        Try
            con = New SqlConnection(conn)
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles bttimkiem.Click
        Connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaSach As String = Me.txtTimKiem.Text.Trim()
        If cbDoiTuong.SelectedIndex = 0 Then
            Dim SQL = "SELECT * FROM Sach WHERE MaSach LIKE N'%" + MaSach + "%'"
            Dim Adapter As New SqlClient.SqlDataAdapter(SQL, con)
            Dim DATA As New DataSet
            Adapter.Fill(DATA, "Sach")
            dgvlistSach.DataSource = DATA
            dgvlistSach.DataMember = "Sach"
        End If
        Dim TenSach As String = Me.txtTimKiem.Text.Trim()
        If cbDoiTuong.SelectedIndex = 1 Then
            Dim SQL = "SELECT * FROM Sach WHERE TenSach LIKE N'%" + TenSach + "%'"
            Dim Adapter As New SqlClient.SqlDataAdapter(SQL, con)
            Dim DATA As New DataSet
            Adapter.Fill(DATA, "Sach")
            dgvlistSach.DataSource = DATA
            dgvlistSach.DataMember = "Sach"
        End If
        Dim TenTG As String = Me.txtTimKiem.Text.Trim()
        If cbDoiTuong.SelectedIndex = 2 Then
            Dim SQL = "SELECT * FROM Sach WHERE TenTG LIKE N'%" + TenTG + "%'"
            Dim Adapter As New SqlClient.SqlDataAdapter(SQL, con)
            Dim DATA As New DataSet
            Adapter.Fill(DATA, "Sach")
            dgvlistSach.DataSource = DATA
            dgvlistSach.DataMember = "Sach"
        End If
    End Sub
    Private Sub cbDoiTuong_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbDoiTuong.SelectedIndexChanged
        If (cbDoiTuong.Text = "Mã Sách") Then
            txtTimKiem.Text = "Nhập Mã Sách Cần Tìm"
        ElseIf (cbDoiTuong.Text = "Tên Sách") Then
            txtTimKiem.Text = "Nhập Tên Sách Cần Tìm"
        ElseIf (cbDoiTuong.Text = "Tác Giả") Then
            txtTimKiem.Text = "Nhập Tên Tác Giả Cần Tìm"
        End If
    End Sub
    Private Sub txtTimKiem_Click(sender As Object, e As EventArgs) Handles txtTimKiem.Click
        txtTimKiem.Text = ""
    End Sub
    Private Sub txtTriGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTriGia.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txthuy_Click(sender As Object, e As EventArgs) Handles txthuy.Click
        loadListSach()
        Me.cbDoiTuong.Text = "Chọn..."
        Me.txtTimKiem.Text = ""
        Me.txtTimKiem.Focus()
    End Sub
    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Hide()
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        ThemSachGUI.Show()
    End Sub


End Class