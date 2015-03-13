Imports System.Data.SqlClient

Public Class frmemployeeattendance

    Private Sub frmemployeeattendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Total number of days
        'Dim noofdays As Integer = System.DateTime.DaysInMonth(2012, 2)
        ''prints total number of employees
        connectiondb()
        sql = "Select * from tbllogin"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            ComboBox3.Items.Add(reader(1))
        End While
        connection_close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim monthint As Integer
        Dim dateformat, dateformat2 As String
        If ComboBox2.Text = "JAN" Then
            monthint = 1
        ElseIf ComboBox2.Text = "FEB" Then
            monthint = 2
        ElseIf ComboBox2.Text = "MAR" Then
            monthint = 3
        ElseIf ComboBox2.Text = "APR" Then
            monthint = 4
        ElseIf ComboBox2.Text = "MAY" Then
            monthint = 5
        ElseIf ComboBox2.Text = "JUN" Then
            monthint = 6
        ElseIf ComboBox2.Text = "JUL" Then
            monthint = 7
        ElseIf ComboBox2.Text = "AUG" Then
            monthint = 8
        ElseIf ComboBox2.Text = "SEPT" Then
            monthint = 9
        ElseIf ComboBox2.Text = "OCT" Then
            monthint = 10
        ElseIf ComboBox2.Text = "NOV" Then
            monthint = 11
        ElseIf ComboBox2.Text = "DEC" Then
            monthint = 12
        Else
            MessageBox.Show("Error")
        End If

        dateformat = "01-" & monthint & "-" & ComboBox1.Text
        dateformat2 = "31-" & monthint & "-" & ComboBox1.Text
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblattendance where username='" & ComboBox3.Text & "' AND attdate  BETWEEN convert(date,'" & dateformat & "',103) and convert(date,'" & dateformat2 & "',103) order by attdate", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Dim slno As Integer
        slno = 1
        Do While reader.Read = True
            DataGridView1.Rows.Add(slno, reader(2), reader(3), reader(4), reader(5), reader(6), reader(7))
            slno = slno + 1
        Loop
        connection_close()
    End Sub
End Class