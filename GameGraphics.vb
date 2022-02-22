Public Class GameGraphics

    Public PlayerGUI As New PictureBox
    Public CurrentsGUI(1) As Label 'score etc.



    Sub New(P As Player)
        Me.PlayerGUI.BackColor = Color.Red 'will be image
        Me.PlayerGUI.Size = P.Properties.PSize
        '=========
        Me.CurrentsGUI(0) = New Label  'dist
        Me.CurrentsGUI(1) = New Label  'coins
        Me.CurrentsGUI(0).Location = New Point(0, 0)
        Me.CurrentsGUI(1).Location = New Point(0, Me.CurrentsGUI(0).Height + 10)

    End Sub

    Sub UpdatePlayerGUI(P As Player)  'WILL MANAGE THE UPDATING OF ALL ON-SCREEN ELEMENTS
        Me.PlayerGUI.Location = New Point(200, P.Properties.PYpos)
        Me.CurrentsGUI(0).Text = P.Properties.PXpos & "M"
        Me.CurrentsGUI(1).Text = P.Properties.CoinCount & " ⬤"
    End Sub

    Sub AddGUIToControls()
        Form1.Controls.Add(Me.PlayerGUI)
        For Each element In Me.CurrentsGUI
            Form1.Controls.Add(element)
        Next
    End Sub

End Class
