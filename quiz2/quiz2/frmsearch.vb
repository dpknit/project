Public Class frmsearch

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub frmsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtuname.Text = "" Then
            MsgBox("enter username")
        Else


            sql = "select name,clgname,contactno,email from tbl_student where username='" & txtuname.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                txtname.Text = rs(0).Value
                txtclg.Text = rs(1).Value
                txtcontact.Text = rs(2).Value
                txtemail.Text = rs(3).Value
            End If
        End If
    End Sub
End Class