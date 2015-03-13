Imports System.Data.SqlClient
Imports System.IO
Public Class frmcriminal
    Dim filepath As String
    Dim uploadfilename, randomvalue, uploadimage As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim str As String
        If RadioButton1.Checked = True Then
            str = "Yes"
        Else
            str = "No"
        End If

        Dim gender As String
        If RadioButton3.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        connectiondb()
        cmd = New SqlCommand("Insert Into tblcriminals values('" & txtcomplaintno.Text & _
                             "','" & txtcriminalname.Text & _
                             "','" & txtnick.Text & "','" & txtage.Text & _
                             "','" & txtaddress.Text & _
                             "','" & txtoccupation.Text & "','" & uploadimage & _
                             "','" & txtcriminaltype.Text & _
                             "',convert(date,'" & DateTimePicker2.Text & "',103),'" & _
                             str & "',convert(date,'" & dtearrestdate.Text & "',103),'" & _
                             txtbirthmark.Text & "','gender','" & txtfathersname.Text & "','" & _
                             txtmaritalst.Text & "')", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Criminal Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmcriminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userids()
        datagrid_admin()
        uploads()
    End Sub
    Sub userids()
        connectiondb()
        sql = "Select MAX(criminalno) from tblcriminals"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtcriminalno.Text = reader.Item(0) + 1
            End While
        Catch ex As Exception
            MsgBox("Invalid Userid! ")
        End Try
        connection_close()
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
        cmd = New SqlCommand("Select * from tblfiles where specid ='" & txtcriminalno.Text & "' AND form='Criminal'", cnn)
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','Criminal','" & randomv & "','" & txtcriminalno.Text & "')", cnn)
        i = cmd.ExecuteNonQuery()
        connection_close()
        uploads()
        txtfilename.Clear()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim str As String
        If RadioButton1.Checked = True Then
            str = "Yes"
        Else
            str = "No"
        End If

        Dim gender As String
        If RadioButton3.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        connectiondb()
        cmd = New SqlCommand("UPDATE tblcriminals SET complaintno = '" & txtcomplaintno.Text & "'" & _
      ",criminalname =  '" & txtcriminalname.Text & "'" & _
      ",nickname = '" & txtnick.Text & "'" & _
",age = '" & txtage.Text & "'" & _
 "     ,address = '" & txtaddress.Text & "'" & _
  "    ,occupation = '" & txtoccupation.Text & "'" & _
    "  ,crimetype = '" & txtcriminaltype.Text & "'" & _
     " ,crimedate = '" & DateTimePicker2.Text & "'" & _
      ",mostwanted = '" & str & "'" & _
      ",arrestdate = '" & dtearrestdate.Text & "'" & _
"      ,birthmark = '" & txtbirthmark.Text & "'" & _
  "    ,sex = '" & gender & "'" & _
   "   ,fatherhusbandname = '" & txtfathersname.Text & "'" & _
    "  ,maritalstatus = '" & txtmaritalst.Text & "'" & _
" WHERE criminalno=" & txtcriminalno.Text, cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Criminal record updated successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick

        Dim str As String
        Dim gender As String

        btndelete.Visible = True
        btnupdate.Visible = True
        Button2.Visible = False
        connectiondb()
        cmd = New SqlCommand("Select * from tblcriminals where criminalno ='" & DataGridView1.CurrentRow.Cells(0).Value & "'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtcriminalno.Text = reader(0)  '[criminalno]()
            txtcomplaintno.Text = reader(1) ' ,[complaintno]
            txtcriminalname.Text = reader(2) ' ,[criminalname]
            txtnick.Text = reader(3) ',[nickname]
            txtage.Text = reader(4) ',[age]
            txtaddress.Text = reader(5) ',[address]
            txtoccupation.Text = reader(6) ',[occupation]
            uploadimage = reader(7) ',[image]

            txtcriminaltype.Text = reader(8)          ',[crimetype]
            DateTimePicker2.Text = reader(9) ',[crimedate]

            str = reader(10) ',[mostwanted]
            If str = "Yes" Then
                RadioButton1.Checked = True
            Else
                RadioButton1.Checked = False
            End If

            dtearrestdate.Text = reader(11)           ',[arrestdate]
            txtbirthmark.Text = reader(12) ',[birthmark]
            ',[sex]
            gender = reader(13)
            If gender = "Male" Then
                RadioButton3.Checked = True
            Else
                RadioButton3.Checked = False
            End If
            txtfathersname.Text = reader(14)           ',[fatherhusbandname]
            txtmaritalst.Text = reader(15) ',[maritalstatus]
        End While
        connection_close()
        Dim strimg As String
        strimg = ""
        connectiondb()
        cmd = New SqlCommand("Select * from tblfiles where specid ='" & DataGridView1.CurrentRow.Cells(0).Value & "' AND form='Criminalimage'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            strimg = reader(3)
        End While
        connection_close()
        PictureBox1.Image = Image.FromFile(Application.StartupPath.ToString & "\images\" & strimg)

        'uploads
        uploads()
        datagrid_admin()

        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim msgbutton As DialogResult
        msgbutton = MessageBox.Show("Are you sure you want to Delete this record?", "Are you sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If msgbutton = Windows.Forms.DialogResult.Yes Then
            connectiondb()
            cmd = New SqlCommand("delete from tblcriminals where criminalno='" & txtcriminalno.Text & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()

            connectiondb()
            cmd = New SqlCommand("delete from tblfiles where specid='" & txtcriminalno.Text & "' AND form='Criminal'", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
        End If
        updatedelete()
    End Sub

    Public Sub datagrid_admin()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblcriminals", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(8), reader(11), reader(10))
        Loop
        connection_close()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        updatedelete()
    End Sub

    Public Sub updatedelete()
        btnupdate.Visible = False
        btndelete.Visible = False
        Button2.Visible = True
        txtaddress.Clear()
        txtage.Clear()
        txtbirthmark.Clear()
        txtcomplaintno.Clear()
        txtcriminalname.Clear()
        txtcriminalno.Clear()
        txtcriminaltype.Clear()
        txtfathersname.Clear()
        txtfathersname.Clear()
        txtfilename.Clear()
        txtnick.Clear()
        txtoccupation.Clear()
        PictureBox1.Image = Image.FromFile(Application.StartupPath.ToString & "\images\blank.jpg")
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


    Private Sub btnimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimage.Click
        '//////////////////// image uploading program

        OpenFileDialog2.Title = "Please select image to upload"
        OpenFileDialog2.InitialDirectory = "c:\"
        OpenFileDialog2.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
        OpenFileDialog2.FilterIndex = 2
        OpenFileDialog2.RestoreDirectory = True
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
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
        strm = OpenFileDialog2.OpenFile()
        filepath = OpenFileDialog2.FileName.ToString()
        FileToCopy = filepath
        randomv = randomvalue & uploadfilename
        NewCopy = Application.StartupPath.ToString & "\images\" & randomv
        MessageBox.Show("You are uploading " & uploadfilename & " image")
        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy)
            MsgBox("Image Uploaded Uploaded Successfully...")
        End If
        uploadimage = randomv
        PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath.ToString & "\images\" & uploadimage)

        connectiondb()
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','Criminalimage','" & randomv & "','" & txtcriminalno.Text & "')", cnn)
        i = cmd.ExecuteNonQuery()
        connection_close()
        uploads()
        txtfilename.Clear()
    End Sub

    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog2.OpenFile()
        filepath = OpenFileDialog2.FileName.ToString()
        uploadfilename = Path.GetFileName(filepath)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        complaintview = "frmcriminal"
        frmcomplaintselect.Show()
    End Sub
End Class