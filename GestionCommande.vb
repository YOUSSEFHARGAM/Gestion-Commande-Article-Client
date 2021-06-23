Imports System.Data.OleDb
Public Class GestionCommande
    Private Sub affiche()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet()
        Dim dt As New DataTable
        ouvrircnx()
        Dim req As New OleDbCommand
        req.Connection = cnx
        req.CommandType = CommandType.Text
        req.CommandText = "select * from commande "
        da.SelectCommand = req
        da.Fill(ds, "commande")
        DataGridView1.DataSource = ds.Tables("commande")
        dt = ds.Tables("commande")
    End Sub

  


   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cmd As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO commande VALUES('" & T1.Text & "','" & T2.Text & "','" &
           T3.Text & "','" & T4.Text & "','" & T5.Text & "','" & T6.Text & "')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
        affiche()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim cm As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cm.Connection = cnx
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE commande SET quantite = '" & T2.Text & "' , pu = '" & T3.Text & "' , prixtot = '" & T4.Text & "', codecl = '" & T4.Text & "', codear = '" & T4.Text & "' WHERE reference = '" & T1.Text & "'"
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
        affiche()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim cm As New OleDbCommand 'new commande
        Try
            ouvrircnx()
            cm.Connection = cnx
            cm.CommandType = CommandType.Text
            cm.CommandText = "DELETE FROM commande WHERE reference = '" & T1.Text & "' "
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnx.Close()
        affiche()
    End Sub
End Class