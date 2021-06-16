
Public Class frmFolderDialoogVenster

    Private BolSleep As Boolean
    Private pteMuis As New Point

    Public Sub Toon(ByVal strPrompt As String)

        Me.ShowDialog()
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








    Private Sub frmFolderDialoogVenster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo) = My.Computer.FileSystem.Drives
        Dim rootDir As String = String.Empty
        For i As Integer = 0 To drives.Count - 1
            If Not drives(i).IsReady Then
                Continue For
            End If

            rootDir = drives(i).Name
            trvFolderSelect.Nodes.Add(rootDir)
            PopulateTreeView(rootDir, trvFolderSelect.Nodes(i))
        Next
    End Sub

    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        Dim folder As String = String.Empty
        Try
            Dim folders() As String = IO.Directory.GetDirectories(dir)
            If folders.Length <> 0 Then
                Dim childNode As TreeNode = Nothing
                For Each folder In folders
                    childNode = New TreeNode(folder)
                    parentNode.Nodes.Add(childNode)
                    PopulateTreeView(folder, childNode)
                Next
            End If
        Catch ex As UnauthorizedAccessException
            parentNode.Nodes.Add(folder & ": Access Denied")
        End Try


    End Sub
End Class