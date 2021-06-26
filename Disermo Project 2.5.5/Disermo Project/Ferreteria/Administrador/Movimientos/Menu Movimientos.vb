Public Class Menu_Movimientos
    Private Sub Menu_Movimientos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main.Show()
    End Sub

    Function centro()
        'FormHijo.Location = New Point((Me.PanelContenedor.Width - FormHijo.Width) / 2, (Me.PanelContenedor.Height - FormHijo.Height) / 2)
        If My.Settings.ConfigPosicionamiento = True Then
            Documentos_de_compra.Location = New Point((Me.PanelContenedor.Width - Documentos_de_compra.Width) / 2, 0)
            Envios_de_entrada.Location = New Point((Me.PanelContenedor.Width - Envios_de_entrada.Width) / 2, 0)
            Envios_de_salida.Location = New Point((Me.PanelContenedor.Width - Envios_de_salida.Width) / 2, 0)
            Facturascompra.Location = New Point((Me.PanelContenedor.Width - Facturascompra.Width) / 2, 0)
            Notas_de_credito.Location = New Point((Me.PanelContenedor.Width - Notas_de_credito.Width) / 2, 0)
            Notas_de_credito_proveedores.Location = New Point((Me.PanelContenedor.Width - Notas_de_credito_proveedores.Width) / 2, 0)
            Recibos_a_clientes.Location = New Point((Me.PanelContenedor.Width - Recibos_a_clientes.Width) / 2, 0)
            Recibos_a_proveedor.Location = New Point((Me.PanelContenedor.Width - Recibos_a_proveedor.Width) / 2, 0)
        ElseIf My.Settings.ConfigPosicionamiento = False Then
            Documentos_de_compra.Location = New Point(10, 0)
            Envios_de_entrada.Location = New Point(10, 0)
            Envios_de_salida.Location = New Point(10, 0)
            Facturascompra.Location = New Point(10, 0)
            Notas_de_credito.Location = New Point(10, 0)
            Notas_de_credito_proveedores.Location = New Point(10, 0)
            Recibos_a_clientes.Location = New Point(10, 0)
            Recibos_a_proveedor.Location = New Point(10, 0)
        End If
    End Function



    Private Sub EnviosDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mov4.Click
        Me.PanelContenedor.Controls.Clear()
        Envios_de_salida.TopLevel = False
        Me.PanelContenedor.Controls.Add(Envios_de_salida)
        centro()
        Envios_de_salida.FormBorderStyle = FormBorderStyle.None
        Envios_de_salida.Show()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mov10.Click
        Me.PanelContenedor.Controls.Clear()
        Facturascompra.TopLevel = False
        Me.PanelContenedor.Controls.Add(Facturascompra)
        centro()
        Facturascompra.FormBorderStyle = FormBorderStyle.None
        Facturascompra.Show()
    End Sub
    Private Sub NotasDeCreditoClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mov6.Click
        Me.PanelContenedor.Controls.Clear()
        Notas_de_credito.TopLevel = False
        Me.PanelContenedor.Controls.Add(Notas_de_credito)
        centro()
        Notas_de_credito.FormBorderStyle = FormBorderStyle.None
        Notas_de_credito.Show()
    End Sub

    Private Sub NotasDeCreditoProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mov7.Click
        Me.PanelContenedor.Controls.Clear()
        Notas_de_credito_proveedores.TopLevel = False
        Me.PanelContenedor.Controls.Add(Notas_de_credito_proveedores)
        centro()
        Notas_de_credito_proveedores.FormBorderStyle = FormBorderStyle.None
        Notas_de_credito_proveedores.Show()
    End Sub

    Private Sub ReciboAClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mov8.Click
        Me.PanelContenedor.Controls.Clear()
        Recibos_a_clientes.TopLevel = False
        Me.PanelContenedor.Controls.Add(Recibos_a_clientes)
        centro()
        Recibos_a_clientes.FormBorderStyle = FormBorderStyle.None
        Recibos_a_clientes.Show()
    End Sub

    Private Sub RecibosAProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mov9.Click
        Me.PanelContenedor.Controls.Clear()
        Recibos_a_proveedor.TopLevel = False
        Me.PanelContenedor.Controls.Add(Recibos_a_proveedor)
        centro()
        Recibos_a_proveedor.FormBorderStyle = FormBorderStyle.None
        Recibos_a_proveedor.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub Menu_Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DocumentosDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.PanelContenedor.Controls.Clear()
        Documentos_de_compra.TopLevel = False
        Me.PanelContenedor.Controls.Add(Documentos_de_compra)
        centro()
        Documentos_de_compra.FormBorderStyle = FormBorderStyle.None
        Documentos_de_compra.Show()
    End Sub

    Private Sub MantenimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientosToolStripMenuItem.Click

    End Sub

    Private Sub EnviosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mov3.Click
        Me.PanelContenedor.Controls.Clear()
        Envios_de_entrada.TopLevel = False
        Me.PanelContenedor.Controls.Add(Envios_de_entrada)
        centro()
        Envios_de_entrada.FormBorderStyle = FormBorderStyle.None
        Envios_de_entrada.Show()
    End Sub

    Private Sub mov5_Click(sender As Object, e As EventArgs) Handles mov5.Click
        Me.PanelContenedor.Controls.Clear()
        Facturascompra.TopLevel = False
        Me.PanelContenedor.Controls.Add(Facturascompra)
        centro()
        Facturascompra.FormBorderStyle = FormBorderStyle.None
        Facturascompra.Show()
    End Sub
End Class