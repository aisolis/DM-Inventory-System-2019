Imports System.Data.SqlClient
Public Class Cuadro_de_productos
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia As String
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtCodigo.Text <> "" And txtDescripcion.Text = "" Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from productos where id_producto = '" & txtCodigo.Text & "'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "productos")
                lista = datos.Tables("productos").Rows.Count
                If lista <> 0 Then
                    Timer1.Stop()
                    Dim cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from productos where id_producto='" + txtCodigo.Text + "' "
                    cmd.ExecuteNonQuery()
                    Dim dt As DataTable = New DataTable()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                    dt.DefaultView.RowFilter = "id_producto like '" + txtCodigo.Text + "%'"
                    con.Close()
                Else
                    MsgBox("no existe un cliente con el id_producto:" + txtCodigo.Text + " , verifique e intente de nuevo")
                End If

            Catch ex As Exception
                con.Close()
            End Try
        ElseIf txtCodigo.Text = "" And txtDescripcion.Text <> "" Then
            Try
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from productos where descripcion like'%" + txtDescripcion.Text + "'%"
                cmd.ExecuteNonQuery()
                Timer1.Stop()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                dt.DefaultView.RowFilter = "descripcion like '" + txtDescripcion.Text + "%'"
                con.Close()
            Catch ex As Exception
                con.Close()
            End Try
        ElseIf txtCodigo.Text <> "" And txtDescripcion.Text <> "" Then
            Try
                con.Close()
                con.Open()
                Dim Consulta As String = "Select * from productos where id_producto = '" & txtCodigo.Text & "' and descripcion like'%" + txtDescripcion.Text + "%'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, con)
                datos = New DataSet
                adaptador.Fill(datos, "productos")
                lista = datos.Tables("productos").Rows.Count
                If lista <> 0 Then
                    Dim cmd As SqlCommand = con.CreateCommand()
                    Timer1.Stop()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from productos where id_producto = '" & txtCodigo.Text & "' and descripcion like'%" + txtDescripcion.Text + "%'"
                    cmd.ExecuteNonQuery()
                    Dim dt As DataTable = New DataTable()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                    dt.DefaultView.RowFilter = "id_producto like '%" + txtCodigo.Text + "%' and descripcion like'%" + txtDescripcion.Text + "%'"
                    con.Close()
                Else
                    MsgBox("no existe un cliente con el id_producto:" + txtCodigo.Text + " , y la descripcion: " + txtDescripcion.Text + " verifique e intente de nuevo")
                End If

            Catch ex As Exception
                con.Close()
            End Try
        End If

    End Sub

    Private Sub Cuadro_de_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        mostrar()
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

    Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
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