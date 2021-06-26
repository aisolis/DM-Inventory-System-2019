Public Class Colorizacion
    Function ColoresMain()
        If My.Settings.ConfigTema = True Then
            Main.btnInicio.BackColor = Color.FromArgb(224, 224, 224)
            Main.btnMovimientos.BackColor = Color.FromArgb(224, 224, 224)
            Main.btnMantenimientos.BackColor = Color.FromArgb(224, 224, 224)
            Main.btnCuentasCobrar.BackColor = Color.FromArgb(224, 224, 224)
            Main.btnCuentasPagar.BackColor = Color.FromArgb(224, 224, 224)
            Main.btnUtilitarios.BackColor = Color.FromArgb(224, 224, 224)


        ElseIf My.Settings.ConfigTema = False Then
            Main.btnInicio.BackColor = Color.FromArgb(65, 65, 65)
            Main.btnMovimientos.BackColor = Color.FromArgb(65, 65, 65)
            Main.btnMantenimientos.BackColor = Color.FromArgb(65, 65, 65)
            Main.btnCuentasCobrar.BackColor = Color.FromArgb(65, 65, 65)
            Main.btnCuentasPagar.BackColor = Color.FromArgb(65, 65, 65)
            Main.btnUtilitarios.BackColor = Color.FromArgb(65, 65, 65)

            Main.PanelLateral.BackColor = Color.FromArgb(65, 65, 65)
            Main.PanelContenedor.BackColor = Color.FromArgb(80, 80, 80)

            Main.BackColor = Color.FromArgb(53, 53, 53)
            Main.ForeColor = SystemColors.Control
        End If


    End Function

    Function Fondos()

        If My.Settings.ConfigTema = True Then




        ElseIf My.Settings.ConfigTema = False Then


            MenuCuentasPorPagar.BackColor = Color.FromArgb(80, 80, 80)
            MenuCuentasPorPagar.ForeColor = SystemColors.Control

            For Each CONTROL As Control In MenuCuentasPorPagar.Controls
                If TypeOf CONTROL Is Button Then
                    CONTROL.ForeColor = SystemColors.Control
                    CONTROL.BackColor = Color.FromArgb(65, 65, 65)
                End If
                If TypeOf CONTROL Is TextBox Then
                    CONTROL.ForeColor = SystemColors.Control
                    CONTROL.BackColor = Color.FromArgb(65, 65, 65)
                End If
            Next


            facturas_Morosas.BackColor = Color.FromArgb(80, 80, 80)
            facturas_Morosas.ForeColor = SystemColors.Control

            For Each CONTROL As Control In facturas_Morosas.Controls
                If TypeOf CONTROL Is Button Then
                    CONTROL.ForeColor = SystemColors.Control
                    CONTROL.BackColor = Color.FromArgb(65, 65, 65)
                End If
                If TypeOf CONTROL Is TextBox Then
                    CONTROL.ForeColor = SystemColors.Control
                    CONTROL.BackColor = Color.FromArgb(65, 65, 65)
                End If
            Next


            menu_de_cuentas_por_cobrar.BackColor = Color.FromArgb(80, 80, 80)
                    menu_de_cuentas_por_cobrar.ForeColor = SystemColors.Control
                    Antiguedad_de_saldos.BackColor = Color.FromArgb(80, 80, 80)
                    Antiguedad_de_saldos.ForeColor = SystemColors.Control
                    Facturas_Canceladas_Clientes.BackColor = Color.FromArgb(80, 80, 80)
                    Facturas_Canceladas_Clientes.ForeColor = SystemColors.Control
                    Facturas_Morosas_Vendedor.BackColor = Color.FromArgb(80, 80, 80)
                    Facturas_Morosas_Vendedor.ForeColor = SystemColors.Control
                    facturas_pendientes_de_pago.BackColor = Color.FromArgb(80, 80, 80)
                    facturas_pendientes_de_pago.ForeColor = SystemColors.Control

                    Menu_de_utilitarios.BackColor = Color.FromArgb(80, 80, 80)
                    Busqueda_de_clientes.BackColor = Color.FromArgb(80, 80, 80)
                    Consulta_de_Proveedores.BackColor = Color.FromArgb(80, 80, 80)
                    Cotizaciones.BackColor = Color.FromArgb(80, 80, 80)
                    CuadroDeClientes.BackColor = Color.FromArgb(80, 80, 80)
                    Cuadro_de_productos.BackColor = Color.FromArgb(80, 80, 80)
                    Menu_de_utilitarios.BackColor = Color.FromArgb(80, 80, 80)

                    menu_mantenimientos.BackColor = Color.FromArgb(80, 80, 80)
                    Maestro_de_clientes.BackColor = Color.FromArgb(80, 80, 80)
                    Maestro_de_combinaciones.BackColor = Color.FromArgb(80, 80, 80)
                    Maestro_de_productos.BackColor = Color.FromArgb(80, 80, 80)
                    Maestro_de_proveedores.BackColor = Color.FromArgb(80, 80, 80)
                    Maestro_de_supervicion_.BackColor = Color.FromArgb(80, 80, 80)
                    Maestro_de_usuarios.BackColor = Color.FromArgb(80, 80, 80)
                    Maestro_de_vendedores.BackColor = Color.FromArgb(80, 80, 80)
                    Mantenimiento_de_rutas.BackColor = Color.FromArgb(80, 80, 80)
                    mantinimiento_de_sub_rutas.BackColor = Color.FromArgb(80, 80, 80)
                    Municipios.BackColor = Color.FromArgb(80, 80, 80)

                    Menu_Movimientos.BackColor = Color.FromArgb(80, 80, 80)
                    Documentos_de_compra.BackColor = Color.FromArgb(80, 80, 80)
                    Envios_de_entrada.BackColor = Color.FromArgb(80, 80, 80)
                    Envios_de_salida.BackColor = Color.FromArgb(80, 80, 80)
                    Facturascompra.BackColor = Color.FromArgb(80, 80, 80)
                    Notas_de_credito.BackColor = Color.FromArgb(80, 80, 80)
                    Notas_de_credito_proveedores.BackColor = Color.FromArgb(80, 80, 80)
                    Recibos_a_clientes.BackColor = Color.FromArgb(80, 80, 80)
                    Recibos_a_proveedor.BackColor = Color.FromArgb(80, 80, 80)




                End If

    End Function
End Class
