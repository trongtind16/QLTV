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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TinhTrangSachGUI))
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTTS = New System.Windows.Forms.DataGridView()
        Me.MaTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDanhSachTTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(194, 278)
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
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(84, 280)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Mã Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(194, 336)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(295, 22)
        Me.txtTenLoai.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 338)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tên Loại:"
        '
        'dgvDanhSachTTS
        '
        Me.dgvDanhSachTTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTTS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTTS, Me.TenTTS})
        Me.dgvDanhSachTTS.Location = New System.Drawing.Point(40, 63)
        Me.dgvDanhSachTTS.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDanhSachTTS.Name = "dgvDanhSachTTS"
        Me.dgvDanhSachTTS.ReadOnly = True
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(349, 391)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 57)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Trở Về"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btsua
        '
        Me.btsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btsua.BackgroundImage = CType(resources.GetObject("btsua.BackgroundImage"), System.Drawing.Image)
        Me.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btsua.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsua.ForeColor = System.Drawing.Color.Black
        Me.btsua.Location = New System.Drawing.Point(114, 391)
        Me.btsua.Margin = New System.Windows.Forms.Padding(4)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(140, 59)
        Me.btsua.TabIndex = 105
        Me.btsua.Text = "Cập Nhật"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 371)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh Sách Tình Trạng Sách"
        '
        'TinhTrangSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(593, 465)
        Me.Controls.Add(Me.btsua)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachTTS)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TinhTrangSachGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TinhTrangSachGUI"
        CType(Me.dgvDanhSachTTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDanhSachTTS As DataGridView
    Friend WithEvents MaTTS As DataGridViewTextBoxColumn
    Friend WithEvents TenTTS As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btsua As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
