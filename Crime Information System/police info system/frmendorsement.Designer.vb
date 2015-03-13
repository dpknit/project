<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmendorsement
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcomplaintno = New System.Windows.Forms.TextBox
        Me.txtaction = New System.Windows.Forms.TextBox
        Me.txtcomplaintgiven = New System.Windows.Forms.TextBox
        Me.txtcomplainton = New System.Windows.Forms.TextBox
        Me.txtcomplaintdetails = New System.Windows.Forms.TextBox
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPLAINT NO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "COMPLAINT DETAILS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "COMPLAINT ON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "COMPLIANT GIVEN BY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ACTION TAKEN"
        '
        'txtcomplaintno
        '
        Me.txtcomplaintno.Location = New System.Drawing.Point(165, 18)
        Me.txtcomplaintno.Name = "txtcomplaintno"
        Me.txtcomplaintno.Size = New System.Drawing.Size(166, 20)
        Me.txtcomplaintno.TabIndex = 5
        '
        'txtaction
        '
        Me.txtaction.Location = New System.Drawing.Point(165, 137)
        Me.txtaction.Multiline = True
        Me.txtaction.Name = "txtaction"
        Me.txtaction.Size = New System.Drawing.Size(166, 20)
        Me.txtaction.TabIndex = 6
        '
        'txtcomplaintgiven
        '
        Me.txtcomplaintgiven.Location = New System.Drawing.Point(165, 108)
        Me.txtcomplaintgiven.Name = "txtcomplaintgiven"
        Me.txtcomplaintgiven.Size = New System.Drawing.Size(166, 20)
        Me.txtcomplaintgiven.TabIndex = 7
        '
        'txtcomplainton
        '
        Me.txtcomplainton.Location = New System.Drawing.Point(165, 75)
        Me.txtcomplainton.Name = "txtcomplainton"
        Me.txtcomplainton.Size = New System.Drawing.Size(166, 20)
        Me.txtcomplainton.TabIndex = 8
        '
        'txtcomplaintdetails
        '
        Me.txtcomplaintdetails.Location = New System.Drawing.Point(165, 48)
        Me.txtcomplaintdetails.Multiline = True
        Me.txtcomplaintdetails.Name = "txtcomplaintdetails"
        Me.txtcomplaintdetails.Size = New System.Drawing.Size(166, 20)
        Me.txtcomplaintdetails.TabIndex = 9
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(45, 185)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(123, 31)
        Me.btnsubmit.TabIndex = 10
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(208, 185)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(123, 31)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmendorsement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 243)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtcomplaintdetails)
        Me.Controls.Add(Me.txtcomplainton)
        Me.Controls.Add(Me.txtcomplaintgiven)
        Me.Controls.Add(Me.txtaction)
        Me.Controls.Add(Me.txtcomplaintno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmendorsement"
        Me.Text = "frmendorsement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcomplaintno As System.Windows.Forms.TextBox
    Friend WithEvents txtaction As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplaintgiven As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplainton As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplaintdetails As System.Windows.Forms.TextBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
