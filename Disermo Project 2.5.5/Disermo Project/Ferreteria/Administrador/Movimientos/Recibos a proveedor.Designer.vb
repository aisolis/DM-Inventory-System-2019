<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recibos_a_proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recibos_a_proveedor))
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdocumento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkbanulado = New System.Windows.Forms.CheckBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvalorrecibido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbforma = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtchequeno = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtidbanco = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbbanco = New System.Windows.Forms.ComboBox()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.btnmodificarfila = New System.Windows.Forms.Button()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.txtproducto = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(13, 446)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(577, 16)
        Me.Label17.TabIndex = 292
        Me.Label17.Text = "Detalle de Envio. En El cuadro precione [ESC] para salir o [ENTER] para consulta " &
    "de productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 160)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(860, 284)
        Me.DataGridView1.TabIndex = 281
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidproveedor.Location = New System.Drawing.Point(121, 56)
        Me.txtidproveedor.MaxLength = 5
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(104, 22)
        Me.txtidproveedor.TabIndex = 306
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(17, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 307
        Me.Label1.Text = "Proveedor:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 24)
        Me.Label15.TabIndex = 305
        Me.Label15.Text = "Recibos Proveedor"
        '
        'txtserie
        '
        Me.txtserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtserie.Location = New System.Drawing.Point(121, 82)
        Me.txtserie.MaxLength = 5
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(104, 22)
        Me.txtserie.TabIndex = 311
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 312
        Me.Label2.Text = "Serie del recibo:"
        '
        'txtdocumento
        '
        Me.txtdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdocumento.Location = New System.Drawing.Point(403, 82)
        Me.txtdocumento.MaxLength = 5
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.Size = New System.Drawing.Size(131, 22)
        Me.txtdocumento.TabIndex = 313
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(303, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 314
        Me.Label3.Text = "Recibo No.:"
        '
        'chkbanulado
        '
        Me.chkbanulado.AutoSize = True
        Me.chkbanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkbanulado.Location = New System.Drawing.Point(597, 86)
        Me.chkbanulado.Name = "chkbanulado"
        Me.chkbanulado.Size = New System.Drawing.Size(77, 20)
        Me.chkbanulado.TabIndex = 316
        Me.chkbanulado.Text = "Anulado"
        Me.chkbanulado.UseVisualStyleBackColor = True
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfecha.Location = New System.Drawing.Point(786, 85)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(92, 22)
        Me.txtfecha.TabIndex = 315
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(717, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 317
        Me.Label7.Text = "Fecha:"
        '
        'txtvalorrecibido
        '
        Me.txtvalorrecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtvalorrecibido.Location = New System.Drawing.Point(121, 107)
        Me.txtvalorrecibido.MaxLength = 6
        Me.txtvalorrecibido.Name = "txtvalorrecibido"
        Me.txtvalorrecibido.Size = New System.Drawing.Size(104, 22)
        Me.txtvalorrecibido.TabIndex = 325
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(17, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 326
        Me.Label8.Text = "Valor Recibido:"
        '
        'cmbforma
        '
        Me.cmbforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbforma.FormattingEnabled = True
        Me.cmbforma.Items.AddRange(New Object() {"efectivo", "credito"})
        Me.cmbforma.Location = New System.Drawing.Point(403, 106)
        Me.cmbforma.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbforma.Name = "cmbforma"
        Me.cmbforma.Size = New System.Drawing.Size(131, 24)
        Me.cmbforma.TabIndex = 327
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(303, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 328
        Me.Label9.Text = "Forma de pago:"
        '
        'txtefectivo
        '
        Me.txtefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtefectivo.Location = New System.Drawing.Point(786, 109)
        Me.txtefectivo.MaxLength = 6
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(92, 22)
        Me.txtefectivo.TabIndex = 329
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(718, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 330
        Me.Label10.Text = "Efectivo:"
        '
        'txtvalor
        '
        Me.txtvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtvalor.Location = New System.Drawing.Point(786, 133)
        Me.txtvalor.MaxLength = 6
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(92, 22)
        Me.txtvalor.TabIndex = 331
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(717, 138)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 16)
        Me.Label18.TabIndex = 332
        Me.Label18.Text = "Valor:"
        '
        'txtchequeno
        '
        Me.txtchequeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtchequeno.Location = New System.Drawing.Point(403, 133)
        Me.txtchequeno.MaxLength = 6
        Me.txtchequeno.Name = "txtchequeno"
        Me.txtchequeno.Size = New System.Drawing.Size(131, 22)
        Me.txtchequeno.TabIndex = 333
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(302, 135)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 16)
        Me.Label20.TabIndex = 334
        Me.Label20.Text = "Cheque No.:"
        '
        'txtidbanco
        '
        Me.txtidbanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidbanco.Location = New System.Drawing.Point(121, 133)
        Me.txtidbanco.MaxLength = 5
        Me.txtidbanco.Name = "txtidbanco"
        Me.txtidbanco.Size = New System.Drawing.Size(50, 22)
        Me.txtidbanco.TabIndex = 335
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(17, 135)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 16)
        Me.Label21.TabIndex = 336
        Me.Label21.Text = "Banco:"
        '
        'cmbbanco
        '
        Me.cmbbanco.Enabled = False
        Me.cmbbanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbbanco.FormattingEnabled = True
        Me.cmbbanco.Location = New System.Drawing.Point(176, 132)
        Me.cmbbanco.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbbanco.Name = "cmbbanco"
        Me.cmbbanco.Size = New System.Drawing.Size(119, 24)
        Me.cmbbanco.TabIndex = 337
        '
        'txt_producto
        '
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_producto.Location = New System.Drawing.Point(73, 487)
        Me.txt_producto.MaxLength = 4
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(111, 22)
        Me.txt_producto.TabIndex = 511
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubtotal.Location = New System.Drawing.Point(811, 516)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(60, 22)
        Me.txtsubtotal.TabIndex = 510
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(768, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 509
        Me.Label4.Text = "Total:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprecio.Location = New System.Drawing.Point(596, 516)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(60, 22)
        Me.txtprecio.TabIndex = 505
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(544, 519)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 16)
        Me.Label23.TabIndex = 508
        Me.Label23.Text = "Precio:"
        '
        'txtexistencia
        '
        Me.txtexistencia.Enabled = False
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtexistencia.Location = New System.Drawing.Point(329, 516)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(79, 22)
        Me.txtexistencia.TabIndex = 504
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(258, 519)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 507
        Me.Label24.Text = "Existencia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcantidad.Location = New System.Drawing.Point(73, 516)
        Me.txtcantidad.MaxLength = 4
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(60, 22)
        Me.txtcantidad.TabIndex = 503
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(10, 519)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 506
        Me.Label26.Text = "Cantidad:"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(504, 592)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Size = New System.Drawing.Size(100, 35)
        Me.btnModificar.TabIndex = 502
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(156, 630)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(123, 31)
        Me.txttotal.TabIndex = 501
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(618, 639)
        Me.btnreporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Padding = New System.Windows.Forms.Padding(4)
        Me.btnreporte.Size = New System.Drawing.Size(100, 35)
        Me.btnreporte.TabIndex = 500
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
        Me.btncancelar.Location = New System.Drawing.Point(504, 639)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Size = New System.Drawing.Size(100, 35)
        Me.btncancelar.TabIndex = 499
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
        Me.btneliminar.Location = New System.Drawing.Point(749, 592)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Padding = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Size = New System.Drawing.Size(100, 35)
        Me.btneliminar.TabIndex = 498
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
        Me.btnbuscar.Location = New System.Drawing.Point(626, 592)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Size = New System.Drawing.Size(100, 35)
        Me.btnbuscar.TabIndex = 497
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Image = Global.Disermo_Project.My.Resources.Resources.btnAñadir
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.Location = New System.Drawing.Point(382, 592)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 496
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(115, 638)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 16)
        Me.Label25.TabIndex = 495
        Me.Label25.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(13, 605)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 494
        Me.Label5.Text = "Totales"
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btneliminarfila.Location = New System.Drawing.Point(744, 550)
        Me.btneliminarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(118, 28)
        Me.btneliminarfila.TabIndex = 492
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'btnmodificarfila
        '
        Me.btnmodificarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnmodificarfila.Location = New System.Drawing.Point(381, 550)
        Me.btnmodificarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificarfila.Name = "btnmodificarfila"
        Me.btnmodificarfila.Size = New System.Drawing.Size(118, 28)
        Me.btnmodificarfila.TabIndex = 491
        Me.btnmodificarfila.Text = "Modificar Fila"
        Me.btnmodificarfila.UseVisualStyleBackColor = True
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btninsertarfila.Location = New System.Drawing.Point(9, 550)
        Me.btninsertarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(118, 28)
        Me.btninsertarfila.TabIndex = 490
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproducto.FormattingEnabled = True
        Me.txtproducto.Location = New System.Drawing.Point(189, 487)
        Me.txtproducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(682, 24)
        Me.txtproducto.TabIndex = 489
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label32.Location = New System.Drawing.Point(9, 490)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(65, 16)
        Me.Label32.TabIndex = 493
        Me.Label32.Text = "Producto:"
        '
        'txtproveedor
        '
        Me.txtproveedor.Enabled = False
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproveedor.Location = New System.Drawing.Point(231, 56)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(647, 22)
        Me.txtproveedor.TabIndex = 512
        '
        'Recibos_a_proveedor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(898, 694)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btneliminarfila)
        Me.Controls.Add(Me.btnmodificarfila)
        Me.Controls.Add(Me.btninsertarfila)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cmbbanco)
        Me.Controls.Add(Me.txtidbanco)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtchequeno)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtefectivo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbforma)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtvalorrecibido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkbanulado)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdocumento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidproveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Recibos_a_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibos_a_proveedor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdocumento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkbanulado As CheckBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvalorrecibido As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbforma As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtefectivo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtchequeno As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtidbanco As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbbanco As ComboBox
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents btnmodificarfila As Button
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents txtproducto As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtproveedor As TextBox
End Class
