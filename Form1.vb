Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox1.Text.Equals("ADMIN") And TextBox2.Text.Equals("2015") Then
            acceuil.Show()
            Me.Hide()
        Else
            MessageBox.Show(" S.V.P nom ou mot de passe invalide")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
