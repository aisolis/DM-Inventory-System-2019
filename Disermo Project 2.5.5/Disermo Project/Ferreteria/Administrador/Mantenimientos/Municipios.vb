Imports System.Data.SqlClient
Public Class Municipios
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, tvip, bloqueo, avisosalida As String

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        con.Close()
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
            If txtidmunicipio.TextLength <> 0 Then
                con.Open()
                Dim Consulta As String = "Select * from ruta where id_ruta = '" & txtidmunicipio.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "ruta")
                lista = datos.Tables("ruta").Rows.Count
                If lista <> 0 Then
                    MsgBox("La Id: " + txtidmunicipio.Text + " ya existe en la base de datos, elija otra e intentelo de nuevo")
                    Exit Sub
                End If

                If chkbactivo.Checked = True Then
                    tvip = 1
                Else
                    tvip = 0
                End If
                sentencia = "insert into municipio values('" + txtidmunicipio.Text + "','" + txtmunicipio.Text + "','" + txtiddepartamento.Text + "','" + txtidurta.Text + "','" + txtsubruta.Text + "','" + tvip + "')"
                mensaje = "Datos insertados correctamente"
                con.Close()
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                chkbactivo.Checked = False
                mostrar()
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If txtidmunicipio.TextLength <> 0 Then
                con.Open()
                Dim Consulta As String = "Select * from municipio where id_municipio = '" & txtidmunicipio.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "municipio")
                lista = datos.Tables("municipio").Rows.Count
                If lista <> 0 Then
                    sentencia = " delete from municipio where id_municipio='" + txtidmunicipio.Text + "' "
                    mensaje = "datos eliminados"
                    avisosalida = MsgBox("¨Realmente quiere eliminar el registro?", MsgBoxStyle.YesNo, "Advertencia")

                    If avisosalida = 6 Then
                        con.Close()
                        ejecutarSQL(sentencia, mensaje)
                        Limpiar_TextBox(Me)
                        chkbactivo.Checked = False
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

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from municipio where id_municipio = '" & txtidmunicipio.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "municipio")
            lista = datos.Tables("municipio").Rows.Count
            If lista <> 0 Then
                txtmunicipio.Text = datos.Tables("municipio").Rows(0).Item("municipio")
                txtiddepartamento.Text = datos.Tables("municipio").Rows(0).Item("id_departamento")
                txtidurta.Text = datos.Tables("municipio").Rows(0).Item("id_ruta")
                txtidsubruta.Text = datos.Tables("municipio").Rows(0).Item("id_subruta")
                tvip = datos.Tables("municipio").Rows(0).Item("estado_activo")
                If tvip = 1 Then
                    chkbactivo.Checked = True
                Else
                    chkbactivo.Checked = False
                End If
                con.Close()
            End If
            con.Close()

            con.Close()
            con.Open()
            Dim Consulta1 As String = "Select * from departamento where id_departamento = '" & txtiddepartamento.Text & "'"
            Dim lista1 As Byte
            Dim datos1 As New DataSet
            Dim adaptador1 = New SqlDataAdapter(Consulta1, con)
            datos1 = New DataSet
            adaptador1.Fill(datos1, "departamento")
            lista1 = datos1.Tables("departamento").Rows.Count
            If lista1 <> 0 Then
                txtdepartamento.Text = datos1.Tables("departamento").Rows(0).Item("departamento")
            Else
                MsgBox("no encotrado")
                con.Close()
            End If
            con.Close()

            con.Open()
            Dim Consulta2 As String = "Select * from ruta where id_ruta = '" & txtidurta.Text & "'"
            Dim lista2 As Byte
            Dim datos2 As New DataSet
            Dim adaptador2 = New SqlDataAdapter(Consulta2, con)
            datos2 = New DataSet
            adaptador2.Fill(datos2, "ruta")
            lista2 = datos2.Tables("ruta").Rows.Count
            If lista2 <> 0 Then
                txtruta.Text = datos2.Tables("ruta").Rows(0).Item("ruta")
            Else
                MsgBox("no encotrado")
                con.Close()
            End If
            con.Close()

            con.Open()
            Dim Consulta3 As String = "Select * from subruta where id_subruta = '" & txtidsubruta.Text & "'"
            Dim lista3 As Byte
            Dim datos3 As New DataSet
            Dim adaptador3 = New SqlDataAdapter(Consulta3, con)
            datos3 = New DataSet
            adaptador3.Fill(datos3, "subruta")
            lista3 = datos3.Tables("subruta").Rows.Count
            If lista3 <> 0 Then
                txtsubruta.Text = datos3.Tables("subruta").Rows(0).Item("subruta")
            Else
                MsgBox("no encotrado")
                con.Close()
            End If
            con.Close()

        Catch
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
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
            Dim Consulta As String = "Select * from municipio where id_municipio = '" & txtidmunicipio.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "municipio")
            lista = datos.Tables("municipio").Rows.Count
            If lista <> 0 Then
                con.Close()
                If chkbactivo.Checked = True Then
                    tvip = 1
                Else
                    tvip = 0
                End If
                sentencia = "update municipio set id_municipio='" + txtidmunicipio.Text + "',municipio='" + txtmunicipio.Text + "',id_departamento='" + txtiddepartamento.Text + "',id_ruta='" + txtidurta.Text + "',id_subruta='" + txtsubruta.Text + "',estado_activo='" + tvip + "' where id_municipio='" + txtidmunicipio.Text + "'"
                mensaje = "actualizado correctamente"
                con.Close()
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                chkbactivo.Checked = False
                mostrar()
                con.Close()
            Else
                MsgBox("la id: " + txtidmunicipio.Text + ", no existe, verifique e intente de nuevo")
            End If

        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub Txtiddepartamento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtiddepartamento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select departamento from departamento where Id_Departamento = '" & txtiddepartamento.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "departamento")
                lista = datos.Tables("departamento").Rows.Count
                If lista <> 0 Then
                    txtdepartamento.Text = datos.Tables("departamento").Rows(0).Item("departamento")
                    con.Close()
                    txtidurta.Select()
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
                con.Open()
                Dim Consulta As String = "Select subruta from subruta where Id_subruta = '" & txtidsubruta.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "subruta")
                lista = datos.Tables("subruta").Rows.Count
                If lista <> 0 Then
                    txtsubruta.Text = datos.Tables("subruta").Rows(0).Item("subruta")
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

    Private Sub Txtidurta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidurta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Open()
                Dim Consulta As String = "Select ruta from ruta where Id_ruta = '" & txtidurta.Text & "'"
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

    Private Sub Txtidmunicipio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidmunicipio.KeyPress, txtidurta.KeyPress, txtidsubruta.KeyPress, txtiddepartamento.KeyPress
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

    Private Sub Txtidmunicipio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidmunicipio.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmunicipio.Select()
        End If
    End Sub

    Private Sub Txtmunicipio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmunicipio.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtiddepartamento.Select()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
    End Sub
    Private Sub Municipios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        mostrar()
        Limpiar_TextBox(Me)
    End Sub
    Sub mostrar()
        Dim Dap As New SqlDataAdapter("select * from municipio", con)
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
End Class