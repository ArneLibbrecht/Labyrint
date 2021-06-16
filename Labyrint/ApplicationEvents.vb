Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 

    Partial Friend Class MyApplication

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown



            'lijst opmaken
            Highscorelijst()
  
            My.Settings.Save()


            Process.GetCurrentProcess.Kill()



        End Sub






        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            'variabelen declareren 
            Dim objSplash As New frmSplash


            Dim objIdentiteit As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent
            Dim objPrincipal As New System.Security.Principal.WindowsPrincipal(objIdentiteit)
            Dim objProces As New ProcessStartInfo(System.Reflection.Assembly.GetExecutingAssembly.CodeBase)



         


            If objPrincipal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator) = False Then

                objProces.UseShellExecute = True
                objProces.Verb = "runas"

                Try

                    Process.Start(objProces)

                Catch ex As Exception
                    MessageBox.Show("Dit programma heeft administratorrechten nodig.")
                End Try

                End

            End If

            ''splashscherm tonen
            'frmSplash.Show()













        End Sub




    End Class


End Namespace

