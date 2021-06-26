<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clima
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
        Me.panelnoether = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelClima = New System.Windows.Forms.Label()
        Me.LabelTemp = New System.Windows.Forms.Label()
        Me.LabelCiudad = New System.Windows.Forms.Label()
        Me.TimerClima = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowserClima = New System.Windows.Forms.WebBrowser()
        Me.llblGoogleWeather = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBClima = New System.Windows.Forms.PictureBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.panelnoether.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBClima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelnoether
        '
        Me.panelnoether.BackColor = System.Drawing.SystemColors.Control
        Me.panelnoether.Controls.Add(Me.Label10)
        Me.panelnoether.Controls.Add(Me.Label9)
        Me.panelnoether.Controls.Add(Me.PictureBox1)
        Me.panelnoether.Location = New System.Drawing.Point(23, 50)
        Me.panelnoether.Name = "panelnoether"
        Me.panelnoether.Size = New System.Drawing.Size(297, 124)
        Me.panelnoether.TabIndex = 26
        Me.panelnoether.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(123, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 32)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Comprueba tu conexión" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e intentalo de nuevo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(123, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 32)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Parece que no estas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "conectado a internet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Disermo_Project.My.Resources.Resources.tumblr_ogi47qqlfI1utgp6co1_400
        Me.PictureBox1.Location = New System.Drawing.Point(23, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(18, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Clima"
        '
        'LabelClima
        '
        Me.LabelClima.BackColor = System.Drawing.Color.Transparent
        Me.LabelClima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClima.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelClima.Location = New System.Drawing.Point(106, 101)
        Me.LabelClima.Name = "LabelClima"
        Me.LabelClima.Size = New System.Drawing.Size(194, 29)
        Me.LabelClima.TabIndex = 27
        Me.LabelClima.Text = "Clima"
        '
        'LabelTemp
        '
        Me.LabelTemp.AutoSize = True
        Me.LabelTemp.BackColor = System.Drawing.Color.Transparent
        Me.LabelTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelTemp.Location = New System.Drawing.Point(104, 50)
        Me.LabelTemp.Name = "LabelTemp"
        Me.LabelTemp.Size = New System.Drawing.Size(44, 31)
        Me.LabelTemp.TabIndex = 26
        Me.LabelTemp.Text = "00"
        '
        'LabelCiudad
        '
        Me.LabelCiudad.AutoSize = True
        Me.LabelCiudad.BackColor = System.Drawing.Color.Transparent
        Me.LabelCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelCiudad.Location = New System.Drawing.Point(106, 81)
        Me.LabelCiudad.Name = "LabelCiudad"
        Me.LabelCiudad.Size = New System.Drawing.Size(59, 20)
        Me.LabelCiudad.TabIndex = 25
        Me.LabelCiudad.Text = "Ciudad"
        '
        'TimerClima
        '
        '
        'WebBrowserClima
        '
        Me.WebBrowserClima.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebBrowserClima.Location = New System.Drawing.Point(326, 0)
        Me.WebBrowserClima.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserClima.Name = "WebBrowserClima"
        Me.WebBrowserClima.Size = New System.Drawing.Size(20, 226)
        Me.WebBrowserClima.TabIndex = 27
        Me.WebBrowserClima.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowserClima.Visible = False
        Me.WebBrowserClima.WebBrowserShortcutsEnabled = False
        '
        'llblGoogleWeather
        '
        Me.llblGoogleWeather.AutoSize = True
        Me.llblGoogleWeather.LinkColor = System.Drawing.Color.Gray
        Me.llblGoogleWeather.Location = New System.Drawing.Point(199, 137)
        Me.llblGoogleWeather.Name = "llblGoogleWeather"
        Me.llblGoogleWeather.Size = New System.Drawing.Size(65, 13)
        Me.llblGoogleWeather.TabIndex = 32
        Me.llblGoogleWeather.TabStop = True
        Me.llblGoogleWeather.Text = "Weater.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(107, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Datos extraidos de"
        '
        'PBClima
        '
        Me.PBClima.BackColor = System.Drawing.Color.Transparent
        Me.PBClima.Location = New System.Drawing.Point(40, 57)
        Me.PBClima.Name = "PBClima"
        Me.PBClima.Size = New System.Drawing.Size(48, 46)
        Me.PBClima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBClima.TabIndex = 24
        Me.PBClima.TabStop = False
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Highlight
        Me.Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Aceptar.FlatAppearance.BorderSize = 0
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar.ForeColor = System.Drawing.Color.White
        Me.Aceptar.Location = New System.Drawing.Point(219, 187)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(101, 27)
        Me.Aceptar.TabIndex = 32
        Me.Aceptar.Text = "&Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'Clima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.panelnoether)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.llblGoogleWeather)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelClima)
        Me.Controls.Add(Me.LabelTemp)
        Me.Controls.Add(Me.WebBrowserClima)
        Me.Controls.Add(Me.LabelCiudad)
        Me.Controls.Add(Me.PBClima)
        Me.Name = "Clima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clima"
        Me.panelnoether.ResumeLayout(False)
        Me.panelnoether.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBClima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelnoether As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelClima As Label
    Friend WithEvents LabelTemp As Label
    Friend WithEvents LabelCiudad As Label
    Friend WithEvents PBClima As PictureBox
    Friend WithEvents TimerClima As Timer
    Friend WithEvents WebBrowserClima As WebBrowser
    Friend WithEvents llblGoogleWeather As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Aceptar As Button
End Class
