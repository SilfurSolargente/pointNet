Public Class File
    Private Const MAX = 100
    Private tabImpressions(MAX) As TacheImpression
    Private PosLibre As Integer

    Public Sub New()
        PosLibre = 0
    End Sub

    Public Function enfiler(ByVal pValeur As TacheImpression) As Boolean
        If PosLibre = MAX Then
            Return False
        End If
        tabImpressions(PosLibre) = pValeur
        PosLibre += 1
        Return True
    End Function

    Public Function defiler() As TacheImpression
        Dim pop As TacheImpression
        pop = tabImpressions(0)
        pop.setEtat("En cours")
        For i = 0 To PosLibre - 1
            tabImpressions(i) = tabImpressions(i + 1)
        Next
        PosLibre -= 1
        Return pop
    End Function

    Public Function EstVide() As Boolean
        Return PosLibre = 0
    End Function

    Public Function nombreDElements() As Integer
        Return PosLibre
    End Function

    Public Overrides Function ToString() As String
        Dim chaine As String
        chaine = "Liste d'attente : " + vbNewLine
        For i = 0 To PosLibre - 1
            chaine += tabImpressions(i).ToString + vbNewLine
        Next
        Return chaine
    End Function
End Class
