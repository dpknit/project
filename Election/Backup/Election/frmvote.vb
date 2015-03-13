Public Class frmvote

    Private Sub frmvote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadpresident()
        loadjoint()
        loadsecretary()

    End Sub
    Sub loadpresident()
        i = 0
        DataGridView1.Rows.Clear()

        sql = " SELECT     name, post"
        sql = sql + " FROM         dbo.tbl_candidate"
        sql = sql + " WHERE     (post = N'PRESIDENT')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            i = i + 1
            rs.MoveNext()

        Loop
    End Sub
    Sub loadsecretary()
        i = 0
        DataGridView2.Rows.Clear()

        sql = " SELECT     name, post"
        sql = sql + " FROM         dbo.tbl_candidate"
        sql = sql + " WHERE     (post = N'SECRETARY')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(0).Value
            i = i + 1
            rs.MoveNext()

        Loop
    End Sub
    Sub loadjoint()
        i = 0
        DataGridView3.Rows.Clear()

        sql = " SELECT     name, post"
        sql = sql + " FROM         dbo.tbl_candidate"
        sql = sql + " WHERE     (post = N'JOINT SECRETARY')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView3.Rows.Add()
            DataGridView3.Item(0, i).Value = rs(0).Value
            i = i + 1
            rs.MoveNext()

        Loop
    End Sub
   



    

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmwelcome.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Visible = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView2.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView3.Visible = True
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim d As Integer
        For a = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(a).Cells(1).Selected = True Then
                sql = " update tbl_vote set vote= vote+1 where post='" & Button1.Text & "' and name= '" & DataGridView1.Rows(a).Cells(0).Value & "'"
                conn.Execute(sql)

               



            End If
        Next
        DataGridView1.Enabled = False
        Button1.Enabled = False

    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim d As Integer
        For a = 0 To DataGridView2.Rows.Count - 1
            If DataGridView2.Rows(a).Cells(1).Selected = True Then
                sql = " update tbl_vote set vote= vote+1 where post= '" & Button2.Text & "' and name= '" & DataGridView2.Rows(a).Cells(0).Value & "'"
                conn.Execute(sql)





            End If
        Next
        DataGridView2.Enabled = False
        Button2.Enabled = False

    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim d As Integer
        For a = 0 To DataGridView3.Rows.Count - 1
            If DataGridView3.Rows(a).Cells(1).Selected = True Then
                sql = " update tbl_vote set vote= vote+1 where post= '" & Button3.Text & "' and name= '" & DataGridView1.Rows(a).Cells(0).Value & "'"
                conn.Execute(sql)





            End If
        Next
        DataGridView3.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        frmwelcome.Show()
        frmwelcome.VOTINGToolStripMenuItem.Visible = False
    End Sub
End Class