<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Municipios
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
        Me.txtidmunicipio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidurta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidsubruta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsubruta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtiddepartamento = New System.Windows.Forms.TextBox()
        Me.chkbactivo = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtmunicipio = New System.Windows.Forms.TextBox()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.txtdepartamento = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(257, 24)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "Mantenimiento de municipios"
        '
        'txtidmunicipio
        '
        Me.txtidmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidmunicipio.Location = New System.Drawing.Point(96, 52)
        Me.txtidmunicipio.MaxLength = 3
        Me.txtidmunicipio.Name = "txtidmunicipio"
        Me.txtidmunicipio.Size = New System.Drawing.Size(95, 22)
        Me.txtidmunicipio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Id Municipio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(13, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(13, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Id Ruta:"
        '
        'txtidurta
        '
        Me.txtidurta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidurta.Location = New System.Drawing.Point(96, 108)
        Me.txtidurta.MaxLength = 3
        Me.txtidurta.Name = "txtidurta"
        Me.txtidurta.Size = New System.Drawing.Size(95, 22)
        Me.txtidurta.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(196, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Ruta:"
        '
        'txtidsubruta
        '
        Me.txtidsubruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidsubruta.Location = New System.Drawing.Point(412, 108)
        Me.txtidsubruta.MaxLength = 3
        Me.txtidsubruta.Name = "txtidsubruta"
        Me.txtidsubruta.Size = New System.Drawing.Size(152, 22)
        Me.txtidsubruta.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(339, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Id Subruta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(605, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Subruta:"
        '
        'txtsubruta
        '
        Me.txtsubruta.Enabled = False
        Me.txtsubruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubruta.Location = New System.Drawing.Point(670, 111)
        Me.txtsubruta.Name = "txtsubruta"
        Me.txtsubruta.Size = New System.Drawing.Size(199, 22)
        Me.txtsubruta.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(569, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Departamento:"
        '
        'txtiddepartamento
        '
        Me.txtiddepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtiddepartamento.Location = New System.Drawing.Point(670, 80)
        Me.txtiddepartamento.MaxLength = 3
        Me.txtiddepartamento.Name = "txtiddepartamento"
        Me.txtiddepartamento.Size = New System.Drawing.Size(40, 22)
        Me.txtiddepartamento.TabIndex = 4
        '
        'chkbactivo
        '
        Me.chkbactivo.AutoSize = True
        Me.chkbactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkbactivo.Location = New System.Drawing.Point(808, 57)
        Me.chkbactivo.Name = "chkbactivo"
        Me.chkbactivo.Size = New System.Drawing.Size(61, 20)
        Me.chkbactivo.TabIndex = 2
        Me.chkbactivo.Text = "Sí/No"
        Me.chkbactivo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(759, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "Activo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(860, 212)
        Me.DataGridView1.TabIndex = 155
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(531, 364)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Padding = New System.Windows.Forms.Padding(4)
        Me.btnReporte.Size = New System.Drawing.Size(100, 35)
        Me.btnReporte.TabIndex = 419
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.Disermo_Project.My.Resources.Resources.btnCancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(427, 364)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.btnCancelar.TabIndex = 418
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.Disermo_Project.My.Resources.Resources.btnEliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(323, 364)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 35)
        Me.BtnEliminar.TabIndex = 417
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.Disermo_Project.My.Resources.Resources.btnBuscar
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(219, 364)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Padding = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Size = New System.Drawing.Size(100, 35)
        Me.BtnBuscar.TabIndex = 416
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Image = Global.Disermo_Project.My.Resources.Resources.btnGuardar
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(115, 364)
        Me.BtnGrabar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Padding = New System.Windows.Forms.Padding(4)
        Me.BtnGrabar.Size = New System.Drawing.Size(100, 35)
        Me.BtnGrabar.TabIndex = 415
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGrabar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = Global.Disermo_Project.My.Resources.Resources.btnAñadir
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(11, 364)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Padding = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Size = New System.Drawing.Size(100, 35)
        Me.BtnAgregar.TabIndex = 414
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtmunicipio.Location = New System.Drawing.Point(96, 80)
        Me.txtmunicipio.MaxLength = 50
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(467, 22)
        Me.txtmunicipio.TabIndex = 420
        '
        'txtruta
        '
        Me.txtruta.Enabled = False
        Me.txtruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtruta.Location = New System.Drawing.Point(241, 107)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(95, 22)
        Me.txtruta.TabIndex = 421
        '
        'txtdepartamento
        '
        Me.txtdepartamento.Enabled = False
        Me.txtdepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdepartamento.Location = New System.Drawing.Point(712, 80)
        Me.txtdepartamento.Name = "txtdepartamento"
        Me.txtdepartamento.Size = New System.Drawing.Size(157, 22)
        Me.txtdepartamento.TabIndex = 422
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Municipios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 410)
        Me.Controls.Add(Me.txtdepartamento)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.txtmunicipio)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.chkbactivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtiddepartamento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsubruta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtidsubruta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtidurta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidmunicipio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Municipios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents txtidmunicipio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidurta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidsubruta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsubruta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtiddepartamento As TextBox
    Friend WithEvents chkbactivo As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents txtmunicipio As TextBox
    Friend WithEvents txtruta As TextBox
    Friend WithEvents txtdepartamento As TextBox
    Friend WithEvents Timer1 As Timer
End Class
