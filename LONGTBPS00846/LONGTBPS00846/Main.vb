Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogin.ShowDialog()
    End Sub

    Private Sub TàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TàiKhoảnToolStripMenuItem.Click
        FrmNhanVien.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        FrmKhachHang.Show()
    End Sub

    Private Sub LoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        FrmLoaiSach.Show()
    End Sub

    Private Sub SáchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem1.Click
        FrmSach.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem1.Click
        FrmHoaDon.Show()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        FrmChiTiet.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub
End Class