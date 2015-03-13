<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstrike
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label14 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtreport = New System.Windows.Forms.TextBox
        Me.txtpermission = New System.Windows.Forms.TextBox
        Me.txttask = New System.Windows.Forms.TextBox
        Me.txtaction = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtkind = New System.Windows.Forms.ComboBox
        Me.txtorganization = New System.Windows.Forms.TextBox
        Me.txtstrike = New System.Windows.Forms.TextBox
        Me.txtplace = New System.Windows.Forms.TextBox
        Me.txtaganist = New System.Windows.Forms.TextBox
        Me.txtreason = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btndeletefile = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lstuploads = New System.Windows.Forms.ListView
        Me.txtfilename = New System.Windows.Forms.TextBox
        Me.btnupload = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(899, 434)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.txtreport)
        Me.TabPage1.Controls.Add(Me.txtpermission)
        Me.TabPage1.Controls.Add(Me.txttask)
        Me.TabPage1.Controls.Add(Me.txtaction)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtkind)
        Me.TabPage1.Controls.Add(Me.txtorganization)
        Me.TabPage1.Controls.Add(Me.txtstrike)
        Me.TabPage1.Controls.Add(Me.txtplace)
        Me.TabPage1.Controls.Add(Me.txtaganist)
        Me.TabPage1.Controls.Add(Me.txtreason)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(891, 408)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ADD"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(506, 227)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Label14"
        Me.Label14.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(233, 144)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 76
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(233, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 75
        '
        'txtreport
        '
        Me.txtreport.Location = New System.Drawing.Point(233, 372)
        Me.txtreport.Name = "txtreport"
        Me.txtreport.Size = New System.Drawing.Size(227, 20)
        Me.txtreport.TabIndex = 70
        '
        'txtpermission
        '
        Me.txtpermission.Location = New System.Drawing.Point(233, 346)
        Me.txtpermission.Name = "txtpermission"
        Me.txtpermission.Size = New System.Drawing.Size(227, 20)
        Me.txtpermission.TabIndex = 69
        '
        'txttask
        '
        Me.txttask.Location = New System.Drawing.Point(233, 313)
        Me.txttask.Name = "txttask"
        Me.txttask.Size = New System.Drawing.Size(227, 20)
        Me.txttask.TabIndex = 68
        '
        'txtaction
        '
        Me.txtaction.Location = New System.Drawing.Point(233, 287)
        Me.txtaction.Name = "txtaction"
        Me.txtaction.Size = New System.Drawing.Size(227, 20)
        Me.txtaction.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 375)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "REPORT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "PERMISSION GRANTED OR NOT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "TASK FORCE ASSIGNED"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "ACTION TAKEN"
        '
        'txtkind
        '
        Me.txtkind.FormattingEnabled = True
        Me.txtkind.Items.AddRange(New Object() {"AREA", "DISTRICT", "STATE", "NATIONAL"})
        Me.txtkind.Location = New System.Drawing.Point(233, 257)
        Me.txtkind.Name = "txtkind"
        Me.txtkind.Size = New System.Drawing.Size(222, 21)
        Me.txtkind.TabIndex = 62
        '
        'txtorganization
        '
        Me.txtorganization.Location = New System.Drawing.Point(233, 45)
        Me.txtorganization.Name = "txtorganization"
        Me.txtorganization.Size = New System.Drawing.Size(227, 20)
        Me.txtorganization.TabIndex = 59
        '
        'txtstrike
        '
        Me.txtstrike.Location = New System.Drawing.Point(233, 77)
        Me.txtstrike.Name = "txtstrike"
        Me.txtstrike.Size = New System.Drawing.Size(227, 20)
        Me.txtstrike.TabIndex = 58
        '
        'txtplace
        '
        Me.txtplace.Location = New System.Drawing.Point(233, 112)
        Me.txtplace.Name = "txtplace"
        Me.txtplace.Size = New System.Drawing.Size(227, 20)
        Me.txtplace.TabIndex = 57
        '
        'txtaganist
        '
        Me.txtaganist.Location = New System.Drawing.Point(233, 221)
        Me.txtaganist.Name = "txtaganist"
        Me.txtaganist.Size = New System.Drawing.Size(227, 20)
        Me.txtaganist.TabIndex = 56
        '
        'txtreason
        '
        Me.txtreason.Location = New System.Drawing.Point(233, 183)
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(227, 20)
        Me.txtreason.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "KIND OF STRIKE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "AGANIST WHOM STRIKE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "REASON OF STRIKE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "DATE AND TIME OF STRIKE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "STRIKE REGUARDING"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "PLACE OF STRIKE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "ORGANIZATION/COMMUNITY NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "DATE"
        '
        'btndeletefile
        '
        Me.btndeletefile.Location = New System.Drawing.Point(299, 62)
        Me.btndeletefile.Name = "btndeletefile"
        Me.btndeletefile.Size = New System.Drawing.Size(65, 82)
        Me.btndeletefile.TabIndex = 73
        Me.btndeletefile.Text = "Click Here to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Files"
        Me.btndeletefile.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(503, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "File Name"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(503, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(46, 13)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Uploads"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstuploads)
        Me.GroupBox2.Controls.Add(Me.txtfilename)
        Me.GroupBox2.Controls.Add(Me.btnupload)
        Me.GroupBox2.Controls.Add(Me.btndeletefile)
        Me.GroupBox2.Location = New System.Drawing.Point(494, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 204)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        '
        'lstuploads
        '
        Me.lstuploads.Location = New System.Drawing.Point(61, 60)
        Me.lstuploads.Name = "lstuploads"
        Me.lstuploads.Size = New System.Drawing.Size(232, 125)
        Me.lstuploads.TabIndex = 51
        Me.lstuploads.UseCompatibleStateImageBehavior = False
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(69, 11)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(177, 20)
        Me.txtfilename.TabIndex = 48
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(274, 14)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(79, 23)
        Me.btnupload.TabIndex = 47
        Me.btnupload.Text = "Upload File"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(891, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VIEW"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(868, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.HeaderText = "idd"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "DATE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "STRIKE REGUARDING"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PLACE OF STRIKE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "ACTION TAKEN"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TASK FORCE"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PERMISSION"
        Me.Column6.Name = "Column6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 460)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 63)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(214, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 30)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(94, 14)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(114, 30)
        Me.btndelete.TabIndex = 47
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        Me.btndelete.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(6, 14)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(82, 30)
        Me.btnupdate.TabIndex = 46
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        Me.btnupdate.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(678, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 33)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(449, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 30)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "ADD  STRIKE RECORD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmstrike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 534)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmstrike"
        Me.Text = "frmstrike"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtreport As System.Windows.Forms.TextBox
    Friend WithEvents txtpermission As System.Windows.Forms.TextBox
    Friend WithEvents txttask As System.Windows.Forms.TextBox
    Friend WithEvents txtaction As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtkind As System.Windows.Forms.ComboBox
    Friend WithEvents txtorganization As System.Windows.Forms.TextBox
    Friend WithEvents txtstrike As System.Windows.Forms.TextBox
    Friend WithEvents txtplace As System.Windows.Forms.TextBox
    Friend WithEvents txtaganist As System.Windows.Forms.TextBox
    Friend WithEvents txtreason As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btndeletefile As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstuploads As System.Windows.Forms.ListView
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents btnupload As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
