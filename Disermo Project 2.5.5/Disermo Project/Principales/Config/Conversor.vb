Public Class Convertidor
    Dim conv As Conve = New Conve


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        conv.Cantidad = txtQuetzales.Text
        txtbDolares.Text = conv.ConverDolares()

        'MsgBox(conv.ConverDolares())
    End Sub

    Private Sub Convertidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbDolares.Enabled = False
    End Sub
End Class
