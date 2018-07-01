Imports BUS
Imports DTO
Imports Utility
Public Class ThemSachGUI
    Private sBUS As SachBUS
    Private tlsBUS As TheLoaiSachBUS
    Private ttsBUS As TinhTrangSachBUS
    ''
    Dim sach As SachDTO
    Dim qd As QuyDinhDTO
    '''
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO
    Dim listQuyDinh = New List(Of QuyDinhDTO)
    Dim resul As Result
    ''
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim sach As SachDTO
        sach = New SachDTO()
        qdBus = New QuyDinhBUS()
        resul = qdBus.selectALL(listQuyDinh)
        quydinh = listQuyDinh(0)
        Dim KhoangCachNamXuatBan = quydinh.KhoangCachNamXuatBan

        '1. Mapping data from GUI control
        sach.MaSach = txtMaSach.Text
        sach.TenSach = txtTenSach.Text
        sach.MaTLS = Convert.ToInt32(cbTheLoai.SelectedValue)
        sach.TenTG = txtTacGia.Text
        sach.NXB = txtNhaXuatBan.Text
        sach.NamXB = txtNamXuatBan.Text
        sach.NgayNhap = dtpNgayNhap.Value
        sach.MaTTS = Convert.ToInt32(cbTinhTrang.SelectedValue)
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
        result = sBUS.insert(sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Get Next ID
            Dim nextID As Integer
            result = sBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
            Else
                MessageBox.Show("Lấy ID kế tiếp của Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            txtMaSach.Text = nextID.ToString()
            txtTenSach.Text = String.Empty
            txtTacGia.Text = String.Empty
            txtNamXuatBan.Text = String.Empty
            txtNhaXuatBan.Text = String.Empty
            txtTriGia.Text = String.Empty
            cbTheLoai.Text = String.Empty
            SachGUI.loadListSach()
        Else
            MessageBox.Show("Thêm Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Me.Hide()
    End Sub


    Private Sub ThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sBUS = New SachBUS()
        tlsBUS = New TheLoaiSachBUS()
        ttsBUS = New TinhTrangSachBUS()

        ' Get Next ID

        Dim nextID As String
        Dim result As Result
        result = sBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaSach.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        'Load List Loai Sach
        Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
        result = tlsBUS.selectAll(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Loại Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbTheLoai.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
        cbTheLoai.DisplayMember = "TenTLS"
        cbTheLoai.ValueMember = "MaTLS"
        cbTheLoai.SelectedIndex = -1
        ''
        Dim listTinhTrangSach = New List(Of TinhTrangSachDTO)
        result = ttsBUS.selectAll(listTinhTrangSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Tình trạng Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbTinhTrang.DataSource = New BindingSource(listTinhTrangSach, String.Empty)
        cbTinhTrang.DisplayMember = "TenTTS"
        cbTinhTrang.ValueMember = "MaTTS"
        'cbTinhTrang.SelectedIndex = -1

        ''
        dtpNgayNhap.Value = DateTime.Now.ToString("MM/dd/yyyy")
        ' Get Quy Dinh
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Hide()
    End Sub

    Private Sub txtTriGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTriGia.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNamXuatBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamXuatBan.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class