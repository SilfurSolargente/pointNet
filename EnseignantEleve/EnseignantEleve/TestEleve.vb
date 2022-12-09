Module TestEleve
    Sub Main()
        Dim e1 As Eleve
        e1 = New Eleve("112", "Martin", "Pierre", "Quelque part à Paris", "0606060606", "15/03/1830", "BTSSIO1")
        Console.WriteLine("Numéro : " + e1.GetNuméro())
        Console.WriteLine("Nom : " + e1.GetNom())
        Console.WriteLine("Prénom : " + e1.GetPrenom())
        Console.WriteLine("Adresse : " + e1.GetAdresse())
        Console.WriteLine("Numéro tel : " + e1.GetNumTel())
        Console.WriteLine("Date de Naissance : " + e1.GetDatNaiss())
        Console.WriteLine("Classe : " + e1.GetNumClasse)
        If e1.Moyenne() = 0 Then
            Console.WriteLine("Il n'y a aucune note, impossible de calculer une moyenne.")
        Else
            Console.WriteLine("La moyenne de " + e1.GetNom() + " est de : " + e1.Moyenne().toString())
        End If
        e1.SetNote(0, 12)
        e1.SetNote(1, 2)
        e1.SetNote(2, 9)
        e1.SetNote(3, 8)
        e1.SetNote(4, 17)
        e1.SetNote(5, 20)
        e1.SetNote(6, 4)
        e1.SetNote(7, 14)
        e1.SetNote(8, 13)
        e1.SetNote(9, 9)
        Console.WriteLine("La moyenne de " + e1.GetNom() + " est de : " + e1.Moyenne().ToString())
        Console.ReadLine()
    End Sub

End Module
