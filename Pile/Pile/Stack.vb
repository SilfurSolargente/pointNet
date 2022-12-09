Public Class Stack
    Private Const MAX = 100
    Private TabPile(MAX) As String
    Private positionLibre As Integer

    Public Sub New()
        positionLibre = 0
    End Sub

    Public Function Empiler(ByVal mot As String) As Boolean
        If positionLibre > MAX Then
            Return False
        End If
        TabPile(positionLibre) = mot
        positionLibre += 1
        Return True
    End Function

    Public Function Dépiler() As String
        If positionLibre > 0 Then
            positionLibre -= 1
            Return TabPile(positionLibre + 1)
        End If
        Return "La pile est vide"
    End Function

    Public Function EstVide() As Boolean
        Return positionLibre = 0
    End Function

    Public Function NombreDElements() As Integer
        Return positionLibre
    End Function
End Class
