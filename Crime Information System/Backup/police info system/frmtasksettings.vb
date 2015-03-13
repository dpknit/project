Imports System.Data.SqlClient
Public Class frmtasksettings
  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'connectiondb()
        'cmd = New SqlCommand("Insert Into tbltasksettings values('" & ComboBox1.Text & "','" & cmpshift.Text & "','" & cmbtask.Text & "','" & txtcomment.Text & "',convert(date,'" & dtefromdate.Text & "',103),convert(date,'" & dtetodate.Text & "',103))", cnn)
        'i = cmd.ExecuteNonQuery()
        'If i > 0 Then
        '    MessageBox.Show("Task Records Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        'connection_close()
    End Sub

    Private Sub frmtasksettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ItemLists As New ArrayList()
        Dim totalemp, emploop, dayloop As New Integer

        ''Total number of days
        'Dim noofdays As Integer = System.DateTime.DaysInMonth(2012, 2)
        ''prints total number of employees
        'connectiondb()
        'sql = "Select COUNT(username) from tbllogin"
        'cmd = New SqlCommand(sql, cnn)
        'reader = cmd.ExecuteReader()
        'While reader.Read()
        '    totalemp = reader(0)
        'End While
        'connection_close()

        'stores employee userid
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tbllogin", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(1), "Day Shift")
        Loop
        connection_close()

        'stores employee userid
        DataGridView2.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tbltasksettings", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Dim kl As Integer
        kl = 1
        Do While reader.Read = True
            DataGridView2.Rows.Add(kl, reader(1), reader(2))
            kl = kl + 1
        Loop
        connection_close()
    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcomment.Click

        Dim Year As Integer = DateTime.Today.Year
        Dim Month As Integer = DateTime.Today.Month

        Dim q As Integer
        q = DataGridView1.Rows.Count
        For j As Integer = 0 To q - 2
            'For k As Integer = 1 To 31
            connectiondb()
            cmd = New SqlCommand("Insert Into tbltasksettings values('" & DataGridView1.Rows(j).Cells(0).Value & "','" & DataGridView1.Rows(j).Cells(1).Value & "','" & txtcomment.Text & "',convert(date,'" & DateTimePicker1.Text & "',103))", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
            'Next
        Next
        MessageBox.Show("Record Inserted Successfully...")
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        TabControl1.SelectedTab = TabPage1
    End Sub
End Class