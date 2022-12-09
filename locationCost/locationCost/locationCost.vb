Module locationCost

    Sub Main()
        Dim tarifEssence, tarifDiesel, distance, nombreJour As Double
        Dim meilleurChoix As String
        meilleurChoix = "Une erreur est survenue" ' Attribution par defaut pour eviter de ne pas avoir de valeur
        Console.WriteLine("Combien de jours voulez vous louer ?")
        nombreJour = Console.ReadLine()
        Console.WriteLine("Combien de kilomètres pensez vous parcourir ?")
        distance = Console.ReadLine()
        tarifEssence = 30 * nombreJour + 0.85 * distance
        tarifDiesel = 35 * nombreJour + 0.65 * distance
        If tarifEssence = tarifDiesel Then
            meilleurChoix = "Nos deux tarifs sont équivalent"
        ElseIf tarifDiesel < tarifEssence Then
            meilleurChoix = "Diesel"
        ElseIf tarifEssence < tarifDiesel Then
            meilleurChoix = "Essence"
        End If
        Console.WriteLine("Meilleur choix : " + meilleurChoix)
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub

End Module
