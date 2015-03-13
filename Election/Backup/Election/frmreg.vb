Public Class frmreg

    Private Sub frmreg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadgrid()


    End Sub
    Sub loadgrid()
        i = 0
        DataGridView1.Rows.Clear()
        sql = "select * from tbl_register"
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
    Sub clear()
        txtname.Text = ""
        txtpass.Text = ""
        cmdtype.SelectedIndex = -1

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmdtype.Text = "" Then
            MsgBox("enter user type")
        ElseIf txtname.Text = "" Then
            MsgBox("enter username")
        ElseIf txtpass.Text = "" Then
            MsgBox("enter password")
        Else
            sql = "select * from tbl_register where username= '" & txtname.Text & "' or password='" & txtpass.Text & "' "
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("Record exist")
                clear()

            Else

                sql = "insert into tbl_register(usertype,username,password)"
                sql = sql & "values('" & cmdtype.Text & "','" & txtname.Text & "','" & txtpass.Text & "')"
                conn.Execute(sql)
                MsgBox("REGISTRATION SUCCESSFUL")
                clear()
                loadgrid()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        sql = "delete from tbl_register where eno='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        If MsgBoxResult.No = MsgBox("do you want to permanently delete this record?", MsgBoxStyle.YesNo) Then Exit Sub
        MsgBox("record deleted")
        clear()

        loadgrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cmdtype.Text = "" Then
            MsgBox("enter user type")
        ElseIf txtname.Text = "" Then
            MsgBox("enter username")
        ElseIf txtpass.Text = "" Then
            MsgBox("enter password")
        Else
            sql = " select * from tbl_register where eno='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("already exists")
            Else
                sql = "update tbl_register set usertype= '" & cmdtype.Text & "',username= '" & txtname.Text & "', password ='" & txtpass.Text & "' where eno= '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
                conn.Execute(sql)
                MsgBox("record updated")
                clear()

                loadgrid()
            End If
            
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cmdtype.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtpass.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub
End Class
