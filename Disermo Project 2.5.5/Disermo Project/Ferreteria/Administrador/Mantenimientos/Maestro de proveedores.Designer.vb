<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maestro_de_proveedores
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDiasTramite = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ChkbImportador = New System.Windows.Forms.CheckBox()
        Me.txtCel2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiasCredito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcontacto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoProv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(13, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(219, 24)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Maestro De Proveedores"
        '
        'txtDiasTramite
        '
        Me.txtDiasTramite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDiasTramite.Location = New System.Drawing.Point(477, 298)
        Me.txtDiasTramite.MaxLength = 3
        Me.txtDiasTramite.Name = "txtDiasTramite"
        Me.txtDiasTramite.Size = New System.Drawing.Size(40, 22)
        Me.txtDiasTramite.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(371, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 16)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Días de Trámite:"
        '
        'ChkbImportador
        '
        Me.ChkbImportador.AutoSize = True
        Me.ChkbImportador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ChkbImportador.Location = New System.Drawing.Point(109, 299)
        Me.ChkbImportador.Name = "ChkbImportador"
        Me.ChkbImportador.Size = New System.Drawing.Size(61, 20)
        Me.ChkbImportador.TabIndex = 13
        Me.ChkbImportador.Text = "Sí/No"
        Me.ChkbImportador.UseVisualStyleBackColor = True
        '
        'txtCel2
        '
        Me.txtCel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCel2.Location = New System.Drawing.Point(374, 269)
        Me.txtCel2.MaxLength = 8
        Me.txtCel2.Name = "txtCel2"
        Me.txtCel2.Size = New System.Drawing.Size(144, 22)
        Me.txtCel2.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(339, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 16)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Cel:"
        '
        'txtnit
        '
        Me.txtnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnit.Location = New System.Drawing.Point(369, 136)
        Me.txtnit.MaxLength = 13
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(149, 22)
        Me.txtnit.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(339, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 16)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Nit:"
        '
        'txtDiasCredito
        '
        Me.txtDiasCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDiasCredito.Location = New System.Drawing.Point(115, 163)
        Me.txtDiasCredito.MaxLength = 3
        Me.txtDiasCredito.Name = "txtDiasCredito"
        Me.txtDiasCredito.Size = New System.Drawing.Size(55, 22)
        Me.txtDiasCredito.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(12, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Días de crédito:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEmail.Location = New System.Drawing.Point(115, 209)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(402, 22)
        Me.txtEmail.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(12, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Email:"
        '
        'txtcontacto
        '
        Me.txtcontacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcontacto.Location = New System.Drawing.Point(109, 266)
        Me.txtcontacto.MaxLength = 8
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(204, 22)
        Me.txtcontacto.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(12, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Contacto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(12, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Importador:"
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txttelefono.Location = New System.Drawing.Point(115, 136)
        Me.txttelefono.MaxLength = 8
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(178, 22)
        Me.txttelefono.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Teléfonos:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtDireccion.Location = New System.Drawing.Point(115, 107)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(403, 22)
        Me.txtDireccion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nombre:"
        '
        'txtCodigoProv
        '
        Me.txtCodigoProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtCodigoProv.Location = New System.Drawing.Point(115, 49)
        Me.txtCodigoProv.MaxLength = 3
        Me.txtCodigoProv.Name = "txtCodigoProv"
        Me.txtCodigoProv.Size = New System.Drawing.Size(106, 22)
        Me.txtCodigoProv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Código Prov.:"
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(302, 359)
        Me.btnreporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Padding = New System.Windows.Forms.Padding(4)
        Me.btnreporte.Size = New System.Drawing.Size(100, 35)
        Me.btnreporte.TabIndex = 405
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Image = Global.Disermo_Project.My.Resources.Resources.btnCancel
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(302, 409)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Size = New System.Drawing.Size(100, 35)
        Me.btncancelar.TabIndex = 404
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Image = Global.Disermo_Project.My.Resources.Resources.btnEliminar
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(198, 409)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Padding = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Size = New System.Drawing.Size(100, 35)
        Me.btneliminar.TabIndex = 403
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Image = Global.Disermo_Project.My.Resources.Resources.btnBuscar
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.Location = New System.Drawing.Point(198, 359)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Size = New System.Drawing.Size(100, 35)
        Me.btnbuscar.TabIndex = 402
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = Global.Disermo_Project.My.Resources.Resources.btnGuardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(94, 409)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnGrabar.Size = New System.Drawing.Size(100, 35)
        Me.btnGrabar.TabIndex = 401
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Image = Global.Disermo_Project.My.Resources.Resources.btnAñadir
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.Location = New System.Drawing.Point(94, 359)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 400
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(561, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(634, 408)
        Me.DataGridView1.TabIndex = 406
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombre.Location = New System.Drawing.Point(114, 79)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(403, 22)
        Me.txtnombre.TabIndex = 407
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Maestro_de_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 498)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDiasTramite)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ChkbImportador)
        Me.Controls.Add(Me.txtCel2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDiasCredito)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcontacto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoProv)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Maestro_de_proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro_de_proveedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDiasTramite As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ChkbImportador As CheckBox
    Friend WithEvents txtCel2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDiasCredito As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcontacto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoProv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Timer1 As Timer
End Class
