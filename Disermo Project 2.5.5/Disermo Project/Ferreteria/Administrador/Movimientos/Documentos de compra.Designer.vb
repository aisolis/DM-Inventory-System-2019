<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Documentos_de_compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Documentos_de_compra))
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcompra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtseriecompra = New System.Windows.Forms.TextBox()
        Me.chkbcredito = New System.Windows.Forms.CheckBox()
        Me.griddocumentoscompra = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.btnactualizarfila = New System.Windows.Forms.Button()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txtnombreprov = New System.Windows.Forms.TextBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.griddocumentoscompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtproveedor
        '
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproveedor.Location = New System.Drawing.Point(95, 64)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(69, 22)
        Me.txtproveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(14, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Proveedor:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(218, 24)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Documentos De Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(14, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Dirección:"
        '
        'txtcompra
        '
        Me.txtcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcompra.Location = New System.Drawing.Point(95, 121)
        Me.txtcompra.Name = "txtcompra"
        Me.txtcompra.Size = New System.Drawing.Size(69, 22)
        Me.txtcompra.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(14, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Compra No.:"
        '
        'txtnit
        '
        Me.txtnit.Enabled = False
        Me.txtnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnit.Location = New System.Drawing.Point(776, 90)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(99, 22)
        Me.txtnit.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(706, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "No. De Nit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(730, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Fecha:"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfecha.Location = New System.Drawing.Point(776, 117)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(99, 22)
        Me.txtfecha.TabIndex = 8
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdireccion.Location = New System.Drawing.Point(95, 91)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(605, 22)
        Me.txtdireccion.TabIndex = 6
        '
        'txtseriecompra
        '
        Me.txtseriecompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtseriecompra.Location = New System.Drawing.Point(169, 121)
        Me.txtseriecompra.Name = "txtseriecompra"
        Me.txtseriecompra.Size = New System.Drawing.Size(124, 22)
        Me.txtseriecompra.TabIndex = 10
        '
        'chkbcredito
        '
        Me.chkbcredito.AutoSize = True
        Me.chkbcredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkbcredito.Location = New System.Drawing.Point(299, 123)
        Me.chkbcredito.Name = "chkbcredito"
        Me.chkbcredito.Size = New System.Drawing.Size(70, 20)
        Me.chkbcredito.TabIndex = 11
        Me.chkbcredito.Text = "Credito"
        Me.chkbcredito.UseVisualStyleBackColor = True
        '
        'griddocumentoscompra
        '
        Me.griddocumentoscompra.AllowUserToAddRows = False
        Me.griddocumentoscompra.AllowUserToDeleteRows = False
        Me.griddocumentoscompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griddocumentoscompra.Location = New System.Drawing.Point(16, 172)
        Me.griddocumentoscompra.Margin = New System.Windows.Forms.Padding(2)
        Me.griddocumentoscompra.Name = "griddocumentoscompra"
        Me.griddocumentoscompra.ReadOnly = True
        Me.griddocumentoscompra.RowTemplate.Height = 24
        Me.griddocumentoscompra.Size = New System.Drawing.Size(859, 227)
        Me.griddocumentoscompra.TabIndex = 194
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(14, 401)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(496, 16)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Haga doble click en la fila que desea modificar o eliminar en el detalle de compr" &
    "a."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(14, 433)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(591, 16)
        Me.Label17.TabIndex = 196
        Me.Label17.Text = "Detalle de Compra. En El cuadro precione [ESC] para salir o [ENTER] para consulta" &
    " de productos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(14, 477)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 198
        Me.Label12.Text = "Producto:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(14, 506)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 16)
        Me.Label13.TabIndex = 205
        Me.Label13.Text = "Cantidad:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcantidad.Location = New System.Drawing.Point(77, 503)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(60, 22)
        Me.txtcantidad.TabIndex = 24
        '
        'txtexistencia
        '
        Me.txtexistencia.Enabled = False
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtexistencia.Location = New System.Drawing.Point(333, 503)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(79, 22)
        Me.txtexistencia.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(262, 506)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "Existencia:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprecio.Location = New System.Drawing.Point(600, 503)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(60, 22)
        Me.txtprecio.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(548, 506)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 16)
        Me.Label16.TabIndex = 209
        Me.Label16.Text = "Precio:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubtotal.Location = New System.Drawing.Point(815, 503)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(60, 22)
        Me.txtsubtotal.TabIndex = 214
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(772, 506)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 16)
        Me.Label19.TabIndex = 213
        Me.Label19.Text = "Total:"
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btninsertarfila.Location = New System.Drawing.Point(14, 543)
        Me.btninsertarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(118, 28)
        Me.btninsertarfila.TabIndex = 28
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'btnactualizarfila
        '
        Me.btnactualizarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnactualizarfila.Location = New System.Drawing.Point(392, 543)
        Me.btnactualizarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btnactualizarfila.Name = "btnactualizarfila"
        Me.btnactualizarfila.Size = New System.Drawing.Size(118, 28)
        Me.btnactualizarfila.TabIndex = 29
        Me.btnactualizarfila.Text = "Modificar Fila"
        Me.btnactualizarfila.UseVisualStyleBackColor = True
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btneliminarfila.Location = New System.Drawing.Point(760, 543)
        Me.btneliminarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(118, 28)
        Me.btneliminarfila.TabIndex = 30
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(116, 634)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 16)
        Me.Label25.TabIndex = 224
        Me.Label25.Text = "Total:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label22.Location = New System.Drawing.Point(14, 601)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 16)
        Me.Label22.TabIndex = 218
        Me.Label22.Text = "Totales"
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(619, 635)
        Me.btnreporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Padding = New System.Windows.Forms.Padding(4)
        Me.btnreporte.Size = New System.Drawing.Size(100, 35)
        Me.btnreporte.TabIndex = 419
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
        Me.btncancelar.Location = New System.Drawing.Point(505, 635)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Size = New System.Drawing.Size(100, 35)
        Me.btncancelar.TabIndex = 418
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
        Me.btneliminar.Location = New System.Drawing.Point(750, 588)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Padding = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Size = New System.Drawing.Size(100, 35)
        Me.btneliminar.TabIndex = 417
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
        Me.btnbuscar.Location = New System.Drawing.Point(627, 588)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Size = New System.Drawing.Size(100, 35)
        Me.btnbuscar.TabIndex = 416
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
        Me.btnagregar.Location = New System.Drawing.Point(383, 588)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 414
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'txt_producto
        '
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_producto.Location = New System.Drawing.Point(77, 476)
        Me.txt_producto.MaxLength = 3
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(112, 22)
        Me.txt_producto.TabIndex = 420
        '
        'txtnombreprov
        '
        Me.txtnombreprov.Enabled = False
        Me.txtnombreprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombreprov.Location = New System.Drawing.Point(170, 63)
        Me.txtnombreprov.Name = "txtnombreprov"
        Me.txtnombreprov.Size = New System.Drawing.Size(705, 22)
        Me.txtnombreprov.TabIndex = 421
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproducto.Location = New System.Drawing.Point(195, 474)
        Me.txtproducto.MaxLength = 50
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(679, 22)
        Me.txtproducto.TabIndex = 422
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(157, 626)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(123, 31)
        Me.txttotal.TabIndex = 423
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(505, 588)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Size = New System.Drawing.Size(100, 35)
        Me.btnModificar.TabIndex = 424
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Documentos_de_compra
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 681)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.txtnombreprov)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btneliminarfila)
        Me.Controls.Add(Me.btnactualizarfila)
        Me.Controls.Add(Me.btninsertarfila)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.griddocumentoscompra)
        Me.Controls.Add(Me.chkbcredito)
        Me.Controls.Add(Me.txtseriecompra)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcompra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Documentos_de_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos_de_compra"
        CType(Me.griddocumentoscompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcompra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtseriecompra As TextBox
    Friend WithEvents chkbcredito As CheckBox
    Friend WithEvents griddocumentoscompra As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents btnactualizarfila As Button
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents txtnombreprov As TextBox
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnModificar As Button
End Class
