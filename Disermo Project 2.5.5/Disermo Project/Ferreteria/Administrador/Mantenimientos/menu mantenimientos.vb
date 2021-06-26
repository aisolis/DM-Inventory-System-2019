Public Class menu_mantenimientos
    Function centro()
        'FormHijo.Location = New Point((Me.PanelContenedor.Width - FormHijo.Width) / 2, (Me.PanelContenedor.Height - FormHijo.Height) / 2)
        If My.Settings.ConfigPosicionamiento = True Then
            Maestro_de_clientes.Location = New Point((Me.PanelContenedor.Width - Maestro_de_clientes.Width) / 2, 0)
            Maestro_de_combinaciones.Location = New Point((Me.PanelContenedor.Width - Maestro_de_combinaciones.Width) / 2, 0)
            Maestro_de_proveedores.Location = New Point((Me.PanelContenedor.Width - Maestro_de_proveedores.Width) / 2, 0)
            Maestro_de_productos.Location = New Point((Me.PanelContenedor.Width - Maestro_de_productos.Width) / 2, 0)
            Maestro_de_supervicion_.Location = New Point((Me.PanelContenedor.Width - Maestro_de_supervicion_.Width) / 2, 0)
            Maestro_de_usuarios.Location = New Point((Me.PanelContenedor.Width - Maestro_de_usuarios.Width) / 2, 0)
            Maestro_de_vendedores.Location = New Point((Me.PanelContenedor.Width - Maestro_de_vendedores.Width) / 2, 0)
            Mantenimiento_de_rutas.Location = New Point((Me.PanelContenedor.Width - Mantenimiento_de_rutas.Width) / 2, 0)
            mantinimiento_de_sub_rutas.Location = New Point((Me.PanelContenedor.Width - mantinimiento_de_sub_rutas.Width) / 2, 0)
            Municipios.Location = New Point((Me.PanelContenedor.Width - Municipios.Width) / 2, 0)

        ElseIf My.Settings.ConfigPosicionamiento = False Then
            Maestro_de_clientes.Location = New Point(10, 0)
            Maestro_de_combinaciones.Location = New Point(10, 0)
            Maestro_de_proveedores.Location = New Point(10, 0)
            Maestro_de_productos.Location = New Point(10, 0)
            Maestro_de_supervicion_.Location = New Point(10, 0)
            Maestro_de_usuarios.Location = New Point(10, 0)
            Maestro_de_vendedores.Location = New Point(10, 0)
            Mantenimiento_de_rutas.Location = New Point(10, 0)
            mantinimiento_de_sub_rutas.Location = New Point(10, 0)
            Municipios.Location = New Point(10, 0)

        End If

    End Function

    Private Sub MaestroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeClientesToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Maestro_de_clientes.TopLevel = False
        Me.PanelContenedor.Controls.Add(Maestro_de_clientes)
        centro()
        Maestro_de_clientes.FormBorderStyle = FormBorderStyle.None
        Maestro_de_clientes.Show()
    End Sub

    Private Sub MaestroDeCombinacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeCombinacionesToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Maestro_de_combinaciones.TopLevel = False
        Me.PanelContenedor.Controls.Add(Maestro_de_combinaciones)
        centro()
        Maestro_de_combinaciones.FormBorderStyle = FormBorderStyle.None
        Maestro_de_combinaciones.Show()
    End Sub

    Private Sub MaestroDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeProductosToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Maestro_de_productos.TopLevel = False
        Me.PanelContenedor.Controls.Add(Maestro_de_productos)
        centro()
        Maestro_de_productos.FormBorderStyle = FormBorderStyle.None
        Maestro_de_productos.Show()
    End Sub

    Private Sub MaestroDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeProveedoresToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Maestro_de_proveedores.TopLevel = False
        Me.PanelContenedor.Controls.Add(Maestro_de_proveedores)
        centro()
        Maestro_de_proveedores.FormBorderStyle = FormBorderStyle.None
        Maestro_de_proveedores.Show()
    End Sub

    Private Sub MaestroDeSupervicionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeSupervicionToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Maestro_de_supervicion_.TopLevel = False
        Me.PanelContenedor.Controls.Add(Maestro_de_supervicion_)
        centro()
        Maestro_de_supervicion_.FormBorderStyle = FormBorderStyle.None
        Maestro_de_supervicion_.Show()
    End Sub

    Private Sub MaestroDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeUsuariosToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Maestro_de_usuarios.TopLevel = False
        Me.PanelContenedor.Controls.Add(Maestro_de_usuarios)
        centro()
        Maestro_de_usuarios.FormBorderStyle = FormBorderStyle.None
        Maestro_de_usuarios.Show()
    End Sub

    Private Sub MaestroDeVendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroDeVendedoresToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Maestro_de_vendedores.TopLevel = False
        Me.PanelContenedor.Controls.Add(Maestro_de_vendedores)
        centro()
        Maestro_de_vendedores.FormBorderStyle = FormBorderStyle.None
        Maestro_de_vendedores.Show()
    End Sub

    Private Sub MantenimientoDeRutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeRutasToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Mantenimiento_de_rutas.TopLevel = False
        Me.PanelContenedor.Controls.Add(Mantenimiento_de_rutas)
        centro()
        Mantenimiento_de_rutas.FormBorderStyle = FormBorderStyle.None
        Mantenimiento_de_rutas.Show()
    End Sub

    Private Sub MantenimientoDeSubRutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeSubRutasToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        mantinimiento_de_sub_rutas.TopLevel = False
        Me.PanelContenedor.Controls.Add(mantinimiento_de_sub_rutas)
        centro()
        mantinimiento_de_sub_rutas.FormBorderStyle = FormBorderStyle.None
        mantinimiento_de_sub_rutas.Show()
    End Sub

    Private Sub MunicipiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MunicipiosToolStripMenuItem.Click
        Me.PanelContenedor.Controls.Clear()
        Municipios.TopLevel = False
        Me.PanelContenedor.Controls.Add(Municipios)
        centro()
        Municipios.FormBorderStyle = FormBorderStyle.None
        Municipios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub Menu_mantenimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class