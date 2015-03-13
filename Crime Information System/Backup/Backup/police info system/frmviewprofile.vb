Imports System.Data.SqlClient

Public Class frmviewprofile

    Private Sub frmviewprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' userids()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tbllogin order by serialnumber", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Dim ida As Integer
        ida = 1
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(ida, reader(3), reader(4), reader(5), reader(1))
            ida = ida + 1
        Loop
        connection_close()
    End Sub
End Class