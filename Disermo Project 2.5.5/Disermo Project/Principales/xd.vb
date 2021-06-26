Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text

Public Class xd
    Dim DATOS As String = Application.StartupPath & "\notasDM.txt" 'ARCHIVO DE TEXTO PARA GUARDAR DATOS
    Dim mensaje, sentencia As String
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim second As Integer = 0
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_MAXIMIZE As Integer = &HF030
    Dim DATOSnota As String = Application.StartupPath & "\notasDM.txt" 'ARCHIVO DE TEXTO PARA GUARDAR DATOS
    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Dim x As Integer = 0


    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Configuración.StartPosition = FormStartPosition.CenterScreen
        Configuración.TopMost = True
        Configuración.Show()
        Main.Enabled = False
    End Sub

    Private Sub xd_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        usuario.Text = Main.btnUsuario.Text

        lblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()

        lblFecha.Text = DateTime.Now.ToString("D")

        LBLDOLAR.Text = My.Settings.ConfigValorQuetzal + " Q."

        Timer1.Start()
        timerclima.Start()
        'notas.Text = File.ReadAllText(DATOS)
        lblClima.Text = lblClima.Text + " °C"
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from notas where NombreUsuario = '" & usuario.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "notas")
            lista = datos.Tables("notas").Rows.Count
            If lista <> 0 Then
                notas.Text = datos.Tables("notas").Rows(0).Item("nota")
            Else
                Exit Sub
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeString
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Proceso As Process = New Process
        Proceso.StartInfo.FileName = "C:\\calc.exe"
        Proceso.StartInfo.CreateNoWindow = True
        Proceso.Start()
        'Dim Comando As String
        'Comando = "calc"
        'Shell("cmd.exe /k " & Comando)

    End Sub

    Private Sub timerclima_Tick(sender As Object, e As EventArgs) Handles timerclima.Tick
        Try
            lblClima.Text = Main.WebBrowserClima.Document.GetElementById("wob_tm").InnerText & "°C"
            pcbClima.ImageLocation = Main.WebBrowserClima.Document.GetElementById("wob_tci").GetAttribute("src")
        Catch ex As Exception

        End Try

        second = second + 1
        If second = 100 Then
            timerclima.Stop()
            second = 0
            WebBrowserClima.Refresh()
            timerclima.Start()
        End If
    End Sub

    Private Sub WebBrowserClima_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserClima.DocumentCompleted
        timerclima.Start()
    End Sub
    '‪C:\notasDM.txt

    Private Sub LblClima_Click(sender As Object, e As EventArgs) Handles lblClima.Click
        Clima.Show()
    End Sub

    Private Sub BtnConversor_Click(sender As Object, e As EventArgs) Handles btnConversor.Click
        Convertidor.Show()
    End Sub

    Private Sub BtnWeb_Click(sender As Object, e As EventArgs) Handles btnWeb.Click
        MsgBox("Se abrira Disermo.com en el navegador predeterminado")
        Process.Start("https://disermo.com/")
    End Sub

    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        Ayuda.Show()
    End Sub

    Private Sub BtnUltima_Click(sender As Object, e As EventArgs) Handles btnUltima.Click
        MsgBox("Caracteristica Futura")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Caracteristica Futura")
    End Sub

    Private Sub BtnGuardarNota_Click(sender As Object, e As EventArgs) Handles btnGuardarNota.Click
        '  My.Computer.FileSystem.WriteAllText(DATOSnota, notas.Text & vbCrLf, False)
        Try
            Dim conexion As New SqlConnection(My.Settings.conexionglobal)
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from notas where NombreUsuario='" + usuario.Text + "'"
            Dim lista As Byte
            Dim datos1 As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, conexion)
            datos1 = New DataSet
            adaptador.Fill(datos1, "notas")
            lista = datos1.Tables("notas").Rows.Count
            If lista <> 0 Then
                sentencia = "update notas set NombreUsuario='" + usuario.Text + "', nota='" + notas.Text + "' where NombreUsuario='" + usuario.Text + "'"
                ejecutarSQL(sentencia)
                lblguardar.Text = "Se han actualizado tus notas..."
                lblguardar.Visible = True
                Timer2.Start()
                x = 0
            Else
                sentencia = "insert into notas  values('" + usuario.Text + "','" + notas.Text + "')"
                ejecutarSQL(sentencia)
                lblguardar.Text = "Se han creado tus notas..."
                lblguardar.Visible = True
                Timer2.Start()
                x = 0
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        x = x + 1
        If x = 3 Then
            Timer2.Stop()
            lblguardar.Visible = False
        End If
    End Sub

    Sub ejecutarSQL(sql As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class