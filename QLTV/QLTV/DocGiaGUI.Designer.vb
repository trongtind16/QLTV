﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocGiaGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocGiaGUI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpNgayHetHan = New System.Windows.Forms.DateTimePicker()
        Me.cbDoiTuong = New System.Windows.Forms.ComboBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvListDG = New System.Windows.Forms.DataGridView()
        Me.MaDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLapThe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayHetHan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.txtTenDG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaDG = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLoaiDG = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpNgayHetHan
        '
        Me.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayHetHan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHetHan.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpNgayHetHan.Location = New System.Drawing.Point(1008, 153)
        Me.dtpNgayHetHan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayHetHan.Name = "dtpNgayHetHan"
        Me.dtpNgayHetHan.Size = New System.Drawing.Size(275, 27)
        Me.dtpNgayHetHan.TabIndex = 96
        Me.dtpNgayHetHan.Value = New Date(2018, 11, 25, 0, 0, 0, 0)
        '
        'cbDoiTuong
        '
        Me.cbDoiTuong.FormattingEnabled = True
        Me.cbDoiTuong.Items.AddRange(New Object() {"Mã Độc Giả", "Tên Độc Giả"})
        Me.cbDoiTuong.Location = New System.Drawing.Point(391, 366)
        Me.cbDoiTuong.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDoiTuong.Name = "cbDoiTuong"
        Me.cbDoiTuong.Size = New System.Drawing.Size(160, 24)
        Me.cbDoiTuong.TabIndex = 96
        '
        'btnHuy
        '
        Me.btnHuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHuy.BackgroundImage = CType(resources.GetObject("btnHuy.BackgroundImage"), System.Drawing.Image)
        Me.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHuy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.ForeColor = System.Drawing.Color.Black
        Me.btnHuy.Location = New System.Drawing.Point(913, 351)
        Me.btnHuy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(131, 50)
        Me.btnHuy.TabIndex = 93
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHuy.UseVisualStyleBackColor = False
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTimKiem.BackgroundImage = CType(resources.GetObject("btnTimKiem.BackgroundImage"), System.Drawing.Image)
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.ForeColor = System.Drawing.Color.Black
        Me.btnTimKiem.Location = New System.Drawing.Point(774, 351)
        Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(131, 50)
        Me.btnTimKiem.TabIndex = 92
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTimKiem.UseVisualStyleBackColor = False
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(559, 363)
        Me.txtTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(207, 27)
        Me.txtTimKiem.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btxoa)
        Me.GroupBox2.Controls.Add(Me.btthoat)
        Me.GroupBox2.Controls.Add(Me.btthem)
        Me.GroupBox2.Controls.Add(Me.btsua)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(412, 217)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(617, 126)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'btxoa
        '
        Me.btxoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btxoa.BackgroundImage = CType(resources.GetObject("btxoa.BackgroundImage"), System.Drawing.Image)
        Me.btxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btxoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Location = New System.Drawing.Point(319, 44)
        Me.btxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(133, 59)
        Me.btxoa.TabIndex = 45
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.UseVisualStyleBackColor = False
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(460, 44)
        Me.btthoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(133, 59)
        Me.btthoat.TabIndex = 48
        Me.btthoat.Text = "Trở Về"
        Me.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthoat.UseVisualStyleBackColor = False
        '
        'btthem
        '
        Me.btthem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthem.BackgroundImage = CType(resources.GetObject("btthem.BackgroundImage"), System.Drawing.Image)
        Me.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthem.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthem.ForeColor = System.Drawing.Color.Black
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.Location = New System.Drawing.Point(35, 44)
        Me.btthem.Margin = New System.Windows.Forms.Padding(4)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(133, 59)
        Me.btthem.TabIndex = 44
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = False
        '
        'btsua
        '
        Me.btsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btsua.BackgroundImage = CType(resources.GetObject("btsua.BackgroundImage"), System.Drawing.Image)
        Me.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btsua.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsua.ForeColor = System.Drawing.Color.Black
        Me.btsua.Location = New System.Drawing.Point(178, 44)
        Me.btsua.Margin = New System.Windows.Forms.Padding(4)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(133, 59)
        Me.btsua.TabIndex = 46
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(878, 160)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Ngày Hết Hạn  :"
        '
        'dgvListDG
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDG, Me.TenDG, Me.GioiTinh, Me.NgaySinh, Me.Email, Me.DiaChi, Me.TenLDG, Me.NgayLapThe, Me.NgayHetHan})
        Me.dgvListDG.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvListDG.Location = New System.Drawing.Point(16, 409)
        Me.dgvListDG.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListDG.Name = "dgvListDG"
        Me.dgvListDG.ReadOnly = True
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvListDG.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvListDG.Size = New System.Drawing.Size(1315, 356)
        Me.dgvListDG.TabIndex = 55
        '
        'MaDG
        '
        Me.MaDG.DataPropertyName = "MaDG"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaDG.DefaultCellStyle = DataGridViewCellStyle2
        Me.MaDG.HeaderText = "Mã Độc Giả"
        Me.MaDG.Name = "MaDG"
        Me.MaDG.ReadOnly = True
        '
        'TenDG
        '
        Me.TenDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenDG.DataPropertyName = "TenDG"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenDG.DefaultCellStyle = DataGridViewCellStyle3
        Me.TenDG.HeaderText = "Tên Độc Giả"
        Me.TenDG.Name = "TenDG"
        Me.TenDG.ReadOnly = True
        '
        'GioiTinh
        '
        Me.GioiTinh.DataPropertyName = "GioiTinh"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GioiTinh.DefaultCellStyle = DataGridViewCellStyle4
        Me.GioiTinh.HeaderText = "Giới Tính"
        Me.GioiTinh.Name = "GioiTinh"
        Me.GioiTinh.ReadOnly = True
        '
        'NgaySinh
        '
        Me.NgaySinh.DataPropertyName = "NgaySinh"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgaySinh.DefaultCellStyle = DataGridViewCellStyle5
        Me.NgaySinh.HeaderText = "Ngày Sinh"
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.ReadOnly = True
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Email.DataPropertyName = "Email"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Email.DefaultCellStyle = DataGridViewCellStyle6
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'DiaChi
        '
        Me.DiaChi.DataPropertyName = "DiaChi"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DiaChi.DefaultCellStyle = DataGridViewCellStyle7
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        '
        'TenLDG
        '
        Me.TenLDG.DataPropertyName = "MaLDG"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenLDG.DefaultCellStyle = DataGridViewCellStyle8
        Me.TenLDG.HeaderText = "Loại ĐG"
        Me.TenLDG.Name = "TenLDG"
        Me.TenLDG.ReadOnly = True
        '
        'NgayLapThe
        '
        Me.NgayLapThe.DataPropertyName = "NgayLapThe"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgayLapThe.DefaultCellStyle = DataGridViewCellStyle9
        Me.NgayLapThe.HeaderText = "Ngày Lập Thẻ"
        Me.NgayLapThe.Name = "NgayLapThe"
        Me.NgayLapThe.ReadOnly = True
        '
        'NgayHetHan
        '
        Me.NgayHetHan.DataPropertyName = "NgayHetHan"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgayHetHan.DefaultCellStyle = DataGridViewCellStyle10
        Me.NgayHetHan.HeaderText = "Ngày Hết Hạn"
        Me.NgayHetHan.Name = "NgayHetHan"
        Me.NgayHetHan.ReadOnly = True
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.Items.AddRange(New Object() {"NAM", "NỮ", "KHÁC"})
        Me.cbGioiTinh.Location = New System.Drawing.Point(563, 105)
        Me.cbGioiTinh.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(275, 28)
        Me.cbGioiTinh.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgayHetHan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbGioiTinh)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpNgayLapThe)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.dtpNgaySinh)
        Me.GroupBox1.Controls.Add(Me.txtTenDG)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMaDG)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbLoaiDG)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1310, 202)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Độc Giả"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(415, 113)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Giới Tính :"
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayLapThe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(1008, 100)
        Me.dtpNgayLapThe.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(275, 27)
        Me.dtpNgayLapThe.TabIndex = 45
        Me.dtpNgayLapThe.Value = New Date(2018, 5, 17, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(878, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Ngày Lập Thẻ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(8, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mã Độc Giả :"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(1008, 54)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(275, 27)
        Me.txtDiaChi.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(563, 153)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(275, 27)
        Me.txtEmail.TabIndex = 41
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgaySinh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(116, 154)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(275, 26)
        Me.dtpNgaySinh.TabIndex = 34
        Me.dtpNgaySinh.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'txtTenDG
        '
        Me.txtTenDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDG.Location = New System.Drawing.Point(116, 105)
        Me.txtTenDG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenDG.Name = "txtTenDG"
        Me.txtTenDG.Size = New System.Drawing.Size(275, 27)
        Me.txtTenDG.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(878, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Địa Chỉ :"
        '
        'txtMaDG
        '
        Me.txtMaDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaDG.Location = New System.Drawing.Point(116, 53)
        Me.txtMaDG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaDG.Name = "txtMaDG"
        Me.txtMaDG.ReadOnly = True
        Me.txtMaDG.Size = New System.Drawing.Size(275, 27)
        Me.txtMaDG.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(415, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Email :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(8, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Tên Độc Giả : "
        '
        'cbLoaiDG
        '
        Me.cbLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoaiDG.FormattingEnabled = True
        Me.cbLoaiDG.Location = New System.Drawing.Point(563, 53)
        Me.cbLoaiDG.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiDG.Name = "cbLoaiDG"
        Me.cbLoaiDG.Size = New System.Drawing.Size(275, 28)
        Me.cbLoaiDG.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(8, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Ngày Sinh :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(415, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Loại Độc Giả :"
        '
        'DocGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1344, 773)
        Me.Controls.Add(Me.cbDoiTuong)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.dgvListDG)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DocGiaGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DocGiaGUI"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpNgayHetHan As DateTimePicker
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btxoa As Button
    Friend WithEvents btthoat As Button
    Friend WithEvents btthem As Button
    Friend WithEvents btsua As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvListDG As DataGridView
    Friend WithEvents cbGioiTinh As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpNgayLapThe As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents txtTenDG As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaDG As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLoaiDG As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDoiTuong As ComboBox
    Friend WithEvents MaDG As DataGridViewTextBoxColumn
    Friend WithEvents TenDG As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinh As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinh As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As DataGridViewTextBoxColumn
    Friend WithEvents TenLDG As DataGridViewTextBoxColumn
    Friend WithEvents NgayLapThe As DataGridViewTextBoxColumn
    Friend WithEvents NgayHetHan As DataGridViewTextBoxColumn
End Class
