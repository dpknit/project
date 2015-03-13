Public Class frmcandidates

    Private Sub frmcandidates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadgrid()

    End Sub
    Sub loadgrid()
        i = 0
        DataGridView1.Rows.Clear()
        sql = "select * from tbl_candidate "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            i = i + 1
            rs.MoveNext()


        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()

    End Sub
    Sub clear()
        cmdpost.SelectedIndex = -1
        txtname.Text = ""
        cmdclass.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sql = " select * from tbl_candidate where post='" & cmdpost.Text & "' and name='" & txtname.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("record exists")
        Else
            sql = "insert into tbl_candidate(post,name,class)"
            sql = sql & " values('" & cmdpost.Text & "','" & txtname.Text & "','" & cmdclass.Text & "')"
            conn.Execute(sql)
            sql = "insert into tbl_vote(post,name,vote)"
            sql = sql & " values('" & cmdpost.Text & "','" & txtname.Text & "',0)"
            conn.Execute(sql)
            MsgBox("Registered successfully")
            loadgrid()
            clear()


        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        sql = " delete from tbl_candidate where id='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        sql = " delete from tbl_vote where name='" & txtname.Text & "'"
        conn.Execute(sql)
        MsgBox("deleted")
        loadgrid()
        clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql = "update tbl_candidate set post='" & cmdpost.Text & "',name='" & txtname.Text & "', class='" & cmdclass.Text & "' where id='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        sql = " update tbl_vote set post='" & cmdpost.Text & "',name='" & txtname.Text & "' where name='" & txtname.Text & "'"
        conn.Execute(sql)
        MsgBox("record Updated")
        loadgrid()
        clear()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cmdpost.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value
        cmdclass.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub
End Class