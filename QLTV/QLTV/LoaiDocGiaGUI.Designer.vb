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
        CType(Me.dgvDanhSachTLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(316, 302)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 37
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(196, 302)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 36
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(196, 198)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(133, 20)
        Me.txtMaLoai.TabIndex = 35
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Mã Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(196, 245)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(222, 20)
        Me.txtTenLoai.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tên Loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Danh sách Loại Đọc giả:"
        '
        'dgvDanhSachTLS
        '
        Me.dgvDanhSachTLS.AllowUserToAddRows = False
        Me.dgvDanhSachTLS.AllowUserToDeleteRows = False
        Me.dgvDanhSachTLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTLS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTLS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLDG, Me.TenLDG})
        Me.dgvDanhSachTLS.Location = New System.Drawing.Point(81, 23)
        Me.dgvDanhSachTLS.MultiSelect = False
        Me.dgvDanhSachTLS.Name = "dgvDanhSachTLS"
        Me.dgvDanhSachTLS.ReadOnly = True
        Me.dgvDanhSachTLS.RowHeadersVisible = False
        Me.dgvDanhSachTLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTLS.Size = New System.Drawing.Size(386, 150)
        Me.dgvDanhSachTLS.TabIndex = 30
        '
        'MaLDG
        '
        Me.MaLDG.DataPropertyName = "MaLDG"
        Me.MaLDG.HeaderText = "Mã Loại Đọc Giả"
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
        Me.btnThem.Location = New System.Drawing.Point(104, 302)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 36
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'LoaiDocGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 334)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachTLS)
        Me.Name = "LoaiDocGiaGUI"
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
    Friend WithEvents MaLDG As DataGridViewTextBoxColumn
    Friend WithEvents TenLDG As DataGridViewTextBoxColumn
    Friend WithEvents btnThem As Button
End Class
