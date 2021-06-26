<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maestro_de_productos
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIdProd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtvolumen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpromvtas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcombinacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCombinacion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbclasificacion = New System.Windows.Forms.ComboBox()
        Me.chkbAlta = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkbBloqueoTemp = New System.Windows.Forms.CheckBox()
        Me.txtPercentLiquidacion = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtGananciaFardo = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtganmedioFardo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtgananciadocena = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtprecioLiquidacion = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtPrecioFardo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtpreciomediofardo = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtPrecioDocena = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtMinInv = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtminvta = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txfardo = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtminmultiplo = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtnombreprod = New System.Windows.Forms.TextBox()
        Me.cmbidproveedor = New System.Windows.Forms.TextBox()
        Me.txtidprov = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 24)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Maestro De Productos"
        '
        'txtIdProd
        '
        Me.txtIdProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIdProd.Location = New System.Drawing.Point(100, 55)
        Me.txtIdProd.MaxLength = 4
        Me.txtIdProd.Name = "txtIdProd"
        Me.txtIdProd.Size = New System.Drawing.Size(85, 22)
        Me.txtIdProd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(8, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Id Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(8, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(8, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Id Proveedor:"
        '
        'txtvolumen
        '
        Me.txtvolumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtvolumen.Location = New System.Drawing.Point(100, 142)
        Me.txtvolumen.MaxLength = 4
        Me.txtvolumen.Name = "txtvolumen"
        Me.txtvolumen.Size = New System.Drawing.Size(85, 22)
        Me.txtvolumen.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(8, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Volumen:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(190, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Mts. Cúbicos"
        '
        'txtpromvtas
        '
        Me.txtpromvtas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtpromvtas.Location = New System.Drawing.Point(420, 142)
        Me.txtpromvtas.MaxLength = 4
        Me.txtpromvtas.Name = "txtpromvtas"
        Me.txtpromvtas.Size = New System.Drawing.Size(57, 22)
        Me.txtpromvtas.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(300, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 16)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Promedio Vta. Mes"
        '
        'txtpeso
        '
        Me.txtpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtpeso.Location = New System.Drawing.Point(528, 142)
        Me.txtpeso.MaxLength = 6
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(72, 22)
        Me.txtpeso.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(483, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Peso:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(606, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Kgs."
        '
        'txtcombinacion
        '
        Me.txtcombinacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtcombinacion.Location = New System.Drawing.Point(100, 172)
        Me.txtcombinacion.MaxLength = 4
        Me.txtcombinacion.Name = "txtcombinacion"
        Me.txtcombinacion.Size = New System.Drawing.Size(68, 22)
        Me.txtcombinacion.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(8, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Combinación:"
        '
        'cmbCombinacion
        '
        Me.cmbCombinacion.Enabled = False
        Me.cmbCombinacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbCombinacion.FormattingEnabled = True
        Me.cmbCombinacion.Location = New System.Drawing.Point(172, 172)
        Me.cmbCombinacion.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCombinacion.Name = "cmbCombinacion"
        Me.cmbCombinacion.Size = New System.Drawing.Size(170, 24)
        Me.cmbCombinacion.TabIndex = 10
        Me.cmbCombinacion.Text = "NO ASIGNADA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(360, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Clasificación:"
        '
        'cmbclasificacion
        '
        Me.cmbclasificacion.Enabled = False
        Me.cmbclasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbclasificacion.FormattingEnabled = True
        Me.cmbclasificacion.Location = New System.Drawing.Point(448, 172)
        Me.cmbclasificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbclasificacion.Name = "cmbclasificacion"
        Me.cmbclasificacion.Size = New System.Drawing.Size(189, 24)
        Me.cmbclasificacion.TabIndex = 11
        Me.cmbclasificacion.Text = "GRIFERIA"
        '
        'chkbAlta
        '
        Me.chkbAlta.AutoSize = True
        Me.chkbAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkbAlta.Location = New System.Drawing.Point(99, 202)
        Me.chkbAlta.Name = "chkbAlta"
        Me.chkbAlta.Size = New System.Drawing.Size(61, 20)
        Me.chkbAlta.TabIndex = 12
        Me.chkbAlta.Text = "Sí/No"
        Me.chkbAlta.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(8, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 16)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Alta Rotación:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(240, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 16)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Bloqueo Temporal:"
        '
        'chkbBloqueoTemp
        '
        Me.chkbBloqueoTemp.AutoSize = True
        Me.chkbBloqueoTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkbBloqueoTemp.Location = New System.Drawing.Point(360, 202)
        Me.chkbBloqueoTemp.Name = "chkbBloqueoTemp"
        Me.chkbBloqueoTemp.Size = New System.Drawing.Size(61, 20)
        Me.chkbBloqueoTemp.TabIndex = 13
        Me.chkbBloqueoTemp.Text = "Sí/No"
        Me.chkbBloqueoTemp.UseVisualStyleBackColor = True
        '
        'txtPercentLiquidacion
        '
        Me.txtPercentLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPercentLiquidacion.Location = New System.Drawing.Point(172, 246)
        Me.txtPercentLiquidacion.MaxLength = 6
        Me.txtPercentLiquidacion.Name = "txtPercentLiquidacion"
        Me.txtPercentLiquidacion.Size = New System.Drawing.Size(140, 22)
        Me.txtPercentLiquidacion.TabIndex = 25
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(6, 249)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(156, 16)
        Me.Label26.TabIndex = 93
        Me.Label26.Text = "% Ganancia Liquidación:"
        '
        'txtGananciaFardo
        '
        Me.txtGananciaFardo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtGananciaFardo.Location = New System.Drawing.Point(172, 274)
        Me.txtGananciaFardo.MaxLength = 6
        Me.txtGananciaFardo.Name = "txtGananciaFardo"
        Me.txtGananciaFardo.Size = New System.Drawing.Size(140, 22)
        Me.txtGananciaFardo.TabIndex = 27
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label27.Location = New System.Drawing.Point(6, 278)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(123, 16)
        Me.Label27.TabIndex = 95
        Me.Label27.Text = "% Ganancia Fardo:"
        '
        'txtganmedioFardo
        '
        Me.txtganmedioFardo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtganmedioFardo.Location = New System.Drawing.Point(172, 303)
        Me.txtganmedioFardo.MaxLength = 6
        Me.txtganmedioFardo.Name = "txtganmedioFardo"
        Me.txtganmedioFardo.Size = New System.Drawing.Size(140, 22)
        Me.txtganmedioFardo.TabIndex = 29
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label28.Location = New System.Drawing.Point(6, 306)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(144, 16)
        Me.Label28.TabIndex = 97
        Me.Label28.Text = "% Ganancia 1/2 Fardo:"
        '
        'txtgananciadocena
        '
        Me.txtgananciadocena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtgananciadocena.Location = New System.Drawing.Point(172, 331)
        Me.txtgananciadocena.MaxLength = 6
        Me.txtgananciadocena.Name = "txtgananciadocena"
        Me.txtgananciadocena.Size = New System.Drawing.Size(140, 22)
        Me.txtgananciadocena.TabIndex = 31
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label29.Location = New System.Drawing.Point(6, 335)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(135, 16)
        Me.Label29.TabIndex = 99
        Me.Label29.Text = "% Ganancia Docena:"
        '
        'txtprecioLiquidacion
        '
        Me.txtprecioLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtprecioLiquidacion.Location = New System.Drawing.Point(600, 246)
        Me.txtprecioLiquidacion.MaxLength = 6
        Me.txtprecioLiquidacion.Name = "txtprecioLiquidacion"
        Me.txtprecioLiquidacion.Size = New System.Drawing.Size(102, 22)
        Me.txtprecioLiquidacion.TabIndex = 26
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label30.Location = New System.Drawing.Point(470, 249)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(122, 16)
        Me.Label30.TabIndex = 101
        Me.Label30.Text = "Precio Liquidación:"
        '
        'txtPrecioFardo
        '
        Me.txtPrecioFardo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPrecioFardo.Location = New System.Drawing.Point(600, 275)
        Me.txtPrecioFardo.MaxLength = 6
        Me.txtPrecioFardo.Name = "txtPrecioFardo"
        Me.txtPrecioFardo.Size = New System.Drawing.Size(102, 22)
        Me.txtPrecioFardo.TabIndex = 28
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.Location = New System.Drawing.Point(470, 278)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 16)
        Me.Label31.TabIndex = 103
        Me.Label31.Text = "Precio: Fardo:"
        '
        'txtpreciomediofardo
        '
        Me.txtpreciomediofardo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtpreciomediofardo.Location = New System.Drawing.Point(600, 304)
        Me.txtpreciomediofardo.MaxLength = 6
        Me.txtpreciomediofardo.Name = "txtpreciomediofardo"
        Me.txtpreciomediofardo.Size = New System.Drawing.Size(102, 22)
        Me.txtpreciomediofardo.TabIndex = 30
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label32.Location = New System.Drawing.Point(470, 306)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(110, 16)
        Me.Label32.TabIndex = 105
        Me.Label32.Text = "Precio 1/2 Fardo:"
        '
        'txtPrecioDocena
        '
        Me.txtPrecioDocena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPrecioDocena.Location = New System.Drawing.Point(600, 332)
        Me.txtPrecioDocena.MaxLength = 6
        Me.txtPrecioDocena.Name = "txtPrecioDocena"
        Me.txtPrecioDocena.Size = New System.Drawing.Size(102, 22)
        Me.txtPrecioDocena.TabIndex = 32
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label33.Location = New System.Drawing.Point(470, 335)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(101, 16)
        Me.Label33.TabIndex = 107
        Me.Label33.Text = "Precio Docena:"
        '
        'txtMinInv
        '
        Me.txtMinInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtMinInv.Location = New System.Drawing.Point(68, 380)
        Me.txtMinInv.MaxLength = 5
        Me.txtMinInv.Name = "txtMinInv"
        Me.txtMinInv.Size = New System.Drawing.Size(54, 22)
        Me.txtMinInv.TabIndex = 33
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(12, 382)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 17)
        Me.Label34.TabIndex = 109
        Me.Label34.Text = "Mín Inv:"
        '
        'txtminvta
        '
        Me.txtminvta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtminvta.Location = New System.Drawing.Point(187, 380)
        Me.txtminvta.MaxLength = 5
        Me.txtminvta.Name = "txtminvta"
        Me.txtminvta.Size = New System.Drawing.Size(59, 22)
        Me.txtminvta.TabIndex = 34
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label35.Location = New System.Drawing.Point(133, 382)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 16)
        Me.Label35.TabIndex = 111
        Me.Label35.Text = "Mín Vta:"
        '
        'txtexistencia
        '
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtexistencia.Location = New System.Drawing.Point(301, 380)
        Me.txtexistencia.MaxLength = 5
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(57, 22)
        Me.txtexistencia.TabIndex = 35
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label36.Location = New System.Drawing.Point(252, 382)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(42, 16)
        Me.Label36.TabIndex = 113
        Me.Label36.Text = "Exist.:"
        '
        'txfardo
        '
        Me.txfardo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txfardo.Location = New System.Drawing.Point(422, 380)
        Me.txfardo.MaxLength = 5
        Me.txfardo.Name = "txfardo"
        Me.txfardo.Size = New System.Drawing.Size(59, 22)
        Me.txfardo.TabIndex = 36
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label37.Location = New System.Drawing.Point(374, 382)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 16)
        Me.Label37.TabIndex = 115
        Me.Label37.Text = "Fardo:"
        '
        'txtminmultiplo
        '
        Me.txtminmultiplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtminmultiplo.Location = New System.Drawing.Point(600, 362)
        Me.txtminmultiplo.MaxLength = 6
        Me.txtminmultiplo.Name = "txtminmultiplo"
        Me.txtminmultiplo.Size = New System.Drawing.Size(102, 22)
        Me.txtminmultiplo.TabIndex = 37
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label38.Location = New System.Drawing.Point(470, 364)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(103, 16)
        Me.Label38.TabIndex = 117
        Me.Label38.Text = "Mínimo Multiplo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(206, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Nombre:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtdescripcion.Location = New System.Drawing.Point(100, 86)
        Me.txtdescripcion.MaxLength = 60
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(613, 22)
        Me.txtdescripcion.TabIndex = 126
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 415)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(708, 189)
        Me.DataGridView1.TabIndex = 127
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(529, 609)
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
        Me.btncancelar.Location = New System.Drawing.Point(425, 609)
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
        Me.btneliminar.Location = New System.Drawing.Point(321, 609)
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
        Me.btnbuscar.Location = New System.Drawing.Point(217, 609)
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
        Me.btnGrabar.Location = New System.Drawing.Point(113, 609)
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
        Me.btnagregar.Location = New System.Drawing.Point(9, 609)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 400
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'txtnombreprod
        '
        Me.txtnombreprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombreprod.Location = New System.Drawing.Point(274, 55)
        Me.txtnombreprod.MaxLength = 50
        Me.txtnombreprod.Name = "txtnombreprod"
        Me.txtnombreprod.Size = New System.Drawing.Size(439, 22)
        Me.txtnombreprod.TabIndex = 406
        '
        'cmbidproveedor
        '
        Me.cmbidproveedor.Enabled = False
        Me.cmbidproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbidproveedor.Location = New System.Drawing.Point(193, 114)
        Me.cmbidproveedor.Name = "cmbidproveedor"
        Me.cmbidproveedor.Size = New System.Drawing.Size(519, 22)
        Me.cmbidproveedor.TabIndex = 407
        '
        'txtidprov
        '
        Me.txtidprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtidprov.Location = New System.Drawing.Point(98, 114)
        Me.txtidprov.MaxLength = 3
        Me.txtidprov.Name = "txtidprov"
        Me.txtidprov.Size = New System.Drawing.Size(87, 22)
        Me.txtidprov.TabIndex = 408
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Maestro_de_productos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(734, 676)
        Me.Controls.Add(Me.txtidprov)
        Me.Controls.Add(Me.cmbidproveedor)
        Me.Controls.Add(Me.txtnombreprod)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtminmultiplo)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txfardo)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtminvta)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtMinInv)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtPrecioDocena)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txtpreciomediofardo)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtPrecioFardo)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtprecioLiquidacion)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtgananciadocena)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtganmedioFardo)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtGananciaFardo)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtPercentLiquidacion)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.chkbBloqueoTemp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chkbAlta)
        Me.Controls.Add(Me.cmbclasificacion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbCombinacion)
        Me.Controls.Add(Me.txtcombinacion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpeso)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpromvtas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtvolumen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Maestro_de_productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro_de_productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents txtIdProd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtvolumen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpromvtas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpeso As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcombinacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbCombinacion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbclasificacion As ComboBox
    Friend WithEvents chkbAlta As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents chkbBloqueoTemp As CheckBox
    Friend WithEvents txtPercentLiquidacion As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtGananciaFardo As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtganmedioFardo As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtgananciadocena As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtprecioLiquidacion As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtPrecioFardo As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtpreciomediofardo As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtPrecioDocena As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtMinInv As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtminvta As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtexistencia As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txfardo As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtminmultiplo As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtnombreprod As TextBox
    Friend WithEvents cmbidproveedor As TextBox
    Friend WithEvents txtidprov As TextBox
    Friend WithEvents Timer1 As Timer
End Class
