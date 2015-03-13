Imports System.Data.SqlClient
Imports System.IO
Public Class frmprofile

    Dim filepath As String
    Dim uploadfilename, randomvalue As String

    Dim uploadimage As String
    Private Sub frmprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If usertype = "ADMIN" Then
            btnadd.Enabled = False
        End If

        connectiondb()
        sql = "Select * from tbldesg"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            cmbdesignation.Items.Add(reader(1))
        End While
        connection_close()

        userprofile()
        uploads()
    End Sub

    Sub uploads()
        connectiondb()
        cmd = New SqlCommand("Select * from tblfiles where filename ='" & sessionuser & "' AND form='ProfileImage'", cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()
            'PictureBox1.ImageLocation = "/uploads/" & reader(3)
            'Image.FromFile(Application.StartupPath.ToString & "\uploads\" & reader(3))
            PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath.ToString & "\images\" & reader(3))
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        End While
        connection_close()
    End Sub

    Sub userprofile()
        connectiondb()
        sql = "Select * from tbllogin where username='" & sessionuser & "'"
        Try
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                txtfirstname.Text = reader(4)
                txtlastname.Text = reader(5)
                txtusername.Text = reader(1)
                txtusername1.Text = reader(1)
                cmbdesignation.Text = reader(5)
            End While
        Catch ex As Exception
            MsgBox("Invalid Userid! ")
        End Try
        connection_close()

        connectiondb()
        sql = "Select * from tblempprofile where username='" & sessionuser & "'"
        cmd = New SqlCommand(sql, cnn)
        reader = cmd.ExecuteReader()
        While reader.Read()

            If reader(0) Is DBNull.Value Then
                txtaddress.Text = ""
            Else
                txtaddress.Text = reader(2)
            End If
            If reader(3) Is DBNull.Value Then

            Else
                DateTimePicker1.Text = reader(3)
            End If

            If reader(5) Is DBNull.Value Then

            Else
                If reader(5) = "Male" Then
                    ComboBox1.SelectedIndex = 0
                Else
                    ComboBox1.SelectedIndex = 1
                End If
            End If
            If reader(4) Is DBNull.Value Then

            Else
                txtage.Text = reader(4)
            End If
            If reader(4) Is DBNull.Value Then

            Else
                txtfathername.Text = reader(7)
            End If
            If reader(8) Is DBNull.Value Then

            Else
                txtcontno.Text = reader(8)
            End If
            If reader(6) Is DBNull.Value Then

            Else
                txtblood.Text = reader(6)
            End If
            If reader(9) Is DBNull.Value Then

            Else
                DateTimePicker2.Text = reader(9)
            End If

            If reader(10) Is DBNull.Value Then

            Else
                DateTimePicker3.Text = reader(10)
            End If

            If reader(11) Is DBNull.Value Then

            Else
                txtsalary.Text = reader(11)
            End If

            If reader(12) Is DBNull.Value Then

            Else
                txtleave.Text = reader(12)
            End If

        End While
        connection_close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click


        connectiondb()
        cmd = New SqlCommand("Update tbllogin Set designation='" & cmbdesignation.Text & "' Where username='" & Val(txtusername.Text) & "'", cnn)
        i = cmd.ExecuteNonQuery()
        connection_close()

        connectiondb()
        cmd = New SqlCommand("Update tblempprofile Set dor=convert(date,'" & DateTimePicker1.Text & _
                             "',103),basicpay='" & txtsalary.Text & "',leavesgranted='" & txtleave.Text & "'", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Employee Profile Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update item!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()


    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '      [empno]()
        ',[username]
        ',[address]
        ',[dob]
        ',[age]
        ',[sex]
        ',[bloodgroup]
        ',[fathersname]
        ',[contactno]
        ',[doj]
        ',[dor]
        ',[basicpay]
        ',[leavesgranted]
        ',[proimg]
        connectiondb()
        cmd = New SqlCommand("Update tblempprofile Set address='" & txtaddress.Text & _
                             "',dob='" & DateTimePicker1.Text & "',age='" & txtage.Text & "',sex='" & _
                             ComboBox1.Text & "',bloodgroup='" & txtblood.Text & _
                             "',fathersname='" & txtfathername.Text & _
                             "',contactno='" & txtcontno.Text & "',doj='" & DateTimePicker2.Text & _
                             "',dor='" & DateTimePicker3.Text & "',basicpay='" & txtsalary.Text & "',leavesgranted='" & txtleave.Text & _
                             "' WHERE username='" & sessionuser & "'", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("User Profile Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()


        'connectiondb()
        'cmd = New SqlCommand("Update tblempprofile Set address='" & txtaddress.Text & "',dob='" & DateTimePicker1.Text & "',sex= '" & ComboBox1.Text & "' Where username=" & Val(txtusername.Text), cnn)
        'i = cmd.ExecuteNonQuery()
        'If i > 0 Then
        '    MessageBox.Show("user profile Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    MessageBox.Show("Failed to update item!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        'connection_close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        connectiondb()
        cmd = New SqlCommand("Update tbllogin Set password='" & txtnewpass.Text & "' WHERE username='" & sessionuser & "'", cnn)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MessageBox.Show("Password Updated Successfully.", "Process Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update record!", "Failed...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        connection_close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '//////////////////// image uploading program

        OpenFileDialog1.Title = "Please select image to upload"
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
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
        NewCopy = Application.StartupPath.ToString & "\images\" & randomv
        MessageBox.Show("You are uploading " & uploadfilename & " image")
        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy)
            MsgBox("Image Uploaded Uploaded Successfully...")
        End If
        uploadimage = randomv
        PictureBox1.Image = Image.FromFile(Application.StartupPath.ToString & "\images\" & uploadimage)

        connectiondb()
        cmd = New SqlCommand("Insert Into tblfiles values('" & sessionuser & "','ProfileImage','" & randomv & "','" & 123 & "')", cnn)
        i = cmd.ExecuteNonQuery()
        connection_close()
        uploads()
        ' txtfilename.Clear()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        filepath = OpenFileDialog1.FileName.ToString()
        uploadfilename = Path.GetFileName(filepath)
    End Sub
End Class