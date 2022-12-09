Module Module1

    Sub Main()
        Dim nouvelleImpression As TacheImpression
        Dim f1 As File
        Dim nouvNbPages, nouvTaille As Integer
        Dim nouvDoc, nouvProp As String
        Dim choix As Integer
        f1 = New File()
        Do
            Console.WriteLine("1. Ajouter une tâche d'impression dans la file")
            Console.WriteLine("2. Défiler une tâche d'impression")
            Console.WriteLine("3. Tester si la file d'impression est vide")
            Console.WriteLine("4. Nombre d'éléments dans la File d'impression")
            Console.WriteLine("5.Contenu de la file d'impression")
            Console.WriteLine("6. Quitter")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Console.WriteLine("Saisir la tâche d'impression à enfiler.")
                    Console.WriteLine("Nom doc ?")
                    nouvDoc = Console.ReadLine()
                    Console.WriteLine("Propriétaire ?")
                    nouvProp = Console.ReadLine()
                    Console.WriteLine("Nombre de pages ?")
                    nouvNbPages = Console.ReadLine()
                    Console.WriteLine("Taille ?")
                    nouvTaille = Console.ReadLine()
                    nouvelleImpression = New TacheImpression(nouvDoc, nouvProp, nouvNbPages, nouvTaille)
                    If f1.enfiler(nouvelleImpression) Then
                        Console.WriteLine("OK")
                    Else
                        Console.WriteLine("La liste est pleine")
                    End If
                Case 2
                    If Not f1.EstVide() Then
                        Console.WriteLine("Valeur extraite de la file : " + f1.defiler().ToString)
                    Else
                        Console.WriteLine("La file d'attente est vide")
                    End If
                Case 3
                    If f1.EstVide() Then
                        Console.WriteLine("La liste est vide")
                    Else
                        Console.WriteLine("La liste n'est pas vide")
                    End If
                Case 4
                    Console.WriteLine("Nombre d'élements = " + f1.nombreDElements().ToString)
                Case 5
                    Console.WriteLine(f1.ToString())
                Case 6
                    Console.WriteLine("Au revoir")
                Case Else
                    Console.WriteLine("Erreur de saisie")
            End Select
        Loop Until choix = 6
    End Sub

End Module
