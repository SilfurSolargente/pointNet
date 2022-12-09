Module Module1
    Sub Main()
        Dim c1, cB, cC As Compteur
        c1 = New Compteur(10)
        c1.PlusUn()
        Console.WriteLine(c1.GetValeur())
        c1.IncrementeDe(10)
        Console.WriteLine(c1.GetValeur())
        c1.DecrementeDe(5)
        Console.WriteLine(c1.GetValeur())
        c1.IncrementeDe(-10)
        Console.WriteLine(c1.GetValeur())
        cB = New Compteur(55)
        Console.WriteLine(cB.GetValeur())
        cC = New Compteur(0)
        Console.WriteLine(cC.GetValeur())
        cC = cB
        Console.WriteLine(cB.GetValeur())
        Console.WriteLine(cC.GetValeur())
        cB.PlusUn()
        Console.WriteLine(cB.GetValeur())
        Console.WriteLine(cC.GetValeur())
        Console.ReadLine()
    End Sub

End Module
