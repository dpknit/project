Imports System.Data.SqlClient
Public Class frmcriminalselect

    Private Sub frmcriminalselect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblcriminals", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(2))
        Loop
        connection_close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If crminalview = "frmutp" Then
            frmutp.txtcriminalno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf crminalview = "frmpermanent" Then
            frmpermanentprisoner.txtcriminalno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf crminalview = "frmchargesheet" Then
            frmchargesheet.txtcriminalno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class