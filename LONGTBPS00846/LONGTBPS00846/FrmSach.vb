Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmSach
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiketnoi As String = "workstation id=longtbps00846.mssql.somee.com;packet size=4096;user id=longtbps00846_SQLLogin_5;pwd=tqmb7ap9ev;data source=longtbps00846.mssql.somee.com;persist security info=False;initial catalog=longtbps00846"

    Private Sub FrmSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Sach", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaSach.Text = DataGridView1.Item(0, index).Value
        txtTenSach.Text = DataGridView1.Item(1, index).Value
        txtTacGia.Text = DataGridView1.Item(2, index).Value
        txtNXB.Text = DataGridView1.Item(3, index).Value
        txtGia.Text = DataGridView1.Item(4, index).Value
        txtMaLS.Text = DataGridView1.Item(5, index).Value
    End Sub

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into Sach values (@MaSach,@TenSach,@TacGia,@NhaXuatBan,@Gia,@MaLoaiSach)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaSach", txtMaSach.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenSach", txtTenSach.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TacGia", txtTacGia.Text)
            ExecuteQuery1.Parameters.AddWithValue("@NhaXuatBan", txtNXB.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Gia", txtGia.Text)
            ExecuteQuery1.Parameters.AddWithValue("@MaLoaiSach", txtMaLS.Text)
            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Sach", connect)
        database.Clear()

        Query3.Fill(database)
        DataGridView1.DataSource = database.DefaultView

    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim Stradd As String = "Update Sach set TenSach = @TenSach, MaSach = @MaSach, TacGia = @TacGia, NhaXuatBan = @NhaXuatBan, Gia = @Gia, MaLoaiSach = @MaLoaiSach where MaSach = @MaSach"
        Dim com As New SqlCommand(Stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSach", txtMaSach.Text)
            com.Parameters.AddWithValue("@TenSach", txtTenSach.Text)
            com.Parameters.AddWithValue("@TacGia", txtTacGia.Text)
            com.Parameters.AddWithValue("@NhaXuatBan", txtNXB.Text)
            com.Parameters.AddWithValue("@Gia", txtGia.Text)
            com.Parameters.AddWithValue("@MaLoaiSach", txtMaLS.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Sửa Không Thành Công")
        End Try
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing
        Loaddata()
    End Sub
    Private Sub Loaddata()
        Dim ketnoi1 As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Sach", ketnoi1)
        ketnoi1.Open()
        Query1.Fill(database)
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim xoadl As String = "Delete from Sach Where MaSach = @MaSach"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaSach", txtMaSach.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub BtnTim_Click(sender As Object, e As EventArgs) Handles BtnTim.Click
        Me.Hide()
    End Sub
End Class