<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquiz
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
        Me.txtqno = New System.Windows.Forms.TextBox
        Me.txtquestion = New System.Windows.Forms.TextBox
        Me.txtd = New System.Windows.Forms.TextBox
        Me.txtc = New System.Windows.Forms.TextBox
        Me.txtb = New System.Windows.Forms.TextBox
        Me.txta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtans = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtqno
        '
        Me.txtqno.Enabled = False
        Me.txtqno.Location = New System.Drawing.Point(83, 12)
        Me.txtqno.Name = "txtqno"
        Me.txtqno.Size = New System.Drawing.Size(100, 20)
        Me.txtqno.TabIndex = 1
        Me.txtqno.Visible = False
        '
        'txtquestion
        '
        Me.txtquestion.Enabled = False
        Me.txtquestion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquestion.Location = New System.Drawing.Point(77, 93)
        Me.txtquestion.Multiline = True
        Me.txtquestion.Name = "txtquestion"
        Me.txtquestion.Size = New System.Drawing.Size(497, 59)
        Me.txtquestion.TabIndex = 2
        '
        'txtd
        '
        Me.txtd.Enabled = False
        Me.txtd.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtd.Location = New System.Drawing.Point(383, 209)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(141, 26)
        Me.txtd.TabIndex = 3
        '
        'txtc
        '
        Me.txtc.Enabled = False
        Me.txtc.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtc.Location = New System.Drawing.Point(123, 209)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(146, 26)
        Me.txtc.TabIndex = 4
        '
        'txtb
        '
        Me.txtb.Enabled = False
        Me.txtb.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb.Location = New System.Drawing.Point(383, 161)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(141, 26)
        Me.txtb.TabIndex = 5
        '
        'txta
        '
        Me.txta.Enabled = False
        Me.txta.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txta.Location = New System.Drawing.Point(123, 161)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(146, 26)
        Me.txta.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "A"
        '
        'txtans
        '
        Me.txtans.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtans.Location = New System.Drawing.Point(234, 261)
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(173, 26)
        Me.txtans.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ANSWER"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(400, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.Enabled = False
        Me.txtusername.Location = New System.Drawing.Point(344, 12)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(114, 20)
        Me.txtusername.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "QUIZ"
        '
        'frmquiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.quiz2.My.Resources.Resources.untitled
        Me.ClientSize = New System.Drawing.Size(586, 354)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtans)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.txtb)
        Me.Controls.Add(Me.txtc)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.txtquestion)
        Me.Controls.Add(Me.txtqno)
        Me.Name = "frmquiz"
        Me.Text = "frmquiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtqno As System.Windows.Forms.TextBox
    Friend WithEvents txtquestion As System.Windows.Forms.TextBox
    Friend WithEvents txtd As System.Windows.Forms.TextBox
    Friend WithEvents txtc As System.Windows.Forms.TextBox
    Friend WithEvents txtb As System.Windows.Forms.TextBox
    Friend WithEvents txta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtans As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
