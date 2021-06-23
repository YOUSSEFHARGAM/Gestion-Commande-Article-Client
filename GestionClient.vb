Imports System.Data.OleDb
Imports System.Net.Mail
Public Class GestionClient


   

    

   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cmd As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO client VALUES('" & T1.Text & "','" & T2.Text & "','" &
           T3.Text & "')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        affichageClient.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim mail As New MailMessage
        mail.Subject = objetm.Text
        mail.To.Add(pour.Text)
        mail.From = New MailAddress("")
        mail.Body = corp.Text

        Dim stmp As New SmtpClient("smtp.gmail.com")
        stmp.EnableSsl = True
        stmp.Credentials = New System.Net.NetworkCredential("", "")
        stmp.Port = "587"
        stmp.Send(mail)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cm As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cm.Connection = cnx
            cm.CommandType = CommandType.Text
            cm.CommandText = "DELETE FROM client WHERE code = '" & T1.Text & "' "
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
    End Sub
End Class