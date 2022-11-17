Imports System.Reflection

Module Module1
    Const MAX = 10
    Structure TMatériel
        Dim noSerie As String
        Dim modèle As String
        Dim type As String
        Dim annéeDAchat As Integer
    End Structure

    Function SaisirMatériel() As TMatériel
        ' retourne un matériel saisi l'utilisateur
        Dim unMateriel As TMatériel
        Console.WriteLine("Numéro de série")
        unMateriel.noSerie = Console.ReadLine()
        Console.WriteLine("Modèle ?")
        unMateriel.modèle = Console.ReadLine()
        Console.WriteLine("Type ?")
        unMateriel.type = Console.ReadLine()
        Console.WriteLine("Annee d'achat ?")
        unMateriel.annéeDAchat = Console.ReadLine()
        Return unMateriel
    End Function

    Sub AfficherUnMatériel(ByVal pUnMatériel As TMatériel)
        ' Affiche un matériel
        Console.WriteLine("No de série : " + pUnMatériel.noSerie)
        Console.WriteLine("Modèle : " + pUnMatériel.modèle)
        Console.WriteLine("Type : " + pUnMatériel.type)
        Console.WriteLine("Annee d'achat : " + pUnMatériel.annéeDAchat.ToString)

    End Sub
    Sub AfficherLesMatériels(ByVal pLesMatériels() As TMatériel, ByVal pPosLibre As Integer)
        ' Affiche tous les matériels du parc
        For i = 0 To pPosLibre - 1
            Console.WriteLine("Matériel numero " + (i + 1).ToString)
            AfficherUnMatériel(pLesMatériels(i))
        Next
    End Sub

    Function AjouterUnMatériel(ByVal pMatériel As TMatériel, ByRef pLesMatériels() As TMatériel,
    ByRef pPosLibre As Integer) As Boolean
        ' Ajoute un matériel au parc (tableau). Si l'ajout est possible retourne True, False sinon.
        If pPosLibre < MAX Then
            pLesMatériels(pPosLibre) = pMatériel
            pPosLibre += 1
            Return True
        End If
        Return False
    End Function
    Function SupprimerParIndex(ByVal pIndex As Integer, ByRef pLesMatériels() As TMatériel,
    ByRef pPosLibre As Integer) As Boolean
        ' Supprime un matériel du parc (tableau). Si la suppression est possible, retourne True, False sinon.
        If pIndex > 0 And pIndex < pPosLibre Then
            For i = pIndex To pPosLibre - 2
                pLesMatériels(i) = pLesMatériels(i + 1)
            Next
            pPosLibre -= 1
            Return True
        End If
        Console.WriteLine("Cette suppression n'est pas possible")
        Return False
    End Function


    Function SupprimerParNoSérie(ByVal pNoSérie As String, ByRef pLesMatériels() As TMatériel,
            ByRef pPosLibre As Integer) As Boolean
        ' Supprime un matériel du parc (tableau). Si la suppression est possible (n° de série existant), retourne True, False sinon.
        For i = 0 To pPosLibre - 1
            If pNoSérie = pLesMatériels(i).noSerie Then
                For j = i To pPosLibre - 2
                    pLesMatériels(i) = pLesMatériels(i + 1)
                Next
                pPosLibre -= 1
                Return True
            End If
        Next
        Return False
    End Function

    Sub Main()
        Dim positionLibre, choix As Integer
        Dim lesMateriels(MAX - 1) As TMatériel
        Do
            Console.WriteLine("1. Ajouter un materiel dans le tableau.")
            Console.WriteLine("2. Supprimer un matériel (saisie index)")
            Console.WriteLine("3. Supprimer un materiel par n de serie")
            Console.WriteLine("4. Lister tous les materiel")
            Console.WriteLine("5. Quitter")
            choix = Console.ReadLine
            Select Case choix
                Case 1

            End Select
        Loop Until choix = 4
        Console.ReadLine()
    End Sub

End Module
