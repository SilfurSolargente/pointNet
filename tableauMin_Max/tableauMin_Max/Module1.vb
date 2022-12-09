Module Module1

    Sub Main()
        Const NONOMBRES = 10
        Dim nombres(9) As Integer
        Dim choixNombre, min, max As Integer
        min = 100
        max = 0
        For choixNombre = 0 To NONOMBRES - 1
            Do
                Console.WriteLine("Saisir le nombre n°" + (choixNombre + 1).ToString)
                nombres(choixNombre) = Console.ReadLine()
                If nombres(choixNombre) < 0 Or nombres(choixNombre) > 100 Then
                    Console.WriteLine("Rentrez un nombre positif inférieur à 100")
                End If
            Loop Until nombres(choixNombre) > -1 And nombres(choixNombre) < 100
            If nombres(choixNombre) > max Then
                max = nombres(choixNombre)
            End If
            If nombres(choixNombre) < min Then
                min = nombres(choixNombre)
            End If
        Next
        Console.WriteLine("Min=" + min.ToString)
        Console.WriteLine("Max=" + max.ToString)
        Console.ReadLine()
    End Sub

End Module
