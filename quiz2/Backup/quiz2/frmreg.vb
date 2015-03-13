Public Class frmreg

    
    Sub loadgrid()
        sql = "select * from tbl_reg"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Dim i
        i = 0
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            rs.MoveNext()
            i = i + 1

        Loop
    End Sub

    Private Sub frmreg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadgrid()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cmdtype.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtpwd.Text = DataGridView1.CurrentRow.Cells(3).Value
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmdtype.Text = "" Then
            MsgBox("enter user type")
        ElseIf txtname.Text = "" Then
            MsgBox("enter username")
        ElseIf txtpwd.Text = "" Then
            MsgBox("enter password")
        Else
            sql = "select * from tbl_reg where usertype='" & cmdtype.Text & "' and username= '" & txtname.Text & "' "
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("Record exist")
                clear()

            Else

                sql = "insert into tbl_reg(usertype,username,password)"
                sql = sql & "values('" & cmdtype.Text & "','" & txtname.Text & "','" & txtpwd.Text & "')"
                conn.Execute(sql)
                MsgBox("REGISTRATION SUCCESSFUL")
                clear()
                loadgrid()
            End If
        End If


    End Sub
    Sub clear()
        Cmdtype.SelectedIndex = -1
        txtname.Text = ""
        txtpwd.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmdtype.Text = "" Then
            MsgBox("enter user type")
        ElseIf txtname.Text = "" Then
            MsgBox("enter username")
        ElseIf txtpwd.Text = "" Then
            MsgBox("enter password")
        Else
            sql = "update tbl_reg set usertype= '" & cmdtype.Text & "',username= '" & txtname.Text & "', password ='" & txtpwd.Text & "' where id= '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
            conn.Execute(sql)
            MsgBox("record updated")
            clear()

            loadgrid()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql = "delete from tbl_reg where id='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        If MsgBoxResult.No = MsgBox("do you want to permanently delete this record?", MsgBoxStyle.YesNo) Then Exit Sub
        MsgBox("record deleted")
        clear()

        loadgrid()
    End Sub
End Class