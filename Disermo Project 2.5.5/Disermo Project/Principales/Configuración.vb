Imports System.Web.Mail
Imports System.Data.SqlClient
Public Class Configuración
    Dim conexion As New SqlConnection(My.Settings.conexionglobal)
    Dim TEMATIZACION As New Colorizacion
    Dim menuac, mensaje, sentencia, avisosalida As String
    Dim cxc1, cxc2, cxc3, cxc4, cxc5, cxp1, cxp2, cxp3, cxp4, cxp5, mant1, mant2, mant3, mant4, mant5, mant6, mant7, mant8, mant9, mant10, mant11, mov1, mov2, mov3, mov4, mov5, mov6, mov7, mov8, mov9, mov10, util1, util2, util3, util4, util5, util6 As String

    Private Sub BtnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        MsgBox("Proximamente disponible")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        If txtbAsunto.Text = "" Or txtbContenido.Text = "" Then
            MsgBox("Llena todos los campos")
        Else
            Dim smtp As New System.Net.Mail.SmtpClient
            Dim correo As New System.Net.Mail.MailMessage
            Dim adjunto As System.Net.Mail.Attachment

            Dim ASUNTO As String = txtbAsunto.Text
            Dim CONTENIDO As String = txtbContenido.Text

            With smtp
                .Port = 25
                .Host = "smtp.elrincondelprogramador.net"
                .Credentials = New System.Net.NetworkCredential("usuario-smtp", "clave-smtp")
                .EnableSsl = False
            End With
            'adjunto = New System.Net.Mail.Attachment("C:\Temp\Adjunto.pdf")
            With correo
                .From = New System.Net.Mail.MailAddress("eldervielman2001@outlook.es")
                .To.Add("vielmanelderlinares@gmail.com")
                .Subject = ASUNTO
                .Body = "<strong>" & CONTENIDO & "</strong>"
                .IsBodyHtml = True
                .Priority = System.Net.Mail.MailPriority.Normal
                '.Attachments.Add(adjunto)
            End With

            Try
                smtp.Send(correo)
                MessageBox.Show("Su mensaje de correo ha sido enviado.",
                                "Correo enviado",
                                 MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message,
                                "Error al enviar correo",
                                 MessageBoxButtons.OK)
            End Try
        End If



    End Sub

    Dim x As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        x = x + 1
        If x = 3 Then
            Timer1.Stop()
            lblguardar.Visible = False
        End If
    End Sub

    Dim web As WebBrowser
    Private Sub btnmoduti_Click(sender As Object, e As EventArgs) Handles btnmoduti.Click
        If chuti1.Checked = True Then
            util1 = "1"
        Else
            util1 = "0"
        End If
        If chuti2.Checked = True Then
            util2 = "1"
        Else
            util2 = "0"
        End If
        If chuti3.Checked = True Then
            util3 = "1"
        Else
            util3 = "0"
        End If
        If chuti4.Checked = True Then
            util4 = "1"
        Else
            util4 = "0"
        End If
        If chuti5.Checked = True Then
            util5 = "1"
        Else
            util5 = "0"
        End If
        If chuti6.Checked = True Then
            util6 = "1"
        Else
            util6 = "0"
        End If
        Try
            sentencia = "update detperfil set  itemactivo='" + util1 + "' where id_perfil='" + cmbid.Text + "' and menu='Utilitarios' and item='Uti1' update detperfil set  itemactivo='" + util2 + "' where id_perfil='" + cmbid.Text + "' and menu='Utilitarios' and item='Uti2' update detperfil set  itemactivo='" + util3 + "' where id_perfil='" + cmbid.Text + "' and menu='Utilitarios' and item='Uti3' update detperfil set  itemactivo='" + util4 + "' where id_perfil='" + cmbid.Text + "' and menu='Utilitarios' and item='uti4' update detperfil set  itemactivo='" + util5 + "' where id_perfil='" + cmbid.Text + "' and menu='Utilitarios' and item='uti5' update detperfil set itemactivo='" + util6 + "' where id_perfil='" + cmbid.Text + "' and menu='Utilitarios' and item='Uti6'"
            mensaje = "Se han actualizado los permisos"
            conexion.Close()
            ejecutarSQL(sentencia, mensaje)
            conexion.Close()
            Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Utilitarios'", conexion)
            Dim ds As New DataSet
            Dap.Fill(ds)
            DataGridView6.DataSource = ds.Tables(0)
            btnmod.Enabled = True
            conexion.Close()
            avisosalida = MsgBox("¿Desea volver al gesto de permisos por menu?", MsgBoxStyle.YesNo, "Advertencia")
            If avisosalida = 6 Then
                PanelUtil.Visible = False
            End If
            conexion.Close()
            Dim Dap1 As New SqlDataAdapter("select * from detperfil where id_perfil='" + cmbid.Text + "' and menu='" + cmbmenu.Text + "'", conexion)
            Dim ds1 As New DataSet
            Dap1.Fill(ds1)
            DataGridView1.DataSource = ds1.Tables(0)
            btnmod.Enabled = True
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        avisosalida = MsgBox("¿Desea volver al gesto de permisos por menu?", MsgBoxStyle.YesNo, "Advertencia")
        If avisosalida = 6 Then
            panelCXC.Visible = False
            PanelCXP.Visible = False
            PanelMant.Visible = False
            Panelmov.Visible = False
            PanelUtil.Visible = False
        End If
    End Sub

    Private Sub btmodmov_Click(sender As Object, e As EventArgs) Handles btmodmov.Click
        If chmov1.Checked = True Then
            mov1 = "1"
        Else
            mov1 = "0"
        End If
        If chmov2.Checked = True Then
            mov2 = "1"
        Else
            mov2 = "0"
        End If
        If chmov3.Checked = True Then
            mov3 = "1"
        Else
            mov3 = "0"
        End If
        If chmov4.Checked = True Then
            mov4 = "1"
        Else
            mov4 = "0"
        End If
        If chmov5.Checked = True Then
            mov5 = "1"
        Else
            mov5 = "0"
        End If
        If chmov6.Checked = True Then
            mov6 = "1"
        Else
            mov6 = "0"
        End If
        If chmov7.Checked = True Then
            mov7 = "1"
        Else
            mov7 = "0"
        End If
        If chmov8.Checked = True Then
            mov8 = "1"
        Else
            mov8 = "0"
        End If
        If chmov9.Checked = True Then
            mov9 = "1"
        Else
            mov9 = "0"
        End If
        If chmov10.Checked = True Then
            mov10 = "1"
        Else
            mov10 = "0"
        End If
        Try
            sentencia = "update detperfil set  itemactivo='" + mov1 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov1' update detperfil set  itemactivo='" + mov2 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov2' update detperfil set  itemactivo='" + mov3 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov3' update detperfil set  itemactivo='" + mov4 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov4' update detperfil set  itemactivo='" + mov5 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov5' update detperfil set  itemactivo='" + mov6 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov6' update detperfil set  itemactivo='" + mov7 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov7' update detperfil set  itemactivo='" + mov8 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov8' update detperfil set  itemactivo='" + mov9 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov9' update detperfil set  itemactivo='" + mov10 + "' where id_perfil='" + cmbid.Text + "' and menu='Movimientos' and item='mov10'"
            mensaje = "Se han actualizado los permisos"
            conexion.Close()
            ejecutarSQL(sentencia, mensaje)
            conexion.Close()
            Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Movimientos'", conexion)
            Dim ds As New DataSet
            Dap.Fill(ds)
            DataGridView5.DataSource = ds.Tables(0)
            btnmod.Enabled = True
            conexion.Close()
            avisosalida = MsgBox("¿Desea volver al gesto de permisos por menu?", MsgBoxStyle.YesNo, "Advertencia")
            If avisosalida = 6 Then
                panelCXC.Visible = False
                PanelCXP.Visible = False
                PanelMant.Visible = False
                Panelmov.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub modmant_Click(sender As Object, e As EventArgs) Handles modmant.Click
        If chmant1.Checked = True Then
            mant1 = "1"
        Else
            mant1 = "0"
        End If
        If chmant2.Checked = True Then
            mant2 = "1"
        Else
            mant2 = "0"
        End If
        If chmant3.Checked = True Then
            mant3 = "1"
        Else
            mant3 = "0"
        End If
        If chmant4.Checked = True Then
            mant4 = "1"
        Else
            mant4 = "0"
        End If
        If chmant5.Checked = True Then
            mant5 = "1"
        Else
            mant5 = "0"
        End If
        If chmant11.Checked = True Then
            mant11 = "1"
        Else
            mant11 = "0"
        End If
        If chmant5.Checked = True Then
            mant6 = "1"
        Else
            mant6 = "0"
        End If
        If chmant7.Checked = True Then
            mant7 = "1"
        Else
            mant7 = "0"
        End If
        If chmant8.Checked = True Then
            mant8 = "1"
        Else
            mant8 = "0"
        End If
        If chmant9.Checked = True Then
            mant9 = "1"
        Else
            mant9 = "0"
        End If
        If chmant10.Checked = True Then
            mant10 = "1"
        Else
            mant10 = "0"
        End If
        Try
            sentencia = "update detperfil set  itemactivo='" + mant1 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant1' update detperfil set  itemactivo='" + mant2 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant2' update detperfil set  itemactivo='" + mant3 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant3' update detperfil set  itemactivo='" + mant5 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant4' update detperfil set  itemactivo='" + mant5 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant5' update detperfil set  itemactivo='" + mant6 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant6' update detperfil set  itemactivo='" + mant7 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant7' update detperfil set  itemactivo='" + mant8 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant8' update detperfil set  itemactivo='" + mant9 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant9' update detperfil set  itemactivo='" + mant10 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant10' update detperfil set  itemactivo='" + mant11 + "' where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos' and item='Mant11' "
            mensaje = "Se han actualizado los permisos"
            conexion.Close()
            ejecutarSQL(sentencia, mensaje)
            conexion.Close()
            Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos'", conexion)
            Dim ds As New DataSet
            Dap.Fill(ds)
            DataGridView4.DataSource = ds.Tables(0)
            btnmod.Enabled = True
            conexion.Close()
            avisosalida = MsgBox("¿Desea volver al gesto de permisos por menu?", MsgBoxStyle.YesNo, "Advertencia")
            If avisosalida = 6 Then
                panelCXC.Visible = False
                PanelCXP.Visible = False
                PanelMant.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEditarNombre_Click(sender As Object, e As EventArgs) Handles btnEditarNombre.Click
        My.Settings.ConfigNombrePrograma = txtbNombrePrograma.Text
        My.Settings.Save()
        My.Settings.Reload()
        CambiarNombres()
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        My.Settings.ConfigNombrePrograma = "Proyecto Disermo"
        My.Settings.Save()
        My.Settings.Reload()
        CambiarNombres()
    End Sub

    Private Sub BtnGuardarValorQuetzal_Click(sender As Object, e As EventArgs) Handles btnGuardarValorQuetzal.Click
        My.Settings.ConfigValorQuetzal = txtbValorQuetzal.Text
        My.Settings.Save()
        My.Settings.Reload()
        txtbValorQuetzal.Text = My.Settings.ConfigValorQuetzal
        lblguardar.Text = "Se ha guardado el valor"
        lblguardar.Visible = True
        Timer1.Start()
        x = 0
    End Sub
    Private Sub cargarValorDolar()

        If (Web.Document IsNot Nothing) Then ' En caso de que la página no halla cargado bien el documento
            Dim divs = Web.Document.Body.GetElementsByTagName("div") ' Obtiene todos los elementos <div> de la página web

            For Each div As HtmlElement In divs ' Recorre la lista de elementos <div>
                Dim className As String = div.GetAttribute("className") ' Obtiene el atributo [class] (nos servirá de filtro)
                If className = "currency-field-result" Then ' El texto con el que se compara es el que muestra el valor del dólar en pesos argentinos
                    txtbValorQuetzal.Text = div.InnerText ' Se obtiene el valor del dólar
                    My.Settings.ConfigValorQuetzal = txtbValorQuetzal.Text
                    My.Settings.Save()
                    My.Settings.Reload()
                    lblguardar.Text = "se extrajo el valor del dolar de internet"
                    lblguardar.Visible = True
                    Timer1.Start()
                    x = 0
                End If
            Next
        End If
    End Sub
    Private Sub BtnObtencionValorQuetzal_Click(sender As Object, e As EventArgs) Handles btnObtencionValorQuetzal.Click
        Try
            web = New WebBrowser() ' Se instancia el WebBrower
            web.ScriptErrorsSuppressed = True ' Oculta la ventana de errores si algún script de la página falló (de todas formas no los necesitamos)
            web.Navigate(New Uri("https://www.cambio-dolar.com.gt")) ' Carga la página web creando un nuevo documento HTML
            AddHandler web.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf cargarValorDolar)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnGuardarIVA_Click(sender As Object, e As EventArgs) Handles btnGuardarIVA.Click
        My.Settings.ConfigIVA = txtbIVA.Text
        txtbIVA.Text = My.Settings.ConfigIVA
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub CmbTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTema.SelectedIndexChanged
        If cmbTema.Text = "Oscuro" Then
            My.Settings.ConfigTema = False
            CambioColor()
            My.Settings.Save()
            My.Settings.Reload()
        ElseIf cmbTema.Text = "Claro" Then
            My.Settings.ConfigTema = True
            CambioColor()
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub RbtnIzquierda_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIzquierda.CheckedChanged
        My.Settings.ConfigPosicionamiento = False
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub RbtnCentro_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCentro.CheckedChanged
        My.Settings.ConfigPosicionamiento = True
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub btnmodcxp_Click(sender As Object, e As EventArgs) Handles btnmodcxp.Click

        If chcxp1.Checked = True Then
            cxp1 = "1"
        Else
            cxp1 = "0"
        End If
        If chcxp2.Checked = True Then
            cxp2 = "1"
        Else
            cxp2 = "0"
        End If
        If chcxp3.Checked = True Then
            cxp3 = "1"
        Else
            cxp3 = "0"
        End If
        If chcxp4.Checked = True Then
            cxp4 = "1"
        Else
            cxp4 = "0"
        End If
        If chcxp5.Checked = True Then
            cxp5 = "1"
        Else
            cxp5 = "0"
        End If
        Try
            sentencia = "update detperfil set  itemactivo='" + cxp1 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar' and item='cxp1' update detperfil set  itemactivo='" + cxp2 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar' and item='cxp2' update detperfil set  itemactivo='" + cxp3 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar' and item='cxp3' update detperfil set  itemactivo='" + cxp4 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar' and item='cxp4' update detperfil set  itemactivo='" + cxp5 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar' and item='cxp5'"
            mensaje = "Se han actualizado los permisos"
            conexion.Close()
            ejecutarSQL(sentencia, mensaje)
            conexion.Close()
            Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar'", conexion)
            Dim ds As New DataSet
            Dap.Fill(ds)
            DataGridView3.DataSource = ds.Tables(0)
            btnmod.Enabled = True
            conexion.Close()
            avisosalida = MsgBox("¿Desea volver al gesto de permisos por menu?", MsgBoxStyle.YesNo, "Advertencia")
            If avisosalida = 6 Then
                PanelCXP.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Configuración_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelContenedorAyuda.Controls.Clear()
        Ayuda.TopLevel = False
        PanelContenedorAyuda.Controls.Add(Ayuda)
        Ayuda.FormBorderStyle = FormBorderStyle.None
        Ayuda.Show()

        webbBuscador.Visible = False
        webbBuscador.ScriptErrorsSuppressed = True
        Me.Text = My.Settings.ConfigNombrePrograma & " - Configuración"
        txtbNombrePrograma.Text = My.Settings.ConfigNombrePrograma
        txtbIVA.Text = My.Settings.ConfigIVA
        txtbValorQuetzal.Text = My.Settings.ConfigValorQuetzal
        My.Settings.Save()
        My.Settings.Reload()

        If My.Settings.ConfigPosicionamiento = False Then
            rbtnIzquierda.Checked = True
        ElseIf My.Settings.ConfigPosicionamiento = True Then
            rbtnCentro.Checked = True
        End If
        Try
            conexion.Close()
            conexion.Open()
            Dim cmd As SqlCommand
            Dim dr As SqlDataReader
            cmd = New SqlCommand("select DISTINCT id_perfil as perfil from detperfil", conexion)
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbid.Items.Add(dr("perfil").ToString())
            End While
            dr.Close()
            conexion.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub CambiarNombres()
        txtbNombrePrograma.Text = My.Settings.ConfigNombrePrograma
        Me.Text = My.Settings.ConfigNombrePrograma & " - Configuración  /  Usuario: " & My.Settings.NombreUsuario
        Main.Text = My.Settings.ConfigNombrePrograma & " - Configuración   /  Usuario: " & My.Settings.NombreUsuario
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub CambioColor()
        TEMATIZACION.ColoresMain()
        TEMATIZACION.Fondos()
    End Sub

    Private Sub Configuración_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main.Enabled = True
    End Sub

    Private Sub ConfigUsuarios_Click(sender As Object, e As EventArgs) Handles ConfigUsuarios.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbid.SelectedIndexChanged
        Try
            cmbperfil.Items.Clear()
            cmbmenu.Items.Clear()
            conexion.Open()
            Dim Consulta As String = "Select perfil from perfil where Id_Perfil='" + cmbid.Text + "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "perfil")
            lista = datos.Tables("perfil").Rows.Count
            If lista <> 0 Then
                conexion.Close()
                conexion.Open()
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                cmd = New SqlCommand("select perfil from perfil where Id_Perfil='" + cmbid.Text + "'", conexion)
                dr = cmd.ExecuteReader
                While dr.Read()
                    cmbperfil.Items.Add(dr("perfil").ToString())
                End While
                dr.Close()
                conexion.Close()
            End If
            conexion.Close()
        Catch
            conexion.Close()
        End Try
    End Sub
    Private Sub cmbmenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmenu.SelectedIndexChanged
        Try
            conexion.Close()
            conexion.Open()
            Dim Consulta1 As String = "Select itemactivo from detperfil where Id_Perfil='" + cmbid.Text + "' and menu='" + cmbmenu.Text + "'"
            Dim lista1 As Byte
            Dim datos1 As New DataSet
            Dim adaptador1 = New SqlDataAdapter(Consulta1, conexion)
            datos1 = New DataSet
            adaptador1.Fill(datos1, "detperfil")
            lista1 = datos1.Tables("detperfil").Rows.Count
            If lista1 <> 0 Then
                menuac = datos1.Tables("detperfil").Rows(0).Item("itemactivo")
                If menuac = "1" Then
                    chkmenuac.Checked = True
                Else
                    chkmenuac.Checked = False
                End If
                Dim Dap As New SqlDataAdapter("select * from detperfil where id_perfil='" + cmbid.Text + "' and menu='" + cmbmenu.Text + "'", conexion)
                Dim ds As New DataSet
                Dap.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                btnmod.Enabled = True
                conexion.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbperfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbperfil.SelectedIndexChanged
        Try
            conexion.Close()
            conexion.Open()
            cmbmenu.Items.Clear()
            Dim cmd As SqlCommand
            Dim dr As SqlDataReader
            cmd = New SqlCommand("select DISTINCT menu as NOMBREMENU from detperfil where Id_Perfil='" + cmbid.Text + "' and activo='1'", conexion)
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbmenu.Items.Add(dr("NOMBREMENU").ToString())
            End While
            dr.Close()
            conexion.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        Button1.Enabled = True
        If cmbmenu.Text = "CuentaxCobrar" Then
            panelCXC.Visible = True
            PanelCXP.Visible = False
            PanelMant.Visible = False
            Panelmov.Visible = False
            PanelUtil.Visible = False
            Try
                conexion.Close()
                Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar'", conexion)
                Dim ds As New DataSet
                Dap.Fill(ds)
                DataGridView2.DataSource = ds.Tables(0)
                btnmod.Enabled = True
                conexion.Close()

                conexion.Open()
                Dim Consulta As String = "select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "detperfil")
                lista = datos.Tables("detperfil").Rows.Count
                If lista <> 0 Then
                    cxc1 = datos.Tables("detperfil").Rows(0).Item("itemactivo")
                    cxc2 = datos.Tables("detperfil").Rows(1).Item("itemactivo")
                    cxc3 = datos.Tables("detperfil").Rows(2).Item("itemactivo")
                    cxc4 = datos.Tables("detperfil").Rows(3).Item("itemactivo")
                    cxc5 = datos.Tables("detperfil").Rows(4).Item("itemactivo")
                    If cxc1 = "1" Then
                        chcxc1.Checked = True
                    End If
                    If cxc2 = "1" Then
                        chcxc2.Checked = True
                    End If
                    If cxc3 = "1" Then
                        chcxc3.Checked = True
                    End If
                    If cxc4 = "1" Then
                        chcxc4.Checked = True
                    End If
                    If cxc5 = "1" Then
                        chcxc5.Checked = True
                    End If

                End If
            Catch ex As Exception
                conexion.Close()
            End Try
        ElseIf cmbmenu.Text = "CuentaxPagar" Then
            Try
                PanelCXP.Visible = True
                panelCXC.Visible = False
                PanelMant.Visible = False
                Panelmov.Visible = False
                PanelUtil.Visible = False
                conexion.Close()
                Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar'", conexion)
                Dim ds As New DataSet
                Dap.Fill(ds)
                DataGridView3.DataSource = ds.Tables(0)
                btnmod.Enabled = True
                conexion.Close()

                conexion.Open()
                Dim Consulta As String = "select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='CuentaxPagar'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "detperfil")
                lista = datos.Tables("detperfil").Rows.Count
                If lista <> 0 Then
                    cxp1 = datos.Tables("detperfil").Rows(0).Item("itemactivo")
                    cxp2 = datos.Tables("detperfil").Rows(1).Item("itemactivo")
                    cxp3 = datos.Tables("detperfil").Rows(2).Item("itemactivo")
                    cxp4 = datos.Tables("detperfil").Rows(3).Item("itemactivo")
                    cxp5 = datos.Tables("detperfil").Rows(4).Item("itemactivo")
                    If cxp1 = "1" Then
                        chcxp1.Checked = True
                    End If
                    If cxp2 = "1" Then
                        chcxp2.Checked = True
                    End If
                    If cxp3 = "1" Then
                        chcxp3.Checked = True
                    End If
                    If cxp4 = "1" Then
                        chcxp4.Checked = True
                    End If
                    If cxp5 = "1" Then
                        chcxp5.Checked = True
                    End If
                End If
            Catch ex As Exception
                conexion.Close()
            End Try
        ElseIf cmbmenu.Text = "Mantenimientos" Then
            Try
                PanelCXP.Visible = False
                panelCXC.Visible = False
                PanelMant.Visible = True
                Panelmov.Visible = False
                PanelUtil.Visible = False
                conexion.Close()
                Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos'", conexion)
                Dim ds As New DataSet
                Dap.Fill(ds)
                DataGridView4.DataSource = ds.Tables(0)
                btnmod.Enabled = True
                conexion.Close()

                conexion.Open()
                Dim Consulta As String = "select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Mantenimientos'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "detperfil")
                lista = datos.Tables("detperfil").Rows.Count
                If lista <> 0 Then
                    mant1 = datos.Tables("detperfil").Rows(0).Item("itemactivo")
                    mant2 = datos.Tables("detperfil").Rows(1).Item("itemactivo")
                    mant3 = datos.Tables("detperfil").Rows(2).Item("itemactivo")
                    mant4 = datos.Tables("detperfil").Rows(3).Item("itemactivo")
                    mant5 = datos.Tables("detperfil").Rows(4).Item("itemactivo")
                    mant6 = datos.Tables("detperfil").Rows(5).Item("itemactivo")
                    mant7 = datos.Tables("detperfil").Rows(6).Item("itemactivo")
                    mant8 = datos.Tables("detperfil").Rows(7).Item("itemactivo")
                    mant9 = datos.Tables("detperfil").Rows(8).Item("itemactivo")
                    mant10 = datos.Tables("detperfil").Rows(9).Item("itemactivo")
                    mant11 = datos.Tables("detperfil").Rows(10).Item("itemactivo")
                    If mant1 = "1" Then
                        chmant1.Checked = True
                    End If
                    If mant2 = "1" Then
                        chmant2.Checked = True
                    End If
                    If mant3 = "1" Then
                        chmant3.Checked = True
                    End If
                    If mant4 = "1" Then
                        chmant4.Checked = True
                    End If
                    If mant5 = "1" Then
                        chmant6.Checked = True
                    End If
                    If mant6 = "1" Then
                        chmant6.Checked = True
                    End If
                    If mant7 = "1" Then
                        chmant7.Checked = True
                    End If
                    If mant8 = "1" Then
                        chmant8.Checked = True
                    End If
                    If mant9 = "1" Then
                        chmant9.Checked = True
                    End If
                    If mant10 = "1" Then
                        chmant11.Checked = True
                    End If
                    If mant11 = "1" Then
                        chmant11.Checked = True
                    End If
                End If
            Catch ex As Exception
                conexion.Close()
            End Try
        ElseIf cmbmenu.Text = "Movimientos" Then
            Try
                PanelCXP.Visible = False
                panelCXC.Visible = False
                PanelMant.Visible = False
                Panelmov.Visible = True
                PanelUtil.Visible = False
                conexion.Close()
                Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Movimientos'", conexion)
                Dim ds As New DataSet
                Dap.Fill(ds)
                DataGridView5.DataSource = ds.Tables(0)
                btnmod.Enabled = True
                conexion.Close()

                conexion.Open()
                Dim Consulta As String = "select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Movimientos'"
                Dim lista As Byte
                Dim datos As New DataSet
                Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "detperfil")
                lista = datos.Tables("detperfil").Rows.Count
                If lista <> 0 Then
                    mov1 = datos.Tables("detperfil").Rows(0).Item("itemactivo")
                    mov2 = datos.Tables("detperfil").Rows(1).Item("itemactivo")
                    mov3 = datos.Tables("detperfil").Rows(2).Item("itemactivo")
                    mov4 = datos.Tables("detperfil").Rows(3).Item("itemactivo")
                    mov5 = datos.Tables("detperfil").Rows(4).Item("itemactivo")
                    mov6 = datos.Tables("detperfil").Rows(5).Item("itemactivo")
                    mov7 = datos.Tables("detperfil").Rows(6).Item("itemactivo")
                    mov8 = datos.Tables("detperfil").Rows(7).Item("itemactivo")
                    mov9 = datos.Tables("detperfil").Rows(8).Item("itemactivo")
                    mov10 = datos.Tables("detperfil").Rows(9).Item("itemactivo")
                    If mov1 = "1" Then
                        chmov1.Checked = True
                    End If
                    If mov2 = "1" Then
                        chmov2.Checked = True
                    End If
                    If mov3 = "1" Then
                        chmov3.Checked = True
                    End If
                    If mov4 = "1" Then
                        chmov4.Checked = True
                    End If
                    If mov5 = "1" Then
                        chmov5.Checked = True
                    End If
                    If mov6 = "1" Then
                        chmov6.Checked = True
                    End If
                    If mov7 = "1" Then
                        chmov7.Checked = True
                    End If
                    If mov8 = "1" Then
                        chmov8.Checked = True
                    End If
                    If mov9 = "1" Then
                        chmov9.Checked = True
                    End If
                    If mov10 = "1" Then
                        chmov10.Checked = True
                    End If
                End If
            Catch ex As Exception
                conexion.Close()
            End Try
        ElseIf cmbmenu.Text = "Utilitarios" Then
            panelCXC.Visible = False
            PanelCXP.Visible = False
            PanelMant.Visible = False
            Panelmov.Visible = False
            PanelUtil.Visible = True
            Try
                    conexion.Close()
                Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Utilitarios'", conexion)
                Dim ds As New DataSet
                Dap.Fill(ds)
                DataGridView6.DataSource = ds.Tables(0)
                btnmod.Enabled = True
                conexion.Close()

                conexion.Open()
                Dim Consulta As String = "select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='Utilitarios'"
                Dim lista As Byte
                    Dim datos As New DataSet
                    Dim adaptador = New SqlDataAdapter(Consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "detperfil")
                    lista = datos.Tables("detperfil").Rows.Count
                    If lista <> 0 Then
                    util1 = datos.Tables("detperfil").Rows(0).Item("itemactivo")
                    util2 = datos.Tables("detperfil").Rows(1).Item("itemactivo")
                    util3 = datos.Tables("detperfil").Rows(2).Item("itemactivo")
                    util4 = datos.Tables("detperfil").Rows(3).Item("itemactivo")
                    util5 = datos.Tables("detperfil").Rows(4).Item("itemactivo")
                    util6 = datos.Tables("detperfil").Rows(5).Item("itemactivo")
                    If util1 = "1" Then
                        chuti1.Checked = True
                    End If
                    If util2 = "1" Then
                        chuti2.Checked = True
                    End If
                    If util3 = "1" Then
                        chuti3.Checked = True
                    End If
                    If util4 = "1" Then
                        chuti4.Checked = True
                    End If
                    If util5 = "1" Then
                        chuti5.Checked = True
                    End If
                    If util6 = "1" Then
                        chuti6.Checked = True
                    End If
                End If
                Catch ex As Exception
                    conexion.Close()
                End Try
            End If
    End Sub

    Private Sub panelCXC_Paint(sender As Object, e As PaintEventArgs) Handles panelCXC.Paint


    End Sub
    Sub ejecutarSQL(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Private Sub btnmodm_Click(sender As Object, e As EventArgs) Handles btnmodm.Click
        If chcxc1.Checked = True Then
            cxc1 = "1"
        Else
            cxc1 = "0"
        End If
        If chcxc2.Checked = True Then
            cxc2 = "1"
        Else
            cxc2 = "0"
        End If
        If chcxc3.Checked = True Then
            cxc3 = "1"
        Else
            cxc3 = "0"
        End If
        If chcxc4.Checked = True Then
            cxc4 = "1"
        Else
            cxc4 = "0"
        End If
        If chcxc5.Checked = True Then
            cxc5 = "1"
        Else
            cxc5 = "0"
        End If
        Try
            sentencia = "update detperfil set  itemactivo='" + cxc1 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar' and item='cxc1' update detperfil set  itemactivo='" + cxc2 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar' and item='cxc2' update detperfil set  itemactivo='" + cxc3 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar' and item='cxc3' update detperfil set  itemactivo='" + cxc4 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar' and item='cxc4' update detperfil set  itemactivo='" + cxc5 + "' where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar' and item='cxc5'"
            mensaje = "Se han actualizado los permisos"
            conexion.Close()
            ejecutarSQL(sentencia, mensaje)
            conexion.Close()
            Dim Dap As New SqlDataAdapter("select item,itemactivo from detperfil where id_perfil='" + cmbid.Text + "' and menu='CuentaXCobrar'", conexion)
            Dim ds As New DataSet
            Dap.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            btnmod.Enabled = True
            conexion.Close()
            avisosalida = MsgBox("¿Desea volver al gesto de permisos por menu?", MsgBoxStyle.YesNo, "Advertencia")
            If avisosalida = 6 Then
                panelCXC.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
