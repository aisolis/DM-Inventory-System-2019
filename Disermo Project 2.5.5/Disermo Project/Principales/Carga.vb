Imports System.Data.SqlClient
Imports System.Threading
Public Class Carga
    Dim xd, avisosalida As String
    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaBaseDeDatos()
        lblVersion.Text = "Administrador Disermo " & My.Settings.ProgramVersion
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

    'VERIFICA CONEXION A BASE DE DATOS
    Sub CargaBaseDeDatos()
        tmrConexDB.Enabled = True
        tmrConexDB.Start()

        My.Settings.conexionglobal = "Data Source=SWORDSUWU-PC\LUCIEL;Initial Catalog=Disermo;Persist Security Info=True;User ID=owo;Password=owo"
        My.Settings.Save()
        My.Settings.Reload()
        lblCarga1.Text = "Preparando 1/3"
        lblCargaDescrpitivo.Text = "Inicializando conexiones"
        Thread.Sleep(3000)
        conect()
        If conect() = True Then
            lblCarga1.Text = "Preparando 1/3"
            lblCargaDescrpitivo.Text = "Conexion s servidor establecida"

            My.Settings.CargaConexDB = True
        Else
            lblCarga1.Text = "Preparando 1/3"
            lblCargaDescrpitivo.Text = "Conexion a el servidor no establecida"
            My.Settings.errordb = "1"
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.CargaConexDB = False
        End If

    End Sub

    Private Sub TmrConexDB_Tick(sender As Object, e As EventArgs) Handles tmrConexDB.Tick
        CargaInternet()
        tmrConexDB.Stop()
        tmrConexDB.Enabled = False
    End Sub

    'VERIFICA CONEXION A INTERNET
    Sub CargaInternet()
        Try
            tmrInternet.Enabled = True
            tmrInternet.Start()

            lblCargaDescrpitivo.Text = ""
            If xd = "1" Then
                lblCarga1.Text = "Preparando 2/3"
            Else
                lblCarga1.Text = "Preparando 2/3"
                lblCargaDescrpitivo.Text = "Comprobando conexion a internet"
                If My.Computer.Network.IsAvailable Then

                    My.Settings.CargaRed = True

                    If My.Computer.Network.Ping("www.google.com", 1000) Then

                        My.Settings.CargaInternet = True
                        lblCargaDescrpitivo.Text = "Conexion a internet establecida exitosamente"
                    Else
                        lblCargaDescrpitivo.Text = "Conexion no establecida"
                    End If
                Else
                    lblCargaDescrpitivo.Text = "Conexion no establecida"

                    My.Settings.CargaInternet = False
                    My.Settings.CargaRed = False
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TmrInternet_Tick(sender As Object, e As EventArgs) Handles tmrInternet.Tick
        CargaArchivos()
        tmrInternet.Stop()
        tmrInternet.Enabled = False
    End Sub

    'VERIFICA CARGA DE ARCHIVOS
    Sub CargaArchivos()
        tmrArchivos.Enabled = True
        tmrArchivos.Start()

        My.Settings.CargaArchivos = True
        lblCarga1.Text = "Preparando 3/3"
        lblCargaDescrpitivo.Text = "Verificando sistema de archivos desactivada"

    End Sub

    Private Sub TmrArchivos_Tick(sender As Object, e As EventArgs) Handles tmrArchivos.Tick
        CargaComprobar()
        tmrArchivos.Stop()
        tmrArchivos.Enabled = False
    End Sub

    'VERIFICA USABILIDAD DEL PROGRAMA
    Sub CargaComprobar()
        If My.Settings.CargaConexDB = True And My.Settings.CargaRed = True And My.Settings.CargaInternet = True And My.Settings.CargaArchivos = True Then
            Me.Hide()
            Ingreso.Show()
        Else
            Me.Hide()
            PostCarga.Show()
        End If


    End Sub
End Class