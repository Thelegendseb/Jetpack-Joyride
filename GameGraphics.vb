Public Class GameGraphics

    Public PlayerGUI As New PictureBox
    Public CurrentsGUI As New PictureBox

    'test update

    Sub New(P As Player)
        Me.PlayerGUI.BackColor = Color.Red 'will be image
        Me.PlayerGUI.Size = P.Properties.PSize
    End Sub

    Sub UpdatePlayerGUI(P As Player)  'WILL MANAGE THE UPDATING OF ALL ON-SCREEN ELEMENTS
        Me.PlayerGUI.Location = New Point(200, P.Properties.PYpos)
    End Sub

    Sub AddGUIToControls()
        Form1.Controls.Add(Me.PlayerGUI)
        'Me.Controls.Add(g.CurrentsGUI)
    End Sub

End Class
