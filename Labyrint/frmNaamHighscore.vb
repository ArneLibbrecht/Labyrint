Public Class frmNaamHighscore

    'Doorgeven dat er op Ok werd gedrukt.
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
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

    Private Sub txtNaam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaam.TextChanged

        'gebruiker kan geen . in de naam gebruiken.
        If txtNaam.Text(txtNaam.TextLength - 1) = "." Then
            txtNaam.Text.Remove(txtNaam.TextLength - 1)
        End If


    End Sub
End Class