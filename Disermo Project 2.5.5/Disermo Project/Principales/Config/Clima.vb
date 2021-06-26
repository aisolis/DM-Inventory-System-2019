Public Class Clima
    Dim second As Integer = 0
    Private Sub Clima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If My.Computer.Network.IsAvailable Then
        '    If My.Computer.Network.Ping("www.google.com", 1000) Then
        '        WebBrowserClima.Navigate("https://www.google.com.gt/#q=clima+gt")
        '    End If
        'Else
        '    panelnoether.Visible = True
        'End If
        'If IsConnectionAvailable() = True Then
        '    WebBrowserClima.Navigate("https://www.google.com.gt/#q=clima+gt")
        '    TimerClima.Start()
        'Else
        '    panelnoether.Visible = True
        'End If
        'TimerClima.Start()
panelnoether.Visible = True
    End Sub
    Public Function IsConnectionAvailable() As Boolean
        ' Returns True if connection is available 
        ' Replace www.yoursite.com with a site that 
        ' is guaranteed to be online - perhaps your 
        ' corporate site, or microsoft.com 
        Dim objUrl As New System.Uri("http://www.google.com.gt")
        ' Setup WebRequest 
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Attempt to get response and return True 
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            ' Error, exit and return False 
            objWebReq = Nothing
            Return False
        End Try
    End Function
    Private Sub TimerClima_Tick(sender As Object, e As EventArgs) Handles TimerClima.Tick
        Try
            PBClima.ImageLocation = Main.WebBrowserClima.Document.GetElementById("wob_tci").GetAttribute("src")
            LabelCiudad.Text = Main.WebBrowserClima.Document.GetElementById("wob_loc").InnerText
            LabelTemp.Text = Main.WebBrowserClima.Document.GetElementById("wob_tm").InnerText & "°C"
            LabelClima.Text = Main.WebBrowserClima.Document.GetElementById("wob_dc").InnerText
        Catch ex As Exception

        End Try

        second = second + 1
        If second = 100 Then
            TimerClima.Stop()
            second = 0
            WebBrowserClima.Refresh()
            TimerClima.Start()
        End If
    End Sub

    Private Sub LlblGoogleWeather_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblGoogleWeather.LinkClicked
        Process.Start("https://weather.com/es-GT/tiempo/hoy/l/14.66,-90.60?par=google&temp=c")
    End Sub



    Private Sub WebBrowserClima_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserClima.DocumentCompleted
        If My.Computer.Network.IsAvailable Then
            xd.timerclima.Start()
            ' xd.PBClima.ImageLocation = WebBrowserClima.Document.GetElementById("wob_tci").GetAttribute("src")

        Else
            panelnoether.Visible = True
            Configuración.btnObtencionValorQuetzal.Enabled = False
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Close()
    End Sub
End Class