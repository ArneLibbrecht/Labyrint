Imports System.Threading
Module mdlFunctiesEnSubs




    Sub Highscorelijst()



        Dim lstHighscores As ListBox = frmHighscores.lstHighscores
        Dim strPlaatsEnNaam, strTussen, strScore As String
        Dim mijnFont As Font = lstHighscores.Font
        Dim szePlaats, szeTussen, szeScore As Size
        Dim lstHighnaam As New List(Of String)

        My.Settings.High.Clear()

        'lijst vullen
        For Each high As HighscoreObject In My.Settings.Highscores
            'Naam en score in variabelen opslaan
            strPlaatsEnNaam = high.Plaats.ToString & ". " & high.Naam.ToString
            strScore = high.Score.ToString
            strTussen = ""
            'tekst meten
            szePlaats = TextRenderer.MeasureText(strPlaatsEnNaam, mijnFont)
            szeScore = TextRenderer.MeasureText(strScore, mijnFont)
            szeTussen = TextRenderer.MeasureText(strTussen, mijnFont)

            'If szePlaats.Width + szeScore.Width >= lstHighscores.Width Then
            '    lstHighscores.Width += (szePlaats.Width + szeScore.Width) + 50
            '    ControlCentr(lstHighscores)
            'End If

            Do While szePlaats.Width + szeTussen.Width + szeScore.Width < lstHighscores.Width
                'strTussen vullen met . tot de breedte van de listbox gevuld is.
                strTussen &= "."
                szeTussen = TextRenderer.MeasureText(strTussen, mijnFont)
            Loop

            'coll vullen met scores


            My.Settings.High.Add(strPlaatsEnNaam & strTussen & strScore)
        Next

        My.Settings.Save()

    End Sub






    Sub ControlCentr(ByRef objControl As System.Windows.Forms.Control, Optional ByVal bolHRelatief As Boolean = False, Optional ByVal intContBreedte As Integer = 953, Optional ByVal intContHoogte As Integer = 550, Optional ByVal intWwidth As Integer = 0, Optional ByVal intWheight As Integer = 0)
        'we declareren de variabelen intCwidth, intCY, intWwidth, intWheight om respectievelijk 
        'de breedte en hoogte(Y-waarde) van de control en van het scherm in op te slaan.
        'intMidden om het midden in op te slaan
        Dim intCwidth, intCY, intMidden, intNieuwY As Integer
        'we declareren een nieuw punt om het punt in op te slaan waar we het control moeten plaatsen.
        Dim ptePunt As New Point

        'we wijzen de variabelen toe
        intCY = Integer.Parse(objControl.Location.Y)
        intCwidth = Integer.Parse(objControl.Width)
        If intWwidth = 0 Then
            intWwidth = Integer.Parse(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width)
        End If
        If intWheight = 0 Then
            intWheight = Integer.Parse(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height)
        End If

        If bolHRelatief Then
            'horizontaal relatief
            intMidden = (intCwidth / intContBreedte) * intWwidth

        Else
            'we berekenen de juiste positie van het control om deze
            'horizontaal gecentreerd weer te geven.
            intMidden = (intWwidth / 2) - (intCwidth / 2)
        End If
        'de originele hoogte van mijn formulier is 550px dus
        'plaats ik de y-waarde in procent van deze 550px en
        'vermenigvuldig ik deze met de huidige schermhoogte

        intNieuwY = (intCY / intContHoogte) * intWheight

        'punt toewijzen
        ptePunt.X = intMidden
        ptePunt.Y = intNieuwY

        'control naar de locatie brengen
        Locatie(objControl, ptePunt)

    End Sub



#Region "VerhinderingThreadCrossing"

    'delegate
    Delegate Sub LocatieDel(ByRef control As Control, ByVal punt As Point)

    'Als het control wordt geroepen door een thread anders dan z'n maker
    'wordt tekst opnieuw door zichzelf opgeroepen met de invoke methode

    Public Sub Locatie(ByRef control As Control, ByVal punt As Point)
        'invokerequired vergelijkt de oproepende thread
        'met de thread die het control heeft gemaakt
        'als ze verschillend zijn wordt true weergegeven

        If control.InvokeRequired Then
            Dim DelegateTekst As New LocatieDel(AddressOf Locatie)
            control.Invoke(DelegateTekst, New Object() {control, punt})
        Else
            control.Location = punt



        End If
    End Sub





