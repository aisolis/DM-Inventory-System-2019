Imports System.Data.SqlClient
Public Class Notas_de_credito
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

    Private Sub Txtnotadecredito_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnotadecredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdocumento.Select()
        End If
    End Sub

    Private Sub Txtdocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdocumento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserie.Select()
        End If
    End Sub

    Private Sub Txtserie_KeyDown(sender As Object, e As KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtidcliente.Select()
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

    Private Sub Txtidsubruta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidsubruta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from subruta where Id_subruta = '" & txtidsubruta.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "subruta")
                lista = datos.Tables("subruta").Rows.Count
                If lista <> 0 Then
                    txtsubruta.Text = datos.Tables("subruta").Rows(0).Item("subruta")
                    con.Close()
                    txt_producto.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtidruta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidruta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from ruta where id_ruta = '" & txtidruta.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "ruta")
                lista = datos.Tables("ruta").Rows.Count
                If lista <> 0 Then
                    txtruta.Text = datos.Tables("ruta").Rows(0).Item("ruta")
                    con.Close()
                    txtidsubruta.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtdepto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdepto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from departamento where Id_departamento = '" & txtdepto.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "departamento")
                lista = datos.Tables("departamento").Rows.Count
                If lista <> 0 Then
                    txtndepto.Text = datos.Tables("departamento").Rows(0).Item("departamento")
                    con.Close()
                    txtidruta.Select()
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
                Dim Consulta As String = "Select * from municipio where Id_municipio = '" & txtidmunicipio.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "municipio")
                lista = datos.Tables("municipio").Rows.Count
                If lista <> 0 Then
                    txtnmunicipio.Text = datos.Tables("municipio").Rows(0).Item("municipio")
                    con.Close()
                    txtdepto.Select()
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
                Dim Consulta As String = "Select * from vendedor where Id_vendedor = '" & txtidvendedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "vendedor")
                lista = datos.Tables("vendedor").Rows.Count
                If lista <> 0 Then
                    txtvendedor.Text = datos.Tables("vendedor").Rows(0).Item("vendedor")
                    con.Close()
                    txtidmunicipio.Select()
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
                    txtidvendedor.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtnotadecredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnotadecredito.KeyPress, txtserie.KeyPress, txtidvendedor.KeyPress, txtidsubruta.KeyPress, txtidruta.KeyPress, txtidmunicipio.KeyPress, txtidcliente.KeyPress, txtdocumento.KeyPress, txtdepto.KeyPress, txtcantidad.KeyPress, txt_producto.KeyPress
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

    Private Sub Btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtnotadecredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" Then
            sentencia = "delete from NotascreditoClientes where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
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
        If txtnotadecredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" Then
            mostrar()
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtnotadecredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" Then
            sentencia = "update NotascreditoClientes set notadecredito='" + txtnotadecredito.Text + "',Serie='" + txtserie.Text + "',IdDocumento='" + txtdocumento.Text + "',Id_Cliente='" + txtidcliente.Text + "',fecha='" + txtfecha.Text + "',Id_Vendedor='" + txtidvendedor.Text + "',Id_Municipio='" + txtidmunicipio.Text + "',Id_ruta='" + txtruta.Text + "',id_departamento='" + txtdepto.Text + "',Id_SubRuta='" + txtsubruta.Text + "',TotalGeneral='" + txttotal.Text.Replace(",", ".") + "',direccion='" + txtdireccion.Text + "',No_Nit='" + txtnonit.Text + "' where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
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
        If txtnotadecredito.Text <> "" AndAlso txtdocumento.Text <> "" AndAlso txtserie.Text <> "" AndAlso txtidcliente.Text <> "" AndAlso txtidvendedor.Text <> "" AndAlso txtidmunicipio.Text <> "" AndAlso txtidsubruta.Text <> "" AndAlso txtruta.Text <> "" AndAlso txtfecha.Text <> "" Then
            sentencia = "insert into NotascreditoClientes values('" + txtnotadecredito.Text + "','" + txtserie.Text + "','" + txtdocumento.Text + "','" + txtidcliente.Text + "','" + txtfecha.Text + "','" + txtidvendedor.Text + "','" + txtidmunicipio.Text + "','" + txtidruta.Text + "','" + txtdepto.Text + "','" + txtidsubruta.Text + "','" + txttotal.Text.Replace(",", ".") + "','" + txtdireccion.Text + "','" + txtnonit.Text + "')"
            mensaje = "se ha agregado la cotizacion, puede visualizarla dando click en reporte"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        End If
    End Sub

    Private Sub Btneliminarfila_Click(sender As Object, e As EventArgs) Handles btneliminarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            Dim datos As New DataSet
            Dim lista As Byte
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoCliente")
            lista = datos.Tables("DetNotascreditoCliente").Rows.Count
            If lista <> 0 Then
                eliminar = datos.Tables("DetNotascreditoCliente").Rows(0).Item("cantidad")
                sentencia6 = "delete from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoCliente")
            lista = datos.Tables("DetNotascreditoCliente").Rows.Count
            If lista <> 0 Then
                detalle = datos.Tables("DetNotascreditoCliente").Rows(0).Item("SUMA")
            End If
            If txt_producto.Text <> "" Then
                con.Close()
                con.Open()
                sentencia = "update DetNotascreditoCliente set notadecredito='" + txtnotadecredito.Text + "',Serie='" + txtserie.Text + "',IdDocumento='" + txtdocumento.Text + "',IdCliente='" + txtidcliente.Text + "', Id_Producto='" + txt_producto.Text + "', cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
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
            con.Close()
        End Try
    End Sub

    Private Sub Btninsertarfila_Click(sender As Object, e As EventArgs) Handles btninsertarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoCliente")
            lista = datos.Tables("DetNotascreditoCliente").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim Consulta2 As String = "select Sum(cantidad) AS SUMA from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "DetNotascreditoCliente")
                lista2 = datos2.Tables("DetNotascreditoCliente").Rows.Count
                If lista2 <> 0 Then
                    detalle = datos2.Tables("DetNotascreditoCliente").Rows(0).Item("SUMA")
                    sentencia5 = "update DetNotascreditoCliente set notadecredito='" + txtnotadecredito.Text + "',Serie='" + txtserie.Text + "',IdDocumento='" + txtdocumento.Text + "',IdCliente='" + txtidcliente.Text + "', Id_Producto='" + txt_producto.Text + "', cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
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
                    sentencia = "insert into DetNotascreditoCliente values('" + txtnotadecredito.Text + "','" + txtserie.Text + "','" + txtdocumento.Text + "','" + txtidcliente.Text + "','" + txt_producto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text.Replace(",", ".") + "','" + txtsubtotal.Text.Replace(",", ".") + "')"
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
    Private Sub btncancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Notas_de_credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
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
            Dim Consulta As String = "Select * from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoCliente")
            lista = datos.Tables("DetNotascreditoCliente").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                gridfacturacion.DataSource = dt
                recuperar_total()
                dt.DefaultView.RowFilter = "notadecredito like '" + txtnotadecredito.Text + "%' and IdDocumento like '" + txtdocumento.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe una nota de credito con el No.: " + txtnotadecredito.Text + " , y Documento: " + txtdocumento.Text + ", verifique e intente de nuevo o cree una nueva de ser necesario")
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub mostrar2()
        Dim Dap As New SqlDataAdapter("select * from DetNotascreditoCliente", con)
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
        Dim Consulta1 As String = "select Sum(totaldet) AS SUMA from DetNotascreditoCliente where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
        Dim lista1 As Byte
        Dim datos1 As New DataSet
        Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
        datos1 = New DataSet
        adaptador1.Fill(datos1, "DetNotascreditoCliente")
        lista1 = datos1.Tables("DetNotascreditoCliente").Rows.Count
        If lista1 <> 0 Then
            txttotal.Text = datos1.Tables("DetNotascreditoCliente").Rows(0).Item("SUMA")
        End If
    End Sub
    Sub recuperartotal()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(totaldet) AS SUMA from DetNotascreditoClientes where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoClientes")
            lista = datos.Tables("DetNotascreditoClientes").Rows.Count
            If lista <> 0 Then
                txttotal.Text = datos.Tables("DetNotascreditoClientes").Rows(0).Item("SUMA")
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from DetNotascreditoClientes where notadecredito='" + txtnotadecredito.Text + "' and IdDocumento='" + txtdocumento.Text + "' and serie='" + txtserie.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "DetNotascreditoClientes")
            lista = datos.Tables("DetNotascreditoClientes").Rows.Count
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