Imports System.Data.SqlClient
Imports System.IO
Public Class frmchargesheet
    Dim filepath As String
    Dim uploadfilename, randomvalue As String
    Private Sub frmchargesheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userids()
        datagrid_admin()
        uploads()
    End Sub

    Sub userids()
        connectiondb()
        sql = "Select MAX(chargesheetno) from tblchargesheet"
        txtchargshetno.Text = 1
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtchargshetno.Text = reader.Item(0) + 1
            End While
        Catch ex As Exception
            MsgBox("Invalid ID! ")
        End Try
        connection_close()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        filepath = OpenFileDialog1.FileName.ToString()
        uploadfilename = Path.GetFileName(filepath)
    End Sub

    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','Chargesheet','" & randomv & "','" & txtchargshetno.Text & "')", cnn)
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
        cmd = New SqlCommand("Select * from tblfiles where specid ='" & txtchargshetno.Text & "' AND form='Chargesheet'", cnn)
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
        TabControl1.SelectedTab = TabPage1
        btndelete.Visible = True
        btnupdate.Visible = True
        Button2.Visible = False
        connectiondb()
        cmd = New SqlCommand("Select * from tblchargesheet where chargesheetno ='" & DataGridView1.CurrentRow.Cells(0).Value & "'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtchargshetno.Text = reader(0)
            txtpolicestationname.Text = reader(1) ',[policestation]
            DateTimePicker1.Text = reader(2) ',[chargesheetdate]
            txtfirno.Text = reader(3) ',[firno]
            txtdistrict.Text = reader(4) ',[district]
            txtinfoname.Text = reader(5) ',[infoname]
            txtinfoadd.Text = reader(6) ',[infadd]
            txtinfooccup.Text = reader(7) ',[infooccupation]
            txtinfoprticular.Text = reader(8) ',[infoparticular]
            txtaccusname.Text = reader(9) ',[accusname]
            txtaccusadd.Text = reader(10) ',[accuseadd]
            txtaccussex.Text = reader(11) ',[accussex]
            txtaccusage.Text = reader(12) ',[accusage]
            txtaccusoccup.Text = reader(13) ',[accusoccupation]
            txtaccusaction.Text = reader(14) ',[accuscurstatn]
            txtaccusaction.Text = reader(15) ',[accusaction]
            txtwitnesname.Text = reader(16) ',[witnessname]
            txtwitnesadd.Text = reader(17) ',[witnessaddress]
            txtwitnesoccup.Text = reader(18) ',[witnessoccupation]
            txtcomplaintno.Text = reader(19) ',[complaintno]

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
            cmd = New SqlCommand("delete from tblchargesheet where chargesheetno='" & txtchargshetno.Text & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Charge sheet Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()

            connectiondb()
            cmd = New SqlCommand("delete from tblfiles where specid='" & txtchargshetno.Text & "' AND form='Chargesheet'", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
        End If
        updatedelete()
    End Sub


    Public Sub datagrid_admin()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblchargesheet", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(19), reader(3), reader(2), reader(5), reader(9), reader(16))
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
        txtaccusaction.Clear()
        txtaccusadd.Clear()
        txtaccusage.Clear()
        txtaccuscurntstation.Clear()
        txtaccusname.Clear()
        txtaccusoccup.Clear()
        txtaccussex.Clear()
        txtchargshetno.Clear()
        txtcomplaintno.Clear()
        txtdistrict.Clear()
        txtfilename.Clear()
        txtfirno.Clear()
        txtinfoadd.Clear()
        txtinfoname.Clear()
        txtinfooccup.Clear()
        txtinfoprticular.Clear()
        txtpolicestationname.Clear()
        txtwitnesadd.Clear()
        txtwitnesname.Clear()
        txtwitnesoccup.Clear()
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

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'inserts login record
        connectiondb()
        cmd = New SqlCommand("INSERT INTO tblchargesheet VALUES('" & txtpolicestationname.Text & "',convert(date,'" & _
            DateTimePicker1.Text & "',103),'" & _
            txtfirno.Text & "','" & _
   txtdistrict.Text & "','" & _
    txtinfoname.Text & "','" & _
   txtinfoadd.Text & "','" & _
   txtinfooccup.Text & "','" & _
     txtinfoprticular.Text & "','" & _
    txtaccusname.Text & "','" & _
   txtaccusadd.Text & "','" & _
     txtaccussex.Text & "','" & _
  txtaccusage.Text & "','" & _
   txtaccusoccup.Text & "','" & _
    txtaccusoccup.Text & "','" & _
      txtaccusaction.Text & "','" & _
     txtwitnesname.Text & "','" & _
     txtwitnesadd.Text & "','" & _
      txtwitnesoccup.Text & "','" & _
       txtcomplaintno.Text & "')", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Chargesheet Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        connectiondb()
        cmd = New SqlCommand("Update tblchargesheet Set policestation='" & txtpolicestationname.Text & _
      "',chargesheetdate = convert(date,'" & DateTimePicker1.Text & _
      "',103),firno = '" & txtfirno.Text & _
      "',district = '" & txtdistrict.Text & _
      "',infoname = '" & txtinfoname.Text & _
      "',infadd = '" & txtinfoadd.Text & _
      "',infooccupation = '" & txtinfooccup.Text & _
      "',infoparticular = '" & txtinfoprticular.Text & _
      "',accusname = '" & txtaccusname.Text & _
      "',accuseadd = '" & txtaccusadd.Text & _
      "',accussex = '" & txtaccussex.Text & _
      "',accusage ='" & txtaccusage.Text & _
      "',accusoccupation = '" & txtaccusoccup.Text & _
      "',accuscurstatn ='" & txtaccuscurntstation.Text & _
      "',accusaction = '" & txtaccusaction.Text & _
      "',witnessname = '" & txtwitnesname.Text & _
      "',witnessaddress = '" & txtwitnesadd.Text & _
      "',witnessoccupation = '" & txtwitnesoccup.Text & _
      "',complaintno = '" & txtcomplaintno.Text & _
        "' Where chargesheetno='" & txtchargshetno.Text & "'", cnn)



        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Chargesheet record Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        complaintview = "frmchargesheet"
        frmcomplaintselect.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        firview = "frmchargesheet"
        frmfirselect.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        crminalview = "frmchargesheet"
        frmcriminalselect.Show()
    End Sub
End Class