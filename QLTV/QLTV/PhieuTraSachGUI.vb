Imports System.Configuration
Imports System.Data.SqlClient
Imports BUS
Imports DTO
Imports Utility
Public Class PhieuTraSachGUI
    Private pmsBUS As PhieuMuonSachBUS
    Dim pms As PhieuMuonSachDTO
    Dim qdBus As QuyDinhBUS
    Dim qdDTO As QuyDinhDTO
    Dim listQuyDinh = New List(Of QuyDinhDTO)
    Dim resul As Result

    Private Sub PhieuTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pmsBUS = New PhieuMuonSachBUS()
        loadListPhieuTraSach()
    End Sub
    Private con As SqlConnection
    Private Sub connect()
        Dim conn As String = ConfigurationManager.AppSettings("ConnectionString")
        Try
            con = New SqlConnection(conn)
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub loadListPhieuTraSach()
        Dim listPhieuTraSach = New List(Of PhieuMuonSachDTO)
        Dim result As Result
        result = pmsBUS.selectAll(listPhieuTraSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        ''
        dgvChiTietPhieuMuon.AutoGenerateColumns = False
        dgvChiTietPhieuMuon.AllowUserToAddRows = False
        dgvChiTietPhieuMuon.DataSource = listPhieuTraSach
    End Sub
    Private Sub dgvChiTietPhieuMuon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvChiTietPhieuMuon.SelectionChanged
        Dim currentRowIndex As Integer = dgvChiTietPhieuMuon.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < dgvChiTietPhieuMuon.RowCount) Then
            Try
                Dim PhieuMuon = CType(dgvChiTietPhieuMuon.Rows(currentRowIndex).DataBoundItem, PhieuMuonSachDTO)
                txtMaPhieu.Text = PhieuMuon.MaPhieu
                txtMaDG.Text = PhieuMuon.MaDG
                txtTenDocGia.Text = PhieuMuon.TenDG
                txtMaSach.Text = PhieuMuon.MaSach
                txtTenSach.Text = PhieuMuon.TenSach
                dtpNgayMuon.Text = PhieuMuon.NgayMuon
                dtpNgayHenTra.Text = PhieuMuon.NgayHenTra
                dtpNgayTra.Text = PhieuMuon.NgayTra
                txtTinhTrangPhieuMuon.Text = PhieuMuon.TinhTrangPhieuMuon
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub



    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Thêm Phiếu Mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        connect()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim MS = Me.txtMaSach.Text
            Dim SQL1 = "UPDATE Sach SET MaTTS = 1 WHERE MaSach = N'" + MS + "'"
            Dim Adapter1 As New SqlClient.SqlDataAdapter(SQL1, con)
            Dim DATA1 As New DataSet
            Adapter1.Fill(DATA1, "Sach")
        Dim MPM = Me.txtMaPhieu.Text.Trim()
        Dim SQL2 = "UPDATE MuonTraSach SET TinhTrangPhieuMuon = N'Đã Trả' WHERE MaPhieu = N'" + MPM + "'"
        Dim Adapter2 As New SqlClient.SqlDataAdapter(SQL2, con)
            Dim DATA2 As New DataSet
            Adapter2.Fill(DATA2, "MuonTraSach")
            loadListPhieuTraSach()
        QuanLyPhieuMuonGUI.loadListPhieuMuonSach()
    End Sub
End Class