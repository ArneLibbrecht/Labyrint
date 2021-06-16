<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpelscherm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpelscherm))
        Me.grpSpelruimte = New System.Windows.Forms.GroupBox()
        Me.PnlGegevens = New System.Windows.Forms.Panel()
        Me.btnPauze = New System.Windows.Forms.Button()
        Me.pnlBollen = New System.Windows.Forms.Panel()
        Me.pnlReturns = New System.Windows.Forms.Panel()
        Me.lblTijd = New System.Windows.Forms.Label()
        Me.lblReturns = New System.Windows.Forms.Label()
        Me.lblUReturns = New System.Windows.Forms.Label()
        Me.pnlLevel = New System.Windows.Forms.Panel()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblULevel = New System.Windows.Forms.Label()
        Me.pnlScore = New System.Windows.Forms.Panel()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblUScore = New System.Windows.Forms.Label()
        Me.picLaden = New System.Windows.Forms.PictureBox()
        Me.PnlGegevens.SuspendLayout()
        Me.pnlBollen.SuspendLayout()
        Me.pnlReturns.SuspendLayout()
        Me.pnlLevel.SuspendLayout()
        Me.pnlScore.SuspendLayout()
        CType(Me.picLaden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSpelruimte
        '
        Me.grpSpelruimte.BackColor = System.Drawing.Color.Black
        Me.grpSpelruimte.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpSpelruimte.Enabled = False
        Me.grpSpelruimte.Location = New System.Drawing.Point(12, 116)
        Me.grpSpelruimte.Name = "grpSpelruimte"
        Me.grpSpelruimte.Size = New System.Drawing.Size(200, 100)
        Me.grpSpelruimte.TabIndex = 1
        Me.grpSpelruimte.TabStop = False
        '
        'PnlGegevens
        '
        Me.PnlGegevens.BackColor = System.Drawing.Color.White
        Me.PnlGegevens.BackgroundImage = CType(resources.GetObject("PnlGegevens.BackgroundImage"), System.Drawing.Image)
        Me.PnlGegevens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlGegevens.Controls.Add(Me.btnPauze)
        Me.PnlGegevens.Controls.Add(Me.pnlBollen)
        Me.PnlGegevens.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlGegevens.Location = New System.Drawing.Point(0, 0)
        Me.PnlGegevens.Name = "PnlGegevens"
        Me.PnlGegevens.Size = New System.Drawing.Size(953, 144)
        Me.PnlGegevens.TabIndex = 2
        Me.PnlGegevens.Visible = False
        '
        'btnPauze
        '
        Me.btnPauze.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPauze.BackColor = System.Drawing.Color.Transparent
        Me.btnPauze.BackgroundImage = Global.Labyrint.My.Resources.Resources.Sluiten
        Me.btnPauze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPauze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPauze.Location = New System.Drawing.Point(914, 0)
        Me.btnPauze.Name = "btnPauze"
        Me.btnPauze.Size = New System.Drawing.Size(39, 33)
        Me.btnPauze.TabIndex = 4
        Me.btnPauze.UseVisualStyleBackColor = False
        '
        'pnlBollen
        '
        Me.pnlBollen.BackColor = System.Drawing.Color.Transparent
        Me.pnlBollen.Controls.Add(Me.pnlReturns)
        Me.pnlBollen.Controls.Add(Me.pnlLevel)
        Me.pnlBollen.Controls.Add(Me.pnlScore)
        Me.pnlBollen.Location = New System.Drawing.Point(248, -2)
        Me.pnlBollen.Name = "pnlBollen"
        Me.pnlBollen.Size = New System.Drawing.Size(464, 143)
        Me.pnlBollen.TabIndex = 3
        '
        'pnlReturns
        '
        Me.pnlReturns.BackColor = System.Drawing.Color.Transparent
        Me.pnlReturns.BackgroundImage = Global.Labyrint.My.Resources.Resources.BolGegevens
        Me.pnlReturns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlReturns.Controls.Add(Me.lblTijd)
        Me.pnlReturns.Controls.Add(Me.lblReturns)
        Me.pnlReturns.Controls.Add(Me.lblUReturns)
        Me.pnlReturns.Location = New System.Drawing.Point(315, 3)
        Me.pnlReturns.Name = "pnlReturns"
        Me.pnlReturns.Size = New System.Drawing.Size(146, 140)
        Me.pnlReturns.TabIndex = 1
        '
        'lblTijd
        '
        Me.lblTijd.AutoSize = True
        Me.lblTijd.BackColor = System.Drawing.Color.Transparent
        Me.lblTijd.Font = New System.Drawing.Font("Centaur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTijd.ForeColor = System.Drawing.Color.Lime
        Me.lblTijd.Location = New System.Drawing.Point(73, 98)
        Me.lblTijd.Name = "lblTijd"
        Me.lblTijd.Size = New System.Drawing.Size(0, 21)
        Me.lblTijd.TabIndex = 0
        Me.lblTijd.Visible = False
        '
        'lblReturns
        '
        Me.lblReturns.AutoSize = True
        Me.lblReturns.BackColor = System.Drawing.Color.Transparent
        Me.lblReturns.Font = New System.Drawing.Font("Centaur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturns.ForeColor = System.Drawing.Color.Lime
        Me.lblReturns.Location = New System.Drawing.Point(63, 68)
        Me.lblReturns.Name = "lblReturns"
        Me.lblReturns.Size = New System.Drawing.Size(0, 21)
        Me.lblReturns.TabIndex = 0
        '
        'lblUReturns
        '
        Me.lblUReturns.AutoSize = True
        Me.lblUReturns.BackColor = System.Drawing.Color.Transparent
        Me.lblUReturns.Font = New System.Drawing.Font("Castellar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUReturns.ForeColor = System.Drawing.Color.Lime
        Me.lblUReturns.Location = New System.Drawing.Point(21, 22)
        Me.lblUReturns.Name = "lblUReturns"
        Me.lblUReturns.Size = New System.Drawing.Size(107, 23)
        Me.lblUReturns.TabIndex = 0
        Me.lblUReturns.Text = "RETURNS"
        '
        'pnlLevel
        '
        Me.pnlLevel.BackColor = System.Drawing.Color.Transparent
        Me.pnlLevel.BackgroundImage = Global.Labyrint.My.Resources.Resources.BolGegevens
        Me.pnlLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlLevel.Controls.Add(Me.lblLevel)
        Me.pnlLevel.Controls.Add(Me.lblULevel)
        Me.pnlLevel.Location = New System.Drawing.Point(8, 4)
        Me.pnlLevel.Name = "pnlLevel"
        Me.pnlLevel.Size = New System.Drawing.Size(152, 140)
        Me.pnlLevel.TabIndex = 1
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Centaur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.Lime
        Me.lblLevel.Location = New System.Drawing.Point(65, 67)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(0, 21)
        Me.lblLevel.TabIndex = 0
        '
        'lblULevel
        '
        Me.lblULevel.AutoSize = True
        Me.lblULevel.BackColor = System.Drawing.Color.Transparent
        Me.lblULevel.Font = New System.Drawing.Font("Castellar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblULevel.ForeColor = System.Drawing.Color.Lime
        Me.lblULevel.Location = New System.Drawing.Point(39, 20)
        Me.lblULevel.Name = "lblULevel"
        Me.lblULevel.Size = New System.Drawing.Size(71, 23)
        Me.lblULevel.TabIndex = 0
        Me.lblULevel.Text = "Level"
        '
        'pnlScore
        '
        Me.pnlScore.BackColor = System.Drawing.Color.Transparent
        Me.pnlScore.BackgroundImage = Global.Labyrint.My.Resources.Resources.BolGegevens
        Me.pnlScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlScore.Controls.Add(Me.lblScore)
        Me.pnlScore.Controls.Add(Me.lblUScore)
        Me.pnlScore.Location = New System.Drawing.Point(163, 3)
        Me.pnlScore.Name = "pnlScore"
        Me.pnlScore.Size = New System.Drawing.Size(146, 140)
        Me.pnlScore.TabIndex = 1
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Centaur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Lime
        Me.lblScore.Location = New System.Drawing.Point(56, 68)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 21)
        Me.lblScore.TabIndex = 0
        '
        'lblUScore
        '
        Me.lblUScore.AutoSize = True
        Me.lblUScore.BackColor = System.Drawing.Color.Transparent
        Me.lblUScore.Font = New System.Drawing.Font("Castellar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUScore.ForeColor = System.Drawing.Color.Lime
        Me.lblUScore.Location = New System.Drawing.Point(35, 23)
        Me.lblUScore.Name = "lblUScore"
        Me.lblUScore.Size = New System.Drawing.Size(76, 23)
        Me.lblUScore.TabIndex = 0
        Me.lblUScore.Text = "SCORE"
        '
        'picLaden
        '
        Me.picLaden.Image = Global.Labyrint.My.Resources.Resources.VoetstappenLaden
        Me.picLaden.Location = New System.Drawing.Point(328, 203)
        Me.picLaden.Name = "picLaden"
        Me.picLaden.Size = New System.Drawing.Size(298, 50)
        Me.picLaden.TabIndex = 3
        Me.picLaden.TabStop = False
        Me.picLaden.Visible = False
        '
        'frmSpelscherm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 550)
        Me.Controls.Add(Me.picLaden)
        Me.Controls.Add(Me.PnlGegevens)
        Me.Controls.Add(Me.grpSpelruimte)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSpelscherm"
        Me.Text = "Spelscherm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlGegevens.ResumeLayout(False)
        Me.pnlBollen.ResumeLayout(False)
        Me.pnlReturns.ResumeLayout(False)
        Me.pnlReturns.PerformLayout()
        Me.pnlLevel.ResumeLayout(False)
        Me.pnlLevel.PerformLayout()
        Me.pnlScore.ResumeLayout(False)
        Me.pnlScore.PerformLayout()
        CType(Me.picLaden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSpelruimte As System.Windows.Forms.GroupBox
    Friend WithEvents PnlGegevens As System.Windows.Forms.Panel
    Friend WithEvents lblUScore As System.Windows.Forms.Label
    Friend WithEvents lblULevel As System.Windows.Forms.Label
    Friend WithEvents lblUReturns As System.Windows.Forms.Label
    Friend WithEvents pnlReturns As System.Windows.Forms.Panel
    Friend WithEvents pnlScore As System.Windows.Forms.Panel
    Friend WithEvents pnlLevel As System.Windows.Forms.Panel
    Friend WithEvents pnlBollen As System.Windows.Forms.Panel
    Friend WithEvents lblReturns As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picLaden As System.Windows.Forms.PictureBox
    Friend WithEvents lblTijd As System.Windows.Forms.Label
    Friend WithEvents btnPauze As System.Windows.Forms.Button
End Class
