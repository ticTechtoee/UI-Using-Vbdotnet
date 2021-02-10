Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Hide()
        Form3.ShowDialog()

    End Sub

    Private Sub linkSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignIn.LinkClicked
        Hide()
        Form2.ShowDialog()
    End Sub
End Class
