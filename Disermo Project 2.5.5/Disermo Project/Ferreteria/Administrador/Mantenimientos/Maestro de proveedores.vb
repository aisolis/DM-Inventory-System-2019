Imports System.Data.SqlClient
Public Class Maestro_de_proveedores
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia, importada, avisosalida As String
    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtCodigoProv.Text <> "" Then
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
                Dim Consulta As String = "Select * from proveedor where Id_proveedor = '" & txtCodigoProv.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "proveedor")
                lista = datos.Tables("proveedor").Rows.Count
                If lista <> 0 Then
                    MsgBox("La Id: " + txtCodigoProv.Text + " ya existe en la base de datos, elija otra e intentelo de nuevo")
                    Exit Sub
                End If

                If ChkbImportador.Checked = True Then
                    importada = 1
                Else
                    importada = 0
                End If
                con.Close()
                sentencia = "insert into proveedor values('" + txtCodigoProv.Text + "','" + txtnombre.Text + "','" + txtDireccion.Text + "','" + txttelefono.Text + "','" + txtnit.Text + "','" + txtDiasCredito.Text + "','" + txtEmail.Text + "','" + txtcontacto.Text + "','" + txtCel2.Text + "','" + importada + "','" + txtDiasTramite.Text + "')"
                mensaje = "Datos insertados correctamente"
                ejecutarSQL(sentencia, mensaje)
                Limpiar_TextBox(Me)
                ChkbImportador.Checked = False
                mostrar()
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try
        Else
            MsgBox("algun campo esta vacio, por favor rellenelo e intente de nuevo")
        End If
    End Sub

    Private Sub Maestro_de_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Limpiar_TextBox(Me)
        Timer1.Start()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtCodigoProv.Text <> "" Then
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
                Dim Consulta As String = "Select * from proveedor where Id_proveedor = '" & txtCodigoProv.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "proveedor")
                lista = datos.Tables("proveedor").Rows.Count
                If lista <> 0 Then
                    If ChkbImportador.Checked = True Then
                        importada = 1
                    Else
                        importada = 0
                    End If
                    con.Close()
                    sentencia = "update proveedor set Id_proveedor='" + txtCodigoProv.Text + "',proveedor='" + txtnombre.Text + "',direccion='" + txtDireccion.Text + "',telefonos='" + txttelefono.Text + "',nit='" + txtnit.Text + "',dias_credito='" + txtDiasCredito.Text + "', email='" + txtEmail.Text + "', contacto='" + txtcontacto.Text + "', celular='" + txtCel2.Text + "', importada='" + importada + "', dias_tramite='" + txtDiasTramite.Text + "' where id_proveedor='" + txtCodigoProv.Text + "'"
                    mensaje = "Datos actualizados correctamente"
                    ejecutarSQL(sentencia, mensaje)
                    Limpiar_TextBox(Me)
                    mostrar()
                    ChkbImportador.Checked = False
                    con.Close()
                Else
                    MsgBox("la id: " + txtCodigoProv.Text + " , no existe, verifique e intente de nuevo")
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
            If txtCodigoProv.Text <> "" Then
                con.Open()
                Dim Consulta As String = "Select * from proveedor where Id_proveedor = '" & txtCodigoProv.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "proveedor")
                lista = datos.Tables("proveedor").Rows.Count
                If lista <> 0 Then
                    con.Close()
                    sentencia = " delete from proveedor where Id_proveedor='" + txtCodigoProv.Text + "' "
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

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            con.Close()
            con.Open()
            If txtCodigoProv.Text <> "" Then
                Dim Consulta As String = "Select * from proveedor where id_proveedor = '" & txtCodigoProv.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "proveedor")
                lista = datos.Tables("proveedor").Rows.Count
                If lista <> 0 Then
                    txtnombre.Text = datos.Tables("proveedor").Rows(0).Item("proveedor")
                    txtDireccion.Text = datos.Tables("proveedor").Rows(0).Item("direccion")
                    txttelefono.Text = datos.Tables("proveedor").Rows(0).Item("telefonos")
                    txtnit.Text = datos.Tables("proveedor").Rows(0).Item("nit")
                    txtDiasCredito.Text = datos.Tables("proveedor").Rows(0).Item("dias_credito")
                    txtEmail.Text = datos.Tables("proveedor").Rows(0).Item("email")
                    txtcontacto.Text = datos.Tables("proveedor").Rows(0).Item("contacto")
                    txtCel2.Text = datos.Tables("proveedor").Rows(0).Item("celular")
                    importada = datos.Tables("proveedor").Rows(0).Item("importada")
                    txtDiasTramite.Text = datos.Tables("proveedor").Rows(0).Item("dias_tramite")
                    If importada = 1 Then
                        ChkbImportador.Checked = True
                    Else
                        ChkbImportador.Checked = False
                    End If
                Else
                    con.Close()
                    MsgBox("no existe")
                End If
            End If
        Catch
            con.Close()
        End Try
    End Sub

    Private Sub TxtCodigoProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoProv.KeyPress, txttelefono.KeyPress, txtnit.KeyPress, txtDiasTramite.KeyPress, txtDiasCredito.KeyPress, txtcontacto.KeyPress, txtCel2.KeyPress
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

    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            Exit Sub
        End If
        Try
            Dim mail As New System.Net.Mail.MailAddress(txtEmail.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtEmail.Focus()
            txtEmail.SelectAll()
        End Try
    End Sub

    Private Sub TxtCodigoProv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoProv.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnombre.Select()
        End If
    End Sub

    Private Sub Txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDireccion.Select()
        End If
    End Sub

    Private Sub TxtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttelefono.Select()
        End If
    End Sub

    Private Sub Txttelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txttelefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtnit.Select()
        End If
    End Sub

    Private Sub Txtnit_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDiasCredito.Select()
        End If
    End Sub

    Private Sub TxtDiasCredito_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiasCredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmail.Select()
        End If
    End Sub

    Private Sub TxtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcontacto.Select()
        End If
    End Sub

    Private Sub Txtcontacto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontacto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCel2.Select()
        End If
    End Sub

    Private Sub TxtCel2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCel2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDiasTramite.Select()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
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
        Dim Dap As New SqlDataAdapter("select * from proveedor", con)
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