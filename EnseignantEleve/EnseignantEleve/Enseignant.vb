Public Class Enseignant
    Private Const VALEURINDICE = 13.754
    Private numéro As String
    Private nom As String
    Private prénom As String
    Private adresse As String
    Private numTel As String
    Private dateNaiss As String
    Private indice As Integer
    Private nombreDHeures As Double

    Public Sub New(ByVal newNum As String, ByVal newNom As String, ByVal NewPrénom As String, ByVal newAdresse As String,
                   ByVal newNumTel As String, ByVal newDateNaiss As String, ByVal newIndice As Integer, ByVal newNombreDHeures As Double)
        numéro = newNum
        nom = newNom
        prénom = NewPrénom
        adresse = newAdresse
        numTel = newNumTel
        dateNaiss = newDateNaiss
        indice = newIndice
        nombreDHeures = newNombreDHeures
    End Sub

    Public Sub New()
        numéro = ""
        nom = ""
        prénom = ""
        adresse = ""
        numTel = ""
        dateNaiss = ""
        indice = 0
        nombreDHeures = 0
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

    Public Function AugmenterIndice(ByVal nouvIndice As Integer) As Boolean
        If nouvIndice < indice Then
            Return False
        End If
        indice = nouvIndice
        Return True
    End Function

    Public Function GetIndice() As Integer
        Return indice
    End Function

    Public Sub SetNombreDHeures(ByVal newNombreHeures As Double)
        If newNombreHeures < 0 Then
            Console.WriteLine("Le nombre d'heure ne peut pas être inférieur a 0")
        Else
            nombreDHeures = newNombreHeures
        End If
    End Sub

    Public Function GetNombreDHeures() As Double
        Return nombreDHeures
    End Function

    Public Function Salaire() As Double
        Return nombreDHeures * indice * VALEURINDICE
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
