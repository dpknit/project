Imports System.Data.SqlClient
Imports System.IO
Public Class frmfir
    Dim filepath As String
    Dim uploadfilename, randomvalue As String

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


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmfir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userids()
        datagrid_admin()
        uploads()
    End Sub
    Sub userids()
        txtfirno.Text = 1
        connectiondb()
        sql = "Select MAX(firno) from tblfir"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtfirno.Text = reader.Item(0) + 1
        End While

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
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','FIR','" & randomv & "','" & txtfirno.Text & "')", cnn)
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
        cmd = New SqlCommand("Select * from tblfiles where specid ='" & txtfirno.Text & "' AND form='FIR'", cnn)
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


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        btndelete.Visible = True
        btnupdate.Visible = True
        Button2.Visible = False
        connectiondb()
        cmd = New SqlCommand("Select * from tblfir where firno ='" & DataGridView1.CurrentRow.Cells(0).Value & "'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtfirno.Text = reader(0)
            txtpolicestation.Text = reader(1)
            DateTimePicker1.Text = reader(2).ToString
            txtdistrict.Text = reader(3)
            txttype.Text = reader(4)
            txtstate.Text = reader(5)
            txtact.Text = reader(6)
            DateTimePicker3.Text = reader(7)
            DateTimePicker2.Text = reader(8)
            DateTimePicker8.Text = reader(9).ToString
            DateTimePicker7.Text = reader(10)
            txtday.Text = reader(11)
            DateTimePicker4.Text = reader(12)
            txttime.Text = reader(13)
            txtgeneral.Text = reader(14)
            txttypeinformation.Text = reader(15)
            txtdirection.Text = reader(16)
            txtdirectionto.Text = reader(17)
            txtaddress.Text = reader(18)
            txtoutside.Text = reader(19)
            txtname.Text = reader(20)
            txtfather.Text = reader(21)
            DateTimePicker5.Text = reader(22)
            txtnationality.Text = reader(23)
            txtpassport.Text = reader(24)
            txtdateissue.Text = reader(25)
            txtplaceissue.Text = reader(26)
            txtoccupation.Text = reader(27)
            txtaddress.Text = reader(28)
            txtaccusename.Text = reader(29)
            DateTimePicker6.Text = reader(30)
            txtfather.Text = reader(31)
            txtsex.Text = reader(32)
            txtreason.Text = reader(33)
            txtparticulars.Text = reader(34)
            txtinguest.Text = reader(35)
            txtfirstinformation.Text = reader(36)
            txtaction.Text = reader(37)
        End While
        connection_close()
        'uploads
        uploads()
        datagrid_admin()
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
   
    End Sub
    Public Sub datagrid_admin()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblfir", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(29), reader(20), reader(2), reader(4))
        Loop
        connection_close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        updatedelete()
    End Sub
    Public Sub updatedelete()
        btnupdate.Visible = False
        btndelete.Visible = False
        Button2.Visible = True

        datagrid_admin()
        userids()
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

  
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        connectiondb()
        cmd = New SqlCommand("Insert Into tblfir values('" & txtpolicestation.Text & "',convert(date,'" & DateTimePicker1.Text & _
       "',103),'" & txtdistrict.Text & "','" & txttype.Text & _
     "','" & txtstate.Text & _
     "','" & txtact.Text & _
     "',convert(date,'" & DateTimePicker3.Text & _
    "',103),convert(date,'" & DateTimePicker2.Text & _
     "',104),convert(time(7),'" & DateTimePicker8.Text & _
     "',105),convert(time(7),'" & DateTimePicker7.Text & _
     "',105),'" & txtday.Text & _
     "',convert(date,'" & DateTimePicker4.Text & _
     "',103),'" & txttime.Text & _
     "','" & txtgeneral.Text & _
     "','" & txttypeinformation.Text & _
    "','" & txtdirection.Text & _
     "','" & txtdirectionto.Text & _
     "','" & txtaddress.Text & _
     "','" & txtoutside.Text & _
    "','" & txtname.Text & _
    "','" & txtfather.Text & _
    "',convert(date,'" & DateTimePicker5.Text & _
    "',103),'" & txtnationality.Text & _
     "','" & txtpassport.Text & _
   "','" & txtdateissue.Text & _
     "','" & txtplaceissue.Text & _
     "','" & txtoccupation.Text & _
 "','" & txtaddress.Text & _
    "','" & txtaccusename.Text & _
     "',convert(date,'" & DateTimePicker6.Text & _
     "',103),'" & txtfather.Text & _
   "','" & txtsex.Text & _
   "','" & txtreason.Text & _
     "','" & txtparticulars.Text & _
    "','" & txtpropertics.Text & _
 "','" & txtinguest.Text & _
    "','" & txtfirstinformation.Text & _
   "','" & txtaction.Text & "')", cnn)

        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("FIR Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub btnupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        connectiondb()
        cmd = New SqlCommand("Update tblfir SET policestation = '" & txtpolicestation.Text & _
       "',firdate = convert(date,'" & DateTimePicker1.Text & _
       "',103),district = '" & txtdistrict.Text & _
       "',type = '" & txttype.Text & _
     "',state='" & txtstate.Text & _
     "',act='" & txtact.Text & _
     "',occurancedateto=convert(date,'" & DateTimePicker3.Text & _
    "',103),occurancedatefrom=convert(date,'" & DateTimePicker2.Text & _
     "',103),occurancetimeto=convert(time(7),'" & DateTimePicker8.Text & _
     "',105),occurancetimefrom=convert(time(7),'" & DateTimePicker7.Text & _
     "',105),occuranceday='" & txtday.Text & _
     "',inforecdate=convert(date,'" & DateTimePicker4.Text & _
     "',103),infotime='" & txttime.Text & _
     "',genrefno='" & txtgeneral.Text & _
     "',infotype='" & txttypeinformation.Text & _
    "',occurancedistfrom='" & txtdirection.Text & _
     "',occurancedistto='" & txtdirectionto.Text & _
     "',occuranceaddress='" & txtaddress.Text & _
     "',outsidelimitpolicestation='" & txtoutside.Text & _
    "',complaintname='" & txtname.Text & _
    "',complaintfather='" & txtfather.Text & _
    "',complaintdate=convert(date,'" & DateTimePicker5.Text & _
    "',103),complaintnationality='" & txtnationality.Text & _
     "',complaintpassportno='" & txtpassport.Text & _
   "',complaintissuedate='" & txtdateissue.Text & _
     "',complaintissueplace='" & txtplaceissue.Text & _
     "',complaintoccupation='" & txtoccupation.Text & _
 "',complaintaddress='" & txtaddress.Text & _
    "',accusedname='" & txtaccusename.Text & _
     "',accuseddate=convert(date,'" & DateTimePicker6.Text & _
     "',103),accusedfather='" & txtfather.Text & _
   "',accousedsex='" & txtsex.Text & _
   "',delayreport='" & txtreason.Text & _
     "',paticularsstolen='" & txtparticulars.Text & _
    "',totalstolen='" & txtpropertics.Text & _
 "',casenoifany='" & txtinguest.Text & _
    "',fircontent='" & txtfirstinformation.Text & _
   "',actiontaken='" & txtaction.Text & _
"' Where firno=" & txtfirno.Text, cnn)

        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("FIR record Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtaccusename.Clear()
        txtact.Clear()
        txtaction.Clear()
        txtaddress.Clear()
        txtaddresss.Clear()
        txtday.Clear()
        txtdirection.Clear()
        txtdirectionto.Clear()
        txtdistrict.Clear()
        txtfather.Clear()
        txtfilename.Clear()
        txtfirno.Clear()
        txtfirstinformation.Clear()
        txtgeneral.Clear()
        txthusband.Clear()
        txtinguest.Clear()
        txtname.Clear()
        txtnationality.Clear()
        txtoccupation.Clear()
        txtoutside.Clear()
        txtparticulars.Clear()
        txtpassport.Clear()
        txtplaceissue.Clear()
        txtpolicestation.Clear()
        txtpropertics.Clear()
        txtreason.Clear()
        txttime.Clear()
        txttype.Clear()
        txttypeinformation.Clear()
    End Sub

    Private Sub btndelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim msgbutton As DialogResult
        msgbutton = MessageBox.Show("Are you sure you want to Delete this record?", "Are you sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If msgbutton = Windows.Forms.DialogResult.Yes Then
            connectiondb()
            cmd = New SqlCommand("delete from tblfir where complaintno='" & txtfirno.Text & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()

            connectiondb()
            cmd = New SqlCommand("delete from tblfiles where specid='" & txtfirno.Text & "' AND form='Complaint'", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
        End If
        updatedelete()
    End Sub
End Class