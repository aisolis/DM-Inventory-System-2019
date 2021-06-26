Public Class MenuCuentasPorPagar
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub DocumentosEnMoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosEnMoraToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        facturas_Morosas.TopLevel = False
        Me.PanelContenedor.Controls.Add(facturas_Morosas)
        centro()
        facturas_Morosas.FormBorderStyle = FormBorderStyle.None
        facturas_Morosas.Show()
    End Sub

    Private Sub DocumentosPorPagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosPorPagarToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        facturas_por_pagar.TopLevel = False
        Me.PanelContenedor.Controls.Add(facturas_por_pagar)
        centro()
        facturas_por_pagar.FormBorderStyle = FormBorderStyle.None
        facturas_por_pagar.Show()
    End Sub

    Private Sub DocumentosCanceladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosCanceladosToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Documentos_Cancelados.TopLevel = False
        Me.PanelContenedor.Controls.Add(Documentos_Cancelados)
        centro()
        Documentos_Cancelados.FormBorderStyle = FormBorderStyle.None
        Documentos_Cancelados.Show()
    End Sub

    Private Sub ReporteDeAntiguedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAntiguedadToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        reporte_de_antiguedad.TopLevel = False
        Me.PanelContenedor.Controls.Add(reporte_de_antiguedad)
        centro()
        reporte_de_antiguedad.FormBorderStyle = FormBorderStyle.None
        reporte_de_antiguedad.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Show()
    End Sub


    Function centro()
        'FormHijo.Location = New Point((Me.PanelContenedor.Width - FormHijo.Width) / 2, (Me.PanelContenedor.Height - FormHijo.Height) / 2)
        If My.Settings.ConfigPosicionamiento = True Then
            Documentos_Cancelados.Location = New Point((Me.PanelContenedor.Width - Documentos_de_compra.Width) / 2, 0)
            Documentos_de_compra.Location = New Point((Me.PanelContenedor.Width - Documentos_de_compra.Width) / 2, 0)
            facturas_Morosas.Location = New Point((Me.PanelContenedor.Width - facturas_Morosas.Width) / 2, 0)
            reporte_de_antiguedad.Location = New Point((Me.PanelContenedor.Width - reporte_de_antiguedad.Width) / 2, 0)
        ElseIf My.Settings.ConfigPosicionamiento = False Then
            Documentos_Cancelados.Location = New Point(10, 0)
            Documentos_de_compra.Location = New Point(10, 0)
            facturas_Morosas.Location = New Point(10, 0)
            reporte_de_antiguedad.Location = New Point(10, 0)
        End If
    End Function

    Private Sub MenuCuentasPorPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centro()
    End Sub
End Class
