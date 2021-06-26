Imports System.Data.SqlClient
Public Class Consulta_de_Proveedores
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia As String
    Private Sub Consulta_de_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Timer1.Start()
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
    Public Sub Limpiar_TextBox(ByVal formulario As Form)
        'Recorremos todos los controles del formulario que enviamos  
        For Each control As Control In formulario.Controls
            'Filtramos solo aquellos de tipo TextBox 
            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto  
            End If
        Next
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar_TextBox(Me)
        Timer1.Start()
    End Sub

    Private Sub TxtbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbProveedor.KeyPress
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            con.Open()
            Dim Consulta As String = "Select * from proveedor where id_proveedor = '" & txtbProveedor.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "proveedor")
            lista = datos.Tables("proveedor").Rows.Count
            If lista <> 0 Then
                con.Open()
                Timer1.Stop()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from proveedor where id_proveedor='" + txtbProveedor.Text + "' "
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                dt.DefaultView.RowFilter = "id_proveedor like '" + txtbProveedor.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe un proveedor con el codigo:" + txtbProveedor.Text + " , verifique e intente de nuevo")
            End If

        Catch ex As Exception
            con.Close()
        End Try
    End Sub
End Class