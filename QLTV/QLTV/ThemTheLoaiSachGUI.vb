Imports BUS
Imports DTO
Imports Utility

Public Class ThemTheLoaiSachGUI
    Private tlsBus As TheLoaiSachBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

        Dim tls As TheLoaiSachDTO
        tls = New TheLoaiSachDTO()

        '1. Mapping data from GUI control
        tls.MaTLS = Convert.ToInt32(txtMaLoai.Text)
        tls.TenTLS = txtTenLoai.Text

        '2. Business .....
        If (tlsBus.isValidName(tls) = False) Then
            MessageBox.Show("Tên Thể loại sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tlsBus.insert(tls)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Thể loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoai.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = tlsBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            TheLoaiSachGUI.loadListTheLoaiSach()
        Else
            MessageBox.Show("Thêm Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub TheLoaiSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tlsBus = New TheLoaiSachBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = tlsBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class