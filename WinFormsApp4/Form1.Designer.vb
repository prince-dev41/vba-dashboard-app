<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Identifiant = New TextBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Password = New TextBox()
        PictureBox3 = New PictureBox()
        SubmitButton = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(107, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 126)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(96, 166)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(5)
        Label1.Size = New Size(191, 47)
        Label1.TabIndex = 1
        Label1.Text = "Se connecter"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Identifiant)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(12, 228)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 40)
        Panel1.TabIndex = 2
        ' 
        ' Identifiant
        ' 
        Identifiant.BorderStyle = BorderStyle.None
        Identifiant.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Identifiant.Location = New Point(53, 3)
        Identifiant.Multiline = True
        Identifiant.Name = "Identifiant"
        Identifiant.Size = New Size(294, 34)
        Identifiant.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 1)
        PictureBox2.Margin = New Padding(5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Padding = New Padding(5)
        PictureBox2.Size = New Size(43, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Password)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(12, 292)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 40)
        Panel2.TabIndex = 3
        ' 
        ' Password
        ' 
        Password.BorderStyle = BorderStyle.None
        Password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(53, 6)
        Password.Multiline = True
        Password.Name = "Password"
        Password.PasswordChar = "."c
        Password.Size = New Size(294, 31)
        Password.TabIndex = 5
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(2, 0)
        PictureBox3.Margin = New Padding(10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(46, 37)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitButton.Location = New Point(12, 350)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(350, 43)
        SubmitButton.TabIndex = 4
        SubmitButton.Text = "Soumettre"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(404, 498)
        Controls.Add(SubmitButton)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Identifiant As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Password As TextBox

End Class
