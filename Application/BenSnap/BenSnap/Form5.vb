Public Class Form5
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim form As New Form3

        form.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        Form4.ShowDialog()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Hide()
        Form4.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Hide()
        Form2.ShowDialog()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCache_Click(sender As Object, e As EventArgs) Handles btnCache.Click
        Dim form As New Form3

        form.Show()
        Me.Close()
    End Sub
End Class