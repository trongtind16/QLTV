Imports System.Configuration
Imports System.Data.SqlClient

Imports BUS
Imports DTO
Imports Utility

Public Class DocGiaGUI
    Private dgBUS As DocGiaBUS
    Private ldgBUS As LoaiDocGiaBUS
    Dim docgia As DocGiaDTO
    Dim qd As QuyDinhDTO
    '''
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO
    Dim listQuyDinh = New List(Of QuyDinhDTO)
    Dim resul As Result
    Dim hsd As Integer
    Public Sub ThongTinDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBUS = New DocGiaBUS()
        loadListDocGia()

        dgBUS = New DocGiaBUS()
        ldgBUS = New LoaiDocGiaBUS()

        ' Load LoaiHocSinh list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBUS.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbLoaiDG.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDG.DisplayMember = "MaLDG"
        cbLoaiDG.ValueMember = "MaLDG"


    End Sub
    Public Sub loadListDocGia()
        Dim listDG = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBUS.selectAll(listDG)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListDG.AutoGenerateColumns = False
        dgvListDG.AllowUserToAddRows = False
        dgvListDG.DataSource = listDG
    End Sub



    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Close()
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        ThemDocGiaGUI.Show()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa độc giả có tên: " + txtTenDG.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = dgBUS.delete(txtMaDG.Text)
                        If (result.FlagResult = True) Then



                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListDG.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListDG.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.loadListDocGia()

                        Else
                            MessageBox.Show("Xóa độc giả  không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        ' Get the current cell location.
        docgia = New DocGiaDTO()
        qdBus = New QuyDinhBUS()
        resul = qdBus.selectALL(listQuyDinh)
        quydinh = listQuyDinh(0)
        hsd = quydinh.ThoiGianSuDung
        Dim tuoitt = quydinh.TuoiToiThieu
        Dim tuoitd = quydinh.TuoiToiDa
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Try
                Dim docgia As DocGiaDTO
                docgia = New DocGiaDTO()

                '1. Mapping data from GUI control
                docgia.MaDG = txtMaDG.Text
                docgia.TenDG = txtTenDG.Text
                docgia.GioiTinh = cbGioiTinh.Text
                docgia.NgaySinh = dtpNgaySinh.Value
                docgia.Email = txtEmail.Text
                docgia.DiaChi = txtDiaChi.Text
                docgia.MaLDG = cbLoaiDG.Text
                docgia.NgayLapThe = dtpNgayLapThe.Value
                dtpNgayHetHan.Value = dtpNgayLapThe.Value.AddMonths(hsd)
                docgia.NgayHetHan = dtpNgayHetHan.Value
                '2. Business .....
                If (dgBUS.isValidName(docgia) = False) Then
                    MessageBox.Show("Họ tên Độc Giả không đúng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtTenDG.Focus()
                    Return
                End If
                If (dgBUS.isValidAge1(docgia, quydinh) = False) Then
                    MessageBox.Show("Đọc giả không đủ tuổi lập thẻ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpNgaySinh.Focus()
                    Return
                End If

                If (dgBUS.isValidAge2(docgia, quydinh) = False) Then
                    MessageBox.Show("Đọc giả Vượt quá tuổi lập thẻ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpNgaySinh.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = dgBUS.update(docgia)
                If (result.FlagResult = True) Then

                    ' Hightlight the row has been updated on table
                    dgvListDG.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Sửa Độc Giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.loadListDocGia()
                Else
                    MessageBox.Show("Sửa Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)

                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub


    Private Sub txthuy_Click(sender As Object, e As EventArgs) Handles txthuy.Click
        loadListDocGia()
        Me.txttdg.Focus()
    End Sub

    Private Sub cmbDocGia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDocGia.SelectedValueChanged
        If (cmbDocGia.Text = "Mã Độc Giả") Then
            txttdg.Text = "Nhập Mã Độc Giả Cần Tìm"

        ElseIf (cmbDocGia.Text = "Tên Độc Giả") Then
            txttdg.Text = "Nhập Tên Độc Giả Cần Tìm"

        End If
    End Sub

    Private Sub txttdg_Click(sender As Object, e As EventArgs) Handles txttdg.Click
        txttdg.Text = ""
    End Sub

    Private Sub dgvListDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListDG.SelectionChanged
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Try
                Dim DocGia = CType(dgvListDG.Rows(currentRowIndex).DataBoundItem, DocGiaDTO)
                txtMaDG.Text = DocGia.MaDG
                txtTenDG.Text = DocGia.TenDG
                cbGioiTinh.Text = DocGia.GioiTinh
                dtpNgaySinh.Text = DocGia.NgaySinh
                txtEmail.Text = DocGia.Email
                txtDiaChi.Text = DocGia.DiaChi
                cbLoaiDG.Text = DocGia.MaLDG
                dtpNgayLapThe.Text = DocGia.NgayLapThe
                dtpNgayHetHan.Value = dtpNgayLapThe.Value.AddMonths(hsd)
                DocGia.NgayHetHan = dtpNgayHetHan.Value
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
    Private Sub dtpNgayLapthe_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayLapThe.ValueChanged
        qdBus = New QuyDinhBUS()
        resul = qdBus.selectALL(listQuyDinh)

        quydinh = listQuyDinh(0)
        hsd = quydinh.ThoiGianSuDung

        dtpNgayHetHan.Value = dtpNgayLapThe.Value.AddMonths(hsd)

    End Sub

End Class