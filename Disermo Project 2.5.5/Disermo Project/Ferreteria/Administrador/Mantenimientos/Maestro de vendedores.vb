Imports System.Data.SqlClient
Public Class Maestro_de_vendedores
    Dim conexion As New SqlConnection(My.Settings.conexionglobal)
    Dim sentencias, mensaje, estado, avisosalida, agregar, eliminar, modificar, imprimir As String

    Private Sub TxtIdRegion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdRegion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                conexion.Open()
                Dim Consulta As String = "Select * from region where Id_region = '" & txtIdRegion.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "region")
                lista = datos.Tables("region").Rows.Count
                If lista <> 0 Then
                    txtNombreRegion.Text = datos.Tables("region").Rows(0).Item("region")
                    conexion.Close()
                    txtIdRuta.Select()
                Else
                    conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub TxtIdRuta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdRuta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                conexion.Open()
                Dim Consulta As String = "Select * from ruta where Id_ruta = '" & txtIdRuta.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "ruta")
                lista = datos.Tables("ruta").Rows.Count
                If lista <> 0 Then
                    txtNombreRuta.Text = datos.Tables("ruta").Rows(0).Item("ruta")
                    conexion.Close()
                Else
                    conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
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
        If ChkbVendActivo.Checked Then

            agregar = "1"
        Else
            agregar = "0"
        End If
        Try
            conexion.Close()
            If txtIdVendedor.TextLength <> 0 Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from vendedor where Id_vendedor = '" & txtIdVendedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "vendedor")
                lista = datos.Tables("vendedor").Rows.Count
                If lista <> 0 Then
                    MsgBox("La id: " + txtIdVendedor.Text + " ya existe en la base de datos, elija otra")
                    Exit Sub
                End If
                conexion.Close()
                sentencias = "insert into vendedor values ('" + txtIdVendedor.Text + "' , '" + txtnombrevendedor.Text + "' , '" + agregar + "' , '" + txtIdSupervisor.Text + "' , '" + txtIdSubGerente.Text + "' , '" + txtIdRegion.Text + "' , '" + txtIdRuta.Text + "' )"
                mensaje = "Datos ingresados correctamente"
                ejecutarSQL(sentencias, mensaje)
                conexion.Close()
                mostrar()
                Limpiar_TextBox(Me)
                txtIdVendedor.Focus()
                ChkbVendActivo.Checked = False
                conexion.Close()
            End If
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            conexion.Close()
            If txtIdVendedor.Text <> "" Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from vendedor where Id_vendedor = '" & txtIdVendedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "vendedor")
                lista = datos.Tables("vendedor").Rows.Count
                If lista <> 0 Then
                    sentencias = "delete from vendedor where Id_vendedor='" + txtIdVendedor.Text + "' "
                    mensaje = "datos eliminados"
                    avisosalida = MsgBox("Realmente quiere eliminar el registro?", MsgBoxStyle.YesNo, "Advertencia")
                    If avisosalida = 6 Then
                        conexion.Close()
                        ejecutarSQL(sentencias, mensaje)
                        mostrar()
                        conexion.Close()
                    End If
                    conexion.Close()
                Else
                    MsgBox("registro no existente")
                    conexion.Close()
                End If
                conexion.Close()
            Else
                MsgBox("debe rellenar todos los campos")
            End If
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
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
        If ChkbVendActivo.Checked Then

            agregar = "1"
        Else
            agregar = "0"
        End If
        Try
            Dim Consulta As String = "Select * from vendedor where id_vendedor = '" & txtIdVendedor.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "vendedor")
            lista = datos.Tables("vendedor").Rows.Count
            If lista <> 0 Then
                conexion.Close()
                sentencias = "update vendedor set id_vendedor= '" + txtIdVendedor.Text + "',vendedor = '" + txtnombrevendedor.Text + "', vendedor_activo='" + agregar + "', id_supervisor='" + txtIdSupervisor.Text + "', id_subgerente='" + txtIdSubGerente.Text + "', id_region='" + txtIdRegion.Text + "', id_ruta='" + txtIdRuta.Text + "' where id_vendedor='" + txtIdVendedor.Text + "'"
                mensaje = "Datos actualizados correctamente"
                ejecutarSQL(sentencias, mensaje)
                conexion.Close()
                mostrar()
                Limpiar_TextBox(Me)
                txtIdVendedor.Focus()
                ChkbVendActivo.Checked = False
                conexion.Close()
            Else
                MsgBox("la id: " + txtIdVendedor.Text + " , no existe, verifique e intente de nuevo")
            End If

        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            conexion.Close()
            If txtIdVendedor.Text <> "" Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from vendedor where Id_vendedor = '" & txtIdVendedor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "vendedor")
                lista = datos.Tables("vendedor").Rows.Count
                If lista <> 0 Then
                    txtnombrevendedor.Text = datos.Tables("vendedor").Rows(0).Item("vendedor")
                    txtIdSupervisor.Text = datos.Tables("vendedor").Rows(0).Item("id_supervisor")
                    txtIdSubGerente.Text = datos.Tables("vendedor").Rows(0).Item("id_subgerente")
                    txtIdRegion.Text = datos.Tables("vendedor").Rows(0).Item("id_region")
                    txtIdRuta.Text = datos.Tables("vendedor").Rows(0).Item("id_ruta")
                    agregar = datos.Tables("vendedor").Rows(0).Item("vendedor_activo")
                    If agregar = 1 Then
                        ChkbVendActivo.Checked = True
                    Else
                        ChkbVendActivo.Checked = False
                    End If
                    conexion.Close()

                    conexion.Close()
                    conexion.Open()
                    Dim Consulta1 As String = "Select * from supervisor where id_supervisor = '" & txtIdSupervisor.Text & "'"
                    Dim lista1 As Byte
                    Dim datos1 As New DataSet
                    Dim adaptador1 = New SqlDataAdapter(Consulta1, conexion)
                    datos1 = New DataSet
                    adaptador1.Fill(datos1, "supervisor")
                    lista1 = datos1.Tables("supervisor").Rows.Count
                    If lista1 <> 0 Then
                        txtNombreSupervisor.Text = datos1.Tables("supervisor").Rows(0).Item("supervisor")
                    Else
                        MsgBox("no encotrado")
                        conexion.Close()
                    End If
                    conexion.Close()

                    conexion.Open()
                    Dim Consulta2 As String = "Select * from subgerente where id_subgerente = '" & txtIdSubGerente.Text & "'"
                    Dim lista2 As Byte
                    Dim datos2 As New DataSet
                    Dim adaptador2 = New SqlDataAdapter(Consulta2, conexion)
                    datos2 = New DataSet
                    adaptador2.Fill(datos2, "subgerente")
                    lista2 = datos2.Tables("subgerente").Rows.Count
                    If lista2 <> 0 Then
                        txtNombreSubGerente.Text = datos2.Tables("subgerente").Rows(0).Item("subgerente")
                    Else
                        MsgBox("no encotrado")
                        conexion.Close()
                    End If
                    conexion.Close()

                    conexion.Open()
                    Dim Consulta3 As String = "Select * from region where id_region = '" & txtIdRegion.Text & "'"
                    Dim lista3 As Byte
                    Dim datos3 As New DataSet
                    Dim adaptador3 = New SqlDataAdapter(Consulta3, conexion)
                    datos3 = New DataSet
                    adaptador3.Fill(datos3, "region")
                    lista3 = datos3.Tables("region").Rows.Count
                    If lista3 <> 0 Then
                        txtNombreRegion.Text = datos3.Tables("region").Rows(0).Item("region")
                    Else
                        MsgBox("no encotrado")
                        conexion.Close()
                    End If
                    conexion.Close()

                    conexion.Open()
                    Dim Consulta4 As String = "Select * from ruta where id_ruta = '" & txtIdRuta.Text & "'"
                    Dim lista4 As Byte
                    Dim datos4 As New DataSet
                    Dim adaptador4 = New SqlDataAdapter(Consulta4, conexion)
                    datos4 = New DataSet
                    adaptador4.Fill(datos4, "ruta")
                    lista4 = datos4.Tables("ruta").Rows.Count
                    If lista4 <> 0 Then
                        txtNombreRuta.Text = datos4.Tables("ruta").Rows(0).Item("ruta")
                    Else
                        MsgBox("no encotrado")
                        conexion.Close()
                    End If
                    conexion.Close()
                End If
                conexion.Close()
            Else
                MsgBox("La id esta vacia, rellenela e intente de nuevo")
            End If
        Catch
            conexion.Close()
        End Try
    End Sub

    Private Sub TxtIdVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdVendedor.KeyPress, txtIdSupervisor.KeyPress, txtIdSubGerente.KeyPress, txtIdRuta.KeyPress, txtIdRegion.KeyPress
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
    End Sub

    Private Sub TxtIdSubGerente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdSubGerente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                conexion.Open()
                Dim Consulta As String = "Select * from subgerente where Id_subgerente = '" & txtIdSubGerente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "subgerente")
                lista = datos.Tables("subgerente").Rows.Count
                If lista <> 0 Then
                    txtNombreSubGerente.Text = datos.Tables("subgerente").Rows(0).Item("subgerente")
                    conexion.Close()
                    txtIdRegion.Select()
                Else
                    conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub TxtIdSupervisor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdSupervisor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                conexion.Open()
                Dim Consulta As String = "Select * from supervisor where Id_supervisor = '" & txtIdSupervisor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "supervisor")
                lista = datos.Tables("supervisor").Rows.Count
                If lista <> 0 Then
                    txtNombreSupervisor.Text = datos.Tables("supervisor").Rows(0).Item("supervisor")
                    conexion.Close()
                    txtIdSubGerente.Select()
                Else
                    conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub TxtIdVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdVendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtIdSupervisor.Select()
        End If
    End Sub

    Private Sub Maestro_de_vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Limpiar_TextBox(Me)
        Timer1.Start()
    End Sub

    Sub mostrar()
        Dim Dap As New SqlDataAdapter("select * from vendedor", conexion)
        Dim ds As New DataSet
        Try
            Dap.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Sub ejecutarSQL(sql As String, msg As String)
        Try
            conexion.Close()
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
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