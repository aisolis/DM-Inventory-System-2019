Public Class menu_de_cuentas_por_cobrar
    Private Sub FacturasMorosasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasMorosasToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Facturas_Morosas_Vendedor.TopLevel = False
        Me.PanelContenedor.Controls.Add(Facturas_Morosas_Vendedor)
        centro()
        Facturas_Morosas_Vendedor.FormBorderStyle = FormBorderStyle.None
        Facturas_Morosas_Vendedor.Show()
    End Sub
    Private Sub AntiguedadDeSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntiguedadDeSaldosToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Antiguedad_de_saldos.TopLevel = False
        Me.PanelContenedor.Controls.Add(Antiguedad_de_saldos)
        centro()
        Antiguedad_de_saldos.FormBorderStyle = FormBorderStyle.None
        Antiguedad_de_saldos.Show()
    End Sub
    Private Sub FacturaCanceladasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaCanceladasToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Facturas_Canceladas_Clientes.TopLevel = False
        Me.PanelContenedor.Controls.Add(Facturas_Canceladas_Clientes)
        centro()
        Facturas_Canceladas_Clientes.FormBorderStyle = FormBorderStyle.None
        Facturas_Canceladas_Clientes.Show()
    End Sub

    Private Sub FacturasPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasPendientesToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        facturas_pendientes_de_pago.TopLevel = False
        Me.PanelContenedor.Controls.Add(facturas_pendientes_de_pago)
        centro()
        facturas_pendientes_de_pago.FormBorderStyle = FormBorderStyle.None
        facturas_pendientes_de_pago.Show()
    End Sub
    Function centro()
        'FormHijo.Location = New Point((Me.PanelContenedor.Width - FormHijo.Width) / 2, (Me.PanelContenedor.Height - FormHijo.Height) / 2)
        If My.Settings.ConfigPosicionamiento = True Then
            Antiguedad_de_saldos.Location = New Point((Me.PanelContenedor.Width - Antiguedad_de_saldos.Width) / 2, 0)
            Facturas_Canceladas_Clientes.Location = New Point((Me.PanelContenedor.Width - Facturas_Canceladas_Clientes.Width) / 2, 0)
            Facturas_Morosas_Vendedor.Location = New Point((Me.PanelContenedor.Width - Facturas_Morosas_Vendedor.Width) / 2, 0)
            facturas_pendientes_de_pago.Location = New Point((Me.PanelContenedor.Width - facturas_pendientes_de_pago.Width) / 2, 0)
        ElseIf My.Settings.ConfigPosicionamiento = False Then
            Antiguedad_de_saldos.Location = New Point(10, 0)
            Antiguedad_de_saldos.Location = New Point(10, 0)
            Facturas_Canceladas_Clientes.Location = New Point(10, 0)
            facturas_Morosas.Location = New Point(10, 0)
            facturas_pendientes_de_pago.Location = New Point(10, 0)
        End If
    End Function

    Private Sub CuentasPorCobrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasPorCobrarToolStripMenuItem.Click

    End Sub
End Class