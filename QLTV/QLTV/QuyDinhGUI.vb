Imports BUS
Imports DTO
Public Class QuyDinhGUI
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO
    Private Sub QuyDinhGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinhBUS()
        Dim listQuyDinh = New List(Of QuyDinhDTO)
        Dim result = qdBus.selectALL(listQuyDinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        quydinh = listQuyDinh(0)
        txtTuoiToiThieu.Text = quydinh.TuoiToiThieu
        txtTuoiToiDa.Text = quydinh.TuoiToiDa
        txtHanSuDung.Text = quydinh.ThoiGianSuDung
        txtKCNXB.Text = quydinh.KhoangCachNamXuatBan
        txtNgayMuonToiDa.Text = quydinh.NgayMuonToiDa
        txtSachMuonToiDa.Text = quydinh.SachMuonToiDa
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try

            quydinh.TuoiToiThieu = Integer.Parse(txtTuoiToiThieu.Text)
            quydinh.TuoiToiDa = Integer.Parse(txtTuoiToiDa.Text)
            quydinh.ThoiGianSuDung = Integer.Parse(txtHanSuDung.Text)
            quydinh.KhoangCachNamXuatBan = Integer.Parse(txtKCNXB.Text)
            quydinh.SachMuonToiDa = Integer.Parse(txtSachMuonToiDa.Text)
            quydinh.NgayMuonToiDa = Integer.Parse(txtNgayMuonToiDa.Text)
            Dim result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Hide()
    End Sub
End Class