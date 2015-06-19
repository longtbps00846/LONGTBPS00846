<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHoaDon
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
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNgayLap = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Them = New System.Windows.Forms.Button()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.BtnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMaKH)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNgayLap)
        Me.GroupBox1.Controls.Add(Me.txtGia)
        Me.GroupBox1.Controls.Add(Me.txtMaHD)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 127)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hóa Đơn Bán Hàng"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(414, 60)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(213, 20)
        Me.txtMaNV.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Mã Nhân Viên :"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(414, 29)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(213, 20)
        Me.txtMaKH.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mã Khách Hàng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ngày Lập :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Giá :"
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
        'txtNgayLap
        '
        Me.txtNgayLap.Location = New System.Drawing.Point(82, 95)
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.Size = New System.Drawing.Size(213, 20)
        Me.txtNgayLap.TabIndex = 2
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(82, 62)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(213, 20)
        Me.txtGia.TabIndex = 1
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(82, 31)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(213, 20)
        Me.txtMaHD.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 127)
        Me.DataGridView1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Them)
        Me.GroupBox2.Controls.Add(Me.BtnSua)
        Me.GroupBox2.Controls.Add(Me.BtnXoa)
        Me.GroupBox2.Controls.Add(Me.BtnThoat)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 74)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'Them
        '
        Me.Them.Image = Global.LONGTBPS00846.My.Resources.Resources.a1
        Me.Them.Location = New System.Drawing.Point(22, 19)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(54, 49)
        Me.Them.TabIndex = 6
        Me.Them.UseVisualStyleBackColor = True
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.LONGTBPS00846.My.Resources.Resources.a11
        Me.BtnSua.Location = New System.Drawing.Point(82, 19)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(54, 49)
        Me.BtnSua.TabIndex = 8
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.LONGTBPS00846.My.Resources.Resources.a2
        Me.BtnXoa.Location = New System.Drawing.Point(142, 19)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(54, 49)
        Me.BtnXoa.TabIndex = 7
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'BtnThoat
        '
        Me.BtnThoat.Image = Global.LONGTBPS00846.My.Resources.Resources.a3
        Me.BtnThoat.Location = New System.Drawing.Point(201, 15)
        Me.BtnThoat.Name = "BtnThoat"
        Me.BtnThoat.Size = New System.Drawing.Size(75, 53)
        Me.BtnThoat.TabIndex = 9
        Me.BtnThoat.UseVisualStyleBackColor = True
        '
        'FrmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(657, 351)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmHoaDon"
        Me.Text = "FrmHoaDon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnThoat As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents Them As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtNgayLap As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
