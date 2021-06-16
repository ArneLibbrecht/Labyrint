Imports Labyrint.mdlFunctiesEnSubs
Public Class frmHelp




    Private Sub btnTerug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerug.Click
        frmStartscherm.Show()
        Me.Close()
    End Sub

    Private Sub frmHelp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each Control As Control In Me.Controls
            ControlCentr(Control)
        Next
    End Sub
End Class