<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.btnTerug = New System.Windows.Forms.Button()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.lblUitleg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTerug
        '
        Me.btnTerug.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerug.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerug.ForeColor = System.Drawing.Color.Lime
        Me.btnTerug.Location = New System.Drawing.Point(421, 489)
        Me.btnTerug.Name = "btnTerug"
        Me.btnTerug.Size = New System.Drawing.Size(110, 39)
        Me.btnTerug.TabIndex = 7
        Me.btnTerug.Text = "Terug"
        Me.btnTerug.UseVisualStyleBackColor = True
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Castellar", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.Color.Lime
        Me.lblTitel.Location = New System.Drawing.Point(372, 22)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(208, 77)
        Me.lblTitel.TabIndex = 6
        Me.lblTitel.Text = "Help"
        Me.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUitleg
        '
        Me.lblUitleg.AutoSize = True
        Me.lblUitleg.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUitleg.ForeColor = System.Drawing.Color.Lime
        Me.lblUitleg.Location = New System.Drawing.Point(280, 99)
        Me.lblUitleg.Name = "lblUitleg"
        Me.lblUitleg.Size = New System.Drawing.Size(390, 306)
        Me.lblUitleg.TabIndex = 8
        Me.lblUitleg.Text = resources.GetString("lblUitleg.Text")
        '
        'frmHelp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 550)
        Me.Controls.Add(Me.lblUitleg)
        Me.Controls.Add(Me.btnTerug)
        Me.Controls.Add(Me.lblTitel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHelp"
        Me.Text = "frmStartscherm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTerug As System.Windows.Forms.Button
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents lblUitleg As System.Windows.Forms.Label
End Class
