<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblpuesto = New System.Windows.Forms.Label()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.txttel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fotopic = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.fotopic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Highlight
        Me.Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Aceptar.FlatAppearance.BorderSize = 0
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar.ForeColor = System.Drawing.Color.White
        Me.Aceptar.Location = New System.Drawing.Point(305, 217)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(101, 27)
        Me.Aceptar.TabIndex = 33
        Me.Aceptar.Text = "&Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(157, 39)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(167, 25)
        Me.lblNombre.TabIndex = 35
        Me.lblNombre.Text = "Nombre Usuario"
        '
        'lblpuesto
        '
        Me.lblpuesto.AutoSize = True
        Me.lblpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpuesto.Location = New System.Drawing.Point(158, 68)
        Me.lblpuesto.Name = "lblpuesto"
        Me.lblpuesto.Size = New System.Drawing.Size(131, 18)
        Me.lblpuesto.TabIndex = 36
        Me.lblpuesto.Text = "Puesto del usuario"
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.Location = New System.Drawing.Point(158, 93)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(131, 18)
        Me.lblcorreo.TabIndex = 37
        Me.lblcorreo.Text = "Correo de Usuario"
        '
        'txttel
        '
        Me.txttel.AutoSize = True
        Me.txttel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(158, 116)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(141, 18)
        Me.txttel.TabIndex = 38
        Me.txttel.Text = "Numero del Usuario"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(198, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 27)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Administrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Salmon
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 27)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Cerrar Sesion"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fotopic
        '
        Me.fotopic.BackColor = System.Drawing.Color.DarkGray
        Me.fotopic.Location = New System.Drawing.Point(33, 28)
        Me.fotopic.Name = "fotopic"
        Me.fotopic.Size = New System.Drawing.Size(100, 99)
        Me.fotopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotopic.TabIndex = 42
        Me.fotopic.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabel1.Location = New System.Drawing.Point(47, 136)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 13)
        Me.LinkLabel1.TabIndex = 43
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Editar Imagen"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.fotopic)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.lblpuesto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Aceptar)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        CType(Me.fotopic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Aceptar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblpuesto As Label
    Friend WithEvents lblcorreo As Label
    Friend WithEvents txttel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents fotopic As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
