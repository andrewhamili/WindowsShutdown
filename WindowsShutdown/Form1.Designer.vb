<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShutdownImmediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Shutdown30secToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartImmediateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Restatrt30secToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutdownImmediateToolStripMenuItem, Me.Shutdown30secToolStripMenuItem, Me.RestartImmediateToolStripMenuItem, Me.Restatrt30secToolStripMenuItem, Me.CancelAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 136)
        '
        'ShutdownImmediateToolStripMenuItem
        '
        Me.ShutdownImmediateToolStripMenuItem.Name = "ShutdownImmediateToolStripMenuItem"
        Me.ShutdownImmediateToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ShutdownImmediateToolStripMenuItem.Text = "Shutdown Immediate"
        '
        'Shutdown30secToolStripMenuItem
        '
        Me.Shutdown30secToolStripMenuItem.Name = "Shutdown30secToolStripMenuItem"
        Me.Shutdown30secToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.Shutdown30secToolStripMenuItem.Text = "Shutdown 30sec"
        '
        'RestartImmediateToolStripMenuItem
        '
        Me.RestartImmediateToolStripMenuItem.Name = "RestartImmediateToolStripMenuItem"
        Me.RestartImmediateToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.RestartImmediateToolStripMenuItem.Text = "Restart Immediate"
        '
        'Restatrt30secToolStripMenuItem
        '
        Me.Restatrt30secToolStripMenuItem.Name = "Restatrt30secToolStripMenuItem"
        Me.Restatrt30secToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.Restatrt30secToolStripMenuItem.Text = "Restatrt 30sec"
        '
        'CancelAllToolStripMenuItem
        '
        Me.CancelAllToolStripMenuItem.Name = "CancelAllToolStripMenuItem"
        Me.CancelAllToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CancelAllToolStripMenuItem.Text = "Cancel All"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 361)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShutdownImmediateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Shutdown30secToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartImmediateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Restatrt30secToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelAllToolStripMenuItem As ToolStripMenuItem
End Class
