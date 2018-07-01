<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhieuTraSachGUI
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhieuTraSachGUI))
        Me.TinhTrangPhieuMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpNgayHenTra = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.NgayHenTra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvChiTietPhieuMuon = New System.Windows.Forms.DataGridView()
        Me.NgayTra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTinhTrangPhieuMuon = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.txtTenDocGia = New System.Windows.Forms.TextBox()
        Me.txtMaDG = New System.Windows.Forms.TextBox()
        Me.txtMaPhieu = New System.Windows.Forms.TextBox()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvChiTietPhieuMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TinhTrangPhieuMuon
        '
        Me.TinhTrangPhieuMuon.DataPropertyName = "TinhTrangPhieuMuon"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TinhTrangPhieuMuon.DefaultCellStyle = DataGridViewCellStyle9
        Me.TinhTrangPhieuMuon.HeaderText = "Tình Trạng Mượn Trả"
        Me.TinhTrangPhieuMuon.Name = "TinhTrangPhieuMuon"
        Me.TinhTrangPhieuMuon.ReadOnly = True
        '
        'dtpNgayHenTra
        '
        Me.dtpNgayHenTra.CustomFormat = "dd/MM/yyy"
        Me.dtpNgayHenTra.Enabled = False
        Me.dtpNgayHenTra.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHenTra.Location = New System.Drawing.Point(551, 150)
        Me.dtpNgayHenTra.Name = "dtpNgayHenTra"
        Me.dtpNgayHenTra.Size = New System.Drawing.Size(203, 23)
        Me.dtpNgayHenTra.TabIndex = 58
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.CustomFormat = "dd/MM/yyy"
        Me.dtpNgayMuon.Enabled = False
        Me.dtpNgayMuon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayMuon.Location = New System.Drawing.Point(551, 113)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(203, 23)
        Me.dtpNgayMuon.TabIndex = 57
        '
        'NgayHenTra
        '
        Me.NgayHenTra.DataPropertyName = "NgayHenTra"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgayHenTra.DefaultCellStyle = DataGridViewCellStyle10
        Me.NgayHenTra.HeaderText = "Ngày Hẹn Trả"
        Me.NgayHenTra.Name = "NgayHenTra"
        Me.NgayHenTra.ReadOnly = True
        '
        'NgayMuon
        '
        Me.NgayMuon.DataPropertyName = "NgayMuon"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NgayMuon.DefaultCellStyle = DataGridViewCellStyle11
        Me.NgayMuon.HeaderText = "Ngày Mượn"
        Me.NgayMuon.Name = "NgayMuon"
        Me.NgayMuon.ReadOnly = True
        '
        'TenSach
        '
        Me.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TenSach.DataPropertyName = "TenSach"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenSach.DefaultCellStyle = DataGridViewCellStyle12
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.ReadOnly = True
        Me.TenSach.Width = 130
        '
        'MaSach
        '
        Me.MaSach.DataPropertyName = "MaSach"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaSach.DefaultCellStyle = DataGridViewCellStyle13
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.ReadOnly = True
        '
        'TenDG
        '
        Me.TenDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TenDG.DataPropertyName = "TenDG"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TenDG.DefaultCellStyle = DataGridViewCellStyle14
        Me.TenDG.HeaderText = "Tên Độc Giả"
        Me.TenDG.Name = "TenDG"
        Me.TenDG.ReadOnly = True
        Me.TenDG.Width = 130
        '
        'MaDG
        '
        Me.MaDG.DataPropertyName = "MaDG"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaDG.DefaultCellStyle = DataGridViewCellStyle15
        Me.MaDG.HeaderText = "Mã Độc Giả"
        Me.MaDG.Name = "MaDG"
        Me.MaDG.ReadOnly = True
        '
        'MaPhieu
        '
        Me.MaPhieu.DataPropertyName = "MaPhieu"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Yellow
        Me.MaPhieu.DefaultCellStyle = DataGridViewCellStyle16
        Me.MaPhieu.HeaderText = "Mã Phiếu"
        Me.MaPhieu.Name = "MaPhieu"
        Me.MaPhieu.ReadOnly = True
        '
        'dgvChiTietPhieuMuon
        '
        Me.dgvChiTietPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChiTietPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietPhieuMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhieu, Me.MaDG, Me.TenDG, Me.MaSach, Me.TenSach, Me.NgayMuon, Me.NgayHenTra, Me.NgayTra, Me.TinhTrangPhieuMuon})
        Me.dgvChiTietPhieuMuon.Location = New System.Drawing.Point(12, 295)
        Me.dgvChiTietPhieuMuon.Name = "dgvChiTietPhieuMuon"
        Me.dgvChiTietPhieuMuon.ReadOnly = True
        Me.dgvChiTietPhieuMuon.Size = New System.Drawing.Size(1094, 280)
        Me.dgvChiTietPhieuMuon.TabIndex = 14
        '
        'NgayTra
        '
        Me.NgayTra.DataPropertyName = "NgayTra"
        Me.NgayTra.HeaderText = "Ngày Trả"
        Me.NgayTra.Name = "NgayTra"
        Me.NgayTra.ReadOnly = True
        '
        'dtpNgayTra
        '
        Me.dtpNgayTra.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayTra.Enabled = False
        Me.dtpNgayTra.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayTra.Location = New System.Drawing.Point(551, 182)
        Me.dtpNgayTra.Name = "dtpNgayTra"
        Me.dtpNgayTra.Size = New System.Drawing.Size(207, 23)
        Me.dtpNgayTra.TabIndex = 59
        Me.dtpNgayTra.Value = New Date(2018, 5, 17, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(323, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(364, 32)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Thông Tin Chi Tiết Phiếu Mượn"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgayTra)
        Me.GroupBox1.Controls.Add(Me.dtpNgayHenTra)
        Me.GroupBox1.Controls.Add(Me.dtpNgayMuon)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtTinhTrangPhieuMuon)
        Me.GroupBox1.Controls.Add(Me.txtTenSach)
        Me.GroupBox1.Controls.Add(Me.txtMaSach)
        Me.GroupBox1.Controls.Add(Me.txtTenDocGia)
        Me.GroupBox1.Controls.Add(Me.txtMaDG)
        Me.GroupBox1.Controls.Add(Me.txtMaPhieu)
        Me.GroupBox1.Controls.Add(Me.btthoat)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(49, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1026, 205)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Mượn Sách"
        '
        'txtTinhTrangPhieuMuon
        '
        Me.txtTinhTrangPhieuMuon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinhTrangPhieuMuon.Location = New System.Drawing.Point(222, 152)
        Me.txtTinhTrangPhieuMuon.Name = "txtTinhTrangPhieuMuon"
        Me.txtTinhTrangPhieuMuon.ReadOnly = True
        Me.txtTinhTrangPhieuMuon.Size = New System.Drawing.Size(179, 23)
        Me.txtTinhTrangPhieuMuon.TabIndex = 56
        '
        'txtTenSach
        '
        Me.txtTenSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenSach.Location = New System.Drawing.Point(551, 74)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.ReadOnly = True
        Me.txtTenSach.Size = New System.Drawing.Size(203, 23)
        Me.txtTenSach.TabIndex = 55
        '
        'txtMaSach
        '
        Me.txtMaSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSach.Location = New System.Drawing.Point(551, 37)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(203, 23)
        Me.txtMaSach.TabIndex = 54
        '
        'txtTenDocGia
        '
        Me.txtTenDocGia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDocGia.Location = New System.Drawing.Point(222, 113)
        Me.txtTenDocGia.Name = "txtTenDocGia"
        Me.txtTenDocGia.ReadOnly = True
        Me.txtTenDocGia.Size = New System.Drawing.Size(179, 23)
        Me.txtTenDocGia.TabIndex = 53
        '
        'txtMaDG
        '
        Me.txtMaDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaDG.Location = New System.Drawing.Point(222, 74)
        Me.txtMaDG.Name = "txtMaDG"
        Me.txtMaDG.ReadOnly = True
        Me.txtMaDG.Size = New System.Drawing.Size(179, 23)
        Me.txtMaDG.TabIndex = 52
        '
        'txtMaPhieu
        '
        Me.txtMaPhieu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaPhieu.Location = New System.Drawing.Point(222, 36)
        Me.txtMaPhieu.Name = "txtMaPhieu"
        Me.txtMaPhieu.ReadOnly = True
        Me.txtMaPhieu.Size = New System.Drawing.Size(179, 23)
        Me.txtMaPhieu.TabIndex = 51
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(893, 37)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(98, 44)
        Me.btthoat.TabIndex = 49
        Me.btthoat.Text = "Trở Về"
        Me.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthoat.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tình Trạng Mượn Trả :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(446, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Ngày Trả :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(443, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ngày Hẹn Trả :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ngày Mượn :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(443, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tên Sách :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(446, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mã Sách :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Độc Giả :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Độc Giả :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(812, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 67)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Trả Sách"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PhieuTraSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1118, 682)
        Me.Controls.Add(Me.dgvChiTietPhieuMuon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PhieuTraSachGUI"
        Me.Text = "PhieuTraSach"
        CType(Me.dgvChiTietPhieuMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TinhTrangPhieuMuon As DataGridViewTextBoxColumn
    Friend WithEvents dtpNgayHenTra As DateTimePicker
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents NgayHenTra As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuon As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents TenDG As DataGridViewTextBoxColumn
    Friend WithEvents MaDG As DataGridViewTextBoxColumn
    Friend WithEvents MaPhieu As DataGridViewTextBoxColumn
    Friend WithEvents dgvChiTietPhieuMuon As DataGridView
    Friend WithEvents NgayTra As DataGridViewTextBoxColumn
    Friend WithEvents dtpNgayTra As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTinhTrangPhieuMuon As TextBox
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents txtTenDocGia As TextBox
    Friend WithEvents txtMaDG As TextBox
    Friend WithEvents txtMaPhieu As TextBox
    Friend WithEvents btthoat As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
