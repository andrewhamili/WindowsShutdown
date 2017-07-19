Public Class Form1
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.Icon = SystemIcons.Application
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Verificador corriendo"
            NotifyIcon1.BalloonTipText = "Verificador corriendo"
            NotifyIcon1.ShowBalloonTip(50000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ShutdownImmediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownImmediateToolStripMenuItem.Click
        Shell("CMD.exe /C shutdown /s /f /t 0")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
    End Sub

    Private Sub Shutdown30secToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Shutdown30secToolStripMenuItem.Click
        Shell("CMD.exe /C shutdown /s /f /t 30")
    End Sub

    Private Sub RestartImmediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartImmediateToolStripMenuItem.Click
        Shell("CMD.exe /C shutdown /r /f /t 0")
    End Sub

    Private Sub Restatrt30secToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Restatrt30secToolStripMenuItem.Click
        Shell("CMD.exe /C shutdown /r /f /t 30")
    End Sub

    Private Sub CancelAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelAllToolStripMenuItem.Click
        Shell("CMD.exe /C shutdown /a")
    End Sub
End Class
