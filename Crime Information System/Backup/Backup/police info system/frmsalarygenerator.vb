Imports System.Data.SqlClient

Public Class frmsalarygenerator

    Private Sub frmsalarygenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ij As Integer
        Dim ItemLists As New ArrayList()

        txtnodays.Text = frmsalary.txtnodays.Text
        txtleaves.Text = frmsalary.txtleaves.Text
        txttotdays.Text = frmsalary.txttotdays.Text
        ComboBox1.Text = frmsalary.ComboBox12.Text
        ComboBox2.Text = frmsalary.ComboBox1.Text

        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tbllogin order by username", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Dim slno As Integer
        slno = 1
        Do While reader.Read = True
            ItemLists.Add(reader(1))
            DataGridView1.Rows.Add(slno, reader(2), reader(1), "", "", "", "", "", "", "")
            slno = slno + 1
        Loop
        connection_close()

        For ij = 0 To ItemLists.Count - 1
            connectiondb()
            cmd = New SqlCommand("Select COUNT(atttype) From tblattendance where username='" & ItemLists.Item(ij) & "'", cnn)
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read = True
                If reader(0) Is DBNull.Value Then
                    DataGridView1.Rows(ij).Cells(3).Value = 0
                Else
                    DataGridView1.Rows(ij).Cells(3).Value = reader(0)
                End If
            Loop
            connection_close()
        Next

        For ij = 0 To ItemLists.Count - 1
            connectiondb()
            cmd = New SqlCommand("Select COUNT(atttype) From tblattendance where username='" & ItemLists.Item(ij) & "' AND atttype='Leave'", cnn)
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read = True
                If reader(0) Is DBNull.Value Then
                    DataGridView1.Rows(ij).Cells(4).Value = 0
                Else
                    DataGridView1.Rows(ij).Cells(4).Value = reader(0)
                End If
            Loop
            connection_close()
        Next

        For ij = 0 To ItemLists.Count - 1
            connectiondb()
            cmd = New SqlCommand("Select SUM(othrs) From tblattendance where username='" & ItemLists.Item(ij) & "'", cnn)
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read = True
                If reader(0) Is DBNull.Value Then
                    DataGridView1.Rows(ij).Cells(5).Value = 0
                Else
                    DataGridView1.Rows(ij).Cells(5).Value = reader(0)
                End If
            Loop
            connection_close()
        Next

        For ij = 0 To ItemLists.Count - 1
            connectiondb()
            cmd = New SqlCommand("Select basicpay From tblempprofile where username='" & ItemLists.Item(ij) & "'", cnn)
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While reader.Read = True
                If reader(0) Is DBNull.Value Then
                    DataGridView1.Rows(ij).Cells(6).Value = 0
                Else
                    DataGridView1.Rows(ij).Cells(6).Value = reader(0)
                    DataGridView1.Rows(ij).Cells(7).Value = DataGridView1.Rows(ij).Cells(5).Value * 100
                    DataGridView1.Rows(ij).Cells(8).Value = DataGridView1.Rows(ij).Cells(6).Value / 31 * DataGridView1.Rows(ij).Cells(4).Value
                    DataGridView1.Rows(ij).Cells(9).Value = (DataGridView1.Rows(ij).Cells(6).Value + DataGridView1.Rows(ij).Cells(7).Value) - DataGridView1.Rows(ij).Cells(8).Value
                End If
            Loop
            connection_close()
        Next

        'For ij = 0 To ItemLists.Count - 1
        '    connectiondb()
        '    cmd = New SqlCommand("Select basicpay From tblempprofile where username='" & ItemLists.Item(ij) & "'", cnn)
        '    reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Do While reader.Read = True
        '        If reader(0) Is DBNull.Value Then
        '            DataGridView1.Rows(ij).Cells(6).Value = 0
        '        Else
        '            DataGridView1.Rows(ij).Cells(6).Value = reader(0)
        '        End If
        '    Loop
        '    connection_close()
        'Next

    End Sub
End Class