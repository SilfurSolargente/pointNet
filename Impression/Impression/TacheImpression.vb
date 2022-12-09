Public Class TacheImpression
    Private nomDocument, etat, propriétaire As String
    Private nbPages, taille As Integer

    Public Sub New(ByVal nouvDoc As String, ByVal nouvProp As String,
                   ByVal nouvNbPages As Integer, ByVal nouvTaille As Integer)
        nomDocument = nouvDoc
        propriétaire = nouvProp
        nbPages = nouvNbPages
        taille = nouvTaille
        etat = "En attente"
    End Sub

    Public Function getNomDocument()
        Return nomDocument
    End Function

    Public Function getEtat()
        Return etat
    End Function

    Public Sub setEtat(ByVal nouvEtat As String)
        etat = nouvEtat
    End Sub

    Public Function getPriopriétaire()
        Return propriétaire
    End Function

    Public Function getNbPages()
        Return nbPages
    End Function

    Public Function getTaille()
        Return taille
    End Function

    Public Overrides Function ToString() As String
        Dim chaine As String
        chaine = nomDocument +
            " - " + etat +
            " - " + propriétaire +
            " - " + nbPages.ToString + " pages" +
            " - " + taille.ToString
        Return chaine
    End Function
End Class
