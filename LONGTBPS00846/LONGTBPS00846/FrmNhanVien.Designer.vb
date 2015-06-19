<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNhanVien
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Them = New System.Windows.Forms.Button()
        Me.BtnTim = New System.Windows.Forms.Button()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTenNV)
        Me.GroupBox1.Controls.Add(Me.txtMK)
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập Thông Tin Thành Viên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tên Nhân Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mật Khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã Nhân Viên"
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(88, 103)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(145, 20)
        Me.txtTenNV.TabIndex = 2
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(88, 66)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.Size = New System.Drawing.Size(145, 20)
        Me.txtMK.TabIndex = 1
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(88, 28)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(145, 20)
        Me.txtMaNV.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 165)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.BtnTim)
        Me.GroupBox2.Controls.Add(Me.BtnSua)
        Me.GroupBox2.Controls.Add(Me.BtnXoa)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 76)
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
        'BtnTim
        '
        Me.BtnTim.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnTim.Image = Global.LONGTBPS00846.My.Resources.Resources.a3
        Me.BtnTim.Location = New System.Drawing.Point(186, 15)
        Me.BtnTim.Name = "BtnTim"
        Me.BtnTim.Size = New System.Drawing.Size(75, 53)
        Me.BtnTim.TabIndex = 9
        Me.BtnTim.UseVisualStyleBackColor = False
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
        'FrmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 323)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmNhanVien"
        Me.Text = "Nhân Viên"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMK As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnTim As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
