Module TestEnseignant

    Sub Main()
        Dim e1 As Enseignant
        Dim indice As Integer
        e1 = New Enseignant("E0112", "Dupont", "Pierre", "1, rue de la paix - 75000 Paris", "0132124182", "01/04/1980", 8, 20)
        Console.WriteLine("Numéro : " + e1.GetNuméro())
        Console.WriteLine("Nom : " + e1.GetNom())
        Console.WriteLine("Prénom : " + e1.GetPrenom())
        Console.WriteLine("Adresse : " + e1.GetAdresse())
        Console.WriteLine("Numéro tel : " + e1.GetNumTel())
        Console.WriteLine("Date de Naissance : " + e1.GetDatNaiss())
        Console.WriteLine("Indice : " + e1.GetIndice().ToString)
        Console.WriteLine("Nombre d'heures travaillées : " + e1.GetNombreDHeures().ToString)
        Console.WriteLine("Salaire mensuel : " + e1.Salaire().ToString)
        Console.WriteLine("Nouvel Indice ?")
        indice = Console.ReadLine()
        If Not e1.AugmenterIndice(indice) Then
            Console.WriteLine("L'indice ne peut pas être baisser")
        Else
            Console.WriteLine("L'indice est désormais de " + indice.ToString)
        End If
        Console.WriteLine("Salaire mensuel : " + e1.Salaire().ToString)
        Console.ReadLine()
    End Sub

End Module
