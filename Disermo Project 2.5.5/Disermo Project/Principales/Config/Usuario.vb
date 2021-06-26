Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Usuario
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Dim sentecia As String
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Camara.Visible = False Then
                Camara.Close()
            End If
            con.Open()
            Dim Consulta As String = "Select * from usuarios where NombreUsuario = '" & Main.btnUsuario.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            lista = datos.Tables("usuarios").Rows.Count
            If lista <> 0 Then
                lblNombre.Text = datos.Tables("usuarios").Rows(0).Item("NombreUsuario")
                Dim xd As String = datos.Tables("usuarios").Rows(0).Item("id_perfil")
                If xd = "1" Then
                    lblpuesto.Text = "Perfil: Administrador"
                ElseIf xd = "2" Then
                    lblpuesto.Text = "Perfil: Vendedor"
                Else
                    lblpuesto.Text = "Perfil: Invitado"
                End If
                lblcorreo.Text = "Correo: " + datos.Tables("usuarios").Rows(0).Item("correo")
                txttel.Text = "Tel: " + datos.Tables("usuarios").Rows(0).Item("telefono")
                con.Close()
                con.Open()
                Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + lblNombre.Text + "'", con)
                Dim ds As New DataSet
                da.Fill(ds)
                Dim c As Integer = ds.Tables(0).Rows.Count
                If c > 0 Then
                    Dim bytBLOBData() As Byte =
                                    ds.Tables(0).Rows(c - 1)("FOTO")
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    fotopic.Image = Image.FromStream(stmBLOBData)
                End If
                con.Close()
            End If
        Catch
        End Try


    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Close()
    End Sub
    Sub ejecutarSQL(sql As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Configuración.StartPosition = FormStartPosition.CenterScreen
        Configuración.TopMost = True
        Configuración.Show()
        Main.Enabled = False
        Configuración.tbpgConfig.SelectedIndex = 2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sentecia = "insert into ultimasesion values('" + Main.btnUsuario.Text + "')"
        ejecutarSQL(sentecia)
        Me.Close()
        Ingreso.Show()
        Main.Hide()

    End Sub

    Private Sub lblguardar_Click(sender As Object, e As EventArgs)
        Camara.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Camara.Show()
        Me.Hide()
    End Sub
End Class