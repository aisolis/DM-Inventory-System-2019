<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maestro_de_vendedores
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
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIdSupervisor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdSubGerente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdRegion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreSupervisor = New System.Windows.Forms.TextBox()
        Me.txtNombreSubGerente = New System.Windows.Forms.TextBox()
        Me.txtNombreRegion = New System.Windows.Forms.TextBox()
        Me.ChkbVendActivo = New System.Windows.Forms.CheckBox()
        Me.txtIdRuta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreRuta = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtnombrevendedor = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIdVendedor.Location = New System.Drawing.Point(116, 61)
        Me.txtIdVendedor.MaxLength = 3
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(69, 22)
        Me.txtIdVendedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Vendedor:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(216, 24)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Maestro De Vendedores"
        '
        'txtIdSupervisor
        '
        Me.txtIdSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIdSupervisor.Location = New System.Drawing.Point(116, 91)
        Me.txtIdSupervisor.MaxLength = 3
        Me.txtIdSupervisor.Name = "txtIdSupervisor"
        Me.txtIdSupervisor.Size = New System.Drawing.Size(68, 22)
        Me.txtIdSupervisor.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(9, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Id Supervisor:"
        '
        'txtIdSubGerente
        '
        Me.txtIdSubGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIdSubGerente.Location = New System.Drawing.Point(116, 119)
        Me.txtIdSubGerente.MaxLength = 3
        Me.txtIdSubGerente.Name = "txtIdSubGerente"
        Me.txtIdSubGerente.Size = New System.Drawing.Size(69, 22)
        Me.txtIdSubGerente.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(9, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Id SubGerente:"
        '
        'txtIdRegion
        '
        Me.txtIdRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIdRegion.Location = New System.Drawing.Point(116, 149)
        Me.txtIdRegion.MaxLength = 3
        Me.txtIdRegion.Name = "txtIdRegion"
        Me.txtIdRegion.Size = New System.Drawing.Size(69, 22)
        Me.txtIdRegion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(9, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Id Región:"
        '
        'txtNombreSupervisor
        '
        Me.txtNombreSupervisor.Enabled = False
        Me.txtNombreSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNombreSupervisor.Location = New System.Drawing.Point(197, 90)
        Me.txtNombreSupervisor.Name = "txtNombreSupervisor"
        Me.txtNombreSupervisor.Size = New System.Drawing.Size(530, 22)
        Me.txtNombreSupervisor.TabIndex = 8
        '
        'txtNombreSubGerente
        '
        Me.txtNombreSubGerente.Enabled = False
        Me.txtNombreSubGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNombreSubGerente.Location = New System.Drawing.Point(197, 119)
        Me.txtNombreSubGerente.Name = "txtNombreSubGerente"
        Me.txtNombreSubGerente.Size = New System.Drawing.Size(530, 22)
        Me.txtNombreSubGerente.TabIndex = 10
        '
        'txtNombreRegion
        '
        Me.txtNombreRegion.Enabled = False
        Me.txtNombreRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNombreRegion.Location = New System.Drawing.Point(197, 149)
        Me.txtNombreRegion.Name = "txtNombreRegion"
        Me.txtNombreRegion.Size = New System.Drawing.Size(198, 22)
        Me.txtNombreRegion.TabIndex = 12
        '
        'ChkbVendActivo
        '
        Me.ChkbVendActivo.AutoSize = True
        Me.ChkbVendActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ChkbVendActivo.Location = New System.Drawing.Point(600, 35)
        Me.ChkbVendActivo.Name = "ChkbVendActivo"
        Me.ChkbVendActivo.Size = New System.Drawing.Size(127, 20)
        Me.ChkbVendActivo.TabIndex = 6
        Me.ChkbVendActivo.Text = "Vendedor Activo"
        Me.ChkbVendActivo.UseVisualStyleBackColor = True
        '
        'txtIdRuta
        '
        Me.txtIdRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIdRuta.Location = New System.Drawing.Point(507, 152)
        Me.txtIdRuta.MaxLength = 3
        Me.txtIdRuta.Name = "txtIdRuta"
        Me.txtIdRuta.Size = New System.Drawing.Size(82, 22)
        Me.txtIdRuta.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(401, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Ruta Asignada:"
        '
        'txtNombreRuta
        '
        Me.txtNombreRuta.Enabled = False
        Me.txtNombreRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNombreRuta.Location = New System.Drawing.Point(594, 152)
        Me.txtNombreRuta.Name = "txtNombreRuta"
        Me.txtNombreRuta.Size = New System.Drawing.Size(133, 22)
        Me.txtNombreRuta.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(721, 170)
        Me.DataGridView1.TabIndex = 57
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(524, 369)
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
        Me.btncancelar.Location = New System.Drawing.Point(420, 369)
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
        Me.btneliminar.Location = New System.Drawing.Point(316, 369)
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
        Me.btnbuscar.Location = New System.Drawing.Point(212, 369)
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
        Me.btnGrabar.Location = New System.Drawing.Point(108, 369)
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
        Me.btnagregar.Location = New System.Drawing.Point(4, 369)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 400
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'txtnombrevendedor
        '
        Me.txtnombrevendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombrevendedor.Location = New System.Drawing.Point(197, 61)
        Me.txtnombrevendedor.Name = "txtnombrevendedor"
        Me.txtnombrevendedor.Size = New System.Drawing.Size(530, 22)
        Me.txtnombrevendedor.TabIndex = 406
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Maestro_de_vendedores
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(734, 427)
        Me.Controls.Add(Me.txtnombrevendedor)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNombreRuta)
        Me.Controls.Add(Me.txtIdRuta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ChkbVendActivo)
        Me.Controls.Add(Me.txtNombreRegion)
        Me.Controls.Add(Me.txtNombreSubGerente)
        Me.Controls.Add(Me.txtNombreSupervisor)
        Me.Controls.Add(Me.txtIdRegion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdSubGerente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdSupervisor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Maestro_de_vendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro_de_vendedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIdSupervisor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdSubGerente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdRegion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreSupervisor As TextBox
    Friend WithEvents txtNombreSubGerente As TextBox
    Friend WithEvents txtNombreRegion As TextBox
    Friend WithEvents ChkbVendActivo As CheckBox
    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreRuta As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtnombrevendedor As TextBox
    Friend WithEvents Timer1 As Timer
End Class
