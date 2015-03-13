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
        Me.CANDIDATESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VOTECOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VOTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VOTINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VOTEPLUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.VOTEToolStripMenuItem, Me.VOTINGToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CANDIDATESToolStripMenuItem, Me.REGISTRATIONToolStripMenuItem, Me.VOTEPLUSToolStripMenuItem, Me.VOTECOUNTToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'CANDIDATESToolStripMenuItem
        '
        Me.CANDIDATESToolStripMenuItem.Name = "CANDIDATESToolStripMenuItem"
        Me.CANDIDATESToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CANDIDATESToolStripMenuItem.Text = "CANDIDATES"
        '
        'REGISTRATIONToolStripMenuItem
        '
        Me.REGISTRATIONToolStripMenuItem.Name = "REGISTRATIONToolStripMenuItem"
        Me.REGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.REGISTRATIONToolStripMenuItem.Text = "REGISTRATION"
        '
        'VOTECOUNTToolStripMenuItem
        '
        Me.VOTECOUNTToolStripMenuItem.Name = "VOTECOUNTToolStripMenuItem"
        Me.VOTECOUNTToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.VOTECOUNTToolStripMenuItem.Text = "RESULT"
        '
        'VOTEToolStripMenuItem
        '
        Me.VOTEToolStripMenuItem.Name = "VOTEToolStripMenuItem"
        Me.VOTEToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.VOTEToolStripMenuItem.Text = "CANDIDATE LIST"
        '
        'VOTINGToolStripMenuItem
        '
        Me.VOTINGToolStripMenuItem.Name = "VOTINGToolStripMenuItem"
        Me.VOTINGToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.VOTINGToolStripMenuItem.Text = "VOTING "
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
        'VOTEPLUSToolStripMenuItem
        '
        Me.VOTEPLUSToolStripMenuItem.Name = "VOTEPLUSToolStripMenuItem"
        Me.VOTEPLUSToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.VOTEPLUSToolStripMenuItem.Text = "VOTE PLUS"
        '
        'frmwelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 262)
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
    Friend WithEvents CANDIDATESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOTINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOTECOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOTEPLUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
