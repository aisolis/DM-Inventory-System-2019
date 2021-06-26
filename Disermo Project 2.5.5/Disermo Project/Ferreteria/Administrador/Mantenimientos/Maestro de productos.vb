Imports System.Data.SqlClient
Public Class Maestro_de_productos
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, rotacion, bloqueo, avisosalida As String

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtIdProd.Text <> "" Then
            Dim text As Object
            For Each text In Me.Controls 'Recorremos todos los controles de la ventana
                If TypeOf text Is TextBox Then 'Comprobamos si es un TextBox
                    If text.Text = "" Then 'Comprobamos si está vacío
                        MsgBox("alguno de los campos esta vacio")
                        Exit Sub 'Salir de la función sin ejecutar el resto del código
                    End If
                End If
            Next text
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from productos where Id_producto = '" & txtIdProd.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "productos")
                lista = datos.Tables("productos").Rows.Count
                If lista <> 0 Then
                    MsgBox("La Id: " + txtIdProd.Text + " ya existe en la base de datos, elija otra e intentelo de nuevo")
                    Exit Sub
                End If

                If chkbAlta.Checked = True Then
                    rotacion = 1
                Else
                    rotacion = 0
                End If
                If chkbBloqueoTemp.Checked = True Then
                    bloqueo = 1
                Else
                    bloqueo = 0
                End If
                con.Close()
                sentencia = "insert into productos values('" + txtIdProd.Text + "','" + txtnombreprod.Text + "','" + txtdescripcion.Text + "','" + txtidprov.Text + "','" + txtvolumen.Text + "','" + txtpromvtas.Text + "','" + txtpeso.Text + "','" + txtcombinacion.Text + "','" + cmbclasificacion.Text + "','" + rotacion + "','" + bloqueo + "','" + txtPercentLiquidacion.Text + "','" + txtGananciaFardo.Text + "','" + txtganmedioFardo.Text + "','" + txtgananciadocena.Text + "','" + txtprecioLiquidacion.Text + "','" + txtPrecioFardo.Text + "','" + txtpreciomediofardo.Text + "','" + txtPrecioDocena.Text + "','" + txtMinInv.Text + "','" + txtminvta.Text + "','" + txtexistencia.Text + "','" + txfardo.Text + "','" + txtminmultiplo.Text + "')"
                mensaje = "Datos insertados correctamente"
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                cmbclasificacion.Text = ""
                cmbCombinacion.Text = ""
                cmbIdProveedor.Text = ""
                mostrar()
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try
        Else
            MsgBox("algun campo esta vacio, por favor rellenelo e intente de nuevo")
        End If
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtIdProd.Text <> "" Then
            Dim text As Object
            For Each text In Me.Controls 'Recorremos todos los controles de la ventana
                If TypeOf text Is TextBox Then 'Comprobamos si es un TextBox
                    If text.Text = "" Then 'Comprobamos si está vacío
                        MsgBox("alguno de los campos esta vacio")
                        Exit Sub 'Salir de la función sin ejecutar el resto del código
                    End If
                End If
            Next text
            Try
                Dim Consulta As String = "Select * from productos where Id_producto = '" & txtIdProd.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "productos")
                lista = datos.Tables("productos").Rows.Count
                If lista <> 0 Then
                    If chkbAlta.Checked = True Then
                        rotacion = 1
                    Else
                        rotacion = 0
                    End If
                    If chkbBloqueoTemp.Checked = True Then
                        bloqueo = 1
                    Else
                        bloqueo = 0
                    End If
                    con.Close()
                    sentencia = "update productos set Id_producto='" + txtIdProd.Text + "',producto='" + txtnombreprod.Text + "',descripcion='" + txtdescripcion.Text + "',id_proveedor='" + txtidprov.Text + "',volumen='" + txtvolumen.Text + "',promedio_ventaxmes='" + txtpromvtas.Text + "', peso='" + txtpeso.Text + "', id_combinacion='" + txtcombinacion.Text + "', grupo='" + cmbclasificacion.Text + "', alta_rotacion='" + rotacion + "', bloqueo_temporal='" + bloqueo + "', ganLiquidacion='" + txtPercentLiquidacion.Text + "', ganFardo='" + txtGananciaFardo.Text + "', ganunmediofardo='" + txtganmedioFardo.Text + "', ganDocena='" + txtgananciadocena.Text + "', prec_liquidacion='" + txtprecioLiquidacion.Text + "', pre_fardo='" + txtPrecioFardo.Text + "', prec_unmedio_fardo='" + txtpreciomediofardo.Text + "', prec_docena_fardo='" + txtPrecioDocena.Text + "', min_inv='" + txtMinInv.Text + "', min_venta='" + txtminvta.Text + "', existencias ='" + txtexistencia.Text + "', fardos='" + txfardo.Text + "', min_multiplos='" + txtminmultiplo.Text + "' where Id_producto='" + txtIdProd.Text + "'"
                    mensaje = "Datos actualizados correctamente"
                    ejecutarSQL(sentencia, mensaje)
                    Limpiar_TextBox(Me)
                    cmbclasificacion.Text = ""
                    cmbCombinacion.Text = ""
                    cmbidproveedor.Text = ""
                    mostrar()
                    con.Close()
                Else
                    MsgBox("La id: " + txtIdProd.Text + " , no existe, verifique e intente de nuevo")
                End If

            Catch ex As Exception
                con.Close()
            End Try
        Else
            MsgBox("algun campo esta vacio, por favor rellenelo e intente de nuevo")
        End If
    End Sub
    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            con.Close()
            If txtIdProd.TextLength <> 0 Then
                con.Open()
                Dim Consulta As String = "Select * from productos where Id_producto = '" & txtIdProd.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "productos")
                lista = datos.Tables("productos").Rows.Count
                If lista <> 0 Then
                    con.Close()
                    sentencia = " delete from productos where Id_producto='" + txtIdProd.Text + "' "
                    mensaje = "datos eliminados"
                    avisosalida = MsgBox("¨Realmente quiere eliminar el registro?", MsgBoxStyle.YesNo, "Advertencia")

                    If avisosalida = 6 Then
                        con.Close()
                        ejecutarSQL(sentencia, mensaje)
                        mostrar()
                        con.Close()
                    End If
                    con.Close()
                Else
                    MsgBox("registro no existente")
                    con.Close()
                End If
                con.Close()
            Else
                MsgBox("debe rellenar todos los campos")
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub Txtcombinacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcombinacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select combinacion from combinaciones where Id_combinacion = '" & txtcombinacion.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "combinaciones")
                lista = datos.Tables("combinaciones").Rows.Count
                If lista <> 0 Then
                    cmbCombinacion.Text = datos.Tables("combinaciones").Rows(0).Item("combinacion")
                    con.Close()
                    txtPercentLiquidacion.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txtidprov_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidprov.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select proveedor from proveedor where Id_proveedor = '" & txtidprov.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "proveedor")
                lista = datos.Tables("proveedor").Rows.Count
                If lista <> 0 Then
                    cmbIdProveedor.Text = datos.Tables("proveedor").Rows(0).Item("proveedor")
                    con.Close()
                    txtvolumen.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub TxtIdProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProd.KeyPress, txtvolumen.KeyPress, txtpromvtas.KeyPress, txtpreciomediofardo.KeyPress, txtprecioLiquidacion.KeyPress, txtPrecioFardo.KeyPress, txtPrecioDocena.KeyPress, txtpeso.KeyPress, txtPercentLiquidacion.KeyPress, txtminvta.KeyPress, txtminmultiplo.KeyPress, txtMinInv.KeyPress, txtidprov.KeyPress, txtganmedioFardo.KeyPress, txtGananciaFardo.KeyPress, txtgananciadocena.KeyPress, txtexistencia.KeyPress, txtcombinacion.KeyPress, txfardo.KeyPress
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

    Private Sub TxtIdProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnombreprod.Select()
        End If
    End Sub

    Private Sub Txtnombreprod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombreprod.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdescripcion.Select()
        End If
    End Sub

    Private Sub Txtdescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtidprov.Select()
        End If
    End Sub

    Private Sub Txtvolumen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvolumen.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpromvtas.Select()
        End If
    End Sub

    Private Sub Txtpromvtas_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpromvtas.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpeso.Select()
        End If
    End Sub

    Private Sub Txtpeso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpeso.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcombinacion.Select()
        End If
    End Sub

    Private Sub TxtPercentLiquidacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPercentLiquidacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecioLiquidacion.Select()
        End If
    End Sub

    Private Sub TxtprecioLiquidacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprecioLiquidacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtGananciaFardo.Select()
        End If
    End Sub

    Private Sub TxtGananciaFardo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGananciaFardo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrecioFardo.Select()
        End If
    End Sub

    Private Sub TxtPrecioFardo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioFardo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtganmedioFardo.Select()
        End If
    End Sub

    Private Sub TxtganmedioFardo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtganmedioFardo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpreciomediofardo.Select()
        End If
    End Sub

    Private Sub Txtpreciomediofardo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpreciomediofardo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtgananciadocena.Select()
        End If
    End Sub

    Private Sub Txtgananciadocena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgananciadocena.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrecioDocena.Select()
        End If
    End Sub

    Private Sub TxtPrecioDocena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioDocena.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtminmultiplo.Select()
        End If
    End Sub

    Private Sub Txtminmultiplo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtminmultiplo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMinInv.Select()
        End If
    End Sub

    Private Sub TxtMinInv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMinInv.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtminvta.Select()
        End If
    End Sub

    Private Sub Txtminvta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtminvta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtexistencia.Select()
        End If
    End Sub

    Private Sub Txtexistencia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtexistencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txfardo.Select()
        End If
    End Sub

    Private Sub Maestro_de_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Limpiar_TextBox(Me)
        Timer1.Start()
    End Sub

    Private Sub Btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        Reporte_tabla_productos.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            con.Open()
            Dim Consulta As String = "Select * from productos where id_producto = '" & txtIdProd.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "productos")
            lista = datos.Tables("productos").Rows.Count
            If lista <> 0 Then
                txtnombreprod.Text = datos.Tables("productos").Rows(0).Item("producto")
                txtdescripcion.Text = datos.Tables("productos").Rows(0).Item("descripcion")
                txtidprov.Text = datos.Tables("productos").Rows(0).Item("Id_proveedor")
                txtvolumen.Text = datos.Tables("productos").Rows(0).Item("volumen")
                txtpromvtas.Text = datos.Tables("productos").Rows(0).Item("promedio_ventaxmes")
                txtpeso.Text = datos.Tables("productos").Rows(0).Item("peso")
                txtcombinacion.Text = datos.Tables("productos").Rows(0).Item("id_combinacion")
                cmbclasificacion.Text = datos.Tables("productos").Rows(0).Item("grupo")
                rotacion = datos.Tables("productos").Rows(0).Item("alta_rotacion")
                bloqueo = datos.Tables("productos").Rows(0).Item("bloqueo_temporal")
                txtPercentLiquidacion.Text = datos.Tables("productos").Rows(0).Item("ganLiquidacion")
                txtGananciaFardo.Text = datos.Tables("productos").Rows(0).Item("ganfardo")
                txtganmedioFardo.Text = datos.Tables("productos").Rows(0).Item("ganunmediofardo")
                txtgananciadocena.Text = datos.Tables("productos").Rows(0).Item("ganDocena")
                txtprecioLiquidacion.Text = datos.Tables("productos").Rows(0).Item("prec_liquidacion")
                txtPrecioFardo.Text = datos.Tables("productos").Rows(0).Item("pre_fardo")
                txtpreciomediofardo.Text = datos.Tables("productos").Rows(0).Item("prec_unmedio_fardo")
                txtPrecioDocena.Text = datos.Tables("productos").Rows(0).Item("prec_Docena_Fardo")
                txtMinInv.Text = datos.Tables("productos").Rows(0).Item("min_inv")
                txtminvta.Text = datos.Tables("productos").Rows(0).Item("min_venta")
                txtexistencia.Text = datos.Tables("productos").Rows(0).Item("existencias")
                txfardo.Text = datos.Tables("productos").Rows(0).Item("fardos")
                txtminmultiplo.Text = datos.Tables("productos").Rows(0).Item("min_multiplos")
                If rotacion = 1 Then
                    chkbAlta.Checked = True
                Else
                    chkbAlta.Checked = False
                End If
                If bloqueo = 1 Then
                    chkbBloqueoTemp.Checked = True
                Else
                    chkbBloqueoTemp.Checked = False
                End If

                con.Close()
                con.Open()
                Dim Consulta1 As String = "Select * from proveedor where id_proveedor = '" & txtidprov.Text & "'"
                Dim lista1 As Byte
                Dim datos1 As New DataSet
                Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
                datos1 = New DataSet
                adaptador1.Fill(datos1, "proveedor")
                lista1 = datos1.Tables("proveedor").Rows.Count
                If lista1 <> 0 Then
                    cmbidproveedor.Text = datos1.Tables("proveedor").Rows(0).Item("proveedor")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta2 As String = "Select * from combinaciones where id_combinacion = '" & txtcombinacion.Text & "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "combinaciones")
                lista2 = datos2.Tables("combinaciones").Rows.Count
                If lista2 <> 0 Then
                    cmbCombinacion.Text = datos2.Tables("combinaciones").Rows(0).Item("combinacion")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()
            End If
            con.Close()
        Catch
            con.Close()
            MsgBox("no existente, agreguelo")
        End Try
    End Sub
    Sub ejecutarSQL(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
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
        Dim Dap As New SqlDataAdapter("select * from productos", con)
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
End Class