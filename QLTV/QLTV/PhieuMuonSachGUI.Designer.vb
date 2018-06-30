<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhieuMuonSachGUI))
        Me.dgvlistSach = New System.Windows.Forms.DataGridView()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTLS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NXB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbDoiTuong = New System.Windows.Forms.ComboBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpHSD = New System.Windows.Forms.DateTimePicker()
        Me.txtTenDG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaPhieu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.cbMaDG = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpNgayHenTra = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvlistSach
        '
        Me.dgvlistSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlistSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.TenSach, Me.MaTTS, Me.TriGia, Me.MaTLS, Me.TenTG, Me.NamXB, Me.NXB})
        Me.dgvlistSach.Location = New System.Drawing.Point(13, 368)
        Me.dgvlistSach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvlistSach.Name = "dgvlistSach"
        Me.dgvlistSach.ReadOnly = True
        Me.dgvlistSach.Size = New System.Drawing.Size(1102, 310)
        Me.dgvlistSach.TabIndex = 59
        '
        'MaSach
        '
        Me.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaSach.DataPropertyName = "MaSach"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaSach.DefaultCellStyle = DataGridViewCellStyle1
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.ReadOnly = True
        Me.MaSach.Width = 90
        '
        'TenSach
        '
        Me.TenSach.DataPropertyName = "TenSach"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenSach.DefaultCellStyle = DataGridViewCellStyle2
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.ReadOnly = True
        '
        'MaTTS
        '
        Me.MaTTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaTTS.DataPropertyName = "MaTTS"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaTTS.DefaultCellStyle = DataGridViewCellStyle3
        Me.MaTTS.HeaderText = "Tình Trạng"
        Me.MaTTS.Name = "MaTTS"
        Me.MaTTS.ReadOnly = True
        Me.MaTTS.Width = 75
        '
        'TriGia
        '
        Me.TriGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TriGia.DataPropertyName = "TriGia"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TriGia.DefaultCellStyle = DataGridViewCellStyle4
        Me.TriGia.HeaderText = "Trị Giá"
        Me.TriGia.Name = "TriGia"
        Me.TriGia.ReadOnly = True
        Me.TriGia.Width = 75
        '
        'MaTLS
        '
        Me.MaTLS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MaTLS.DataPropertyName = "MaTLS"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaTLS.DefaultCellStyle = DataGridViewCellStyle5
        Me.MaTLS.HeaderText = "Thể Loại"
        Me.MaTLS.Name = "MaTLS"
        Me.MaTLS.ReadOnly = True
        Me.MaTLS.Width = 125
        '
        'TenTG
        '
        Me.TenTG.DataPropertyName = "TenTG"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenTG.DefaultCellStyle = DataGridViewCellStyle6
        Me.TenTG.HeaderText = "Tác Giả"
        Me.TenTG.Name = "TenTG"
        Me.TenTG.ReadOnly = True
        '
        'NamXB
        '
        Me.NamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NamXB.DataPropertyName = "NamXB"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NamXB.DefaultCellStyle = DataGridViewCellStyle7
        Me.NamXB.HeaderText = "Năm Xuất Bản"
        Me.NamXB.Name = "NamXB"
        Me.NamXB.ReadOnly = True
        Me.NamXB.Width = 95
        '
        'NXB
        '
        Me.NXB.DataPropertyName = "NXB"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NXB.DefaultCellStyle = DataGridViewCellStyle8
        Me.NXB.HeaderText = "Nhà Xuất Bản"
        Me.NXB.Name = "NXB"
        Me.NXB.ReadOnly = True
        '
        'cbDoiTuong
        '
        Me.cbDoiTuong.FormattingEnabled = True
        Me.cbDoiTuong.Items.AddRange(New Object() {"Mã Sách", "Tên Sách", "Tác Giả"})
        Me.cbDoiTuong.Location = New System.Drawing.Point(233, 322)
        Me.cbDoiTuong.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDoiTuong.Name = "cbDoiTuong"
        Me.cbDoiTuong.Size = New System.Drawing.Size(160, 24)
        Me.cbDoiTuong.TabIndex = 2
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(401, 318)
        Me.txtTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(207, 27)
        Me.txtTimKiem.TabIndex = 60
        '
        'btthem
        '
        Me.btthem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthem.BackgroundImage = CType(resources.GetObject("btthem.BackgroundImage"), System.Drawing.Image)
        Me.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthem.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthem.ForeColor = System.Drawing.Color.Black
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.Location = New System.Drawing.Point(80, 37)
        Me.btthem.Margin = New System.Windows.Forms.Padding(4)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(133, 59)
        Me.btthem.TabIndex = 62
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = False
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTimKiem.BackgroundImage = CType(resources.GetObject("btnTimKiem.BackgroundImage"), System.Drawing.Image)
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTimKiem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.ForeColor = System.Drawing.Color.Black
        Me.btnTimKiem.Location = New System.Drawing.Point(622, 302)
        Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(133, 59)
        Me.btnTimKiem.TabIndex = 93
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTimKiem.UseVisualStyleBackColor = False
        '
        'btnHuy
        '
        Me.btnHuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHuy.BackgroundImage = CType(resources.GetObject("btnHuy.BackgroundImage"), System.Drawing.Image)
        Me.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHuy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.ForeColor = System.Drawing.Color.Black
        Me.btnHuy.Location = New System.Drawing.Point(763, 301)
        Me.btnHuy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(133, 59)
        Me.btnHuy.TabIndex = 94
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHuy.UseVisualStyleBackColor = False
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(221, 38)
        Me.btthoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(133, 59)
        Me.btthoat.TabIndex = 95
        Me.btthoat.Text = "Trở Về"
        Me.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthoat.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btthoat)
        Me.GroupBox2.Controls.Add(Me.btthem)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(401, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 105)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'dtpHSD
        '
        Me.dtpHSD.CustomFormat = "dd/MM/yyyy"
        Me.dtpHSD.Enabled = False
        Me.dtpHSD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHSD.Location = New System.Drawing.Point(179, 139)
        Me.dtpHSD.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHSD.Name = "dtpHSD"
        Me.dtpHSD.Size = New System.Drawing.Size(188, 26)
        Me.dtpHSD.TabIndex = 116
        Me.dtpHSD.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'txtTenDG
        '
        Me.txtTenDG.Location = New System.Drawing.Point(179, 109)
        Me.txtTenDG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenDG.Name = "txtTenDG"
        Me.txtTenDG.Size = New System.Drawing.Size(188, 22)
        Me.txtTenDG.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(49, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Tên Độc Giả"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(49, 145)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "HSD Thẻ"
        '
        'dtpNgayTra
        '
        Me.dtpNgayTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayTra.Enabled = False
        Me.dtpNgayTra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayTra.Location = New System.Drawing.Point(555, 130)
        Me.dtpNgayTra.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayTra.Name = "dtpNgayTra"
        Me.dtpNgayTra.Size = New System.Drawing.Size(178, 26)
        Me.dtpNgayTra.TabIndex = 114
        Me.dtpNgayTra.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayMuon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayMuon.Location = New System.Drawing.Point(555, 55)
        Me.dtpNgayMuon.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(178, 26)
        Me.dtpNgayMuon.TabIndex = 115
        Me.dtpNgayMuon.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(49, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Mã Phiếu Mượn"
        '
        'txtMaPhieu
        '
        Me.txtMaPhieu.Enabled = False
        Me.txtMaPhieu.Location = New System.Drawing.Point(179, 49)
        Me.txtMaPhieu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaPhieu.Name = "txtMaPhieu"
        Me.txtMaPhieu.Size = New System.Drawing.Size(188, 22)
        Me.txtMaPhieu.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(49, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Mã Độc Giả"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(384, 133)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Ngày Trả"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(384, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Ngày Mượn"
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(927, 74)
        Me.txtMaSach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(160, 22)
        Me.txtMaSach.TabIndex = 110
        '
        'txtTenSach
        '
        Me.txtTenSach.Enabled = False
        Me.txtTenSach.Location = New System.Drawing.Point(927, 113)
        Me.txtTenSach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(160, 22)
        Me.txtTenSach.TabIndex = 111
        '
        'cbMaDG
        '
        Me.cbMaDG.FormattingEnabled = True
        Me.cbMaDG.Location = New System.Drawing.Point(179, 77)
        Me.cbMaDG.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMaDG.Name = "cbMaDG"
        Me.cbMaDG.Size = New System.Drawing.Size(188, 24)
        Me.cbMaDG.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(818, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Mã Sách"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(818, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Tên Sách"
        '
        'dtpNgayHenTra
        '
        Me.dtpNgayHenTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayHenTra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHenTra.Location = New System.Drawing.Point(555, 93)
        Me.dtpNgayHenTra.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayHenTra.Name = "dtpNgayHenTra"
        Me.dtpNgayHenTra.Size = New System.Drawing.Size(178, 26)
        Me.dtpNgayHenTra.TabIndex = 113
        Me.dtpNgayHenTra.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(384, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Ngày Hẹn Trả"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1102, 180)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Phiếu Mượn Sách"
        '
        'PhieuMuonSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1133, 691)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.dtpHSD)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTenDG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpNgayTra)
        Me.Controls.Add(Me.dtpNgayMuon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaPhieu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.cbMaDG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpNgayHenTra)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.dgvlistSach)
        Me.Controls.Add(Me.cbDoiTuong)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PhieuMuonSachGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhieuMuonSachGUI"
        CType(Me.dgvlistSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvlistSach As DataGridView
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents MaTTS As DataGridViewTextBoxColumn
    Friend WithEvents TriGia As DataGridViewTextBoxColumn
    Friend WithEvents MaTLS As DataGridViewTextBoxColumn
    Friend WithEvents TenTG As DataGridViewTextBoxColumn
    Friend WithEvents NamXB As DataGridViewTextBoxColumn
    Friend WithEvents NXB As DataGridViewTextBoxColumn
    Friend WithEvents cbDoiTuong As ComboBox
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents btthem As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents btthoat As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpHSD As DateTimePicker
    Friend WithEvents txtTenDG As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpNgayTra As DateTimePicker
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaPhieu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents cbMaDG As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpNgayHenTra As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
