Public Class Form1

    ' Déclaration des variables pour les identifiants statiques
    Private Const VALID_IDENTIFIANT As String = "Admin"
    Private Const VALID_PASSWORD As String = "Password"

    ' Constructeur
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Gestionnaire d'événements pour le bouton de soumission
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Récupérer les valeurs saisies par l'utilisateur
        Dim enteredIdentifiant As String = Identifiant.Text
        Dim enteredPassword As String = Password.Text

        ' Vérifier les informations d'identification
        If enteredIdentifiant = VALID_IDENTIFIANT AndAlso enteredPassword = VALID_PASSWORD Then
            ' Ouvrir le formulaire du tableau de bord
            Dim dashboard As New Form2()
            dashboard.Show()
            Me.Hide() ' Masquer le formulaire de connexion
        Else
            ' Afficher une boîte de dialogue d'erreur
            MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
