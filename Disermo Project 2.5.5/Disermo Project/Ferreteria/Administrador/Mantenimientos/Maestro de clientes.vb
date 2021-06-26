Imports System.Data.SqlClient
Public Class Maestro_de_clientes
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, tvip, bloqueo, avisosalida As String
    Sub mostrar()
        Dim Dap As New SqlDataAdapter("select * from tabla_clientes", con)
        Dim ds As New DataSet
        Try
            Dap.Fill(ds)

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            con.Open()
            Dim Consulta As String = "Select * from tabla_clientes where Id_cliente = '" & CodCliente.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "tabla_clientes")
            lista = datos.Tables("tabla_clientes").Rows.Count
            If lista <> 0 Then
                txtnombre.Text = datos.Tables("tabla_clientes").Rows(0).Item("Cliente")
                Direccion.Text = datos.Tables("tabla_clientes").Rows(0).Item("Direccion")
                NoCasa.Text = datos.Tables("tabla_clientes").Rows(0).Item("No_Casa")
                CalleAvenida.Text = datos.Tables("tabla_clientes").Rows(0).Item("calleAvenia")
                zona.Text = datos.Tables("tabla_clientes").Rows(0).Item("Zona")
                Colonia.Text = datos.Tables("tabla_clientes").Rows(0).Item("ColoniaoLugar")
                IdMunicipio.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_municipio")
                Departamento.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_departamento")
                Telefono.Text = datos.Tables("tabla_clientes").Rows(0).Item("telefono")
                NIT.Text = datos.Tables("tabla_clientes").Rows(0).Item("nit")
                tvip = datos.Tables("tabla_clientes").Rows(0).Item("vip")
                If tvip = 1 Then
                    VIP.Checked = True
                Else
                    VIP.Checked = False
                End If
                DiasDeCredito.Text = datos.Tables("tabla_clientes").Rows(0).Item("dia_credito")
                LimCredito.Text = datos.Tables("tabla_clientes").Rows(0).Item("limite_credito")
                Email.Text = datos.Tables("tabla_clientes").Rows(0).Item("email")
                txtobersaciones.Text = datos.Tables("tabla_clientes").Rows(0).Item("Obser")
                IdVendedor.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_vendedor")
                TipoDeCliente.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_tipo")
                RutaDeCliente.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_ruta")
                Transporte.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_transporte")
                bloqueo = datos.Tables("tabla_clientes").Rows(0).Item("bloqueo_temporal")
                If bloqueo = 1 Then
                    BloqueoTemporal.Checked = True
                Else
                    BloqueoTemporal.Checked = False
                End If
                MotivoBloqueo.Text = datos.Tables("tabla_clientes").Rows(0).Item("motivo_bloqueo")
                Estado.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_estado")
                MotivoBaja.Text = datos.Tables("tabla_clientes").Rows(0).Item("motivo_baja")
                SubRutaCliente.Text = datos.Tables("tabla_clientes").Rows(0).Item("id_subruta")

                con.Close()
                con.Open()
                Dim Consulta1 As String = "Select * from vendedor where id_vendedor = '" & IdVendedor.Text & "'"
                Dim lista1 As Byte
                Dim datos1 As New DataSet
                Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
                datos1 = New DataSet
                adaptador1.Fill(datos1, "vendedor")
                lista1 = datos1.Tables("vendedor").Rows.Count
                If lista1 <> 0 Then
                    CmbVendedor.Text = datos1.Tables("vendedor").Rows(0).Item("vendedor")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta2 As String = "Select * from municipio where id_municipio = '" & IdVendedor.Text & "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "municipio")
                lista2 = datos2.Tables("municipio").Rows.Count
                If lista2 <> 0 Then
                    cmbMunicipio.Text = datos2.Tables("municipio").Rows(0).Item("municipio")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta3 As String = "Select * from departamento where id_departamento = '" & Departamento.Text & "'"
                Dim lista3 As Byte
                Dim datos3 As New DataSet
                Dim adaptador3 = New SqlDataAdapter(Consulta3, con)
                datos3 = New DataSet
                adaptador3.Fill(datos3, "departamento")
                lista3 = datos3.Tables("departamento").Rows.Count
                If lista3 <> 0 Then
                    cmbDepartamento.Text = datos3.Tables("departamento").Rows(0).Item("departamento")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta4 As String = "Select * from tipo_cliente where id_tipo = '" & TipoDeCliente.Text & "'"
                Dim lista4 As Byte
                Dim datos4 As New DataSet
                Dim adaptador4 = New SqlDataAdapter(Consulta4, con)
                datos4 = New DataSet
                adaptador4.Fill(datos4, "tipo_cliente")
                lista4 = datos4.Tables("tipo_cliente").Rows.Count
                If lista4 <> 0 Then
                    cmbTipodeCliente.Text = datos4.Tables("tipo_cliente").Rows(0).Item("tipo")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta5 As String = "Select * from ruta where id_ruta = '" & RutaDeCliente.Text & "'"
                Dim lista5 As Byte
                Dim datos5 As New DataSet
                Dim adaptador5 = New SqlDataAdapter(Consulta5, con)
                datos5 = New DataSet
                adaptador5.Fill(datos5, "ruta")
                lista5 = datos5.Tables("ruta").Rows.Count
                If lista5 <> 0 Then
                    cmbRuta.Text = datos5.Tables("ruta").Rows(0).Item("ruta")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta6 As String = "Select * from subruta where id_subruta = '" & SubRutaCliente.Text & "'"
                Dim lista6 As Byte
                Dim datos6 As New DataSet
                Dim adaptador6 = New SqlDataAdapter(Consulta6, con)
                datos6 = New DataSet
                adaptador6.Fill(datos6, "subruta")
                lista6 = datos6.Tables("subruta").Rows.Count
                If lista6 <> 0 Then
                    cmbSubRuta.Text = datos6.Tables("subruta").Rows(0).Item("subruta")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta7 As String = "Select * from transporte where id_transporte = '" & Transporte.Text & "'"
                Dim lista7 As Byte
                Dim datos7 As New DataSet
                Dim adaptador7 = New SqlDataAdapter(Consulta7, con)
                datos7 = New DataSet
                adaptador7.Fill(datos7, "transporte")
                lista7 = datos7.Tables("transporte").Rows.Count
                If lista7 <> 0 Then
                    cmbTransporte.Text = datos7.Tables("transporte").Rows(0).Item("transpor")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta8 As String = "Select * from estado where id_estado = '" & Estado.Text & "'"
                Dim lista8 As Byte
                Dim datos8 As New DataSet
                Dim adaptador8 = New SqlDataAdapter(Consulta8, con)
                datos8 = New DataSet
                adaptador8.Fill(datos8, "estado")
                lista8 = datos8.Tables("estado").Rows.Count
                If lista8 <> 0 Then
                    cmbEstado.Text = datos8.Tables("estado").Rows(0).Item("estado")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()

                con.Open()
                Dim Consulta9 As String = "Select * from bajacliente where id_motivo = '" & MotivoBaja.Text & "'"
                Dim lista9 As Byte
                Dim datos9 As New DataSet
                Dim adaptador9 = New SqlDataAdapter(Consulta9, con)
                datos9 = New DataSet
                adaptador9.Fill(datos9, "bajacliente")
                lista9 = datos9.Tables("bajacliente").Rows.Count
                If lista9 <> 0 Then
                    cmbBajaCliente.Text = datos9.Tables("bajacliente").Rows(0).Item("motivobaja")
                Else
                    MsgBox("no encotrado")
                    con.Close()
                End If
                con.Close()
            Else
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If CodCliente.TextLength <> 0 Then
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where Id_cliente = '" & CodCliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    sentencia = " delete from tabla_clientes where Id_Cliente='" + CodCliente.Text + "' "
                    mensaje = "datos eliminados"
                    avisosalida = MsgBox("¨Realmente quiere eliminar el registro?", MsgBoxStyle.YesNo, "Advertencia")

                    If avisosalida = 6 Then
                        con.Close()
                        ejecutarSQL(sentencia, mensaje)
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
    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
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
            con.Open()
            Dim Consulta As String = "Select * from tabla_clientes where Id_cliente = '" & CodCliente.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "tabla_clientes")
            lista = datos.Tables("tabla_clientes").Rows.Count
            If lista <> 0 Then
                If VIP.Checked = True Then
                    tvip = 1
                Else
                    tvip = 0
                End If
                If BloqueoTemporal.Checked = True Then
                    bloqueo = 1
                Else
                    bloqueo = 0
                End If
                con.Close()
                sentencia = "update tabla_clientes set Id_Cliente='" + CodCliente.Text + "',cliente='" + txtnombre.Text + "',Direccion='" + Direccion.Text + "',No_Casa='" + NoCasa.Text + "',CalleAvenia='" + CalleAvenida.Text + "', Zona='" + zona.Text + "', ColoniaoLugar='" + Colonia.Text + "', id_municipio='" + IdMunicipio.Text + "', id_departamento='" + Departamento.Text + "', telefono='" + Telefono.Text + "', nit='" + NIT.Text + "', vip='" + tvip + "', dia_credito='" + DiasDeCredito.Text + "', limite_credito='" + LimCredito.Text + "', email='" + Email.Text + "', obser='" + txtobersaciones.Text + "', id_vendedor='" + IdVendedor.Text + "', id_tipo='" + TipoDeCliente.Text + "', id_subruta='" + SubRutaCliente.Text + "', id_ruta='" + RutaDeCliente.Text + "', id_transporte='" + Transporte.Text + "', bloqueo_Temporal ='" + bloqueo + "', motivo_bloqueo='" + MotivoBloqueo.Text + "', id_estado='" + Estado.Text + "', Id_motivo='" + MotivoBaja.Text + "' where Id_Cliente='" + CodCliente.Text + "'"
                mensaje = "actualizado correctamente"
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                cmbBajaCliente.Text = ""
                cmbDepartamento.Text = ""
                cmbEstado.Text = ""
                cmbMunicipio.Text = ""
                cmbRuta.Text = ""
                cmbSubRuta.Text = ""
                cmbTipodeCliente.Text = ""
                cmbTransporte.Text = ""
                CmbVendedor.Text = ""
                zona.Text = ""
            Else
                MsgBox("no existe registro con la id del cliente: " + CodCliente.Text + " ,verifique e intente de nuevo")
                con.Close()
                Exit Sub
            End If

        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Private Sub Maestro_de_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar_TextBox(Me)
    End Sub
    Private Sub IdMunicipio_KeyDown(sender As Object, e As KeyEventArgs) Handles IdMunicipio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select municipio from municipio where id_municipio = '" & IdMunicipio.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "municipio")
                lista = datos.Tables("municipio").Rows.Count
                If lista <> 0 Then
                    cmbMunicipio.Text = datos.Tables("municipio").Rows(0).Item("municipio")
                    con.Close()
                    Departamento.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub Departamento_KeyDown(sender As Object, e As KeyEventArgs) Handles Departamento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select departamento from departamento where Id_Departamento = '" & Departamento.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "departamento")
                lista = datos.Tables("departamento").Rows.Count
                If lista <> 0 Then
                    cmbDepartamento.Text = datos.Tables("departamento").Rows(0).Item("departamento")
                    con.Close()
                    Telefono.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub IdVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles IdVendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select vendedor from vendedor where Id_vendedor = '" & IdVendedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "vendedor")
                lista = datos.Tables("vendedor").Rows.Count
                If lista <> 0 Then
                    CmbVendedor.Text = datos.Tables("vendedor").Rows(0).Item("vendedor")
                    con.Close()
                    TipoDeCliente.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub RutaDeCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles RutaDeCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select ruta from ruta where Id_ruta = '" & RutaDeCliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "ruta")
                lista = datos.Tables("ruta").Rows.Count
                If lista <> 0 Then
                    cmbRuta.Text = datos.Tables("ruta").Rows(0).Item("ruta")
                    con.Close()
                    SubRutaCliente.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub Transporte_KeyDown(sender As Object, e As KeyEventArgs) Handles Transporte.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select transpor from transporte where Id_transporte = '" & Transporte.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "transporte")
                lista = datos.Tables("transporte").Rows.Count
                If lista <> 0 Then
                    cmbTransporte.Text = datos.Tables("transporte").Rows(0).Item("transpor")
                    con.Close()
                    MotivoBloqueo.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub TipoDeCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TipoDeCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select tipo from tipo_cliente where Id_tipo = '" & TipoDeCliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tipo_cliente")
                lista = datos.Tables("tipo_cliente").Rows.Count
                If lista <> 0 Then
                    cmbTipodeCliente.Text = datos.Tables("tipo_cliente").Rows(0).Item("tipo")
                    con.Close()
                    RutaDeCliente.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub CodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodCliente.KeyPress, Transporte.KeyPress, TipoDeCliente.KeyPress, Telefono.KeyPress, SubRutaCliente.KeyPress, RutaDeCliente.KeyPress, NIT.KeyPress, MotivoBaja.KeyPress, LimCredito.KeyPress, IdVendedor.KeyPress, IdMunicipio.KeyPress, Estado.KeyPress, Disp.KeyPress, DiasDeCredito.KeyPress, Departamento.KeyPress
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

    Private Sub Email_Leave(sender As Object, e As EventArgs) Handles Email.Leave
        If Email.Text = "" Then
            Exit Sub
        End If
        Try
            Dim mail As New System.Net.Mail.MailAddress(Email.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Email.Focus()
            Email.SelectAll()
        End Try
    End Sub

    Private Sub CodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles CodCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            NIT.Select()
        End If
    End Sub

    Private Sub NIT_KeyDown(sender As Object, e As KeyEventArgs) Handles NIT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnombre.Select()
        End If
    End Sub

    Private Sub Txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Direccion.Select()
        End If
    End Sub

    Private Sub Direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles Direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalleAvenida.Select()
        End If
    End Sub

    Private Sub CalleAvenida_KeyDown(sender As Object, e As KeyEventArgs) Handles CalleAvenida.KeyDown
        If e.KeyCode = Keys.Enter Then
            NoCasa.Select()
        End If
    End Sub

    Private Sub NoCasa_KeyDown(sender As Object, e As KeyEventArgs) Handles NoCasa.KeyDown
        If e.KeyCode = Keys.Enter Then
            AptoPuestoLocal.Select()
        End If
    End Sub

    Private Sub AptoPuestoLocal_KeyDown(sender As Object, e As KeyEventArgs) Handles AptoPuestoLocal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Colonia.Select()
        End If
    End Sub

    Private Sub Colonia_KeyDown(sender As Object, e As KeyEventArgs) Handles Colonia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Municipios.Select()
        End If
    End Sub

    Private Sub Telefono_KeyDown(sender As Object, e As KeyEventArgs) Handles Telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiasDeCredito.Select()
        End If
    End Sub

    Private Sub DiasDeCredito_KeyDown(sender As Object, e As KeyEventArgs) Handles DiasDeCredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            LimCredito.Select()
        End If
    End Sub

    Private Sub LimCredito_KeyDown(sender As Object, e As KeyEventArgs) Handles LimCredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            Disp.Select()
        End If
    End Sub

    Private Sub Disp_KeyDown(sender As Object, e As KeyEventArgs) Handles Disp.KeyDown
        If e.KeyCode = Keys.Enter Then
            Email.Select()
        End If
    End Sub

    Private Sub Email_KeyDown(sender As Object, e As KeyEventArgs) Handles Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtobersaciones.Select()
        End If
    End Sub

    Private Sub Txtobersaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txtobersaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            IdVendedor.Select()
        End If
    End Sub

    Private Sub MotivoBloqueo_KeyDown(sender As Object, e As KeyEventArgs) Handles MotivoBloqueo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Estado.Select()
        End If
    End Sub

    Private Sub MotivoBloqueo_Leave(sender As Object, e As EventArgs) Handles MotivoBloqueo.Leave
        If MotivoBloqueo.Text = "" Then
            MotivoBloqueo.Text = " "
        End If
    End Sub

    Private Sub MotivoBaja_Leave(sender As Object, e As EventArgs) Handles MotivoBaja.Leave
        If MotivoBaja.Text = "" Then
            MotivoBaja.Text = " "
        End If
    End Sub

    Private Sub Btnreporte_Click(sender As Object, e As EventArgs) Handles btnreporte.Click
        reporte_tabla_clientes.Show()
    End Sub

    Private Sub SubRutaCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles SubRutaCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select subruta from subruta where Id_subruta = '" & SubRutaCliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "subruta")
                lista = datos.Tables("subruta").Rows.Count
                If lista <> 0 Then
                    cmbSubRuta.Text = datos.Tables("subruta").Rows(0).Item("subruta")
                    con.Close()
                    Transporte.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub Estado_KeyDown(sender As Object, e As KeyEventArgs) Handles Estado.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select estado from estado where Id_estado = '" & Estado.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "estado")
                lista = datos.Tables("estado").Rows.Count
                If lista <> 0 Then
                    cmbEstado.Text = datos.Tables("estado").Rows(0).Item("estado")
                    con.Close()
                    MotivoBaja.Select()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
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
            If CodCliente.Text <> "" Then
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where Id_cliente = '" & CodCliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    MsgBox("La Id: " + CodCliente.Text + " ya existe en la base de datos, elija otra e intentelo de nuevo")
                    Exit Sub
                End If

                If VIP.Checked = True Then
                    tvip = 1
                Else
                    tvip = 0
                End If
                If BloqueoTemporal.Checked = True Then
                    bloqueo = 1
                Else
                    bloqueo = 0
                End If
                sentencia = "insert into tabla_clientes values('" + CodCliente.Text + "','" + txtnombre.Text + "','" + Direccion.Text + "','" + NoCasa.Text + "','" + CalleAvenida.Text + "','" + AptoPuestoLocal.Text + "','" + zona.Text + "','" + Colonia.Text + "','" + IdMunicipio.Text + "','" + Departamento.Text + "','" + Telefono.Text + "','" + NIT.Text + "','" + tvip + "','" + DiasDeCredito.Text + "','" + LimCredito.Text + "','" + Email.Text + "','" + txtobersaciones.Text + "','" + IdVendedor.Text + "','" + TipoDeCliente.Text + "','" + SubRutaCliente.Text + "','" + RutaDeCliente.Text + "','" + Transporte.Text + "','" + bloqueo + "','" + MotivoBloqueo.Text + "','" + Estado.Text + "','" + MotivoBaja.Text + "')"
                mensaje = "Datos insertados correctamente"
                con.Close()
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                cmbBajaCliente.Text = ""
                cmbDepartamento.Text = ""
                cmbEstado.Text = ""
                cmbMunicipio.Text = ""
                cmbRuta.Text = ""
                cmbSubRuta.Text = ""
                cmbTipodeCliente.Text = ""
                cmbTransporte.Text = ""
                CmbVendedor.Text = ""
                zona.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub MotivoBaja_KeyDown(sender As Object, e As KeyEventArgs) Handles MotivoBaja.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select motivo from bajacliente where Id_motivo = '" & MotivoBaja.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "bajacliente")
                lista = datos.Tables("bajacliente").Rows.Count
                If lista <> 0 Then
                    cmbBajaCliente.Text = datos.Tables("bajacliente").Rows(0).Item("motivo")
                    con.Close()
                Else
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
End Class