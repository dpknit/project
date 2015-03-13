Public Class frmwelcome

    Private Sub REGISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRATIONToolStripMenuItem.Click
        frmreg.Show()

    End Sub

    Private Sub AIDDQUESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AIDDQUESTToolStripMenuItem.Click
        frmquesadd.Show()

    End Sub

    Private Sub EDITQUESTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITQUESTIONToolStripMenuItem.Click
        frmquesedit.Show()

    End Sub

    Private Sub QUIZToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUIZToolStripMenuItem.Click
        frmquiz.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        'Me.Close()

        If MsgBoxResult.No = MsgBox("DO YOU WANT TO LOGOUT?", MsgBoxStyle.YesNo, " MMS") Then Exit Sub

        Me.Close()
        frmlogin.Show()
        'ComboBox1.SelectedIndex = -1
        'txtname.Text = ""
        'txtpass.Text = ""
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        If MsgBoxResult.No = MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNo) Then Exit Sub
        Application.Exit()
    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHToolStripMenuItem.Click
        frmsearch.Show()

    End Sub

    Private Sub RESULTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESULTToolStripMenuItem.Click
        frmresult.Show()

    End Sub
End Class