#End Region



    Public Class KlokTime

        'klok

        Public Event elapsed()
        Public Event LabelMaken(ByVal lblTijd As Label)
        Public enabled As Boolean = True
        Public bolPauze As Boolean = False
        Public tspTijd As New TimeSpan

        Public Sub Klok()

            'bij moeilijk hebben we 5 minuten de tijd om het doolhof te maken
            'Tijd instellen
            tspTijd = TimeSpan.FromMinutes(5)







            'klok is ingeschakeld
            enabled = True

            Do Until enabled = False
                Thread.Sleep(1000)
                '1 seconde van de tijd aftrekken
                tspTijd -= TimeSpan.FromSeconds(1)
                'elapsed event oproepen om label bij te werken.
                RaiseEvent elapsed()

                'Rekening houden met pauze
                Do Until bolPauze = False
                    Thread.Sleep(500)
                Loop

            Loop




        End Sub




    End Class


#Region "Highscore"
    Public Class HighscoreObject
        Implements IComparable(Of HighscoreObject)

        Private intScore As Integer
        Private strNaam As String
        Private bytPlaats As Byte

        Public Sub New(ByVal score As Integer, ByVal Naam As String)
            MyBase.new()
            intScore = score
            strNaam = Naam

        End Sub


        Public Function VergelijkMet(ByVal other As HighscoreObject) As Integer Implements IComparable(Of Labyrint.mdlFunctiesEnSubs.HighscoreObject).CompareTo


            Return 0
        End Function


        Public Property Score As Integer

            Get
                Return intScore
            End Get
            Set(ByVal value As Integer)
                intScore = value
            End Set
        End Property

        Public Property Naam As String

            Get
                Return strNaam
            End Get
            Set(ByVal value As String)
                strNaam = value
            End Set
        End Property

        Public Property Plaats As Byte

            Get
                Return bytPlaats
            End Get
            Set(ByVal value As Byte)
                bytPlaats = value
            End Set
        End Property

    End Class



    Public Class MijnComparer
        Inherits Comparer(Of HighscoreObject)




        Private sortOrder As SortOrder


        'bij het maken van een nieuwe instantie van integercomparer wil ik dat de volgorde wordt opgegeven
        Public Sub New(ByVal Volgorde As SortOrder)

            MyBase.new()

            sortOrder = Volgorde


        End Sub


        ''opgeroepen door sort

        Public Overrides Function Compare(ByVal x As HighscoreObject, ByVal y As HighscoreObject) As Integer

            'x met y vergelijken
            If x.Score > y.Score Then
                'als de volgorde oplopend is geven we 1 door aan compare anders -1
                If Me.sortOrder = System.Windows.Forms.SortOrder.Ascending Then

                    Return 1

                Else

                    Return -1

                End If
            Else
                'als de volgorde oplopend is geven we -1 door aan compare anders 1
                If Me.sortOrder = System.Windows.Forms.SortOrder.Ascending Then

                    Return -1

                Else

                    Return 1

                End If


            End If

        End Function

    End Class

