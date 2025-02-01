'Imports System.CodeDom
'Imports System.IO
'Imports System.Data
'Public Class Form2
'    Private dt As New DataTable()
'    Private indexSelectionne As Integer = -1
'    Private dtFilter As New DataView() 'vue filtrée du dataTable

'    Private filePath As String = "products2.csv"
'    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        dt.Columns.Add("CodeProd", GetType(String))
'        dt.Columns.Add("Libelle", GetType(String))
'        dt.Columns.Add("Prix", GetType(String))

'        dtFilter = New DataView(dt)
'        dgvProduits.DataSource = dtFilter


'        ChargerProduits(filePath)
'    End Sub

'    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
'        If txtCodProd.Text = "" Or txtPrix.Text = "" Or txtLibelle.Text = "" Then
'            MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Exit Sub
'        End If

'        'vérifier si le Code est déjà utilisé
'        For Each row As DataRow In dt.Rows
'            If row("CodeProd").ToString() = txtCodProd.Text Then
'                MessageBox.Show("Ce code de produit existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Exit Sub
'            End If
'        Next

'        'Ajouter l'étudiant au DataTable
'        dt.Rows.Add(txtCodProd.Text, txtLibelle.Text, txtPrix.Text)

'        Sauvegarder()

'        ReinitialiserChamps()
'    End Sub

'    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
'        If dgvProduits.SelectedRows.Count > 0 Then
'            dgvProduits.Rows.RemoveAt(dgvProduits.SelectedRows(0).Index)
'        Else
'            MessageBox.Show("Veuillez selectionner un produit à supprimer !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        End If
'    End Sub

'    Private Sub dgvProduits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduits.CellClick
'        If e.RowIndex >= 0 Then
'            indexSelectionne = e.RowIndex
'            txtCodProd.Text = dgvProduits.Rows(e.RowIndex).Cells(0).Value.ToString()
'            txtLibelle.Text = dgvProduits.Rows(e.RowIndex).Cells(1).Value.ToString()
'            txtPrix.Text = dgvProduits.Rows(e.RowIndex).Cells(2).Value.ToString()
'        End If
'    End Sub

'    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
'        If indexSelectionne < 0 Then
'            MessageBox.Show("Veuillez selectionner un produit à modifier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Exit Sub
'        End If

'        If txtCodProd.Text = "" Or txtPrix.Text = "" Or txtLibelle.Text = "" Then
'            MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Exit Sub
'        End If

'        'vérifier si le Code est déjà utilisé
'        For Each row As DataRow In dt.Rows
'            If dt.Rows(indexSelectionne)("CodeProd") <> txtCodProd.Text Then
'                If row("CodeProd").ToString = txtCodProd.Text Then
'                    MessageBox.Show("Ce matricule existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                    Exit Sub
'                End If
'            End If
'        Next

'        dt.Rows(indexSelectionne)("CodeProd") = txtCodProd.Text
'        dt.Rows(indexSelectionne)("Libelle") = txtLibelle.Text
'        dt.Rows(indexSelectionne)("Prix") = txtPrix.Text

'        Sauvegarder()

'        ReinitialiserChamps()
'    End Sub


'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
'            dt.Clear()
'            ChargerProduits(OpenFileDialog1.FileName)
'        End If
'    End Sub

'    Private Sub Sauvegarder()
'        Try
'            Using writer As New StreamWriter(filePath)
'                For Each row As DataRow In dt.Rows
'                    writer.WriteLine($"{row("CodeProd")},{row("Libelle")},{row("Prix")}")
'                Next
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Erreur lors de la sauvegarde des produits : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub ChargerProduits(filePath As String)
'        If File.Exists(filePath) Then
'            Try
'                Using reader As New StreamReader(filePath)
'                    While Not reader.EndOfStream
'                        Dim ligne As String = reader.ReadLine()
'                        Dim valeurs() As String = ligne.Split(","c)

'                        If valeurs.Length = 3 Then
'                            dt.Rows.Add(valeurs(0), valeurs(1), valeurs(2))
'                        End If
'                    End While
'                End Using

'                Dim fichier = New FileInfo(filePath)
'                txtTaille.Text = "Taille : " & fichier.Length.ToString & " ko"
'                txtDate.Text = "Date : " & fichier.CreationTime.ToLongDateString
'            Catch ex As Exception
'                MessageBox.Show("Erreur lors du chargement des produits : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If
'    End Sub

'    Private Sub ReinitialiserChamps()
'        'Reinitialiser les champs
'        txtCodProd.Clear()
'        txtLibelle.Clear()
'        txtPrix.Clear()
'        indexSelectionne = -1
'    End Sub

'    Private Sub txtRecherche_TextChanged(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged
'        dtFilter.RowFilter = $"CodeProd LIKE '%{txtRecherche.Text}%' OR Libelle LIKE '%{txtRecherche.Text}%' OR Prix LIKE '%{txtRecherche.Text}%'"
'    End Sub


'    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
'        Form1.Close()
'    End Sub

'End Class