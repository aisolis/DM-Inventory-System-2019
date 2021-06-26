Imports System.Data.SqlClient
Public Class Documentos_de_compra
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, tvip, bloqueo, avisosalida, liquidacion, docena, fardo, mediofardo, existencia, total, resta, resta2, sentencia2, valordetalle, sentencia3, sentencia4, sentencia5, sentencia6, sentencia7 As String

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If chkbcredito.Checked = True Then
            bloqueo = "1"
        Else
            bloqueo = "0"
        End If
        If txtcompra.Text <> "" AndAlso txtseriecompra.Text <> "" AndAlso txtnit.Text <> "" AndAlso txtproveedor.Text <> "" AndAlso txtfecha.Text <> "" AndAlso txttotal.Text <> "" Then
            sentencia = "insert into facturaCompra values('" + txtcompra.Text + "','" + txtseriecompra.Text + "','" + txtproveedor.Text + "','" + bloqueo + "','" + txtdireccion.Text + "','" + txtnit.Text + "','" + txtfecha.Text + "','" + txttotal.Text.Replace(",", ".") + "')"
            mensaje = "se ha agregado la cotizacion, puede visualizarla dando click en reporte"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        End If
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If chkbcredito.Checked = True Then
            bloqueo = "1"
        Else
            bloqueo = "0"
        End If
        If txtcompra.Text <> "" AndAlso txtseriecompra.Text <> "" AndAlso txtproveedor.Text <> "" Then
            sentencia = "update facturaCompra set id_documento='" + txtcompra.Text + "',serie='" + txtseriecompra.Text + "',id_proveedor='" + txtproveedor.Text + "',credito='" + bloqueo + "',direccion='" + txtdireccion.Text + "',nit='" + txtnit.Text + "',fecha='" + txtfecha.Text + "',total='" + txttotal.Text.Replace(",", ".") + "' where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            mensaje = "datos actualizados"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtcompra.Text <> "" AndAlso txtseriecompra.Text <> "" And txtproveedor.Text <> "" Then
            mostrar()
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtcompra.Text <> "" AndAlso txtseriecompra.Text <> "" And txtproveedor.Text <> "" Then
            sentencia = "delete from facturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            mensaje = "se ha eliminado"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
            mostrar2()
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Txtproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproveedor.KeyPress, txtcompra.KeyPress, txtcantidad.KeyPress, txt_producto.KeyPress
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
                    btnactualizarfila.Enabled = True
                    btneliminarfila.Enabled = True
                ElseIf txtcantidad.Text <= 25 And txtexistencia.Text >= 13 Then
                    txtprecio.Text = mediofardo
                    txtsubtotal.Text = txtcantidad.Text * mediofardo
                    btninsertarfila.Enabled = True
                    btnactualizarfila.Enabled = True
                    btneliminarfila.Enabled = True
                ElseIf txtcantidad.Text <= 50 And txtexistencia.Text >= 26 Then
                    txtprecio.Text = fardo
                    txtsubtotal.Text = txtcantidad.Text * fardo
                    btninsertarfila.Enabled = True
                    btnactualizarfila.Enabled = True
                    btneliminarfila.Enabled = True
                End If
            End If
        Else
            btninsertarfila.Enabled = False
            Exit Sub
            MsgBox("la cantidad es superior a las existencias")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        mostrar()
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

    Private Sub Txtseriecompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtseriecompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_producto.Select()
        End If
    End Sub

    Private Sub Txtcompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtseriecompra.Select()
        End If
    End Sub

    Dim nuevovalor, nuevoproducto, detalle, base, cantidad, nuevoproducto2, nuevovalor2, exis, eliminar, totaleli As Integer
    Private Sub Txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from proveedor where Id_proveedor = '" & txtproveedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "proveedor")
                lista = datos.Tables("proveedor").Rows.Count
                If lista <> 0 Then
                    txtnombreprov.Text = datos.Tables("proveedor").Rows(0).Item("proveedor")
                    txtnit.Text = datos.Tables("proveedor").Rows(0).Item("nit")
                    txtdireccion.Text = datos.Tables("proveedor").Rows(0).Item("direccion")
                    con.Close()
                    txtcompra.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
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
    Sub mostrar()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from facturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detfacturaCompra")
            lista = datos.Tables("detfacturaCompra").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                griddocumentoscompra.DataSource = dt
                recuperar_total()
                dt.DefaultView.RowFilter = "id_documento like '" + txtcompra.Text + "%' and serie like '" + txtseriecompra.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe la factura con el documento: " + txtcompra.Text + " , y con serie: " + txtseriecompra.Text + ", verifique e intente de nuevo o cree una nueva de ser necesario")
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub mostrar2()
        Dim Dap As New SqlDataAdapter("select * from detfacturaCompra", con)
        Dim ds As New DataSet
        Try
            Dap.Fill(ds)
            griddocumentoscompra.DataSource = ds.Tables(0)
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
        Dim Consulta1 As String = "select Sum(totaldet) AS SUMA from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
        Dim lista1 As Byte
        Dim datos1 As New DataSet
        Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
        datos1 = New DataSet
        adaptador1.Fill(datos1, "detfacturaCompra")
        lista1 = datos1.Tables("detfacturaCompra").Rows.Count
        If lista1 <> 0 Then
            txttotal.Text = datos1.Tables("detfacturaCompra").Rows(0).Item("SUMA")
        End If
    End Sub
    Sub recuperartotal()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(totaldet) AS SUMA from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detfacturaCompra")
            lista = datos.Tables("detfacturaCompra").Rows.Count
            If lista <> 0 Then
                txttotal.Text = datos.Tables("detfacturaCompra").Rows(0).Item("SUMA")
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detfacturaCompra")
            lista = datos.Tables("detfacturaCompra").Rows.Count
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
    Private Sub Btninsertarfila_Click(sender As Object, e As EventArgs) Handles btninsertarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detfacturaCompra")
            lista = datos.Tables("detfacturaCompra").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim Consulta2 As String = "select Sum(cantidad) AS SUMA from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "detfacturaCompra")
                lista2 = datos2.Tables("detfacturaCompra").Rows.Count
                If lista2 <> 0 Then
                    detalle = datos2.Tables("detfacturaCompra").Rows(0).Item("SUMA")
                    sentencia5 = "update detfacturaCompra set id_documento='" + txtcompra.Text + "',serie='" + txtseriecompra.Text + "',id_proveedor='" + txtproveedor.Text + "',id_producto='" + txt_producto.Text + "',cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where Id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
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
                    btnactualizarfila.Enabled = False
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
                        sentencia = "insert into detfacturaCompra values('" + txtcompra.Text + "','" + txtseriecompra.Text + "','" + txtproveedor.Text + "','" + txt_producto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text.Replace(",", ".") + "','" + txtsubtotal.Text.Replace(",", ".") + "')"
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
                        btnactualizarfila.Enabled = False
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
    Private Sub Btnactualizarfila_Click(sender As Object, e As EventArgs) Handles btnactualizarfila.Click
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detfacturaCompra")
            lista = datos.Tables("detfacturaCompra").Rows.Count
            If lista <> 0 Then
                detalle = datos.Tables("detfacturaCompra").Rows(0).Item("SUMA")
            End If
            If txt_producto.Text <> "" Then
                con.Close()
                con.Open()
                sentencia = "update detfacturaCompra set id_documento='" + txtcompra.Text + "',serie='" + txtseriecompra.Text + "',id_proveedor='" + txtproveedor.Text + "',id_producto='" + txt_producto.Text + "',cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where Id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
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
                btnactualizarfila.Enabled = False
                btneliminarfila.Enabled = False
            End If
        Catch
        End Try
    End Sub
    Private Sub Btneliminarfila_Click(sender As Object, e As EventArgs) Handles btneliminarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detfacturaCompra")
            lista = datos.Tables("detfacturaCompra").Rows.Count
            If lista <> 0 Then
                eliminar = datos.Tables("detfacturaCompra").Rows(0).Item("cantidad")
                sentencia6 = "delete from detfacturaCompra where id_documento='" + txtcompra.Text + "' and serie='" + txtseriecompra.Text + "' and id_proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
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
                btnactualizarfila.Enabled = False
                btneliminarfila.Enabled = False
            End If
        Catch
            con.Close()
        End Try
    End Sub
    Private Sub Documentos_de_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
End Class