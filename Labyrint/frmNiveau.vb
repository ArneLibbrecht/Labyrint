Public Class frmNiveau

    Public Function showNiveau(ByVal strPrompt As String, Optional ByVal strTitle As String = "")
        'nieuwe instantie van frmniveau maken
        Dim objNiveau As New frmNiveau
        'de tekst in het label en in de title bar wordt aangepast.
        objNiveau.lblPrompt.Text = strPrompt
        objNiveau.Text = strTitle

        'objniveau weergeven + dialogresult afhandelen.
        Select Case objNiveau.ShowDialog
            Case DialogResult.Yes
                Return 0
            Case DialogResult.No
                Return 2
            Case DialogResult.OK
                Return 1
            Case Else
                Return 10
        End Select
    End Function



    Private Sub btnMakkelijk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakkelijk.Click
        'als makkelijk wordt gekozen wordt dialogresult.yes doorgespeeld
        DialogResult = DialogResult.Yes
    End Sub

    Private Sub btnMoeilijk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoeilijk.Click
        'als moeilijk wordt gekozen wordt dialogresult.no doorgespeeld
        DialogResult = DialogResult.No
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'bij annulering wordt dialogresult.cancel doorgespeeld.
        DialogResult = DialogResult.Cancel
    End Sub


    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_mouseenter(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnCancel.MouseEnter, btnGemiddeld.MouseEnter, btnMakkelijk.MouseEnter, btnMoeilijk.MouseEnter
        'Dit zorgt ervoor dat de rand van de knop waar de muis binnenkomt, groen kleurt 
        sender.FlatAppearance.BorderColor = Color.Lime
    End Sub
    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_Mouseleave(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnCancel.MouseLeave, btnGemiddeld.MouseLeave, btnMakkelijk.MouseLeave, btnMoeilijk.MouseLeave
        'Dit zorgt ervoor dat de rand van de knop waar de muis buitengaat, zwart kleurt 
        sender.FlatAppearance.BorderColor = Color.Black
    End Sub


    Private Sub frmNiveau_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'rand tekenen rond formulier
        'we gebruiken e.graphics in plaats van me.creategraphics omdat het korter is 
        e.Graphics.DrawRectangle(Pens.Lime, 0, 0, Me.Width - 1, Me.Height - 25)
    End Sub

    Private Sub btnGemiddeld_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGemiddeld.Click
        'als gemiddeld wordt gekozen wordt dialogresult.OK doorgespeeld
        DialogResult = DialogResult.OK
    End Sub
End Class