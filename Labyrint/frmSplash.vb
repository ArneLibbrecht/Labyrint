Imports System.Security.Principal
Imports System.Security.Permissions


Public Class frmSplash


    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dteStraks As Date
        Dim tspTijd As TimeSpan


        'timespan op 5 seconden zetten dtestraks op binnen 5 seconden
        tspTijd = TimeSpan.FromSeconds(1)
        dteStraks = TimeOfDay + tspTijd

        Do Until TimeOfDay = dteStraks
            'zolang we nog geen 5 seconden verder zijn mag je deze lus uitvoeren
        Loop


        'daarna mag je frmSplash sluiten en wordt het programma gestart.
        frmStartscherm.Show()
        Me.Close()



    End Sub
End Class