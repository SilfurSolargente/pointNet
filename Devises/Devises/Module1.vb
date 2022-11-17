Module Module1

    Sub Main()
        Const NOMBREDEVISES = 17
        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM",
                           "LUF", "NLG", "GRD", "SIT", "ATS", "PTE", "CYP", "MTL", "SKK"}

        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94,
                        40.33, 2.2, 340.75, 239.64, 13.76, 200.48, 0.58, 0.42, 30.12}
        Dim euro, equivalentAncienneDevise As Double
        Dim codeDeviseUtilisateur As String
        Dim codeDeviseNombre As Integer
        codeDeviseNombre = -1
        Do
            Console.WriteLine("Montant en euro ?")
            euro = Console.ReadLine()
        Loop Until euro > 0
        Console.WriteLine("Code Devise ?")
        codeDeviseUtilisateur = Console.ReadLine
        For i = 0 To NOMBREDEVISES - 1
            If devises(i) = codeDeviseUtilisateur Then
                codeDeviseNombre = i
                Exit For
            End If
        Next
        If codeDeviseNombre = -1 Then
            Console.WriteLine("Cette devise est introuvable.")
            Console.ReadLine()
            End
        End If
        equivalentAncienneDevise = euro * taux(codeDeviseNombre)
        Console.WriteLine("Montant dans l'ancienne monnaie nationale : " + equivalentAncienneDevise.ToString)
        Console.ReadLine()
    End Sub

End Module
