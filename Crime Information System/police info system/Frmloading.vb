Public Class Frmloading

    Private Sub Frmloading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 10 Then
            Me.Hide()
            Frmlogin.Show()
            Timer1.Enabled = False
            Exit Sub
        Else
            ProgressBar1.Value += 5
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class