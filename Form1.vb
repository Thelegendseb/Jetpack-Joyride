Public Class Form1

    Dim WithEvents GameRule As New Timer
    '/=====================================/

    Dim P1 As New Player
    Dim g As New GameGraphics(P1)

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Private Sub GameRule_Tick(sender As System.Object, e As System.EventArgs) Handles GameRule.Tick

        P1.Properties.PXpos += 0.1
        P1.JumpOps()
        g.UpdatePlayerGUI(P1)

        Me.Text = P1.Properties.PXpos

        If GetAsyncKeyState(27) Then
            '--ESC--
            Application.Exit()
        End If
    End Sub

    Sub Init()
        Me.Show()
        'Me.MaximizeBox = False
        'Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        GameRule.Interval = 10
        Me.Text = "Jetpack Joyride - S.C"

        g.AddGUIToControls()
        GameRule.Enabled = True
    End Sub

End Class
