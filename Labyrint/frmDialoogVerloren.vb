Public Class frmDialoogVerloren

    Private BolSleep As Boolean
    Private pteMuis As New Point

    Public Sub Toon(ByVal strPrompt As String)
        lblPrompt.Text = strPrompt
        Me.ShowDialog()
    End Sub

    'ervoor zorgen dat je het formulier kan bewegen

    Private Sub frmDialoogVerloren_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        BolSleep = True
        pteMuis.X = Windows.Forms.Cursor.Position.X - Me.Left
        pteMuis.Y = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmDialoogVerloren_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If BolSleep Then
            Me.Left = Windows.Forms.Cursor.Position.X - pteMuis.X
            Me.Top = Windows.Forms.Cursor.Position.Y - pteMuis.Y
        End If
    End Sub
    Private Sub frmDialoogVerloren_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        BolSleep = False
    End Sub



    'formulier sluiten
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