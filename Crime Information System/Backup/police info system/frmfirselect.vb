Imports System.Data.SqlClient
Public Class frmfirselect

    Private Sub frmfirselect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        connectiondb()
     
        cmd = New SqlCommand("Select * From tblfir", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(29))
        Loop
        connection_close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If firview = "frmpostmortem" Then
            frmpostmortem.txtfirno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf firview = "frmchargesheet" Then
            frmchargesheet.txtfirno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf firview = "frmjudgement" Then
            Frmjudgement.txtfirno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf firview = "frmstatus" Then
            frmstatus.txtfir.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf firview = "frmwithdrawn" Then
            frmwithdrawn.txtfir.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class