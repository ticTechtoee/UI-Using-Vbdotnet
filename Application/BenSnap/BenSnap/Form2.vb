Public Class Form2
    Private Sub linksignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linksignup.LinkClicked
        Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Hide()
        Form3.Show()
    End Sub
End Class