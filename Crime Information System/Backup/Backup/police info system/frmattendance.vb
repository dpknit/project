Imports System.Data.SqlClient
Public Class frmattendance
    Dim i, attid As Integer


    Private Sub frmattendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usersatt()
        userattendance()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If cmbusername.Text = "" Then
            MessageBox.Show("Please enter valid username")
        ElseIf dtedate.Text = "" Then
            MessageBox.Show("Attendance date is not valid")
        ElseIf dtelogin.Text = "" Or dtelogout.Text = "" Then
            MessageBox.Show("Time is not valid")
        Else
            connectiondb()
            cmd = New SqlCommand("Insert Into tblattendance(username,attdate,login,comment,atttype) values('" & _
                                 cmbusername.Text & "',convert(date,'" & dtedate.Text & _
                                 "',103),'" & dtelogin.Text & "','" & txtreason.Text & "','" & _
                                 cmpatttype.Text & "')", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("you are successfully logged in", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("loggin is unsuccessfull", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
        End If
    End Sub


    Sub usersatt()
        connectiondb()
        sql = "Select * from tbllogin"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()

            If usertype = "ADMIN" Then
                cmbusername.Enabled = True
                dtedate.Enabled = True
                dtelogin.Enabled = True
                dtelogout.Enabled = True
                cmpatttype.Enabled = True
                txtreason.Enabled = True
                cmbusername.Items.Add(reader(1))
            Else
                dtedate.Enabled = False
                dtelogin.Enabled = False
                dtelogout.Enabled = False
                cmpatttype.Enabled = True
                txtreason.Enabled = True
                cmbusername.Text = sessionuser
                cmbusername.Enabled = False
            End If

        End While
        connection_close()
    End Sub

    Sub userattendance()
        i = 0
        btnlogin.Enabled = True
        btnlogout.Enabled = False
        dtelogin.Text = Now
        dtelogout.Text = Now
        cmpatttype.Enabled = False
        connectiondb()
        sql = "Select * from tblattendance where username='" & cmbusername.Text & "' AND attdate=convert(date,'" & dtedate.Text & "',103)"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            i = 1
            dtelogin.Enabled = False
            btnlogin.Enabled = False
            dtelogin.Text = reader(3).ToString
            'txtlogin.Text = reader(3)
            cmpatttype.Text = reader(6)
            txtreason.Text = reader(5)
            btnlogin.Enabled = False
            btnlogout.Enabled = True
            cmpatttype.Enabled = True
            attid = reader(0)
        End While
        connection_close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmbusername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusername.SelectedIndexChanged
        userattendance()
    End Sub

    Private Sub dtedate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtedate.ValueChanged
        userattendance()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click

   connectiondb()
        cmd = New SqlCommand("Update tblattendance Set logout='" & dtelogout.Text & _
                             "',comment='" & txtreason.Text & _
                             "',atttype='" & cmpatttype.Text & _
                             "',othrs='" & ComboBox1.Text & "' Where attid=" & attid, cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Logged out Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
    End Sub

    Private Sub cmpatttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmpatttype.SelectedIndexChanged
        If cmpatttype.Text = "Full Time + Over Time" Then
            ComboBox1.Enabled = True
        End If
    End Sub
End Class