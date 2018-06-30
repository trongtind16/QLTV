Public Class Form1
    Dim LDG As LoaiDocGiaGUI = New LoaiDocGiaGUI()
    Dim DG As DocGiaGUI = New DocGiaGUI()
    Dim QD As QuyDinhGUI = New QuyDinhGUI()
    Dim TLS As TheLoaiSachGUI = New TheLoaiSachGUI()
    Dim TTS As TinhTrangSachGUI = New TinhTrangSachGUI()
    Dim S As SachGUI = New SachGUI()
    Dim QLPM As QuanLyPhieuMuonGUI = New QuanLyPhieuMuonGUI()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        LDG.MdiParent = Me
        LDG.Hide()
        DG.Hide()
        QD.Hide()
        TLS.Hide()
        TTS.Hide()
        S.Hide()
        QLPM.Hide()
        LDG.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        DG.MdiParent = Me
        LDG.Hide()
        DG.Hide()
        QD.Hide()
        TLS.Hide()
        TTS.Hide()
        S.Hide()
        QLPM.Hide()
        DG.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        QD.MdiParent = Me
        LDG.Hide()
        DG.Hide()
        QD.Hide()
        TLS.Hide()
        TTS.Hide()
        S.Hide()
        QLPM.Hide()
        QD.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        TLS.MdiParent = Me
        LDG.Hide()
        DG.Hide()
        QD.Hide()
        TLS.Hide()
        TTS.Hide()
        S.Hide()
        QLPM.Hide()
        TLS.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        TTS.MdiParent = Me
        LDG.Hide()
        DG.Hide()
        QD.Hide()
        TLS.Hide()
        TTS.Hide()
        S.Hide()
        QLPM.Hide()
        TTS.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        S.MdiParent = Me
        LDG.Hide()
        DG.Hide()
        QD.Hide()
        TLS.Hide()
        TTS.Hide()
        S.Hide()
        QLPM.Hide()
        S.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)
        QLPM.MdiParent = Me
        LDG.Hide()
        DG.Hide()
        QD.Hide()
        TLS.Hide()
        TTS.Hide()
        S.Hide()
        QLPM.Hide()
        QLPM.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If SideMenu.Width = 48 Then
            SideMenu.Visible = False
            SideMenu.Width = 196
            PanelAnimator.ShowSync(SideMenu)
        Else
            SideMenu.Visible = False
            SideMenu.Width = 48
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
