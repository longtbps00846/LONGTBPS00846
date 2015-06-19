<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaLS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtNXB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Them = New System.Windows.Forms.Button()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.BtnTim = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã Sách :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtMaLS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtGia)
        Me.GroupBox1.Controls.Add(Me.txtNXB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTacGia)
        Me.GroupBox1.Controls.Add(Me.txtTenSach)
        Me.GroupBox1.Controls.Add(Me.txtMaSach)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 189)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Khách Hàng"
        '
        'txtMaLS
        '
        Me.txtMaLS.Location = New System.Drawing.Point(429, 62)
        Me.txtMaLS.Name = "txtMaLS"
        Me.txtMaLS.Size = New System.Drawing.Size(162, 20)
        Me.txtMaLS.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mã Loại Sách :"
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(429, 35)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(162, 20)
        Me.txtGia.TabIndex = 13
        '
        'txtNXB
        '
        Me.txtNXB.Location = New System.Drawing.Point(108, 126)
        Me.txtNXB.Name = "txtNXB"
        Me.txtNXB.Size = New System.Drawing.Size(213, 20)
        Me.txtNXB.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Giá :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nhà Xuất Bản :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tác Giả :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tên Sách :"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(108, 95)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(213, 20)
        Me.txtTacGia.TabIndex = 2
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(108, 62)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(213, 20)
        Me.txtTenSach.TabIndex = 1
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(108, 31)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(213, 20)
        Me.txtMaSach.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 199)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(611, 172)
        Me.DataGridView1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.BtnSua)
        Me.GroupBox2.Controls.Add(Me.BtnXoa)
        Me.GroupBox2.Controls.Add(Me.BtnTim)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 78)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'Them
        '
        Me.Them.Image = Global.LONGTBPS00846.My.Resources.Resources.a1
        Me.Them.Location = New System.Drawing.Point(6, 19)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(54, 49)
        Me.Them.TabIndex = 6
        Me.Them.UseVisualStyleBackColor = True
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.LONGTBPS00846.My.Resources.Resources.a11
        Me.BtnSua.Location = New System.Drawing.Point(66, 19)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(54, 49)
        Me.BtnSua.TabIndex = 8
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.LONGTBPS00846.My.Resources.Resources.a2
        Me.BtnXoa.Location = New System.Drawing.Point(126, 19)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(54, 49)
        Me.BtnXoa.TabIndex = 7
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'BtnTim
        '
        Me.BtnTim.Image = Global.LONGTBPS00846.My.Resources.Resources.a3
        Me.BtnTim.Location = New System.Drawing.Point(186, 15)
        Me.BtnTim.Name = "BtnTim"
        Me.BtnTim.Size = New System.Drawing.Size(75, 53)
        Me.BtnTim.TabIndex = 9
        Me.BtnTim.UseVisualStyleBackColor = True
        '
        'FrmSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmSach"
        Me.Text = "FrmSach"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtNXB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnTim As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTacGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSach As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSach As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaLS As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
