Module MontantNet
    Sub Main()
        Dim montant, remise As Double
        Console.WriteLine("Veuillez taper votre montant ")
        montant = Console.ReadLine()
        If montant < 1999 Then
            Console.WriteLine("Pas de remise")
            Console.WriteLine("Le montant net est de :" + montant.ToString)
        ElseIf montant >= 2000 And montant <= 5000 Then
            Console.WriteLine("Remise de 1%")
            remise = montant * 0.01
            montant = montant - remise
            Console.WriteLine("Le montant net est de : " + montant.ToString)
        ElseIf montant > 5000 Then
            Console.WriteLine("Remise de 2%")
            remise = montant * 0.02
            montant = montant - remise
            Console.WriteLine("Le montant net est de : " + montant.ToString)
        End If
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub
End Module
