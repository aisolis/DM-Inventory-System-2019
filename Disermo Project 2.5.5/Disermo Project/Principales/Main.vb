Option Explicit On
Imports System.Data.SqlClient
Public Class Main
    Dim TEMATIZACION As New Colorizacion
    Dim avisosalida As String
    Dim _enabledCerrar As Boolean = False
    Dim sentencia As String
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")>
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnTamaño.Click
        If PanelLateral.Width = 200 Then
            PanelLateral.Width = 50
        Else
            PanelLateral.Width = 200
        End If
    End Sub


    Function Maximizar()
        MenuCuentasPorPagar.WindowState = FormWindowState.Maximized
        menu_de_cuentas_por_cobrar.WindowState = FormWindowState.Maximized
        Menu_de_utilitarios.WindowState = FormWindowState.Maximized
        menu_mantenimientos.WindowState = FormWindowState.Maximized
        Menu_Movimientos.WindowState = FormWindowState.Maximized
        General.WindowState = FormWindowState.Maximized
    End Function

    Function Reposicionamiento()
        pcbFondo.Top = ((Me.PanelContenedor.Height - pcbFondo.Height) / 2)
        pcbFondo.Left = ((Me.PanelContenedor.Width - pcbFondo.Width) / 2)
    End Function

    Function DesmarcarBotones()

        TEMATIZACION.ColoresMain()

        PanelIndicador1.Visible = False
        PanelIndicador2.Visible = False
        PanelIndicador3.Visible = False
        PanelIndicador4.Visible = False
        PanelIndicador5.Visible = False
        PanelIndicador6.Visible = False

    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TEMATIZACION.ColoresMain()
        Reposicionamiento()
        DesmarcarBotones()
        PanelIndicador1.Visible = True
        btnInicio.BackColor = Color.Silver

        General.PanelContenedor.Controls.Clear()
        xd.TopLevel = False
        General.PanelContenedor.Controls.Add(xd)
        Maximizar()
        xd.FormBorderStyle = FormBorderStyle.None
        xd.Show()

        Me.PanelContenedor.Controls.Clear()
        General.TopLevel = False
        Me.PanelContenedor.Controls.Add(General)
        Maximizar()
        General.FormBorderStyle = FormBorderStyle.None
        General.Show()

        Me.Text = My.Settings.ConfigNombrePrograma & " - Menu Principal   /  Usuario: " & My.Settings.NombreUsuario
        btnUsuario.Text = My.Settings.NombreUsuario

        Ingreso.Close()

    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Reposicionamiento()
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        DesmarcarBotones()
        PanelIndicador1.Visible = True
        btnInicio.BackColor = Color.Silver
        If PanelContenedor.Controls.Contains(General) Then
            General.Close()
        End If

        General.PanelContenedor.Controls.Clear()
        xd.TopLevel = False
        General.PanelContenedor.Controls.Add(xd)
        Maximizar()
        xd.FormBorderStyle = FormBorderStyle.None
        xd.Show()


        Me.PanelContenedor.Controls.Clear()
        General.TopLevel = False
        Me.PanelContenedor.Controls.Add(General)
        Maximizar()
        General.FormBorderStyle = FormBorderStyle.None
        General.Show()



    End Sub

    Private Sub BtnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        DesmarcarBotones()
        PanelIndicador2.Visible = True
        btnMovimientos.BackColor = Color.Silver
        If Menu_Movimientos.PanelContenedor.Controls.Contains(Documentos_de_compra) Then
            Documentos_de_compra.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Envios_de_entrada) Then
            Envios_de_entrada.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Envios_de_salida) Then
            Envios_de_salida.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Facturas_compra) Then
            Facturas_compra.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Facturascompra) Then
            Facturascompra.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Notas_de_credito) Then
            Notas_de_credito.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Notas_de_credito_proveedores) Then
            Notas_de_credito_proveedores.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Recibos_a_clientes) Then
            Recibos_a_clientes.Close()
        ElseIf Menu_Movimientos.PanelContenedor.Controls.Contains(Recibos_a_proveedor) Then
            Recibos_a_proveedor.Close()
        End If
        Me.PanelContenedor.Controls.Clear()
        Menu_Movimientos.TopLevel = False
        Me.PanelContenedor.Controls.Add(Menu_Movimientos)
        Maximizar()
        Menu_Movimientos.FormBorderStyle = FormBorderStyle.None
        Menu_Movimientos.Show()

        Menu_Movimientos.PanelContenedor.Controls.Clear()

        Me.Text = My.Settings.ConfigNombrePrograma & " - Movimientos   /  Usuario: " & My.Settings.NombreUsuario
    End Sub

    Private Sub BtnMantenimientos_Click(sender As Object, e As EventArgs) Handles btnMantenimientos.Click
        DesmarcarBotones()
        PanelIndicador3.Visible = True
        btnMantenimientos.BackColor = Color.Silver
        If menu_mantenimientos.PanelContenedor.Controls.Contains(Maestro_de_clientes) Then
            Maestro_de_clientes.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Maestro_de_combinaciones) Then
            Maestro_de_combinaciones.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Maestro_de_productos) Then
            Maestro_de_productos.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Maestro_de_proveedores) Then
            Maestro_de_proveedores.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Maestro_de_supervicion_) Then
            Maestro_de_supervicion_.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Maestro_de_usuarios) Then
            Maestro_de_usuarios.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Maestro_de_vendedores) Then
            Maestro_de_vendedores.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Mantenimiento_de_rutas) Then
            Mantenimiento_de_rutas.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(mantinimiento_de_sub_rutas) Then
            mantinimiento_de_sub_rutas.Close()
        ElseIf menu_mantenimientos.PanelContenedor.Controls.Contains(Municipios) Then
            Municipios.Close()
        End If
        Me.PanelContenedor.Controls.Clear()
        menu_mantenimientos.TopLevel = False
        Me.PanelContenedor.Controls.Add(menu_mantenimientos)
        Maximizar()
        menu_mantenimientos.FormBorderStyle = FormBorderStyle.None
        menu_mantenimientos.Show()

        menu_mantenimientos.PanelContenedor.Controls.Clear()

        Me.Text = My.Settings.ConfigNombrePrograma & " - Mantenimientos   /  Usuario: " & My.Settings.NombreUsuario
    End Sub

    Private Sub BtnCuentasCobrar_Click(sender As Object, e As EventArgs) Handles btnCuentasCobrar.Click
        DesmarcarBotones()
        PanelIndicador4.Visible = True
        btnCuentasCobrar.BackColor = Color.Silver
        If menu_de_cuentas_por_cobrar.PanelContenedor.Controls.Contains(Antiguedad_de_saldos) Then
            Antiguedad_de_saldos.Close()
        ElseIf Menu_de_utilitarios.PanelContenedor.Controls.Contains(Facturas_Canceladas_Clientes) Then
            Facturas_Canceladas_Clientes.Close()
        ElseIf Menu_de_utilitarios.PanelContenedor.Controls.Contains(Facturas_Morosas_Vendedor) Then
            Facturas_Morosas_Vendedor.Close()
        ElseIf Menu_de_utilitarios.PanelContenedor.Controls.Contains(facturas_pendientes_de_pago) Then
            facturas_pendientes_de_pago.Close()
        End If
        Me.PanelContenedor.Controls.Clear()
        menu_de_cuentas_por_cobrar.TopLevel = False
        Me.PanelContenedor.Controls.Add(menu_de_cuentas_por_cobrar)
        Maximizar()
        menu_de_cuentas_por_cobrar.FormBorderStyle = FormBorderStyle.None
        menu_de_cuentas_por_cobrar.Show()

        menu_de_cuentas_por_cobrar.PanelContenedor.Controls.Clear()

        Me.Text = My.Settings.ConfigNombrePrograma & " - Cuentas por Cobrar   /  Usuario: " & My.Settings.NombreUsuario
    End Sub

    Private Sub BtnCuentasPagar_Click(sender As Object, e As EventArgs) Handles btnCuentasPagar.Click
        DesmarcarBotones()
        PanelIndicador5.Visible = True
        btnCuentasPagar.BackColor = Color.Silver
        If MenuCuentasPorPagar.PanelContenedor.Controls.Contains(facturas_Morosas) Then
            facturas_Morosas.Close()
        ElseIf MenuCuentasPorPagar.PanelContenedor.Controls.Contains(facturas_por_pagar) Then
            facturas_por_pagar.Close()
        ElseIf MenuCuentasPorPagar.PanelContenedor.Controls.Contains(Documentos_Cancelados) Then
            Documentos_Cancelados.Close()
        ElseIf MenuCuentasPorPagar.PanelContenedor.Controls.Contains(reporte_de_antiguedad) Then
            reporte_de_antiguedad.Close()
        End If
        Me.PanelContenedor.Controls.Clear()
        MenuCuentasPorPagar.TopLevel = False
        Me.PanelContenedor.Controls.Add(MenuCuentasPorPagar)
        Maximizar()
        MenuCuentasPorPagar.FormBorderStyle = FormBorderStyle.None
        MenuCuentasPorPagar.Show()

        MenuCuentasPorPagar.PanelContenedor.Controls.Clear()

        Me.Text = My.Settings.ConfigNombrePrograma & " - Cuentas por Pagar   /  Usuario: " & My.Settings.NombreUsuario
    End Sub

    Private Sub BtnUtilitarios_Click(sender As Object, e As EventArgs) Handles btnUtilitarios.Click
        DesmarcarBotones()
        PanelIndicador6.Visible = True
        btnUtilitarios.BackColor = Color.Silver
        If Menu_de_utilitarios.PanelContenedor.Controls.Contains(Busqueda_de_clientes) Then
            Busqueda_de_clientes.Close()
        ElseIf Menu_de_utilitarios.PanelContenedor.Controls.Contains(Consulta_de_Proveedores) Then
            Consulta_de_Proveedores.Close()
        ElseIf Menu_de_utilitarios.PanelContenedor.Controls.Contains(Cotizaciones) Then
            Cotizaciones.Close()
        ElseIf Menu_de_utilitarios.PanelContenedor.Controls.Contains(CuadroDeClientes) Then
            CuadroDeClientes.Close()
        ElseIf Menu_de_utilitarios.PanelContenedor.Controls.Contains(Cuadro_de_productos) Then
            Cuadro_de_productos.Close()
        End If
        Me.PanelContenedor.Controls.Clear()
        Menu_de_utilitarios.TopLevel = False
        Me.PanelContenedor.Controls.Add(Menu_de_utilitarios)
        Maximizar()
        Menu_de_utilitarios.FormBorderStyle = FormBorderStyle.None
        Menu_de_utilitarios.Show()

        Menu_de_utilitarios.PanelContenedor.Controls.Clear()

        Me.Text = My.Settings.ConfigNombrePrograma & " - Utlilitarios   /  Usuario: " & My.Settings.NombreUsuario
    End Sub

    Private Sub PanelContenedor_Resize(sender As Object, e As EventArgs)
        Maximizar()
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Configuración.StartPosition = FormStartPosition.CenterScreen
        Configuración.TopMost = True
        Configuración.Show()

        Me.Enabled = False
    End Sub

    Private Sub BtnQue_Click(sender As Object, e As EventArgs) Handles btnQue.Click
        Ayuda.StartPosition = FormStartPosition.CenterScreen
        Ayuda.TopMost = True
        Ayuda.Show()

        'Me.Enabled = False
    End Sub

    Private Sub BtnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        Usuario.StartPosition = FormStartPosition.CenterScreen
        Usuario.TopMost = True
        Usuario.Show()
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
    Public Sub cerrar()
        If Me.Visible = True Then
            avisosalida = MsgBox("se procedera a cerrar la sesion, ¿Desea continuar?", MsgBoxStyle.YesNo, "Advertencia")
            If avisosalida = 6 Then
                Me.Hide()
                Ingreso.Show()
            ElseIf Me.Visible = False Then
                Me.Show()
            End If
        Else
        End If
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cerrar()
    End Sub

    Public Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        avisosalida = MsgBox("Terminando la sesion", MsgBoxStyle.YesNo, "Advertencia")
        If avisosalida = 6 Then
            Me.Hide()
            sentencia = "insert into ultimasesion values('" + btnUsuario.Text + "')"
            ejecutarSQL(sentencia)
            Ingreso.Show()

        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.PanelContenedor.Controls.Clear()
        General.TopLevel = False
        Me.PanelContenedor.Controls.Add(General)
        Maximizar()
        General.FormBorderStyle = FormBorderStyle.None
        General.Show()

        General.PanelContenedor.Controls.Clear()
        Ejemplo2.TopLevel = False
        General.PanelContenedor.Controls.Add(Ejemplo2)
        Maximizar()
        Ejemplo2.FormBorderStyle = FormBorderStyle.None
        Ejemplo2.Show()
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub WebBrowserClima_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserClima.DocumentCompleted
        If My.Computer.Network.IsAvailable Then
            xd.timerclima.Start()
            'xd.PBClima.ImageLocation = WebBrowserClima.Document.GetElementById("wob_tci").GetAttribute("src")

        Else
            xd.lblClima.Text = "Desconocido"
            Configuración.btnObtencionValorQuetzal.Enabled = False
        End If

    End Sub
End Class