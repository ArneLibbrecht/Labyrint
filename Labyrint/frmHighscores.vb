Imports Labyrint.mdlFunctiesEnSubs

Public Class frmHighscores



    Private Sub frmHighscores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        For Each Control As Control In Me.Controls
            ControlCentr(Control, , Me.Width, Me.Height, Me.Width, Me.Height)

        Next
        'lijst opmaken
        Highscorelijst()
        'lijst tonen
        For Each score As String In My.Settings.High

            lstHighscores.Items.Add(score)
        Next

    End Sub


    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_mouseenter(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnTerug.MouseEnter
        'Dit zorgt ervoor dat de rand van de knop waar de muis binnenkomt, groen kleurt 
        sender.FlatAppearance.BorderColor = Color.Lime
    End Sub
    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_Mouseleave(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnTerug.MouseLeave
        'Dit zorgt ervoor dat de rand van de knop waar de muis buitengaat, zwart kleurt 
        sender.FlatAppearance.BorderColor = Color.Black
    End Sub


    Private Sub btnTerug_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        frmStartscherm.Show()
        Me.Close()

    End Sub
End Class