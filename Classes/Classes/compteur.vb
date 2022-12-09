Public Class Compteur
    Private compte As Integer

    Public Sub New(ByVal nouveauCompteur As Integer)
        compte = nouveauCompteur
    End Sub

    Public Sub New()
        compte = 0
    End Sub

    Public Function GetValeur() As Integer
        Return compte
    End Function

    Public Sub PlusUn()
        compte += 1
    End Sub

    Public Sub Raz()
        compte = 0
    End Sub

    Public Sub IncrementeDe(ByVal pValeur As Integer)
        compte += pValeur
    End Sub

    Public Sub DecrementeDe(ByVal pValeur As Integer)
        compte -= pValeur
    End Sub

End Class
