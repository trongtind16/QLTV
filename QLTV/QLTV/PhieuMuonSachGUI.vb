Imports System.Configuration
Imports System.Data.SqlClient
Imports BUS
Imports DTO
Imports Utility
Public Class PhieuMuonSachGUI
    Private pmsBUS As PhieuMuonSachBUS
    Private dgBUS As DocGiaBUS
    Private sBUS As SachBUS
    Private qdBUS As QuyDinhBUS
    Private quydinh As QuyDinhDTO
    Dim listQuyDinh = New List(Of QuyDinhDTO)
    Dim resul As Result
    Private con As SqlConnection
    Private Sub Connect()
        Dim conn As String = ConfigurationManager.AppSettings("ConnectionString")
        Try
            con = New SqlConnection(conn)
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim pms As PhieuMuonSachDTO
        pms = New PhieuMuonSachDTO()
        '1. Mapping data from GUI control
        pms.MaPhieu = txtMaPhieu.Text
        pms.MaDG = cbMaDG.Text
        pms.MaSach = txtMaSach.Text
        pms.NgayMuon = dtpNgayMuon.Value
        pms.NgayHenTra = dtpNgayHenTra.Value
        pms.NgayTra = dtpNgayTra.Value
        pms.TinhTrangPhieuMuon = "Đang Mượn"

        '2. Business .....
        If (pmsBUS.isValidMaSach(pms) = False) Then
            MessageBox.Show("Bạn chưa chọn sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenSach.Focus()
            Return
        End If
        If (pmsBUS.isValidMaDocGia(pms) = False) Then
            MessageBox.Show("Vui Lòng Nhập Thông Tin Độc Giả", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenDG.Focus()
            Return
        End If
        Dim HSD As DateTime
        HSD = dtpHSD.Value
        Dim Now As DateTime
        Now = DateTime.Now
        If (HSD < Now) Then
            MessageBox.Show("Thẻ đã hết hạn sử dụng !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = pmsBUS.insert(pms)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            QuanLyPhieuMuonGUI.loadListPhieuMuonSach()
            'QuanLyPhieuMuonGUI.loadListpms()
        Else
            MessageBox.Show("Thêm Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Me.Close()



    End Sub
    Private Sub PhieuMuonSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sBUS = New SachBUS()
        dgBUS = New DocGiaBUS()
        pmsBUS = New PhieuMuonSachBUS()
        loadListSach()
        ' Load LoaiHocSinh list
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBUS.selectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbMaDG.DataSource = New BindingSource(listDocGia, String.Empty)
        cbMaDG.DisplayMember = "MaDG"
        cbMaDG.ValueMember = "MaDG"
        ''
        dtpNgayMuon.Value = DateTime.Now


        'set MSSH auto
        Dim nextID As Integer
        result = pmsBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaPhieu.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        cbDoiTuong.Text = "Chọn..."

    End Sub
    Private Sub dgvlistSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvlistSach.SelectionChanged
        Dim currentRowIndex As Integer = dgvlistSach.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvlistSach.RowCount) Then
            Try
                Dim Sach = CType(dgvlistSach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                txtMaSach.Text = Sach.MaSach
                txtTenSach.Text = Sach.TenSach
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
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
    Private Sub cbMaDG_SelectedIndexChanged(sender As Object, e As EventArgs)
        Connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cm = New SqlCommand("SELECT [DocGia].[TenDG],[DocGia].[NgayHetHan] From [DocGia] WHERE [DocGia].[MaDG]='" + cbMaDG.Text + "'", con)
        Dim reader As SqlDataReader
        reader = cm.ExecuteReader()
        If (reader.HasRows) Then
            reader.Read()
            txtTenDG.Text = reader.GetString(0).ToString
            dtpHSD.Value = reader.GetDateTime(1).Date
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
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
    Private Sub cbDoiTuong_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbDoiTuong.SelectedValueChanged
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
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        loadListSach()
        Me.txtTimKiem.Focus()
        Me.cbDoiTuong.Text = "Chọn..."
        Me.txtTimKiem.Text = ""
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Hide()
    End Sub
End Class