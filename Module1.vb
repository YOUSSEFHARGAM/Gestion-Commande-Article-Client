Imports System.Data.OleDb
Module Module1
    Public cnx As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\OPEN-MINDED\Desktop\Projet VB.NET\youssefdb.accdb")
    Public Sub ouvrircnx()
        Try
            cnx.Open()

        Catch ex As Exception
            MessageBox.Show("error in connection :" + ex.Message)

        End Try
    End Sub
End Module
