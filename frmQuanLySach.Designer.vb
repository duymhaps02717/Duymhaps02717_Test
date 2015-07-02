<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySach
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grbTen = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtNgayXuatBan = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.NgayXuatBan = New System.Windows.Forms.Label()
        Me.TenSach = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.DonGia = New System.Windows.Forms.Label()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(210, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 29)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "QUẢN LÝ SÁCH"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(265, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(478, 382)
        Me.DataGridView1.TabIndex = 13
        '
        'grbTen
        '
        Me.grbTen.Controls.Add(Me.txtMaLoai)
        Me.grbTen.Controls.Add(Me.Label2)
        Me.grbTen.Controls.Add(Me.txtDonGia)
        Me.grbTen.Controls.Add(Me.DonGia)
        Me.grbTen.Controls.Add(Me.btnClear)
        Me.grbTen.Controls.Add(Me.btnSua)
        Me.grbTen.Controls.Add(Me.btnXoa)
        Me.grbTen.Controls.Add(Me.btnThem)
        Me.grbTen.Controls.Add(Me.txtNgayXuatBan)
        Me.grbTen.Controls.Add(Me.txtTenSach)
        Me.grbTen.Controls.Add(Me.txtMaSach)
        Me.grbTen.Controls.Add(Me.NgayXuatBan)
        Me.grbTen.Controls.Add(Me.TenSach)
        Me.grbTen.Controls.Add(Me.Label1)
        Me.grbTen.Location = New System.Drawing.Point(17, 68)
        Me.grbTen.Name = "grbTen"
        Me.grbTen.Size = New System.Drawing.Size(228, 382)
        Me.grbTen.TabIndex = 12
        Me.grbTen.TabStop = False
        Me.grbTen.Text = "Nhập thông tin sách"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(142, 334)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(15, 334)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 37)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(142, 279)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 37)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(15, 279)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 37)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtNgayXuatBan
        '
        Me.txtNgayXuatBan.Location = New System.Drawing.Point(78, 126)
        Me.txtNgayXuatBan.Name = "txtNgayXuatBan"
        Me.txtNgayXuatBan.Size = New System.Drawing.Size(139, 20)
        Me.txtNgayXuatBan.TabIndex = 5
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(78, 78)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(139, 20)
        Me.txtTenSach.TabIndex = 4
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(78, 33)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(139, 20)
        Me.txtMaSach.TabIndex = 3
        '
        'NgayXuatBan
        '
        Me.NgayXuatBan.Location = New System.Drawing.Point(7, 116)
        Me.NgayXuatBan.Name = "NgayXuatBan"
        Me.NgayXuatBan.Size = New System.Drawing.Size(60, 38)
        Me.NgayXuatBan.TabIndex = 2
        Me.NgayXuatBan.Text = "NgayXuatBan"
        Me.NgayXuatBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TenSach
        '
        Me.TenSach.AutoSize = True
        Me.TenSach.Location = New System.Drawing.Point(7, 81)
        Me.TenSach.Name = "TenSach"
        Me.TenSach.Size = New System.Drawing.Size(51, 13)
        Me.TenSach.TabIndex = 1
        Me.TenSach.Text = "TenSach"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MaSach"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(78, 181)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(139, 20)
        Me.txtDonGia.TabIndex = 11
        '
        'DonGia
        '
        Me.DonGia.AutoSize = True
        Me.DonGia.Location = New System.Drawing.Point(12, 188)
        Me.DonGia.Name = "DonGia"
        Me.DonGia.Size = New System.Drawing.Size(43, 13)
        Me.DonGia.TabIndex = 10
        Me.DonGia.Text = "DonGia"
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(78, 231)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(139, 20)
        Me.txtMaLoai.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "MaLoai"
        '
        'frmQuanLySach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 462)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grbTen)
        Me.Name = "frmQuanLySach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Sách"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTen.ResumeLayout(False)
        Me.grbTen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grbTen As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtNgayXuatBan As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSach As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSach As System.Windows.Forms.TextBox
    Friend WithEvents NgayXuatBan As System.Windows.Forms.Label
    Friend WithEvents TenSach As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents DonGia As System.Windows.Forms.Label
    Friend WithEvents txtMaLoai As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
