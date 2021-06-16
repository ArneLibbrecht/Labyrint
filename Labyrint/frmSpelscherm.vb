Imports Labyrint.mdlFunctiesEnSubs
Imports System.Threading
Imports Labyrint.My
Imports System.Runtime.InteropServices


Public Class frmSpelscherm

    Private objPunt() As Punt
    Private WithEvents objSpeler As New Speler
    Private bolKlok, bolTijdOp, bolStopladen, BolHertekenenSpelenMag, bolWachtOpLaad, bolOorzaak As Boolean
    Private bytReturns, bytScoreTeller As Byte
    Private intLevel, intScore As Integer

    Private WithEvents tmrKlok As New KlokTime
    Private Delegate Sub DelegateKlok()


    'Blokeren input
    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
    Public Shared Function BlockInput(<[In](), MarshalAs(UnmanagedType.Bool)> ByVal fBlockIt As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function



    Private Sub frmSpelscherm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim bytNiveau As Byte
        Dim intAantalB, intAantalH As Integer
        Dim objSize As New Size

        Me.DoubleBuffered = True




        'panel grootte aanpassen aan de moeilijkheid.
        ''niveau doorspelen, 0=makkelijk , 1=moeilijk, anders is cancel en het formulier dient dan te worden gesloten.
        bytNiveau = Labyrint.frmStartscherm.bytNiveau



        Select Case bytNiveau
            Case 0
                objSize.Width = 900
                objSize.Height = 600
                bolKlok = False
                bytReturns = 20
                bytScoreTeller = 25
            Case 1
                objSize.Width = 1100
                objSize.Height = 600
                bolKlok = False
                bytReturns = 15
                bytScoreTeller = 50
            Case 2
                objSize.Width = 1100
                objSize.Height = 600
                bytReturns = 5
                bolKlok = True
                bytScoreTeller = 100
        End Select

        'Level en score instellen
        intLevel = 1
        intScore = 0

        'Grootte van de spelruimte instellen
        grpSpelruimte.Size = objSize

        'gaat door alle controls in het formulier en geeft ze allemaal door aan de sub ControlCentr
        For Each cControl As Control In Me.Controls
            ControlCentr(cControl)
        Next

        'Teksten plaatsen
        lblReturns.Text = bytReturns.ToString
        lblScore.Text = 0
        lblLevel.Text = 1


        'De controls in pnlGegevens relatief weergeven
        For Each Control As Control In PnlGegevens.Controls
            ControlCentr(Control)


            For Each Control1 As Control In Control.Controls
                For Each control2 As Control In Control1.Controls
                    ControlCentr(control2, , Control1.Width, Control1.Height, Control1.Width, Control1.Height)
                Next
            Next

        Next

        ControlCentr(btnPauze, True, , , btnPauze.Width, btnPauze.Height)

        PnlGegevens.Show()

        'aantal punten in de breedte en hoogte berekenen
        intAantalB = grpSpelruimte.Width / 20
        intAantalH = grpSpelruimte.Height / 20

        'grootte array bepalen
        ReDim objPunt((intAantalB * intAantalH) - 1)

        'nieuwe instantie van objecten in array maken 
        For intTeller = 0 To objPunt.GetUpperBound(0)
            objPunt(intTeller) = New Punt
        Next


        'x en y waarden instellen voor de objecten in de array
        For intTeller = 0 To intAantalH - 1
            For intTeller2 = 0 To intAantalB - 1
                objPunt((intTeller * (intAantalB - 1)) + intTeller + intTeller2).X = intTeller2 * objPunt(0).Breedte
                objPunt((intTeller * (intAantalB - 1)) + intTeller + intTeller2).Y = intTeller * objPunt(0).Hoogte
                objPunt((intTeller * (intAantalB - 1)) + intTeller + intTeller2).ControladdGrap(grpSpelruimte, (intTeller * (intAantalB - 1)) + intTeller + intTeller2)
            Next
        Next




        ''voorlopige test
        'intScore = InputBox("Score:", "score")




        BolHertekenenSpelenMag = False





    End Sub





    'Dit is de laatste stap in het proces van het laden van een formulier dus plaats ik hier 
    'm'n commando's om te genereren en schakel ik hier de grpspelruimte in, 
    'zo bekom ik eerder geen volledig raster door de door het hertekenen opgeroepen door me.paint.
    Private Sub frmSpelscherm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Spelruimte aanzetten
        grpSpelruimte.Enabled = True

        PnlGegevens.Visible = True

        'genereren we het doolhof
        genereren()



    End Sub

    'Bij het hertekenen van het venster moeten ook het doolhof + al zijn componenten hertekent worden.
    Private Sub frmSpelscherm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If BolHertekenenSpelenMag Then
            For Each Punt As Punt In objPunt
                Punt.Herteken()
            Next
        End If
    End Sub




    '''overschrijf een stuk van de reeds bestaande functie ProcessCmdKey
    ''' Er wordt al gebruik gemaakt van de toetsen knop beneden boven ... 
    ''' om bv controls op het formulier te selecteren,
    ''' hier zeggen we dat hij bij het gebruiken van de pijltjestoetsen 
    ''' objspeler.beweeg moet uitvoeren met de corresponderende waarde voor de richting
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean


        Select Case keyData
            Case Keys.Left
                objSpeler.Beweeg(1, objPunt)
            Case Keys.Right
                objSpeler.Beweeg(2, objPunt)
            Case Keys.Up
                objSpeler.Beweeg(3, objPunt)
            Case Keys.Down
                objSpeler.Beweeg(4, objPunt)
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


    'Het spel pauzeren
    Private Sub btnPauze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPauze.Click
        Dim objPauze As New frmPauze

        If bolKlok = True Then
            tmrKlok.bolPauze = True
        End If

        objPauze.Show()

        If bolKlok = True Then
            tmrKlok.bolPauze = False
        End If

    End Sub



    'score vergelijken met high-scores
    'pad uittekenen als correctie
    Private Sub EindSpel()
        Dim objSolver As New Solver(objPunt)
        Dim Dialoog As New frmDialoogVerloren
        Dim doolhofEind As New Media.SoundPlayer
        'als instelling voor effecten aanstaat mag geluid worden afgespeeld
        If My.Settings.BolSFX Then
            doolhofEind.Stream = My.Resources.Verloren
            doolhofEind.Play()
        End If

        'Doorgeven naar objspeler dat hij verloren is
        objSpeler.bolVerloren = True
        tmrKlok.enabled = False

        'doolhof oplossen
        objSolver.Solve(objPunt(0))
        'muis terug tonen
        Windows.Forms.Cursor.Show()

        'Spel is uit
        If bolOorzaak = True Then
            'Venster verlies tonen
            Dialoog.Toon("Het aantal returns zijn op." & vbCrLf & " Score: " & intScore.ToString)
        Else
            'Venster verlies tonen
            Dialoog.Toon("De tijd is op." & vbCrLf & " Score: " & intScore.ToString)
        End If
        Highscores()


        'Sluit het spelformulier
        Me.Close()

    End Sub






    ''' <summary>
    ''' Kijkt of er een nieuwe highscore is.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Highscores()

        Dim lstHigh As New List(Of HighscoreObject)
        Dim frmNaam As New frmNaamHighscore
        Dim bytCounter As Byte
        Dim strNaam As String
        Dim Voorlhighscoreobj As New HighscoreObject(-1, "Element")
        Dim doolhofEind As New Media.SoundPlayer



        'strnaam voorlopig toewijzen
        strNaam = ""

        For Each high As Object In My.Settings.Highscores

            lstHigh.Add(CType(high, HighscoreObject))


        Next
        'aflopend sorteren
        lstHigh.Sort(New MijnComparer(SortOrder.Descending))
        'als de lijst leeg is voegen we een tijdelijk element in 

        lstHigh.Add(Voorlhighscoreobj)

        'als de laatste score kleiner is dan de huidige score hebben we een nieuwe highscore, als we nog geen 20 scores hebben heb je zo ie zo een nieuwe highscore.
        If lstHigh.Last.Score < intScore And intScore > 0 Then

            'als instelling voor effecten aanstaat mag geluid worden afgespeeld
            If My.Settings.BolSFX Then
                doolhofEind.Stream = My.Resources.Highscore
                doolhofEind.Play()
            End If

            'Voorlopig highscoreobject verwijderen
            lstHigh.Remove(Voorlhighscoreobj)
            'highscores heeft maximum 20 plaatsen
            Select Case lstHigh.Count
                Case 20 : lstHigh.Remove(lstHigh.Last)
            End Select

            'strNaam toewijzen
            Do Until frmNaam.ShowDialog() = DialogResult.OK And frmNaam.txtNaam.Text <> Nothing

            Loop
            strNaam = frmNaam.txtNaam.Text

            'intscore in list plaatsen 
            lstHigh.Add(New HighscoreObject(intScore, strNaam))
            'aflopend sorteren
            lstHigh.Sort(New MijnComparer(SortOrder.Descending))

            'highscores leegmaken
            My.Settings.Highscores.Clear()



            'bytcounter op 1 plaatsen
            bytCounter = 1

            For Each high As HighscoreObject In lstHigh
                ' de plaats in de ranklijst bepalen.
                high.Plaats = bytCounter
                bytCounter += 1

                'Aan highscores toevoegen
                My.Settings.Highscores.Add(high)

            Next


            'highscores tonen
            frmHighscores.Show()



        Else
            'startscherm tonen
            frmStartscherm.Show()
        End If



    End Sub





#Region "Klok"



    Private Sub tmrKlok_Tick() Handles tmrKlok.elapsed

        'tijd weergeven
        Tekst(tmrKlok.tspTijd.ToString("mm\:ss"), lblTijd, Me)

        ControlCentr(lblTijd, , pnlReturns.Width, pnlReturns.Height, pnlReturns.Width, pnlReturns.Height)

        'Als er geen tijd meer is wordt eindspel opgeroepen
        If tmrKlok.tspTijd.Seconds = 0 And tmrKlok.tspTijd.Minutes = 0 Then
            'klok uitschakelen
            tmrKlok.enabled = False

            'dispose oproepen voor lblTijd
            Verwijder(lblTijd)
            'Als tijd op is dan plaatsen we boltijdop op true en wordt de volgende beweging niet uitgevoerd
            'maar wordt eindspel ingezet
            bolTijdOp = True
            bolOorzaak = False
        End If

    End Sub

    Private Delegate Sub DelEindSpel()

    'wordt opgeroepen als de klok klaar is.
    Private Sub EindKlok(ByVal AsyncResult As System.IAsyncResult)

        If bolTijdOp = True Then
            'naar mainthread overschakelen om eindspel af te handelen
            If InvokeRequired Then
                Dim delEind As New DelEindSpel(AddressOf EindSpel)
                Invoke(delEind)
            End If


        End If
    End Sub

#End Region

#Region "VerhinderingThreadCrossing"
    'delegate
    Delegate Sub SluitDel(ByRef form As Form)

    'Als het control wordt geroepen door een thread anders dan z'n maker
    'wordt tekst opnieuw door zichzelf opgeroepen met de invoke methode

    Public Sub Sluit(ByRef form As Form)
        'invokerequired vergelijkt de oproepende thread
        'met de thread die het control heeft gemaakt
        'als ze verschillend zijn wordt true weergegeven

        If form.InvokeRequired Then
            Dim DelegateTekst As New SluitDel(AddressOf Sluit)
            form.Invoke(DelegateTekst, New Object() {form})
        Else
            form.Close()


        End If
    End Sub




    'delegate
    Delegate Sub DisposeDel(ByRef control As Control)

    'Als het control wordt geroepen door een thread anders dan z'n maker
    'wordt tekst opnieuw door zichzelf opgeroepen met de invoke methode

    Public Sub Verwijder(ByRef control As Control)
        'invokerequired vergelijkt de oproepende thread
        'met de thread die het control heeft gemaakt
        'als ze verschillend zijn wordt true weergegeven

        If control.InvokeRequired Then
            Dim DelegateTekst As New DisposeDel(AddressOf Verwijder)
            control.Invoke(DelegateTekst, New Object() {control})
        Else
            control.Dispose()


        End If
    End Sub


    'delegate
    Delegate Sub TekstDel(ByVal [Text] As String, ByRef [lblTekst] As Label, ByRef form As Form)

    'Als het control wordt geroepen door een thread anders dan z'n maker
    'wordt tekst opnieuw door zichzelf opgeroepen met de invoke methode

    Public Sub Tekst(ByVal [Text] As String, ByRef [lblTekst] As Label, ByRef form As Form)
        'invokerequired vergelijkt de oproepende thread
        'met de thread die het control heeft gemaakt
        'als ze verschillend zijn wordt true weergegeven

        If [lblTekst].InvokeRequired Then
            Dim DelegateTekst As New TekstDel(AddressOf Tekst)
            form.Invoke(DelegateTekst, New Object() {[Text], [lblTekst], form})
        Else
            [lblTekst].Text = [Text]


        End If
    End Sub

    'delegate
    Delegate Sub LabelDel(ByRef obj As Object, ByVal control As Control)

    'Als het control wordt geroepen door een thread anders dan z'n maker
    'wordt tekst opnieuw door zichzelf opgeroepen met de invoke methode

    Public Sub ControlToevoegen(ByRef obj As Object, ByVal control As Control)
        'invokerequired vergelijkt de oproepende thread
        'met de thread die het control heeft gemaakt
        'als ze verschillend zijn wordt true weergegeven

        If obj.InvokeRequired Then
            Dim DelegateTekst As New LabelDel(AddressOf ControlToevoegen)
            obj.Invoke(DelegateTekst, New Object() {obj, control})
        Else
            obj.Controls.Add(control)



        End If
    End Sub

    'delegate
    Delegate Sub ZichtDel(ByRef control As Control, ByVal bol As Boolean)

    'Als het control wordt geroepen door een thread anders dan z'n maker
    'wordt tekst opnieuw door zichzelf opgeroepen met de invoke methode

    Public Sub Zichtbaar(ByRef control As Control, ByVal bol As Boolean)
        'invokerequired vergelijkt de oproepende thread
        'met de thread die het control heeft gemaakt
        'als ze verschillend zijn wordt true weergegeven

        If control.InvokeRequired Then
            Dim DelegateTekst As New ZichtDel(AddressOf Zichtbaar)
            control.Invoke(DelegateTekst, New Object() {control, bol})
        Else
            control.Visible = bol



        End If
    End Sub


#End Region


    Private Sub Terugkeren() Handles objSpeler.StopTerug


        'verrekenening van aantal keren missen
        If bytReturns > 0 Then
            bytReturns -= 1
            lblReturns.Text = bytReturns.ToString
        Else
            bolOorzaak = True
            'eindspel oproepen
            EindSpel()
        End If

    End Sub



    Private Sub DoolhofUit() Handles objSpeler.Einde
        Dim DialGewonnen As New frmDialoogGewonnen
        Dim doolhofEind As New Media.SoundPlayer
        'als instelling voor effecten aanstaat mag geluid worden afgespeeld
        If My.Settings.BolSFX Then
            doolhofEind.Stream = My.Resources.DoolhofUit
            doolhofEind.Play()
        End If


        'timer uitschakelen
        tmrKlok.enabled = False
        'cursor tonen
        Windows.Forms.Cursor.Show()


        'scoreteller bijtellen bij score
        intScore += bytScoreTeller

        lblScore.Text = intScore.ToString

        'level bijwerken
        intLevel += 1
        lblLevel.Text = intLevel.ToString

        'persoonlijkere boodschap meegeven, level, mss muzieksj
        DialGewonnen.Toon("Labyrint " & (intLevel - 1).ToString & " geslaagd!" & vbCrLf & "Score: " & intScore.ToString)

        'cursor verbergen
        Windows.Forms.Cursor.Hide()

        PnlGegevens.Visible = False
        'voor als scores meer plaats innemen, labels terug centreren.
        For Each Control1 As Control In pnlBollen.Controls
            For Each control2 As Control In Control1.Controls
                ControlCentr(control2, , Control1.Width, Control1.Height, Control1.Width, Control1.Height)
            Next
        Next
        PnlGegevens.Visible = True
        'nieuw doolhof genereren
        genereren()

    End Sub
    Delegate Sub HertekenDel()
    Delegate Sub Updatedel()

    Private Sub genereren()


        Dim ThreadLaden As New Thread(New ThreadStart(AddressOf Laadgif))
        Dim ThreadGenereren As New Thread(New ThreadStart(AddressOf genererenUitvoer))


        ThreadLaden.Start()
        ThreadGenereren.Start()



    End Sub



    Delegate Sub LaadDel()


    Private Sub Laadgif()
        Dim delUpdate As New Updatedel(AddressOf picLaden.Update)

        'picladen tonen 
        Zichtbaar(picLaden, True)
        bolWachtOpLaad = True
        Do Until bolStopladen = True
            'Gif updaten totdat bolStopladen true is
            'We gebruiken zo ie zo invoke omdat we in een andere thread zitten dan deze
            'waarin picladen werd gemaakt.

            picLaden.Invoke(delUpdate)
        Loop

        Zichtbaar(picLaden, False)

        Thread.Sleep(500)
        bolWachtOpLaad = False


    End Sub





    Private Sub genererenUitvoer()

        Dim intKeuzeindex, intM(), intTel As Integer
        Dim pteLoc As New Point
        Dim objRand As New Random
        Dim bytRandLoc, bytRandPunt, bytIntMogelijk As Byte
        Dim intMogelijk As New Dictionary(Of Byte, Integer())
        Dim objLijn As New List(Of Punt)
        Dim objDel() As Punt


        'hertekenen mag momenteel niet
        BolHertekenenSpelenMag = False

        'toetsenbord blokkeren
        BlockInput(True)



        'als we op moeilijk spelen wordt al het nodige hier geladen en wordt lblTijd zichtbaar gemaakt.
        'klokDelegate
        Dim Klokdel As New DelegateKlok(AddressOf tmrKlok.Klok)
        Dim KlokCallBack As New AsyncCallback(AddressOf EindKlok)
        Dim ObjectState As Object
        If bolKlok Then
            'lblTijd klaarmaken.
            Zichtbaar(lblTijd, True)
        End If


        'LaadThread
        bolStopladen = False







        'random randomizen
        Randomize()

        'Voor alle punten de startsituatie ophalen.
        For Each punt As Punt In objPunt
            punt.Start()
        Next

        'Start, eindpunt instellen
        objPunt(0).Functie(1)
        objPunt(objPunt.GetUpperBound(0)).Functie(2)

        'Startpunt doorgeven aan spelerobject
        objSpeler.Locatie = objPunt(0).Punt



        'objLoc geeft de plaats in het doolhof weer waar we nu zitten om te genereren
        'logiserwijs starten we op het startpunt
        pteLoc = objPunt(0).Punt


        Do


            'index van Alle mogelijke stappen vanuit pteloc opslaan in de dictionary intmogelijkheden


            intTel = 0

            For Each Punt As Punt In objPunt
                If ((Punt.X = pteLoc.X + Punt.Breedte And Punt.Y = pteLoc.Y) Xor (Punt.Y = pteLoc.Y + Punt.Hoogte And pteLoc.X = Punt.X) Xor (Punt.X = pteLoc.X - Punt.Breedte And pteLoc.Y = Punt.Y) Xor (Punt.Y = pteLoc.Y - Punt.Hoogte And Punt.X = pteLoc.X)) And Punt.Bezoekt = False Then
                    ReDim intM(2)
                    intM(0) = Array.IndexOf(objPunt, Punt)

                    'om een onlogische/onbekende reden werkt onderstaand stuk code niet.

                    'Select Case Punt.X And Punt.Y
                    '    Case Punt.X = Punt.Breedte + pteLoc.X
                    '        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 1) = 2
                    '        'om randen al op te slaan welke rand van het punt op punt moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 2) = 1
                    '    Case Punt.X = pteLoc.X - Punt.Breedte
                    '        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 1) = 1
                    '        'om randen al op te slaan welke rand van het punt op punt moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 2) = 2
                    '    Case Punt.Y = pteLoc.Y + Punt.Hoogte
                    '        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 1) = 3
                    '        'om randen al op te slaan welke rand van het punt op punt moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 2) = 4
                    '    Case Punt.Y = pteLoc.Y + Punt.Hoogte
                    '        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 1) = 4
                    '        'om randen al op te slaan welke rand van het punt op punt moet weg
                    '        intMogelijk(intMogelijk.GetUpperBound(0), 2) = 3
                    'End Select

                    'dit is niet de efficientste manier maar de select case reageert onlogisch.

                    If Punt.X = Punt.Breedte + pteLoc.X Then
                        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                        intM(1) = 2
                        'om randen al op te slaan welke rand van het punt op punt moet weg
                        intM(2) = 1

                    End If
                    If Punt.X = pteLoc.X - Punt.Breedte Then
                        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                        intM(1) = 1
                        'om randen al op te slaan welke rand van het punt op punt moet weg
                        intM(2) = 2
                    End If

                    If Punt.Y = pteLoc.Y + Punt.Hoogte Then
                        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                        intM(1) = 4
                        'om randen al op te slaan welke rand van het punt op punt moet weg
                        intM(2) = 3
                    End If

                    If Punt.Y = pteLoc.Y - Punt.Hoogte Then
                        'om randen al op te slaan welke rand van het punt op pteloc moet weg
                        intM(1) = 3
                        'om randen al op te slaan welke rand van het punt op punt moet weg
                        intM(2) = 4
                    End If

                    intMogelijk.Add(intTel, intM)

                    intTel += 1
                End If
            Next
            ''Onderstaande if is enkel false wanneer we in de situatie zitten dat
            '' pteLoc vastzit tussen allemaal reeds bezochte punten
Verder:
            If intMogelijk.Count <> 0 Then



                'kiezen uit mogelijkheden
                bytIntMogelijk = Byte.Parse(objRand.Next(0, intMogelijk.Count))
                intKeuzeindex = intMogelijk(bytIntMogelijk)(0)
                bytRandLoc = Byte.Parse(intMogelijk(bytIntMogelijk)(1))
                bytRandPunt = Byte.Parse(intMogelijk(bytIntMogelijk)(2))
                intMogelijk.Clear()

                'rand van pteloc wegdoen + pteloc als bezoekt weergeven
                For Each Punt As Punt In objPunt
                    If Punt.Punt = pteLoc Then
                        'Punt.Randen(False, bytRandLoc)
                        'bolranden handmatig bijwerken om niet aan grafisch object te komen
                        Punt.bolRanden(bytRandLoc, 0) = False
                        Punt.BeschermdeRanden(bytRandLoc)
                        Punt.Bezoekt = True
                        'Punt aan  lijn toevoegen,
                        'als het punt ergens vastzit wordt er in deze lijst
                        'gezocht naar een andere route.
                        objLijn.Add(Punt)
                        Exit For
                    End If
                Next


                'rand van gekozen punt wegdoen
                'objPunt(intKeuzeindex).Randen(False, bytRandPunt)
                objPunt(intKeuzeindex).bolRanden(bytRandPunt, 0) = False
                objPunt(intKeuzeindex).BeschermdeRanden(bytRandPunt)
                'bezoekt al op true plaatsen voor het geval dat we nu vast zitten.
                objPunt(intKeuzeindex).Bezoekt = True

                'pteLoc verplaatsen
                pteLoc = objPunt(intKeuzeindex).Punt

            Else
                'als het punt ergens vastzit wordt er in deze lijst (objLijn)
                'gezocht naar een andere route.
                ReDim objDel(0)

                For Each puntNU As Punt In objLijn


                    intTel = 0

                    For Each Punt As Punt In objPunt
                        If ((Punt.X = puntNU.X + Punt.Breedte And Punt.Y = puntNU.Y) Xor (Punt.Y = puntNU.Y + Punt.Hoogte And puntNU.X = Punt.X) Xor (Punt.X = puntNU.X - Punt.Breedte And puntNU.Y = Punt.Y) Xor (Punt.Y = puntNU.Y - Punt.Hoogte And Punt.X = puntNU.X)) And Punt.Bezoekt = False Then
                            ReDim intM(2)
                            intM(0) = Array.IndexOf(objPunt, Punt)


                            If Punt.X = Punt.Breedte + puntNU.X Then
                                'om randen al op te slaan welke rand van het punt op puntNU moet weg
                                intM(1) = 2
                                'om randen al op te slaan welke rand van het punt op punt moet weg
                                intM(2) = 1

                            End If
                            If Punt.X = puntNU.X - Punt.Breedte Then
                                'om randen al op te slaan welke rand van het punt op puntNU moet weg
                                intM(1) = 1
                                'om randen al op te slaan welke rand van het punt op punt moet weg
                                intM(2) = 2
                            End If

                            If Punt.Y = puntNU.Y + Punt.Hoogte Then
                                'om randen al op te slaan welke rand van het punt op puntNU moet weg
                                intM(1) = 4
                                'om randen al op te slaan welke rand van het punt op punt moet weg
                                intM(2) = 3
                            End If

                            If Punt.Y = puntNU.Y - Punt.Hoogte Then
                                'om randen al op te slaan welke rand van het punt op puntNU moet weg
                                intM(1) = 3
                                'om randen al op te slaan welke rand van het punt op punt moet weg
                                intM(2) = 4
                            End If

                            intMogelijk.Add(intTel, intM)

                            intTel += 1
                        End If
                    Next


                    'als er iets in intmogelijk zit is het nutteloos om nog verder te zoeken.
                    If intMogelijk.Count <> 0 Then
                        'pteLoc verzetten naar het nieuwe startpunt
                        pteLoc = puntNU.Punt
                        Exit For
                    Else

                        objDel(objDel.GetUpperBound(0)) = puntNU
                        ReDim Preserve objDel(objDel.GetUpperBound(0) + 1)

                    End If

                Next

                For Each Punt As Punt In objDel
                    'punt uit lijst verwijderen, sneller genereren
                    objLijn.Remove(Punt)
                Next


                GoTo Verder




            End If
            'Loop Until pteLoc = objPunt(objPunt.GetUpperBound(0)).Punt
        Loop Until Array.TrueForAll(objPunt, Function(waarde As Punt)

                                                 Return waarde.Bezoekt
                                             End Function)


        'deze thread nog wat stilzetten zodat laadthread nog even getoond wordt
        Thread.Sleep(2000)

        'Laadthread stoppen
        bolStopladen = True

        'even wachten zodat Threadladen zeker gestopt is en grpSpelscherm aanstaat
        Do Until bolWachtOpLaad = False And picLaden.Visible = False
            Thread.Sleep(100)
        Loop


        'aller randen tonen
        For intTeller = 0 To objPunt.GetUpperBound(0)
            objPunt(intTeller).Randen()
        Next

        'spelersobject weergeven
        objPunt(0).Man(True)

        'speler op startwaarden plaatsen.
        objSpeler.start()



        'Als we op niveau moeilijk zitten werken we met een klok als extra moeilijkheid.
        If bolKlok Then
            ''timer inschakelen
            Dim AsyncResult As System.IAsyncResult = Klokdel.BeginInvoke(KlokCallBack, ObjectState)

        End If

        If picLaden.Visible = False Then
            'nu mag het venster hertekent worden moest dit nodig zijn
            BolHertekenenSpelenMag = True
            'nu mag het spel toetsenstroken doorspelen naar speler.beweeg


        End If
        'toetsenbord terug inschakelen
        BlockInput(False)

    End Sub










    Private Sub grpSpelruimte_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpSpelruimte.MouseEnter
        'De muis niet tonen
        Windows.Forms.Cursor.Hide()
    End Sub


    Private Sub grpSpelruimte_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpSpelruimte.MouseLeave
        'De muis  tonen
        Windows.Forms.Cursor.Show()
    End Sub
End Class