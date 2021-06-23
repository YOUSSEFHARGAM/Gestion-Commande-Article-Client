Imports System.Data.OleDb
Public Class gestion_article

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cmd As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO article VALUES('" & T1.Text & "','" & T2.Text & "','" &
           T3.Text & "','" & T4.Text & "')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim cm As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cm.Connection = cnx
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE article SET nom = '" & T2.Text & "' , categorie = '" & T3.Text & "' , stock = '" & T4.Text & "' WHERE reference = '" & T1.Text & "'"
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
        
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cm As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cm.Connection = cnx
            cm.CommandType = CommandType.Text
            cm.CommandText = "DELETE FROM article WHERE reference = '" & T1.Text & "' "
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet()
        Dim dt As New DataTable
        ouvrircnx()
        Dim req As New OleDbCommand
        req.Connection = cnx
        req.CommandType = CommandType.Text
        req.CommandText = "select reference, nom, categorie, stock from article "
        da.SelectCommand = req
        da.Fill(ds, "article")
        DataGridView1.DataSource = ds.Tables("article")
        dt = ds.Tables("article")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        acceuil.Show()
        Me.Hide()
    End Sub
End Class