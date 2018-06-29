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

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try

            quydinh.TuoiToiThieu = Integer.Parse(txtTuoiToiThieu.Text)
            quydinh.TuoiToiDa = Integer.Parse(txtTuoiToiDa.Text)
            quydinh.ThoiGianSuDung = Integer.Parse(txtHanSuDung.Text)
            quydinh.KhoangCachNamXuatBan = Integer.Parse(txtKCNXB.Text)
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
        Me.Close()
    End Sub

    Private Sub txtTuoiToiThieu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTuoiToiThieu.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTuoiToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTuoiToiDa.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHanSuDung_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHanSuDung.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKCNXB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKCNXB.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSoLuongTheLoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongTheLoai.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSSMTD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSSMTD.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSNMuon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSNMuon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class