Module Module1

    Sub Main()
        Dim mois() As String = {"Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre"}
        Dim choix As Integer
        Do
            Console.WriteLine("Saisissez un nombre de mois")
            choix = Console.ReadLine()
            If choix < 1 Or choix > 12 Then
                Console.WriteLine("erreur de saisie")
            End If
        Loop Until choix > 0 And choix < 13
        Console.WriteLine("Le mois choisi est : " + mois(choix - 1))
        Console.ReadLine()

    End Sub

End Module
