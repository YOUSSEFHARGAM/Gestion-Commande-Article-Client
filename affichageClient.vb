Imports System.Data.OleDb
Public Class affichageClient

    Private Sub affichageClient_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet()
        Dim dt As New DataTable
        ouvrircnx()
        Dim req As New OleDbCommand
        req.Connection = cnx
        req.CommandType = CommandType.Text
        req.CommandText = "select * from client "
        da.SelectCommand = req
        da.Fill(ds, "client")
        DataGridView1.DataSource = ds.Tables("client")
        dt = ds.Tables("client")
    End Sub
End Class