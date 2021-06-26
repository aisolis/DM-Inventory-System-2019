Public Class PostCarga
    Private Sub PostCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Opacity = 0.0R
        Carga.ShowInTaskbar = False
        Carga.Visible = False
        'Carga.Hide()

        If My.Settings.CargaConexDB = False Then
            lblbError.Items.Add("- No se ha podido conectar con la base de datos")
            btnContinuar.Visible = False
            btnSalir.Left = 293
        End If
        If My.Settings.CargaRed = False Then
            lblbError.Items.Add("- No se ha detectado una conexion a la red")
        End If
        If My.Settings.CargaInternet = False Then
            lblbError.Items.Add("- No se ha podido conectar a internet")
        End If
        If My.Settings.CargaArchivos = False Then
            lblbError.Items.Add("- No se han encontrado todos los archivos")
            btnContinuar.Visible = False
            btnSalir.Left = 293
        End If
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Ingreso.Show()
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class