﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhieuMuonSachGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMaDG = New System.Windows.Forms.ComboBox()
        Me.txtMaPhieu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenDG = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpNgayHenTra = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpHSD = New System.Windows.Forms.DateTimePicker()
        Me.dgvlistSach = New System.Windows.Forms.DataGridView()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTLS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.cbDoiTuong = New System.Windows.Forms.ComboBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(299, 110)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnNhap.TabIndex = 0
        Me.btnNhap.Text = "Thêm"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Phiếu Mượn"
        '
        'cbMaDG
        '
        Me.cbMaDG.FormattingEnabled = True
        Me.cbMaDG.Location = New System.Drawing.Point(121, 74)
        Me.cbMaDG.Name = "cbMaDG"
        Me.cbMaDG.Size = New System.Drawing.Size(121, 21)
        Me.cbMaDG.TabIndex = 2
        '
        'txtMaPhieu
        '
        Me.txtMaPhieu.Enabled = False
        Me.txtMaPhieu.Location = New System.Drawing.Point(121, 33)
        Me.txtMaPhieu.Name = "txtMaPhieu"
        Me.txtMaPhieu.Size = New System.Drawing.Size(121, 20)
        Me.txtMaPhieu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Đọc Giả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên Đọc Giả"
        '
        'txtTenDG
        '
        Me.txtTenDG.Location = New System.Drawing.Point(121, 107)
        Me.txtTenDG.Name = "txtTenDG"
        Me.txtTenDG.Size = New System.Drawing.Size(121, 20)
        Me.txtTenDG.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(638, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Sách"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(638, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tên Sách"
        '
        'txtTenSach
        '
        Me.txtTenSach.Enabled = False
        Me.txtTenSach.Location = New System.Drawing.Point(747, 58)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(121, 20)
        Me.txtTenSach.TabIndex = 3
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayMuon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayMuon.Location = New System.Drawing.Point(393, 32)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(207, 22)
        Me.dtpNgayMuon.TabIndex = 35
        Me.dtpNgayMuon.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ngày Mượn"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Ngày Hẹn Trả"
        '
        'dtpNgayHenTra
        '
        Me.dtpNgayHenTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayHenTra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHenTra.Location = New System.Drawing.Point(393, 60)
        Me.dtpNgayHenTra.Name = "dtpNgayHenTra"
        Me.dtpNgayHenTra.Size = New System.Drawing.Size(207, 22)
        Me.dtpNgayHenTra.TabIndex = 35
        Me.dtpNgayHenTra.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ngày Trả"
        '
        'dtpNgayTra
        '
        Me.dtpNgayTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayTra.Enabled = False
        Me.dtpNgayTra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayTra.Location = New System.Drawing.Point(393, 88)
        Me.dtpNgayTra.Name = "dtpNgayTra"
        Me.dtpNgayTra.Size = New System.Drawing.Size(207, 22)
        Me.dtpNgayTra.TabIndex = 35
        Me.dtpNgayTra.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "HSD Thẻ"
        '
        'dtpHSD
        '
        Me.dtpHSD.CustomFormat = "dd/MM/yyyy"
        Me.dtpHSD.Enabled = False
        Me.dtpHSD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHSD.Location = New System.Drawing.Point(121, 150)
        Me.dtpHSD.Name = "dtpHSD"
        Me.dtpHSD.Size = New System.Drawing.Size(137, 22)
        Me.dtpHSD.TabIndex = 35
        Me.dtpHSD.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'dgvlistSach
        '
        Me.dgvlistSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlistSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.TenSach, Me.MaTTS, Me.TriGia, Me.MaTLS, Me.TenTG, Me.NamXB, Me.NXB})
        Me.dgvlistSach.Location = New System.Drawing.Point(12, 179)
        Me.dgvlistSach.Name = "dgvlistSach"
        Me.dgvlistSach.ReadOnly = True
        Me.dgvlistSach.Size = New System.Drawing.Size(1098, 273)
        Me.dgvlistSach.TabIndex = 59
        '
        'MaSach
        '
        Me.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaSach.DataPropertyName = "MaSach"
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaSach.DefaultCellStyle = DataGridViewCellStyle17
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.ReadOnly = True
        Me.MaSach.Width = 90
        '
        'TenSach
        '
        Me.TenSach.DataPropertyName = "TenSach"
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenSach.DefaultCellStyle = DataGridViewCellStyle18
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.ReadOnly = True
        '
        'MaTTS
        '
        Me.MaTTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaTTS.DataPropertyName = "MaTTS"
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaTTS.DefaultCellStyle = DataGridViewCellStyle19
        Me.MaTTS.HeaderText = "Tình Trạng"
        Me.MaTTS.Name = "MaTTS"
        Me.MaTTS.ReadOnly = True
        Me.MaTTS.Width = 75
        '
        'TriGia
        '
        Me.TriGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TriGia.DataPropertyName = "TriGia"
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TriGia.DefaultCellStyle = DataGridViewCellStyle20
        Me.TriGia.HeaderText = "Trị Giá"
        Me.TriGia.Name = "TriGia"
        Me.TriGia.ReadOnly = True
        Me.TriGia.Width = 75
        '
        'MaTLS
        '
        Me.MaTLS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaTLS.DataPropertyName = "MaTLS"
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaTLS.DefaultCellStyle = DataGridViewCellStyle21
        Me.MaTLS.HeaderText = "Thể Loại"
        Me.MaTLS.Name = "MaTLS"
        Me.MaTLS.ReadOnly = True
        Me.MaTLS.Width = 125
        '
        'TenTG
        '
        Me.TenTG.DataPropertyName = "TenTG"
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenTG.DefaultCellStyle = DataGridViewCellStyle22
        Me.TenTG.HeaderText = "Tác Giả"
        Me.TenTG.Name = "TenTG"
        Me.TenTG.ReadOnly = True
        '
        'NamXB
        '
        Me.NamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NamXB.DataPropertyName = "NamXB"
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NamXB.DefaultCellStyle = DataGridViewCellStyle23
        Me.NamXB.HeaderText = "Năm Xuất Bản"
        Me.NamXB.Name = "NamXB"
        Me.NamXB.ReadOnly = True
        Me.NamXB.Width = 95
        '
        'NXB
        '
        Me.NXB.DataPropertyName = "NXB"
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NXB.DefaultCellStyle = DataGridViewCellStyle24
        Me.NXB.HeaderText = "Nhà Xuất Bản"
        Me.NXB.Name = "NXB"
        Me.NXB.ReadOnly = True
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(747, 29)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(121, 20)
        Me.txtMaSach.TabIndex = 3
        '
        'cbDoiTuong
        '
        Me.cbDoiTuong.FormattingEnabled = True
        Me.cbDoiTuong.Items.AddRange(New Object() {"Mã Sách", "Tên Sách", "Tác Giả"})
        Me.cbDoiTuong.Location = New System.Drawing.Point(329, 152)
        Me.cbDoiTuong.Name = "cbDoiTuong"
        Me.cbDoiTuong.Size = New System.Drawing.Size(121, 21)
        Me.cbDoiTuong.TabIndex = 2
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(601, 149)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
        Me.btnTimKiem.TabIndex = 0
        Me.btnTimKiem.Text = "Thêm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(693, 152)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 0
        Me.btnHuy.Text = "Thêm"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(456, 153)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(156, 23)
        Me.txtTimKiem.TabIndex = 60
        '
        'PhieuMuonSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 450)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.dgvlistSach)
        Me.Controls.Add(Me.dtpHSD)
        Me.Controls.Add(Me.dtpNgayTra)
        Me.Controls.Add(Me.dtpNgayHenTra)
        Me.Controls.Add(Me.dtpNgayMuon)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.txtTenDG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMaPhieu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbDoiTuong)
        Me.Controls.Add(Me.cbMaDG)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnNhap)
        Me.Name = "PhieuMuonSachGUI"
        Me.Text = "PhieuMuonSachGUI"
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMaDG As ComboBox
    Friend WithEvents txtMaPhieu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenDG As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpNgayHenTra As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpNgayTra As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpHSD As DateTimePicker
    Friend WithEvents dgvlistSach As DataGridView
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents MaTTS As DataGridViewTextBoxColumn
    Friend WithEvents TriGia As DataGridViewTextBoxColumn
    Friend WithEvents MaTLS As DataGridViewTextBoxColumn
    Friend WithEvents TenTG As DataGridViewTextBoxColumn
    Friend WithEvents NamXB As DataGridViewTextBoxColumn
    Friend WithEvents NXB As DataGridViewTextBoxColumn
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents cbDoiTuong As ComboBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents txtTimKiem As TextBox
End Class
