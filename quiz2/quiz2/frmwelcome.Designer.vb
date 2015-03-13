<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwelcome
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AIDDQUESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EDITQUESTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RESULTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QUIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.QUIZToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(356, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRATIONToolStripMenuItem, Me.AIDDQUESTToolStripMenuItem, Me.EDITQUESTIONToolStripMenuItem, Me.RESULTToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'REGISTRATIONToolStripMenuItem
        '
        Me.REGISTRATIONToolStripMenuItem.Name = "REGISTRATIONToolStripMenuItem"
        Me.REGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.REGISTRATIONToolStripMenuItem.Text = "REGISTRATION"
        '
        'AIDDQUESTToolStripMenuItem
        '
        Me.AIDDQUESTToolStripMenuItem.Name = "AIDDQUESTToolStripMenuItem"
        Me.AIDDQUESTToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AIDDQUESTToolStripMenuItem.Text = "ADD QUESTION"
        '
        'EDITQUESTIONToolStripMenuItem
        '
        Me.EDITQUESTIONToolStripMenuItem.Name = "EDITQUESTIONToolStripMenuItem"
        Me.EDITQUESTIONToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EDITQUESTIONToolStripMenuItem.Text = "EDIT QUESTION"
        '
        'RESULTToolStripMenuItem
        '
        Me.RESULTToolStripMenuItem.Name = "RESULTToolStripMenuItem"
        Me.RESULTToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RESULTToolStripMenuItem.Text = "RESULT"
        '
        'QUIZToolStripMenuItem
        '
        Me.QUIZToolStripMenuItem.Name = "QUIZToolStripMenuItem"
        Me.QUIZToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.QUIZToolStripMenuItem.Text = "QUIZ"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'frmwelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.quiz2.My.Resources.Resources.untitled
        Me.ClientSize = New System.Drawing.Size(356, 307)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmwelcome"
        Me.Text = "frmwelcome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUIZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AIDDQUESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITQUESTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RESULTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
