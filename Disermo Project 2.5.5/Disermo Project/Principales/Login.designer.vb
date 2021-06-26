<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class Ingreso
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
        Dim PanelSuperior As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso))
        Me.llblRapido = New System.Windows.Forms.LinkLabel()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.btnQue = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelults3 = New System.Windows.Forms.Panel()
        Me.lblus3 = New System.Windows.Forms.Label()
        Me.picfoto3 = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.Panelults2 = New System.Windows.Forms.Panel()
        Me.lblus2 = New System.Windows.Forms.Label()
        Me.picfoto2 = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.Panelults1 = New System.Windows.Forms.Panel()
        Me.lblus1 = New System.Windows.Forms.Label()
        Me.picfoto1 = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.PanelIngreso = New System.Windows.Forms.Panel()
        Me.llblRegresarPanelNormal = New System.Windows.Forms.LinkLabel()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelIngresoEspecial = New System.Windows.Forms.Panel()
        Me.llblRegresarPanelEspecial = New System.Windows.Forms.LinkLabel()
        Me.aceptar2 = New System.Windows.Forms.Button()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.picfot = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.password2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelUsuarios = New System.Windows.Forms.Panel()
        Me.llblOtroUsuario = New System.Windows.Forms.LinkLabel()
        PanelSuperior = New System.Windows.Forms.Panel()
        PanelSuperior.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelults3.SuspendLayout()
        CType(Me.picfoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelults2.SuspendLayout()
        CType(Me.picfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelults1.SuspendLayout()
        CType(Me.picfoto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIngreso.SuspendLayout()
        Me.PanelIngresoEspecial.SuspendLayout()
        CType(Me.picfot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        PanelSuperior.Controls.Add(Me.llblRapido)
        PanelSuperior.Controls.Add(Me.pcbLogo)
        PanelSuperior.Controls.Add(Me.btnQue)
        PanelSuperior.Dock = System.Windows.Forms.DockStyle.Left
        PanelSuperior.Location = New System.Drawing.Point(0, 0)
        PanelSuperior.Name = "PanelSuperior"
        PanelSuperior.Size = New System.Drawing.Size(224, 391)
        PanelSuperior.TabIndex = 6
        AddHandler PanelSuperior.DoubleClick, AddressOf Me.PanelSuperior_DoubleClick
        '
        'llblRapido
        '
        Me.llblRapido.AutoSize = True
        Me.llblRapido.LinkColor = System.Drawing.Color.Gray
        Me.llblRapido.Location = New System.Drawing.Point(19, 350)
        Me.llblRapido.Name = "llblRapido"
        Me.llblRapido.Size = New System.Drawing.Size(78, 15)
        Me.llblRapido.TabIndex = 10
        Me.llblRapido.TabStop = True
        Me.llblRapido.Text = "Pase Rapido"
        '
        'pcbLogo
        '
        Me.pcbLogo.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.Alargado_2
        Me.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbLogo.Location = New System.Drawing.Point(22, 29)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(178, 39)
        Me.pcbLogo.TabIndex = 7
        Me.pcbLogo.TabStop = False
        '
        'btnQue
        '
        Me.btnQue.FlatAppearance.BorderSize = 0
        Me.btnQue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQue.Image = Global.Disermo_Project.My.Resources.Resources.help_20px
        Me.btnQue.Location = New System.Drawing.Point(170, 338)
        Me.btnQue.Name = "btnQue"
        Me.btnQue.Size = New System.Drawing.Size(30, 37)
        Me.btnQue.TabIndex = 8
        Me.btnQue.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ultimas sesiones activas"
        '
        'Panelults3
        '
        Me.Panelults3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panelults3.Controls.Add(Me.lblus3)
        Me.Panelults3.Controls.Add(Me.picfoto3)
        Me.Panelults3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panelults3.Location = New System.Drawing.Point(18, 165)
        Me.Panelults3.Name = "Panelults3"
        Me.Panelults3.Size = New System.Drawing.Size(206, 50)
        Me.Panelults3.TabIndex = 14
        Me.Panelults3.Visible = False
        '
        'lblus3
        '
        Me.lblus3.BackColor = System.Drawing.Color.Transparent
        Me.lblus3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblus3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblus3.Location = New System.Drawing.Point(56, 7)
        Me.lblus3.Name = "lblus3"
        Me.lblus3.Size = New System.Drawing.Size(138, 35)
        Me.lblus3.TabIndex = 15
        Me.lblus3.Text = "Usuario"
        Me.lblus3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picfoto3
        '
        Me.picfoto3.BackColor = System.Drawing.Color.DarkGray
        Me.picfoto3.Location = New System.Drawing.Point(11, 8)
        Me.picfoto3.Name = "picfoto3"
        Me.picfoto3.Size = New System.Drawing.Size(33, 32)
        Me.picfoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto3.TabIndex = 12
        Me.picfoto3.TabStop = False
        '
        'Panelults2
        '
        Me.Panelults2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panelults2.Controls.Add(Me.lblus2)
        Me.Panelults2.Controls.Add(Me.picfoto2)
        Me.Panelults2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panelults2.Location = New System.Drawing.Point(18, 109)
        Me.Panelults2.Name = "Panelults2"
        Me.Panelults2.Size = New System.Drawing.Size(206, 50)
        Me.Panelults2.TabIndex = 14
        Me.Panelults2.Visible = False
        '
        'lblus2
        '
        Me.lblus2.BackColor = System.Drawing.Color.Transparent
        Me.lblus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblus2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblus2.Location = New System.Drawing.Point(56, 7)
        Me.lblus2.Name = "lblus2"
        Me.lblus2.Size = New System.Drawing.Size(138, 35)
        Me.lblus2.TabIndex = 14
        Me.lblus2.Text = "Usuario"
        Me.lblus2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picfoto2
        '
        Me.picfoto2.BackColor = System.Drawing.Color.DarkGray
        Me.picfoto2.Location = New System.Drawing.Point(11, 8)
        Me.picfoto2.Name = "picfoto2"
        Me.picfoto2.Size = New System.Drawing.Size(33, 32)
        Me.picfoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto2.TabIndex = 12
        Me.picfoto2.TabStop = False
        '
        'Panelults1
        '
        Me.Panelults1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panelults1.Controls.Add(Me.lblus1)
        Me.Panelults1.Controls.Add(Me.picfoto1)
        Me.Panelults1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panelults1.Location = New System.Drawing.Point(18, 53)
        Me.Panelults1.Name = "Panelults1"
        Me.Panelults1.Size = New System.Drawing.Size(206, 50)
        Me.Panelults1.TabIndex = 13
        Me.Panelults1.Visible = False
        '
        'lblus1
        '
        Me.lblus1.BackColor = System.Drawing.Color.Transparent
        Me.lblus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblus1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblus1.Location = New System.Drawing.Point(56, 7)
        Me.lblus1.Name = "lblus1"
        Me.lblus1.Size = New System.Drawing.Size(138, 35)
        Me.lblus1.TabIndex = 13
        Me.lblus1.Text = "Usuario"
        Me.lblus1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picfoto1
        '
        Me.picfoto1.BackColor = System.Drawing.Color.DarkGray
        Me.picfoto1.Location = New System.Drawing.Point(11, 8)
        Me.picfoto1.Name = "picfoto1"
        Me.picfoto1.Size = New System.Drawing.Size(35, 35)
        Me.picfoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto1.TabIndex = 12
        Me.picfoto1.TabStop = False
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Aceptar.FlatAppearance.BorderSize = 0
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar.ForeColor = System.Drawing.Color.White
        Me.Aceptar.Location = New System.Drawing.Point(132, 166)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(101, 27)
        Me.Aceptar.TabIndex = 5
        Me.Aceptar.Text = "&Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(260, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Para recuperación de credenciales ponte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en contacto con el administrador."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblError
        '
        Me.lblError.ForeColor = System.Drawing.Color.Maroon
        Me.lblError.Location = New System.Drawing.Point(262, 276)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(227, 38)
        Me.lblError.TabIndex = 11
        Me.lblError.Text = "LABEL DE ERROR"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'PanelIngreso
        '
        Me.PanelIngreso.Controls.Add(Me.llblRegresarPanelNormal)
        Me.PanelIngreso.Controls.Add(Me.Password)
        Me.PanelIngreso.Controls.Add(Me.Aceptar)
        Me.PanelIngreso.Controls.Add(Me.PasswordLabel)
        Me.PanelIngreso.Controls.Add(Me.Usuario)
        Me.PanelIngreso.Controls.Add(Me.UsernameLabel)
        Me.PanelIngreso.Location = New System.Drawing.Point(253, 64)
        Me.PanelIngreso.Name = "PanelIngreso"
        Me.PanelIngreso.Size = New System.Drawing.Size(239, 205)
        Me.PanelIngreso.TabIndex = 13
        '
        'llblRegresarPanelNormal
        '
        Me.llblRegresarPanelNormal.AutoSize = True
        Me.llblRegresarPanelNormal.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.llblRegresarPanelNormal.Location = New System.Drawing.Point(4, 172)
        Me.llblRegresarPanelNormal.Name = "llblRegresarPanelNormal"
        Me.llblRegresarPanelNormal.Size = New System.Drawing.Size(58, 15)
        Me.llblRegresarPanelNormal.TabIndex = 19
        Me.llblRegresarPanelNormal.TabStop = True
        Me.llblRegresarPanelNormal.Text = "Regresar"
        '
        'Password
        '
        Me.Password.AcceptsReturn = True
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(7, 111)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(226, 22)
        Me.Password.TabIndex = 14
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasswordLabel.Location = New System.Drawing.Point(6, 89)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(77, 16)
        Me.PasswordLabel.TabIndex = 13
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Usuario
        '
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(7, 51)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(226, 22)
        Me.Usuario.TabIndex = 10
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(6, 29)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(123, 16)
        Me.UsernameLabel.TabIndex = 9
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(258, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Inicio de Sesión"
        '
        'PanelIngresoEspecial
        '
        Me.PanelIngresoEspecial.Controls.Add(Me.llblRegresarPanelEspecial)
        Me.PanelIngresoEspecial.Controls.Add(Me.aceptar2)
        Me.PanelIngresoEspecial.Controls.Add(Me.lblusuario)
        Me.PanelIngresoEspecial.Controls.Add(Me.picfot)
        Me.PanelIngresoEspecial.Controls.Add(Me.password2)
        Me.PanelIngresoEspecial.Controls.Add(Me.Label4)
        Me.PanelIngresoEspecial.Location = New System.Drawing.Point(533, 29)
        Me.PanelIngresoEspecial.Name = "PanelIngresoEspecial"
        Me.PanelIngresoEspecial.Size = New System.Drawing.Size(239, 240)
        Me.PanelIngresoEspecial.TabIndex = 15
        '
        'llblRegresarPanelEspecial
        '
        Me.llblRegresarPanelEspecial.AutoSize = True
        Me.llblRegresarPanelEspecial.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.llblRegresarPanelEspecial.Location = New System.Drawing.Point(4, 207)
        Me.llblRegresarPanelEspecial.Name = "llblRegresarPanelEspecial"
        Me.llblRegresarPanelEspecial.Size = New System.Drawing.Size(58, 15)
        Me.llblRegresarPanelEspecial.TabIndex = 18
        Me.llblRegresarPanelEspecial.TabStop = True
        Me.llblRegresarPanelEspecial.Text = "Regresar"
        '
        'aceptar2
        '
        Me.aceptar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.aceptar2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.aceptar2.FlatAppearance.BorderSize = 0
        Me.aceptar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptar2.ForeColor = System.Drawing.Color.White
        Me.aceptar2.Location = New System.Drawing.Point(132, 207)
        Me.aceptar2.Name = "aceptar2"
        Me.aceptar2.Size = New System.Drawing.Size(101, 21)
        Me.aceptar2.TabIndex = 17
        Me.aceptar2.Text = "&Aceptar"
        Me.aceptar2.UseVisualStyleBackColor = False
        '
        'lblusuario
        '
        Me.lblusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.Black
        Me.lblusuario.Location = New System.Drawing.Point(3, 72)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(233, 24)
        Me.lblusuario.TabIndex = 16
        Me.lblusuario.Text = "Bienvenido, USUARIO"
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picfot
        '
        Me.picfot.BackColor = System.Drawing.Color.DarkGray
        Me.picfot.Location = New System.Drawing.Point(89, 3)
        Me.picfot.Name = "picfot"
        Me.picfot.Size = New System.Drawing.Size(60, 60)
        Me.picfot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfot.TabIndex = 15
        Me.picfot.TabStop = False
        '
        'password2
        '
        Me.password2.AcceptsReturn = True
        Me.password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password2.Location = New System.Drawing.Point(7, 146)
        Me.password2.Name = "password2"
        Me.password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password2.Size = New System.Drawing.Size(226, 22)
        Me.password2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(4, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "&Contraseña"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.user_male_circle_filled_30_2px
        Me.PictureBox1.Location = New System.Drawing.Point(456, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PanelUsuarios
        '
        Me.PanelUsuarios.Controls.Add(Me.llblOtroUsuario)
        Me.PanelUsuarios.Controls.Add(Me.Label2)
        Me.PanelUsuarios.Controls.Add(Me.Panelults3)
        Me.PanelUsuarios.Controls.Add(Me.Panelults1)
        Me.PanelUsuarios.Controls.Add(Me.Panelults2)
        Me.PanelUsuarios.Location = New System.Drawing.Point(823, 64)
        Me.PanelUsuarios.Name = "PanelUsuarios"
        Me.PanelUsuarios.Size = New System.Drawing.Size(239, 250)
        Me.PanelUsuarios.TabIndex = 19
        '
        'llblOtroUsuario
        '
        Me.llblOtroUsuario.AutoSize = True
        Me.llblOtroUsuario.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.llblOtroUsuario.Location = New System.Drawing.Point(14, 222)
        Me.llblOtroUsuario.Name = "llblOtroUsuario"
        Me.llblOtroUsuario.Size = New System.Drawing.Size(154, 15)
        Me.llblOtroUsuario.TabIndex = 19
        Me.llblOtroUsuario.TabStop = True
        Me.llblOtroUsuario.Text = "Ingresar como otro usuario"
        '
        'Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(514, 391)
        Me.Controls.Add(Me.PanelUsuarios)
        Me.Controls.Add(Me.PanelIngresoEspecial)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(PanelSuperior)
        Me.Controls.Add(Me.PanelIngreso)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        PanelSuperior.ResumeLayout(False)
        PanelSuperior.PerformLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelults3.ResumeLayout(False)
        CType(Me.picfoto3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelults2.ResumeLayout(False)
        CType(Me.picfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelults1.ResumeLayout(False)
        CType(Me.picfoto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIngreso.ResumeLayout(False)
        Me.PanelIngreso.PerformLayout()
        Me.PanelIngresoEspecial.ResumeLayout(False)
        Me.PanelIngresoEspecial.PerformLayout()
        CType(Me.picfot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuarios.ResumeLayout(False)
        Me.PanelUsuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQue As Button
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblError As Label
    Friend WithEvents llblRapido As LinkLabel
    Friend WithEvents Panelults1 As Panel
    Friend WithEvents picfoto1 As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents Panelults3 As Panel
    Friend WithEvents picfoto3 As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents Panelults2 As Panel
    Friend WithEvents picfoto2 As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents Label2 As Label
    Friend WithEvents lblus3 As Label
    Friend WithEvents lblus2 As Label
    Friend WithEvents lblus1 As Label
    Friend WithEvents PanelIngreso As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Usuario As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PanelIngresoEspecial As Panel
    Friend WithEvents lblusuario As Label
    Friend WithEvents picfot As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents password2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents aceptar2 As Button
    Friend WithEvents llblRegresarPanelEspecial As LinkLabel
    Friend WithEvents PanelUsuarios As Panel
    Friend WithEvents llblOtroUsuario As LinkLabel
    Friend WithEvents llblRegresarPanelNormal As LinkLabel
End Class
