Public Class Menu_de_utilitarios

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles util5.Click
        Me.PanelContenedor.Controls.Clear()
        Cuadro_de_productos.TopLevel = False
        Me.PanelContenedor.Controls.Add(Cuadro_de_productos)
        centro()
        Cuadro_de_productos.FormBorderStyle = FormBorderStyle.None
        Cuadro_de_productos.Show()
    End Sub

    Private Sub BusquedaDeClientesPorNitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles util4.Click
        Me.PanelContenedor.Controls.Clear()
        Busqueda_de_clientes.TopLevel = False
        Me.PanelContenedor.Controls.Add(Busqueda_de_clientes)
        centro()
        Busqueda_de_clientes.FormBorderStyle = FormBorderStyle.None
        Busqueda_de_clientes.Show()
    End Sub

    Private Sub CuadroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles util6.Click
        Me.PanelContenedor.Controls.Clear()
        CuadroDeClientes.TopLevel = False
        Me.PanelContenedor.Controls.Add(CuadroDeClientes)
        centro()
        CuadroDeClientes.FormBorderStyle = FormBorderStyle.None
        CuadroDeClientes.Show()
    End Sub

    Private Sub CuadroDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles util2.Click
        Me.PanelContenedor.Controls.Clear()
        Consulta_de_Proveedores.TopLevel = False
        Me.PanelContenedor.Controls.Add(Consulta_de_Proveedores)
        centro()
        Consulta_de_Proveedores.FormBorderStyle = FormBorderStyle.None
        Consulta_de_Proveedores.Show()
    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles util3.Click
        Me.PanelContenedor.Controls.Clear()
        Cotizaciones.TopLevel = False
        Me.PanelContenedor.Controls.Add(Cotizaciones)
        centro()
        Cotizaciones.FormBorderStyle = FormBorderStyle.None
        Cotizaciones.Show()
    End Sub

    Private Sub VerificacionDeBoletasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Menu_de_utilitarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function centro()
        'FormHijo.Location = New Point((Me.PanelContenedor.Width - FormHijo.Width) / 2, (Me.PanelContenedor.Height - FormHijo.Height) / 2)
        If My.Settings.ConfigPosicionamiento = True Then
            Busqueda_de_clientes.Location = New Point((Me.PanelContenedor.Width - Busqueda_de_clientes.Width) / 2, 0)
            Consulta_de_Proveedores.Location = New Point((Me.PanelContenedor.Width - Consulta_de_Proveedores.Width) / 2, 0)
            Cotizaciones.Location = New Point((Me.PanelContenedor.Width - Cotizaciones.Width) / 2, 0)
            CuadroDeClientes.Location = New Point((Me.PanelContenedor.Width - CuadroDeClientes.Width) / 2, 0)
            Cuadro_de_productos.Location = New Point((Me.PanelContenedor.Width - Cuadro_de_productos.Width) / 2, 0)
        ElseIf My.Settings.ConfigPosicionamiento = False Then
            Busqueda_de_clientes.Location = New Point(10, 0)
            Consulta_de_Proveedores.Location = New Point(10, 0)
            Cotizaciones.Location = New Point(10, 0)
            CuadroDeClientes.Location = New Point(10, 0)
            Cuadro_de_productos.Location = New Point(10, 0)
        End If
    End Function
End Class