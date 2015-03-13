Public Class frmquiz

  
    Private Sub frmquiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        txtusername.Text = frmlogin.txtname.Text
        txtqno.Text = 1
        qno()


    End Sub
    Sub qno()

        sql = "select * from tbl_quesadd where qno='" & txtqno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtqno.Text = rs(0).Value
            txtquestion.Text = rs(1).Value
            txta.Text = rs(2).Value
            txtb.Text = rs(3).Value
            txtc.Text = rs(4).Value
            txtd.Text = rs(5).Value

        End If

    End Sub
    Sub increment()
        i = txtqno.Text
        i = i + 1
        txtqno.Text = i

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtans.Text = "" Then
            MsgBox("pls answer the question")
        Else


            Dim a As String
            Dim s As Integer
            s = 0
            'a = txtans.Text
            sql = "select ans from tbl_quesadd where qno='" & txtqno.Text & "' "
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                a = rs(0).Value
            Else
                MsgBox("exam completed")
                Me.Hide()
                frmwelcome.Show()
                frmwelcome.QUIZToolStripMenuItem.Visible = False

            End If
            If txtans.Text = a Then
                sql = "update tbl_result set result=result+1 where loginname='" & txtusername.Text & "'"
                conn.Execute(sql)

            End If





            increment()
            qno()
            txtans.Text = ""

        End If
    End Sub


    Private Sub txtans_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtans.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtans.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If
    End Sub

End Class