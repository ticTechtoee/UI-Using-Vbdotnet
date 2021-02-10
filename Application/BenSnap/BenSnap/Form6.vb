Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnRed.BringToFront()
        btnRed.Parent = picmap


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click


        Dim form As New Form3

        form.Show()
        Me.Close()






    End Sub

    Private Sub btnCache_Click(sender As Object, e As EventArgs) Handles btnCache.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        Form4.ShowDialog()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Hide()
        Form4.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Hide()
        Form5.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Hide()
        Form5.ShowDialog()
    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub
End Class