<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemSachGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThemSachGUI))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.txtNamXuatBan = New System.Windows.Forms.TextBox()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.txtNhaXuatBan = New System.Windows.Forms.TextBox()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.txtTriGia = New System.Windows.Forms.TextBox()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNhap.BackgroundImage = CType(resources.GetObject("btnNhap.BackgroundImage"), System.Drawing.Image)
        Me.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNhap.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnNhap.ForeColor = System.Drawing.Color.Black
        Me.btnNhap.Location = New System.Drawing.Point(301, 283)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(89, 40)
        Me.btnNhap.TabIndex = 39
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnThoat.BackgroundImage = CType(resources.GetObject("btnThoat.BackgroundImage"), System.Drawing.Image)
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Location = New System.Drawing.Point(424, 285)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(89, 40)
        Me.btnThoat.TabIndex = 40
        Me.btnThoat.Text = "Trở Về"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'txtNamXuatBan
        '
        Me.txtNamXuatBan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamXuatBan.Location = New System.Drawing.Point(104, 227)
        Me.txtNamXuatBan.Name = "txtNamXuatBan"
        Me.txtNamXuatBan.Size = New System.Drawing.Size(150, 23)
        Me.txtNamXuatBan.TabIndex = 47
        '
        'cbTheLoai
        '
        Me.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTheLoai.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(419, 21)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(141, 23)
        Me.cbTheLoai.TabIndex = 44
        '
        'txtNhaXuatBan
        '
        Me.txtNhaXuatBan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNhaXuatBan.Location = New System.Drawing.Point(104, 170)
        Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
        Me.txtNhaXuatBan.Size = New System.Drawing.Size(150, 23)
        Me.txtNhaXuatBan.TabIndex = 43
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTinhTrang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(419, 121)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(141, 23)
        Me.cbTinhTrang.TabIndex = 42
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayNhap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayNhap.Location = New System.Drawing.Point(419, 167)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(141, 23)
        Me.dtpNgayNhap.TabIndex = 41
        Me.dtpNgayNhap.Value = New Date(2018, 5, 19, 0, 0, 0, 0)
        '
        'txtTriGia
        '
        Me.txtTriGia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriGia.Location = New System.Drawing.Point(419, 71)
        Me.txtTriGia.Name = "txtTriGia"
        Me.txtTriGia.Size = New System.Drawing.Size(141, 23)
        Me.txtTriGia.TabIndex = 39
        '
        'txtTacGia
        '
        Me.txtTacGia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTacGia.Location = New System.Drawing.Point(104, 121)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(150, 23)
        Me.txtTacGia.TabIndex = 38
        '
        'txtTenSach
        '
        Me.txtTenSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenSach.Location = New System.Drawing.Point(104, 71)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(150, 23)
        Me.txtTenSach.TabIndex = 36
        '
        'txtMaSach
        '
        Me.txtMaSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSach.Location = New System.Drawing.Point(104, 21)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(150, 23)
        Me.txtMaSach.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(329, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Tình Trạng :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Trị Giá :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(329, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Ngày Nhập :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Năm Xuất Bản :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nhà Xuất Bản :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tác Giả :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Thể Loại :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tên Sách :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Mã Sách :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtNamXuatBan)
        Me.Panel2.Controls.Add(Me.cbTheLoai)
        Me.Panel2.Controls.Add(Me.txtNhaXuatBan)
        Me.Panel2.Controls.Add(Me.cbTinhTrang)
        Me.Panel2.Controls.Add(Me.dtpNgayNhap)
        Me.Panel2.Controls.Add(Me.txtTriGia)
        Me.Panel2.Controls.Add(Me.txtTacGia)
        Me.Panel2.Controls.Add(Me.txtTenSach)
        Me.Panel2.Controls.Add(Me.txtMaSach)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(579, 265)
        Me.Panel2.TabIndex = 42
        '
        'ThemSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(618, 339)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ThemSachGUI"
        Me.Text = "ThemSachGUI"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnNhap As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents txtNamXuatBan As TextBox
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents txtNhaXuatBan As TextBox
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents txtTriGia As TextBox
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
End Class
