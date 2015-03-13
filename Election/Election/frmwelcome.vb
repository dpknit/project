Public Class frmwelcome

    Private Sub CANDIDATESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANDIDATESToolStripMenuItem.Click
        frmcandidates.Show()

    End Sub

    Private Sub frmwelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()

    End Sub

    Private Sub REGISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRATIONToolStripMenuItem.Click
        frmreg.Show()

    End Sub

    Private Sub VOTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOTEToolStripMenuItem.Click
        frmcandidatelist.Show()

    End Sub

    Private Sub VOTINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOTINGToolStripMenuItem.Click
        frmvote.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        If MsgBoxResult.No = MsgBox("DO YOU WANT TO LOGOUT?", MsgBoxStyle.YesNo, " MMS") Then Exit Sub

        Me.Close()
        frmlogin.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        If MsgBoxResult.No = MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNo) Then Exit Sub
        Application.Exit()
    End Sub

    Private Sub VOTECOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOTECOUNTToolStripMenuItem.Click
        frmcount.Show()

    End Sub

    Private Sub VOTEPLUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOTEPLUSToolStripMenuItem.Click
        frmadvote.Show()

    End Sub
End Class