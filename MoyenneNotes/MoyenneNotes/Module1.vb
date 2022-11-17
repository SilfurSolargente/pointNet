Module MoyenneNotes

    Sub Main()
        Dim note, moyenne, notesAuDessusMoyenne, nombresDeNotes, total As Double
        total = 0
        notesAuDessusMoyenne = 0
        nombresDeNotes = 0
        Do
            Console.WriteLine("Rentrez votre note entre 0 et 20 : ")
            note = Console.ReadLine()
            If note < 0 Or note > 20 Then
                Console.WriteLine("La note doit etre entre 0 et 20")
            End If
        Loop Until note >= 0 And note <= 20
        While note > -1
            If note > 10 Then
                notesAuDessusMoyenne += 1
            End If
            total += note
            nombresDeNotes += 1
            Do
                Console.WriteLine("Rentrez votre note entre 0 et 20, -1 pour terminer: ")
                note = Console.ReadLine()
                If note < 0 Or note > 20 Then
                    Console.WriteLine("La note doit etre entre 0 et 20")
                End If
            Loop Until note >= 0 And note <= 20
        End While
        moyenne = total / nombresDeNotes
        notesAuDessusMoyenne = (notesAuDessusMoyenne / nombresDeNotes) * 100
        Console.WriteLine("Vous avez " + notesAuDessusMoyenne.ToString + "% de notes > à la moyenne")
        Console.WriteLine("Votre total de notes est de " + total.ToString)
        Console.WriteLine("Votre nombre de notes valides est de " + nombresDeNotes.ToString)
        Console.WriteLine("Votre moyenne est de " + moyenne.ToString)
        Console.ReadLine()
    End Sub

End Module
