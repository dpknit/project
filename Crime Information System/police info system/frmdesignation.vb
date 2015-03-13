Imports System.Data.SqlClient

Public Class frmdesignation
    Dim a As Integer
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        connectiondb()
        sql = "Select * from tbldesg where designation='" & txtdesignation.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            a = 1
        End While
        connection_close()
        If txtslno.Text = "" Then
            MessageBox.Show("Please enter value for SL ID")
        ElseIf txtdesignation.Text = "" Then
            MessageBox.Show("Please Enter value for designation ")
        ElseIf txtbsalary.Text = "" Then
            MessageBox.Show("Please Enter value for designation ")
        ElseIf a = 1 Then
            MessageBox.Show("Designation already exists")
            a = 0
        Else
            connectiondb()
            cmd = New SqlCommand("Insert Into tbldesg values('" & txtdesignation.Text & "','" & txtcomment.Text & "','" & txtbsalary.Text & "')", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
            datagrid_admin()
            txtdesignation.Clear()
            txtbsalary.Clear()
            userids()
        End If

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtslno.Text = "" Then
            MessageBox.Show("Please enter value for SL ID")
        ElseIf txtdesignation.Text = "" Then
            MessageBox.Show("Please Enter value for designation ")
        ElseIf txtbsalary.Text = "" Then
            MessageBox.Show("Please Enter value for designation ")
        ElseIf a = 1 Then
            MessageBox.Show("Designation already exists")
            a = 0
        Else
            connectiondb()
            cmd = New SqlCommand("Update tbldesg Set designation='" & txtdesignation.Text & "',bsalary='" & txtbsalary.Text & "',comment='" & txtcomment.Text & "' Where designationid=" & Val(txtslno.Text), cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Designation Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
            datagrid_admin()
            connection_close()
            datagrid_admin()
            txtcomment.Clear()
            txtdesignation.Clear()
            txtbsalary.Clear()
            txtslno.Clear()
            userids()
            btndelete.Enabled = False
            btnadd.Enabled = True
            btnupdate.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        connectiondb()
        sql = "Select * from tbldesg where designationid='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtslno.Text = reader(0)
            txtdesignation.Text = reader(1)
            txtbsalary.Text = reader(2)
            txtcomment.Text = reader(3)
        End While
        connection_close()
        btndelete.Enabled = True
        btnupdate.Enabled = True
        btnadd.Enabled = False
    End Sub

    Public Sub datagrid_admin()
        userids()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tbldesg", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(3), reader(2))
        Loop
        connection_close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim msgbutton As DialogResult
        msgbutton = MessageBox.Show("Are you sure you want to Delete this record?", "Are you sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If msgbutton = Windows.Forms.DialogResult.Yes Then
            connectiondb()
            cmd = New SqlCommand("delete from tbldesg where designationid='" & Val(txtslno.Text) & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
            datagrid_admin()
            txtdesignation.Clear()
            txtbsalary.Clear()
            txtcomment.Clear()
            userids()
            btndelete.Enabled = False
            btnadd.Enabled = True
            btnupdate.Enabled = False
        End If
    End Sub

    Sub userids()
        connectiondb()
        sql = "Select * from tbldesg"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtslno.Text = reader.Item(0) + 1
            End While
        Catch ex As Exception
            MsgBox("Invalid id! ")
        End Try
        connection_close()
    End Sub

    Private Sub frmdesignation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btndelete.Enabled = False
        btnupdate.Enabled = False
        txtdesignation.Focus()
        datagrid_admin()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        connectiondb()
        sql = "Select * from tbldesg where designationid='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtslno.Text = reader(0)
            txtdesignation.Text = reader(1)
            txtbsalary.Text = reader(3)
            txtcomment.Text = reader(2)
        End While
        connection_close()
        btndelete.Enabled = True
        btnupdate.Enabled = True
        btnadd.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class