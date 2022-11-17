
Module Module1

    Sub Main()
        Dim ventesHebdo, commission, totalVentes As Double, nomRep, answer As String, semaine As Integer
        Do
            Console.WriteLine("Nom de représentant ?")
            nomRep = Console.ReadLine()
            totalVentes = 0
            semaine = 1
            ventesHebdo = 2
            While ventesHebdo > 1 And semaine < 5

                Do
                    Console.WriteLine("Semaines" + semaine.ToString + ": Ventes hebdomadaires H.T.(0 pour stopper la saisie)")
                    ventesHebdo = Console.ReadLine()
                    If ventesHebdo < 0 Then
                        Console.WriteLine("Les ventes ne peuvent être < à 0")
                    End If
                Loop Until ventesHebdo >= 0
                totalVentes += ventesHebdo
                semaine += 1
            End While
            Console.WriteLine("Bilan pour " + nomRep + ":")
            Console.WriteLine("total des ventes H.T : " + totalVentes.ToString)
            commission = totalVentes * 10 / 100
            Console.WriteLine("Commission : " + commission.ToString)

            Do
                Console.WriteLine("Autre représentant ? O/N")
                answer = Console.ReadLine()
            Loop Until answer = "N" Or answer = "O"
        Loop Until answer = "N"
        Console.ReadLine()
    End Sub

End Module
