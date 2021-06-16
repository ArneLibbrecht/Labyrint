Imports Labyrint.mdlFunctiesEnSubs
Public Class frmInstellingen




    Private Sub frmInstellingen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Controls relatief maken
        For Each Control As Control In Me.Controls
            ControlCentr(Control)
        Next

        'voor de zekerheid een try toevoegen.
        Try
            'controleren of bestand bestaat
            If FileIO.FileSystem.FileExists(My.Settings.Manneke) Then
                picSpelerAfbeelding.Image = Image.FromFile(My.Settings.Manneke)
            Else
                'My.Settings.Manneke = "..\..\resources\man.png"
                'My.Settings.Save()
                'picSpelerAfbeelding.Image = Image.FromFile(My.Settings.Manneke)
                My.Settings.Manneke1 = My.Resources.Man
                My.Settings.Save()
                picSpelerAfbeelding.Image = My.Settings.Manneke1



            End If
        Catch
            'My.Settings.Manneke = "..\..\resources\man.png"
            'My.Settings.Save()
            'picSpelerAfbeelding.Image = My.Settings.Manneke1

            My.Settings.Manneke1 = My.Resources.Man
            My.Settings.Save()
            picSpelerAfbeelding.Image = My.Settings.Manneke1

        End Try


        chkJingles.Checked = My.Settings.BolSFX
        pnlKleur.BackColor = My.Settings.LabyrintKleur
 
    End Sub

    Private Sub picSpelerAfbeelding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSpelerAfbeelding.Click
        Dim Afbeelding As Image
        Dim dialoog As New frmDialoog
        Dim BolIngesteld As Boolean = False
        Dim dialresult As DialogResult

        fileDialogSpeler.Filter = "Afbeeldingen(*.bmp, *.jpg, *.png, *.gif, *.ico)|*.bmp;*.jpg;*.png; *.gif; *.ico"
        fileDialogSpeler.Multiselect = False

        Do Until BolIngesteld
            dialresult = fileDialogSpeler.ShowDialog()
            If dialresult = dialogresult.OK Then



                Afbeelding = Image.FromFile(fileDialogSpeler.FileName)

                If Afbeelding.Size.Width = 10 And Afbeelding.Size.Height = 10 Then
                    My.Settings.Manneke = fileDialogSpeler.FileName
                    My.Settings.Manneke1 = Afbeelding
                    BolIngesteld = True
                    My.Settings.Save()
                Else
                    dialoog.Toon("Kies een afbeelding met 10px breedte, 10px hoogte.")
                End If
            Else
                BolIngesteld = True
            End If
        Loop

        picSpelerAfbeelding.Image = My.Settings.Manneke1




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

    'terug naar startscherm
    Private Sub btnTerug_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        frmStartscherm.Show()
        Me.Close()

    End Sub

    Private Sub chkJingles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJingles.Click
        If My.Settings.BolSFX Then
            My.Settings.BolSFX = False
        Else
            My.Settings.BolSFX = True
        End If
        My.Settings.Save()

        chkJingles.Checked = My.Settings.BolSFX

    End Sub

    Private Sub btnHighScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighScore.Click
        'als highscores leeg iets zetten
        If My.Settings.Highscores Is Nothing Then
            My.Settings.Highscores = New List(Of HighscoreObject)
        End If
        My.Settings.High.Clear()
        My.Settings.Highscores.Clear()
        My.Settings.Save()


    End Sub


    Private Sub btnResetSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetSettings.Click
        Dim saveScore As List(Of HighscoreObject)

        saveScore = My.Settings.Highscores

        My.Settings.Reset()
        My.Settings.Manneke1 = My.Resources.Man
        My.Settings.Save()
        picSpelerAfbeelding.Image = My.Settings.Manneke1
        chkJingles.Checked = My.Settings.BolSFX
        pnlKleur.BackColor = My.Settings.LabyrintKleur

        If My.Settings.Highscores Is Nothing Then
            My.Settings.Highscores = New List(Of HighscoreObject)
        End If

        'lijst vullen
        My.Settings.Highscores = saveScore
        Highscorelijst()
        'settings opslaan
        My.Settings.Save()
    End Sub




    Private Sub pnlKleur_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlKleur.Click
        Dim objKleur As New ColorDialog







        If objKleur.ShowDialog() = DialogResult.OK Then


            My.Settings.LabyrintKleur = objKleur.Color


        Else
            My.Settings.LabyrintKleur = Color.Lime

        End If

        My.Settings.Save()


        pnlKleur.BackColor = My.Settings.LabyrintKleur

    End Sub
End Class