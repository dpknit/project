Imports System.Data.SqlClient
Public Class frmadmin
    Dim a As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        connectiondb()
        sql = "Select * from tbllogin where username='" & txtuserid.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            a = 1
        End While
        connection_close()
        If txtslno.Text = "" Then
            MessageBox.Show("Please enter value for SL ID")
        ElseIf txtfirstname.Text = "" Then
            MessageBox.Show("Please enter value for first name")
        ElseIf txtlastname.Text = "" Then
            MessageBox.Show("Please Enter value for Last Name")
        ElseIf txtdesignation.Text = "" Then
            MessageBox.Show("Please Enter value for designation ")
        ElseIf txtuserid.Text = "" Then
            MessageBox.Show("Please Enter value for user id")
        ElseIf Len(txtpassword.Text) < 2 Then
            MessageBox.Show("Password must be more than 2 character")
        ElseIf a = 1 Then
            MessageBox.Show("Username already exists")
            txtuserid.Clear()
            a = 0
        Else
            connectiondb()
            cmd = New SqlCommand("Insert Into tbllogin values('" & txtuserid.Text & "','" & txtpassword.Text & "','" & txtfirstname.Text & "','" & txtlastname.Text & "','ADMIN')", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("One User Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
            ' inserts record: employee profile
            connectiondb()
            cmd = New SqlCommand("Insert Into tblempprofile(username) values('" & txtuserid.Text & "')", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
            '--------
            datagrid_admin()
            txtfirstname.Clear()
            txtlastname.Clear()
            txtdesignation.Items.Clear()
            txtuserid.Clear()
            txtpassword.Clear()
            userids()
        End If
    End Sub

    Private Sub frmadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btndelete.Enabled = False
        btnupdate.Enabled = False
        txtfirstname.Focus()
        datagrid_admin()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Sub userids()
        connectiondb()
        sql = "Select * from tbllogin"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtslno.Text = reader.Item(0) + 1
            End While
        Catch ex As Exception
            MsgBox("Invalid Userid! ")
        End Try
        connection_close()
    End Sub

    Public Sub datagrid_admin()
        userids()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tbllogin where designation='ADMIN' order by serialnumber", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Dim id As Integer
        id = 1
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(id, reader(0), reader(3), reader(4), reader(1))
            id = id + 1
        Loop
        connection_close()

        connectiondb()
        sql = "Select * from tbldesg"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtdesignation.Items.Add(reader(1))
            End While
        Catch ex As Exception
            MsgBox("Invalid Userid! ")
        End Try
        connection_close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        connectiondb()
        sql = "Select * from tbllogin where serialnumber='" & DataGridView1.CurrentRow.Cells(1).Value & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtslno.Text = reader(0)
            txtfirstname.Text = reader(3)
            txtlastname.Text = reader(4)
            txtdesignation.Text = reader(5)
            txtuserid.Text = reader(1)
            txtpassword.Text = reader(2)
        End While
        connection_close()
        btndelete.Enabled = True
        btnupdate.Enabled = True
        btnsubmit.Enabled = False
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtslno.Text = "" Then
            MessageBox.Show("Please enter value for SL ID")
        ElseIf txtfirstname.Text = "" Then
            MessageBox.Show("Please enter value for first name")
        ElseIf txtlastname.Text = "" Then
            MessageBox.Show("Please Enter value for Last Name")
        ElseIf txtdesignation.Text = "" Then
            MessageBox.Show("Please Enter value for designation ")
        ElseIf txtuserid.Text = "" Then
            MessageBox.Show("Please Enter value for user id")
        ElseIf Len(txtpassword.Text) < 2 Then
            MessageBox.Show("Password must be more than 2 character")
        ElseIf a = 1 Then
            MessageBox.Show("Username already exists")
            txtuserid.Clear()
            a = 0
        Else

            connectiondb()
            cmd = New SqlCommand("Update tbllogin Set username='" & txtuserid.Text & "',fname='" & txtfirstname.Text & "',lname='" & txtlastname.Text & "',designation='" & txtdesignation.Text & "' Where serialnumber=" & Val(txtslno.Text), cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Admin Record Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update item!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
            datagrid_admin()
            txtfirstname.Clear()
            txtlastname.Clear()
            txtdesignation.Items.Clear()
            txtuserid.Clear()
            txtpassword.Clear()
            userids()
            btndelete.Enabled = False
            btnsubmit.Enabled = True
            btnupdate.Enabled = False
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim msgbutton As DialogResult
        msgbutton = MessageBox.Show("Are you sure you want to Delete this record?", "Are you sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If msgbutton = Windows.Forms.DialogResult.Yes Then
            connectiondb()
            cmd = New SqlCommand("delete from tbllogin where serialnumber='" & Val(txtslno.Text) & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
            datagrid_admin()
            txtfirstname.Clear()
            txtlastname.Clear()
            txtdesignation.Items.Clear()
            txtuserid.Clear()
            txtpassword.Clear()
            userids()
            btndelete.Enabled = False
            btnsubmit.Enabled = True
            btnupdate.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class