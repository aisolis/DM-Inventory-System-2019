Imports System.Data.SqlClient
Public Class CuadroDeClientes
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia As String
    Private Sub CuadroDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Timer1.Start()
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtbCliente.Text <> "" And txtbNIT.Text = "" And txtbTelefono.Text = "" Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where cliente = '" & txtbCliente.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    Timer1.Stop()
                    Dim cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from tabla_clientes where cliente='" + txtbCliente.Text + "' "
                    cmd.ExecuteNonQuery()
                    Dim dt As DataTable = New DataTable()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvDatos.DataSource = dt
                    dt.DefaultView.RowFilter = "cliente like '" + txtbCliente.Text + "%'"
                    con.Close()
                Else
                    MsgBox("no existe un cliente con el cliente:" + txtbCliente.Text + " , verifique e intente de nuevo")
                End If

            Catch ex As Exception
                con.Close()
            End Try
        ElseIf txtbCliente.Text = "" And txtbNIT.Text = "" And txtbTelefono.Text <> "" Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where telefono = '" & txtbTelefono.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    con.Open()
                    Timer1.Stop()
                    Dim cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from tabla_clientes where telefono='" + txtbTelefono.Text + "' "
                    cmd.ExecuteNonQuery()
                    Dim dt As DataTable = New DataTable()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvDatos.DataSource = dt
                    dt.DefaultView.RowFilter = "telefono like '" + txtbTelefono.Text + "%'"
                    con.Close()
                Else
                    MsgBox("no existe un cliente con el telefono:" + txtbTelefono.Text + " , verifique e intente de nuevo")
                End If

            Catch ex As Exception
                con.Close()
            End Try
        ElseIf txtbCliente.Text = "" And txtbTelefono.Text = "" And txtbNIT.Text <> "" Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where nit = '" & txtbNIT.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    Timer1.Stop()
                    Dim cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from tabla_clientes where nit='" + txtbNIT.Text + "' "
                    cmd.ExecuteNonQuery()
                    Dim dt As DataTable = New DataTable()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvDatos.DataSource = dt
                    dt.DefaultView.RowFilter = "Nit like '" + txtbNIT.Text + "%'"
                    con.Close()
                Else
                    MsgBox("no existe un cliente con el nit:" + txtbNIT.Text + " , verifique e intente de nuevo")
                End If

            Catch ex As Exception
                con.Close()
            End Try
        ElseIf txtbCliente.Text <> "" And txtbNIT.Text <> "" And txtbTelefono.Text <> "" Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from tabla_clientes where cliente = '" & txtbCliente.Text & "' and nit='" + txtbNIT.Text + "' and telefono='" + txtbTelefono.Text + "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "tabla_clientes")
                lista = datos.Tables("tabla_clientes").Rows.Count
                If lista <> 0 Then
                    Timer1.Stop()
                    Dim cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from tabla_clientes where cliente = '" & txtbCliente.Text & "' and nit='" + txtbNIT.Text + "' and telefono='" + txtbTelefono.Text + "'"
                    cmd.ExecuteNonQuery()
                    Dim dt As DataTable = New DataTable()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvDatos.DataSource = dt
                    dt.DefaultView.RowFilter = "cliente like '" + txtbCliente.Text + "%'"
                    con.Close()

                Else
                    MsgBox("no existe un cliente con el cliente:" + txtbCliente.Text + " , con el nit: " + txtbNIT.Text + ", con el telefono: " + txtbTelefono.Text + ", verifique e intente de nuevo")
                End If

            Catch ex As Exception
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar_TextBox(Me)
        Timer1.Start()
    End Sub
    Public Sub Limpiar_TextBox(ByVal formulario As Form)
        'Recorremos todos los controles del formulario que enviamos  
        For Each control As Control In formulario.Controls
            'Filtramos solo aquellos de tipo TextBox 
            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto  
            End If
        Next
        mostrar()
    End Sub

    Private Sub TxtbNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbTelefono.KeyPress, txtbNIT.KeyPress
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

    Private Sub TxtbCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbNIT.Select()
        End If
    End Sub

    Private Sub TxtbNIT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbNIT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtbTelefono.Select()
        End If
    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mostrar()
    End Sub

    Sub mostrar()
        Dim Dap As New SqlDataAdapter("select * from tabla_clientes", con)
        Dim ds As New DataSet
        Try
            Dap.Fill(ds)
            dgvDatos.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class
