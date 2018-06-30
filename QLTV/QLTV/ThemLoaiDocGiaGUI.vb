Imports BUS
Imports DTO
Imports Utility

Public Class ThemLoaiDocGiaGUI

    Private ldgBus As LoaiDocGiaBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim ldg As LoaiDocGiaDTO
        ldg = New LoaiDocGiaDTO()

        '1. Mapping data from GUI control
        ldg.MaLDG = Convert.ToInt32(txtMaLoai.Text)
        ldg.TenLDG = txtTenLoai.Text

        '2. Business .....
        If (ldgBus.isValidName(ldg) = False) Then
            MessageBox.Show("Tên Loại Đọc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = ldgBus.insert(ldg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoai.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = ldgBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            LoaiDocGiaGUI.loadListLoaiDocGia()
        Else
            MessageBox.Show("Thêm loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub LoaiDocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ldgBus = New LoaiDocGiaBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = ldgBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Hide()
    End Sub
End Class