<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturascompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturascompra))
        Me.txtfacturano = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkbanulada = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkncredito = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefonos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnonit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdiascredito = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtlimitecredito = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfechavencimiento = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcobroporenvio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtidvendedor = New System.Windows.Forms.TextBox()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtidmunicipio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtidepartamento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtnopedido = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtrutacliente = New System.Windows.Forms.TextBox()
        Me.txtrutacliente2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtsubrutacliente = New System.Windows.Forms.TextBox()
        Me.txtsubrutacliente2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.btnmodificarfila = New System.Windows.Forms.Button()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.txtproducto = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtnmuni = New System.Windows.Forms.TextBox()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.txtndepto = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtfacturano
        '
        Me.txtfacturano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfacturano.Location = New System.Drawing.Point(116, 50)
        Me.txtfacturano.MaxLength = 5
        Me.txtfacturano.Name = "txtfacturano"
        Me.txtfacturano.Size = New System.Drawing.Size(51, 22)
        Me.txtfacturano.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(16, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Factura No.:"
        '
        'chkbanulada
        '
        Me.chkbanulada.AutoSize = True
        Me.chkbanulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkbanulada.Location = New System.Drawing.Point(800, 27)
        Me.chkbanulada.Name = "chkbanulada"
        Me.chkbanulada.Size = New System.Drawing.Size(77, 20)
        Me.chkbanulada.TabIndex = 4
        Me.chkbanulada.Text = "Anulada"
        Me.chkbanulada.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 24)
        Me.Label15.TabIndex = 188
        Me.Label15.Text = "Facturas venta"
        '
        'txtserie
        '
        Me.txtserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtserie.Location = New System.Drawing.Point(173, 49)
        Me.txtserie.MaxLength = 5
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(165, 22)
        Me.txtserie.TabIndex = 2
        '
        'txtidcliente
        '
        Me.txtidcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidcliente.Location = New System.Drawing.Point(116, 78)
        Me.txtidcliente.MaxLength = 5
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(51, 22)
        Me.txtidcliente.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(16, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 192
        Me.Label2.Text = "Cliente:"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfecha.Location = New System.Drawing.Point(390, 50)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(92, 22)
        Me.txtfecha.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(344, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Fecha:"
        '
        'chkncredito
        '
        Me.chkncredito.AutoSize = True
        Me.chkncredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkncredito.Location = New System.Drawing.Point(800, 53)
        Me.chkncredito.Name = "chkncredito"
        Me.chkncredito.Size = New System.Drawing.Size(70, 20)
        Me.chkncredito.TabIndex = 5
        Me.chkncredito.Text = "Credito"
        Me.chkncredito.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(657, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Teléfonos:"
        '
        'txttelefonos
        '
        Me.txttelefonos.Enabled = False
        Me.txttelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txttelefonos.Location = New System.Drawing.Point(734, 76)
        Me.txttelefonos.Name = "txttelefonos"
        Me.txttelefonos.Size = New System.Drawing.Size(143, 22)
        Me.txttelefonos.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(16, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "Dirección:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdireccion.Location = New System.Drawing.Point(117, 105)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(759, 22)
        Me.txtdireccion.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(16, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 242
        Me.Label5.Text = "No. de Nit:"
        '
        'txtnonit
        '
        Me.txtnonit.Enabled = False
        Me.txtnonit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnonit.Location = New System.Drawing.Point(116, 133)
        Me.txtnonit.Name = "txtnonit"
        Me.txtnonit.Size = New System.Drawing.Size(51, 22)
        Me.txtnonit.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(204, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 244
        Me.Label6.Text = "Días de crédito:"
        '
        'txtdiascredito
        '
        Me.txtdiascredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdiascredito.Location = New System.Drawing.Point(312, 132)
        Me.txtdiascredito.MaxLength = 3
        Me.txtdiascredito.Name = "txtdiascredito"
        Me.txtdiascredito.Size = New System.Drawing.Size(69, 22)
        Me.txtdiascredito.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(398, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 246
        Me.Label8.Text = "Limite de crédito:"
        '
        'txtlimitecredito
        '
        Me.txtlimitecredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtlimitecredito.Location = New System.Drawing.Point(515, 133)
        Me.txtlimitecredito.MaxLength = 3
        Me.txtlimitecredito.Name = "txtlimitecredito"
        Me.txtlimitecredito.Size = New System.Drawing.Size(69, 22)
        Me.txtlimitecredito.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(472, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 16)
        Me.Label10.TabIndex = 247
        Me.Label10.Text = "Fecha vencimiento:"
        '
        'txtfechavencimiento
        '
        Me.txtfechavencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfechavencimiento.Location = New System.Drawing.Point(599, 161)
        Me.txtfechavencimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfechavencimiento.Mask = "00/00/0000"
        Me.txtfechavencimiento.Name = "txtfechavencimiento"
        Me.txtfechavencimiento.Size = New System.Drawing.Size(71, 22)
        Me.txtfechavencimiento.TabIndex = 16
        Me.txtfechavencimiento.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(680, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 16)
        Me.Label11.TabIndex = 250
        Me.Label11.Text = "% de cobro x envio:"
        '
        'txtcobroporenvio
        '
        Me.txtcobroporenvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcobroporenvio.Location = New System.Drawing.Point(811, 159)
        Me.txtcobroporenvio.MaxLength = 6
        Me.txtcobroporenvio.Name = "txtcobroporenvio"
        Me.txtcobroporenvio.Size = New System.Drawing.Size(65, 22)
        Me.txtcobroporenvio.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(16, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 16)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Vendedor:"
        '
        'txtidvendedor
        '
        Me.txtidvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidvendedor.Location = New System.Drawing.Point(116, 162)
        Me.txtidvendedor.MaxLength = 5
        Me.txtidvendedor.Name = "txtidvendedor"
        Me.txtidvendedor.Size = New System.Drawing.Size(51, 22)
        Me.txtidvendedor.TabIndex = 18
        '
        'txtvendedor
        '
        Me.txtvendedor.Enabled = False
        Me.txtvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtvendedor.Location = New System.Drawing.Point(173, 161)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(293, 22)
        Me.txtvendedor.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(16, 193)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 16)
        Me.Label14.TabIndex = 258
        Me.Label14.Text = "IdMunicipio:"
        '
        'txtidmunicipio
        '
        Me.txtidmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidmunicipio.Location = New System.Drawing.Point(116, 191)
        Me.txtidmunicipio.MaxLength = 5
        Me.txtidmunicipio.Name = "txtidmunicipio"
        Me.txtidmunicipio.Size = New System.Drawing.Size(51, 22)
        Me.txtidmunicipio.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label16.Location = New System.Drawing.Point(177, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 260
        Me.Label16.Text = "Municipio:"
        '
        'txtidepartamento
        '
        Me.txtidepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidepartamento.Location = New System.Drawing.Point(631, 192)
        Me.txtidepartamento.MaxLength = 5
        Me.txtidepartamento.Name = "txtidepartamento"
        Me.txtidepartamento.Size = New System.Drawing.Size(60, 22)
        Me.txtidepartamento.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(522, 195)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 16)
        Me.Label17.TabIndex = 264
        Me.Label17.Text = "IdDepartamento:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(16, 220)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 16)
        Me.Label18.TabIndex = 266
        Me.Label18.Text = "No. Pedido:"
        '
        'txtnopedido
        '
        Me.txtnopedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnopedido.Location = New System.Drawing.Point(116, 220)
        Me.txtnopedido.MaxLength = 5
        Me.txtnopedido.Name = "txtnopedido"
        Me.txtnopedido.Size = New System.Drawing.Size(51, 22)
        Me.txtnopedido.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(172, 223)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 268
        Me.Label19.Text = "Ruta Cliente:"
        '
        'txtrutacliente
        '
        Me.txtrutacliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtrutacliente.Location = New System.Drawing.Point(259, 221)
        Me.txtrutacliente.MaxLength = 5
        Me.txtrutacliente.Name = "txtrutacliente"
        Me.txtrutacliente.Size = New System.Drawing.Size(50, 22)
        Me.txtrutacliente.TabIndex = 27
        '
        'txtrutacliente2
        '
        Me.txtrutacliente2.Enabled = False
        Me.txtrutacliente2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtrutacliente2.Location = New System.Drawing.Point(314, 221)
        Me.txtrutacliente2.Name = "txtrutacliente2"
        Me.txtrutacliente2.Size = New System.Drawing.Size(202, 22)
        Me.txtrutacliente2.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(521, 223)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 16)
        Me.Label20.TabIndex = 271
        Me.Label20.Text = "SubRuta Cliente:"
        '
        'txtsubrutacliente
        '
        Me.txtsubrutacliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubrutacliente.Location = New System.Drawing.Point(631, 221)
        Me.txtsubrutacliente.MaxLength = 5
        Me.txtsubrutacliente.Name = "txtsubrutacliente"
        Me.txtsubrutacliente.Size = New System.Drawing.Size(60, 22)
        Me.txtsubrutacliente.TabIndex = 29
        '
        'txtsubrutacliente2
        '
        Me.txtsubrutacliente2.Enabled = False
        Me.txtsubrutacliente2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubrutacliente2.Location = New System.Drawing.Point(699, 221)
        Me.txtsubrutacliente2.Name = "txtsubrutacliente2"
        Me.txtsubrutacliente2.Size = New System.Drawing.Size(178, 22)
        Me.txtsubrutacliente2.TabIndex = 30
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(8, 264)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 16)
        Me.Label22.TabIndex = 276
        Me.Label22.Text = "Observaciones:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtobservaciones.Location = New System.Drawing.Point(116, 249)
        Me.txtobservaciones.MaxLength = 200
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(761, 57)
        Me.txtobservaciones.TabIndex = 32
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btneliminarfila.Location = New System.Drawing.Point(752, 657)
        Me.btneliminarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(118, 28)
        Me.btneliminarfila.TabIndex = 41
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'btnmodificarfila
        '
        Me.btnmodificarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnmodificarfila.Location = New System.Drawing.Point(389, 657)
        Me.btnmodificarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificarfila.Name = "btnmodificarfila"
        Me.btnmodificarfila.Size = New System.Drawing.Size(118, 28)
        Me.btnmodificarfila.TabIndex = 40
        Me.btnmodificarfila.Text = "Modificar Fila"
        Me.btnmodificarfila.UseVisualStyleBackColor = True
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btninsertarfila.Location = New System.Drawing.Point(17, 657)
        Me.btninsertarfila.Margin = New System.Windows.Forms.Padding(2)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(118, 28)
        Me.btninsertarfila.TabIndex = 39
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproducto.FormattingEnabled = True
        Me.txtproducto.Location = New System.Drawing.Point(197, 594)
        Me.txtproducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(682, 24)
        Me.txtproducto.TabIndex = 34
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label32.Location = New System.Drawing.Point(17, 597)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(65, 16)
        Me.Label32.TabIndex = 279
        Me.Label32.Text = "Producto:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label33.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label33.Location = New System.Drawing.Point(17, 577)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(591, 16)
        Me.Label33.TabIndex = 278
        Me.Label33.Text = "Detalle de Compra. En El cuadro precione [ESC] para salir o [ENTER] para consulta" &
    " de productos"
        '
        'txtnmuni
        '
        Me.txtnmuni.Enabled = False
        Me.txtnmuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnmuni.Location = New System.Drawing.Point(255, 190)
        Me.txtnmuni.Name = "txtnmuni"
        Me.txtnmuni.Size = New System.Drawing.Size(257, 22)
        Me.txtnmuni.TabIndex = 306
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Enabled = False
        Me.txtnombrecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombrecliente.Location = New System.Drawing.Point(173, 78)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(478, 22)
        Me.txtnombrecliente.TabIndex = 420
        '
        'txtndepto
        '
        Me.txtndepto.Enabled = False
        Me.txtndepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtndepto.Location = New System.Drawing.Point(697, 192)
        Me.txtndepto.Name = "txtndepto"
        Me.txtndepto.Size = New System.Drawing.Size(178, 22)
        Me.txtndepto.TabIndex = 421
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(164, 737)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(123, 31)
        Me.txttotal.TabIndex = 432
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(123, 745)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 16)
        Me.Label25.TabIndex = 426
        Me.Label25.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Location = New System.Drawing.Point(21, 712)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 425
        Me.Label9.Text = "Totales"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubtotal.Location = New System.Drawing.Point(819, 623)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(60, 22)
        Me.txtsubtotal.TabIndex = 441
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(776, 626)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 440
        Me.Label13.Text = "Total:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprecio.Location = New System.Drawing.Point(604, 623)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(60, 22)
        Me.txtprecio.TabIndex = 436
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(552, 626)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 16)
        Me.Label23.TabIndex = 439
        Me.Label23.Text = "Precio:"
        '
        'txtexistencia
        '
        Me.txtexistencia.Enabled = False
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtexistencia.Location = New System.Drawing.Point(337, 623)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(79, 22)
        Me.txtexistencia.TabIndex = 435
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(266, 626)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 438
        Me.Label24.Text = "Existencia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcantidad.Location = New System.Drawing.Point(81, 623)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(60, 22)
        Me.txtcantidad.TabIndex = 434
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(18, 626)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 437
        Me.Label26.Text = "Cantidad:"
        '
        'txt_producto
        '
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_producto.Location = New System.Drawing.Point(81, 594)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(111, 22)
        Me.txt_producto.TabIndex = 442
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 312)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(859, 276)
        Me.DataGridView1.TabIndex = 443
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(512, 699)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Size = New System.Drawing.Size(100, 35)
        Me.btnModificar.TabIndex = 433
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
        Me.btnreporte.Location = New System.Drawing.Point(626, 746)
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
        Me.btncancelar.Location = New System.Drawing.Point(512, 746)
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
        Me.btneliminar.Location = New System.Drawing.Point(757, 699)
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
        Me.btnbuscar.Location = New System.Drawing.Point(634, 699)
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
        Me.btnagregar.Location = New System.Drawing.Point(390, 699)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 427
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'Facturascompra
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 805)
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
        Me.Controls.Add(Me.txtndepto)
        Me.Controls.Add(Me.txtnombrecliente)
        Me.Controls.Add(Me.txtnmuni)
        Me.Controls.Add(Me.btneliminarfila)
        Me.Controls.Add(Me.btnmodificarfila)
        Me.Controls.Add(Me.btninsertarfila)
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.txtsubrutacliente2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtsubrutacliente)
        Me.Controls.Add(Me.txtrutacliente2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtrutacliente)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtnopedido)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtidepartamento)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtidmunicipio)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtidvendedor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcobroporenvio)
        Me.Controls.Add(Me.txtfechavencimiento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtlimitecredito)
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
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.chkbanulada)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtfacturano)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Facturascompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtfacturano As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkbanulada As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkncredito As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttelefonos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnonit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdiascredito As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtlimitecredito As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfechavencimiento As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcobroporenvio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtidvendedor As TextBox
    Friend WithEvents txtvendedor As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtidmunicipio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtidepartamento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtnopedido As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtrutacliente As TextBox
    Friend WithEvents txtrutacliente2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtsubrutacliente As TextBox
    Friend WithEvents txtsubrutacliente2 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents btnmodificarfila As Button
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents txtproducto As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtnmuni As TextBox
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents txtndepto As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
