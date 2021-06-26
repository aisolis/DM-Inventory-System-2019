<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Envios_de_entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Envios_de_entrada))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.envio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtobser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.docto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.btnmodificarfila = New System.Windows.Forms.Button()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtnombreprov = New System.Windows.Forms.TextBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(162, 24)
        Me.Label15.TabIndex = 136
        Me.Label15.Text = "Envios de entrada"
        '
        'txtproveedor
        '
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproveedor.Location = New System.Drawing.Point(113, 64)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(61, 22)
        Me.txtproveedor.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(13, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Proveedor:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdireccion.Location = New System.Drawing.Point(113, 90)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(515, 22)
        Me.txtdireccion.TabIndex = 140
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(13, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Dirección:"
        '
        'envio
        '
        Me.envio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.envio.Location = New System.Drawing.Point(113, 115)
        Me.envio.Name = "envio"
        Me.envio.Size = New System.Drawing.Size(131, 22)
        Me.envio.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Envio No.:"
        '
        'txtobser
        '
        Me.txtobser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtobser.Location = New System.Drawing.Point(113, 137)
        Me.txtobser.Name = "txtobser"
        Me.txtobser.Size = New System.Drawing.Size(750, 22)
        Me.txtobser.TabIndex = 144
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(13, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Observaciones:"
        '
        'txtnit
        '
        Me.txtnit.Enabled = False
        Me.txtnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnit.Location = New System.Drawing.Point(717, 90)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(146, 22)
        Me.txtnit.TabIndex = 238
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(648, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 239
        Me.Label5.Text = "No. De Nit:"
        '
        'docto
        '
        Me.docto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.docto.Location = New System.Drawing.Point(420, 115)
        Me.docto.Name = "docto"
        Me.docto.Size = New System.Drawing.Size(131, 22)
        Me.docto.TabIndex = 240
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(316, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Docto Reclamo:"
        '
        'txtvalor
        '
        Me.txtvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtvalor.Location = New System.Drawing.Point(729, 115)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(134, 22)
        Me.txtvalor.TabIndex = 242
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(686, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 243
        Me.Label7.Text = "Valor:"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfecha.Location = New System.Drawing.Point(787, 64)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(76, 22)
        Me.txtfecha.TabIndex = 244
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(741, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 245
        Me.Label8.Text = "Fecha:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 177)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(853, 247)
        Me.DataGridView1.TabIndex = 246
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(726, 506)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 293
        Me.Label21.Text = "Total:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprecio.Location = New System.Drawing.Point(563, 506)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(51, 22)
        Me.txtprecio.TabIndex = 292
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(511, 508)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 16)
        Me.Label20.TabIndex = 291
        Me.Label20.Text = "Precio:"
        '
        'txtexistencia
        '
        Me.txtexistencia.Enabled = False
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtexistencia.Location = New System.Drawing.Point(359, 506)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(51, 22)
        Me.txtexistencia.TabIndex = 290
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(288, 508)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 289
        Me.Label19.Text = "Existencia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcantidad.Location = New System.Drawing.Point(83, 504)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(71, 22)
        Me.txtcantidad.TabIndex = 288
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(13, 506)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 16)
        Me.Label18.TabIndex = 287
        Me.Label18.Text = "Cantidad:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(14, 462)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(576, 16)
        Me.Label17.TabIndex = 285
        Me.Label17.Text = "Detalle de envio. En El cuadro precione [ESC] para salir o [ENTER] para consulta " &
    "de productos"
        '
        'txt_producto
        '
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_producto.Location = New System.Drawing.Point(83, 479)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(95, 22)
        Me.txt_producto.TabIndex = 283
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(13, 481)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 16)
        Me.Label16.TabIndex = 284
        Me.Label16.Text = "Producto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(14, 434)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(537, 16)
        Me.Label14.TabIndex = 282
        Me.Label14.Text = "Haga Doble Click Sonbre La Fila Que Desea Modificar o Eliminar En El Detalle Del " &
    "Envio"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubtotal.Location = New System.Drawing.Point(768, 505)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(95, 22)
        Me.txtsubtotal.TabIndex = 302
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Enabled = False
        Me.btneliminarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btneliminarfila.Location = New System.Drawing.Point(745, 535)
        Me.btneliminarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(118, 28)
        Me.btneliminarfila.TabIndex = 305
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'btnmodificarfila
        '
        Me.btnmodificarfila.Enabled = False
        Me.btnmodificarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnmodificarfila.Location = New System.Drawing.Point(374, 535)
        Me.btnmodificarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificarfila.Name = "btnmodificarfila"
        Me.btnmodificarfila.Size = New System.Drawing.Size(118, 28)
        Me.btnmodificarfila.TabIndex = 304
        Me.btnmodificarfila.Text = "Modificar Fila"
        Me.btnmodificarfila.UseVisualStyleBackColor = True
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Enabled = False
        Me.btninsertarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btninsertarfila.Location = New System.Drawing.Point(16, 535)
        Me.btninsertarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(118, 28)
        Me.btninsertarfila.TabIndex = 303
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(501, 583)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Size = New System.Drawing.Size(100, 35)
        Me.btnModificar.TabIndex = 433
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(153, 621)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(123, 31)
        Me.txttotal.TabIndex = 432
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(615, 630)
        Me.btnreporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Padding = New System.Windows.Forms.Padding(4)
        Me.btnreporte.Size = New System.Drawing.Size(100, 35)
        Me.btnreporte.TabIndex = 431
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
        Me.btncancelar.Location = New System.Drawing.Point(501, 630)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Size = New System.Drawing.Size(100, 35)
        Me.btncancelar.TabIndex = 430
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
        Me.btneliminar.Location = New System.Drawing.Point(746, 583)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Padding = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Size = New System.Drawing.Size(100, 35)
        Me.btneliminar.TabIndex = 429
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
        Me.btnbuscar.Location = New System.Drawing.Point(623, 583)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Size = New System.Drawing.Size(100, 35)
        Me.btnbuscar.TabIndex = 428
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
        Me.btnagregar.Location = New System.Drawing.Point(379, 583)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 427
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(112, 629)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 16)
        Me.Label25.TabIndex = 426
        Me.Label25.Text = "Total:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label22.Location = New System.Drawing.Point(10, 596)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 16)
        Me.Label22.TabIndex = 425
        Me.Label22.Text = "Totales"
        '
        'txtnombreprov
        '
        Me.txtnombreprov.Enabled = False
        Me.txtnombreprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombreprov.Location = New System.Drawing.Point(182, 64)
        Me.txtnombreprov.Name = "txtnombreprov"
        Me.txtnombreprov.Size = New System.Drawing.Size(446, 22)
        Me.txtnombreprov.TabIndex = 434
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproducto.Location = New System.Drawing.Point(184, 478)
        Me.txtproducto.MaxLength = 50
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(679, 22)
        Me.txtproducto.TabIndex = 435
        '
        'Envios_de_entrada
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 681)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.txtnombreprov)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btneliminarfila)
        Me.Controls.Add(Me.btnmodificarfila)
        Me.Controls.Add(Me.btninsertarfila)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.docto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtobser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.envio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.Name = "Envios_de_entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents envio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtobser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents docto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents btnmodificarfila As Button
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtnombreprov As TextBox
    Friend WithEvents txtproducto As TextBox
End Class
