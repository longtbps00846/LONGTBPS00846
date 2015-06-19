Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim chuoiketnoi As String = "workstation id=longtbps00846.mssql.somee.com;packet size=4096;user id=longtbps00846_SQLLogin_5;pwd=tqmb7ap9ev;data source=longtbps00846.mssql.somee.com;persist security info=False;initial catalog=longtbps00846"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNhanVien='" & TextBox1.Text & "' and MatKhau='" & TextBox2.Text & "' ", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công !!!")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng")
            End If
        Catch ex As Exception
        End Try
    End Sub
    'chỉnh sửa bởi tài khoản 2 LONGTBPS00846@GMAIL.COM
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class
