Public Class frmPauze

    Private Sub frmPauze_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'controls mooi op venster zetten

        For Each Control As Control In Me.Controls
            ControlCentr(Control)
        Next

    End Sub



    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim dialog As New frmDialoogJaNee

        dialog.Toon("Weet u zeker dat u het spel wenst af te sluiten," & vbCrLf & "uw vooruitgang wordt niet opgeslagen.")

        If dialog.DialogResult = DialogResult.Yes Then
            End
        End If

    End Sub


    Private Sub btnTerugStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTerugStart.Click
        Dim dialog As New frmDialoogJaNee

        dialog.Toon("Weet u zeker dat u naar het startscherm wenst te gaan," & vbCrLf & "uw vooruitgang wordt niet opgeslagen.")

        If dialog.DialogResult = DialogResult.Yes Then
            frmStartscherm.Show()
            frmSpelscherm.Close()
            Me.Close()
        End If
    End Sub

    Private Sub btnTerug_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        Me.Close()
    End Sub
End Class