<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas_de_credito
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
        Me.txtnotaresponsable = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnotadecredito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdocumento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdocumento2 = New System.Windows.Forms.TextBox()
        Me.txttotales = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnonit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidvendedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmunicipio = New System.Windows.Forms.ComboBox()
        Me.txtdepto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbdepto = New System.Windows.Forms.ComboBox()
        Me.txtidruta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtidsubruta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtsubruta = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtidnota = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtnorecepcion = New System.Windows.Forms.TextBox()
        Me.gridfacturacion = New System.Windows.Forms.DataGridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.txtpredescuento = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtprod = New System.Windows.Forms.ComboBox()
        Me.cmbprod = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.btnactualizarfila = New System.Windows.Forms.Button()
        Me.chkbactualizarcosto = New System.Windows.Forms.CheckBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        CType(Me.gridfacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnotaresponsable
        '
        Me.txtnotaresponsable.Enabled = False
        Me.txtnotaresponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtnotaresponsable.FormattingEnabled = True
        Me.txtnotaresponsable.Location = New System.Drawing.Point(208, 300)
        Me.txtnotaresponsable.Name = "txtnotaresponsable"
        Me.txtnotaresponsable.Size = New System.Drawing.Size(429, 28)
        Me.txtnotaresponsable.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(320, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(400, 38)
        Me.Label15.TabIndex = 192
        Me.Label15.Text = "Notas de credito clientes"
        '
        'txtnotadecredito
        '
        Me.txtnotadecredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnotadecredito.Location = New System.Drawing.Point(153, 90)
        Me.txtnotadecredito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnotadecredito.Name = "txtnotadecredito"
        Me.txtnotadecredito.Size = New System.Drawing.Size(112, 27)
        Me.txtnotadecredito.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Notá de crédito:"
        '
        'txtdocumento
        '
        Me.txtdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocumento.Location = New System.Drawing.Point(382, 90)
        Me.txtdocumento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.Size = New System.Drawing.Size(57, 27)
        Me.txtdocumento.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(276, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "Documento:"
        '
        'txtdocumento2
        '
        Me.txtdocumento2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocumento2.Location = New System.Drawing.Point(447, 90)
        Me.txtdocumento2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdocumento2.Name = "txtdocumento2"
        Me.txtdocumento2.Size = New System.Drawing.Size(141, 27)
        Me.txtdocumento2.TabIndex = 3
        '
        'txttotales
        '
        Me.txttotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotales.Location = New System.Drawing.Point(650, 90)
        Me.txttotales.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotales.Name = "txttotales"
        Me.txttotales.Size = New System.Drawing.Size(108, 27)
        Me.txttotales.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(599, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "Total:"
        '
        'txtfecha
        '
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(825, 90)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(108, 27)
        Me.txtfecha.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(768, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Fecha:"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(971, 513)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 69)
        Me.btnreporte.TabIndex = 38
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(971, 638)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 69)
        Me.btncancelar.TabIndex = 39
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(971, 397)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(82, 69)
        Me.btneliminar.TabIndex = 37
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(971, 278)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(82, 69)
        Me.btnbuscar.TabIndex = 36
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(971, 166)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(82, 69)
        Me.btnGrabar.TabIndex = 35
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(971, 50)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(82, 69)
        Me.btnagregar.TabIndex = 34
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'txtidcliente
        '
        Me.txtidcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidcliente.Location = New System.Drawing.Point(153, 125)
        Me.txtidcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(47, 27)
        Me.txtidcliente.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Cliente:"
        '
        'txtcliente
        '
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(208, 125)
        Me.txtcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(725, 27)
        Me.txtcliente.TabIndex = 7
        '
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(153, 160)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(533, 27)
        Me.txtdireccion.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 163)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 210
        Me.Label6.Text = "Dirección:"
        '
        'txtnonit
        '
        Me.txtnonit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnonit.Location = New System.Drawing.Point(795, 160)
        Me.txtnonit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnonit.Name = "txtnonit"
        Me.txtnonit.Size = New System.Drawing.Size(138, 27)
        Me.txtnonit.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(696, 163)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 212
        Me.Label7.Text = "No. De Nit:"
        '
        'txtidvendedor
        '
        Me.txtidvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidvendedor.Location = New System.Drawing.Point(153, 195)
        Me.txtidvendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidvendedor.Name = "txtidvendedor"
        Me.txtidvendedor.Size = New System.Drawing.Size(47, 27)
        Me.txtidvendedor.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Vendedor:"
        '
        'txtvendedor
        '
        Me.txtvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendedor.Location = New System.Drawing.Point(208, 195)
        Me.txtvendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(725, 27)
        Me.txtvendedor.TabIndex = 11
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(153, 230)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(47, 27)
        Me.TextBox11.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 233)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 217
        Me.Label9.Text = "IdMunicipio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(204, 233)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 20)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "Municipio:"
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Enabled = False
        Me.txtmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtmunicipio.FormattingEnabled = True
        Me.txtmunicipio.Location = New System.Drawing.Point(293, 230)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(344, 28)
        Me.txtmunicipio.TabIndex = 13
        '
        'txtdepto
        '
        Me.txtdepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepto.Location = New System.Drawing.Point(705, 230)
        Me.txtdepto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.Size = New System.Drawing.Size(53, 27)
        Me.txtdepto.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(642, 233)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 221
        Me.Label11.Text = "Depto:"
        '
        'cmbdepto
        '
        Me.cmbdepto.Enabled = False
        Me.cmbdepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbdepto.FormattingEnabled = True
        Me.cmbdepto.Location = New System.Drawing.Point(765, 229)
        Me.cmbdepto.Name = "cmbdepto"
        Me.cmbdepto.Size = New System.Drawing.Size(168, 28)
        Me.cmbdepto.TabIndex = 15
        '
        'txtidruta
        '
        Me.txtidruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidruta.Location = New System.Drawing.Point(153, 265)
        Me.txtidruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidruta.Name = "txtidruta"
        Me.txtidruta.Size = New System.Drawing.Size(47, 27)
        Me.txtidruta.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 268)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 20)
        Me.Label12.TabIndex = 224
        Me.Label12.Text = "IdRuta:"
        '
        'txtruta
        '
        Me.txtruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruta.Location = New System.Drawing.Point(256, 265)
        Me.txtruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(224, 27)
        Me.txtruta.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(204, 268)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 20)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "Ruta:"
        '
        'txtidsubruta
        '
        Me.txtidsubruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidsubruta.Location = New System.Drawing.Point(578, 265)
        Me.txtidsubruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidsubruta.Name = "txtidsubruta"
        Me.txtidsubruta.Size = New System.Drawing.Size(59, 27)
        Me.txtidsubruta.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(488, 268)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 20)
        Me.Label14.TabIndex = 228
        Me.Label14.Text = "IdSubRuta:"
        '
        'txtsubruta
        '
        Me.txtsubruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubruta.Location = New System.Drawing.Point(722, 265)
        Me.txtsubruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubruta.Name = "txtsubruta"
        Me.txtsubruta.Size = New System.Drawing.Size(211, 27)
        Me.txtsubruta.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(642, 268)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 230
        Me.Label16.Text = "Subruta:"
        '
        'txtidnota
        '
        Me.txtidnota.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidnota.Location = New System.Drawing.Point(153, 300)
        Me.txtidnota.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidnota.Name = "txtidnota"
        Me.txtidnota.Size = New System.Drawing.Size(47, 27)
        Me.txtidnota.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 293)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 40)
        Me.Label17.TabIndex = 232
        Me.Label17.Text = "Responsable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "De la Nota:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(646, 303)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(123, 20)
        Me.Label18.TabIndex = 234
        Me.Label18.Text = "No. Recepción:"
        '
        'txtnorecepcion
        '
        Me.txtnorecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnorecepcion.Location = New System.Drawing.Point(771, 300)
        Me.txtnorecepcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnorecepcion.Name = "txtnorecepcion"
        Me.txtnorecepcion.Size = New System.Drawing.Size(162, 27)
        Me.txtnorecepcion.TabIndex = 23
        '
        'gridfacturacion
        '
        Me.gridfacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridfacturacion.Location = New System.Drawing.Point(24, 334)
        Me.gridfacturacion.Name = "gridfacturacion"
        Me.gridfacturacion.RowTemplate.Height = 24
        Me.gridfacturacion.Size = New System.Drawing.Size(909, 263)
        Me.gridfacturacion.TabIndex = 278
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label19.Location = New System.Drawing.Point(21, 639)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 17)
        Me.Label19.TabIndex = 280
        Me.Label19.Text = "Detalle de Factura"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 600)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(703, 20)
        Me.Label20.TabIndex = 279
        Me.Label20.Text = "Haga doble click en la fila que desea modificar o eliminar en el detalle de Factu" &
    "ra de compra."
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Location = New System.Drawing.Point(24, 733)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(158, 34)
        Me.btninsertarfila.TabIndex = 31
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'txtpredescuento
        '
        Me.txtpredescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpredescuento.Location = New System.Drawing.Point(854, 699)
        Me.txtpredescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpredescuento.Name = "txtpredescuento"
        Me.txtpredescuento.Size = New System.Drawing.Size(79, 27)
        Me.txtpredescuento.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(737, 702)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 20)
        Me.Label21.TabIndex = 290
        Me.Label21.Text = "Prec. Descto:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(490, 702)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 20)
        Me.Label22.TabIndex = 289
        Me.Label22.Text = "Precio:"
        '
        'txtexistencia
        '
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexistencia.Location = New System.Drawing.Point(327, 699)
        Me.txtexistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(104, 27)
        Me.txtexistencia.TabIndex = 28
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(233, 702)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 20)
        Me.Label23.TabIndex = 288
        Me.Label23.Text = "Existencia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(105, 699)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(79, 27)
        Me.txtcantidad.TabIndex = 27
        '
        'txtprod
        '
        Me.txtprod.Enabled = False
        Me.txtprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtprod.FormattingEnabled = True
        Me.txtprod.Location = New System.Drawing.Point(261, 664)
        Me.txtprod.Name = "txtprod"
        Me.txtprod.Size = New System.Drawing.Size(672, 28)
        Me.txtprod.TabIndex = 25
        '
        'cmbprod
        '
        Me.cmbprod.Enabled = False
        Me.cmbprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbprod.FormattingEnabled = True
        Me.cmbprod.Location = New System.Drawing.Point(105, 664)
        Me.cmbprod.Name = "cmbprod"
        Me.cmbprod.Size = New System.Drawing.Size(150, 28)
        Me.cmbprod.TabIndex = 24
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(20, 667)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 20)
        Me.Label24.TabIndex = 287
        Me.Label24.Text = "Producto:"
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Location = New System.Drawing.Point(775, 733)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(158, 34)
        Me.btneliminarfila.TabIndex = 33
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'btnactualizarfila
        '
        Me.btnactualizarfila.Location = New System.Drawing.Point(407, 733)
        Me.btnactualizarfila.Name = "btnactualizarfila"
        Me.btnactualizarfila.Size = New System.Drawing.Size(158, 34)
        Me.btnactualizarfila.TabIndex = 32
        Me.btnactualizarfila.Text = "Modificar Fila"
        Me.btnactualizarfila.UseVisualStyleBackColor = True
        '
        'chkbactualizarcosto
        '
        Me.chkbactualizarcosto.AutoSize = True
        Me.chkbactualizarcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbactualizarcosto.Location = New System.Drawing.Point(781, 639)
        Me.chkbactualizarcosto.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbactualizarcosto.Name = "chkbactualizarcosto"
        Me.chkbactualizarcosto.Size = New System.Drawing.Size(152, 24)
        Me.chkbactualizarcosto.TabIndex = 26
        Me.chkbactualizarcosto.Text = "Actualizar costo"
        Me.chkbactualizarcosto.UseVisualStyleBackColor = True
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(560, 699)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(104, 27)
        Me.txtprecio.TabIndex = 29
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(20, 702)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 20)
        Me.Label25.TabIndex = 295
        Me.Label25.Text = "Cantidad:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label26.Location = New System.Drawing.Point(27, 781)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 17)
        Me.Label26.TabIndex = 308
        Me.Label26.Text = "Totales"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(808, 797)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(125, 22)
        Me.txttotal.TabIndex = 40
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(754, 798)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 20)
        Me.Label27.TabIndex = 307
        Me.Label27.Text = "Total:"
        '
        'Notas_de_credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 850)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.btneliminarfila)
        Me.Controls.Add(Me.btnactualizarfila)
        Me.Controls.Add(Me.chkbactualizarcosto)
        Me.Controls.Add(Me.btninsertarfila)
        Me.Controls.Add(Me.txtpredescuento)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtprod)
        Me.Controls.Add(Me.cmbprod)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.gridfacturacion)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtnorecepcion)
        Me.Controls.Add(Me.txtidnota)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtsubruta)
        Me.Controls.Add(Me.txtidsubruta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtidruta)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbdepto)
        Me.Controls.Add(Me.txtdepto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtmunicipio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.txtidvendedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnonit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdocumento2)
        Me.Controls.Add(Me.txtdocumento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnotaresponsable)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtnotadecredito)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Notas_de_credito"
        Me.Text = "Notas_de_credito"
        CType(Me.gridfacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnotaresponsable As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnotadecredito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdocumento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdocumento2 As TextBox
    Friend WithEvents txttotales As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnonit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtidvendedor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtvendedor As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtmunicipio As ComboBox
    Friend WithEvents txtdepto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbdepto As ComboBox
    Friend WithEvents txtidruta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtruta As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtidsubruta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtsubruta As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtidnota As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtnorecepcion As TextBox
    Friend WithEvents gridfacturacion As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents txtpredescuento As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtprod As ComboBox
    Friend WithEvents cmbprod As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents btnactualizarfila As Button
    Friend WithEvents chkbactualizarcosto As CheckBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label27 As Label
End Class
