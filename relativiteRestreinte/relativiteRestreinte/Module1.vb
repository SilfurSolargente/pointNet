Module Module1
    Public Const c = 300000

    Function DilatationTemps(ByVal t As Double, ByVal v As Double) As Double
        Return t / (Math.Sqrt(1 - (v ^ 2 / c ^ 2)))
    End Function

    Function ContractionLongueur(ByVal l As Double, ByVal v As Double) As Double
        Return l * (Math.Sqrt(1 - (v ^ 2 / c ^ 2)))
    End Function

    Function CompositionVitesse(ByVal w As Double, v As Double) As Double
        Return (w + v) / (1 + (w * v / c ^ 2))
    End Function


    Sub Main()
        Dim duree, vitesse, tailleFusee, vitesseObus As Double
        Dim choix As Integer
        Do
            Console.WriteLine("1. La dilatation du temps")
            Console.WriteLine("2. La contraction des longueurs")
            Console.WriteLine("3. Loi de composition des vitesses")
            Console.WriteLine("4. Quitter")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        vitesse = Console.ReadLine()
                        If vitesse < 1 Then
                            Console.WriteLine("La vitesse doit être supérieure à 0")
                        End If
                    Loop Until vitesse > 0
                    Do
                        Console.WriteLine("Durée écoulée dans la fusée (en secondes) ?")
                        duree = Console.ReadLine()
                        If duree < 1 Then
                            Console.WriteLine("La durée doit être supérieure à 0")
                        End If
                    Loop Until duree > 0
                    Console.WriteLine("Durée écoulée sur la terre : " + DilatationTemps(duree, vitesse).ToString)
                Case 2
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        vitesse = Console.ReadLine()
                        If vitesse < 1 Then
                            Console.WriteLine("La vitesse doit être supérieure à 0")
                        End If
                    Loop Until vitesse > 0
                    Do
                        Console.WriteLine("Taille de la fusée (en km) ?")
                        tailleFusee = Console.ReadLine()
                        If tailleFusee < 1 Then
                            Console.WriteLine("La taille de la fusée doit être supérieure à 0")
                        End If
                    Loop Until tailleFusee > 0
                    Console.WriteLine("Taille de la fusée vue de la terre : " + ContractionLongueur(tailleFusee, vitesse).ToString)
                Case 3
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        vitesse = Console.ReadLine()
                        If vitesse < 1 Then
                            Console.WriteLine("La vitesse doit être supérieure à 0")
                        End If
                    Loop Until vitesse > 0
                    Do
                        Console.WriteLine("Vitesse de l'obus (en km/s) ?")
                        vitesseObus = Console.ReadLine()
                        If vitesseObus < 1 Then
                            Console.WriteLine("La vitesse de l'obus doit être supérieure à 0")
                        End If
                    Loop Until vitesseObus > 0
                    Console.WriteLine("Vitesse de l'obus par rapport à la terre : " + CompositionVitesse(vitesseObus, vitesse).ToString)
                Case 4
                    Console.WriteLine("Au revoir.")
                Case Else
                    Console.WriteLine("Erreur de saisie")
            End Select
        Loop Until choix = 4

        Console.ReadLine()
    End Sub

End Module
