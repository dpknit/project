Public Class frmquesedit

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtc.TextChanged

    End Sub

    Private Sub frmquesedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        qno()

    End Sub
    Sub qno()
        cmdqno.Items.Clear()
        sql = "select distinct qno from tbl_quesadd "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            cmdqno.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmdqno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdqno.SelectedIndexChanged
       






        sql = "select * from tbl_quesadd where qno='" & cmdqno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then

            txtquestion.Text = rs(1).Value
            txta.Text = rs(2).Value
            txtb.Text = rs(3).Value
            txtc.Text = rs(4).Value
            txtd.Text = rs(5).Value
            txtans.Text = rs(6).Value



        End If

    End Sub
    Sub clear()
        txtquestion.Text = ""
        txta.Text = ""
        txtb.Text = ""
        txtc.Text = ""
        txtd.Text = ""
        txtans.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtquestion.Text = "" Then
            MsgBox("enter question")
        ElseIf txta.Text = "" Then
            MsgBox("enter option A")
        ElseIf txtb.Text = "" Then
            MsgBox("enter option B")
        ElseIf txtc.Text = "" Then
            MsgBox("enter option C")
        ElseIf txtd.Text = "" Then
            MsgBox("enter option D")
        ElseIf txtans.Text = "" Then
            MsgBox("enter answer")
        Else
            sql = "update tbl_quesadd set question='" & txtquestion.Text & "',opa='" & txta.Text & "',opb='" & txtb.Text & "',opc='" & txtc.Text & "',opd='" & txtd.Text & "',ans='" & txtans.Text & "' where qno='" & cmdqno.Text & "' "
            conn.Execute(sql)
            MsgBox("record updated")
            clear()
        End If


    End Sub
End Class