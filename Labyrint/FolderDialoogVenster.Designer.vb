<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFolderDialoogVenster
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.trvFolderSelect = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.Color.Lime
        Me.lblTitel.Location = New System.Drawing.Point(177, 22)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitel.Size = New System.Drawing.Size(102, 19)
        Me.lblTitel.TabIndex = 0
        Me.lblTitel.Text = "Verloren"
        Me.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK
        '
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Castellar", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Lime
        Me.btnOK.Location = New System.Drawing.Point(192, 330)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'trvFolderSelect
        '
        Me.trvFolderSelect.BackColor = System.Drawing.Color.Black
        Me.trvFolderSelect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.trvFolderSelect.ForeColor = System.Drawing.Color.Lime
        Me.trvFolderSelect.LineColor = System.Drawing.Color.Lime
        Me.trvFolderSelect.Location = New System.Drawing.Point(48, 53)
        Me.trvFolderSelect.Name = "trvFolderSelect"
        Me.trvFolderSelect.Size = New System.Drawing.Size(369, 256)
        Me.trvFolderSelect.TabIndex = 3
        '
        'frmFolderDialoogVenster
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(456, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.trvFolderSelect)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblTitel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFolderDialoogVenster"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDialoog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitel As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents trvFolderSelect As System.Windows.Forms.TreeView
End Class
