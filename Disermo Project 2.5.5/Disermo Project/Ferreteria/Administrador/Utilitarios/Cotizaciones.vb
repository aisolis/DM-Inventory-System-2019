Imports System.Data.SqlClient
Public Class Cotizaciones
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, bloqueo, avisosalida, liquidacion, docena, fardo, mediofardo, existencia, total, resta, resta2, sentencia2, valordetalle, sentencia3, sentencia4, sentencia5, sentencia6, sentencia7 As String
    Dim nuevovalor, nuevoproducto, detalle, base, cantidad, nuevoproducto2, nuevovalor2, exis, eliminar, totaleli As Integer

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Txt_noCotizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_noCotizacion.KeyPress, txt_vendedor1.KeyPress, txt_producto.KeyPress, txt_cliente.KeyPress, txt_cantidad.KeyPress
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
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txt_noCotizacion.Text <> "" AndAlso txt_cliente.Text <> "" Then
            sentencia = "update cotizaciones set id_documento='" + txt_noCotizacion.Text + "',id_cliente='" + txt_cliente.Text + "',nit='" + txt_noNit.Text + "',direccion='" + txt_direccion.Text + "',telfono='" + txt_telefono.Text + "',id_vendedor='" + txt_vendedor1.Text + "',fecha='" + mtxt_fecha.Text + "',obser='" + txt_obser.Text + "',total_general='" + txt_total2.Text.Replace(",", ".") + "' where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "'"
            mensaje = "datos actualizados"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            mtxt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txt_noCotizacion.Text <> "" AndAlso txt_cliente.Text <> "" Then
            sentencia = "delete from cotizaciones where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "'"
            mensaje = "se ha eliminado"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            mtxt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txt_noCotizacion.Text <> "" AndAlso txt_cliente.Text <> "" Then
            mostrar()
            mtxt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Else
            MsgBox("El campo del numero de cotizacion o el de cliente esta vacio")
        End If
    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txt_noCotizacion.Text <> "" AndAlso txt_cliente.Text <> "" AndAlso txt_noNit.Text <> "" AndAlso txt_direccion.Text <> "" AndAlso txt_telefono.Text <> "" AndAlso txt_vendedor1.Text <> "" AndAlso mtxt_fecha.Text <> "" AndAlso txt_obser.Text <> "" AndAlso txt_total2.Text <> "" Then
            sentencia = "insert into cotizaciones values('" + txt_noCotizacion.Text + "','" + txt_cliente.Text + "','" + txt_noNit.Text + "','" + txt_direccion.Text + "','" + txt_telefono.Text + "','" + txt_vendedor1.Text + "','" + mtxt_fecha.Text + "','" + txt_obser.Text + "','" + txt_total2.Text.Replace(",", ".") + "')"
            mensaje = "se ha agregado la cotizacion, puede visualizarla dando click en reporte"
            con.Close()
            ejecutarSQL(sentencia, mensaje)
            Limpiar_TextBox(Me)
            mtxt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        End If
    End Sub

    Private Sub Btn_EliminFila_Click(sender As Object, e As EventArgs) Handles btn_EliminFila.Click
        Dim Text As Object
        For Each Text In Me.Controls 'Recorremos todos los controles de la ventana
            If TypeOf Text Is TextBox Then 'Comprobamos si es un TextBox
                If Text.Text = "" Then 'Comprobamos si está vacío
                    MsgBox("alguno de los campos esta vacio")
                    Exit Sub 'Salir de la función sin ejecutar el resto del código
                End If
            End If
        Next Text
        Try
            con.Close()
            Dim Consulta As String = "select * from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detallecotizaciones")
            lista = datos.Tables("detallecotizaciones").Rows.Count
            If lista <> 0 Then
                eliminar = datos.Tables("detallecotizaciones").Rows(0).Item("cantidad")
                sentencia6 = "delete from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "' and id_producto='" + txt_producto.Text + "'"
                mensaje = "fila eliminada correctamente"
                con.Close()
                ' restaurar()
                con.Close()
                ejecutarSQL(sentencia6, mensaje)
                con.Close()
                recuperartotal()
                mostrar2()
                txt_producto.Text = ""
                txtproducto.Text = ""
                txt_cantidad.Text = ""
                txt_precio.Text = ""
                txt_total.Text = ""
                txt_existen.Text = ""
                btn_InsertFila.Enabled = False
                btn_ModifFila.Enabled = False
                btn_EliminFila.Enabled = False
            End If
        Catch
            con.Close()
        End Try

    End Sub

    Public Sub restaurar()
        base = txt_existen.Text
        totaleli = eliminar + base
        Dim xd As String = totaleli
        sentencia4 = "update productos set existencias='" + xd + "' where id_producto='" + txt_producto.Text + "'"
        ejecutarSQL2(sentencia4)
    End Sub
    Private Sub Btn_InsertFila_Click(sender As Object, e As EventArgs) Handles btn_InsertFila.Click
        Dim Text As Object
        For Each Text In Me.Controls 'Recorremos todos los controles de la ventana
            If TypeOf Text Is TextBox Then 'Comprobamos si es un TextBox
                If Text.Text = "" Then 'Comprobamos si está vacío
                    MsgBox("alguno de los campos esta vacio")
                    Exit Sub 'Salir de la función sin ejecutar el resto del código
                End If
            End If
        Next Text
        Try
            con.Close()
            Dim Consulta As String = "select * from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detallecotizaciones")
            lista = datos.Tables("detallecotizaciones").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim Consulta2 As String = "select Sum(cantidad) AS SUMA from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "detallecotizaciones")
                lista2 = datos2.Tables("detallecotizaciones").Rows.Count
                If lista2 <> 0 Then
                    detalle = datos2.Tables("detallecotizaciones").Rows(0).Item("SUMA")
                    sentencia5 = "update detallecotizaciones set id_documento='" + txt_noCotizacion.Text + "',id_cliente='" + txt_cliente.Text + "',id_producto='" + txt_producto.Text + "',cantidad='" + txt_cantidad.Text + "',precio='" + txt_precio.Text.Replace(",", ".") + "', totaldetalle='" + txt_total.Text.Replace(",", ".") + "' where Id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "' and id_producto='" + txt_producto.Text + "'"
                    con.Close()
                    ejecutarSQL2(sentencia5)
                    mostrar()
                    con.Close()
                    ' sumaorestaexistencia()
                    recuperartotal()
                    con.Close()
                    txt_producto.Text = ""
                    txtproducto.Text = ""
                    txt_cantidad.Text = ""
                    txt_precio.Text = ""
                    txt_total.Text = ""
                    txt_existen.Text = ""
                    btn_InsertFila.Enabled = False
                    btn_ModifFila.Enabled = False
                    btn_EliminFila.Enabled = False

                End If
            Else
                Dim a, b As Integer
                a = txt_cantidad.Text
                b = txt_existen.Text
                If a <= b Then
                    If txt_producto.Text <> "" Then
                        con.Close()
                        con.Open()
                        sentencia = "insert into detallecotizaciones values('" + txt_noCotizacion.Text + "','" + txt_cliente.Text + "','" + txt_producto.Text + "','" + txt_cantidad.Text + "','" + txt_precio.Text.Replace(",", ".") + "','" + txt_total.Text.Replace(",", ".") + "')"
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
                        txt_cantidad.Text = ""
                        txt_precio.Text = ""
                        txt_total.Text = ""
                        txt_existen.Text = ""
                        btn_InsertFila.Enabled = False
                        btn_ModifFila.Enabled = False
                        btn_EliminFila.Enabled = False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(resta2)
    End Sub

    Sub recuperartotal()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(totaldetalle) AS SUMA from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detallecotizaciones")
            lista = datos.Tables("detallecotizaciones").Rows.Count
            If lista <> 0 Then
                txt_total2.Text = datos.Tables("detallecotizaciones").Rows(0).Item("SUMA")
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
            resta = txt_existen.Text - txt_cantidad.Text
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
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detallecotizaciones")
            lista = datos.Tables("detallecotizaciones").Rows.Count
            If lista <> 0 Then
                'detalle = datos.Tables("detallecotizaciones").Rows(0).Item("SUMA")
                base = txt_existen.Text
                If txt_cantidad.Text > detalle Then
                    nuevovalor = txt_cantidad.Text - detalle
                    nuevoproducto = base - nuevovalor
                    con.Close()
                    Dim nuevo As String = nuevoproducto
                    sentencia4 = "update productos set existencias='" + nuevo + "' where id_producto='" + txt_producto.Text + "'"
                    ejecutarSQL2(sentencia4)
                ElseIf txt_cantidad.Text < detalle Then
                    nuevovalor2 = detalle - txt_cantidad.Text
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
    Private Sub Txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        existencia = txt_existen.Text
        If e.KeyCode = Keys.Enter Then
            If txt_cantidad.Text <> "" Then
                Dim cantidad As Integer = txt_cantidad.Text
                Dim exis As Integer = existencia
                If txt_cantidad.Text <= 12 Then
                    txt_precio.Text = docena
                    txt_total.Text = txt_cantidad.Text * docena
                    btn_InsertFila.Enabled = True
                    btn_ModifFila.Enabled = True
                    btn_EliminFila.Enabled = True
                ElseIf txt_cantidad.Text <= 25 And txt_cantidad.Text >= 13 Then
                    txt_precio.Text = mediofardo
                    txt_total.Text = txt_cantidad.Text * mediofardo
                    btn_InsertFila.Enabled = True
                    btn_ModifFila.Enabled = True
                    btn_EliminFila.Enabled = True
                ElseIf txt_cantidad.Text <= 50 And txt_cantidad.Text >= 26 Then
                    txt_precio.Text = fardo
                    txt_total.Text = txt_cantidad.Text * fardo
                    btn_ModifFila.Enabled = True
                    btn_InsertFila.Enabled = True
                    btn_EliminFila.Enabled = True
                End If
            End If
        Else
            btn_InsertFila.Enabled = False
            Exit Sub
            MsgBox("la cantidad es superior a las existencias")
        End If
    End Sub

    Private Sub Txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_telefono.Select()
        End If
    End Sub

    Private Sub Btn_ModifFila_Click(sender As Object, e As EventArgs) Handles btn_ModifFila.Click
        Dim Text As Object
        For Each Text In Me.Controls 'Recorremos todos los controles de la ventana
            If TypeOf Text Is TextBox Then 'Comprobamos si es un TextBox
                If Text.Text = "" Then 'Comprobamos si está vacío
                    MsgBox("alguno de los campos esta vacio")
                    Exit Sub 'Salir de la función sin ejecutar el resto del código
                End If
            End If
        Next Text
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "select Sum(cantidad) AS SUMA from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "' and id_producto='" + txt_producto.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detallecotizaciones")
            lista = datos.Tables("detallecotizaciones").Rows.Count
            If lista <> 0 Then
                detalle = datos.Tables("detallecotizaciones").Rows(0).Item("SUMA")
            End If
            If txt_producto.Text <> "" Then
                con.Close()
                con.Open()
                sentencia = "update detallecotizaciones set id_documento='" + txt_noCotizacion.Text + "',id_cliente='" + txt_cliente.Text + "',id_producto='" + txt_producto.Text + "',cantidad='" + txt_cantidad.Text + "',precio='" + txt_precio.Text.Replace(",", ".") + "', totaldetalle='" + txt_total.Text.Replace(",", ".") + "' where Id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "' and id_producto='" + txt_producto.Text + "'"
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
                txt_cantidad.Text = ""
                txt_precio.Text = ""
                txt_total.Text = ""
                txt_existen.Text = ""
                btn_InsertFila.Enabled = False
                btn_ModifFila.Enabled = False
                btn_EliminFila.Enabled = False
            End If
        Catch
        End Try
    End Sub

    Private Sub Txt_obser_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_obser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_producto.Select()
        End If
    End Sub
    Private Sub Txt_telefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_vendedor1.Select()
        End If
    End Sub

    Private Sub Txt_vendedor1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_vendedor1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from vendedor where Id_vendedor = '" & txt_cliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "vendedor")
                lista = datos.Tables("vendedor").Rows.Count
                If lista <> 0 Then
                    txt_vendedor2.Text = datos.Tables("vendedor").Rows(0).Item("vendedor")
                    con.Close()
                    txt_obser.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Sub mostrar2()
        Dim Dap As New SqlDataAdapter("select * from detallecotizaciones", con)
        Dim ds As New DataSet
        Try
            Dap.Fill(ds)
            dgv_cotizacion.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
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
                    txt_existen.Text = datos.Tables("productos").Rows(0).Item("existencias")
                    liquidacion = datos.Tables("productos").Rows(0).Item("prec_liquidacion")
                    fardo = datos.Tables("productos").Rows(0).Item("pre_fardo")
                    mediofardo = datos.Tables("productos").Rows(0).Item("prec_unmedio_fardo")
                    docena = datos.Tables("productos").Rows(0).Item("prec_Docena_Fardo")
                    con.Close()
                    txt_cantidad.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txt_noNit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_noNit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_direccion.Select()
        End If
    End Sub

    Private Sub Txt_noCotizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_noCotizacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cliente.Select()
        End If
    End Sub

    Private Sub Cotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
    Private Sub Txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where Id_cliente = '" & txt_cliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    txtnombrelcliente.Text = datos.Tables("tabla_clientes").Rows(0).Item("cliente")
                    txt_noNit.Text = datos.Tables("tabla_clientes").Rows(0).Item("nit")
                    txt_direccion.Text = datos.Tables("tabla_clientes").Rows(0).Item("direccion")
                    txt_telefono.Text = datos.Tables("tabla_clientes").Rows(0).Item("telefono")
                    con.Close()
                    txt_vendedor1.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Sub mostrar()
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from detallecotizaciones where id_documento = '" & txt_noCotizacion.Text & "' and id_cliente='" + txt_cliente.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "detallecotizaciones")
            lista = datos.Tables("detallecotizaciones").Rows.Count
            If lista <> 0 Then
                con.Close()
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from detallecotizaciones where id_documento = '" & txt_noCotizacion.Text & "' and id_cliente='" + txt_cliente.Text + "'"
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                dgv_cotizacion.DataSource = dt
                recuperar_total()
                dt.DefaultView.RowFilter = "id_documento like '" + txt_noCotizacion.Text + "%' and id_cliente like '" + txt_cliente.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe la contizacion con el documento:" + txt_noCotizacion.Text + " , y el id de cliente: " + txt_cliente.Text + ", verifique e intente de nuevo o cree una nueva de ser necesario")
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Public Sub recuperar_total()
        con.Close()
        Dim Consulta1 As String = "select Sum(totaldetalle) AS SUMA from detallecotizaciones  where id_documento='" + txt_noCotizacion.Text + "' and id_cliente='" + txt_cliente.Text + "'"
        Dim lista1 As Byte
        Dim datos1 As New DataSet
        Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
        datos1 = New DataSet
        adaptador1.Fill(datos1, "detallecotizaciones")
        lista1 = datos1.Tables("detallecotizaciones").Rows.Count
        If lista1 <> 0 Then
            txt_total2.Text = datos1.Tables("detallecotizaciones").Rows(0).Item("SUMA")
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