<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartscherm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartscherm))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Lime
        Me.btnExit.Location = New System.Drawing.Point(300, 434)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(358, 79)
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Castellar", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.Color.Lime
        Me.lblTitel.Location = New System.Drawing.Point(287, 39)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(398, 77)
        Me.lblTitel.TabIndex = 0
        Me.lblTitel.Text = "Labyrint"
        Me.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Lime
        Me.btnStart.Location = New System.Drawing.Point(300, 119)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(358, 79)
        Me.btnStart.TabIndex = 2
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Start spel"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnHighScores
        '
        Me.btnHighScores.BackColor = System.Drawing.Color.Black
        Me.btnHighScores.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHighScores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnHighScores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnHighScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighScores.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScores.ForeColor = System.Drawing.Color.Lime
        Me.btnHighScores.Location = New System.Drawing.Point(300, 193)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(358, 79)
        Me.btnHighScores.TabIndex = 3
        Me.btnHighScores.TabStop = False
        Me.btnHighScores.Text = "High-scores"
        Me.btnHighScores.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Black
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Lime
        Me.btnSettings.Location = New System.Drawing.Point(300, 278)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(358, 79)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.TabStop = False
        Me.btnSettings.Text = "Instellingen"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Black
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.Lime
        Me.btnHelp.Location = New System.Drawing.Point(300, 363)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(358, 79)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.TabStop = False
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'frmStartscherm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 550)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStartscherm"
        Me.Text = "frmStartscherm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnHighScores As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
