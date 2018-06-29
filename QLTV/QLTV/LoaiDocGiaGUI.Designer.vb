<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoaiDocGiaGUI
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
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTLS = New System.Windows.Forms.DataGridView()
        Me.MaLDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachTLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Cyan
        Me.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnXoa.FlatAppearance.BorderSize = 3
        Me.btnXoa.Location = New System.Drawing.Point(433, 366)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(123, 34)
        Me.btnXoa.TabIndex = 37
        Me.btnXoa.TabStop = False
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.Cyan
        Me.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCapNhat.FlatAppearance.BorderSize = 3
        Me.btnCapNhat.Location = New System.Drawing.Point(284, 366)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(123, 34)
        Me.btnCapNhat.TabIndex = 36
        Me.btnCapNhat.TabStop = False
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = False
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(261, 244)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(176, 22)
        Me.txtMaLoai.TabIndex = 35
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(152, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Mã Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(261, 302)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(295, 22)
        Me.txtTenLoai.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(152, 310)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tên Loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(104, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Danh sách Loại Độc giả:"
        '
        'dgvDanhSachTLS
        '
        Me.dgvDanhSachTLS.AllowUserToAddRows = False
        Me.dgvDanhSachTLS.AllowUserToDeleteRows = False
        Me.dgvDanhSachTLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTLS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTLS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLDG, Me.TenLDG})
        Me.dgvDanhSachTLS.Location = New System.Drawing.Point(108, 28)
        Me.dgvDanhSachTLS.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDanhSachTLS.MultiSelect = False
        Me.dgvDanhSachTLS.Name = "dgvDanhSachTLS"
        Me.dgvDanhSachTLS.ReadOnly = True
        Me.dgvDanhSachTLS.RowHeadersVisible = False
        Me.dgvDanhSachTLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTLS.Size = New System.Drawing.Size(515, 185)
        Me.dgvDanhSachTLS.TabIndex = 30
        '
        'MaLDG
        '
        Me.MaLDG.DataPropertyName = "MaLDG"
        Me.MaLDG.HeaderText = "Mã Loại Độc Giả"
        Me.MaLDG.Name = "MaLDG"
        Me.MaLDG.ReadOnly = True
        '
        'TenLDG
        '
        Me.TenLDG.DataPropertyName = "TenLDG"
        Me.TenLDG.HeaderText = "Tên LDG"
        Me.TenLDG.Name = "TenLDG"
        Me.TenLDG.ReadOnly = True
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Cyan
        Me.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnThem.FlatAppearance.BorderSize = 3
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.Location = New System.Drawing.Point(136, 366)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(123, 34)
        Me.btnThem.TabIndex = 36
        Me.btnThem.TabStop = False
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Cyan
        Me.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnThoat.FlatAppearance.BorderSize = 3
        Me.btnThoat.Location = New System.Drawing.Point(581, 366)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(123, 34)
        Me.btnThoat.TabIndex = 38
        Me.btnThoat.TabStop = False
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'LoaiDocGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(733, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachTLS)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LoaiDocGiaGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoaiDocGiaGUI"
        CType(Me.dgvDanhSachTLS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachTLS As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents MaLDG As DataGridViewTextBoxColumn
    Friend WithEvents TenLDG As DataGridViewTextBoxColumn
    Friend WithEvents btnThoat As Button
End Class
