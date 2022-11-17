Module Module1

    Function PerimetreCercle(ByVal pRayon As Double) As Double
        Dim perim As Double
        perim = 2 * Math.PI * pRayon
        Return perim
    End Function

    Function SurfaceCercle(ByVal pRayon As Double) As Double
        Dim surface As Double
        surface = Math.PI * pRayon * pRayon
        Return surface
    End Function

    Function PerimetreRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Dim perim As Double
        perim = 2 * (pLongueur + pLargeur)
        Return perim
    End Function

    Function SurfaceRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Dim surface As Double
        surface = pLongueur * pLargeur
        Return surface
    End Function
    Sub Main()
        Dim rayon, longueur, largeur As Double, choix As Integer
        Do
            Console.WriteLine("1. Calcul du perimetre d'un cercle.")
            Console.WriteLine("2. Calcul de la surface d'un cercle")
            Console.WriteLine("3. Calcul du perimetre d'un rectangle")
            Console.WriteLine("4.Cacul de la surface d'un rectangle")
            Console.WriteLine("5. Quitter")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Do
                        Console.WriteLine("Rayon du cercle ? (rayon > 0)")
                        rayon = Console.ReadLine()
                        If rayon < 1 Then
                            Console.WriteLine("Le rayon doit etre superieur a 0")
                        End If
                    Loop Until rayon > 0
                    Console.WriteLine("Le perimetre du cerle est de " + PerimetreCercle(rayon).ToString)
                Case 2
                    Do
                        Console.WriteLine("Rayon du cercle ? (rayon > 0)")
                        rayon = Console.ReadLine()
                        If rayon < 1 Then
                            Console.WriteLine("Le rayon doit etre superieur a 0")
                        End If
                    Loop Until rayon > 0
                    Console.WriteLine("La surface du cerle est de " + SurfaceCercle(rayon).ToString)
                Case 3
                    Do
                        Console.WriteLine("Longueur du rectangle ?")
                        longueur = Console.ReadLine()
                        If longueur < 1 Then
                            Console.WriteLine("La longueur doit etre superieure a 0")
                        End If
                    Loop Until longueur > 0
                    Do
                        Console.WriteLine("Largeur du rectangle ?")
                        largeur = Console.ReadLine()
                        If largeur < 1 Then
                            Console.WriteLine("La largeur doit etre superieure a 0")
                        End If
                    Loop Until largeur > 0
                    Console.WriteLine("Le perimetre du rectangle est de " + PerimetreRectangle(longueur, largeur).ToString)
                Case 4
                    Do
                        Console.WriteLine("Longueur du rectangle ?")
                        longueur = Console.ReadLine()
                        If longueur < 1 Then
                            Console.WriteLine("La longueur doit etre superieure a 0")
                        End If
                    Loop Until longueur > 0
                    Do
                        Console.WriteLine("Largeur du rectangle ?")
                        largeur = Console.ReadLine()
                        If largeur < 1 Then
                            Console.WriteLine("La largeur doit etre superieure a 0")
                        End If
                    Loop Until largeur > 0
                    Console.WriteLine("La surface du rectangle est de " + SurfaceRectangle(longueur, largeur).ToString)
                Case 5
                    Console.WriteLine("Merci. Fermeture du programme")
                Case Else
                    Console.WriteLine("Erreur de saisie.")
            End Select
        Loop Until choix = 5
        Console.ReadLine()
    End Sub

End Module
