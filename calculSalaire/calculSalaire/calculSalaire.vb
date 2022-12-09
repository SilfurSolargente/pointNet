Module CalculSalaire

    Sub Main()
        Dim heuresTravail As Integer
        Dim tauxHoraire, salaireHebdo, horaireMaj25, horaireMaj50 As Double
        Console.WriteLine("Nombre d'heures travaillees hebdomadaires ?")
        heuresTravail = Console.ReadLine()
        If heuresTravail < 39 Then
            salaireHebdo = 0
            Console.WriteLine("Vous ne travaillez pas assez !")
            Console.WriteLine("Salaire hebdomadaire : " + salaireHebdo.ToString)
            Console.WriteLine("Au revoir")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Taux horaire ?")
        tauxHoraire = Console.ReadLine()
        horaireMaj25 = (heuresTravail - 39) * (tauxHoraire * 1.25)
        horaireMaj50 = (heuresTravail - 47) * (tauxHoraire * 1.5)
        If heuresTravail = 39 Then
            salaireHebdo = heuresTravail * tauxHoraire
        ElseIf heuresTravail > 39 And heuresTravail < 47 Then
            salaireHebdo = 39 * tauxHoraire + horaireMaj25
        ElseIf heuresTravail >= 47 Then
            salaireHebdo = 39 * tauxHoraire + 8 * (tauxHoraire * 1.25) + horaireMaj50
        End If
        Console.WriteLine("Salaire hebdomadaire : " + salaireHebdo.ToString)
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub

End Module
