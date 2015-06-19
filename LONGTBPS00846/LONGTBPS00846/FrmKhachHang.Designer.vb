<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKhachHang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSDT)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNgaySinh)
        Me.GroupBox1.Controls.Add(Me.txtTenKH)
        Me.GroupBox1.Controls.Add(Me.txtMaKH)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 194)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Khách Hàng"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(108, 163)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(213, 20)
        Me.txtSDT.TabIndex = 13
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(108, 130)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(213, 20)
        Me.txtDiaChi.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Số Điện Thoại :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Địa Chỉ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ngày Sinh :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tên Khách Hàng :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã Khách Hàng :"
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(108, 99)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(213, 20)
        Me.txtNgaySinh.TabIndex = 2
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(108, 62)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(213, 20)
        Me.txtTenKH.TabIndex = 1
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(108, 31)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(213, 20)
        Me.txtMaKH.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(632, 163)
        Me.DataGridView1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.BtnSua)
        Me.GroupBox2.Controls.Add(Me.BtnXoa)
        Me.GroupBox2.Controls.Add(Me.BtnTim)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 79)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'Them
        '
        Me.Them.Image = Global.LONGTBPS00846.My.Resources.Resources.a1
        Me.Them.Location = New System.Drawing.Point(15, 19)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(54, 49)
        Me.Them.TabIndex = 6
        Me.Them.UseVisualStyleBackColor = True
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.LONGTBPS00846.My.Resources.Resources.a11
        Me.BtnSua.Location = New System.Drawing.Point(75, 19)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(54, 49)
        Me.BtnSua.TabIndex = 8
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.LONGTBPS00846.My.Resources.Resources.a2
        Me.BtnXoa.Location = New System.Drawing.Point(135, 19)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(54, 49)
        Me.BtnXoa.TabIndex = 7
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'BtnTim
        '
        Me.BtnTim.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnTim.Image = Global.LONGTBPS00846.My.Resources.Resources.a3
        Me.BtnTim.Location = New System.Drawing.Point(195, 15)
        Me.BtnTim.Name = "BtnTim"
        Me.BtnTim.Size = New System.Drawing.Size(75, 53)
        Me.BtnTim.TabIndex = 9
        Me.BtnTim.UseVisualStyleBackColor = False
        '
        'FrmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(647, 379)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmKhachHang"
        Me.Text = "FrmKhachHang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTim As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtNgaySinh As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
