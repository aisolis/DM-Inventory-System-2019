<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xd
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xd))
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnGuardarNota = New System.Windows.Forms.Button()
        Me.notas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLDOLAR = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConversor = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnWeb = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.Herram = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUltima = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerclima = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowserClima = New System.Windows.Forms.WebBrowser()
        Me.id_perf = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.lblClima = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pcbClima = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblguardar = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbClima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Controls.Add(Me.lblguardar)
        Me.Panel7.Controls.Add(Me.btnGuardarNota)
        Me.Panel7.Controls.Add(Me.notas)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(18, 288)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(393, 208)
        Me.Panel7.TabIndex = 18
        '
        'btnGuardarNota
        '
        Me.btnGuardarNota.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnGuardarNota.FlatAppearance.BorderSize = 0
        Me.btnGuardarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarNota.ForeColor = System.Drawing.Color.White
        Me.btnGuardarNota.Location = New System.Drawing.Point(286, 162)
        Me.btnGuardarNota.Name = "btnGuardarNota"
        Me.btnGuardarNota.Size = New System.Drawing.Size(87, 27)
        Me.btnGuardarNota.TabIndex = 8
        Me.btnGuardarNota.Text = "Guardar"
        Me.btnGuardarNota.UseVisualStyleBackColor = False
        '
        'notas
        '
        Me.notas.Location = New System.Drawing.Point(17, 48)
        Me.notas.Multiline = True
        Me.notas.Name = "notas"
        Me.notas.Size = New System.Drawing.Size(356, 108)
        Me.notas.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Notas"
        '
        'LBLDOLAR
        '
        Me.LBLDOLAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDOLAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBLDOLAR.Location = New System.Drawing.Point(317, 44)
        Me.LBLDOLAR.Name = "LBLDOLAR"
        Me.LBLDOLAR.Size = New System.Drawing.Size(84, 25)
        Me.LBLDOLAR.TabIndex = 24
        Me.LBLDOLAR.Text = "DOLAR"
        Me.LBLDOLAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(274, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "$ = Q:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnConversor)
        Me.Panel2.Controls.Add(Me.btnAyuda)
        Me.Panel2.Controls.Add(Me.btnWeb)
        Me.Panel2.Controls.Add(Me.btnCalc)
        Me.Panel2.Controls.Add(Me.btnConfig)
        Me.Panel2.Controls.Add(Me.Herram)
        Me.Panel2.Location = New System.Drawing.Point(422, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 187)
        Me.Panel2.TabIndex = 19
        '
        'btnConversor
        '
        Me.btnConversor.BackColor = System.Drawing.Color.LightGray
        Me.btnConversor.FlatAppearance.BorderSize = 0
        Me.btnConversor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConversor.Image = Global.Disermo_Project.My.Resources.Resources.currency_exchange_25px
        Me.btnConversor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConversor.Location = New System.Drawing.Point(200, 50)
        Me.btnConversor.Name = "btnConversor"
        Me.btnConversor.Size = New System.Drawing.Size(86, 55)
        Me.btnConversor.TabIndex = 6
        Me.btnConversor.Text = "Conversor"
        Me.btnConversor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConversor.UseVisualStyleBackColor = False
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.LightGray
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Image = Global.Disermo_Project.My.Resources.Resources.help_25px
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(16, 111)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(86, 55)
        Me.btnAyuda.TabIndex = 5
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'btnWeb
        '
        Me.btnWeb.BackColor = System.Drawing.Color.LightGray
        Me.btnWeb.FlatAppearance.BorderSize = 0
        Me.btnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeb.Image = Global.Disermo_Project.My.Resources.Resources.web_25px
        Me.btnWeb.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWeb.Location = New System.Drawing.Point(292, 50)
        Me.btnWeb.Name = "btnWeb"
        Me.btnWeb.Size = New System.Drawing.Size(86, 55)
        Me.btnWeb.TabIndex = 4
        Me.btnWeb.Text = "Sitio Web"
        Me.btnWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWeb.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.LightGray
        Me.btnCalc.FlatAppearance.BorderSize = 0
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Image = Global.Disermo_Project.My.Resources.Resources.calculator_25px
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalc.Location = New System.Drawing.Point(108, 50)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(86, 55)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculadora"
        Me.btnCalc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.LightGray
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Image = Global.Disermo_Project.My.Resources.Resources.settings_25px
        Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfig.Location = New System.Drawing.Point(16, 50)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(86, 55)
        Me.btnConfig.TabIndex = 2
        Me.btnConfig.Text = "Ajustes"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'Herram
        '
        Me.Herram.AutoSize = True
        Me.Herram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Herram.Location = New System.Drawing.Point(13, 16)
        Me.Herram.Name = "Herram"
        Me.Herram.Size = New System.Drawing.Size(133, 20)
        Me.Herram.TabIndex = 1
        Me.Herram.Text = "Accesos Directos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnUltima)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(18, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 187)
        Me.Panel1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button1.Size = New System.Drawing.Size(356, 55)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "     Penultimo Form Abierto"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnUltima
        '
        Me.btnUltima.BackColor = System.Drawing.Color.LightGray
        Me.btnUltima.FlatAppearance.BorderSize = 0
        Me.btnUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltima.Image = CType(resources.GetObject("btnUltima.Image"), System.Drawing.Image)
        Me.btnUltima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUltima.Location = New System.Drawing.Point(17, 50)
        Me.btnUltima.Name = "btnUltima"
        Me.btnUltima.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnUltima.Size = New System.Drawing.Size(356, 55)
        Me.btnUltima.TabIndex = 2
        Me.btnUltima.Text = "     Ultimo Form Abierto"
        Me.btnUltima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUltima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUltima.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tareas Recientes"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timerclima
        '
        Me.timerclima.Interval = 10
        '
        'WebBrowserClima
        '
        Me.WebBrowserClima.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebBrowserClima.Location = New System.Drawing.Point(843, 0)
        Me.WebBrowserClima.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserClima.Name = "WebBrowserClima"
        Me.WebBrowserClima.Size = New System.Drawing.Size(20, 539)
        Me.WebBrowserClima.TabIndex = 25
        Me.WebBrowserClima.Url = New System.Uri("https://www.google.com.gt/#q=clima+gt", System.UriKind.Absolute)
        Me.WebBrowserClima.Visible = False
        Me.WebBrowserClima.WebBrowserShortcutsEnabled = False
        '
        'id_perf
        '
        Me.id_perf.AutoSize = True
        Me.id_perf.Location = New System.Drawing.Point(420, 291)
        Me.id_perf.Name = "id_perf"
        Me.id_perf.Size = New System.Drawing.Size(13, 13)
        Me.id_perf.TabIndex = 26
        Me.id_perf.Text = "1"
        Me.id_perf.Visible = False
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(439, 288)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(100, 20)
        Me.usuario.TabIndex = 27
        Me.usuario.Visible = False
        '
        'lblClima
        '
        Me.lblClima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClima.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClima.Location = New System.Drawing.Point(417, 46)
        Me.lblClima.Name = "lblClima"
        Me.lblClima.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClima.Size = New System.Drawing.Size(63, 20)
        Me.lblClima.TabIndex = 29
        Me.lblClima.Text = "¿?"
        Me.lblClima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(516, 46)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFecha.Size = New System.Drawing.Size(201, 20)
        Me.lblFecha.TabIndex = 30
        Me.lblFecha.Text = "FECHA"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(723, 46)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHora.Size = New System.Drawing.Size(92, 20)
        Me.lblHora.TabIndex = 31
        Me.lblHora.Text = "HORA"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblBienvenida.Location = New System.Drawing.Point(12, 41)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(125, 25)
        Me.lblBienvenida.TabIndex = 28
        Me.lblBienvenida.Text = "Bienvenido "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.NoClima
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Disermo_Project.My.Resources.Resources.banknotes_filled_20px
        Me.PictureBox1.Location = New System.Drawing.Point(251, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.Disermo_Project.My.Resources.Resources.clock_20px
        Me.PictureBox3.Location = New System.Drawing.Point(720, 46)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'pcbClima
        '
        Me.pcbClima.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.NoClima
        Me.pcbClima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbClima.Location = New System.Drawing.Point(395, 46)
        Me.pcbClima.Name = "pcbClima"
        Me.pcbClima.Size = New System.Drawing.Size(20, 20)
        Me.pcbClima.TabIndex = 33
        Me.pcbClima.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Disermo_Project.My.Resources.Resources.calendar_20px
        Me.PictureBox2.Location = New System.Drawing.Point(490, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'lblguardar
        '
        Me.lblguardar.AutoSize = True
        Me.lblguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguardar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblguardar.Location = New System.Drawing.Point(14, 169)
        Me.lblguardar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblguardar.Name = "lblguardar"
        Me.lblguardar.Size = New System.Drawing.Size(153, 13)
        Me.lblguardar.TabIndex = 35
        Me.lblguardar.Text = "Se han actualizado tus notas..."
        Me.lblguardar.Visible = False
        '
        'Timer2
        '
        '
        'xd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 539)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pcbClima)
        Me.Controls.Add(Me.LBLDOLAR)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblClima)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.WebBrowserClima)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.id_perf)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "xd"
        Me.Text = "xd"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbClima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents notas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConversor As Button
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnWeb As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents Herram As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBLDOLAR As Label
    Friend WithEvents timerclima As Timer
    Friend WithEvents WebBrowserClima As WebBrowser
    Friend WithEvents id_perf As Label
    Friend WithEvents usuario As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pcbClima As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblClima As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUltima As Button
    Friend WithEvents btnGuardarNota As Button
    Friend WithEvents lblguardar As Label
    Friend WithEvents Timer2 As Timer
End Class
