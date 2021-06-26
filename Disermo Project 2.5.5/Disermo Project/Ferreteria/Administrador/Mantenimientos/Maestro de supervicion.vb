Imports System.Data.SqlClient
Public Class Maestro_de_supervicion_
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, tvip, bloqueo, avisosalida As String

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
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
            If txtidsupervisor.TextLength <> 0 Then
                con.Open()
                Dim Consulta As String = "Select * from supervisor where Id_supervisor = '" & txtidsupervisor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "supervisor")
                lista = datos.Tables("supervisor").Rows.Count
                If lista <> 0 Then
                    MsgBox("La Id: " + txtidsupervisor.Text + " ya existe en la base de datos, elija otra e intentelo de nuevo")
                    Exit Sub
                End If

                If chkbSupervisorActivo.Checked = True Then
                    tvip = 1
                Else
                    tvip = 0
                End If
                sentencia = "insert into supervisor values('" + txtidsupervisor.Text + "','" + txtnombresup.Text + "','" + txtmetadeventas.Text + "','" + tvip + "')"
                mensaje = "Datos insertados correctamente"
                con.Close()
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                chkbSupervisorActivo.Checked = False
                mostrar()
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
            Dim Consulta As String = "Select * from supervisor where Id_supervisor = '" & txtidsupervisor.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "supervisor")
            lista = datos.Tables("supervisor").Rows.Count
            If lista <> 0 Then
                con.Close()
                If chkbSupervisorActivo.Checked = True Then
                    tvip = 1
                Else
                    tvip = 0
                End If
                sentencia = "update supervisor set Id_supervisor='" + txtidsupervisor.Text + "',supervisor='" + txtnombresup.Text + "',meta='" + txtmetadeventas.Text + "',super_activo='" + tvip + "' where id_supervisor='" + txtidsupervisor.Text + "'"
                mensaje = "actualizado correctamente"
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                chkbSupervisorActivo.Checked = False
                mostrar()
                con.Close()
            Else
                MsgBox("la id: " + txtidsupervisor.Text + " , no existe, verifique e intente de nuevo")
            End If

        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from supervisor where Id_supervisor = '" & txtidsupervisor.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "supervisor")
            lista = datos.Tables("supervisor").Rows.Count
            If lista <> 0 Then
                txtnombresup.Text = datos.Tables("supervisor").Rows(0).Item("supervisor")
                txtmetadeventas.Text = datos.Tables("supervisor").Rows(0).Item("meta")
                tvip = datos.Tables("supervisor").Rows(0).Item("super_activo")
                If tvip = 1 Then
                    chkbSupervisorActivo.Checked = True
                Else
                    chkbSupervisorActivo.Checked = False
                End If
                con.Close()

            End If
            con.Close()
        Catch
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If txtidsupervisor.TextLength <> 0 Then
                con.Open()
                Dim Consulta As String = "Select * from supervisor where Id_supervisor = '" & txtidsupervisor.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "supervisor")
                lista = datos.Tables("supervisor").Rows.Count
                If lista <> 0 Then
                    sentencia = " delete from supervisor where Id_supervisor='" + txtidsupervisor.Text + "' "
                    mensaje = "datos eliminados"
                    avisosalida = MsgBox("¨Realmente quiere eliminar el registro?", MsgBoxStyle.YesNo, "Advertencia")

                    If avisosalida = 6 Then
                        con.Close()
                        ejecutarSQL(sentencia, mensaje)
                        Limpiar_TextBox(Me)
                        chkbSupervisorActivo.Checked = False
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

    Private Sub Txtidsupervisor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidsupervisor.KeyPress, txtmetadeventas.KeyPress
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

    Private Sub Txtidsupervisor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidsupervisor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnombresup.Select()
        End If
    End Sub

    Private Sub Txtnombresup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombresup.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmetadeventas.Select()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
    End Sub

    Private Sub Maestro_de_supervicion__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Limpiar_TextBox(Me)
        Timer1.Start()
    End Sub
    Sub mostrar()
        Dim Dap As New SqlDataAdapter("select * from supervisor", con)
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