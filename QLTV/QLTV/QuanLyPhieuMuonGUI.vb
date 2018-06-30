Imports System.Configuration
Imports System.Data.SqlClient
Imports BUS
Imports DTO
Imports Utility
Public Class QuanLyPhieuMuonGUI
    Private pmsBUS As PhieuMuonSachBUS

    Private Sub PhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pmsBUS = New PhieuMuonSachBUS()
        loadListPhieuMuonSach()
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
    Public Sub loadListPhieuMuonSach()
        Dim listPhieuMuonSach = New List(Of PhieuMuonSachDTO)
        Dim result As Result
        result = pmsBUS.selectAll(listPhieuMuonSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvChiTietPhieuMuon.AutoGenerateColumns = False
        dgvChiTietPhieuMuon.AllowUserToAddRows = False
        dgvChiTietPhieuMuon.DataSource = listPhieuMuonSach
    End Sub
    Private Sub dgvChiTietPhieuMuon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvChiTietPhieuMuon.SelectionChanged
        Dim currentRowIndex As Integer = dgvChiTietPhieuMuon.CurrentCellAddress.Y

        If (-1 < currentRowIndex And currentRowIndex < dgvChiTietPhieuMuon.RowCount) Then
            Try
                Dim PhieuMuon = CType(dgvChiTietPhieuMuon.Rows(currentRowIndex).DataBoundItem, PhieuMuonSachDTO)
                txtMaPhieu.Text = PhieuMuon.MaPhieu
                txtMaDG.Text = PhieuMuon.MaDG
                txtTenDocGia.Text = PhieuMuon.TenDG
                txtMaS.Text = PhieuMuon.MaSach
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
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        PhieuMuonSachGUI.Show()
    End Sub



    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btthoat.Click
        Me.Close()
    End Sub
End Class