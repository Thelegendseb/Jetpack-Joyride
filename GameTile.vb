Public Class GameTile

    Public BackImage As Image
    Public Obstacles As List(Of Obstacle)

    Public CoinMap(20, 35) As Boolean


    ' each tile will have rando number of obs - 0,0,0,0,0,1,1,1,1,2,2

    Sub New(BackImageNum As Integer, CoinMapNum As Byte)

        Select Case CoinMapNum
            Case 1
            Case 2
            Case 3
            Case Else
                MsgBox("Resource not found.")
                Application.Exit()
        End Select

        Select Case BackImageNum
            Case 1
            Case 2
            Case 3
            Case Else
                MsgBox("Resource not found.")
                Application.Exit()


        End Select

    End Sub
    'get image
    'get obs for tile

    'g = PictureBox1.CreateGraphics for the coins

End Class
