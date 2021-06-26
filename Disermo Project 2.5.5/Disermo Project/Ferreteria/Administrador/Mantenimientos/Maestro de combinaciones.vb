Imports System.Data.SqlClient
Public Class Maestro_de_combinaciones
    Dim conexion As New SqlConnection(My.Settings.conexionglobal)
    Dim sentencias, mensaje, estado, avisosalida As String
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
        Dim Dap As New SqlDataAdapter("select * from combinaciones", conexion)
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
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnreporte_Click(sender As Object, e As EventArgs)
        My.Settings.code = txtidcombinacion.Text
        reporte_tabla_combinaciones.Show()
    End Sub

    Private Sub Txtidcombinacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidcombinacion.KeyPress, txtcantidad.KeyPress
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
        If chkbestado.Checked Then

            chkbestado.Text = "1"
        Else
            chkbestado.Text = "0"
        End If
        Try
            conexion.Close()
            If txtidcombinacion.TextLength <> 0 Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from combinaciones where Id_combinacion = '" & txtidcombinacion.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "combinaciones")
                lista = datos.Tables("combinaciones").Rows.Count
                If lista <> 0 Then
                    MsgBox("La id: " + txtidcombinacion.Text + " ya existe en la base de datos, elija otra")
                    Exit Sub
                End If
                conexion.Close()
                sentencias = "insert into combinaciones values ('" + txtidcombinacion.Text + "' , '" + txtcombinacion.Text + "' , '" + txtcantidad.Text + "' , '" + chkbestado.Text + "' )"
                mensaje = "Datos ingresados correctamente"
                ejecutarSQL(sentencias, mensaje)
                conexion.Close()
                mostrar()
                Limpiar_TextBox(Me)
                txtidcombinacion.Focus()
                conexion.Close()
            End If
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
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
        If chkbestado.Checked Then

            estado = "1"
        Else
            estado = "0"
        End If
        Try
            Dim Consulta As String = "Select * from combinaciones where Id_combinacion = '" & txtidcombinacion.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "combinaciones")
            lista = datos.Tables("combinaciones").Rows.Count
            If lista <> 0 Then
                conexion.Close()
                sentencias = "update combinaciones set id_combinacion= '" + txtidcombinacion.Text + "',combinacion = '" + txtcombinacion.Text + "', cantidad='" + txtcantidad.Text + "', estado='" + estado + "' where id_combinacion='" + txtidcombinacion.Text + "'"
                mensaje = "Datos actualizados correctamente"
                ejecutarSQL(sentencias, mensaje)
                mostrar()
                Limpiar_TextBox(Me)
                txtidcombinacion.Focus()
                conexion.Close()
            Else
                MsgBox("la id: " + txtidcombinacion.Text + " , no existe, verifique e intente de nuevo")
            End If

        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Private Sub Txtidcombinacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidcombinacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Select()
        End If
    End Sub

    Private Sub Btnreporte_Click_1(sender As Object, e As EventArgs) Handles btnreporte.Click
        reporte_tabla_combinaciones.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            conexion.Close()
            If txtidcombinacion.Text <> "" Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from combinaciones where Id_combinacion = '" & txtidcombinacion.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "combinaciones")
                lista = datos.Tables("combinaciones").Rows.Count
                If lista <> 0 Then
                    txtcombinacion.Text = datos.Tables("combinaciones").Rows(0).Item("combinacion")
                    txtcantidad.Text = datos.Tables("combinaciones").Rows(0).Item("cantidad")
                    estado = datos.Tables("combinaciones").Rows(0).Item("estado")
                    If estado = 1 Then
                        chkbestado.Checked = True
                    Else
                        chkbestado.Checked = False
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

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            conexion.Close()
            If txtidcombinacion.TextLength <> 0 Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from combinaciones where Id_combinacion = '" & txtidcombinacion.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "combinaciones")
                lista = datos.Tables("combinaciones").Rows.Count
                If lista <> 0 Then
                    sentencias = " delete from combinaciones where Id_combinacion='" + txtidcombinacion.Text + "' "
                    mensaje = "datos eliminados"
                    avisosalida = MsgBox("¨Realmente quiere eliminar el registro?", MsgBoxStyle.YesNo, "Advertencia")
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

    Private Sub Maestro_de_combinaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Timer1.Start()
        Limpiar_TextBox(Me)
    End Sub
End Class