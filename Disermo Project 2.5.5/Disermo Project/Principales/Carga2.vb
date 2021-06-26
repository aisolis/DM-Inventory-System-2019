Imports System.Data.SqlClient
Imports System.Threading
Public Class Carga2
    Dim xd As String
    'Dim avisosalida As String
    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Conexiones()



    End Sub
    Function conect() As Boolean
        Try
            lblCargaDescrpitivo.Text = ""

            Using tryconect As New SqlConnection(My.Settings.conexionglobal)
                tryconect.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
    Sub Conexiones()
        lblCargaDescrpitivo.Text = ""
        If xd = "1" Then
            lblCarga1.Text = "Preparando 1/2"
        Else
            lblCarga1.Text = "Preparando 2/2"
            lblCargaDescrpitivo.Text = "Comprobando conexion a internet"
            If My.Computer.Network.IsAvailable Then
                If My.Computer.Network.Ping("www.google.com", 1000) Then
                    lblCargaDescrpitivo.Text = "Conexion a internet establecida exitosamente"


                Else
                    lblCargaDescrpitivo.Text = "Conexion establecida"


                End If

            Else
                lblCargaDescrpitivo.Text = "Conexion no establecida exitosamente"


            End If
        End If

        My.Settings.conexionglobal = "Data Source=DESKTOP-9R7M7SC\SWORDS;Initial Catalog=Disermo;Persist Security Info=True;User ID=DisermoLogin;Password=12345"
        My.Settings.Save()
        My.Settings.Reload()
        lblCarga1.Text = "Preparando 0/2"
        lblCargaDescrpitivo.Text = "Inicializando conexiones"
        Thread.Sleep(3000)

        conect()
        If conect() = True Then
            lblCarga1.Text = "Preparando 1/2"
            lblCargaDescrpitivo.Text = "Conexion A Servidor Establecida"
            Timer1.Start()
        Else
            lblCarga1.Text = "Preparando 1/2"
            lblCargaDescrpitivo.Text = "Conexion A Servidor No Establecida"
            xd = "1"
            'avisosalida = MsgBox("no se ha podido establecer conexion con el servidor, ¿Desea continuar?", MsgBoxStyle.YesNo, "Advertencia")
            'If avisosalida = 6 Then
            'My.Settings.errordb = "1"
            '    My.Settings.Save()
            'My.Settings.Reload()
            'Timer1.Start()
            'Else
            'End
            ' End If
        End If


    End Sub

    Function Archivos()
        lblCargaDescrpitivo.Text = ""
        lblCarga1.Text = "Preparando"
        lblCargaDescrpitivo.Text = "Preparando"

    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Archivos()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If xd = "1" Then
            Timer2.Stop()
            Me.Hide()
            MsgBox("No se ha podido conectar con el servidor, el programa se cerrara")
            Application.Exit()
        Else
            Timer2.Stop()

            Ingreso.Show()
            Me.Hide()
        End If

    End Sub

End Class