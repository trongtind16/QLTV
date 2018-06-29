Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim aaa As LoaiDocGiaGUI = New LoaiDocGiaGUI()
        aaa.MdiParent = Me
        aaa.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim aaa As DocGiaGUI = New DocGiaGUI()
        aaa.MdiParent = Me
        aaa.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim aaa As QuyDinhGUI = New QuyDinhGUI()
        aaa.MdiParent = Me
        aaa.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim aaa As TheLoaiSachGUI = New TheLoaiSachGUI()
        aaa.MdiParent = Me
        aaa.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim aaa As TinhTrangSachGUI = New TinhTrangSachGUI()
        aaa.MdiParent = Me
        aaa.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Dim aaa As SachGUI = New SachGUI()
        aaa.MdiParent = Me
        aaa.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If SideMenu.Width = 43 Then
            SideMenu.Visible = False
            SideMenu.Width = 161
            PanelAnimator.ShowSync(SideMenu)
        Else
            SideMenu.Visible = False
            SideMenu.Width = 43
            PanelAnimator2.ShowSync(SideMenu)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
    End Sub
End Class
