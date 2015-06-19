Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmHoaDon
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiketnoi As String = "workstation id=longtbps00846.mssql.somee.com;packet size=4096;user id=longtbps00846_SQLLogin_5;pwd=tqmb7ap9ev;data source=longtbps00846.mssql.somee.com;persist security info=False;initial catalog=longtbps00846"
    Private Sub FrmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaHD.Text = DataGridView1.Item(0, index).Value
        txtGia.Text = DataGridView1.Item(1, index).Value
        txtNgayLap.Text = DataGridView1.Item(2, index).Value
        txtMaKH.Text = DataGridView1.Item(3, index).Value
        txtMaNV.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into HoaDon values (@MaHoaDon,@Gia,@Ngay,@MaKhachHang,@MaNhanVien)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaHoaDon", txtMaHD.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Gia", txtGia.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Ngay", txtNgayLap.Text)
            ExecuteQuery1.Parameters.AddWithValue("@MaKhachHang", txtMaKH.Text)
            ExecuteQuery1.Parameters.AddWithValue("@MaNhanVien", txtMaNV.Text)
            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", connect)
        database.Clear()
        Query3.Fill(database)
        DataGridView1.DataSource = database.DefaultView

    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim Stradd As String = "Update HoaDon set Gia = @Gia, MaHoaDon = @MaHoaDon, Ngay = @Ngay, MaKhachHang = @MaKhachHang, MaNhanVien = @MaNhanVien where MaHoaDon = @MaHoaDon"
        Dim com As New SqlCommand(Stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaHoaDon", txtMaHD.Text)
            com.Parameters.AddWithValue("@Gia", txtGia.Text)
            com.Parameters.AddWithValue("@Ngay", txtNgayLap.Text)
            com.Parameters.AddWithValue("@MaKhachHang", txtMaKH.Text)
            com.Parameters.AddWithValue("@MaNhanVien", txtMaNV.Text)
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
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", ketnoi1)

        ketnoi1.Open()
        Query1.Fill(database)
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim xoadl As String = "Delete from HoaDon Where MaHoaDon = @MaHoaDon"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaHoaDon", txtMaHD.Text)
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

    Private Sub BtnThoat_Click(sender As Object, e As EventArgs) Handles BtnThoat.Click
        Me.Hide()
    End Sub
End Class