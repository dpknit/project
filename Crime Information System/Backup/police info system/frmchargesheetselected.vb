Imports System.Data.SqlClient
Public Class frmchargesheetselected

    Private Sub frmchargesheetselected_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblchargesheet", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(9))
        Loop
        connection_close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If chargesheetview = "frmjudgement" Then
            Frmjudgement.txtchargesheetno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf chargesheetview = "frmwithdrawn" Then
            frmwithdrawn.txtchargesheet.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf chargesheetview = "frmstatus" Then
            frmstatus.txtchargesheet.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class