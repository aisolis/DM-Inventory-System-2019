Imports System.Data.SqlClient
Public Class Maestro_de_usuarios
    Dim conexion As New SqlConnection(My.Settings.conexionglobal)
    Dim sentencias, mensaje, estado, avisosalida, agregar, eliminar, modificar, imprimir As String

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            conexion.Close()
            If idusuario.Text <> "" Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from usuarios where Id_usuario = '" & idusuario.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "usuarios")
                lista = datos.Tables("usuarios").Rows.Count
                If lista <> 0 Then
                    sentencias = "delete from usuarios where Id_usuario='" + idusuario.Text + "' "
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

    Private Sub Idperfil_KeyDown(sender As Object, e As KeyEventArgs) Handles idperfil.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                conexion.Open()
                Dim Consulta As String = "Select * from perfil where Id_perfil = '" & idperfil.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "perfil")
                lista = datos.Tables("perfil").Rows.Count
                If lista <> 0 Then
                    txtperfil.Text = datos.Tables("perfil").Rows(0).Item("perfil")
                    conexion.Close()
                    correo.Select()
                Else
                    conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub Idusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idusuario.KeyPress, idperfil.KeyPress, txttelefono.KeyPress
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

    Private Sub Idusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles idusuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtusuario.Select()
        End If
    End Sub

    Private Sub Txtusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Select()
        End If
    End Sub

    Private Sub Txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            idperfil.Select()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
    End Sub

    Private Sub correo_KeyDown(sender As Object, e As KeyEventArgs) Handles correo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttelefono.Select()
        End If
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            conexion.Close()
            If idusuario.Text <> "" Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from usuarios where Id_usuario = '" & idusuario.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "usuarios")
                lista = datos.Tables("usuarios").Rows.Count
                If lista <> 0 Then
                    txtusuario.Text = datos.Tables("usuarios").Rows(0).Item("NombreUsuario")
                    txtpassword.Text = datos.Tables("usuarios").Rows(0).Item("contraseña")
                    correo.Text = datos.Tables("usuarios").Rows(0).Item("coreo")
                    txttelefono.Text = datos.Tables("usuarios").Rows(0).Item("telefono")
                    idperfil.Text = datos.Tables("usuarios").Rows(0).Item("Id_Perfil")
                    agregar = datos.Tables("usuarios").Rows(0).Item("ingresar")
                    eliminar = datos.Tables("usuarios").Rows(0).Item("eliminar")
                    modificar = datos.Tables("usuarios").Rows(0).Item("modificar")
                    imprimir = datos.Tables("usuarios").Rows(0).Item("imprimir")
                    If agregar = 1 Then
                        chkbingresar.Checked = True
                    Else
                        chkbingresar.Checked = False
                    End If
                    If eliminar = 1 Then
                        chkbeliminar.Checked = True
                    Else
                        chkbeliminar.Checked = False
                    End If
                    If modificar = 1 Then
                        chkbmodificar.Checked = True
                    Else
                        chkbmodificar.Checked = False
                    End If
                    If imprimir = 1 Then
                        chkbimprimir.Checked = True
                    Else
                        chkbimprimir.Checked = False
                    End If
                    conexion.Close()

                    conexion.Open()
                    Dim Consulta2 As String = "Select * from perfil where id_perfil = '" & idperfil.Text & "'"
                    Dim lista2 As Byte
                    Dim datos2 As New DataSet
                    Dim adaptador2 = New SqlDataAdapter(Consulta2, conexion)
                    datos2 = New DataSet
                    adaptador2.Fill(datos2, "perfil")
                    lista2 = datos2.Tables("perfil").Rows.Count
                    If lista2 <> 0 Then
                        txtperfil.Text = datos2.Tables("perfil").Rows(0).Item("perfil")
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
        If chkbingresar.Checked Then

            agregar = "1"
        Else
            agregar = "0"
        End If
        If chkbeliminar.Checked Then

            eliminar = "1"
        Else
            eliminar = "0"
        End If
        If chkbmodificar.Checked Then

            modificar = "1"
        Else
            modificar = "0"
        End If
        If chkbimprimir.Checked Then

            imprimir = "1"
        Else
            imprimir = "0"
        End If
        Try
            Dim Consulta As String = "Select * from usuarios where id_usuario = '" & idusuario.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            lista = datos.Tables("usuarios").Rows.Count
            If lista <> 0 Then
                conexion.Close()
                sentencias = "update usuarios set id_usuario= '" + idusuario.Text + "',NombreUsuario = '" + txtusuario.Text + "',correo = '" + correo.Text + "',telefono = '" + txttelefono.Text + "', contraseña='" + txtpassword.Text + "', Id_Perfil='" + idperfil.Text + "', ingresar='" + agregar + "', modificar='" + modificar + "', eliminar='" + eliminar + "', imprimir='" + imprimir + "' where id_usuario='" + idusuario.Text + "'"
                mensaje = "Datos actualizados correctamente"
                ejecutarSQL(sentencias, mensaje)
                conexion.Close()
                mostrar()
                Limpiar_TextBox(Me)
                idusuario.Focus()
                chkbimprimir.Checked = False
                chkbeliminar.Checked = False
                chkbingresar.Checked = False
                chkbmodificar.Checked = False
                conexion.Close()
            Else
                MsgBox("la id: " + idusuario.Text + " , no existe, verifique e intente de nuevo")
            End If
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Private Sub Maestro_de_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Limpiar_TextBox(Me)
        Timer1.Start()
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
        If chkbingresar.Checked Then

            agregar = "1"
        Else
            agregar = "0"
        End If
        If chkbeliminar.Checked Then

            eliminar = "1"
        Else
            eliminar = "0"
        End If
        If chkbmodificar.Checked Then

            modificar = "1"
        Else
            modificar = "0"
        End If
        If chkbimprimir.Checked Then

            imprimir = "1"
        Else
            imprimir = "0"
        End If

        Try
            conexion.Close()
            If idusuario.TextLength <> 0 Then
                conexion.Close()
                conexion.Open()
                Dim Consulta As String = "Select * from usuarios where Id_Usuario = '" & idusuario.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "usuarios")
                lista = datos.Tables("usuarios").Rows.Count
                If lista <> 0 Then
                    MsgBox("La id: " + idusuario.Text + " ya existe en la base de datos, elija otra")
                    Exit Sub
                End If
                conexion.Close()
                conexion.Open()
                Dim Consulta2 As String = "Select * from usuarios where NombreUsuario='" + txtusuario.Text + "'"
                Dim lista2 As Byte
                Dim datos2 As New DataSet
                Dim adaptador2 = New SqlDataAdapter(Consulta2, conexion)
                datos2 = New DataSet
                adaptador2.Fill(datos2, "usuarios")
                lista2 = datos2.Tables("usuarios").Rows.Count
                If lista2 <> 0 Then
                    MsgBox("El usuario: " + txtusuario.Text + " ya existe en la base de datos, elija otro")
                    Exit Sub
                End If

                conexion.Close()
                sentencias = "insert into usuarios values ('" + idusuario.Text + "' , '" + txtusuario.Text + "' , '" + txtpassword.Text + "' , '" + correo.Text + "' , '" + txttelefono.Text + "' , '" + idperfil.Text + "' , '" + agregar + "' , '" + eliminar + "' , '" + modificar + "' , '" + imprimir + "' , '" + "Null" + "' )"
                mensaje = "Datos ingresados correctamente"
                ejecutarSQL(sentencias, mensaje)
                conexion.Close()
                mostrar()
                Limpiar_TextBox(Me)
                idusuario.Focus()
                chkbimprimir.Checked = False
                chkbeliminar.Checked = False
                chkbingresar.Checked = False
                chkbmodificar.Checked = False
                conexion.Close()
            End If
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub mostrar()
        Dim Dap As New SqlDataAdapter("select * from usuarios", conexion)
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