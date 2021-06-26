Imports System.Data.SqlClient
Public Class Busqueda_de_clientes
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia As String
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            con.Open()
            Dim Consulta As String = "Select * from tabla_clientes where nit = '" & txtNit.Text & "'"
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
                cmd.CommandText = "select * from tabla_clientes where nit='" + txtNit.Text + "' "
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable()
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                dt.DefaultView.RowFilter = "Nit like '" + txtNit.Text + "%'"
                con.Close()
            Else
                MsgBox("no existe un cliente con el nit:" + txtNit.Text + " , verifique e intente de nuevo")
            End If

        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub Busqueda_de_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
    End Sub
    Private Sub TxtNit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNit.KeyPress
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Sub mostrar()
        Dim Dap As New SqlDataAdapter("select * from tabla_clientes", con)
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