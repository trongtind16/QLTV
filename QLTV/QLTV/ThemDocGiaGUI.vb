Imports BUS
Imports DTO
Imports Utility

Public Class ThemDocGiaGUI

    Private dgBus As DocGiaBUS
    Private ldgBus As LoaiDocGiaBUS
    ''
    Dim docgia As DocGiaDTO
    Dim qd As QuyDinhDTO
    '''
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO
    Dim listQuyDinh = New List(Of QuyDinhDTO)
    Dim resul As Result
    Dim hsd As Integer
    ''
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

        docgia = New DocGiaDTO()
        qdBus = New QuyDinhBUS()
        resul = qdBus.selectALL(listQuyDinh)
        quydinh = listQuyDinh(0)
        hsd = quydinh.ThoiGianSuDung
        Dim tuoitt = quydinh.TuoiToiThieu
        Dim tuoitd = quydinh.TuoiToiDa

        ''''
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
        If (dgBus.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên Đọc giả không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenDG.Focus()
            Return
        End If

        If (dgBus.isValidAge1(docgia, quydinh) = False) Then
            MessageBox.Show("Đọc giả không đủ tuổi lập thẻ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpNgaySinh.Focus()
            Return
        End If

        If (dgBus.isValidAge2(docgia, quydinh) = False) Then
            MessageBox.Show("Đọc giả Vượt quá tuổi lập thẻ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpNgaySinh.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Độc Giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Get Next ID
            Dim nextID As Integer
            result = dgBus.getNextID(nextID)
            If (result.FlagResult = True) Then


            Else
                MessageBox.Show("Lấy ID kế tiếp của Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            txtMaDG.Text = nextID.ToString()
            txtTenDG.Text = String.Empty
            txtEmail.Text = String.Empty
            txtDiaChi.Text = String.Empty
            cbGioiTinh.SelectedIndex = -1
            cbLoaiDG.SelectedIndex = -1
            DocGiaGUI.loadListDocGia()

        Else
            MessageBox.Show("Thêm loại Độc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub DocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgBus = New DocGiaBUS()
        ldgBus = New LoaiDocGiaBUS()

        ' Load LoaiHocSinh list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbLoaiDG.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDG.DisplayMember = "MaLDG"
        cbLoaiDG.ValueMember = "MaLDG"


        'set MSSH auto
        Dim nextID As Integer
        result = dgBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaDG.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub dtpNgayLapthe_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayLapThe.ValueChanged
        qdBus = New QuyDinhBUS()
        resul = qdBus.selectALL(listQuyDinh)

        quydinh = listQuyDinh(0)
        hsd = quydinh.ThoiGianSuDung

        dtpNgayHetHan.Value = dtpNgayLapThe.Value.AddMonths(hsd)

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub txtTenDG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTenDG.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class