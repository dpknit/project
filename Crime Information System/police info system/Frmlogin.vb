Imports System.Data.SqlClient
Public Class Frmlogin
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click, Button4.Click, Button2.Click
        i = 0
        usertype = ComboBox1.Text
        connectiondb()
        sql = "Select * from tbllogin where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "' and designation='" & ComboBox1.Text & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            i = 1
        End While
        If i > 0 Then
            Me.Hide()
            sessionuser = txtusername.Text
            MDIParent1.Show()
        Else
            MessageBox.Show("Invalid Username and Password! ", "Invalid Login Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click, Button3.Click, Button1.Click
        End
    End Sub

    Private Sub Frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select * from tbldesg"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            ComboBox1.Items.Add(reader(1))
        End While
        connection_close()
    End Sub
End Class