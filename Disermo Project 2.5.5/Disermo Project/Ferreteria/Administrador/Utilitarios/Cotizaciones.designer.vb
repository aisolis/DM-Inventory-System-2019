<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cotizaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cotizaciones))
        Me.lbl_noCotizacion = New System.Windows.Forms.Label()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_Obser = New System.Windows.Forms.Label()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_noCotizacion = New System.Windows.Forms.TextBox()
        Me.txt_obser = New System.Windows.Forms.TextBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_Cotizaciones = New System.Windows.Forms.Label()
        Me.txt_noNit = New System.Windows.Forms.TextBox()
        Me.lbl_noNit = New System.Windows.Forms.Label()
        Me.txt_vendedor1 = New System.Windows.Forms.TextBox()
        Me.lbl_vendedor = New System.Windows.Forms.Label()
        Me.txt_vendedor2 = New System.Windows.Forms.TextBox()
        Me.dgv_cotizacion = New System.Windows.Forms.DataGridView()
        Me.gb_detalleEnvio = New System.Windows.Forms.GroupBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.btn_EliminFila = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.lbl_Precio = New System.Windows.Forms.Label()
        Me.btn_ModifFila = New System.Windows.Forms.Button()
        Me.txt_existen = New System.Windows.Forms.TextBox()
        Me.lbl_Existencia = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.btn_InsertFila = New System.Windows.Forms.Button()
        Me.lbl_Cantidad = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.gb_totales = New System.Windows.Forms.GroupBox()
        Me.txt_total2 = New System.Windows.Forms.TextBox()
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtnombrelcliente = New System.Windows.Forms.TextBox()
        Me.mtxt_fecha = New System.Windows.Forms.TextBox()
        CType(Me.dgv_cotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_detalleEnvio.SuspendLayout()
        Me.gb_totales.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_noCotizacion
        '
        Me.lbl_noCotizacion.AutoSize = True
        Me.lbl_noCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_noCotizacion.Location = New System.Drawing.Point(13, 43)
        Me.lbl_noCotizacion.Name = "lbl_noCotizacion"
        Me.lbl_noCotizacion.Size = New System.Drawing.Size(97, 16)
        Me.lbl_noCotizacion.TabIndex = 0
        Me.lbl_noCotizacion.Text = "Cotizacion No.:"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_Cliente.Location = New System.Drawing.Point(15, 69)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(52, 16)
        Me.lbl_Cliente.TabIndex = 1
        Me.lbl_Cliente.Text = "Cliente:"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_direccion.Location = New System.Drawing.Point(15, 94)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(68, 16)
        Me.lbl_direccion.TabIndex = 2
        Me.lbl_direccion.Text = "Direccion:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_telefono.Location = New System.Drawing.Point(13, 116)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(72, 16)
        Me.lbl_telefono.TabIndex = 3
        Me.lbl_telefono.Text = "Telefonos:"
        '
        'lbl_Obser
        '
        Me.lbl_Obser.AutoSize = True
        Me.lbl_Obser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_Obser.Location = New System.Drawing.Point(13, 141)
        Me.lbl_Obser.Name = "lbl_Obser"
        Me.lbl_Obser.Size = New System.Drawing.Size(103, 16)
        Me.lbl_Obser.TabIndex = 4
        Me.lbl_Obser.Text = "Observaciones:"
        '
        'txt_cliente
        '
        Me.txt_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_cliente.Location = New System.Drawing.Point(116, 66)
        Me.txt_cliente.MaxLength = 3
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(69, 22)
        Me.txt_cliente.TabIndex = 5
        '
        'txt_telefono
        '
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_telefono.Location = New System.Drawing.Point(116, 114)
        Me.txt_telefono.MaxLength = 8
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(221, 22)
        Me.txt_telefono.TabIndex = 7
        '
        'txt_direccion
        '
        Me.txt_direccion.Enabled = False
        Me.txt_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_direccion.Location = New System.Drawing.Point(116, 91)
        Me.txt_direccion.MaxLength = 50
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(667, 22)
        Me.txt_direccion.TabIndex = 8
        '
        'txt_noCotizacion
        '
        Me.txt_noCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_noCotizacion.Location = New System.Drawing.Point(116, 40)
        Me.txt_noCotizacion.MaxLength = 3
        Me.txt_noCotizacion.Name = "txt_noCotizacion"
        Me.txt_noCotizacion.Size = New System.Drawing.Size(115, 22)
        Me.txt_noCotizacion.TabIndex = 9
        '
        'txt_obser
        '
        Me.txt_obser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_obser.Location = New System.Drawing.Point(116, 138)
        Me.txt_obser.MaxLength = 200
        Me.txt_obser.Multiline = True
        Me.txt_obser.Name = "txt_obser"
        Me.txt_obser.Size = New System.Drawing.Size(667, 46)
        Me.txt_obser.TabIndex = 10
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_fecha.Location = New System.Drawing.Point(613, 43)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(49, 16)
        Me.lbl_fecha.TabIndex = 67
        Me.lbl_fecha.Text = "Fecha:"
        '
        'lbl_Cotizaciones
        '
        Me.lbl_Cotizaciones.AutoSize = True
        Me.lbl_Cotizaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lbl_Cotizaciones.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_Cotizaciones.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Cotizaciones.Name = "lbl_Cotizaciones"
        Me.lbl_Cotizaciones.Size = New System.Drawing.Size(117, 24)
        Me.lbl_Cotizaciones.TabIndex = 69
        Me.lbl_Cotizaciones.Text = "Cotizaciones"
        '
        'txt_noNit
        '
        Me.txt_noNit.Enabled = False
        Me.txt_noNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_noNit.Location = New System.Drawing.Point(668, 66)
        Me.txt_noNit.MaxLength = 13
        Me.txt_noNit.Name = "txt_noNit"
        Me.txt_noNit.Size = New System.Drawing.Size(115, 22)
        Me.txt_noNit.TabIndex = 71
        '
        'lbl_noNit
        '
        Me.lbl_noNit.AutoSize = True
        Me.lbl_noNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_noNit.Location = New System.Drawing.Point(592, 69)
        Me.lbl_noNit.Name = "lbl_noNit"
        Me.lbl_noNit.Size = New System.Drawing.Size(70, 16)
        Me.lbl_noNit.TabIndex = 70
        Me.lbl_noNit.Text = "No. de Nit:"
        '
        'txt_vendedor1
        '
        Me.txt_vendedor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_vendedor1.Location = New System.Drawing.Point(496, 115)
        Me.txt_vendedor1.MaxLength = 3
        Me.txt_vendedor1.Name = "txt_vendedor1"
        Me.txt_vendedor1.Size = New System.Drawing.Size(44, 22)
        Me.txt_vendedor1.TabIndex = 73
        '
        'lbl_vendedor
        '
        Me.lbl_vendedor.AutoSize = True
        Me.lbl_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_vendedor.Location = New System.Drawing.Point(418, 117)
        Me.lbl_vendedor.Name = "lbl_vendedor"
        Me.lbl_vendedor.Size = New System.Drawing.Size(71, 16)
        Me.lbl_vendedor.TabIndex = 72
        Me.lbl_vendedor.Text = "Vendedor:"
        '
        'txt_vendedor2
        '
        Me.txt_vendedor2.Enabled = False
        Me.txt_vendedor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_vendedor2.Location = New System.Drawing.Point(541, 115)
        Me.txt_vendedor2.Name = "txt_vendedor2"
        Me.txt_vendedor2.Size = New System.Drawing.Size(242, 22)
        Me.txt_vendedor2.TabIndex = 74
        '
        'dgv_cotizacion
        '
        Me.dgv_cotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cotizacion.Enabled = False
        Me.dgv_cotizacion.Location = New System.Drawing.Point(4, 190)
        Me.dgv_cotizacion.Name = "dgv_cotizacion"
        Me.dgv_cotizacion.Size = New System.Drawing.Size(775, 194)
        Me.dgv_cotizacion.TabIndex = 78
        '
        'gb_detalleEnvio
        '
        Me.gb_detalleEnvio.Controls.Add(Me.txtproducto)
        Me.gb_detalleEnvio.Controls.Add(Me.btn_EliminFila)
        Me.gb_detalleEnvio.Controls.Add(Me.txt_total)
        Me.gb_detalleEnvio.Controls.Add(Me.lbl_total)
        Me.gb_detalleEnvio.Controls.Add(Me.txt_precio)
        Me.gb_detalleEnvio.Controls.Add(Me.lbl_Precio)
        Me.gb_detalleEnvio.Controls.Add(Me.btn_ModifFila)
        Me.gb_detalleEnvio.Controls.Add(Me.txt_existen)
        Me.gb_detalleEnvio.Controls.Add(Me.lbl_Existencia)
        Me.gb_detalleEnvio.Controls.Add(Me.txt_cantidad)
        Me.gb_detalleEnvio.Controls.Add(Me.btn_InsertFila)
        Me.gb_detalleEnvio.Controls.Add(Me.lbl_Cantidad)
        Me.gb_detalleEnvio.Controls.Add(Me.txt_producto)
        Me.gb_detalleEnvio.Controls.Add(Me.lbl_Producto)
        Me.gb_detalleEnvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.gb_detalleEnvio.Location = New System.Drawing.Point(12, 401)
        Me.gb_detalleEnvio.Name = "gb_detalleEnvio"
        Me.gb_detalleEnvio.Size = New System.Drawing.Size(767, 128)
        Me.gb_detalleEnvio.TabIndex = 114
        Me.gb_detalleEnvio.TabStop = False
        Me.gb_detalleEnvio.Text = "Detalle del Envío.  En el Cuadro Producto Presione [ESC] para Salir o [ENTER] par" &
    "a rellenar campos."
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproducto.Location = New System.Drawing.Point(207, 30)
        Me.txtproducto.MaxLength = 50
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(531, 22)
        Me.txtproducto.TabIndex = 14
        '
        'btn_EliminFila
        '
        Me.btn_EliminFila.Location = New System.Drawing.Point(599, 99)
        Me.btn_EliminFila.Name = "btn_EliminFila"
        Me.btn_EliminFila.Size = New System.Drawing.Size(139, 23)
        Me.btn_EliminFila.TabIndex = 13
        Me.btn_EliminFila.Text = "Eliminar Fila"
        Me.btn_EliminFila.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(650, 59)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(79, 22)
        Me.txt_total.TabIndex = 12
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_total.Location = New System.Drawing.Point(592, 63)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(60, 16)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "Subtotal:"
        '
        'txt_precio
        '
        Me.txt_precio.Enabled = False
        Me.txt_precio.Location = New System.Drawing.Point(409, 59)
        Me.txt_precio.MaxLength = 1000
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(79, 22)
        Me.txt_precio.TabIndex = 10
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.Location = New System.Drawing.Point(344, 65)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Precio.TabIndex = 9
        Me.lbl_Precio.Text = "Precio:"
        '
        'btn_ModifFila
        '
        Me.btn_ModifFila.Location = New System.Drawing.Point(317, 99)
        Me.btn_ModifFila.Name = "btn_ModifFila"
        Me.btn_ModifFila.Size = New System.Drawing.Size(139, 23)
        Me.btn_ModifFila.TabIndex = 7
        Me.btn_ModifFila.Text = "Modificar Fila"
        Me.btn_ModifFila.UseVisualStyleBackColor = True
        '
        'txt_existen
        '
        Me.txt_existen.Enabled = False
        Me.txt_existen.Location = New System.Drawing.Point(224, 60)
        Me.txt_existen.MaxLength = 1000
        Me.txt_existen.Name = "txt_existen"
        Me.txt_existen.Size = New System.Drawing.Size(79, 22)
        Me.txt_existen.TabIndex = 6
        '
        'lbl_Existencia
        '
        Me.lbl_Existencia.AutoSize = True
        Me.lbl_Existencia.Location = New System.Drawing.Point(147, 62)
        Me.lbl_Existencia.Name = "lbl_Existencia"
        Me.lbl_Existencia.Size = New System.Drawing.Size(72, 16)
        Me.lbl_Existencia.TabIndex = 5
        Me.lbl_Existencia.Text = "Existencia:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(72, 59)
        Me.txt_cantidad.MaxLength = 4
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(56, 22)
        Me.txt_cantidad.TabIndex = 4
        '
        'btn_InsertFila
        '
        Me.btn_InsertFila.Enabled = False
        Me.btn_InsertFila.Location = New System.Drawing.Point(6, 99)
        Me.btn_InsertFila.Name = "btn_InsertFila"
        Me.btn_InsertFila.Size = New System.Drawing.Size(139, 23)
        Me.btn_InsertFila.TabIndex = 3
        Me.btn_InsertFila.Text = "Insertar Fila"
        Me.btn_InsertFila.UseVisualStyleBackColor = True
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(6, 62)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(65, 16)
        Me.lbl_Cantidad.TabIndex = 2
        Me.lbl_Cantidad.Text = "Cantidad:"
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(72, 30)
        Me.txt_producto.MaxLength = 3
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(129, 22)
        Me.txt_producto.TabIndex = 1
        '
        'lbl_Producto
        '
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(8, 33)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(65, 16)
        Me.lbl_Producto.TabIndex = 0
        Me.lbl_Producto.Text = "Producto:"
        '
        'gb_totales
        '
        Me.gb_totales.Controls.Add(Me.txt_total2)
        Me.gb_totales.Controls.Add(Me.lbl_total2)
        Me.gb_totales.Enabled = False
        Me.gb_totales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.gb_totales.Location = New System.Drawing.Point(31, 557)
        Me.gb_totales.Name = "gb_totales"
        Me.gb_totales.Size = New System.Drawing.Size(231, 74)
        Me.gb_totales.TabIndex = 119
        Me.gb_totales.TabStop = False
        Me.gb_totales.Text = "Totales"
        '
        'txt_total2
        '
        Me.txt_total2.Enabled = False
        Me.txt_total2.Location = New System.Drawing.Point(90, 27)
        Me.txt_total2.Multiline = True
        Me.txt_total2.Name = "txt_total2"
        Me.txt_total2.Size = New System.Drawing.Size(123, 31)
        Me.txt_total2.TabIndex = 1
        '
        'lbl_total2
        '
        Me.lbl_total2.AutoSize = True
        Me.lbl_total2.Location = New System.Drawing.Point(50, 30)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(42, 16)
        Me.lbl_total2.TabIndex = 0
        Me.lbl_total2.Text = "Total:"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(518, 596)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Padding = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Size = New System.Drawing.Size(100, 35)
        Me.btnImprimir.TabIndex = 409
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Image = Global.Disermo_Project.My.Resources.Resources.btnCancel
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(406, 596)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Size = New System.Drawing.Size(100, 35)
        Me.btncancelar.TabIndex = 408
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
        Me.btneliminar.Location = New System.Drawing.Point(518, 557)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Padding = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Size = New System.Drawing.Size(100, 35)
        Me.btneliminar.TabIndex = 407
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
        Me.btnbuscar.Location = New System.Drawing.Point(406, 557)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Size = New System.Drawing.Size(100, 35)
        Me.btnbuscar.TabIndex = 406
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
        Me.btnagregar.Location = New System.Drawing.Point(294, 557)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 404
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(622, 557)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Size = New System.Drawing.Size(100, 35)
        Me.btnModificar.TabIndex = 411
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtnombrelcliente
        '
        Me.txtnombrelcliente.Enabled = False
        Me.txtnombrelcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombrelcliente.Location = New System.Drawing.Point(191, 66)
        Me.txtnombrelcliente.MaxLength = 50
        Me.txtnombrelcliente.Name = "txtnombrelcliente"
        Me.txtnombrelcliente.Size = New System.Drawing.Size(395, 22)
        Me.txtnombrelcliente.TabIndex = 412
        '
        'mtxt_fecha
        '
        Me.mtxt_fecha.Enabled = False
        Me.mtxt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.mtxt_fecha.Location = New System.Drawing.Point(668, 37)
        Me.mtxt_fecha.MaxLength = 13
        Me.mtxt_fecha.Name = "mtxt_fecha"
        Me.mtxt_fecha.Size = New System.Drawing.Size(115, 22)
        Me.mtxt_fecha.TabIndex = 413
        '
        'Cotizaciones
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(801, 649)
        Me.Controls.Add(Me.mtxt_fecha)
        Me.Controls.Add(Me.txtnombrelcliente)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.gb_totales)
        Me.Controls.Add(Me.gb_detalleEnvio)
        Me.Controls.Add(Me.dgv_cotizacion)
        Me.Controls.Add(Me.txt_vendedor2)
        Me.Controls.Add(Me.txt_vendedor1)
        Me.Controls.Add(Me.lbl_vendedor)
        Me.Controls.Add(Me.txt_noNit)
        Me.Controls.Add(Me.lbl_noNit)
        Me.Controls.Add(Me.lbl_Cotizaciones)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.txt_obser)
        Me.Controls.Add(Me.txt_noCotizacion)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.lbl_Obser)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.lbl_Cliente)
        Me.Controls.Add(Me.lbl_noCotizacion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.MaximizeBox = False
        Me.Name = "Cotizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizaciones  (Disermo, S.A. DM DM DM )            USUARIOS:"
        CType(Me.dgv_cotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_detalleEnvio.ResumeLayout(False)
        Me.gb_detalleEnvio.PerformLayout()
        Me.gb_totales.ResumeLayout(False)
        Me.gb_totales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_noCotizacion As Label
    Friend WithEvents lbl_Cliente As Label
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_Obser As Label
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_noCotizacion As TextBox
    Friend WithEvents txt_obser As TextBox
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_Cotizaciones As Label
    Friend WithEvents txt_noNit As TextBox
    Friend WithEvents lbl_noNit As Label
    Friend WithEvents txt_vendedor1 As TextBox
    Friend WithEvents lbl_vendedor As Label
    Friend WithEvents txt_vendedor2 As TextBox
    Friend WithEvents dgv_cotizacion As DataGridView
    Friend WithEvents gb_detalleEnvio As GroupBox
    Friend WithEvents gb_totales As GroupBox
    Friend WithEvents txt_total2 As TextBox
    Friend WithEvents lbl_total2 As Label
    Friend WithEvents btn_EliminFila As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents lbl_Precio As Label
    Friend WithEvents btn_ModifFila As Button
    Friend WithEvents txt_existen As TextBox
    Friend WithEvents lbl_Existencia As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents btn_InsertFila As Button
    Friend WithEvents lbl_Cantidad As Label
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents lbl_Producto As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtnombrelcliente As TextBox
    Friend WithEvents mtxt_fecha As TextBox
End Class
