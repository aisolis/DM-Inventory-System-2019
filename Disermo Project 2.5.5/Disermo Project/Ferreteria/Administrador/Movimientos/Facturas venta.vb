Imports System.Data.SqlClient
Public Class Facturascompra
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, tvip, bloqueo, avisosalida, liquidacion, docena, fardo, mediofardo, existencia, total, resta, resta2, sentencia2, valordetalle, sentencia3, sentencia4, sentencia5, sentencia6, sentencia7, anulado, credito As String

    Private Sub Txtidcliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidcliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where Id_cliente = '" & txtidcliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    txtnombrecliente.Text = datos.Tables("tabla_clientes").Rows(0).Item("cliente")
                    txtnonit.Text = datos.Tables("tabla_clientes").Rows(0).Item("nit")
                    txtdireccion.Text = datos.Tables("tabla_clientes").Rows(0).Item("direccion")
                    txttelefonos.Text = datos.Tables("tabla_clientes").Rows(0).Item("telefono")
                    con.Close()
                    txtdiascredito.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtidvendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidvendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from vendedor where id_vendedor = '" & txtidvendedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "vendedor")
                lista = datos.Tables("vendedor").Rows.Count
                If lista <> 0 Then
                    txtvendedor.Text = datos.Tables("vendedor").Rows(0).Item("vendedor")
                    con.Close()
                    txtfechavencimiento.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtidmunicipio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidmunicipio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from municipio where id_municipio = '" & txtidvendedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "municipio")
                lista = datos.Tables("municipio").Rows.Count
                If lista <> 0 Then
                    txtnmuni.Text = datos.Tables("municipio").Rows(0).Item("municipio")
                    con.Close()
                    txtidepartamento.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtidepartamento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidepartamento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from departamento where id_departamento = '" & txtidepartamento.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "departamento")
                lista = datos.Tables("departamento").Rows.Count
                If lista <> 0 Then
                    txtndepto.Text = datos.Tables("departamento").Rows(0).Item("departamento")
                    con.Close()
                    txtnopedido.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtrutacliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrutacliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from ruta where id_ruta = '" & txtrutacliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "ruta")
                lista = datos.Tables("ruta").Rows.Count
                If lista <> 0 Then
                    txtrutacliente2.Text = datos.Tables("ruta").Rows(0).Item("ruta")
                    con.Close()
                    txtsubrutacliente.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtsubrutacliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsubrutacliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from subruta where id_subruta = '" & txtsubrutacliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "subruta")
                lista = datos.Tables("subruta").Rows.Count
                If lista <> 0 Then
                    txtsubrutacliente2.Text = datos.Tables("subruta").Rows(0).Item("subruta")
                    con.Close()
                    txtobservaciones.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Txtfacturano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfacturano.KeyPress, txtsubrutacliente.KeyPress, txtserie.KeyPress, txtrutacliente.KeyPress, txtnopedido.KeyPress, txtlimitecredito.KeyPress, txtidvendedor.KeyPress, txtidmunicipio.KeyPress, txtidepartamento.KeyPress, txtidcliente.KeyPress, txtfechavencimiento.KeyPress, txtdiascredito.KeyPress, txtcobroporenvio.KeyPress, txtcantidad.KeyPress, txt_producto.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtfacturano_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfacturano.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserie.Select()
        End If
    End Sub

    Private Sub Txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtidcliente.Select()
        End If
    End Sub

    Private Sub Txtdiascredito_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdiascredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtlimitecredito.Select()
        End If
    End Sub

    Private Sub Txtlimitecredito_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlimitecredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtidvendedor.Select()
        End If
    End Sub

    Private Sub Txtfechavencimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfechavencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcobroporenvio.Select()
        End If
    End Sub

    Private Sub Txtcobroporenvio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcobroporenvio.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtidmunicipio.Select()
        End If
    End Sub

    Private Sub Txtnopedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnopedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrutacliente.Select()
        End If
    End Sub

    Private Sub Txtobservaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_producto.Select()
        End If
    End Sub

    Private Sub Txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyDown
        existencia = txtexistencia.Text
        If e.KeyCode = Keys.Enter Then
            If txtcantidad.Text <> "" Then
                Dim cantidad As Integer = txtexistencia.Text
                Dim exis As Integer = existencia
                If txtcantidad.Text <= 12 Then
                    txtprecio.Text = docena
                    txtsubtotal.Text = txtcantidad.Text * docena
                    btninsertarfila.Enabled = True
                    btnmodificarfila.Enabled = True
                    btneliminarfila.Enabled = True
                ElseIf txtcantidad.Text <= 25 And txtexistencia.Text >= 13 Then
                    txtprecio.Text = mediofardo
                    txtsubtotal.Text = txtcantidad.Text * mediofardo
                    btninsertarfila.Enabled = True
                    btnmodificarfila.Enabled = True
                    btneliminarfila.Enabled = True
                ElseIf txtcantidad.Text <= 50 And txtexistencia.Text >= 26 Then
                    txtprecio.Text = fardo
                    txtsubtotal.Text = txtcantidad.Text * fardo
                    btninsertarfila.Enabled = True
                    btnmodificarfila.Enabled = True
                    btneliminarfila.Enabled = True
                End If
            End If
        Else
            btninsertarfila.Enabled = False
            Exit Sub
            MsgBox("la cantidad es superior a las existencias")
        End If
    End Sub

    Private Sub Txt_producto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_producto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select * from productos where Id_producto = '" & txt_producto.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "productos")
                lista = datos.Tables("productos").Rows.Count
                If lista <> 0 Then
                    txtproducto.Text = datos.Tables("productos").Rows(0).Item("producto")
                    txtexistencia.Text = datos.Tables("productos").Rows(0).Item("existencias")
                    liquidacion = datos.Tables("productos").Rows(0).Item("prec_liquidacion")
                    fardo = datos.Tables("productos").Rows(0).Item("pre_fardo")
                    mediofardo = datos.Tables("productos").Rows(0).Item("prec_unmedio_fardo")
                    docena = datos.Tables("productos").Rows(0).Item("prec_Docena_Fardo")
                    con.Close()
                    txtcantidad.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtnopedido.Text <> "" And txtserie.Text <> "" Then
            sentencia = "delete from facturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
            mensaje = "se ha eliminado"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
            mostrar2()
        Else
            MsgBox("El campo del numero de el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtnopedido.Text <> "" AndAlso txtserie.Text <> "" Then
            mostrar()
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtnopedido.Text <> "" AndAlso txtserie.Text <> "" Then
            sentencia = "update facturasventa set Id_Documento='" + txtnopedido.Text + "',Serie='" + txtserie.Text + "',Id_Cliente='" + txtidcliente.Text + "',Direccion='" + txtdireccion.Text + "',NoNit='" + txtnonit.Text + "',Id_Municipio='" + txtidmunicipio.Text + "',NoPedido='" + txtnopedido.Text + "',IdRuta='" + txtrutacliente.Text + "',Observaciones='" + txtobservaciones.Text + "',Diascredito='" + txtdiascredito.Text + "',limitecredito='" + txtlimitecredito.Text + "',fechavenci='" + txtfechavencimiento.Text + "',cobroxenvio='" + txtcobroporenvio.Text + "',id_departamento='" + txtidepartamento.Text + "',id_subruta='" + txtsubrutacliente.Text + "',telefonos='" + txttelefonos.Text + "',anulado='" + anulado + "',credito='" + credito + "',id_vendedor='" + txtidvendedor.Text + "',fecha='" + txtfecha.Text + "',total='" + txttotal.Text + +"' where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
            mensaje = "datos actualizados"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtnopedido.Text <> "" AndAlso txtserie.Text <> "" AndAlso txtidcliente.Text <> "" AndAlso txtidmunicipio.Text <> "" AndAlso txtidepartamento.Text <> "" AndAlso txttotal.Text <> "" AndAlso txtidvendedor.Text <> "" AndAlso txtrutacliente.Text <> "" AndAlso txtsubrutacliente.Text <> "" Then
            If chkbanulada.Checked = True Then
                anulado = "1"
            Else
                anulado = "0"
            End If
            If chkncredito.Checked = True Then
                credito = "1"
            Else
                credito = "0"
            End If
            sentencia = "insert into facturasventa values('" + txtnopedido.Text + "','" + txtserie.Text + "','" + txtidcliente.Text + "','" + txtdireccion.Text + "','" + txtnonit.Text + "','" + txtidmunicipio.Text + "','" + txtnopedido.Text + "','" + txtrutacliente.Text + "','" + txtobservaciones.Text + "','" + txtdiascredito.Text + "','" + txtlimitecredito.Text + "','" + txtfechavencimiento.Text + "','" + txtcobroporenvio.Text + "','" + txtidepartamento.Text + "','" + txtsubrutacliente.Text + "','" + txttelefonos.Text + "','" + anulado + "','" + credito + "','" + txtidvendedor.Text + "','" + txtfecha.Text + "','" + txttotal.Text.Replace(",", ".") + "')"
            mensaje = "se ha agregado la cotizacion, puede visualizarla dando click en reporte"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            mostrar2()
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        End If
    End Sub
    Private Sub Btneliminarfila_Click(sender As Object, e As EventArgs) Handles btneliminarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "defacturasventa")
            lista = datos.Tables("defacturasventa").Rows.Count
            If lista <> 0 Then
                eliminar = datos.Tables("defacturasventa").Rows(0).Item("cantidad")
                sentencia6 = "delete from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "' and id_producto='" + txt_producto.Text + "'"
                mensaje = "fila eliminada correctamente"
                con.Close()
                restaurar()
                con.Close()
                ejecutarSQL(sentencia6, mensaje)
                con.Close()
                recuperartotal()
                mostrar2()
                txt_producto.Text = ""
                txtproducto.Text = ""
                txt_producto.Text = ""
                txtproducto.Text = ""
                txtcantidad.Text = ""
                txtprecio.Text = ""
                txtsubtotal.Text = ""
                txtexistencia.Text = ""
                btninsertarfila.Enabled = False
                btnmodificarfila.Enabled = False
                btneliminarfila.Enabled = False
            End If
        Catch
            con.Close()
        End Try
    End Sub

    Private Sub Btnmodificarfila_Click(sender As Object, e As EventArgs) Handles btnmodificarfila.Click
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "defacturasventa")
            lista = datos.Tables("defacturasventa").Rows.Count
            If lista <> 0 Then
                detalle = datos.Tables("defacturasventa").Rows(0).Item("SUMA")
            End If
            If txt_producto.Text <> "" Then
                con.Close()
                con.Open()
                sentencia = "update defacturasventa set Id_Documento='" + txtfacturano.Text + "',serie='" + txtserie.Text + "',NoPedido='" + txtnopedido.Text + "',Id_Producto='" + txt_producto.Text + "',cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
                con.Close()
                mensaje = "Datos actualizados correctamente"
                ejecutarSQL(sentencia, mensaje)
                mostrar()
                con.Close()
                sumaorestaexistencia()
                recuperartotal()
                con.Close()
                txt_producto.Text = ""
                txtproducto.Text = ""
                txt_producto.Text = ""
                txtproducto.Text = ""
                txtcantidad.Text = ""
                txtprecio.Text = ""
                txtsubtotal.Text = ""
                txtexistencia.Text = ""
                btninsertarfila.Enabled = False
                btnmodificarfila.Enabled = False
                btneliminarfila.Enabled = False
            End If
        Catch
        End Try
    End Sub

    Dim nuevovalor, nuevoproducto, detalle, base, cantidad, nuevoproducto2, nuevovalor2, exis, eliminar, totaleli As Integer
    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
    Private Sub Btninsertarfila_Click(sender As Object, e As EventArgs) Handles btninsertarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "defacturasventa")
            lista = datos.Tables("defacturasventa").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim Consulta2 As String = "select Sum(cantidad) AS SUMA from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "defacturasventa")
                lista2 = datos2.Tables("defacturasventa").Rows.Count
                If lista2 <> 0 Then
                    detalle = datos2.Tables("defacturasventa").Rows(0).Item("SUMA")
                    sentencia5 = "update defacturasventa set Id_Documento='" + txtfacturano.Text + "',serie='" + txtserie.Text + "',NoPedido='" + txtnopedido.Text + "',Id_Producto='" + txt_producto.Text + "',cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
                    con.Close()
                    ejecutarSQL2(sentencia5)
                    mostrar()
                    con.Close()
                    sumaorestaexistencia()
                    recuperartotal()
                    con.Close()
                    txt_producto.Text = ""
                    txtproducto.Text = ""
                    txtcantidad.Text = ""
                    txtprecio.Text = ""
                    txtsubtotal.Text = ""
                    txtexistencia.Text = ""
                    btninsertarfila.Enabled = False
                    btnmodificarfila.Enabled = False
                    btneliminarfila.Enabled = False
                End If
            Else
                Dim a, b As Integer
                a = txtcantidad.Text
                b = txtexistencia.Text
                If a <= b Then
                    If txt_producto.Text <> "" Then
                        con.Close()
                        con.Open()
                        sentencia = "insert into defacturasventa values('" + txtfacturano.Text + "','" + txtserie.Text + "','" + txtnopedido.Text + "','" + txt_producto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text.Replace(",", ".") + "','" + txtsubtotal.Text.Replace(",", ".") + "')"
                        con.Close()
                        mensaje = "Datos insertados correctamente"
                        ejecutarSQL(sentencia, mensaje)
                        mostrar()
                        con.Close()
                        recuperartotal()
                        con.Close()
                        restaexistencia()
                        txt_producto.Text = ""
                        txtproducto.Text = ""
                        txt_producto.Text = ""
                        txtproducto.Text = ""
                        txtcantidad.Text = ""
                        txtprecio.Text = ""
                        txtsubtotal.Text = ""
                        txtexistencia.Text = ""
                        btninsertarfila.Enabled = False
                        btnmodificarfila.Enabled = False
                        btneliminarfila.Enabled = False
                    Else
                        MsgBox("no se puede insertar un producto con mayor cantidad a las existencias")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Public Sub restaurar()
        base = txtexistencia.Text
        totaleli = eliminar + base
        Dim xd As String = totaleli
        sentencia4 = "update productos set existencias='" + xd + "' where id_producto='" + txt_producto.Text + "'"
        ejecutarSQL2(sentencia4)
    End Sub
    Sub recuperartotal()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(totaldet) AS SUMA from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "defacturasventa")
            lista = datos.Tables("defacturasventa").Rows.Count
            If lista <> 0 Then
                txttotal.Text = datos.Tables("defacturasventa").Rows(0).Item("SUMA")
                con.Close()
            Else
                con.Close()
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub restaexistencia()
        Try
            resta = txtexistencia.Text - txtcantidad.Text
            con.Close()
            sentencia2 = "update productos set existencias='" + resta + "' where id_producto='" + txt_producto.Text + "'"
            ejecutarSQL2(sentencia2)
        Catch ex As Exception

        End Try
    End Sub
    Sub sumaorestaexistencia()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "defacturasventa")
            lista = datos.Tables("defacturasventa").Rows.Count
            If lista <> 0 Then
                'detalle = datos.Tables("detallecotizaciones").Rows(0).Item("SUMA")
                base = txtexistencia.Text
                If txtcantidad.Text > detalle Then
                    nuevovalor = txtcantidad.Text - detalle
                    nuevoproducto = base - nuevovalor
                    con.Close()
                    Dim nuevo As String = nuevoproducto
                    sentencia4 = "update productos set existencias='" + nuevo + "' where id_producto='" + txt_producto.Text + "'"
                    ejecutarSQL2(sentencia4)
                ElseIf txtcantidad.Text < detalle Then
                    nuevovalor2 = detalle - txtcantidad.Text
                    nuevoproducto2 = base + nuevovalor2
                    con.Close()
                    Dim nuevo As String = nuevoproducto2
                    sentencia3 = "update productos set existencias='" + nuevo + "' where id_producto='" + txt_producto.Text + "'"
                    ejecutarSQL2(sentencia3)
                End If

                con.Close()
            Else
                con.Close()
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub mostrar2()
        Dim Dap As New SqlDataAdapter("select * from defacturasventa", con)
        Dim ds As New DataSet
        Try
            Dap.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Sub mostrar()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "defacturasventa")
            lista = datos.Tables("defacturasventa").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                recuperar_total()
                dt.DefaultView.RowFilter = "Id_Documento like '" + txtfacturano.Text + "%' and serie like '" + txtserie.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe el envio con el id de documento: " + txtfacturano.Text + " , y la serie: " + txtserie.Text + ", verifique e intente de nuevo o cree una nueva de ser necesario")
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Public Sub recuperar_total()
        con.Close()
        Dim Consulta1 As String = "select Sum(totaldet) AS SUMA from defacturasventa where Id_Documento='" + txtfacturano.Text + "' and serie='" + txtserie.Text + "' and NoPedido='" + txtnopedido.Text + "'"
        Dim lista1 As Byte
        Dim datos1 As New DataSet
        Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
        datos1 = New DataSet
        adaptador1.Fill(datos1, "defacturasventa")
        lista1 = datos1.Tables("defacturasventa").Rows.Count
        If lista1 <> 0 Then
            txttotal.Text = datos1.Tables("defacturasventa").Rows(0).Item("SUMA")
        End If
    End Sub

    Sub ejecutarSQL(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Sub ejecutarSQL2(sql As String)
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
    Public Sub Limpiar_TextBox(ByVal formulario As Form)
        'Recorremos todos los controles del formulario que enviamos  
        For Each control As Control In formulario.Controls
            'Filtramos solo aquellos de tipo TextBox 
            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto  
            End If
        Next
    End Sub
End Class