#End Region


    'object maken om punten toe te wijzen en te kijken of ze bezoekt werden, wordt gebruikt voor de generatie van het labyrint
    Public Class Punt
        Private intX, intY, intControlIndex As Integer
        Private bytFunctie As Byte = 3
        Private bolBezoekt, bolMan As Boolean
        Private Const cintBreedte As Integer = 20
        Private Const cintHoogte As Integer = 20
        Public GrafischObj As Graphics
        Private ptePunt As New Point
        'bytvoet standaard 0, witte voet 1, rode voet 2
        Public bytVoet As Byte = 0
        Public bolRanden(4, 1) As Boolean
        Public bolPublSchrank As Boolean
        Public bytRicht As Byte
        'enkel gebruikt voor correctie
        Public lstMogelijkeRichting As New List(Of Byte)


        Public Property X As Integer

            Get
                Return intX
            End Get
            Set(ByVal value As Integer)
                intX = Integer.Parse(value)
            End Set

        End Property

        Public Property Y As Integer

            Get
                Return intY
            End Get
            Set(ByVal value As Integer)
                intY = Integer.Parse(value)
            End Set

        End Property

        Public ReadOnly Property Breedte As Integer

            Get

                Return cintBreedte
            End Get


        End Property

        Public ReadOnly Property Hoogte As Integer

            Get

                Return cintHoogte
            End Get


        End Property

        Public Property Bezoekt As Boolean

            Get
                Return bolBezoekt
            End Get
            Set(ByVal value As Boolean)
                bolBezoekt = Boolean.Parse(value)
            End Set

        End Property

        ''' <summary>
        ''' 1:Startpunt 2:Eindpunt 3:Gewoon
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Func
            Get
                Return bytFunctie
            End Get
        End Property

        Public ReadOnly Property Punt
            Get
                Return ptePunt
            End Get
        End Property

        ''' <summary>
        ''' Hertekent alle componenten van het doolhof+het doolhof zelf.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Herteken()

            'De randen tekenen
            Randen()

            'Als er een manneke in het vak stond moet deze terugkomen
            If bolMan Then
                Man(True)
            End If

            'De voet kiezen, rood of wit de richting,... 
            Select Case bytVoet
                Case 1
                    Pad(bytRicht, False, bolPublSchrank)
                Case 2
                    Pad(bytRicht, True, bolPublSchrank)
            End Select

        End Sub

        ''' <summary>
        ''' Plaats verwijdert alle componenten in het vak.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Clear()

            GrafischObj.Clear(Color.Black)
            Me.bolMan = False
            Me.bytVoet = 0

            Randen()
        End Sub

        ''' <summary>
        ''' Zorgt voor het tonen van het manneke
        ''' </summary>
        ''' <param name="bolZicht"></param>
        ''' <remarks></remarks>
        Public Sub Man(ByVal bolZicht As Boolean)

            If bolZicht Then
                'voor de zekerheid een try toevoegen.
                Try
                    'controleren of bestand bestaat
                    If FileIO.FileSystem.FileExists(My.Settings.Manneke) Then
                        GrafischObj.DrawImage(My.Settings.Manneke1, 5, 5)
                    Else
                        GrafischObj.DrawImage(My.Resources.Man, 5, 5)
                    End If
                Catch
                    GrafischObj.DrawImage(My.Resources.Man, 5, 5)
                End Try
                'opslaan dat in dit veld een manneke staat
                bolMan = True
            Else
                GrafischObj.Clear(Color.Black)
                Randen()
                'opslaan dat in dit veld geen manneke staat
                bolMan = False
            End If

        End Sub

        ''' <summary>
        ''' Zorgt voor het tonen van het correctiebolleke
        ''' </summary>
        Public Sub CorrectieAfb()


            GrafischObj.DrawImage(My.Resources.afbCorrectie, 5, 5)

        End Sub

        ''' <summary>
        ''' Tekent een pad van voetstappen achter de speler, bij terugkereren zijn deze voetstappen rood.
        ''' </summary>
        ''' <param name="bytRichting">1:Links, 2:Rechts, 3:Boven, 4:Onder</param>
        ''' <param name="bolTerug">true is terugkeren</param>
        ''' <param name="bolSchrank"> Bij true staat de voet 4px van links anders van rechts</param>
        ''' <remarks></remarks>
        Public Sub Pad(ByVal bytRichting As Byte, ByVal bolTerug As Boolean, Optional ByVal bolSchrank As Boolean = True)
            'Variabelen voor afbeeldingen declareren
            Dim objVoet As Image
            Dim objDraai As System.Drawing.RotateFlipType
            Dim ptePunt As New Point


            If bolTerug = False Then
                'Afbeeldingen toewijzen
                objVoet = Labyrint.My.Resources.Voetstap
                'laten weten dat hier een witte voet staat
                bytVoet = 1


            Else
                'vorige voet verwijderen
                Randen()

                'afbeeldingen toewijzen
                objVoet = Labyrint.My.Resources.VoetstapTerug

                'laten weten dat hier een rode voet staat
                bytVoet = 2
            End If

            'draai instellen van voeten
            Select Case bytRichting
                Case 1
                    objDraai = RotateFlipType.RotateNoneFlipNone
                    ptePunt.X = 4
                Case 3
                    objDraai = RotateFlipType.Rotate90FlipNone
                    ptePunt.Y = 4
                Case 2
                    objDraai = RotateFlipType.Rotate180FlipNone
                    ptePunt.X = 4
                Case 4
                    objDraai = RotateFlipType.Rotate270FlipNone
                    ptePunt.Y = 4
            End Select


            'Richting in punt opslaan
            bytRicht = bytRichting
            'Schrank in punt opslaan
            bolPublSchrank = bolSchrank


            'kijken welke waarde van het punt nog moet worden ingesteld
            If bytRichting = 1 Or bytRichting = 2 Then
                'waarde van punt bepalen door middel van bolschrank
                If bolSchrank Then
                    ptePunt.Y = 4
                Else
                    ptePunt.Y = 12
                End If
            Else
                If bolSchrank Then
                    ptePunt.X = 4
                Else
                    ptePunt.X = 12
                End If

            End If

            'draai uitvoeren    
            objVoet.RotateFlip(objDraai)

            'voet tekenen
            GrafischObj.DrawImage(objVoet, ptePunt)

        End Sub

        Public Sub ControladdGrap(ByRef pnlControls As GroupBox, ByVal index As Integer)
            'punt object als panel in het formulier in een panel plaatsen.
            Dim objVak As New Control

            Dim szeSize As New Size
            ptePunt.X = X
            ptePunt.Y = Y

            szeSize.Width = cintBreedte
            szeSize.Height = cintHoogte

            objVak.Name = index.ToString
            objVak.Location = ptePunt

            objVak.Size = szeSize



            pnlControls.Controls.Add(objVak)

            Me.intControlIndex = pnlControls.Controls.IndexOf(objVak)




            GrafischObj = pnlControls.Controls(intControlIndex).CreateGraphics()


        End Sub

        ''' <summary>
        ''' Startwaarden opvragen
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Start()
            'alle 1 waarden in bolranden op false plaatsen, dit staat voor protected= false
            For intTeller = 1 To 4
                bolRanden(intTeller, 1) = False
                bolRanden(intTeller, 0) = True
            Next
            'bolman false plaatsen, randen uitzetten, bezocht uit en alle voeten op 0
            Me.bolMan = False
            Me.Randen(False)
            Me.Bezoekt = False
            Me.bytVoet = 0
        End Sub


        ''' <summary>
        ''' hiermee kan je de randen van het object bewerken
        ''' </summary>
        ''' <param name="bytRand">1,2,3,4,9 staan voor links, rechts, boven, onder, alle randen</param>
        ''' <param name="bolTeken">Kies of de rand getekend of verwijdert moet worden. (true getekend)</param>
        ''' <remarks></remarks>
        Public Sub Randen(Optional ByVal bolTeken As Boolean = True, Optional ByVal bytRand As Byte = 9)
            ' Hier wordt de pen gedeclareerd, ik gebruik de kleur die de gebruiker insteld. ( standaard lime)
            Dim objPen As New Pen(My.Settings.LabyrintKleur, 2)


            If bolTeken Then
                'Tekent de randen
                Select Case bytRand
                    Case 1
                        If bolRanden(1, 1) = False Or (bolRanden(1, 1) = True And bolRanden(1, 0) = True) Then
                            GrafischObj.DrawLine(objPen, 0, 0, 0, cintHoogte)
                            bolRanden(1, 0) = True
                        End If
                    Case 2
                        If bolRanden(2, 1) = False Or (bolRanden(2, 1) = True And bolRanden(2, 0) = True) Then
                            GrafischObj.DrawLine(objPen, cintBreedte, 0, cintBreedte, cintHoogte)
                            bolRanden(2, 0) = True
                        End If
                    Case 3
                        If bolRanden(3, 1) = False Or (bolRanden(3, 1) = True And bolRanden(3, 0) = True) Then
                            GrafischObj.DrawLine(objPen, 0, 0, cintBreedte, 0)
                            bolRanden(3, 0) = True
                        End If
                    Case 4
                        If bolRanden(4, 1) = False Or (bolRanden(4, 1) = True And bolRanden(4, 0) = True) Then
                            GrafischObj.DrawLine(objPen, 0, cintHoogte, cintBreedte, cintHoogte)
                            bolRanden(4, 0) = True
                        End If
                    Case 9

                        For intTeller = 1 To 4
                            If bolRanden(intTeller, 1) = False Or (bolRanden(intTeller, 1) = True And bolRanden(intTeller, 0) = True) Then
                                Randen(True, intTeller)
                                bolRanden(intTeller, 0) = True
                            End If
                        Next

                    Case Else

                End Select



            Else
                'verwijder alle randen en geef aan welke rand weg moet in de array randen
                GrafischObj.Clear(Color.Black)

                Select Case bytRand
                    Case 1
                        If bolRanden(1, 1) = False Then
                            bolRanden(1, 0) = False
                        End If
                    Case 2
                        If bolRanden(2, 1) = False Then
                            bolRanden(2, 0) = False
                        End If
                    Case 3
                        If bolRanden(3, 1) = False Then
                            bolRanden(3, 0) = False
                        End If
                    Case 4
                        If bolRanden(4, 1) = False Then
                            bolRanden(4, 0) = False
                        End If
                    Case 9
                        For intTeller = 1 To 4
                            If bolRanden(intTeller, 1) = False Then
                                bolRanden(intTeller, 0) = False
                            End If
                        Next
                    Case Else

                End Select

                'Alle randen die niet werden uitgeschakeld moeten terug getoond worden
                For intTeller = 1 To 4
                    If bolRanden(intTeller, 0) Then
                        Randen(True, intTeller)
                    End If
                Next


            End If



        End Sub


        ''' <summary>
        ''' Deze sub beschermt bepaalde randen
        ''' </summary>
        ''' <param name="bytRand">1: linkerrand, 2:rechterrand ,3: bovenrand, 4: onderrand</param>
        ''' <remarks></remarks>
        Public Sub BeschermdeRanden(ByVal bytRand As Byte)
            'rand beschermen.
            If bytRand >= 1 And bytRand <= 4 Then
                bolRanden(bytRand, 1) = True
            End If

        End Sub


        ''' <summary>
        ''' Geef de functie van het punt aan.
        ''' </summary>
        ''' <param name="Functie">1: Startpunt, 2:Eindpunt, 3:Gewoon</param>
        ''' <remarks></remarks>
        Public Sub Functie(Optional ByVal Functie As Byte = 3)
            'startpunt heeft geen bovenrand, eindpunt geen onderrand, ook beschermen.
            bytFunctie = Functie
            Select Case Functie
                Case 1
                    Me.Randen(False, 3)
                    Me.BeschermdeRanden(3)
                Case 2
                    Me.Randen(False, 4)
                    Me.BeschermdeRanden(4)
                Case Else
                    Me.Randen(False, 9)
            End Select
        End Sub


        Public Sub MogelijkeRichtingen()
            For intTeller = 1 To 4
                If bolRanden(intTeller, 0) = False And ((Func = 1 And intTeller = 3) Or (Func = 2 And intTeller = 4)) = False Then
                    'Richting aan lstMogelijkeRichtingen Toevoegen
                    lstMogelijkeRichting.Add(intTeller)
                End If
            Next

        End Sub






    End Class


    ''' <summary>
    ''' Object waar de speler en z'n atributen inzitten
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Speler
        Private pteLocSpeler, ptePuntTerug As New Point
        Private bolSchrank As Boolean
        Private bolNuTerug As Boolean
        Private objLijn, objLijnFout As New Collection
        Private intTeller As Integer
        Public Event StopTerug()
        Public Event Einde()
        Public bolVerloren As Boolean


        ''' <summary>
        ''' Locatie speler
        ''' </summary>
        ''' <value>Geef een Point object </value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Locatie As Point

            Get
                Return pteLocSpeler
            End Get
            Set(ByVal value As Point)
                pteLocSpeler = value
            End Set
        End Property

        ''' <summary>
        ''' Startwaarden van spelerobject ophalen.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub start()
            objLijn.Clear()
            objLijnFout.Clear()
            bolSchrank = True
            bolVerloren = False
            bolNuTerug = False
            ptePuntTerug = New Point(0, 0)
        End Sub


        ''' <summary>
        ''' Regelt het bewegen van de speler.
        ''' </summary>
        ''' <param name="bytRichting">1: Links, 2: Rechts, 3:Boven, 4:Onder </param>
        ''' <remarks></remarks>
        Public Sub Beweeg(ByVal bytRichting As Byte, ByRef objLabyrint() As Punt)
            'soudplayers declareren, moet niet globaal want wordt enkel in deze sub gebruikt.
            Dim objSfout, objSTerugFout, objTerug As New Media.SoundPlayer
            Dim pteGewenstpunt As New Point
            Dim bolTerug As Boolean





            'Geluid voor botsen laden
            objSfout.Stream = Labyrint.My.Resources.Toon_botsen
            'Geluid voor terugkeren op rood laden
            ' objSTerugFout.Stream = Labyrint.My.Resources.Toon_Terug_Botsen
            'Geluid voor gewoon terugkeren laden
            objTerug.Stream = My.Resources.TerugKeren


            'punt links rechts boven of onder van huidige locatie 
            Select Case bytRichting

                Case 1
                    pteGewenstpunt.X = pteLocSpeler.X - 20
                    pteGewenstpunt.Y = pteLocSpeler.Y
                Case 3
                    pteGewenstpunt.X = pteLocSpeler.X
                    pteGewenstpunt.Y = pteLocSpeler.Y - 20
                Case 2
                    pteGewenstpunt.X = pteLocSpeler.X + 20
                    pteGewenstpunt.Y = pteLocSpeler.Y
                Case 4
                    pteGewenstpunt.X = pteLocSpeler.X
                    pteGewenstpunt.Y = pteLocSpeler.Y + 20
                Case Else
                    Exit Sub
            End Select





            For Each Punt As Punt In objLabyrint



                'In labyrint naar loc speler zoeken, als de richting ons niet op een muur of tegen de in-of uitgang smijt 
                'mag de code worden uitgevoerd
                If Punt.Punt = pteLocSpeler And Punt.bolRanden(bytRichting, 0) = False And ((Punt.Func = 1 And bytRichting = 3) Or (Punt.Func = 2 And bytRichting = 4)) = False Then
                    'manneke uitzetten in dit veld
                    Punt.Man(False)



                    'punt aan lijn toevoegen als het nog niet in de lijn zit.
                    If objLijn.Contains(Punt.X.ToString & " " & Punt.Y.ToString) = False Then
                        objLijn.Add(Punt, Punt.X.ToString & " " & Punt.Y.ToString)
                    End If



                    'kijken of het gewenste punt reeds bezocht werd
                    If objLijn.Contains(pteGewenstpunt.X.ToString & " " & pteGewenstpunt.Y.ToString) Then
                        'We gaan terug
                        bolTerug = True
                        'Tot we een andere weg inslaan gaan we terug
                        bolNuTerug = True

                        'We zoeken het punt vanaf waar we terugkeren
                        If objLijnFout.Count = 0 Then
                            ptePuntTerug = Punt.Punt
                        End If

                        'bezocht punt aan lijnfout toevoegen.
                        objLijnFout.Add(Punt, Punt.X.ToString & " " & Punt.Y.ToString)


                        'als het gewenste punt al in de foutenlijst zit verwijderen we de foutenlijst 
                        If objLijnFout.Contains(pteGewenstpunt.X.ToString & " " & pteGewenstpunt.Y.ToString) Then

                            'Alle sporen in objlijn wegnemen
                            For Each Punt2 As Punt In objLijnFout
                                Punt2.Clear()
                                objLijn.Remove(Punt2.X.ToString & " " & Punt2.Y.ToString)
                            Next
                            'punt leegmaken, zit niet in objlijnfout
                            Punt.Clear()

                            'lijnfout leegmaken
                            objLijnFout.Clear()

                            'We stoppen met terug gaan
                            bolNuTerug = False

                            'manneke aanzetten in dit veld
                            Punt.Man(True)
                            pteLocSpeler = Punt.Punt

                            If My.Settings.BolSFX Then
                                'muziekje voor terugkeren afspelen
                                objTerug.Play()
                            End If

                            'Event Stopterug lanceren, de fout tellen
                            RaiseEvent StopTerug()
                            'de sub verlaten
                            Exit Sub
                        End If

                    Else

                        ' als we nu aan het terugkeren zijn en we komen aan een punt dat we nog niet
                        'bezocht hebben dan voeren we onderstaande commando's uit
                        If bolNuTerug Then
                            If My.Settings.BolSFX Then
                                objTerug.Play()
                            End If

                            'Alle sporen van objlijnfout uit objlijn wegnemen
                            For Each Punt2 As Punt In objLijnFout
                                Punt2.Clear()
                                objLijn.Remove(Punt2.X.ToString & " " & Punt2.Y.ToString)

                            Next
                            'lijnfout leegmaken
                            objLijnFout.Clear()
                            'we gaan niet langer terug
                            bolNuTerug = False


                            'Event Stopterug lanceren, de fout tellen
                            RaiseEvent StopTerug()

                        Else
                        End If
                        'we gaan vooruit
                        bolTerug = False
                    End If

                    If bolVerloren = False Then
                        'pad inschakelen in dit veld
                        Punt.Pad(bytRichting, bolTerug, bolSchrank)

                        'bolschrank naar false zetten als true en vice versa
                        If bolSchrank Then
                            bolSchrank = False
                        Else
                            bolSchrank = True
                        End If

                        ' gewenste punt zoeken
                        For Each Punt1 As Punt In objLabyrint

                            If Punt1.Punt = pteGewenstpunt Then
                                'manneke aanzetten in dit veld
                                Punt1.Man(True)
                                'de locatie van de speler wijzigen
                                pteLocSpeler = Punt1.Punt
                                'Als we op het laatste punt in de array objlabyrint zitten
                                'hebben we het level uitgespeeld en wordt het event einde opgeroepen.
                                If pteLocSpeler = objLabyrint(objLabyrint.GetUpperBound(0)).Punt Then
                                    RaiseEvent Einde()
                                End If
                                ' als het gewenste punt is gevonden is de sub klaar.
                                Exit Sub
                            End If
                        Next
                    Else
                        Exit Sub
                    End If

                End If
            Next

            If My.Settings.BolSFX Then
                'geluid voor botsen afspelen
                objSfout.Play()
            End If

        End Sub






    End Class

    ''' <summary>
    ''' Klasse om doolhof op te lossen.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Solver
        Private objLabyrint() As Punt
        Private lstPad As New List(Of Punt)
        Private bolStop As Boolean = False

        'Sub bij het maken van een nieuwe instantie van solver
        Public Sub New(ByRef pobjLabyrint() As Punt)
            MyBase.New()

            objLabyrint = pobjLabyrint

            'Huidige spelerobjecten uit doolhof verwijderen
            'Mogelijke richtingen vullen
            For Each Punt As Punt In objLabyrint
                Punt.Clear()
                Punt.MogelijkeRichtingen()
            Next


        End Sub

        Public Sub Solve(ByVal PuntStart As Punt)
            Dim pteGewenstpunt As New Point
            Dim PuntGewenstpunt As Punt
            Dim lstVerwijder As New List(Of Punt)
            Dim ColLijsten As New Collection

            'Lus uitvoeren tot we aan het einde zijn.
            Do Until PuntStart.Func = 2
