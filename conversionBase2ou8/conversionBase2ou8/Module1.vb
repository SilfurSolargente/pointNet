Module Module1
    Sub conversionBase(ByVal quotient As Integer, ByVal base As Integer)
        Dim restes(7) As Integer
        Dim noBoucle As Integer
        noBoucle = 0
        Do
            restes(noBoucle) = (quotient Mod base)
            quotient \= base
            noBoucle += 1
        Loop Until quotient = 0
        For i = noBoucle - 1 To 0 Step -1
            Console.Write(restes(i).ToString)
        Next
        Console.WriteLine("")
    End Sub

    Sub Main()
        Dim choixValeur, choixBase As Integer
        Dim recommencer As String
        Do
            Do
                Console.WriteLine("Choisissez le nombre à convertir")
                choixValeur = Console.ReadLine()
            Loop Until choixValeur > 0 And choixValeur < 256
            Do
                Console.WriteLine("Choisir la base de conversion (2/8)")
                choixBase = Console.ReadLine()
            Loop Until choixBase = 8 Or choixBase = 2
            conversionBase(choixValeur, choixBase)
            Console.WriteLine("Voulez vous recommencer ?")
            recommencer = Console.ReadLine()
        Loop Until recommencer = "N" Or recommencer = "n"
        Console.ReadLine()
    End Sub

End Module
