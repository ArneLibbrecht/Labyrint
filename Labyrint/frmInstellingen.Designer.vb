<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstellingen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstellingen))
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.pnlInstellingen = New System.Windows.Forms.Panel()
        Me.btnResetSettings = New System.Windows.Forms.Button()
        Me.btnHighScore = New System.Windows.Forms.Button()
        Me.chkJingles = New System.Windows.Forms.CheckBox()
        Me.picSpelerAfbeelding = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblManneke = New System.Windows.Forms.Label()
        Me.fileDialogSpeler = New System.Windows.Forms.OpenFileDialog()
        Me.btnTerug = New System.Windows.Forms.Button()
        Me.lblKleurLabyrint = New System.Windows.Forms.Label()
        Me.pnlKleur = New System.Windows.Forms.Panel()
        Me.pnlInstellingen.SuspendLayout()
        CType(Me.picSpelerAfbeelding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Castellar", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.Color.Lime
        Me.lblTitel.Location = New System.Drawing.Point(206, 32)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(540, 77)
        Me.lblTitel.TabIndex = 2
        Me.lblTitel.Text = "Instellingen"
        Me.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInstellingen
        '
        Me.pnlInstellingen.Controls.Add(Me.pnlKleur)
        Me.pnlInstellingen.Controls.Add(Me.lblKleurLabyrint)
        Me.pnlInstellingen.Controls.Add(Me.btnResetSettings)
        Me.pnlInstellingen.Controls.Add(Me.btnHighScore)
        Me.pnlInstellingen.Controls.Add(Me.chkJingles)
        Me.pnlInstellingen.Controls.Add(Me.picSpelerAfbeelding)
        Me.pnlInstellingen.Controls.Add(Me.Label1)
        Me.pnlInstellingen.Controls.Add(Me.lblManneke)
        Me.pnlInstellingen.Location = New System.Drawing.Point(250, 112)
        Me.pnlInstellingen.Name = "pnlInstellingen"
        Me.pnlInstellingen.Size = New System.Drawing.Size(465, 342)
        Me.pnlInstellingen.TabIndex = 3
        '
        'btnResetSettings
        '
        Me.btnResetSettings.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetSettings.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetSettings.ForeColor = System.Drawing.Color.Lime
        Me.btnResetSettings.Location = New System.Drawing.Point(290, 56)
        Me.btnResetSettings.Name = "btnResetSettings"
        Me.btnResetSettings.Size = New System.Drawing.Size(135, 30)
        Me.btnResetSettings.TabIndex = 6
        Me.btnResetSettings.Text = "Fabrieksinstellingen"
        Me.btnResetSettings.UseVisualStyleBackColor = True
        '
        'btnHighScore
        '
        Me.btnHighScore.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighScore.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.ForeColor = System.Drawing.Color.Lime
        Me.btnHighScore.Location = New System.Drawing.Point(290, 16)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(135, 30)
        Me.btnHighScore.TabIndex = 6
        Me.btnHighScore.Text = "Higshores legen"
        Me.btnHighScore.UseVisualStyleBackColor = True
        '
        'chkJingles
        '
        Me.chkJingles.AutoSize = True
        Me.chkJingles.Location = New System.Drawing.Point(118, 64)
        Me.chkJingles.Name = "chkJingles"
        Me.chkJingles.Size = New System.Drawing.Size(15, 14)
        Me.chkJingles.TabIndex = 2
        Me.chkJingles.UseVisualStyleBackColor = True
        '
        'picSpelerAfbeelding
        '
        Me.picSpelerAfbeelding.Location = New System.Drawing.Point(118, 30)
        Me.picSpelerAfbeelding.Name = "picSpelerAfbeelding"
        Me.picSpelerAfbeelding.Size = New System.Drawing.Size(10, 10)
        Me.picSpelerAfbeelding.TabIndex = 1
        Me.picSpelerAfbeelding.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(3, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Effectjingles"
        '
        'lblManneke
        '
        Me.lblManneke.AutoSize = True
        Me.lblManneke.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManneke.ForeColor = System.Drawing.Color.Lime
        Me.lblManneke.Location = New System.Drawing.Point(3, 22)
        Me.lblManneke.Name = "lblManneke"
        Me.lblManneke.Size = New System.Drawing.Size(109, 18)
        Me.lblManneke.TabIndex = 0
        Me.lblManneke.Text = "Spelerafbeelding:"
        '
        'btnTerug
        '
        Me.btnTerug.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerug.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerug.ForeColor = System.Drawing.Color.Lime
        Me.btnTerug.Location = New System.Drawing.Point(421, 499)
        Me.btnTerug.Name = "btnTerug"
        Me.btnTerug.Size = New System.Drawing.Size(110, 39)
        Me.btnTerug.TabIndex = 5
        Me.btnTerug.Text = "Terug"
        Me.btnTerug.UseVisualStyleBackColor = True
        '
        'lblKleurLabyrint
        '
        Me.lblKleurLabyrint.AutoSize = True
        Me.lblKleurLabyrint.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKleurLabyrint.ForeColor = System.Drawing.Color.Lime
        Me.lblKleurLabyrint.Location = New System.Drawing.Point(3, 101)
        Me.lblKleurLabyrint.Name = "lblKleurLabyrint"
        Me.lblKleurLabyrint.Size = New System.Drawing.Size(91, 18)
        Me.lblKleurLabyrint.TabIndex = 7
        Me.lblKleurLabyrint.Text = "LabyrintKleur"
        '
        'pnlKleur
        '
        Me.pnlKleur.Location = New System.Drawing.Point(118, 101)
        Me.pnlKleur.Name = "pnlKleur"
        Me.pnlKleur.Size = New System.Drawing.Size(14, 17)
        Me.pnlKleur.TabIndex = 8
        '
        'frmInstellingen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 550)
        Me.Controls.Add(Me.btnTerug)
        Me.Controls.Add(Me.pnlInstellingen)
        Me.Controls.Add(Me.lblTitel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInstellingen"
        Me.Text = "frmStartscherm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlInstellingen.ResumeLayout(False)
        Me.pnlInstellingen.PerformLayout()
        CType(Me.picSpelerAfbeelding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents pnlInstellingen As System.Windows.Forms.Panel
    Friend WithEvents lblManneke As System.Windows.Forms.Label
    Friend WithEvents picSpelerAfbeelding As System.Windows.Forms.PictureBox
    Friend WithEvents fileDialogSpeler As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnTerug As System.Windows.Forms.Button
    Friend WithEvents chkJingles As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnResetSettings As System.Windows.Forms.Button
    Friend WithEvents btnHighScore As System.Windows.Forms.Button
    Friend WithEvents pnlKleur As System.Windows.Forms.Panel
    Friend WithEvents lblKleurLabyrint As System.Windows.Forms.Label
End Class
