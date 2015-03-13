<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewprofile
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.slno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.designation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.userid = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.slno, Me.fname, Me.lname, Me.designation, Me.userid})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 410)
        Me.DataGridView1.TabIndex = 16
        '
        'slno
        '
        Me.slno.HeaderText = "SL.NO"
        Me.slno.Name = "slno"
        '
        'fname
        '
        Me.fname.HeaderText = "FIRST NAME"
        Me.fname.Name = "fname"
        '
        'lname
        '
        Me.lname.HeaderText = "LAST NAME"
        Me.lname.Name = "lname"
        '
        'designation
        '
        Me.designation.HeaderText = "DESIGNATION"
        Me.designation.Name = "designation"
        '
        'userid
        '
        Me.userid.HeaderText = "USER ID"
        Me.userid.Name = "userid"
        '
        'frmviewprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 426)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmviewprofile"
        Me.Text = "View Profile"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents slno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents designation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
