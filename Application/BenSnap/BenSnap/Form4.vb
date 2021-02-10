Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        redButton.Parent = map
        redButtonT.Parent = map
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub btnYesT_Click(sender As Object, e As EventArgs) Handles btnYesT.Click
        paneltwo.Visible = False
    End Sub

    Private Sub btnCache_Click(sender As Object, e As EventArgs) Handles btnCache.Click
        Hide()
        Form3.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim form As New Form3

        form.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim form As New Form5

        form.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Hide()
        Form5.ShowDialog()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        one.Visible = False

    End Sub

    Private Sub redButton_Click(sender As Object, e As EventArgs) Handles redButton.Click
        one.Visible = True
    End Sub

    Private Sub redButtonT_Click(sender As Object, e As EventArgs) Handles redButtonT.Click
        paneltwo.Visible = True

    End Sub
End Class