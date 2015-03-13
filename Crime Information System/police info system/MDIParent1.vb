Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
   
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        With frmadmin
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub


    Private Sub UToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UToolStripMenuItem.Click
        With frmuser
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollToolStripMenuItem.Click

    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceToolStripMenuItem.Click
        If usertype = "ADMIN" Then
            With frmemployeeattendance
                .MdiParent = Me
                .WindowState = FormWindowState.Normal
                .Show()
            End With
        Else
            With frmemployeeattendance
                .MdiParent = Me
                .WindowState = FormWindowState.Normal
                .Show()
            End With
        End If

    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskToolStripMenuItem.Click
        With frmtasksettings
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub DesignationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesignationToolStripMenuItem.Click
        With frmdesignation
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub TargetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetToolStripMenuItem.Click
        With frmtarget
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        With frmviewprofile
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        With frmprofile
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub AttendanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceToolStripMenuItem1.Click
        With frmattendance
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub OverTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmovertime
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryToolStripMenuItem.Click
        With frmsalary
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ComplaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintToolStripMenuItem.Click
        With frmcomplaint
            vartype = "Crime"
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub CriminalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriminalToolStripMenuItem.Click
        With frmcriminal
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub PostMortemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostMortemToolStripMenuItem.Click
        With frmpostmortem
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub FIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIRToolStripMenuItem.Click
        With frmfir
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ChargeSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargeSheetToolStripMenuItem.Click
        With frmchargesheet
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub UTPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UTPToolStripMenuItem.Click
        With frmutp
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub PermanentPrisonerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermanentPrisonerToolStripMenuItem.Click
        With frmpermanentprisoner
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub MostWantedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostWantedToolStripMenuItem.Click
        With frmmostwanted
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub StrikeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrikeToolStripMenuItem.Click
        With frmstrike
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub DailyRoundsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyRoundsToolStripMenuItem.Click
        With frmdailyrounds
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ChecktingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecktingToolStripMenuItem.Click
        With frmchecking
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub SecurityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecurityToolStripMenuItem.Click
        With frmsecurity
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub RideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RideToolStripMenuItem.Click
        With frmride
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub ComplaintRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintRecordToolStripMenuItem.Click
        With frmcomplaint
            vartype = "Law and Order"
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub EndorsementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndorsementToolStripMenuItem.Click
        With frmendorsement
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub RunningCaseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunningCaseToolStripMenuItem2.Click
       
    End Sub

    Private Sub StatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusToolStripMenuItem.Click
        With frmstatus
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub JudgementDoneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JudgementDoneToolStripMenuItem1.Click
        With Frmjudgement
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub WithdrawnCaseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawnCaseToolStripMenuItem2.Click
        With frmwithdrawn
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()
        End With
    End Sub

    Private Sub CrystalREportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalREportToolStripMenuItem.Click
        
        dbconf()
        Dim rpt As New CrystalReport1
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        ' rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        ' rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub


    Private Sub AttendenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendenceToolStripMenuItem.Click
        dbconf()
        Dim rpt As New rptattendance
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()

    End Sub

   
    Private Sub EmployeeProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeProfileToolStripMenuItem.Click
        dbconf()
        Dim rpt As New rptemp
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub ComplaintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptcomplaint
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub CriminalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriminalToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptcriminal
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub PostmortemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostmortemToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptpostmortem
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub FirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptfir
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub ChargesheetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargesheetToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptchargesheet
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub UtpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtpToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptutp
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    
    Private Sub MostwantedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostwantedToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptmostwanted
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub RideToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RideToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptride
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub StrikeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrikeToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptstrike
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub DailyroundsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyroundsToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptdailyreports
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub CheckingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckingToolStripMenuItem.Click
        dbconf()
        Dim rpt As New rptchecking
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub SecurityToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecurityToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptsecurity
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub EndorsmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndorsmentToolStripMenuItem.Click
        dbconf()
        Dim rpt As New rptendorsment
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub JurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JurToolStripMenuItem.Click
        dbconf()
        Dim rpt As New rptjudgement
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub WithdrawnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawnToolStripMenuItem.Click
        dbconf()
        Dim rpt As New rptwithdrawal
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub StatusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusToolStripMenuItem1.Click
        dbconf()
        Dim rpt As New rptstatus
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub

    Private Sub MenuStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub PermanentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermanentToolStripMenuItem.Click
        dbconf()
        Dim rpt As New rptpermanent
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        ' rpt.RecordSelectionFormula = " {command.client1}=" & txt_search.Text
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()
    End Sub
End Class
