Imports System.Data.SqlClient
Imports System.IO
Public Class frmcomplaint
    Dim filepath As String
    Dim uploadfilename, randomvalue As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strvar As String
        If RadioButton1.Checked = True Then
            strvar = "Crime"
        ElseIf RadioButton2.Checked = True Then
            strvar = "Law and Order"
        Else
            strvar = "Law and Order and Crime"
        End If
        'inserts login record
        connectiondb()
        cmd = New SqlCommand("Insert Into tblcomplaints values(convert(date,'" & DateTimePicker1.Text & "',103),'" & DateTimePicker3.Text & "','" & txtnameon.Text & _
                            "','" & txtaddresson.Text & "','" & txtcontacton.Text & _
                            "','" & txtoccupasionon.Text & "','" & txtcomplaintabout.Text & _
                            "',convert(date,'" & DateTimePicker2.Text & "',103),'" & nameby.Text & _
                            "','" & txtaddressby.Text & "','" & txtcontactby.Text & _
                            "','" & txtoccupasionby.Text & "','" & strvar & _
                            "','" & txtarea.Text & "','" & txtpolicestation.Text & "','')", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Complaint Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmcomplaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userids()
        datagrid_admin()
        uploads()
    End Sub

    Sub userids()
        connectiondb()
        sql = "Select MAX(complaintno) from tblcomplaints"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtcomplaintname.Text = reader.Item(0) + 1
            End While
        Catch ex As Exception
            MsgBox("Invalid Userid! ")
        End Try
        connection_close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        filepath = OpenFileDialog1.FileName.ToString()
        uploadfilename = Path.GetFileName(filepath)
    End Sub

    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        OpenFileDialog1.Title = "Please select file to upload"
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            filepath = OpenFileDialog1.FileName
        End If

        '''''''''''Random Value'''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''
        Dim Letters As New List(Of Integer)
        'add ASCII codes for numbers
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        'lowercase letters
        For i As Integer = 97 To 122
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        'select 8 random integers from number of items in Letters
        'then convert those random integers to characters and
        'add each to a string and display in Textbox
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 8
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
        Next
        randomvalue = SB.ToString
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim FileToCopy As String
        Dim NewCopy, randomv As String
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        filepath = OpenFileDialog1.FileName.ToString()
        FileToCopy = filepath
        randomv = randomvalue & uploadfilename
        NewCopy = Application.StartupPath.ToString & "\uploads\" & randomv
        MessageBox.Show("You are uploading " & txtfilename.Text & " file")
        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy)
            MsgBox("File Uploaded Successfully...")
        End If

        connectiondb()
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','Complaint','" & randomv & "','" & txtcomplaintname.Text & "')", cnn)
        i = cmd.ExecuteNonQuery()
        connection_close()
        uploads()
        txtfilename.Clear()
    End Sub

    Sub uploads()
        Dim i As Integer
        i = 1
        lstuploads.Items.Clear()

        ' Set ListView Properties  
        lstuploads.View = View.Details
        lstuploads.GridLines = True
        lstuploads.FullRowSelect = True
        lstuploads.HideSelection = False
        lstuploads.MultiSelect = False


        ' Create Columns Headers  
        lstuploads.Columns.Add("SL No.")
        lstuploads.Columns.Add("File Name")
        lstuploads.Columns.Add("File")

        Dim tempValue As Integer = 0


        connectiondb()
        cmd = New SqlCommand("Select * from tblfiles where specid ='" & txtcomplaintname.Text & "' AND form='Complaint'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()

            ' Create List View Item (Row)  
            Dim lvi As New ListViewItem

            'First Column can be the listview item's Text  
            lvi.Text = i.ToString

            ' Second Column is the first sub item  
            lvi.SubItems.Add(reader(1))

            ' Third Column is the first sub item  
            lvi.SubItems.Add(reader(3))

            ' Add the ListViewItem to the ListView  
            lstuploads.Items.Add(lvi)

            i = i + 1
            ' lstuploads.Items.Add(reader(1))
        End While
        connection_close()


    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim strvar As String
        If RadioButton1.Checked = True Then
            strvar = "Crime"
        ElseIf RadioButton2.Checked = True Then
            strvar = "Law and Order"
        Else
            strvar = "Law and Order and Crime"
        End If

        connectiondb()
        cmd = New SqlCommand("Update tblcomplaints Set complaintdate=convert(date,'" & DateTimePicker1.Text & "',103),complainttime=convert(date,'" & DateTimePicker3.Text & _
                             "',103),gonname='" & txtnameon.Text & "',gonaddress='" & txtaddresson.Text & "',goncontno='" & _
                             txtcontacton.Text & "',gonoccupation='" & txtcomplaintabout.Text & _
                             "',compabt='" & txtcomplaintabout.Text & "',compdate=convert(date,'" & DateTimePicker2.Text & "',103),gbyname='" & nameby.Text & _
                             "',gbyaddress='" & txtaddressby.Text & "',gbycontact='" & txtaddressby.Text & _
                             "',gbyoccupation='" & txtoccupasionon.Text & "',comptype='" & strvar & _
                             "',comparea='" & txtarea.Text & "',policestation='" & txtpolicestation.Text & _
                             "' Where complaintno=" & txtcomplaintname.Text, cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Complaint record Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        TabControl1.SelectedTab = TabPage1
        btndelete.Visible = True
        btnupdate.Visible = True
        Button2.Visible = False
        connectiondb()
        cmd = New SqlCommand("Select * from tblcomplaints where complaintno ='" & DataGridView1.CurrentRow.Cells(0).Value & "'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtcomplaintname.Text = reader(0)
            DateTimePicker1.Text = reader(1)
            DateTimePicker3.Text = reader(2)
            txtnameon.Text = reader(3)
            txtaddresson.Text = reader(4)
            txtcontacton.Text = reader(5)
            txtoccupasionon.Text = reader(6)
            txtcomplaintabout.Text = reader(7)
            DateTimePicker2.Text = reader(8)
            nameby.Text = reader(9)
            txtaddressby.Text = reader(10)
            txtcontactby.Text = reader(11)
            txtoccupasionby.Text = reader(12)
            If reader(13) = "Crime" Then
                RadioButton1.Checked = True
            ElseIf reader(13) = "Law and Order" Then
                RadioButton2.Checked = True
            Else
                RadioButton3.Checked = True
            End If
            txtarea.Text = reader(14)            ',[comparea]
            txtpolicestation.Text = reader(15) ',[policestation]
        End While
        connection_close()
        'uploads
        uploads()
        datagrid_admin()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim msgbutton As DialogResult
        msgbutton = MessageBox.Show("Are you sure you want to Delete this record?", "Are you sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If msgbutton = Windows.Forms.DialogResult.Yes Then
            connectiondb()
            cmd = New SqlCommand("delete from tblcomplaints where complaintno='" & txtcomplaintname.Text & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()

            connectiondb()
            cmd = New SqlCommand("delete from tblfiles where specid='" & txtcomplaintname.Text & "' AND form='Complaint'", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
        End If
        updatedelete()
    End Sub

    Public Sub datagrid_admin()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblcomplaints where comptype='" & vartype & "'", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(3), reader(9), reader(7))
        Loop
        connection_close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       updatedelete()
    End Sub

    Public Sub updatedelete()
        btnupdate.Visible = False
        btndelete.Visible = False
        Button2.Visible = True
        txtaddressby.Clear()
        txtaddresson.Clear()
        txtarea.Clear()
        txtcomplaintabout.Clear()
        txtcomplaintname.Clear()
        txtcontactby.Clear()
        txtcontacton.Clear()
        txtfilename.Clear()
        txtnameon.Clear()
        txtoccupasionby.Clear()
        txtoccupasionon.Clear()
        txtpolicestation.Clear()
        datagrid_admin()
        userids()
    End Sub


    Private Sub btndeletefile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeletefile.Click
        'If lstuploads.SelectedIndices.Count = 0 Then Return
        'Dim lvi As ListViewItem = lstuploads.SelectedItems(0)
        Dim msgbutton As DialogResult
        msgbutton = MessageBox.Show("Are you sure you want to Delete this record?", "Are you sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If msgbutton = Windows.Forms.DialogResult.Yes Then
            connectiondb()
            cmd = New SqlCommand("delete from tblfiles where filepath='" & lstuploads.SelectedItems(0).SubItems(2).Text & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("File Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()
        End If
        uploads()
    End Sub

    Private Sub lstuploads_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstuploads.DoubleClick
        'If lstuploads.SelectedIndices.Count = 0 Then Return
        'Dim lvi As ListViewItem = lstuploads.SelectedItems(0)
        'MessageBox.Show(lvi.Text + " has been selected.")

        System.Diagnostics.Process.Start(Application.StartupPath.ToString & "\uploads\" & lstuploads.SelectedItems(0).SubItems(2).Text)

        'Dim I As Integer
        'For I = 0 To lstuploads.SelectedItems.Count - 1
        '    MsgBox(lstuploads.SelectedItems(I).Text)
        'Next


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dbconf()
        Dim rpt As New CrystalReport1
        'MessageBox.Show(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        rpt.RecordSelectionFormula = "{command.compid}=" & DataGridView1.CurrentRow.Cells(0).Value
        frmviewreport.Text = "Client wise Records"
        frmviewreport.CrystalReportViewer1.ReportSource = rpt
        frmviewreport.CrystalReportViewer1.Refresh()
        frmviewreport.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class