Imports System.Data.SqlClient
Public Class Notas_de_credito_proveedores
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim nuevovalor, nuevoproducto, detalle, base, cantidad, nuevoproducto2, nuevovalor2, exis, eliminar, totaleli As Integer
    Dim mensaje, sentencia, tvip, bloqueo, avisosalida, liquidacion, docena, fardo, mediofardo, existencia, total, resta, resta2, sentencia2, valordetalle, sentencia3, sentencia4, sentencia5, sentencia6, sentencia7 As String

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

    Private Sub Txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_producto.Select()
        End If
    End Sub

    Private Sub Txtdocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdocumento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserie.Select()
        End If
    End Sub

    Private Sub Txtnotacredito_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnotacredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdocumento.Select()
        End If
    End Sub

    Private Sub Txtsaldo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsaldo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnotacredito.Select()
        End If
    End Sub

    Private Sub Txtidproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidproveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from proveedor where id_proveedor = '" & txtidproveedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "proveedor")
                lista = datos.Tables("proveedor").Rows.Count
                If lista <> 0 Then
                    txtproveedor.Text = datos.Tables("proveedor").Rows(0).Item("proveedor")
                    con.Close()
                    txtidcliente.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

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
                    txtcliente.Text = datos.Tables("tabla_clientes").Rows(0).Item("cliente")
                    txtnonit.Text = datos.Tables("tabla_clientes").Rows(0).Item("nit")
                    txtdireccion.Text = datos.Tables("tabla_clientes").Rows(0).Item("direccion")
                    con.Close()
                    txtsaldo.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtidproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidproveedor.KeyPress, txtsaldo.KeyPress, txtnotacredito.KeyPress, txtidcliente.KeyPress, txtdocumento.KeyPress, txtcantidad.KeyPress, txtaño.KeyPress, txt_producto.KeyPress
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

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtnotacredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" Then
            sentencia = "delete from NotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            mensaje = "se ha eliminado"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
            txtaño.Text = DateTime.Now.ToString("yyyy")

            mostrar2()
        Else
            MsgBox("El campo del numero de el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtnotacredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" Then
            mostrar()
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
            txtaño.Text = DateTime.Now.ToString("yyyy")

        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtnotacredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" Then
            sentencia = "update NotascreditoProveedores set Id_Proveedor='" + txtidproveedor.Text + "',IdDocumento='" + txtdocumento.Text + "',serie='" + txtserie.Text + "',Id_Cliente='" + txtidcliente.Text + "',fecha='" + txtfecha.Text + "',año='" + txtaño.Text + "',saldo='" + txtsaldo.Text + "',No_Nit='" + txtnonit.Text + "',notadecredito='" + txtnotacredito.Text + "',direccion='" + txtdireccion.Text + "',total='" + txttotal.Text.Replace(",", ".") + "' where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            mensaje = "datos actualizados"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
            txtaño.Text = DateTime.Now.ToString("yyyy")

        Else
            MsgBox("El campo del numero o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtnotacredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" AndAlso txtidcliente.Text <> "" AndAlso txtdireccion.Text <> "" AndAlso txtidproveedor.Text <> "" AndAlso txtaño.Text <> "" AndAlso txtsaldo.Text <> "" AndAlso txtfecha.Text <> "" Then
            sentencia = "insert into NotascreditoProveedores values('" + txtidproveedor.Text + "','" + txtdocumento.Text + "','" + txtserie.Text + "','" + txtidcliente.Text + "','" + txtfecha.Text + "','" + txtaño.Text + "','" + txtsaldo.Text + "','" + txtnonit.Text + "','" + txtnotacredito.Text + "','" + txtdireccion.Text + "','" + txttotal.Text.Replace(",", ".") + "')"
            mensaje = "se ha agregado la cotizacion, puede visualizarla dando click en reporte"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
            txtaño.Text = DateTime.Now.ToString("yyyy")

        End If
    End Sub

    Private Sub Btneliminarfila_Click(sender As Object, e As EventArgs) Handles btneliminarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            Dim datos As New DataSet
            Dim lista As Byte
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoProveedores")
            lista = datos.Tables("DetNotascreditoProveedores").Rows.Count
            If lista <> 0 Then
                eliminar = datos.Tables("DetNotascreditoProveedores").Rows(0).Item("cantidad")
                sentencia6 = "delete from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
                mensaje = "fila eliminada correctamente"
                con.Close()
                'restaurar()
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoProveedores")
            lista = datos.Tables("DetNotascreditoProveedores").Rows.Count
            If lista <> 0 Then
                detalle = datos.Tables("DetNotascreditoProveedores").Rows(0).Item("SUMA")
            End If
            If txt_producto.Text <> "" Then
                con.Close()
                con.Open()
                sentencia = "update DetNotascreditoProveedores set notadecredito='" + txtnotacredito.Text + "',Serie='" + txtserie.Text + "',Id_Proveedor='" + txtidproveedor.Text + "',IdDocumento='" + txtdocumento.Text + "', Id_Cliente='" + txtidcliente.Text + "', id_producto='" + txt_producto.Text + "', cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
                con.Close()
                mensaje = "Datos actualizados correctamente"
                ejecutarSQL(sentencia, mensaje)
                mostrar()
                con.Close()
                'sumaorestaexistencia()
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

    Private Sub Btninsertarfila_Click(sender As Object, e As EventArgs) Handles btninsertarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoProveedores")
            lista = datos.Tables("DetNotascreditoProveedores").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim Consulta2 As String = "select Sum(cantidad) AS SUMA from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "DetNotascreditoProveedores")
                lista2 = datos2.Tables("DetNotascreditoProveedores").Rows.Count
                If lista2 <> 0 Then
                    detalle = datos2.Tables("DetNotascreditoProveedores").Rows(0).Item("SUMA")
                    sentencia5 = "update DetNotascreditoProveedores set notadecredito='" + txtnotacredito.Text + "',Serie='" + txtserie.Text + "',Id_Proveedor='" + txtidproveedor.Text + "',IdDocumento='" + txtdocumento.Text + "', Id_Cliente='" + txtidcliente.Text + "', id_producto='" + txt_producto.Text + "', cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
                    con.Close()
                    ejecutarSQL2(sentencia5)
                    mostrar()
                    con.Close()
                    'sumaorestaexistencia()
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
                '  If a <= b Then
                If txt_producto.Text <> "" Then
                    con.Close()
                    con.Open()
                    sentencia = "insert into DetNotascreditoProveedores values('" + txtnotacredito.Text + "','" + txtserie.Text + "','" + txtidproveedor.Text + "','" + txtdocumento.Text + "','" + txtidcliente.Text + "','" + txt_producto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text.Replace(",", ".") + "','" + txtsubtotal.Text.Replace(",", ".") + "')"
                    con.Close()
                    mensaje = "Datos insertados correctamente"
                    ejecutarSQL(sentencia, mensaje)
                    mostrar()
                    con.Close()
                    recuperartotal()
                    con.Close()
                    'restaexistencia()
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
                ' End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Notas_de_credito_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtaño.Text = DateTime.Now.ToString("yyyy")
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
    Sub mostrar()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoProveedores")
            lista = datos.Tables("DetNotascreditoProveedores").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                gridfacturacion.DataSource = dt
                recuperar_total()
                dt.DefaultView.RowFilter = "notadecredito like '" + txtnotacredito.Text + "%' and IdDocumento like '" + txtdocumento.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe una nota de credito con el No.: " + txtnotacredito.Text + " , y Documento: " + txtdocumento.Text + ", verifique e intente de nuevo o cree una nueva de ser necesario")
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub mostrar2()
        Dim Dap As New SqlDataAdapter("select * from DetNotascreditoProveedores", con)
        Dim ds As New DataSet
        Try
            Dap.Fill(ds)
            gridfacturacion.DataSource = ds.Tables(0)
            con.Close()
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
    Public Sub recuperar_total()
        con.Close()
        Dim Consulta1 As String = "select Sum(totaldet) AS SUMA from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
        Dim lista1 As Byte
        Dim datos1 As New DataSet
        Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
        datos1 = New DataSet
        adaptador1.Fill(datos1, "DetNotascreditoProveedores")
        lista1 = datos1.Tables("DetNotascreditoProveedores").Rows.Count
        If lista1 <> 0 Then
            txttotal.Text = datos1.Tables("DetNotascreditoProveedores").Rows(0).Item("SUMA")
        End If
    End Sub
    Sub recuperartotal()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(totaldet) AS SUMA from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoProveedores")
            lista = datos.Tables("DetNotascreditoProveedores").Rows.Count
            If lista <> 0 Then
                txttotal.Text = datos.Tables("DetNotascreditoProveedores").Rows(0).Item("SUMA")
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from DetNotascreditoProveedores where notadecredito='" + txtnotacredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoProveedores")
            lista = datos.Tables("DetNotascreditoProveedores").Rows.Count
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
End Class