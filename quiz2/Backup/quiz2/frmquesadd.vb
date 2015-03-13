Public Class frmquesadd

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        qno()


    End Sub
    Sub qno()
        Dim j
        j = 1
        txtqno.Text = j
        sql = "select max(qno) from tbl_quesadd"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            j = rs(0).Value
            j = j + 1
            txtqno.Text = j

        End If

    End Sub
    Sub clear()
        txtqno.Text = ""
        txtques.Text = ""
        txtans.Text = ""
        txta.Text = ""
        txtb.Text = ""
        txtc.Text = ""
        txtd.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtques.Text = "" Then
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



            sql = "insert into tbl_quesadd(qno,question,opa,opb,opc,opd,ans)"
            sql = sql & " values ('" & txtqno.Text & "','" & txtques.Text & "','" & txta.Text & "','" & txtb.Text & "','" & txtc.Text & "','" & txtd.Text & "','" & txtans.Text & "')"
            conn.Execute(sql)

            MsgBox("record saved")
            clear()
            qno()
        End If
    End Sub
End Class
