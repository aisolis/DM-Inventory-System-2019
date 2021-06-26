<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carga2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carga2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCargaDescrpitivo = New System.Windows.Forms.Label()
        Me.lblCarga1 = New System.Windows.Forms.Label()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.TimerCarga = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(61, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Abduzcan Team Software TM"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.ForeColor = System.Drawing.Color.Gray
        Me.lblVersion.Location = New System.Drawing.Point(63, 301)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(144, 13)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "Administrador Disermo v1.0.0"
        '
        'lblCargaDescrpitivo
        '
        Me.lblCargaDescrpitivo.ForeColor = System.Drawing.Color.Gray
        Me.lblCargaDescrpitivo.Location = New System.Drawing.Point(29, 246)
        Me.lblCargaDescrpitivo.Name = "lblCargaDescrpitivo"
        Me.lblCargaDescrpitivo.Size = New System.Drawing.Size(217, 32)
        Me.lblCargaDescrpitivo.TabIndex = 12
        Me.lblCargaDescrpitivo.Text = "Label2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCargaDescrpitivo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCarga1
        '
        Me.lblCarga1.ForeColor = System.Drawing.Color.Gray
        Me.lblCarga1.Location = New System.Drawing.Point(29, 231)
        Me.lblCarga1.Name = "lblCarga1"
        Me.lblCarga1.Size = New System.Drawing.Size(217, 17)
        Me.lblCarga1.TabIndex = 11
        Me.lblCarga1.Text = "Label1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCarga1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pcbLogo
        '
        Me.pcbLogo.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.Alargado_2
        Me.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbLogo.Location = New System.Drawing.Point(74, 89)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(131, 54)
        Me.pcbLogo.TabIndex = 10
        Me.pcbLogo.TabStop = False
        '
        'TimerCarga
        '
        Me.TimerCarga.Enabled = True
        Me.TimerCarga.Interval = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'BunifuElipse1
        '

        '
        'Carga2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(275, 365)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCargaDescrpitivo)
        Me.Controls.Add(Me.lblCarga1)
        Me.Controls.Add(Me.pcbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Carga2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga2"
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCargaDescrpitivo As Label
    Friend WithEvents lblCarga1 As Label
    Friend WithEvents pcbLogo As PictureBox

    Friend WithEvents TimerCarga As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
