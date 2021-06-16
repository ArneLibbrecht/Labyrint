<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPauze
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTerugStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Castellar", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.Color.Lime
        Me.lblTitel.Location = New System.Drawing.Point(346, 24)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(260, 77)
        Me.lblTitel.TabIndex = 1
        Me.lblTitel.Text = "Pauze"
        Me.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTerug
        '
        Me.btnTerug.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerug.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerug.ForeColor = System.Drawing.Color.Lime
        Me.btnTerug.Location = New System.Drawing.Point(421, 278)
        Me.btnTerug.Name = "btnTerug"
        Me.btnTerug.Size = New System.Drawing.Size(110, 39)
        Me.btnTerug.TabIndex = 4
        Me.btnTerug.Text = "Terug"
        Me.btnTerug.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Lime
        Me.btnExit.Location = New System.Drawing.Point(421, 402)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTerugStart
        '
        Me.btnTerugStart.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnTerugStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerugStart.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerugStart.ForeColor = System.Drawing.Color.Lime
        Me.btnTerugStart.Location = New System.Drawing.Point(421, 164)
        Me.btnTerugStart.Name = "btnTerugStart"
        Me.btnTerugStart.Size = New System.Drawing.Size(110, 39)
        Me.btnTerugStart.TabIndex = 4
        Me.btnTerugStart.Text = "Start"
        Me.btnTerugStart.UseVisualStyleBackColor = True
        '
        'frmPauze
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 550)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTerugStart)
        Me.Controls.Add(Me.btnTerug)
        Me.Controls.Add(Me.lblTitel)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPauze"
        Me.Text = "Pauze"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents btnTerug As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTerugStart As System.Windows.Forms.Button

End Class
