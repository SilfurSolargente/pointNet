Public Class Eleve
    Private Const MAXNOTE = 9
    Private numéro As String
    Private nom As String
    Private prénom As String
    Private adresse As String
    Private numTel As String
    Private dateNaiss As String
    Private numClasse As String
    Private tabNotes(MAXNOTE) As Double

    Public Sub New(ByVal newNuméro As String, ByVal newNom As String, ByVal newPrénom As String, ByVal newAdresse As String,
      ByVal newNumTel As String, ByVal newDateNaiss As String, ByVal newNumClasse As String)
        numéro = newNuméro
        nom = newNom
        prénom = newPrénom
        adresse = newAdresse
        numTel = newNumTel
        dateNaiss = newDateNaiss
        numClasse = newNumClasse
        tabNotes = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1}
    End Sub

    Public Sub New()
        numéro = ""
        nom = ""
        prénom = ""
        adresse = ""
        numTel = ""
        dateNaiss = ""
        numClasse = ""
        tabNotes = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1}
    End Sub

    Public Function GetNuméro() As String
        Return numéro
    End Function

    Public Function GetNom() As String
        Return nom
    End Function

    Public Sub SetNom(ByVal newNom)
        nom = newNom
    End Sub

    Public Function GetPrenom() As String
        Return prénom
    End Function

    Public Sub SetPrenom(ByVal newPrénom)
        prénom = newPrénom
    End Sub

    Public Function GetNumTel() As String
        Return numTel
    End Function

    Public Sub SetNumTel(ByVal newNumTel)
        numTel = newNumTel
    End Sub

    Public Function GetAdresse() As String
        Return adresse
    End Function

    Public Sub SetAdresse(ByVal newAdresse)
        adresse = newAdresse
    End Sub

    Public Function GetDatNaiss() As String
        Return dateNaiss
    End Function

    Public Function GetNumClasse() As String
        Return numClasse
    End Function

    Public Sub SetNumClasse(ByVal newNumClasse As String)
        numClasse = newNumClasse
    End Sub

    Public Function Moyenne() As Double
        Dim somme As Double
        Dim nbNotes As Integer
        nbNotes = 0
        somme = 0
        For i = 0 To MAXNOTE
            If tabNotes(i) <> -1 Then
                somme += tabNotes(i)
                nbNotes += 1
            End If
        Next
        If nbNotes = 0 Then
            Return -1
        End If
        Return somme / nbNotes
    End Function

    Public Sub SetNote(ByVal noMatière As Integer, ByVal note As Double)
        tabNotes(noMatière) = note
    End Sub

    Public Overrides Function ToString() As String
        Return "Nom : " + nom + vbNewLine + "Prénom : " + prénom + vbNewLine + "Adresse : " + adresse + vbNewLine _
            + ""
    End Function
End Class
