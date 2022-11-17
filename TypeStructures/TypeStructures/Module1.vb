
Imports System.Diagnostics.Eventing.Reader

Module Module1

    Const MAX As Integer = 2



    Structure TClient
        Dim code As String
        Dim nom As String
        Dim adresse As String
    End Structure



    Structure TCommande
        Dim numéro As Integer
        Dim dateC As String
        Dim montant As Double
        Dim codeClient As String
    End Structure



    Sub AfficherUnClient(ByVal pUnClient As TClient)
        ' affiche un client
        Console.WriteLine("Le nom du client est " + pUnClient.nom)
        Console.WriteLine("Son code client est " + pUnClient.code)
        Console.WriteLine("Iel habite le " + pUnClient.adresse)
    End Sub



    Function ClientPourUneCommande(ByVal pNuméroCommande As Integer,
                ByVal pTabCommandes() As TCommande,
                ByVal pTabClients() As TClient) As TClient
        Dim codeClient As String
        Dim client As TClient
        codeClient = ""
        client.code = "X"
        client.nom = ""
        client.adresse = ""
        ' retourne le client, de type TClient correspondant au n° de commande
        ' passé en paramètre. Si le n° de commande n'existe pas. Retourne un
        ' client, de type TClient, 'vide', à l'exception du champ code qui sera
        ' mis à X
        For i = 0 To MAX ' Parcours des commandes pour trouver le numéro client
            If pTabCommandes(i).numéro = pNuméroCommande Then
                codeClient = pTabCommandes(i).codeClient
                Exit For
            End If
        Next
        If codeClient = "" Then ' Si on n'a rien trouvé on retourne un client vide
            Return client
        End If
        For i = 0 To MAX ' Parcours du tableau client
            If pTabClients(i).code = codeClient Then
                Return pTabClients(i) 'On retourne le client qui correspond au code client de la commande
            End If
        Next
        Return client ' Normalement on arrive jamais là mais au cas où...
    End Function
    Function MontantCommandé(ByVal pCodeClient As String,
                                 ByVal pTabCommandes() As TCommande) As Double
        ' retourne le montant total commandé par le client ayant
        ' pour code pCodeClient
        Dim montantTotal As Double
        For i = 0 To MAX
            If pCodeClient = pTabCommandes(i).codeClient Then
                montantTotal += pTabCommandes(i).montant
            End If
        Next
        Return montantTotal
    End Function



    Sub Main()
        Dim choix, nCommande As Integer
        Dim codeClient As String
        Dim lesClients(MAX), client As TClient
        Dim lesCommandes(MAX) As TCommande

        lesClients(0).code = "C01"
        lesClients(0).nom = "NomC01"
        lesClients(0).adresse = "AdresseC01"

        lesClients(1).code = "C02"
        lesClients(1).nom = "NomC02"
        lesClients(1).adresse = "AdresseC02"

        lesClients(2).code = "C03"
        lesClients(2).nom = "NomC03"
        lesClients(2).adresse = "AdresseC03"

        lesCommandes(0).numéro = 1
        lesCommandes(0).dateC = "01-01-01"
        lesCommandes(0).montant = 100
        lesCommandes(0).codeClient = "C02"

        lesCommandes(1).numéro = 2
        lesCommandes(1).dateC = "02-01-02"
        lesCommandes(1).montant = 200
        lesCommandes(1).codeClient = "C01"

        lesCommandes(2).numéro = 3
        lesCommandes(2).dateC = "02-01-03"
        lesCommandes(2).montant = 300
        lesCommandes(2).codeClient = "C02"
        Do
            Console.WriteLine("1. Montant total des commandes passées par un client (code client)")
            Console.WriteLine("2. Details d'un client pour une commande (n de commande)")
            Console.WriteLine("3. Quitter")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Console.WriteLine("Code client ?")
                    codeClient = Console.ReadLine()
                    Console.WriteLine("Montant commandé: " + MontantCommandé(codeClient, lesCommandes).ToString)

                Case 2
                    Console.WriteLine("Numero commande ?")
                    nCommande = Console.ReadLine()
                    client = ClientPourUneCommande(nCommande, lesCommandes, lesClients)
                    If client.code <> "X" Then
                        AfficherUnClient(client)
                    Else
                        Console.WriteLine("Le client ou la commande sont introuvables.D")
                    End If
                Case 3
                    Console.WriteLine("Au revoir.")
                Case Else
                    Console.WriteLine("Saisie erronée")
            End Select
        Loop Until choix = 3
        Console.ReadLine()

    End Sub

End Module
