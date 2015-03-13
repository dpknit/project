Imports System.Data.SqlClient
Imports System.IO
Public Class frmmostwanted
    Dim filepath As String
    Dim uploadfilename, randomvalue, uploadimage As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       
     
        connectiondb()
        cmd = New SqlCommand("Insert Into tblmostwanted values('" & txtmwname.Text & _
                             "','" & txtnickname.Text & _
                             "','" & txtage.Text & "','" & txtsex.Text & _
                             "','" & txtdesp.Text & _
                             "','" & txtidmark.Text & "','" & txtoccup.Text & _
                             "','" & txtcasercrd.Text & "')", cnn)

        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Most Wanted Record Inserted Successfully", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add new admin record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub frmmostwanted_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userids()
        datagrid_admin()
        uploads()
    End Sub

    Sub userids()
        connectiondb()
        sql = "Select MAX(Mostwantedid) from tblmostwanted"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtmwid.Text = reader.Item(0) + 1
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
        cmd = New SqlCommand("Select * from tblfiles where specid ='" & txtmwid.Text & "' AND form='MostWanted'", cnn)
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
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','MostWanted','" & randomv & "','" & txtmwid.Text & "')", cnn)
        i = cmd.ExecuteNonQuery()
        connection_close()
        uploads()
        txtfilename.Clear()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        connectiondb()
        cmd = New SqlCommand("Update tblmostwanted Set Mostwantedname='" & txtmwname.Text & "',Nickname='" & txtnickname.Text & "',Age='" & txtage.Text & "',Sex='" & txtsex.Text & "',Description='" & txtdesp.Text & "',Identificationmark='" & txtidmark.Text & "',Occupation='" & txtoccup.Text & "',Casesrecorded='" & txtcasercrd.Text & "' Where Mostwantedid=" & txtmwid.Text, cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Most Wanted record Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
        updatedelete()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim str As String
        Dim gender As String

        btndelete.Visible = True
        btnupdate.Visible = True
        Button2.Visible = False
        connectiondb()
        cmd = New SqlCommand("Select * from tblmostwanted where Mostwantedid ='" & DataGridView1.CurrentRow.Cells(0).Value & "'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtmwid.Text = reader(0)  '      [Mostwantedid]()
            txtmwname.Text = reader(1) ',[Mostwantedname]
            txtnickname.Text = reader(2) ',[Nickname]
            txtage.Text = reader(3) ',[Age]
            txtsex.Text = reader(4) ',[Sex]
            txtdesp.Text = reader(5) ',[Description]
            txtidmark.Text = reader(6) ',[Identificationmark]
            txtoccup.Text = reader(7) ',[Occupation]
            txtcasercrd.Text = reader(8) ',[Casesrecorded]
        End While
        connection_close()
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
            cmd = New SqlCommand("delete from tblmostwanted where Mostwantedid='" & txtmwid.Text & "'", cnn)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record has been Deleted successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to Delete record!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connection_close()

            connectiondb()
            cmd = New SqlCommand("delete from tblfiles where specid='" & txtmwid.Text & "' AND form='MostWanted'", cnn)
            i = cmd.ExecuteNonQuery()
            connection_close()
        End If
        updatedelete()
    End Sub

    Public Sub datagrid_admin()
        DataGridView1.Rows.Clear()
        connectiondb()
        cmd = New SqlCommand("Select * From tblmostwanted", cnn)
        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        DataGridView1.Rows.Clear()
        Do While reader.Read = True
            DataGridView1.Rows.Add(reader(0), reader(1), reader(5), reader(7))
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
        txtage.Clear()
        txtcasercrd.Clear()
        txtdesp.Clear()
        txtfilename.Clear()
        txtidmark.Clear()
        txtmwid.Clear()
        txtmwname.Clear()
        txtnickname.Clear()
        txtoccup.Clear()
        txtsex.Clear()
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

    Private Sub lstuploads_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstuploads.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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
        cmd = New SqlCommand("Insert Into tblfiles values('" & txtfilename.Text & "','mostwantedimage','" & randomv & "','" & txtmwid.Text & "')", cnn)
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
End Class