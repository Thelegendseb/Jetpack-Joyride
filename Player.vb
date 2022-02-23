Public Class Player

    Public Properties As New PlayerProperties

    Public FOV As List(Of GameTile)

    Sub New()
        Properties.PYpos = 326 'grounded val;
    End Sub

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Sub JumpOps()
        If Grounded() = True Then
            Properties.PYV = 0
        ElseIf Topped() = True Then
            Properties.PYV = Globals.Gravity
            Properties.PYpos = 71
        End If
        AddGrav()
        TVCap()
        If GetAsyncKeyState(32) Or GetAsyncKeyState(87) Then '--SPACEBAR--
            Properties.PYV -= 2.5
        End If
    End Sub

    Private Function Grounded() As Boolean
        If Properties.PYpos + Me.Properties.PSize.Height >= Form1.Height - 100 Then Return True
        Return False
    End Function
    Private Function Topped() As Boolean
        If Properties.PYpos <= 70 Then Return True
        Return False
    End Function
    Private Sub AddGrav()
        Properties.PYpos += (Properties.PYV - Globals.Gravity) / 3
        Properties.PYV += Globals.Gravity / 4
    End Sub
    Private Sub TVCap()
        If Properties.PYV < -30 Then
            Properties.PYV = -30 '--TERMINAL VELOCITY DECLARATION--UP
        End If
        If Properties.PYV > 50 Then
            Properties.PYV = 50 '--TERMINAL VELOCITY DECLARATION--DOWN
        End If
    End Sub

End Class
