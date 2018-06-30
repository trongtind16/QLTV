<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemDocGiaGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThemDocGiaGUI))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpNgayHetHan = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
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
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgayHetHan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
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
        Me.GroupBox1.Size = New System.Drawing.Size(935, 295)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Độc Giả"
        '
        'dtpNgayHetHan
        '
        Me.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayHetHan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayHetHan.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpNgayHetHan.Location = New System.Drawing.Point(637, 201)
        Me.dtpNgayHetHan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayHetHan.Name = "dtpNgayHetHan"
        Me.dtpNgayHetHan.Size = New System.Drawing.Size(275, 27)
        Me.dtpNgayHetHan.TabIndex = 96
        Me.dtpNgayHetHan.Value = New Date(2018, 11, 25, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(489, 208)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Ngày Hết Hạn  :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(275, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.Items.AddRange(New Object() {"NAM", "NỮ", "KHÁC"})
        Me.cbGioiTinh.Location = New System.Drawing.Point(637, 104)
        Me.cbGioiTinh.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(275, 28)
        Me.cbGioiTinh.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(489, 113)
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
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(637, 153)
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
        Me.Label8.Location = New System.Drawing.Point(489, 160)
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
        Me.Label3.Location = New System.Drawing.Point(52, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mã Độc Giả :"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(183, 201)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(275, 27)
        Me.txtDiaChi.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(183, 251)
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
        Me.dtpNgaySinh.Location = New System.Drawing.Point(183, 154)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(275, 26)
        Me.dtpNgaySinh.TabIndex = 34
        Me.dtpNgaySinh.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'txtTenDG
        '
        Me.txtTenDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenDG.Location = New System.Drawing.Point(183, 105)
        Me.txtTenDG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenDG.Name = "txtTenDG"
        Me.txtTenDG.Size = New System.Drawing.Size(275, 27)
        Me.txtTenDG.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(52, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Địa Chỉ :"
        '
        'txtMaDG
        '
        Me.txtMaDG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaDG.Location = New System.Drawing.Point(183, 53)
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
        Me.Label5.Location = New System.Drawing.Point(52, 258)
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
        Me.Label6.Location = New System.Drawing.Point(52, 113)
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
        Me.cbLoaiDG.Location = New System.Drawing.Point(637, 53)
        Me.cbLoaiDG.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiDG.Name = "cbLoaiDG"
        Me.cbLoaiDG.Size = New System.Drawing.Size(275, 28)
        Me.cbLoaiDG.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(52, 160)
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
        Me.Label1.Location = New System.Drawing.Point(489, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Loại Độc Giả :"
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhap.BackgroundImage = CType(resources.GetObject("btnNhap.BackgroundImage"), System.Drawing.Image)
        Me.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnNhap.ForeColor = System.Drawing.Color.Black
        Me.btnNhap.Location = New System.Drawing.Point(348, 318)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(136, 59)
        Me.btnNhap.TabIndex = 58
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(559, 318)
        Me.btthoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(136, 59)
        Me.btthoat.TabIndex = 104
        Me.btthoat.Text = "Trở Về"
        Me.btthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthoat.UseVisualStyleBackColor = False
        '
        'ThemDocGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(971, 393)
        Me.Controls.Add(Me.btthoat)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ThemDocGiaGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThemDocGiaGUI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpNgayHetHan As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbGioiTinh As ComboBox
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
    Friend WithEvents btnNhap As Button
    Friend WithEvents btthoat As Button
End Class
