Public Class frmDialoog

    Public Sub Toon(ByVal strPrompt As String)

        lblPrompt.Text = strPrompt
        Me.ShowDialog()
    End Sub


    'Doorgeven dat er op Ok werd gedrukt.
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub


    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_mouseenter(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnOK.MouseEnter
        'Dit zorgt ervoor dat de rand van de knop waar de muis binnenkomt, groen kleurt 
        sender.FlatAppearance.BorderColor = Color.Lime
    End Sub
    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_Mouseleave(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        'Dit zorgt ervoor dat de rand van de knop waar de muis buitengaat, zwart kleurt 
        sender.FlatAppearance.BorderColor = Color.Black
    End Sub

End Class