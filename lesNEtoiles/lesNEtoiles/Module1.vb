Module Module1
    Sub Dessin(ByVal noLignes As Integer)
        Dim nombreBlancs, nombreEtoiles As Integer
        nombreEtoiles = 1
        For i = 1 To noLignes
            nombreBlancs = noLignes - i
            For j = 1 To nombreBlancs
                Console.Write(" ")
            Next
            For k = 1 To nombreEtoiles
                Console.Write("*")
            Next
            nombreEtoiles += 2
            Console.WriteLine("")
        Next
    End Sub
    Sub Main()
        Dim nombreLignes As Integer
        Console.WriteLine("Combien de ligne voulez vous ?")
        nombreLignes = Console.ReadLine()
        Dessin(nombreLignes)
        Console.ReadLine()
    End Sub

End Module
