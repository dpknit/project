Public Class frmcount

    Private Sub frmcount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadgrid1()
        loadgrid2()
        loadgrid3()

    End Sub
    Sub loadgrid1()
        i = 0
        DataGridView1.Rows.Clear()
        sql = "select * from tbl_vote where (post = N'PRESIDENT')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            i = i + 1
            rs.MoveNext()


        Loop
    End Sub
    Sub loadgrid2()
        i = 0
        DataGridView2.Rows.Clear()
        sql = "select * from tbl_vote where (post = N'SECRETARY')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(0).Value
            DataGridView2.Item(1, i).Value = rs(1).Value
            DataGridView2.Item(2, i).Value = rs(2).Value
            i = i + 1
            rs.MoveNext()


        Loop
    End Sub
    Sub loadgrid3()
        i = 0
        DataGridView3.Rows.Clear()
        sql = "select * from tbl_vote where (post = N'JOINT SECRETARY')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView3.Rows.Add()
            DataGridView3.Item(0, i).Value = rs(0).Value
            DataGridView3.Item(1, i).Value = rs(1).Value
            DataGridView3.Item(2, i).Value = rs(2).Value
            i = i + 1
            rs.MoveNext()


        Loop
    End Sub

End Class