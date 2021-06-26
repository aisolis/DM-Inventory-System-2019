<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Envios_de_salida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Envios_de_salida))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.envio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtidvendedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidmunicipio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtobser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnombrevendedor = New System.Windows.Forms.TextBox()
        Me.cmbndepto = New System.Windows.Forms.ComboBox()
        Me.txtdepto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbmunicipio = New System.Windows.Forms.ComboBox()
        Me.txtrutanombre = New System.Windows.Forms.TextBox()
        Me.txtsubruta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.btnmodificarfila = New System.Windows.Forms.Button()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.txtnsubruta = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(13, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 24)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "Envios De Salida"
        '
        'envio
        '
        Me.envio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.envio.Location = New System.Drawing.Point(126, 49)
        Me.envio.Margin = New System.Windows.Forms.Padding(4)
        Me.envio.MaxLength = 5
        Me.envio.Name = "envio"
        Me.envio.Size = New System.Drawing.Size(125, 22)
        Me.envio.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Envio No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(19, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Cliente:"
        '
        'txtcliente
        '
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(126, 74)
        Me.txtcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcliente.MaxLength = 5
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(99, 23)
        Me.txtcliente.TabIndex = 136
        '
        'txtidvendedor
        '
        Me.txtidvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidvendedor.Location = New System.Drawing.Point(126, 130)
        Me.txtidvendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidvendedor.MaxLength = 5
        Me.txtidvendedor.Name = "txtidvendedor"
        Me.txtidvendedor.Size = New System.Drawing.Size(49, 23)
        Me.txtidvendedor.TabIndex = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(19, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Vendedor:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdireccion.Location = New System.Drawing.Point(126, 103)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(751, 22)
        Me.txtdireccion.TabIndex = 137
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(19, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Dirección:"
        '
        'txtruta
        '
        Me.txtruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruta.Location = New System.Drawing.Point(126, 185)
        Me.txtruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtruta.MaxLength = 5
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(49, 23)
        Me.txtruta.TabIndex = 144
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(19, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Ruta Cliente:"
        '
        'txtidmunicipio
        '
        Me.txtidmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidmunicipio.Location = New System.Drawing.Point(126, 159)
        Me.txtidmunicipio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidmunicipio.MaxLength = 5
        Me.txtidmunicipio.Name = "txtidmunicipio"
        Me.txtidmunicipio.Size = New System.Drawing.Size(49, 23)
        Me.txtidmunicipio.TabIndex = 141
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(19, 165)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "IdMunicipio:"
        '
        'txtobser
        '
        Me.txtobser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtobser.Location = New System.Drawing.Point(126, 215)
        Me.txtobser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtobser.MaxLength = 200
        Me.txtobser.Multiline = True
        Me.txtobser.Name = "txtobser"
        Me.txtobser.Size = New System.Drawing.Size(750, 47)
        Me.txtobser.TabIndex = 146
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(19, 219)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Observaciones:"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtfecha.Location = New System.Drawing.Point(552, 48)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(125, 22)
        Me.txtfecha.TabIndex = 156
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(495, 50)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "Fecha:"
        '
        'cmbcliente
        '
        Me.cmbcliente.Enabled = False
        Me.cmbcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(232, 74)
        Me.cmbcliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(645, 24)
        Me.cmbcliente.TabIndex = 162
        '
        'txtnit
        '
        Me.txtnit.Enabled = False
        Me.txtnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnit.Location = New System.Drawing.Point(752, 49)
        Me.txtnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(125, 22)
        Me.txtnit.TabIndex = 163
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(680, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 164
        Me.Label10.Text = "No De Nit:"
        '
        'txtnombrevendedor
        '
        Me.txtnombrevendedor.Enabled = False
        Me.txtnombrevendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombrevendedor.Location = New System.Drawing.Point(182, 130)
        Me.txtnombrevendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombrevendedor.Name = "txtnombrevendedor"
        Me.txtnombrevendedor.Size = New System.Drawing.Size(338, 22)
        Me.txtnombrevendedor.TabIndex = 165
        '
        'cmbndepto
        '
        Me.cmbndepto.Enabled = False
        Me.cmbndepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbndepto.FormattingEnabled = True
        Me.cmbndepto.Location = New System.Drawing.Point(640, 129)
        Me.cmbndepto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbndepto.Name = "cmbndepto"
        Me.cmbndepto.Size = New System.Drawing.Size(237, 24)
        Me.cmbndepto.TabIndex = 170
        '
        'txtdepto
        '
        Me.txtdepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdepto.Location = New System.Drawing.Point(584, 129)
        Me.txtdepto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdepto.MaxLength = 5
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.Size = New System.Drawing.Size(49, 22)
        Me.txtdepto.TabIndex = 169
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(528, 133)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Depto:"
        '
        'cmbmunicipio
        '
        Me.cmbmunicipio.Enabled = False
        Me.cmbmunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbmunicipio.FormattingEnabled = True
        Me.cmbmunicipio.Location = New System.Drawing.Point(182, 157)
        Me.cmbmunicipio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbmunicipio.Name = "cmbmunicipio"
        Me.cmbmunicipio.Size = New System.Drawing.Size(279, 24)
        Me.cmbmunicipio.TabIndex = 172
        '
        'txtrutanombre
        '
        Me.txtrutanombre.Enabled = False
        Me.txtrutanombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtrutanombre.Location = New System.Drawing.Point(182, 185)
        Me.txtrutanombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrutanombre.Name = "txtrutanombre"
        Me.txtrutanombre.Size = New System.Drawing.Size(279, 22)
        Me.txtrutanombre.TabIndex = 173
        '
        'txtsubruta
        '
        Me.txtsubruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubruta.Location = New System.Drawing.Point(584, 156)
        Me.txtsubruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubruta.MaxLength = 5
        Me.txtsubruta.Name = "txtsubruta"
        Me.txtsubruta.Size = New System.Drawing.Size(49, 22)
        Me.txtsubruta.TabIndex = 175
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(479, 159)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 16)
        Me.Label13.TabIndex = 174
        Me.Label13.Text = "Subruta Cliente:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 268)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(858, 143)
        Me.DataGridView1.TabIndex = 177
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(19, 413)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(537, 16)
        Me.Label14.TabIndex = 178
        Me.Label14.Text = "Haga Doble Click Sonbre La Fila Que Desea Modificar o Eliminar En El Detalle Del " &
    "Envio"
        '
        'txt_producto
        '
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_producto.Location = New System.Drawing.Point(111, 467)
        Me.txt_producto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(125, 22)
        Me.txt_producto.TabIndex = 179
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 470)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 17)
        Me.Label16.TabIndex = 180
        Me.Label16.Text = "Producto:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(19, 447)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(576, 16)
        Me.Label17.TabIndex = 181
        Me.Label17.Text = "Detalle de envio. En El cuadro precione [ESC] para salir o [ENTER] para consulta " &
    "de productos"
        '
        'txtproducto
        '
        Me.txtproducto.Enabled = False
        Me.txtproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtproducto.FormattingEnabled = True
        Me.txtproducto.Location = New System.Drawing.Point(243, 468)
        Me.txtproducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(633, 24)
        Me.txtproducto.TabIndex = 182
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 499)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 17)
        Me.Label18.TabIndex = 183
        Me.Label18.Text = "Cantidad:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(111, 496)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(48, 23)
        Me.txtcantidad.TabIndex = 184
        '
        'txtexistencia
        '
        Me.txtexistencia.Enabled = False
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtexistencia.Location = New System.Drawing.Point(333, 497)
        Me.txtexistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(67, 22)
        Me.txtexistencia.TabIndex = 186
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(258, 499)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 185
        Me.Label19.Text = "Existencia:"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprecio.Location = New System.Drawing.Point(566, 497)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(67, 22)
        Me.txtprecio.TabIndex = 188
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(517, 499)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 16)
        Me.Label20.TabIndex = 187
        Me.Label20.Text = "Precio:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtsubtotal.Location = New System.Drawing.Point(752, 497)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(125, 22)
        Me.txtsubtotal.TabIndex = 190
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(709, 501)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 189
        Me.Label21.Text = "Total:"
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btneliminarfila.Location = New System.Drawing.Point(719, 541)
        Me.btneliminarfila.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(157, 34)
        Me.btneliminarfila.TabIndex = 207
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'btnmodificarfila
        '
        Me.btnmodificarfila.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnmodificarfila.Location = New System.Drawing.Point(387, 541)
        Me.btnmodificarfila.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificarfila.Name = "btnmodificarfila"
        Me.btnmodificarfila.Size = New System.Drawing.Size(157, 34)
        Me.btnmodificarfila.TabIndex = 206
        Me.btnmodificarfila.Text = "Modificar Fila"
        Me.btnmodificarfila.UseVisualStyleBackColor = True
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Location = New System.Drawing.Point(18, 541)
        Me.btninsertarfila.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(157, 34)
        Me.btninsertarfila.TabIndex = 205
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'txtnsubruta
        '
        Me.txtnsubruta.Enabled = False
        Me.txtnsubruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnsubruta.Location = New System.Drawing.Point(641, 156)
        Me.txtnsubruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnsubruta.Name = "txtnsubruta"
        Me.txtnsubruta.Size = New System.Drawing.Size(236, 22)
        Me.txtnsubruta.TabIndex = 176
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(518, 607)
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
        Me.txttotal.Location = New System.Drawing.Point(170, 645)
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
        Me.btnreporte.Location = New System.Drawing.Point(632, 654)
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
        Me.btncancelar.Location = New System.Drawing.Point(518, 654)
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
        Me.btneliminar.Location = New System.Drawing.Point(763, 607)
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
        Me.btnbuscar.Location = New System.Drawing.Point(640, 607)
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
        Me.btnagregar.Location = New System.Drawing.Point(396, 607)
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
        Me.Label25.Location = New System.Drawing.Point(129, 653)
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
        Me.Label22.Location = New System.Drawing.Point(27, 620)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 16)
        Me.Label22.TabIndex = 425
        Me.Label22.Text = "Totales"
        '
        'Envios_de_salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 712)
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
        Me.Controls.Add(Me.txtproducto)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnsubruta)
        Me.Controls.Add(Me.txtsubruta)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtrutanombre)
        Me.Controls.Add(Me.cmbmunicipio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbndepto)
        Me.Controls.Add(Me.txtdepto)
        Me.Controls.Add(Me.txtnombrevendedor)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtobser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtidmunicipio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtidvendedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.envio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Envios_de_salida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de venta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents envio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents txtidvendedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtruta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidmunicipio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtobser As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbcliente As ComboBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnombrevendedor As TextBox
    Friend WithEvents cmbndepto As ComboBox
    Friend WithEvents txtdepto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbmunicipio As ComboBox
    Friend WithEvents txtrutanombre As TextBox
    Friend WithEvents txtsubruta As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtproducto As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents btnmodificarfila As Button
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents txtnsubruta As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
End Class
