<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChiTiet
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
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.Them = New System.Windows.Forms.Button()
        Me.BtnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(83, 31)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(213, 20)
        Me.txtMaHD.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtThanhTien)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDonGia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTenSach)
        Me.GroupBox1.Controls.Add(Me.txtMaSach)
        Me.GroupBox1.Controls.Add(Me.txtMaHD)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 129)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hóa Đơn Bán Hàng"
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Enabled = False
        Me.txtThanhTien.Location = New System.Drawing.Point(379, 88)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(213, 20)
        Me.txtThanhTien.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Thành Tiền :"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(379, 60)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(213, 20)
        Me.txtDonGia.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Đơn Giá :"
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(378, 31)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(213, 20)
        Me.txtSL.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Số Lượng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tên Sách :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã Sách :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã Hóa Đơn :"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(83, 95)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(213, 20)
        Me.txtTenSach.TabIndex = 2
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(83, 62)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(213, 20)
        Me.txtMaSach.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(647, 131)
        Me.DataGridView1.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSua)
        Me.GroupBox2.Controls.Add(Me.BtnXoa)
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.BtnThoat)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 83)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.LONGTBPS00846.My.Resources.Resources.a11
        Me.BtnSua.Location = New System.Drawing.Point(85, 22)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(54, 49)
        Me.BtnSua.TabIndex = 8
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.LONGTBPS00846.My.Resources.Resources.a2
        Me.BtnXoa.Location = New System.Drawing.Point(145, 22)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(54, 49)
        Me.BtnXoa.TabIndex = 7
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'Them
        '
        Me.Them.Image = Global.LONGTBPS00846.My.Resources.Resources.a1
        Me.Them.Location = New System.Drawing.Point(25, 22)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(54, 49)
        Me.Them.TabIndex = 6
        Me.Them.UseVisualStyleBackColor = True
        '
        'BtnThoat
        '
        Me.BtnThoat.Image = Global.LONGTBPS00846.My.Resources.Resources.a3
        Me.BtnThoat.Location = New System.Drawing.Point(205, 18)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(75, 53)
        Me.BtnThoat.TabIndex = 9
        Me.BtnThoat.UseVisualStyleBackColor = True
        '
        'FrmChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(659, 375)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmChiTiet"
        Me.Text = "FrmChiTiet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtThanhTien As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnThoat As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenSach As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSach As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
