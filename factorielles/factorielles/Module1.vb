Module Module1
    Function Factorielle(ByVal n As Integer) As Long
        Dim resultat As Long
        resultat = 1
        If n = 0 Then
            Return 1

        Else
            For i = 1 To n
                resultat *= i
            Next
            Return resultat
        End If
    End Function
    Sub Main()
        Dim entier As Integer
        Do


            Do
                Console.WriteLine("Saisir un nombre >= 0")
                entier = Console.ReadLine()
            Loop Until entier >= 0 Or entier = -1
            Console.WriteLine("La factorielle de ce nombre est : " + Factorielle(entier).ToString)
        Loop Until entier = -1
    End Sub

End Module
