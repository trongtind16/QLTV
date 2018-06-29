<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TinhTrangSachGUI
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
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTTS = New System.Windows.Forms.DataGridView()
        Me.MaTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDanhSachTTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(347, 380)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(100, 28)
        Me.btnThoat.TabIndex = 55
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(187, 380)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(100, 28)
        Me.btnCapNhat.TabIndex = 53
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(187, 252)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(176, 22)
        Me.txtMaLoai.TabIndex = 52
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Mã Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(187, 310)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(295, 22)
        Me.txtTenLoai.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 319)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tên Loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Danh sách Loại Độc giả:"
        '
        'dgvDanhSachTTS
        '
        Me.dgvDanhSachTTS.AllowUserToAddRows = False
        Me.dgvDanhSachTTS.AllowUserToDeleteRows = False
        Me.dgvDanhSachTTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTTS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTTS, Me.TenTTS})
        Me.dgvDanhSachTTS.Location = New System.Drawing.Point(33, 37)
        Me.dgvDanhSachTTS.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDanhSachTTS.MultiSelect = False
        Me.dgvDanhSachTTS.Name = "dgvDanhSachTTS"
        Me.dgvDanhSachTTS.ReadOnly = True
        Me.dgvDanhSachTTS.RowHeadersVisible = False
        Me.dgvDanhSachTTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTTS.Size = New System.Drawing.Size(515, 185)
        Me.dgvDanhSachTTS.TabIndex = 47
        '
        'MaTTS
        '
        Me.MaTTS.DataPropertyName = "MaTTS"
        Me.MaTTS.HeaderText = "Mã Tình Trạng Sách"
        Me.MaTTS.Name = "MaTTS"
        Me.MaTTS.ReadOnly = True
        '
        'TenTTS
        '
        Me.TenTTS.DataPropertyName = "TenTTS"
        Me.TenTTS.HeaderText = "Tên Tình Trạng Sách"
        Me.TenTTS.Name = "TenTTS"
        Me.TenTTS.ReadOnly = True
        '
        'TinhTrangSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 443)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachTTS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "TinhTrangSachGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TinhTrangSachGUI"
        CType(Me.dgvDanhSachTTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThoat As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachTTS As DataGridView
    Friend WithEvents MaTTS As DataGridViewTextBoxColumn
    Friend WithEvents TenTTS As DataGridViewTextBoxColumn
End Class
