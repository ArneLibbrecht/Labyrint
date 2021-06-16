<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNiveau
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnMakkelijk = New System.Windows.Forms.Button()
        Me.btnMoeilijk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGemiddeld = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.Lime
        Me.lblPrompt.Location = New System.Drawing.Point(12, 19)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(432, 100)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "Label1"
        '
        'btnMakkelijk
        '
        Me.btnMakkelijk.BackColor = System.Drawing.Color.Black
        Me.btnMakkelijk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMakkelijk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnMakkelijk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnMakkelijk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMakkelijk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakkelijk.Font = New System.Drawing.Font("Castellar", 9.0!)
        Me.btnMakkelijk.ForeColor = System.Drawing.Color.Lime
        Me.btnMakkelijk.Location = New System.Drawing.Point(62, 122)
        Me.btnMakkelijk.Name = "btnMakkelijk"
        Me.btnMakkelijk.Size = New System.Drawing.Size(101, 23)
        Me.btnMakkelijk.TabIndex = 4
        Me.btnMakkelijk.TabStop = False
        Me.btnMakkelijk.Text = "Makkelijk"
        Me.btnMakkelijk.UseVisualStyleBackColor = False
        '
        'btnMoeilijk
        '
        Me.btnMoeilijk.BackColor = System.Drawing.Color.Black
        Me.btnMoeilijk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMoeilijk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnMoeilijk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnMoeilijk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMoeilijk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoeilijk.Font = New System.Drawing.Font("Castellar", 9.0!)
        Me.btnMoeilijk.ForeColor = System.Drawing.Color.Lime
        Me.btnMoeilijk.Location = New System.Drawing.Point(276, 122)
        Me.btnMoeilijk.Name = "btnMoeilijk"
        Me.btnMoeilijk.Size = New System.Drawing.Size(84, 23)
        Me.btnMoeilijk.TabIndex = 5
        Me.btnMoeilijk.TabStop = False
        Me.btnMoeilijk.Text = "Moeilijk"
        Me.btnMoeilijk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Castellar", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Lime
        Me.btnCancel.Location = New System.Drawing.Point(366, 122)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnGemiddeld
        '
        Me.btnGemiddeld.BackColor = System.Drawing.Color.Black
        Me.btnGemiddeld.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGemiddeld.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnGemiddeld.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnGemiddeld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGemiddeld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGemiddeld.Font = New System.Drawing.Font("Castellar", 9.0!)
        Me.btnGemiddeld.ForeColor = System.Drawing.Color.Lime
        Me.btnGemiddeld.Location = New System.Drawing.Point(169, 122)
        Me.btnGemiddeld.Name = "btnGemiddeld"
        Me.btnGemiddeld.Size = New System.Drawing.Size(101, 23)
        Me.btnGemiddeld.TabIndex = 4
        Me.btnGemiddeld.TabStop = False
        Me.btnGemiddeld.Text = "Gemiddeld"
        Me.btnGemiddeld.UseVisualStyleBackColor = False
        '
        'frmNiveau
        '
        Me.AcceptButton = Me.btnMakkelijk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(456, 159)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnMoeilijk)
        Me.Controls.Add(Me.btnGemiddeld)
        Me.Controls.Add(Me.btnMakkelijk)
        Me.Controls.Add(Me.lblPrompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNiveau"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNiveau"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents btnMakkelijk As System.Windows.Forms.Button
    Friend WithEvents btnMoeilijk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGemiddeld As System.Windows.Forms.Button
End Class
