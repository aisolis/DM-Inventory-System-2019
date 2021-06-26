Imports System.Data.SqlClient
Public Class Envios_de_entrada
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, tvip, bloqueo, avisosalida, liquidacion, docena, fardo, mediofardo, existencia, total, resta, resta2, sentencia2, valordetalle, sentencia3, sentencia4, sentencia5, sentencia6, sentencia7 As String
    Dim nuevovalor, nuevoproducto, detalle, base, cantidad, nuevoproducto2, nuevovalor2, exis, eliminar, totaleli As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        mostrar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If envio.Text <> "" AndAlso txtproveedor.Text <> "" Then
            sentencia = "update envioentrada set id_envio='" + envio.Text + "',id_proveedor='" + txtproveedor.Text + "',fecha='" + txtfecha.Text + "',observaciones='" + txtobser.Text + "',No_nit='" + txtnit.Text + "',DoctoReclamo='" + docto.Text + "',valor='" + txtvalor.Text + "',direccion='" + txtdireccion.Text + "',totalenvio='" + txttotal.Text.Replace(",", ".") + "' where id_envio='" + envio.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            mensaje = "datos actualizados"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If envio.Text <> "" AndAlso txtproveedor.Text <> "" Then
            mostrar()
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If envio.Text <> "" And txtproveedor.Text <> "" Then
            sentencia = "delete from envioentrada where id_envio='" + envio.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
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

    Private Sub Txtproveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproveedor.KeyPress, txtvalor.KeyPress, txtcantidad.KeyPress, txt_producto.KeyPress, envio.KeyPress, docto.KeyPress
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

    Private Sub Envio_KeyDown(sender As Object, e As KeyEventArgs) Handles envio.KeyDown
        If e.KeyCode = Keys.Enter Then
            docto.Select()
        End If
    End Sub

    Private Sub Docto_KeyDown(sender As Object, e As KeyEventArgs) Handles docto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtvalor.Select()
        End If
    End Sub

    Private Sub Txtvalor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvalor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtobser.Select()
        End If
    End Sub

    Private Sub Txtobser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_producto.Select()
        End If
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If envio.Text <> "" AndAlso txtproveedor.Text <> "" AndAlso txtnit.Text <> "" AndAlso docto.Text <> "" AndAlso txtfecha.Text <> "" AndAlso txttotal.Text <> "" AndAlso txtvalor.Text <> "" Then
            sentencia = "insert into envioentrada values('" + txtproveedor.Text + "','" + envio.Text + "','" + txtfecha.Text + "','" + txtobser.Text + "','" + txtnit.Text + "','" + docto.Text + "','" + txtvalor.Text + "','" + txtdireccion.Text + "','" + txttotal.Text.Replace(",", ".") + "')"
            mensaje = "se ha agregado la cotizacion, puede visualizarla dando click en reporte"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
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

    Private Sub Envios_de_entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

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
                    envio.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Btneliminarfila_Click(sender As Object, e As EventArgs) Handles btneliminarfila.Click
        Try
            con.Close()
            Dim Consulta As String = "select * from detenvioentrada where id_envio='" + envio.Text + "' and Id_Proveedor='" + txtproveedor.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detenvioentrada")
            lista = datos.Tables("detenvioentrada").Rows.Count
            If lista <> 0 Then
                eliminar = datos.Tables("detenvioentrada").Rows(0).Item("cantidad")
                sentencia6 = "delete from detenvioentrada where id_envio='" + envio.Text + "' and Id_Proveedor='" + txtproveedor.Text + "'"
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from detenvioentrada where id_envio='" + envio.Text + "' and Id_Proveedor='" + txtproveedor.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detenvioentrada")
            lista = datos.Tables("detenvioentrada").Rows.Count
            If lista <> 0 Then
                detalle = datos.Tables("detenvioentrada").Rows(0).Item("SUMA")
            End If
            If txt_producto.Text <> "" Then
                con.Close()
                con.Open()
                sentencia = "update detenvioentrada set id_envio='" + envio.Text + "',Id_Proveedor='" + txtproveedor.Text + "',id_producto='" + txt_producto.Text + "',cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where id_envio='" + envio.Text + "' and Id_`proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
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
            Dim Consulta As String = "select * from detenvioentrada where id_envio='" + envio.Text + "' and Id_Proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detenvioentrada")
            lista = datos.Tables("detenvioentrada").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim Consulta2 As String = "select Sum(cantidad) AS SUMA from detenvioentrada where id_envio='" + envio.Text + "' and Id_Proveedor='" + txtproveedor.Text + "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "detenvioentrada")
                lista2 = datos2.Tables("detenvioentrada").Rows.Count
                If lista2 <> 0 Then
                    detalle = datos2.Tables("detenvioentrada").Rows(0).Item("SUMA")
                    sentencia5 = "update detenvioentrada set id_envio='" + envio.Text + "',Id_Proveedor='" + txtproveedor.Text + "',id_producto='" + txt_producto.Text + "',cantidad='" + txtcantidad.Text + "', precio='" + txtprecio.Text.Replace(",", ".") + "', totaldet='" + txtsubtotal.Text.Replace(",", ".") + "' where id_envio='" + envio.Text + "' and Id_`proveedor='" + txtproveedor.Text + "' and id_producto='" + txt_producto.Text + "'"
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
                        sentencia = "insert into detenvioentrada values('" + txtproveedor.Text + "','" + envio.Text + "','" + txt_producto.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text.Replace(",", ".") + "','" + txtsubtotal.Text.Replace(",", ".") + "')"
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
            Dim Consulta As String = "select Sum(totaldetalle) AS SUMA from detenvioentrada where id_envio='" + envio.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detenvioentrada")
            lista = datos.Tables("detenvioentrada").Rows.Count
            If lista <> 0 Then
                txttotal.Text = datos.Tables("detenvioentrada").Rows(0).Item("SUMA")
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from detenvioentrada where id_envio='" + envio.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detenvioentrada")
            lista = datos.Tables("detenvioentrada").Rows.Count
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
        Dim Dap As New SqlDataAdapter("select * from detallecotizaciones", con)
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
            Dim Consulta As String = "Select * from detenvioentrada where id_envio='" + envio.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detenvioentrada")
            lista = datos.Tables("detenvioentrada").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from detenvioentrada where id_envio='" + envio.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                recuperar_total()
                dt.DefaultView.RowFilter = "id_envio like '" + envio.Text + "%' and id_proveedor like '" + txtproveedor.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe el envio con el id de envio: " + envio.Text + " , y el id de proveedor: " + txtproveedor.Text + ", verifique e intente de nuevo o cree una nueva de ser necesario")
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Public Sub recuperar_total()
        con.Close()
        Dim Consulta1 As String = "select Sum(totaldetalle) AS SUMA from detenvioentrada where id_envio='" + envio.Text + "' and id_proveedor='" + txtproveedor.Text + "'"
        Dim lista1 As Byte
        Dim datos1 As New DataSet
        Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
        datos1 = New DataSet
        adaptador1.Fill(datos1, "detenvioentrada")
        lista1 = datos1.Tables("detenvioentrada").Rows.Count
        If lista1 <> 0 Then
            txttotal.Text = datos1.Tables("detenvioentrada").Rows(0).Item("SUMA")
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