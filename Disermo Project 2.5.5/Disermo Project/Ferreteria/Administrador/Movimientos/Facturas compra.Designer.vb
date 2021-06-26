<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturas_compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas_compra))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprov = New System.Windows.Forms.TextBox()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.btnmodificarfila = New System.Windows.Forms.Button()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.txtproducto = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtidvendedor = New System.Windows.Forms.TextBox()
        Me.txtfechavencimiento = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdiascredito = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnonit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefonos = New System.Windows.Forms.TextBox()
        Me.chkncredito = New System.Windows.Forms.CheckBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.chkbanulada = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtfacturano = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(859, 335)
        Me.DataGridView1.TabIndex = 513
        '
        'txt_producto
        '
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_producto.Location = New System.Drawing.Point(80, 601)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(111, 22)
        Me.txt_producto.TabIndex = 512
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubtotal.Location = New System.Drawing.Point(818, 630)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(60, 22)
        Me.txtsubtotal.TabIndex = 511
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(775, 633)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 510
        Me.Label13.Text = "Total:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprecio.Location = New System.Drawing.Point(603, 630)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(60, 22)
        Me.txtprecio.TabIndex = 506
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(551, 633)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 16)
        Me.Label23.TabIndex = 509
        Me.Label23.Text = "Precio:"
        '
        'txtexistencia
        '
        Me.txtexistencia.Enabled = False
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtexistencia.Location = New System.Drawing.Point(336, 630)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(79, 22)
        Me.txtexistencia.TabIndex = 505
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(265, 633)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 508
        Me.Label24.Text = "Existencia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcantidad.Location = New System.Drawing.Point(80, 630)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(60, 22)
        Me.txtcantidad.TabIndex = 504
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(17, 633)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 507
        Me.Label26.Text = "Cantidad:"
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(163, 744)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(123, 31)
        Me.txttotal.TabIndex = 502
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(122, 752)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 16)
        Me.Label25.TabIndex = 496
        Me.Label25.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Location = New System.Drawing.Point(20, 719)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 495
        Me.Label9.Text = "Totales"
        '
        'txtprov
        '
        Me.txtprov.Enabled = False
        Me.txtprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprov.Location = New System.Drawing.Point(172, 85)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.Size = New System.Drawing.Size(478, 22)
        Me.txtprov.TabIndex = 493
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btneliminarfila.Location = New System.Drawing.Point(751, 664)
        Me.btneliminarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(118, 28)
        Me.btneliminarfila.TabIndex = 470
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'btnmodificarfila
        '
        Me.btnmodificarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnmodificarfila.Location = New System.Drawing.Point(388, 664)
        Me.btnmodificarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificarfila.Name = "btnmodificarfila"
        Me.btnmodificarfila.Size = New System.Drawing.Size(118, 28)
        Me.btnmodificarfila.TabIndex = 469
        Me.btnmodificarfila.Text = "Modificar Fila"
        Me.btnmodificarfila.UseVisualStyleBackColor = True
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btninsertarfila.Location = New System.Drawing.Point(16, 664)
        Me.btninsertarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(118, 28)
        Me.btninsertarfila.TabIndex = 468
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproducto.FormattingEnabled = True
        Me.txtproducto.Location = New System.Drawing.Point(196, 601)
        Me.txtproducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(682, 24)
        Me.txtproducto.TabIndex = 467
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label32.Location = New System.Drawing.Point(16, 604)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(65, 16)
        Me.Label32.TabIndex = 491
        Me.Label32.Text = "Producto:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label33.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label33.Location = New System.Drawing.Point(16, 584)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(591, 16)
        Me.Label33.TabIndex = 490
        Me.Label33.Text = "Detalle de Compra. En El cuadro precione [ESC] para salir o [ENTER] para consulta" &
    " de productos"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(0, 212)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 16)
        Me.Label22.TabIndex = 489
        Me.Label22.Text = "Observaciones:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtobservaciones.Location = New System.Drawing.Point(109, 197)
        Me.txtobservaciones.MaxLength = 200
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(760, 57)
        Me.txtobservaciones.TabIndex = 466
        '
        'txtvendedor
        '
        Me.txtvendedor.Enabled = False
        Me.txtvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtvendedor.Location = New System.Drawing.Point(172, 168)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(293, 22)
        Me.txtvendedor.TabIndex = 458
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(15, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 16)
        Me.Label12.TabIndex = 482
        Me.Label12.Text = "Vendedor:"
        '
        'txtidvendedor
        '
        Me.txtidvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidvendedor.Location = New System.Drawing.Point(109, 169)
        Me.txtidvendedor.MaxLength = 5
        Me.txtidvendedor.Name = "txtidvendedor"
        Me.txtidvendedor.Size = New System.Drawing.Size(57, 22)
        Me.txtidvendedor.TabIndex = 457
        '
        'txtfechavencimiento
        '
        Me.txtfechavencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfechavencimiento.Location = New System.Drawing.Point(598, 168)
        Me.txtfechavencimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfechavencimiento.Mask = "00/00/0000"
        Me.txtfechavencimiento.Name = "txtfechavencimiento"
        Me.txtfechavencimiento.Size = New System.Drawing.Size(71, 22)
        Me.txtfechavencimiento.TabIndex = 455
        Me.txtfechavencimiento.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(471, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 16)
        Me.Label10.TabIndex = 480
        Me.Label10.Text = "Fecha vencimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(203, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 478
        Me.Label6.Text = "Días de crédito:"
        '
        'txtdiascredito
        '
        Me.txtdiascredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdiascredito.Location = New System.Drawing.Point(311, 139)
        Me.txtdiascredito.MaxLength = 3
        Me.txtdiascredito.Name = "txtdiascredito"
        Me.txtdiascredito.Size = New System.Drawing.Size(69, 22)
        Me.txtdiascredito.TabIndex = 453
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(15, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 477
        Me.Label5.Text = "No. de Nit:"
        '
        'txtnonit
        '
        Me.txtnonit.Enabled = False
        Me.txtnonit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnonit.Location = New System.Drawing.Point(109, 140)
        Me.txtnonit.Name = "txtnonit"
        Me.txtnonit.Size = New System.Drawing.Size(57, 22)
        Me.txtnonit.TabIndex = 452
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(15, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 476
        Me.Label4.Text = "Dirección:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdireccion.Location = New System.Drawing.Point(110, 112)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(765, 22)
        Me.txtdireccion.TabIndex = 451
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(656, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 475
        Me.Label3.Text = "Teléfonos:"
        '
        'txttelefonos
        '
        Me.txttelefonos.Enabled = False
        Me.txttelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txttelefonos.Location = New System.Drawing.Point(733, 83)
        Me.txttelefonos.Name = "txttelefonos"
        Me.txttelefonos.Size = New System.Drawing.Size(143, 22)
        Me.txttelefonos.TabIndex = 450
        '
        'chkncredito
        '
        Me.chkncredito.AutoSize = True
        Me.chkncredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkncredito.Location = New System.Drawing.Point(799, 60)
        Me.chkncredito.Name = "chkncredito"
        Me.chkncredito.Size = New System.Drawing.Size(70, 20)
        Me.chkncredito.TabIndex = 448
        Me.chkncredito.Text = "Credito"
        Me.chkncredito.UseVisualStyleBackColor = True
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfecha.Location = New System.Drawing.Point(389, 57)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(92, 22)
        Me.txtfecha.TabIndex = 446
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(343, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 474
        Me.Label7.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(15, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 473
        Me.Label2.Text = "Proveedor:"
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidproveedor.Location = New System.Drawing.Point(109, 85)
        Me.txtidproveedor.MaxLength = 5
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(57, 22)
        Me.txtidproveedor.TabIndex = 449
        '
        'txtserie
        '
        Me.txtserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtserie.Location = New System.Drawing.Point(172, 56)
        Me.txtserie.MaxLength = 5
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(165, 22)
        Me.txtserie.TabIndex = 445
        '
        'chkbanulada
        '
        Me.chkbanulada.AutoSize = True
        Me.chkbanulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkbanulada.Location = New System.Drawing.Point(799, 34)
        Me.chkbanulada.Name = "chkbanulada"
        Me.chkbanulada.Size = New System.Drawing.Size(77, 20)
        Me.chkbanulada.TabIndex = 447
        Me.chkbanulada.Text = "Anulada"
        Me.chkbanulada.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(11, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 24)
        Me.Label15.TabIndex = 472
        Me.Label15.Text = "Facturas compra"
        '
        'txtfacturano
        '
        Me.txtfacturano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfacturano.Location = New System.Drawing.Point(109, 57)
        Me.txtfacturano.MaxLength = 5
        Me.txtfacturano.Name = "txtfacturano"
        Me.txtfacturano.Size = New System.Drawing.Size(57, 22)
        Me.txtfacturano.TabIndex = 444
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(15, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 471
        Me.Label1.Text = "Factura No.:"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(511, 706)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Size = New System.Drawing.Size(100, 35)
        Me.btnModificar.TabIndex = 503
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(625, 753)
        Me.btnreporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Padding = New System.Windows.Forms.Padding(4)
        Me.btnreporte.Size = New System.Drawing.Size(100, 35)
        Me.btnreporte.TabIndex = 501
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
        Me.btncancelar.Location = New System.Drawing.Point(511, 753)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Size = New System.Drawing.Size(100, 35)
        Me.btncancelar.TabIndex = 500
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
        Me.btneliminar.Location = New System.Drawing.Point(756, 706)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Padding = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Size = New System.Drawing.Size(100, 35)
        Me.btneliminar.TabIndex = 499
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
        Me.btnbuscar.Location = New System.Drawing.Point(633, 706)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Size = New System.Drawing.Size(100, 35)
        Me.btnbuscar.TabIndex = 498
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
        Me.btnagregar.Location = New System.Drawing.Point(389, 706)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 497
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Facturas_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 741)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label13)
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
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtprov)
        Me.Controls.Add(Me.btneliminarfila)
        Me.Controls.Add(Me.btnmodificarfila)
        Me.Controls.Add(Me.btninsertarfila)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtidvendedor)
        Me.Controls.Add(Me.txtfechavencimiento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdiascredito)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnonit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttelefonos)
        Me.Controls.Add(Me.chkncredito)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidproveedor)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.chkbanulada)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtfacturano)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Facturas_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas_compra"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label13 As Label
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
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprov As TextBox
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents btnmodificarfila As Button
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents txtproducto As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents txtvendedor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtidvendedor As TextBox
    Friend WithEvents txtfechavencimiento As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdiascredito As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnonit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttelefonos As TextBox
    Friend WithEvents chkncredito As CheckBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents txtserie As TextBox
    Friend WithEvents chkbanulada As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtfacturano As TextBox
    Friend WithEvents Label1 As Label
End Class
