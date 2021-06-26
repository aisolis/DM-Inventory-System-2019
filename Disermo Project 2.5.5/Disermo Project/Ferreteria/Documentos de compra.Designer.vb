<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentos_de_compra
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
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcompra1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescprod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txttipocompra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcompra2 = New System.Windows.Forms.TextBox()
        Me.chkbcredito = New System.Windows.Forms.CheckBox()
        Me.txtperiodo1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtperiodo2 = New System.Windows.Forms.TextBox()
        Me.chkbnotapend = New System.Windows.Forms.CheckBox()
        Me.chkbprodaltoprecio = New System.Windows.Forms.CheckBox()
        Me.chkbprodpendiente = New System.Windows.Forms.CheckBox()
        Me.griddocumentoscompra = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkbprodnosolicitado = New System.Windows.Forms.CheckBox()
        Me.chkbcanbiopendprov = New System.Windows.Forms.CheckBox()
        Me.chkbproductoconaltoprecio2 = New System.Windows.Forms.CheckBox()
        Me.chkbactualizarcosto = New System.Windows.Forms.CheckBox()
        Me.cmbprod = New System.Windows.Forms.ComboBox()
        Me.txtprod = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtpredescuento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btninsertarfila = New System.Windows.Forms.Button()
        Me.btnactualizarfila = New System.Windows.Forms.Button()
        Me.btneliminarfila = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.t = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        CType(Me.griddocumentoscompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtproveedor
        '
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.Location = New System.Drawing.Point(143, 92)
        Me.txtproveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(91, 27)
        Me.txtproveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Proveedor:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(552, 20)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(397, 38)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Documentos De Compra"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(143, 127)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 27)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Dirección:"
        '
        'txtcompra1
        '
        Me.txtcompra1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompra1.Location = New System.Drawing.Point(143, 162)
        Me.txtcompra1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcompra1.Name = "txtcompra1"
        Me.txtcompra1.Size = New System.Drawing.Size(91, 27)
        Me.txtcompra1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Compra No.:"
        '
        'cmbproveedor
        '
        Me.cmbproveedor.Enabled = False
        Me.cmbproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(241, 91)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(881, 28)
        Me.cmbproveedor.TabIndex = 2
        '
        'txtnit
        '
        Me.txtnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnit.Location = New System.Drawing.Point(1227, 91)
        Me.txtnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(121, 27)
        Me.txtnit.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1134, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "No. De Nit:"
        '
        'txtdescprod
        '
        Me.txtdescprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescprod.Location = New System.Drawing.Point(1274, 55)
        Me.txtdescprod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescprod.Name = "txtdescprod"
        Me.txtdescprod.Size = New System.Drawing.Size(45, 27)
        Me.txtdescprod.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1113, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 20)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Descto. Productos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1327, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 20)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1166, 127)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Fecha:"
        '
        'txtfecha
        '
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(1227, 124)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(121, 27)
        Me.txtfecha.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1180, 158)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "Descto.:"
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(1260, 155)
        Me.txtdesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(88, 27)
        Me.txtdesc.TabIndex = 14
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(241, 126)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(595, 27)
        Me.TextBox7.TabIndex = 6
        '
        'txttipocompra
        '
        Me.txttipocompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipocompra.Location = New System.Drawing.Point(994, 126)
        Me.txttipocompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txttipocompra.Name = "txttipocompra"
        Me.txttipocompra.Size = New System.Drawing.Size(128, 27)
        Me.txttipocompra.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(854, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 20)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Tipo de compra:"
        '
        'txtcompra2
        '
        Me.txtcompra2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompra2.Location = New System.Drawing.Point(241, 162)
        Me.txtcompra2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcompra2.Name = "txtcompra2"
        Me.txtcompra2.Size = New System.Drawing.Size(164, 27)
        Me.txtcompra2.TabIndex = 10
        '
        'chkbcredito
        '
        Me.chkbcredito.AutoSize = True
        Me.chkbcredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbcredito.Location = New System.Drawing.Point(610, 164)
        Me.chkbcredito.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbcredito.Name = "chkbcredito"
        Me.chkbcredito.Size = New System.Drawing.Size(85, 24)
        Me.chkbcredito.TabIndex = 11
        Me.chkbcredito.Text = "Credito"
        Me.chkbcredito.UseVisualStyleBackColor = True
        '
        'txtperiodo1
        '
        Me.txtperiodo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperiodo1.Location = New System.Drawing.Point(994, 162)
        Me.txtperiodo1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtperiodo1.Name = "txtperiodo1"
        Me.txtperiodo1.Size = New System.Drawing.Size(51, 27)
        Me.txtperiodo1.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(910, 165)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Periodo:"
        '
        'txtperiodo2
        '
        Me.txtperiodo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperiodo2.Location = New System.Drawing.Point(1053, 161)
        Me.txtperiodo2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtperiodo2.Name = "txtperiodo2"
        Me.txtperiodo2.Size = New System.Drawing.Size(69, 27)
        Me.txtperiodo2.TabIndex = 13
        '
        'chkbnotapend
        '
        Me.chkbnotapend.AutoSize = True
        Me.chkbnotapend.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbnotapend.Location = New System.Drawing.Point(38, 194)
        Me.chkbnotapend.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbnotapend.Name = "chkbnotapend"
        Me.chkbnotapend.Size = New System.Drawing.Size(300, 24)
        Me.chkbnotapend.TabIndex = 15
        Me.chkbnotapend.Text = "Nota Pend. x producto No Solicitado"
        Me.chkbnotapend.UseVisualStyleBackColor = True
        '
        'chkbprodaltoprecio
        '
        Me.chkbprodaltoprecio.AutoSize = True
        Me.chkbprodaltoprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbprodaltoprecio.Location = New System.Drawing.Point(544, 194)
        Me.chkbprodaltoprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbprodaltoprecio.Name = "chkbprodaltoprecio"
        Me.chkbprodaltoprecio.Size = New System.Drawing.Size(213, 24)
        Me.chkbprodaltoprecio.TabIndex = 16
        Me.chkbprodaltoprecio.Text = "Producto con precio alto"
        Me.chkbprodaltoprecio.UseVisualStyleBackColor = True
        '
        'chkbprodpendiente
        '
        Me.chkbprodpendiente.AutoSize = True
        Me.chkbprodpendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbprodpendiente.Location = New System.Drawing.Point(947, 194)
        Me.chkbprodpendiente.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbprodpendiente.Name = "chkbprodpendiente"
        Me.chkbprodpendiente.Size = New System.Drawing.Size(175, 24)
        Me.chkbprodpendiente.TabIndex = 17
        Me.chkbprodpendiente.Text = "Producto pendiente"
        Me.chkbprodpendiente.UseVisualStyleBackColor = True
        '
        'griddocumentoscompra
        '
        Me.griddocumentoscompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griddocumentoscompra.Location = New System.Drawing.Point(38, 225)
        Me.griddocumentoscompra.Name = "griddocumentoscompra"
        Me.griddocumentoscompra.RowTemplate.Height = 24
        Me.griddocumentoscompra.Size = New System.Drawing.Size(1310, 279)
        Me.griddocumentoscompra.TabIndex = 194
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 507)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(618, 20)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Haga doble click en la fila que desea modificar o eliminar en el detalle de compr" &
    "a."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(35, 546)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(623, 17)
        Me.Label17.TabIndex = 196
        Me.Label17.Text = "Detalle de Compra. En El cuadro precione [ESC] para salir o [ENTER] para consulta" &
    " de productos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 601)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 20)
        Me.Label12.TabIndex = 198
        Me.Label12.Text = "Producto:"
        '
        'chkbprodnosolicitado
        '
        Me.chkbprodnosolicitado.AutoSize = True
        Me.chkbprodnosolicitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbprodnosolicitado.Location = New System.Drawing.Point(38, 573)
        Me.chkbprodnosolicitado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbprodnosolicitado.Name = "chkbprodnosolicitado"
        Me.chkbprodnosolicitado.Size = New System.Drawing.Size(197, 24)
        Me.chkbprodnosolicitado.TabIndex = 18
        Me.chkbprodnosolicitado.Text = "Producto no solicitado"
        Me.chkbprodnosolicitado.UseVisualStyleBackColor = True
        '
        'chkbcanbiopendprov
        '
        Me.chkbcanbiopendprov.AutoSize = True
        Me.chkbcanbiopendprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbcanbiopendprov.Location = New System.Drawing.Point(422, 573)
        Me.chkbcanbiopendprov.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbcanbiopendprov.Name = "chkbcanbiopendprov"
        Me.chkbcanbiopendprov.Size = New System.Drawing.Size(244, 24)
        Me.chkbcanbiopendprov.TabIndex = 19
        Me.chkbcanbiopendprov.Text = "Cambio pendiente proveedor"
        Me.chkbcanbiopendprov.UseVisualStyleBackColor = True
        '
        'chkbproductoconaltoprecio2
        '
        Me.chkbproductoconaltoprecio2.AutoSize = True
        Me.chkbproductoconaltoprecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbproductoconaltoprecio2.Location = New System.Drawing.Point(832, 573)
        Me.chkbproductoconaltoprecio2.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbproductoconaltoprecio2.Name = "chkbproductoconaltoprecio2"
        Me.chkbproductoconaltoprecio2.Size = New System.Drawing.Size(213, 24)
        Me.chkbproductoconaltoprecio2.TabIndex = 20
        Me.chkbproductoconaltoprecio2.Text = "Producto con precio alto"
        Me.chkbproductoconaltoprecio2.UseVisualStyleBackColor = True
        '
        'chkbactualizarcosto
        '
        Me.chkbactualizarcosto.AutoSize = True
        Me.chkbactualizarcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbactualizarcosto.Location = New System.Drawing.Point(1196, 573)
        Me.chkbactualizarcosto.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbactualizarcosto.Name = "chkbactualizarcosto"
        Me.chkbactualizarcosto.Size = New System.Drawing.Size(152, 24)
        Me.chkbactualizarcosto.TabIndex = 21
        Me.chkbactualizarcosto.Text = "Actualizar costo"
        Me.chkbactualizarcosto.UseVisualStyleBackColor = True
        '
        'cmbprod
        '
        Me.cmbprod.Enabled = False
        Me.cmbprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbprod.FormattingEnabled = True
        Me.cmbprod.Location = New System.Drawing.Point(119, 598)
        Me.cmbprod.Name = "cmbprod"
        Me.cmbprod.Size = New System.Drawing.Size(150, 28)
        Me.cmbprod.TabIndex = 22
        '
        'txtprod
        '
        Me.txtprod.Enabled = False
        Me.txtprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtprod.FormattingEnabled = True
        Me.txtprod.Location = New System.Drawing.Point(275, 598)
        Me.txtprod.Name = "txtprod"
        Me.txtprod.Size = New System.Drawing.Size(1073, 28)
        Me.txtprod.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 636)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 205
        Me.Label13.Text = "Cantidad:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(119, 633)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(79, 27)
        Me.txtcantidad.TabIndex = 24
        '
        'txtexistencia
        '
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexistencia.Location = New System.Drawing.Point(341, 633)
        Me.txtexistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(104, 27)
        Me.txtexistencia.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(247, 636)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 20)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "Existencia:"
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(574, 633)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(79, 27)
        Me.txtprecio.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(504, 636)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 20)
        Me.Label16.TabIndex = 209
        Me.Label16.Text = "Precio:"
        '
        'txtpredescuento
        '
        Me.txtpredescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpredescuento.Location = New System.Drawing.Point(841, 633)
        Me.txtpredescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpredescuento.Name = "txtpredescuento"
        Me.txtpredescuento.Size = New System.Drawing.Size(79, 27)
        Me.txtpredescuento.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(724, 636)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 20)
        Me.Label18.TabIndex = 211
        Me.Label18.Text = "Prec. Descto:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.Location = New System.Drawing.Point(1269, 633)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(79, 27)
        Me.txtsubtotal.TabIndex = 214
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1212, 636)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 20)
        Me.Label19.TabIndex = 213
        Me.Label19.Text = "Total:"
        '
        'btninsertarfila
        '
        Me.btninsertarfila.Location = New System.Drawing.Point(38, 667)
        Me.btninsertarfila.Name = "btninsertarfila"
        Me.btninsertarfila.Size = New System.Drawing.Size(158, 34)
        Me.btninsertarfila.TabIndex = 28
        Me.btninsertarfila.Text = "Insertar Fila"
        Me.btninsertarfila.UseVisualStyleBackColor = True
        '
        'btnactualizarfila
        '
        Me.btnactualizarfila.Location = New System.Drawing.Point(630, 667)
        Me.btnactualizarfila.Name = "btnactualizarfila"
        Me.btnactualizarfila.Size = New System.Drawing.Size(158, 34)
        Me.btnactualizarfila.TabIndex = 29
        Me.btnactualizarfila.Text = "Modificar Fila"
        Me.btnactualizarfila.UseVisualStyleBackColor = True
        '
        'btneliminarfila
        '
        Me.btneliminarfila.Location = New System.Drawing.Point(1193, 667)
        Me.btneliminarfila.Name = "btneliminarfila"
        Me.btneliminarfila.Size = New System.Drawing.Size(158, 34)
        Me.btneliminarfila.TabIndex = 30
        Me.btneliminarfila.Text = "Eliminar Fila"
        Me.btneliminarfila.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.txttotal.Location = New System.Drawing.Point(1148, 747)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(125, 34)
        Me.txttotal.TabIndex = 223
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(1060, 752)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 29)
        Me.Label25.TabIndex = 224
        Me.Label25.Text = "Total:"
        '
        'txtdescuento
        '
        Me.txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.txtdescuento.Location = New System.Drawing.Point(752, 747)
        Me.txtdescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(125, 34)
        Me.txtdescuento.TabIndex = 221
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(612, 752)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(144, 29)
        Me.Label24.TabIndex = 222
        Me.Label24.Text = "Descuento:"
        '
        't
        '
        Me.t.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.t.Location = New System.Drawing.Point(168, 749)
        Me.t.Margin = New System.Windows.Forms.Padding(4)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(125, 34)
        Me.t.TabIndex = 219
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(34, 752)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 29)
        Me.Label23.TabIndex = 220
        Me.Label23.Text = "SubTotal:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label22.Location = New System.Drawing.Point(35, 724)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 17)
        Me.Label22.TabIndex = 218
        Me.Label22.Text = "Totales"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(1377, 509)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 69)
        Me.btnreporte.TabIndex = 230
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(1377, 634)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 69)
        Me.btncancelar.TabIndex = 229
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(1377, 393)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(82, 69)
        Me.btneliminar.TabIndex = 228
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(1377, 274)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(82, 69)
        Me.btnbuscar.TabIndex = 227
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(1377, 162)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(82, 69)
        Me.btnGrabar.TabIndex = 226
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(1377, 46)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(82, 69)
        Me.btnagregar.TabIndex = 225
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Documentos_de_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1474, 812)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btneliminarfila)
        Me.Controls.Add(Me.btnactualizarfila)
        Me.Controls.Add(Me.btninsertarfila)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtpredescuento)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtprod)
        Me.Controls.Add(Me.cmbprod)
        Me.Controls.Add(Me.chkbactualizarcosto)
        Me.Controls.Add(Me.chkbproductoconaltoprecio2)
        Me.Controls.Add(Me.chkbcanbiopendprov)
        Me.Controls.Add(Me.chkbprodnosolicitado)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.griddocumentoscompra)
        Me.Controls.Add(Me.chkbprodpendiente)
        Me.Controls.Add(Me.chkbprodaltoprecio)
        Me.Controls.Add(Me.chkbnotapend)
        Me.Controls.Add(Me.txtperiodo2)
        Me.Controls.Add(Me.txtperiodo1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkbcredito)
        Me.Controls.Add(Me.txtcompra2)
        Me.Controls.Add(Me.txttipocompra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdescprod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbproveedor)
        Me.Controls.Add(Me.txtcompra1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Documentos_de_compra"
        Me.Text = "Documentos_de_compra"
        CType(Me.griddocumentoscompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcompra1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbproveedor As ComboBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdescprod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txttipocompra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcompra2 As TextBox
    Friend WithEvents chkbcredito As CheckBox
    Friend WithEvents txtperiodo1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtperiodo2 As TextBox
    Friend WithEvents chkbnotapend As CheckBox
    Friend WithEvents chkbprodaltoprecio As CheckBox
    Friend WithEvents chkbprodpendiente As CheckBox
    Friend WithEvents griddocumentoscompra As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chkbprodnosolicitado As CheckBox
    Friend WithEvents chkbcanbiopendprov As CheckBox
    Friend WithEvents chkbproductoconaltoprecio2 As CheckBox
    Friend WithEvents chkbactualizarcosto As CheckBox
    Friend WithEvents cmbprod As ComboBox
    Friend WithEvents txtprod As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtpredescuento As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btninsertarfila As Button
    Friend WithEvents btnactualizarfila As Button
    Friend WithEvents btneliminarfila As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents t As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
End Class
