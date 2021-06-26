Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports Transitions
Public Class Camara
    Dim con As New SqlConnection(My.Settings.conexionglobal)
    Public sRuta As String
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim a As New OpenFileDialog
    Dim sentencias As String
    Private Sub prueba_a_sql_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSig.Visible = False


        If Usuario.Visible = False Then
            Usuario.Close()
        End If
    End Sub

    Private Sub cmdcamara_Click(sender As Object, e As EventArgs) Handles cmdcamara.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        t.add(PanelCamara, "Left", 23)
        t.add(PanelImagen, "Left", -400)
        t.run()

        Me.WebCam1.Start()
    End Sub

    Private Sub BtnCancelarFoto_Click(sender As Object, e As EventArgs) Handles btnCancelarFoto.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        t.add(PanelCamara, "Left", 480)
        t.add(PanelImagen, "Left", 23)
        t.run()
    End Sub


    Private Sub cmdCapturar_Click(sender As Object, e As EventArgs) Handles cmdCapturar.Click
        If WebCam1.Imagen Is Nothing = True Then
            MessageBox.Show("No hay imagen disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Me.PicFoto.Image = WebCam1.Imagen
                Me.picPrev.Image = WebCam1.Imagen
                PicFoto.Image.Save("IM", ImageFormat.Jpeg)
                Me.WebCam1.Stop()
                WebCam1.Imagen = Nothing
                btnSig.Visible = True
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            End Try
        End If

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
    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        PicFoto.Image = Nothing
        WebCam1.Imagen = Nothing
    End Sub
    Public Sub actualizar()
        con.Close()
        con.Open()
        Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + Main.btnUsuario.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim c As Integer = ds.Tables(0).Rows.Count
        If c > 0 Then
            Dim bytBLOBData() As Byte =
                    ds.Tables(0).Rows(c - 1)("FOTO")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            Main.picfoto.Image = Image.FromStream(stmBLOBData)
            Usuario.fotopic.Image = Image.FromStream(stmBLOBData)
            Me.Hide()
            Main.Show()
        End If
        con.Close()
    End Sub
    Public Sub actualizarfoto()
        con.Close()
        Dim ms As New MemoryStream()
        PicFoto.Image.Save(ms, ImageFormat.Png)
        Dim pic_arr As Byte() = New Byte(ms.Length - 1) {}
        ms.Position = 0
        ms.Read(pic_arr, 0, pic_arr.Length)
        Dim i As Short
        con.Open()
        Using cmd As New SqlClient.SqlCommand("update fotos set foto=@Imagen where Nombreusuario='" + Main.btnUsuario.Text + "'", con)
            cmd.Parameters.AddWithValue("@Imagen", pic_arr)
            i = cmd.ExecuteNonQuery()
        End Using
        con.Close()
        If (i > 0) Then
            MessageBox.Show("Foto actualizada", "DATOS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizar()
        End If
    End Sub
    Private Sub btnGuardarFotoBase_Click(sender As Object, e As EventArgs) Handles btnGuardarFotoBase.Click
        Try
            con.Close()
            con.Open()
            Dim Consulta As String = "Select * from fotos where NombreUsuario = '" & Main.btnUsuario.Text & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, con)
            datos = New DataSet
            adaptador.Fill(datos, "fotos")
            lista = datos.Tables("fotos").Rows.Count
            If lista <> 0 Then
                actualizarfoto()
            Else
                If (PicFoto.Image Is Nothing) Then
                    MsgBox("¡ERROR, ELIGA UNA IMÁGEN!")
                Else
                    Dim ms As New MemoryStream()
                    PicFoto.Image.Save(ms, ImageFormat.Png)
                    Dim pic_arr As Byte() = New Byte(ms.Length - 1) {}
                    ms.Position = 0
                    ms.Read(pic_arr, 0, pic_arr.Length)
                    Dim i As Short
                    con.Close()
                    con.Open()
                    Using cmd As New SqlClient.SqlCommand("INSERT INTO fotos(Nombreusuario, foto) VALUES('" & Main.btnUsuario.Text & "', @Imagen)", con)
                        cmd.Parameters.AddWithValue("@imagen", pic_arr)
                        i = cmd.ExecuteNonQuery()

                    End Using
                    con.Close()
                    If (i > 0) Then
                        MessageBox.Show("¡REGISTRO SE GUARDÓ EXITOSAMENTE!", "DATOS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Main.picfoto.Image = PicFoto.Image
                        Usuario.fotopic.Image = PicFoto.Image
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnGuardarFotoArchivo_Click(sender As Object, e As EventArgs)
        Try
            Dim sFD As New SaveFileDialog
            sFD.Title = "Guardar Imagen"
            sFD.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"
            If sFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.PicFoto.Image.Save(System.IO.Path.GetFullPath(sFD.FileName))
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Dim piclocation As String
            'a.Filter = Nothing
            'piclocation = a.FileName
            'a.ShowDialog()
            'PicFoto.Image = Image.FromFile(a.FileName)
            Dim foto As Image
            Dim piclocation As String
            a.Filter = Nothing
            piclocation = a.FileName
            a.ShowDialog()
            ' PicFoto.Image 
            foto = Image.FromFile(a.FileName)
            Dim imagenOriginal As Bitmap
            Dim imagenRedimensionada As Bitmap
            imagenOriginal = New Bitmap(foto)
            imagenRedimensionada = New Bitmap(256, 256)
            Using gr As Graphics = Graphics.FromImage(imagenRedimensionada)
                gr.DrawImage(imagenOriginal, 0, 0, imagenRedimensionada.Width, imagenRedimensionada.Height)
            End Using
            PicFoto.Image = imagenRedimensionada
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If (WebCam1.Imagen Is Nothing = True) Then
            MessageBox.Show("¡ERROR, EL WEBCAM NO ESTÁ ENCENDIDO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.WebCam1.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.WebCam1.Configuracion()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Usuario.Show()
        'Try
        '    If Usuario.Visible = False Then
        '        Usuario.Close()
        '    End If
        '    con.Open()
        '    Dim Consulta As String = "Select * from usuarios where NombreUsuario = '" & Main.btnUsuario.Text & "'"
        '    Dim lista As Byte
        '    Dim datos As New DataSet
        '    Dim adaptador = New SqlDataAdapter(Consulta, con)
        '    datos = New DataSet
        '    adaptador.Fill(datos, "usuarios")
        '    lista = datos.Tables("usuarios").Rows.Count
        '    If lista <> 0 Then
        '        con.Close()
        '        con.Open()
        '        Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + Main.btnUsuario.Text + "'", con)
        '        Dim ds As New DataSet
        '        da.Fill(ds)
        '        Dim c As Integer = ds.Tables(0).Rows.Count
        '        If c > 0 Then
        '            Dim bytBLOBData() As Byte =
        '                            ds.Tables(0).Rows(c - 1)("FOTO")
        '            Dim stmBLOBData As New MemoryStream(bytBLOBData)
        '            Main.picfoto.Image = Image.FromStream(stmBLOBData)
        '        End If
        '        con.Close()
        '    End If
        'Catch
        'End Try
    End Sub

    Private Sub BtnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        t.add(PanelCamara, "Left", 480)
        t.add(PanelImagen, "Left", 23)
        t.run()
    End Sub
End Class