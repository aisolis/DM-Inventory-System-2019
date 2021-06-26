<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.WebBrowserClima = New System.Windows.Forms.WebBrowser()
        Me.PanelDerecha = New System.Windows.Forms.Panel()
        Me.btnQue = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picfoto = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.PanelIndicador6 = New System.Windows.Forms.Panel()
        Me.PanelIndicador5 = New System.Windows.Forms.Panel()
        Me.PanelIndicador4 = New System.Windows.Forms.Panel()
        Me.PanelIndicador3 = New System.Windows.Forms.Panel()
        Me.PanelIndicador2 = New System.Windows.Forms.Panel()
        Me.PanelIndicador1 = New System.Windows.Forms.Panel()
        Me.btnUtilitarios = New System.Windows.Forms.Button()
        Me.btnCuentasPagar = New System.Windows.Forms.Button()
        Me.btnTamaño = New System.Windows.Forms.Button()
        Me.btnCuentasCobrar = New System.Windows.Forms.Button()
        Me.btnMantenimientos = New System.Windows.Forms.Button()
        Me.btnMovimientos = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.pcbFondo = New System.Windows.Forms.PictureBox()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelDerecha.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLateral.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.pcbFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.WebBrowserClima)
        Me.PanelSuperior.Controls.Add(Me.PanelDerecha)
        Me.PanelSuperior.Controls.Add(Me.pcbLogo)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1099, 50)
        Me.PanelSuperior.TabIndex = 0
        '
        'WebBrowserClima
        '
        Me.WebBrowserClima.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebBrowserClima.Location = New System.Drawing.Point(769, 0)
        Me.WebBrowserClima.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserClima.Name = "WebBrowserClima"
        Me.WebBrowserClima.Size = New System.Drawing.Size(20, 50)
        Me.WebBrowserClima.TabIndex = 26
        Me.WebBrowserClima.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowserClima.Visible = False
        Me.WebBrowserClima.WebBrowserShortcutsEnabled = False
        '
        'PanelDerecha
        '
        Me.PanelDerecha.Controls.Add(Me.btnQue)
        Me.PanelDerecha.Controls.Add(Me.btnConfig)
        Me.PanelDerecha.Controls.Add(Me.Panel1)
        Me.PanelDerecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDerecha.Location = New System.Drawing.Point(789, 0)
        Me.PanelDerecha.Name = "PanelDerecha"
        Me.PanelDerecha.Size = New System.Drawing.Size(310, 50)
        Me.PanelDerecha.TabIndex = 1
        '
        'btnQue
        '
        Me.btnQue.FlatAppearance.BorderSize = 0
        Me.btnQue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQue.Image = Global.Disermo_Project.My.Resources.Resources.help_20px
        Me.btnQue.Location = New System.Drawing.Point(52, 7)
        Me.btnQue.Name = "btnQue"
        Me.btnQue.Size = New System.Drawing.Size(30, 37)
        Me.btnQue.TabIndex = 2
        Me.btnQue.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Image = Global.Disermo_Project.My.Resources.Resources.settings_20px
        Me.btnConfig.Location = New System.Drawing.Point(85, 7)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(30, 37)
        Me.btnConfig.TabIndex = 1
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picfoto)
        Me.Panel1.Controls.Add(Me.btnUsuario)
        Me.Panel1.Controls.Add(Me.btnCerrarSesion)
        Me.Panel1.Location = New System.Drawing.Point(123, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(171, 37)
        Me.Panel1.TabIndex = 0
        '
        'picfoto
        '
        Me.picfoto.BackColor = System.Drawing.Color.DarkGray
        Me.picfoto.Location = New System.Drawing.Point(133, 4)
        Me.picfoto.Name = "picfoto"
        Me.picfoto.Size = New System.Drawing.Size(30, 30)
        Me.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto.TabIndex = 1
        Me.picfoto.TabStop = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.Location = New System.Drawing.Point(42, 0)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnUsuario.Size = New System.Drawing.Size(126, 37)
        Me.btnUsuario.TabIndex = 2
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Image = Global.Disermo_Project.My.Resources.Resources.logout_rounded_up_20px
        Me.btnCerrarSesion.Location = New System.Drawing.Point(6, 0)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(30, 37)
        Me.btnCerrarSesion.TabIndex = 1
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'pcbLogo
        '
        Me.pcbLogo.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.Alargado_2
        Me.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbLogo.Location = New System.Drawing.Point(12, 7)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(178, 39)
        Me.pcbLogo.TabIndex = 0
        Me.pcbLogo.TabStop = False
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelLateral.Controls.Add(Me.PanelIndicador6)
        Me.PanelLateral.Controls.Add(Me.PanelIndicador5)
        Me.PanelLateral.Controls.Add(Me.PanelIndicador4)
        Me.PanelLateral.Controls.Add(Me.PanelIndicador3)
        Me.PanelLateral.Controls.Add(Me.PanelIndicador2)
        Me.PanelLateral.Controls.Add(Me.PanelIndicador1)
        Me.PanelLateral.Controls.Add(Me.btnUtilitarios)
        Me.PanelLateral.Controls.Add(Me.btnCuentasPagar)
        Me.PanelLateral.Controls.Add(Me.btnTamaño)
        Me.PanelLateral.Controls.Add(Me.btnCuentasCobrar)
        Me.PanelLateral.Controls.Add(Me.btnMantenimientos)
        Me.PanelLateral.Controls.Add(Me.btnMovimientos)
        Me.PanelLateral.Controls.Add(Me.btnInicio)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 50)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(200, 536)
        Me.PanelLateral.TabIndex = 1
        '
        'PanelIndicador6
        '
        Me.PanelIndicador6.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelIndicador6.Location = New System.Drawing.Point(0, 241)
        Me.PanelIndicador6.Name = "PanelIndicador6"
        Me.PanelIndicador6.Size = New System.Drawing.Size(3, 40)
        Me.PanelIndicador6.TabIndex = 9
        '
        'PanelIndicador5
        '
        Me.PanelIndicador5.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelIndicador5.Location = New System.Drawing.Point(0, 201)
        Me.PanelIndicador5.Name = "PanelIndicador5"
        Me.PanelIndicador5.Size = New System.Drawing.Size(3, 40)
        Me.PanelIndicador5.TabIndex = 9
        '
        'PanelIndicador4
        '
        Me.PanelIndicador4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelIndicador4.Location = New System.Drawing.Point(0, 161)
        Me.PanelIndicador4.Name = "PanelIndicador4"
        Me.PanelIndicador4.Size = New System.Drawing.Size(3, 40)
        Me.PanelIndicador4.TabIndex = 9
        '
        'PanelIndicador3
        '
        Me.PanelIndicador3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelIndicador3.Location = New System.Drawing.Point(0, 121)
        Me.PanelIndicador3.Name = "PanelIndicador3"
        Me.PanelIndicador3.Size = New System.Drawing.Size(3, 40)
        Me.PanelIndicador3.TabIndex = 8
        '
        'PanelIndicador2
        '
        Me.PanelIndicador2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelIndicador2.Location = New System.Drawing.Point(0, 81)
        Me.PanelIndicador2.Name = "PanelIndicador2"
        Me.PanelIndicador2.Size = New System.Drawing.Size(3, 40)
        Me.PanelIndicador2.TabIndex = 8
        '
        'PanelIndicador1
        '
        Me.PanelIndicador1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PanelIndicador1.Location = New System.Drawing.Point(0, 41)
        Me.PanelIndicador1.Name = "PanelIndicador1"
        Me.PanelIndicador1.Size = New System.Drawing.Size(3, 40)
        Me.PanelIndicador1.TabIndex = 7
        '
        'btnUtilitarios
        '
        Me.btnUtilitarios.FlatAppearance.BorderSize = 0
        Me.btnUtilitarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUtilitarios.Image = Global.Disermo_Project.My.Resources.Resources.box_20px
        Me.btnUtilitarios.Location = New System.Drawing.Point(0, 239)
        Me.btnUtilitarios.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUtilitarios.Name = "btnUtilitarios"
        Me.btnUtilitarios.Size = New System.Drawing.Size(200, 40)
        Me.btnUtilitarios.TabIndex = 6
        Me.btnUtilitarios.Text = "     Utilitarios                   "
        Me.btnUtilitarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUtilitarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUtilitarios.UseVisualStyleBackColor = True
        '
        'btnCuentasPagar
        '
        Me.btnCuentasPagar.FlatAppearance.BorderSize = 0
        Me.btnCuentasPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentasPagar.Image = Global.Disermo_Project.My.Resources.Resources.request_money_filled_20px
        Me.btnCuentasPagar.Location = New System.Drawing.Point(0, 200)
        Me.btnCuentasPagar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCuentasPagar.Name = "btnCuentasPagar"
        Me.btnCuentasPagar.Size = New System.Drawing.Size(200, 40)
        Me.btnCuentasPagar.TabIndex = 5
        Me.btnCuentasPagar.Text = "     Cuentas por Pagar  "
        Me.btnCuentasPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentasPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCuentasPagar.UseVisualStyleBackColor = True
        '
        'btnTamaño
        '
        Me.btnTamaño.FlatAppearance.BorderSize = 0
        Me.btnTamaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTamaño.Image = Global.Disermo_Project.My.Resources.Resources.menu_20px
        Me.btnTamaño.Location = New System.Drawing.Point(0, 0)
        Me.btnTamaño.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTamaño.Name = "btnTamaño"
        Me.btnTamaño.Size = New System.Drawing.Size(200, 40)
        Me.btnTamaño.TabIndex = 4
        Me.btnTamaño.Text = "                                         "
        Me.btnTamaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTamaño.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTamaño.UseVisualStyleBackColor = True
        '
        'btnCuentasCobrar
        '
        Me.btnCuentasCobrar.FlatAppearance.BorderSize = 0
        Me.btnCuentasCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentasCobrar.Image = Global.Disermo_Project.My.Resources.Resources.initiate_money_transfer_filled_20px
        Me.btnCuentasCobrar.Location = New System.Drawing.Point(0, 160)
        Me.btnCuentasCobrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCuentasCobrar.Name = "btnCuentasCobrar"
        Me.btnCuentasCobrar.Size = New System.Drawing.Size(200, 40)
        Me.btnCuentasCobrar.TabIndex = 3
        Me.btnCuentasCobrar.Text = "     Cuentas por Cobrar "
        Me.btnCuentasCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentasCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCuentasCobrar.UseVisualStyleBackColor = True
        '
        'btnMantenimientos
        '
        Me.btnMantenimientos.FlatAppearance.BorderSize = 0
        Me.btnMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimientos.Image = Global.Disermo_Project.My.Resources.Resources.maintenance_20px
        Me.btnMantenimientos.Location = New System.Drawing.Point(0, 120)
        Me.btnMantenimientos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMantenimientos.Name = "btnMantenimientos"
        Me.btnMantenimientos.Size = New System.Drawing.Size(200, 40)
        Me.btnMantenimientos.TabIndex = 2
        Me.btnMantenimientos.Text = "     Mantenimientos       "
        Me.btnMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMantenimientos.UseVisualStyleBackColor = True
        '
        'btnMovimientos
        '
        Me.btnMovimientos.FlatAppearance.BorderSize = 0
        Me.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovimientos.Image = Global.Disermo_Project.My.Resources.Resources.move_by_trolley_20px
        Me.btnMovimientos.Location = New System.Drawing.Point(0, 80)
        Me.btnMovimientos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.Size = New System.Drawing.Size(200, 40)
        Me.btnMovimientos.TabIndex = 1
        Me.btnMovimientos.Text = "     Movimientos             "
        Me.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMovimientos.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.Location = New System.Drawing.Point(0, 40)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(200, 40)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "     Inicio                          "
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.AutoScroll = True
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.Control
        Me.PanelContenedor.Controls.Add(Me.pcbFondo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(200, 50)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(899, 536)
        Me.PanelContenedor.TabIndex = 402
        '
        'pcbFondo
        '
        Me.pcbFondo.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.Logo_Cuadrado_BN2
        Me.pcbFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbFondo.Location = New System.Drawing.Point(49, 41)
        Me.pcbFondo.Name = "pcbFondo"
        Me.pcbFondo.Size = New System.Drawing.Size(160, 160)
        Me.pcbFondo.TabIndex = 0
        Me.pcbFondo.TabStop = False
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1090, 600)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelDerecha.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.pcbFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents PanelIndicador1 As Panel
    Friend WithEvents PanelIndicador6 As Panel
    Friend WithEvents PanelIndicador5 As Panel
    Friend WithEvents PanelIndicador4 As Panel
    Friend WithEvents PanelIndicador3 As Panel
    Friend WithEvents PanelIndicador2 As Panel
    Friend WithEvents PanelDerecha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnQue As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents pcbFondo As PictureBox
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnCuentasCobrar As Button
    Friend WithEvents btnMantenimientos As Button
    Friend WithEvents btnMovimientos As Button
    Friend WithEvents btnTamaño As Button
    Friend WithEvents btnUtilitarios As Button
    Friend WithEvents btnCuentasPagar As Button
    Friend WithEvents WebBrowserClima As WebBrowser
    Friend WithEvents picfoto As PictureBoxAbouAmmar.صورة_دائرة
End Class
