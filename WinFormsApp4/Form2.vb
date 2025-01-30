Public Class Form2

    ' Liste pour stocker les étudiants
    Private students As New List(Of Student)

    ' Classe pour représenter un étudiant
    Private Class Student
        Public Property Matricule As String
        Public Property Nom As String
        Public Property Prenom As String
    End Class

    ' Constructeur
    Public Sub New()
        InitializeComponent()
        ' Initialiser la DataGridView
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns(0).DataPropertyName = "Matricule"
        DataGridView1.Columns(1).DataPropertyName = "Nom"
        DataGridView1.Columns(2).DataPropertyName = "Prenom"
    End Sub

    ' Gestionnaire d'événements pour le bouton Ajouter
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim matricule As String = MatriculeTextBox.Text
        Dim nom As String = NomTextBox.Text
        Dim prenom As String = PrenomTextBox.Text

        If String.IsNullOrWhiteSpace(matricule) OrElse String.IsNullOrWhiteSpace(nom) OrElse String.IsNullOrWhiteSpace(prenom) Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim newStudent As New Student With {
            .Matricule = matricule,
            .Nom = nom,
            .Prenom = prenom
        }

        students.Add(newStudent)
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = students

        ' Réinitialiser les champs de texte
        MatriculeTextBox.Clear()
        NomTextBox.Clear()
        PrenomTextBox.Clear()
    End Sub

    ' Gestionnaire d'événements pour le bouton Modifier
    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim index As Integer = selectedRow.Index
            Dim student As Student = students(index)

            student.Matricule = MatriculeTextBox.Text
            student.Nom = NomTextBox.Text
            student.Prenom = PrenomTextBox.Text

            DataGridView1.Refresh()
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Gestionnaire d'événements pour le bouton Supprimer
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim index As Integer = selectedRow.Index
            students.RemoveAt(index)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = students
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Gestionnaire d'événements pour la recherche
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim searchText As String = SearchTextBox.Text.ToLower()
        Dim filteredStudents = students.Where(Function(s) s.Matricule.ToLower().Contains(searchText) OrElse s.Nom.ToLower().Contains(searchText) OrElse s.Prenom.ToLower().Contains(searchText)).ToList()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = filteredStudents
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub NomTextBox_TextChanged(sender As Object, e As EventArgs) Handles NomTextBox.TextChanged

    End Sub
End Class
