Imports System.Data.SqlClient
Public Class frmtarget

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connectiondb()
        cmd = New SqlCommand("Update tbltarget Set minimumcase='" & txttarget.Text & "' Where tid='1'", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Target Updated Successfully...", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update password!" & vbCrLf & " Invalid User Name or Password Entered... ", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()

    End Sub

    Private Sub frmtarget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectiondb()
        sql = "Select * from tbltarget"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txttarget.Text = reader(1)
            End While
        Catch ex As Exception
            MsgBox("Invalid Username and Password! ")
        End Try
        connection_close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class