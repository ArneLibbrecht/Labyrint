<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialoogJaNee
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
        Me.btnJa = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnNee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJa
        '
        Me.btnJa.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnJa.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnJa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJa.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJa.ForeColor = System.Drawing.Color.Lime
        Me.btnJa.Location = New System.Drawing.Point(116, 124)
        Me.btnJa.Name = "btnJa"
        Me.btnJa.Size = New System.Drawing.Size(75, 23)
        Me.btnJa.TabIndex = 2
        Me.btnJa.Text = "Ja"
        Me.btnJa.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Font = New System.Drawing.Font("Centaur", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.Lime
        Me.lblPrompt.Location = New System.Drawing.Point(104, 56)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPrompt.Size = New System.Drawing.Size(248, 48)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNee
        '
        Me.btnNee.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNee.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnNee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNee.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNee.ForeColor = System.Drawing.Color.Lime
        Me.btnNee.Location = New System.Drawing.Point(244, 124)
        Me.btnNee.Name = "btnNee"
        Me.btnNee.Size = New System.Drawing.Size(75, 23)
        Me.btnNee.TabIndex = 2
        Me.btnNee.Text = "Nee"
        Me.btnNee.UseVisualStyleBackColor = True
        '
        'frmDialoogJaNee
        '
        Me.AcceptButton = Me.btnJa
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnNee
        Me.ClientSize = New System.Drawing.Size(456, 159)
        Me.Controls.Add(Me.btnNee)
        Me.Controls.Add(Me.btnJa)
        Me.Controls.Add(Me.lblPrompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDialoogJaNee"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialoog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnJa As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents btnNee As System.Windows.Forms.Button
End Class
