Public Class Obstacle

    Public Point1 As Point ' |  relative to the game tile
    Public Point2 As Point ' |  ^^^^^^^^^^^^^^^^^^^^^^^^^

    'COULD MAKE A BOOL MAP THAT CONNECTS STUFF - MIGHT BE EASIER?

    Sub New(CurrentObsList As List(Of Obstacle))
        'need to make sure they are made in relation 
        ' to eachother -- pass in list 
        '-- not too many of each type

        If CurrentObsList.Count > 1 Then
            'here will be checks for overlay
        End If

    End Sub

    Private Function GetTypeOfOb() As String
        Dim Types() As String = {"H", "V", "DP", "DN"}
        'horizontal, vertical, Diagonal pos, diagonal neg
        Randomize()
        Return Types(Int(Rnd() * Types.Length - 1))
    End Function

    Private Function GetLineLength() As Integer
        Dim Lengths() As Integer = {255 / 4, 255 / 3, 255 / 3, 255 / 2.5}
        'all in relation to playable area size
        Randomize()
        Return Lengths(Int(Rnd() * Lengths.Length - 1))
    End Function

    Private Sub BuildOb()

        Dim TOB As String = GetTypeOfOb()
        Dim LineLength As Integer = GetLineLength()

        Randomize() 'VALUES NEED TO BE CONSIDERED WHEN OVERLAY CHECK IS DONE
        Dim GetPointStartY As Integer = (255 / (Int(Rnd() * 10) + 1)) - ((255 / 10) / 2) ' offset
        Dim GetPointStartX As Integer = (Form1.Width / (Int(Rnd() * 12) + 1)) - ((Form1.Width / 12) / 2)

        Point1 = New Point(GetPointStartX, GetPointStartY) 'going left
        Select Case TOB
            Case "H"
                If Form1.Width / 2 < GetPointStartX Then
                    Point2 = New Point(GetPointStartX + LineLength, GetPointStartY)
                Else
                    Point2 = New Point(GetPointStartX - LineLength, GetPointStartY)
                End If
            Case "V"
                If Form1.Height / 2 < GetPointStartY Then
                    Point2 = New Point(GetPointStartX, GetPointStartY + LineLength)
                Else
                    Point2 = New Point(GetPointStartX, GetPointStartY - LineLength)
                End If
            Case "DP", "DN"
                Dim Ydiff As Integer = Math.Sin(45) * LineLength
                Dim Xdiff As Integer = Math.Cos(45) * LineLength
                If Form1.Height / 2 < GetPointStartY Then 'dp 


                Else 'dn


                End If


        End Select

    End Sub



End Class
