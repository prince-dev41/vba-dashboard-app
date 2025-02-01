<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Panel1 = New Panel()
        AddButton = New Button()
        PrenomTextBox = New TextBox()
        NomTextBox = New TextBox()
        MatriculeTextBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        SearchTextBox = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        ModifyButton = New Button()
        DeleteButton = New Button()
        BtnSave = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(343, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(255, 37)
        Label1.TabIndex = 0
        Label1.Text = "Liste des Etudiants"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(AddButton)
        Panel1.Controls.Add(PrenomTextBox)
        Panel1.Controls.Add(NomTextBox)
        Panel1.Controls.Add(MatriculeTextBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(23, 79)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(906, 116)
        Panel1.TabIndex = 1
        ' 
        ' AddButton
        ' 
        AddButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddButton.Location = New Point(738, 31)
        AddButton.Margin = New Padding(3, 4, 3, 4)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(159, 63)
        AddButton.TabIndex = 6
        AddButton.Text = "Ajouter"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' PrenomTextBox
        ' 
        PrenomTextBox.Location = New Point(531, 43)
        PrenomTextBox.Margin = New Padding(3, 4, 3, 4)
        PrenomTextBox.Multiline = True
        PrenomTextBox.Name = "PrenomTextBox"
        PrenomTextBox.Size = New Size(177, 51)
        PrenomTextBox.TabIndex = 5
        ' 
        ' NomTextBox
        ' 
        NomTextBox.Location = New Point(270, 43)
        NomTextBox.Margin = New Padding(3, 4, 3, 4)
        NomTextBox.Multiline = True
        NomTextBox.Name = "NomTextBox"
        NomTextBox.Size = New Size(221, 49)
        NomTextBox.TabIndex = 4
        ' 
        ' MatriculeTextBox
        ' 
        MatriculeTextBox.Location = New Point(3, 43)
        MatriculeTextBox.Margin = New Padding(3, 4, 3, 4)
        MatriculeTextBox.Multiline = True
        MatriculeTextBox.Name = "MatriculeTextBox"
        MatriculeTextBox.Size = New Size(231, 51)
        MatriculeTextBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(531, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 21)
        Label4.TabIndex = 2
        Label4.Text = "Prénoms :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(270, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 21)
        Label3.TabIndex = 1
        Label3.Text = "Nom :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 21)
        Label2.TabIndex = 0
        Label2.Text = "Matricule :"
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Location = New Point(23, 203)
        SearchTextBox.Margin = New Padding(3, 4, 3, 4)
        SearchTextBox.Multiline = True
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.Size = New Size(708, 63)
        SearchTextBox.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(26, 293)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(705, 333)
        DataGridView1.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Matricule"
        Column1.Name = "Column1"
        Column1.Width = 220
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nom"
        Column2.Name = "Column2"
        Column2.Width = 220
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Prénom"
        Column3.Name = "Column3"
        Column3.Width = 220
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Prénom"
        Column4.Name = "Column4"
        ' 
        ' ModifyButton
        ' 
        ModifyButton.BackColor = Color.Blue
        ModifyButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ModifyButton.ForeColor = Color.Transparent
        ModifyButton.Location = New Point(761, 293)
        ModifyButton.Margin = New Padding(3, 4, 3, 4)
        ModifyButton.Name = "ModifyButton"
        ModifyButton.Size = New Size(168, 65)
        ModifyButton.TabIndex = 4
        ModifyButton.Text = "Modifier"
        ModifyButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.Red
        DeleteButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteButton.ForeColor = Color.White
        DeleteButton.Location = New Point(761, 394)
        DeleteButton.Margin = New Padding(3, 4, 3, 4)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(168, 60)
        DeleteButton.TabIndex = 5
        DeleteButton.Text = "Supprimer"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.ForestGreen
        BtnSave.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(761, 475)
        BtnSave.Margin = New Padding(3, 4, 3, 4)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(168, 60)
        BtnSave.TabIndex = 6
        BtnSave.Text = "Sauvegarder"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(960, 656)
        Controls.Add(BtnSave)
        Controls.Add(DeleteButton)
        Controls.Add(ModifyButton)
        Controls.Add(DataGridView1)
        Controls.Add(SearchTextBox)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Gestion des Etudiants"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents PrenomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MatriculeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModifyButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnSave As Button

End Class