voorForEach:
                ' we gebruiken tolist omdat we veranderingen aan de lijst in kwestie aanbrengen terwijl de lus draait.
                For Each bytRichting As Byte In PuntStart.lstMogelijkeRichting.ToList

                    'punt links rechts boven of onder van huidige locatie 
                    Select Case bytRichting
                        Case 1
                            pteGewenstpunt.X = PuntStart.X - 20
                            pteGewenstpunt.Y = PuntStart.Y
                        Case 3
                            pteGewenstpunt.X = PuntStart.X
                            pteGewenstpunt.Y = PuntStart.Y - 20
                        Case 2
                            pteGewenstpunt.X = PuntStart.X + 20
                            pteGewenstpunt.Y = PuntStart.Y
                        Case 4
                            pteGewenstpunt.X = PuntStart.X
                            pteGewenstpunt.Y = PuntStart.Y + 20
                    End Select
                    'gewenstepunt zoeken
                    For Each Punt As Punt In objLabyrint
                        If Punt.Punt = pteGewenstpunt Then
                            PuntGewenstpunt = Punt
                            Exit For
                        End If
                    Next
                    'Gekozen richting uit lijst met mogelijke richtingen halen
                    PuntStart.lstMogelijkeRichting.Remove(bytRichting)
                    'bij gekozen punt richting om terug te keren ook verwijderen.
                    Select Case bytRichting
                        Case 1 : PuntGewenstpunt.lstMogelijkeRichting.Remove(2)
                        Case 2 : PuntGewenstpunt.lstMogelijkeRichting.Remove(1)
                        Case 3 : PuntGewenstpunt.lstMogelijkeRichting.Remove(4)
                        Case 4 : PuntGewenstpunt.lstMogelijkeRichting.Remove(3)
                    End Select
                    'Als lstpad het punt niet bevat mag dit worden toegevoegd
                    If lstPad.Contains(PuntStart) = False Then
                        'punt Aan pad toevoegen
                        lstPad.Add(PuntStart)
                    End If
                    'als het gewenstepunt het eindpunt is moet je de do lus verlaten.
                    If PuntGewenstpunt.Func = 2 Then
                        Exit Do
                    End If


                    'Als er in het huidige puntStart nog richtingen over zijn
                    'dan zetten we puntstart op puntgewenstpunt en gaan we naar de lijn voordat de for each lus begint
                    'omdat we anders verderwerken op de richtingen van het voormalig startpunt
                    'anders wijzigen we enkel puntstart naar puntgewenstpunt
                    'omdat we hier de mogelijkheid hebben dat we vast zitten.
                    If PuntStart.lstMogelijkeRichting.Count = 0 Then
                        PuntStart = PuntGewenstpunt
                    Else
                        PuntStart = PuntGewenstpunt
                        GoTo VoorForEach
                    End If



                Next
                'als er geen richtingen meer zijn in het nieuwe punt start zit je vast
                If PuntStart.lstMogelijkeRichting.Count = 0 Then
                    'loop omgekeerd door de lijst en zoek het eerste punt waar we meerdere richtingen hebben
                    For intTeller = lstPad.Count - 1 To 0 Step -1
                        If lstPad(intTeller).lstMogelijkeRichting.Count = 0 Then
                            If intTeller <> 0 Then
                                'als er geen richtingen zijn in het punt wordt het punt toegevoegd aan lstverwijder
                                lstVerwijder.Add(lstPad(intTeller))
                            Else
                                'code om code te testen
                                'MsgBox("foute boel!")

                                'For intTeller1 = 1 To ColLijsten.Count


                                '    For Each Punt As Punt In objLabyrint
                                '        Punt.Clear()
                                '    Next

                                '    For Each Punt As Punt In ColLijsten(intTeller1)


                                '        Punt.CorrectieAfb()
                                '    Next
                                '    'MsgBox("Voor verwijder")


                                'Next

                            End If

                        Else
                            'Als er een richting is wordt dit punt de nieuwe puntStart, we stoppen de for-lus
                            PuntStart = lstPad(intTeller)
                            Exit For
                        End If
                    Next

                    'Collectie lijsten om stuk code te testen
                    ' ColLijsten.Add(lstPad.ToList)

                    'we verwijderen alle punten van lstverwijder uit lstpad
                    For Each Punt As Punt In lstVerwijder
                        lstPad.Remove(Punt)
                    Next
                    'we legen lstverwijder
                    lstVerwijder.Clear()

                End If
            Loop
            'pad tonen
            For Each pnt As Punt In lstPad
                pnt.CorrectieAfb()
            Next
            'pad ook aanzetten op laatste punt dat niet in het pad zit
            objLabyrint.Last.CorrectieAfb()
        End Sub
    End Class


End Module
