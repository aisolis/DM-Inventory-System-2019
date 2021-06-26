Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports Transitions
Public Class Ingreso
    Dim conexion As New SqlConnection(My.Settings.conexionglobal)
    Dim IsAdmin, cxc1, cxc2, cxc3, cxc4, cxc5, cxp1, cxp2, cxp3, cxp4, cxp5, mant1, mant2, mant3, mant4, mant5, mant6, mant7, mant8, mant9, mant10, mant11, mov1, mov2, mov3, mov4, mov5, mov6, mov7, mov8, mov9, mov10, util1, util2, util3, util4, util5, util6 As String


    Private Sub LlblRegresarPanelEspecial_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRegresarPanelEspecial.LinkClicked
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        t.add(PanelUsuarios, "Left", 253)
        t.add(PanelIngresoEspecial, "Left", 535)
        t.run()
    End Sub

    Private Sub LlblRegresarPanelNormal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRegresarPanelNormal.LinkClicked
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        t.add(PanelUsuarios, "Left", 253)
        t.add(PanelIngreso, "Left", 535)
        t.run()

        PanelIngresoEspecial.Left = 535
    End Sub

    Private Sub LlblOtroUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblOtroUsuario.LinkClicked
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        t.add(PanelIngreso, "Left", 253)
        t.add(PanelUsuarios, "Left", 535)
        t.run()
        PanelIngresoEspecial.Left = 535
    End Sub

    Private Sub Panelults3_MouseEnter(sender As Object, e As EventArgs) Handles Panelults3.MouseEnter
        'Panelults3.Width = 150
        Panelults3.BackColor = Color.Silver
    End Sub

    Private Sub Panelults3_MouseLeave(sender As Object, e As EventArgs) Handles Panelults3.MouseLeave
        'Panelults3.Width = 128
        Panelults3.BackColor = Color.Transparent
    End Sub

    Private Sub lblus2_MouseLeave(sender As Object, e As EventArgs) Handles lblus2.MouseLeave
        'Panelults2.Width = 128
        Panelults2.BackColor = Color.Transparent
    End Sub

    Private Sub lblus2_MouseEnter(sender As Object, e As EventArgs) Handles lblus2.MouseEnter
        'Panelults2.Width = 150
        Panelults2.BackColor = Color.Silver
    End Sub

    Private Sub Panelults2_MouseLeave(sender As Object, e As EventArgs) Handles Panelults2.MouseLeave
        'Panelults2.Width = 128
        Panelults2.BackColor = Color.Transparent
    End Sub

    Private Sub Panelults2_MouseEnter(sender As Object, e As EventArgs) Handles Panelults2.MouseEnter
        'Panelults2.Width = 150
        Panelults2.BackColor = Color.Silver
    End Sub

    Private Sub picfoto3_MouseLeave(sender As Object, e As EventArgs)
        'Panelults3.Width = 128
        Panelults3.BackColor = Color.Transparent
    End Sub

    Private Sub picfoto3_MouseEnter(sender As Object, e As EventArgs)
        'Panelults3.Width = 150
        Panelults3.BackColor = Color.Silver
    End Sub
    Private Sub lblus3_Click(sender As Object, e As EventArgs) Handles picfoto3.Click, Panelults3.Click, lblus3.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        picfot.Image = picfoto3.Image
        t.add(PanelIngresoEspecial, "Left", 250)
        t.add(PanelUsuarios, "Left", 535)
        t.run()
        lblusuario.Text = lblus3.Text
    End Sub

    Private Sub picfoto2_Click(sender As Object, e As EventArgs) Handles picfoto2.Click, Panelults2.Click, lblus2.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        picfot.Image = picfoto2.Image
        t.add(PanelIngresoEspecial, "Left", 250)
        t.add(PanelUsuarios, "Left", 535)
        t.run()
        lblusuario.Text = lblus2.Text
    End Sub

    Private Sub picfoto2_MouseLeave(sender As Object, e As EventArgs) Handles picfoto2.MouseLeave
        ' Panelults1.Width = 128
        Panelults1.BackColor = Color.Transparent
    End Sub

    Private Sub picfoto2_MouseEnter(sender As Object, e As EventArgs) Handles picfoto2.MouseEnter, Panelults2.MouseEnter
        'Panelults2.Width = 150
        Panelults2.BackColor = Color.Silver
    End Sub

    Private Sub password2_KeyDown(sender As Object, e As KeyEventArgs) Handles password2.KeyDown
        If e.KeyCode = Keys.Enter Then
            aceptar2.Select()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles aceptar2.Click
        Try
            If password2.Text = "" Then
                lblError.Visible = True
                If password2.Text = "" Then
                    lblError.Text = "Llena todos los campos"
                Else
                    lblError.Text = "Nombre de usuario o contraseña incorrecto"
                    'MessageBox.Show("Nombre de Usuario o Password invalido, Verifique")
                End If
                password2.Focus()
                password2.SelectAll()
            Else
                Main.Close()
                Dim dt As New DataTable
                'Estableciendo cadena de conexión
                Dim conexion As New SqlConnection(My.Settings.conexionglobal)
                Dim datos As New DataSet
                Dim Consulta As String = "Select NombreUsuario, contraseña ,Id_perfil from usuarios where NombreUsuario = '" & lblusuario.Text & "'"
                Dim comando As New SqlCommand(Consulta, conexion)
                Dim drd As SqlDataReader
                conexion.Open()
                drd = comando.ExecuteReader
                If drd.Read() Then
                    Dim idus = drd.Item("NombreUsuario").ToString()
                    Dim pass As String = drd.Item("contraseña").ToString()
                    IsAdmin = drd.Item("Id_perfil").ToString()
                    If UCase(idus) = UCase(Trim(lblusuario.Text)) And pass = Trim(password2.Text) Then
                        My.Settings.NombreUsuario = lblusuario.Text
                        My.Settings.Save()
                        My.Settings.Reload()
                        Main.btnUsuario.Text = idus
                        permisos()
                        password2.Text = ""
                        conexion.Close()
                        conexion.Open()
                        Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + idus + "'", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds)
                        Dim c As Integer = ds.Tables(0).Rows.Count
                        If c > 0 Then
                            Dim bytBLOBData() As Byte =
                                    ds.Tables(0).Rows(c - 1)("FOTO")
                            Dim stmBLOBData As New MemoryStream(bytBLOBData)
                            Main.picfoto.Image = Image.FromStream(stmBLOBData)
                            Me.Hide()
                            Main.Show()
                            conexion.Close()
                        Else
                            Me.Hide()
                            Main.Show()
                            conexion.Close()
                        End If
                    Else
                        lblError.Visible = True
                        If password2.Text = "" Then
                            lblError.Text = "Llena todos los campos"
                        Else
                            lblError.Text = "Nombre de usuario o contraseña incorrecto"
                        End If
                        password2.Focus()
                        password2.SelectAll()
                    End If
                Else
                    drd.Close()
                    conexion.Close()
                End If
            End If
        Catch ex As Exception
            lblError.Text = "Error al establicer conexion con el servidor"
            lblError.Visible = True
        End Try
    End Sub


    Private Sub Panelults1_Click(sender As Object, e As EventArgs) Handles Panelults1.Click, picfoto1.Click, lblus1.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(1000))
        picfot.Image = picfoto1.Image
        t.add(PanelIngresoEspecial, "Left", 250)
        t.add(PanelUsuarios, "Left", 535)
        t.run()
        lblusuario.Text = lblus1.Text
    End Sub

    Private Sub Panelults1_MouseLeave(sender As Object, e As EventArgs) Handles Panelults1.MouseLeave, picfoto3.MouseLeave, picfoto1.MouseLeave, lblus3.MouseLeave, lblus1.MouseLeave
        'Panelults1.Width = 128
        Panelults1.BackColor = Color.Transparent
    End Sub

    Private Sub Panelults1_MouseEnter(sender As Object, e As EventArgs) Handles Panelults1.MouseEnter, picfoto3.MouseEnter, picfoto1.MouseEnter, lblus3.MouseEnter, lblus1.MouseEnter
        'Panelults1.Width = 150
        Panelults1.BackColor = Color.Silver
    End Sub

    Dim sesion1, sesion2, sesion3, nick As String

    Private Sub PanelSuperior_DoubleClick(sender As Object, e As EventArgs)
        If llblRapido.Visible = True Then
            llblRapido.Visible = False
        Else
            llblRapido.Visible = True
        End If
    End Sub

    Private Sub LlblRapido_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRapido.LinkClicked
        'Me.Close()
        'Main.Show()

        MsgBox("Funcion desactivada :v")

    End Sub

    Protected Overrides Function ProcessCmdKey(
    ByRef msg As System.Windows.Forms.Message,
    ByVal keyData As System.Windows.Forms.Keys) As Boolean

        ' ¿Tiene el foco el control ComboBox?
        '
        If Usuario.Focused Then
            If keyData = Keys.Enter Then
                Password.Focus()
                'MessageBox.Show("Se ha pulsado la tecla Enter.")
            End If
        Else
            If Password.Focused Or password2.Focused Then
                If keyData = Keys.Enter Then
                    If Aceptar.Enabled = False Then
                        Aceptar.Enabled = True
                    End If
                    Aceptar.Focus()
                End If
            End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    Private Sub Cancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Width = 540
            Me.Height = 430
            llblRapido.Visible = False
            Dim conexion As New SqlConnection(My.Settings.conexionglobal)
            conexion.Close()
            Dim Consulta As String = "SELECT top 3 * FROM ultimasesion ORDER BY idsesion desc"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "ultimasesion")
            lista = datos.Tables("ultimasesion").Rows.Count

            If lista <> 0 Then
                sesion1 = datos.Tables("ultimasesion").Rows(0).Item("nombreusuario")
                llblRegresarPanelNormal.Visible = True
                PanelIngreso.Left = 535
                PanelIngresoEspecial.Left = 535
                PanelUsuarios.Left = 253
                If sesion1 <> "" Then
                    Panelults1.Visible = True
                    lblus1.Text = sesion1
                    nick = sesion1
                    Try
                        conexion.Close()
                        conexion.Open()
                        Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + nick + "'", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds)
                        Dim c As Integer = ds.Tables(0).Rows.Count
                        If c > 0 Then
                            Dim bytBLOBData() As Byte =
                                    ds.Tables(0).Rows(c - 1)("FOTO")
                            Dim stmBLOBData As New MemoryStream(bytBLOBData)
                            If sesion1 <> "" Then
                                picfoto1.Image = Image.FromStream(stmBLOBData)
                            End If
                        End If
                        conexion.Close()
                    Catch ex As Exception
                    End Try
                End If
                sesion2 = datos.Tables("ultimasesion").Rows(1).Item("nombreusuario")
                If sesion2 <> "" And sesion2 <> lblus1.Text Then
                    Panelults2.Visible = True
                    lblus2.Text = sesion2
                    nick = sesion2
                    Try
                        conexion.Close()
                        conexion.Open()
                        Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + nick + "'", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds)
                        Dim c As Integer = ds.Tables(0).Rows.Count
                        If c > 0 Then
                            Dim bytBLOBData() As Byte =
                                    ds.Tables(0).Rows(c - 1)("FOTO")
                            Dim stmBLOBData As New MemoryStream(bytBLOBData)
                            If sesion1 <> "" Then
                                picfoto2.Image = Image.FromStream(stmBLOBData)
                            End If
                        End If
                        conexion.Close()
                    Catch ex As Exception
                    End Try
                    sesion3 = datos.Tables("ultimasesion").Rows(2).Item("nombreusuario")
                    If sesion3 <> "" And sesion3 <> lblus1.Text And sesion3 <> lblus2.Text Then
                        Panelults3.Visible = True
                        lblus3.Text = sesion1
                        nick = sesion3
                        Try
                            conexion.Close()
                            conexion.Open()
                            Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + nick + "'", conexion)
                            Dim ds As New DataSet
                            da.Fill(ds)
                            Dim c As Integer = ds.Tables(0).Rows.Count
                            If c > 0 Then
                                Dim bytBLOBData() As Byte =
                                        ds.Tables(0).Rows(c - 1)("FOTO")
                                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                                If sesion1 <> "" Then
                                    picfoto3.Image = Image.FromStream(stmBLOBData)
                                End If
                            End If
                            conexion.Close()
                        Catch ex As Exception
                        End Try
                    End If
                End If
            Else
                llblRegresarPanelNormal.Visible = False

                PanelIngreso.Left = 253
                PanelIngresoEspecial.Left = 535
                PanelUsuarios.Left = 535
            End If
        Catch
        End Try
    End Sub
    Private Sub Usuario_Click(sender As Object, e As EventArgs)
        Usuario.SelectAll()
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs)
        Password.SelectAll()
    End Sub
    Public Sub limitado()
        Try
            Dim conexion As New SqlConnection(My.Settings.conexionglobal)
            conexion.Close()
            Dim Consulta As String = "Select itemactivo from detperfil where Id_perfil = '" & IsAdmin & "'"
            Dim lista As Byte
            Dim datos As New DataSet
            Dim adaptador = New SqlDataAdapter(Consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "detperfil")
            lista = datos.Tables("detperfil").Rows.Count
            If lista <> 0 Then
                mov1 = datos.Tables("detperfil").Rows(21).Item("itemactivo")
                If mov1 = "1" Then
                Else
                    Main.btnMovimientos.Enabled = False
                End If
                mov3 = datos.Tables("detperfil").Rows(23).Item("itemactivo")
                If mov3 = "1" Then

                Else
                    Menu_Movimientos.mov3.Enabled = False
                End If
                mov4 = datos.Tables("detperfil").Rows(24).Item("itemactivo")
                If mov4 = "1" Then

                Else
                    Menu_Movimientos.mov4.Enabled = False
                End If
                mov5 = datos.Tables("detperfil").Rows(25).Item("itemactivo")
                If mov5 = "1" Then

                Else
                    Menu_Movimientos.mov5.Enabled = False
                End If
                mov6 = datos.Tables("detperfil").Rows(26).Item("itemactivo")
                If mov6 = "1" Then

                Else
                    Menu_Movimientos.mov6.Enabled = False
                End If
                mov7 = datos.Tables("detperfil").Rows(27).Item("itemactivo")
                If mov7 = "1" Then

                Else
                    Menu_Movimientos.mov7.Enabled = False
                End If
                mov8 = datos.Tables("detperfil").Rows(28).Item("itemactivo")
                If mov8 = "1" Then

                Else
                    Menu_Movimientos.mov8.Enabled = False
                End If
                mov9 = datos.Tables("detperfil").Rows(29).Item("itemactivo")
                If mov9 = "1" Then

                Else
                    Menu_Movimientos.mov9.Enabled = False
                End If
                mov10 = datos.Tables("detperfil").Rows(30).Item("itemactivo")
                If mov10 = "1" Then

                Else
                    Menu_Movimientos.mov10.Enabled = False
                End If
                ''
                util1 = datos.Tables("detperfil").Rows(31).Item("itemactivo")
                If util1 = "1" Then

                Else
                    Main.btnUtilitarios.Enabled = False
                End If
                util2 = datos.Tables("detperfil").Rows(32).Item("itemactivo")
                If util2 = "1" Then

                Else
                    Menu_de_utilitarios.util2.Enabled = False
                End If
                util3 = datos.Tables("detperfil").Rows(33).Item("itemactivo")
                If util3 = "1" Then

                Else
                    Menu_de_utilitarios.util3.Enabled = False
                End If
                util4 = datos.Tables("detperfil").Rows(34).Item("itemactivo")
                If util4 = "1" Then

                Else
                    Menu_de_utilitarios.util4.Enabled = False
                End If

                util5 = datos.Tables("detperfil").Rows(35).Item("itemactivo")
                If util5 = "1" Then

                Else
                    Menu_de_utilitarios.util5.Enabled = False
                End If
                util6 = datos.Tables("detperfil").Rows(36).Item("itemactivo")
                If util6 = "1" Then

                Else
                    Menu_de_utilitarios.util6.Enabled = False
                End If
                xd.btnConfig.Enabled = False
                Main.btnMantenimientos.Enabled = False
                Main.btnMovimientos.Enabled = False
                Main.btnConfig.Enabled = False
                Main.btnMantenimientos.Visible = False
                Main.btnCuentasCobrar.Top = 86
                Main.btnCuentasPagar.Top = 126
                Main.btnUtilitarios.Top = 166
                xd.btnConfig.Visible = False
                conexion.Close()
            End If
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    Public Sub permisos()
        Try
            If IsAdmin = "1" Then
                Exit Sub
            ElseIf IsAdmin = "2" Then
                limitado()
            ElseIf IsAdmin = "3" Then
                limitado()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Try
            If Usuario.Text = "" Or Password.Text = "" Then
                lblError.Text = "Llena todos los campos"
                lblError.Visible = True
                Usuario.Focus()
            Else
                Main.Close()
                Dim dt As New DataTable
                Dim conexion As New SqlConnection(My.Settings.conexionglobal)
                Dim datos As New DataSet
                Dim Consulta As String = "Select NombreUsuario, contraseña ,Id_perfil from usuarios where NombreUsuario = '" & Usuario.Text & "'"
                Dim comando As New SqlCommand(Consulta, conexion)
                Dim drd As SqlDataReader
                conexion.Open()
                drd = comando.ExecuteReader
                If drd.Read() Then
                    Dim idus = drd.Item("NombreUsuario").ToString()
                    Dim pass As String = drd.Item("contraseña").ToString()
                    IsAdmin = drd.Item("Id_perfil").ToString()
                    If UCase(idus) = UCase(Trim(Usuario.Text)) And pass = Trim(Password.Text) Then
                        My.Settings.NombreUsuario = Usuario.Text
                        My.Settings.Save()
                        My.Settings.Reload()
                        Main.btnUsuario.Text = idus
                        permisos()
                        Usuario.Text = ""
                        Password.Text = ""
                        conexion.Close()
                        conexion.Open()
                        Dim da As New SqlDataAdapter("select * from fotos where Nombreusuario='" + idus + "'", conexion)
                        Dim ds As New DataSet
                        da.Fill(ds)
                        Dim c As Integer = ds.Tables(0).Rows.Count
                        If c > 0 Then
                            Dim bytBLOBData() As Byte =
                                    ds.Tables(0).Rows(c - 1)("FOTO")
                            Dim stmBLOBData As New MemoryStream(bytBLOBData)
                            Main.picfoto.Image = Image.FromStream(stmBLOBData)
                            conexion.Close()
                            Me.Hide()
                            Main.Show()
                        Else
                            conexion.Close()
                            Me.Hide()
                            Main.Show()
                        End If
                    Else
                        lblError.Visible = True
                        lblError.Text = "Nombre de usuario o contraseña incorrecto"
                        Password.Focus()
                        Password.SelectAll()
                    End If
                Else
                    drd.Close()
                    conexion.Close()
                End If
                drd.Close()
                conexion.Close()
            End If
        Catch ex As Exception
            lblError.Text = "Error al establicer conexion con el servidor"
            lblError.Visible = True
        End Try

    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Visible = False Then
            Carga.Hide()
        Else
            End
        End If

    End Sub


End Class