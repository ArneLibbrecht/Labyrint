Public Class frmDialoogJaNee
    Public Sub Toon(ByVal strPrompt As String)

        lblPrompt.Text = strPrompt
        Me.ShowDialog()
    End Sub




    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_mouseenter(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnJa.MouseEnter, btnJa.MouseLeave
        'Dit zorgt ervoor dat de rand van de knop waar de muis binnenkomt, groen kleurt 
        sender.FlatAppearance.BorderColor = Color.Lime
    End Sub
    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_Mouseleave(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnJa.MouseLeave, btnNee.MouseLeave
        'Dit zorgt ervoor dat de rand van de knop waar de muis buitengaat, zwart kleurt 
        sender.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub btnJa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnJa.Click
        Me.DialogResult = DialogResult.Yes
    End Sub


    Private Sub btnNee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNee.Click
        Me.DialogResult = DialogResult.No
    End Sub
End Class