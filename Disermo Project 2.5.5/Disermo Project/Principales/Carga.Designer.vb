<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carga
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carga))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCarga1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCargaDescrpitivo = New System.Windows.Forms.Label()
        Me.tmrConexDB = New System.Windows.Forms.Timer(Me.components)
        Me.tmrInternet = New System.Windows.Forms.Timer(Me.components)
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrArchivos = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.ForeColor = System.Drawing.Color.Gray
        Me.lblVersion.Location = New System.Drawing.Point(20, 78)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(144, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Administrador Disermo v1.0.0"
        '
        'lblCarga1
        '
        Me.lblCarga1.AutoSize = True
        Me.lblCarga1.ForeColor = System.Drawing.Color.Gray
        Me.lblCarga1.Location = New System.Drawing.Point(20, 208)
        Me.lblCarga1.Name = "lblCarga1"
        Me.lblCarga1.Size = New System.Drawing.Size(39, 13)
        Me.lblCarga1.TabIndex = 3
        Me.lblCarga1.Text = "Label1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(20, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Abduzcan Team Software TM"
        '
        'lblCargaDescrpitivo
        '
        Me.lblCargaDescrpitivo.AutoSize = True
        Me.lblCargaDescrpitivo.ForeColor = System.Drawing.Color.Gray
        Me.lblCargaDescrpitivo.Location = New System.Drawing.Point(20, 222)
        Me.lblCargaDescrpitivo.Name = "lblCargaDescrpitivo"
        Me.lblCargaDescrpitivo.Size = New System.Drawing.Size(39, 13)
        Me.lblCargaDescrpitivo.TabIndex = 5
        Me.lblCargaDescrpitivo.Text = "Label2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tmrConexDB
        '
        Me.tmrConexDB.Interval = 3000
        '
        'tmrInternet
        '
        Me.tmrInternet.Interval = 3000
        '
        'pcbLogo
        '
        Me.pcbLogo.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.Alargado_2
        Me.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbLogo.Location = New System.Drawing.Point(23, 22)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(239, 53)
        Me.pcbLogo.TabIndex = 1
        Me.pcbLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.FONDO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(210, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 188)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'tmrArchivos
        '
        Me.tmrArchivos.Interval = 2000
        '
        'Carga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(443, 257)
        Me.Controls.Add(Me.lblCargaDescrpitivo)
        Me.Controls.Add(Me.lblCarga1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.pcbLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Carga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga"
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCarga1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCargaDescrpitivo As Label
    Friend WithEvents tmrConexDB As Timer
    Friend WithEvents tmrInternet As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrArchivos As Timer
End Class
