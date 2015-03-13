Public Class frmre

    Private Sub frmre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtname.Text = "" Then
            MsgBox("enter the name")
        ElseIf txtclgname.Text = "" Then
            MsgBox("enter college name")
        ElseIf txtcontact.Text = "" Then
            MsgBox("enter contact no")
        ElseIf txtemail.Text = "" Then
            MsgBox("enter email Id")
        ElseIf txtuname.Text = "" Then
            MsgBox("enter  username")
        ElseIf txtpass.Text = "" Then
            MsgBox("enter password")
        ElseIf txtcpass.Text = "" Then
            MsgBox("enter confirm password")
        ElseIf txtpass.Text <> txtcpass.Text Then
            MsgBox(" retype ur password")
            txtpass.Text = ""
            txtcpass.Text = ""
        Else



            sql = "insert into tbl_student(name,clgname,contactno,email,username,password)"
            sql = sql & " values('" & txtname.Text & "','" & txtclgname.Text & "','" & txtcontact.Text & "','" & txtemail.Text & "','" & txtuname.Text & "','" & txtpass.Text & "')"
            conn.Execute(sql)
            MsgBox("registered successfully")
            Me.Hide()
            frmlogin.Show()
        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frmlogin.Show()

    End Sub
End Class