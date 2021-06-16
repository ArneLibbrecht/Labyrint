<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighscores
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
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.btnTerug = New System.Windows.Forms.Button()
        Me.lstHighscores = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Castellar", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.Color.Lime
        Me.lblTitel.Location = New System.Drawing.Point(249, 20)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(478, 77)
        Me.lblTitel.TabIndex = 1
        Me.lblTitel.Text = "Highscores"
        Me.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnTerug.TabIndex = 4
        Me.btnTerug.Text = "Terug"
        Me.btnTerug.UseVisualStyleBackColor = True
        '
        'lstHighscores
        '
        Me.lstHighscores.BackColor = System.Drawing.Color.Black
        Me.lstHighscores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstHighscores.Font = New System.Drawing.Font("Centaur", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHighscores.ForeColor = System.Drawing.Color.Lime
        Me.lstHighscores.FormattingEnabled = True
        Me.lstHighscores.ItemHeight = 27
        Me.lstHighscores.Location = New System.Drawing.Point(152, 100)
        Me.lstHighscores.Name = "lstHighscores"
        Me.lstHighscores.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstHighscores.Size = New System.Drawing.Size(648, 378)
        Me.lstHighscores.TabIndex = 2
        '
        'frmHighscores
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 550)
        Me.Controls.Add(Me.lstHighscores)
        Me.Controls.Add(Me.btnTerug)
        Me.Controls.Add(Me.lblTitel)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHighscores"
        Me.Text = "Highscores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents btnTerug As System.Windows.Forms.Button
    Friend WithEvents lstHighscores As System.Windows.Forms.ListBox
End Class
