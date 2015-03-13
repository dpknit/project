Imports System.Data.SqlClient
Imports System.IO
Public Class frmstatus
    Dim filepath As String
    Dim uploadfilename, randomvalue As String
    Private Sub frmstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userids()
        datagrid_admin()
        uploads()
    End Sub
    Sub userids()
        connectiondb()
        sql = "Select MAX(statusid) from tblstatus"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtstatusid.Text = reader.Item(0) + 1
            End While
        Catch ex As Exception
            MsgBox("Invalid Userid! ")
        End Try
        connection_close()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim strvar As String
        If RadioButton1.Checked = True Then
            strvar = "Running"
        Else
            strvar = "Suspended"
        End If
        'inserts login record
        connectiondb()
        cmd = New SqlCommand("Insert Into tblstatus values('" & txtcomplaint.Text & "','" & txtfir.Text & "','" & txtchargesheet.Text & _
                            "','" & txtcourt.Text & "','" & txtjudge.Text & _
                            "','" & txtpolice.Text & "','" & txtstation.Text & _
                            "','" & txtsuspect.Text & "','" & 1 & _
                            "','" & txtcase.Text & "','" & txtproved.Text & _
                            "','" & strvar & "','" & txtfullreport.Text & _
                            "',convert(date,'" & DateTimePicker3.Text & "',103))", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Status Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        filepath = OpenFileDialog1.FileName.ToString()
        uploadfilename = Path.GetFileName(filepath)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
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
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','frmstatus','" & randomv & "','" & txtcomplaint.Text & "')", cnn)
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
        cmd = New SqlCommand("Select * from tblfiles where specid ='" & txtstatusid.Text & "' AND form='frmstatus'", cnn)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim strvar As String
        If RadioButton1.Checked = True Then
            strvar = "Running"
        Else
            strvar = "Suspended"
        End If

        connectiondb()
        cmd = New SqlCommand("Update tblstatus Set Firno='" & txtfir.Text & "',Chargesheetno='" & txtchargesheet.Text & _
                             "',Court='" & txtcourt.Text & "',Judge='" & txtjudge.Text & "',Policeincharge='" & _
                             txtpolice.Text & "',Stationjuridiction='" & txtstation.Text & _
                             "',Suspectname='" & txtsuspect.Text & "',Address='" & txtaddress.Text & "',Caserecorded='" & txtcase.Text & _
                             "',Provedtillnow='" & txtproved.Text & "',Status='" & strvar & _
                             "',Fullreport='" & txtfullreport.Text & "',Nextcourthearing=convert(date,'" & DateTimePicker3.Text & _
                             "',103) Where statusid=" & txtstatusid.Text, cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Record Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        btndelete.Visible = True
        btnupdate.Visible = True
        Button5.Visible = True
        Button2.Visible = True
        Button8.Visible = False
        connectiondb()
        cmd = New SqlCommand("Select * from tblstatus where statusid ='" & DataGridView1.CurrentRow.Cells(0).Value & "'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtcomplaint.Text = reader(0)     '[Complaintno]()
            txtfir.Text = reader(1) '          ,[Firno]
            txtchargesheet.Text = reader(2) '          ,[Chargesheetno]
            txtcourt.Text = reader(3) '          ,[Court]
            txtjudge.Text = reader(4) '          ,[Judge]
            txtpolice.Text = reader(5) '          ,[Policeincharge]
            txtstation.Text = reader(6) '          ,[Stationjuridiction]
            txtsuspect.Text = reader(7) '          ,[Suspectname]
            txtaddress.Text = reader(8) '          ,[Address]
            txtcase.Text = reader(9) '          ,[Caserecorded]
            txtproved.Text = reader(10) '          ,[Provedtillnow]

            '          ,[Status]
            If reader(11) = "Running" Then
                RadioButton1.Checked = True
            Else
                RadioButton2.Checked = False
            End If
            txtfullreport.Text = reader(12) '          ,[Fullreport]
            txtcourt.Text = reader(13) '          ,[Nextcourthearing]
            txtstatusid.Text = reader(14)
        End While
        connection_close()
        'uploads
        uploads()
        datagrid_admin()
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msgbutton As DialogResult
        msgbutton = MessageBox.Show("Are you sure you want to Delete this record?", "Are you sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If msgbutton = Windows.Forms.DialogResult.Yes Then
            connectiondb()
            cmd = New SqlCommand("delete from tblstatus where statusid='" & txtstatusid.Text & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()

            connectiondb()
            cmd = New SqlCommand("delete from tblfiles where specid='" & txtcomplaint.Text & "' AND form='frmstatus'", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
        End If
        updatedelete()
    End Sub


    Public Sub datagrid_admin()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblstatus", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(14), reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7))
        Loop
        connection_close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        updatedelete()
    End Sub

    Public Sub updatedelete()
        btnupdate.Visible = False
        btndelete.Visible = False
        Button2.Visible = True
        txtaddress.Clear()
        txtcase.Clear()
        txtchargesheet.Clear()
        txtcomplaint.Clear()
        txtcourt.Clear()
        txtfilename.Clear()
        txtfir.Clear()
        txtfullreport.Clear()
        datagrid_admin()
        userids()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
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

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        'If lstuploads.SelectedIndices.Count = 0 Then Return
        'Dim lvi As ListViewItem = lstuploads.SelectedItems(0)
        'MessageBox.Show(lvi.Text + " has been selected.")

        System.Diagnostics.Process.Start(Application.StartupPath.ToString & "\uploads\" & lstuploads.SelectedItems(0).SubItems(2).Text)

        'Dim I As Integer
        'For I = 0 To lstuploads.SelectedItems.Count - 1
        '    MsgBox(lstuploads.SelectedItems(I).Text)
        'Next

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        complaintview = "frmstatus"
        frmcomplaintselect.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        firview = "frmstatus"
        frmfirselect.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        chargesheetview = "frmstatus"
        frmchargesheetselected.Show()
    End Sub
End Class