Public Class frmadvote

    Private Sub frmadvote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        
        loadgrid1()

    End Sub
    Sub loadgrid1()
        i = 0
        DataGridView1.Rows.Clear()
        sql = "select * from tbl_vote"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            i = i + 1
            rs.MoveNext()

           
        Loop


    End Sub
    

  



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim sum As Integer
        sql = " select * from tbl_vote"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        For a = 0 To DataGridView1.Rows.Count - 1


            If rs.EOF = False Then
                sum = DataGridView1.Rows(a).Cells(3).Value

                sql = "update tbl_vote set vote=vote + '" & sum & "'  where post='" & DataGridView1.Rows(a).Cells(0).Value & "' and name='" & DataGridView1.Rows(a).Cells(1).Value & "'"
                conn.Execute(sql)
                'MsgBox("Added successfully")
            Else
                'sql = "insert into tbl_stock(prodname,qty)"
                'sql = sql & "values('" & DataGridView1.Rows(a).Cells(0).Value & "','" & DataGridView1.Rows(a).Cells(2).Value & "')"
                'conn.Execute(sql)
                ' MsgBox("Added successfully")
                ' MsgBox("record updated")
            End If









            'If DataGridView1.Rows(a).Cells(1).Value = "True" Then

            '    sql = "insert into tbl_stock(prodname,qty)"
            '    sql = sql & " values ('" & DataGridView1.Rows(a).Cells(0).Value & "','" & DataGridView1.Rows(a).Cells(2).Value & "')"
            '    conn.Execute(sql)




            'End If
        Next
        MsgBox("saved successfully ")

    End Sub
End Class