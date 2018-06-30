﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        LoaiDocGiaGUI.MdiParent = Me

        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()

        LoaiDocGiaGUI.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        DocGiaGUI.MdiParent = Me

        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()

        DocGiaGUI.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        QuyDinhGUI.MdiParent = Me

        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()

        QuyDinhGUI.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        TheLoaiSachGUI.MdiParent = Me

        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()

        TheLoaiSachGUI.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        TinhTrangSachGUI.MdiParent = Me

        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()

        TinhTrangSachGUI.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        SachGUI.MdiParent = Me

        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()

        SachGUI.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        QuanLyPhieuMuonGUI.MdiParent = Me

        LoaiDocGiaGUI.Hide()
        DocGiaGUI.Hide()
        QuyDinhGUI.Hide()
        TheLoaiSachGUI.Hide()
        TinhTrangSachGUI.Hide()
        SachGUI.Hide()
        QuanLyPhieuMuonGUI.Hide()

        QuanLyPhieuMuonGUI.Show()
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
