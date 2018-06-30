<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheLoaiSachGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheLoaiSachGUI))
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTLS = New System.Windows.Forms.DataGridView()
        Me.MaTLS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTLS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDanhSachTLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(239, 265)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(176, 22)
        Me.txtMaLoai.TabIndex = 43
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Mã Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(239, 309)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(295, 22)
        Me.txtTenLoai.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(87, 311)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Tên Loại:"
        '
        'dgvDanhSachTLS
        '
        Me.dgvDanhSachTLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTLS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTLS, Me.TenTLS})
        Me.dgvDanhSachTLS.Location = New System.Drawing.Point(34, 60)
        Me.dgvDanhSachTLS.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDanhSachTLS.Name = "dgvDanhSachTLS"
        Me.dgvDanhSachTLS.ReadOnly = True
        Me.dgvDanhSachTLS.Size = New System.Drawing.Size(533, 185)
        Me.dgvDanhSachTLS.TabIndex = 38
        '
        'MaTLS
        '
        Me.MaTLS.DataPropertyName = "MaTLS"
        Me.MaTLS.HeaderText = "Mã Thể Loại Sách"
        Me.MaTLS.Name = "MaTLS"
        Me.MaTLS.ReadOnly = True
        '
        'TenTLS
        '
        Me.TenTLS.DataPropertyName = "TenTLS"
        Me.TenTLS.HeaderText = "Tên Thể Loại Sách"
        Me.TenTLS.Name = "TenTLS"
        Me.TenTLS.ReadOnly = True
        '
        'btxoa
        '
        Me.btxoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btxoa.BackgroundImage = CType(resources.GetObject("btxoa.BackgroundImage"), System.Drawing.Image)
        Me.btxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btxoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Location = New System.Drawing.Point(328, 375)
        Me.btxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(146, 57)
        Me.btxoa.TabIndex = 105
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.UseVisualStyleBackColor = False
        '
        'btsua
        '
        Me.btsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btsua.BackgroundImage = CType(resources.GetObject("btsua.BackgroundImage"), System.Drawing.Image)
        Me.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btsua.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsua.ForeColor = System.Drawing.Color.Black
        Me.btsua.Location = New System.Drawing.Point(174, 373)
        Me.btsua.Margin = New System.Windows.Forms.Padding(4)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(146, 59)
        Me.btsua.TabIndex = 104
        Me.btsua.Text = "Cập Nhật"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.UseVisualStyleBackColor = False
        '
        'btthoat
        '
        Me.btthoat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btthoat.BackgroundImage = CType(resources.GetObject("btthoat.BackgroundImage"), System.Drawing.Image)
        Me.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btthoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.Black
        Me.btthoat.Location = New System.Drawing.Point(482, 376)
        Me.btthoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(146, 56)
        Me.btthoat.TabIndex = 103
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
        Me.btthem.Location = New System.Drawing.Point(20, 373)
        Me.btthem.Margin = New System.Windows.Forms.Padding(4)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(146, 59)
        Me.btthem.TabIndex = 102
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 347)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh Sách Loại Sách"
        '
        'TheLoaiSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(650, 455)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btsua)
        Me.Controls.Add(Me.btthoat)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachTLS)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TheLoaiSachGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TheLoaiSachGUI"
        CType(Me.dgvDanhSachTLS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDanhSachTLS As DataGridView
    Friend WithEvents MaTLS As DataGridViewTextBoxColumn
    Friend WithEvents TenTLS As DataGridViewTextBoxColumn
    Friend WithEvents btxoa As Button
    Friend WithEvents btsua As Button
    Friend WithEvents btthoat As Button
    Friend WithEvents btthem As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
