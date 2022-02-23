Public Class Obstacle

    Public Point1 As Point ' |  relative to the game tile
    Public Point2 As Point ' |  ^^^^^^^^^^^^^^^^^^^^^^^^^



    Sub New(CurrentObsList As List(Of Obstacle))
        'need to make sure they are made in relation 
        ' to eachother -- pass in list 
        '-- not too many of each type

        Dim TOB As String = GetTypeOfOb()
        Dim LineLength As Integer = GetLineLength()

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


End Class
