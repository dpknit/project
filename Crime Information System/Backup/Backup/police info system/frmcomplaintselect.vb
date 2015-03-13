Imports System.Data.SqlClient
Public Class frmcomplaintselect

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmcomplaintselect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        connectiondb()
        If complaintview = "frmendorsement" Then
            cmd = New SqlCommand("Select * From tblcomplaints where comptype='Law and Order'", cnn)
        Else
            cmd = New SqlCommand("Select * From tblcomplaints", cnn)
        End If

        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(3))
        Loop
        connection_close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If complaintview = "frmcriminal" Then
            frmcriminal.txtcomplaintno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf complaintview = "frmchargesheet" Then
            frmchargesheet.txtcomplaintno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf complaintview = "frmendorsement" Then
            frmendorsement.txtcomplaintno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf complaintview = "frmjudgement" Then
            Frmjudgement.txtcomplainno.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf complaintview = "frmwithdrawn" Then
            frmwithdrawn.txtcomplaint.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf complaintview = "frmstatus" Then
            frmstatus.txtcomplaint.Text = DataGridView1.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class