Imports Labyrint.mdlFunctiesEnSubs
Public Class frmStartscherm

    Public bytNiveau As Byte

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'sluit programma af
        End
    End Sub



    Private Sub frmStartscherm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intCount As Integer = 0
        Dim strNaam, strScore, strPlaats As String
        Dim intScore, intPlaats As Integer
        strNaam = ""
        strScore = ""
        strPlaats = ""


        'gaat door alle controls in het formulier en geeft ze allemaal door aan de sub ControlCentr
        For Each cControl As Control In Me.Controls
            ControlCentr(cControl)
        Next

        'standaardwaarde voor manneke laden
        If My.Settings.Manneke1 Is Nothing Then

            My.Settings.Manneke1 = My.Resources.Man

        End If

        My.Settings.Highscores = New List(Of HighscoreObject)


        If My.Settings.High.Count = 0 Then
            My.Settings.High = New Collections.Specialized.StringCollection

        End If



        'Gegevens uit stringcollectie overnemen

        If My.Settings.High.Count <> 0 Then

            For Each score As String In My.Settings.High


                'plaats in variabele steken
                Do Until score(intCount) = "."
                    strPlaats &= score(intCount)
                    intCount += 1
                Loop
                intCount += 2
                'naam in variabele steken
                Do Until score(intCount) = "."
                    strNaam &= score(intCount)
                    intCount += 1
                Loop

                'door punten lopen
                Do While score(intCount) = "."
                    intCount += 1
                Loop
                Try
                    'score in variabele steken.
                    strScore &= score.Substring(intCount)

                    intScore = Integer.Parse(strScore)
                    intPlaats = Integer.Parse(strPlaats)


                    'highscoreobject aanmaken
                    Dim objhigh As New HighscoreObject(intScore, strNaam)
                    objhigh.Plaats = intPlaats
                    My.Settings.Highscores.Add(objhigh)
                Catch

                End Try
                intCount = 0
                strNaam = ""
                strPlaats = ""
                strScore = ""
            Next
        End If


        ''spelerafbeelding klaarzetten als deze leeg staat
        'My.Settings.Manneke = My.Resources.Man.ToString

    End Sub

    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_mouseenter(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnExit.MouseEnter, btnHighScores.MouseEnter, btnSettings.MouseEnter, btnStart.MouseEnter, btnHelp.MouseEnter
        'Dit zorgt ervoor dat de rand van de knop waar de muis binnenkomt, groen kleurt 
        sender.FlatAppearance.BorderColor = Color.Lime
    End Sub
    'er worden enkel knoppen naar deze sub doorgespeeld dus mag ik gerust in plaats van sender als object te declareren
    'hem als een button declareren, dan moet ik hem niet meer converteren naar een button.
    Private Sub Knoppen_Mouseleave(ByVal sender As Button, ByVal e As System.EventArgs) Handles btnExit.MouseLeave, btnHighScores.MouseLeave, btnSettings.MouseLeave, btnStart.MouseLeave, btnHelp.MouseLeave
        'Dit zorgt ervoor dat de rand van de knop waar de muis buitengaat, zwart kleurt 
        sender.FlatAppearance.BorderColor = Color.Black
    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'We vragen hier op welk niveau de gebruiker wil spelen, makkelijk of moeilijk.
        'Daarna openen we het spelformulier met de gekozen instellingen.


        bytNiveau = frmNiveau.showNiveau("Wenst u Labyrint op niveau makkelijk, gemiddeld of moeilijk te spelen?")
        frmNiveau.Dispose()








        'spelscherm tonen

        If bytNiveau = 1 Or bytNiveau = 0 Or bytNiveau = 2 Then
            Dim objSpel As New frmSpelscherm
            objSpel.Show()
            Me.Hide()
        End If





    End Sub

    Private Sub btnHighScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighScores.Click
        'frmHighscores openen
        Dim objHighscores As New frmHighscores

        objHighscores.Show()
        Me.Hide()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        'frminstelingen openen
        Dim objHelp As New frmHelp

        objHelp.Show()
        Me.Hide()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        'frminstelingen openen
        Dim objinstel As New frmInstellingen

        objinstel.Show()
        Me.Hide()
    End Sub

End Class