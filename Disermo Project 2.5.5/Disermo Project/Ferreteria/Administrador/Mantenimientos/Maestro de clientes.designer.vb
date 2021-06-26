<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maestro_de_clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CodCliente = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.CalleAvenida = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NoCasa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AptoPuestoLocal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NIT = New System.Windows.Forms.TextBox()
        Me.Colonia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.IdMunicipio = New System.Windows.Forms.TextBox()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Departamento = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.VIP = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DiasDeCredito = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.IdVendedor = New System.Windows.Forms.TextBox()
        Me.RutaDeCliente = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Transporte = New System.Windows.Forms.TextBox()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.BloqueoTemporal = New System.Windows.Forms.CheckBox()
        Me.cmbRuta = New System.Windows.Forms.ComboBox()
        Me.cmbTransporte = New System.Windows.Forms.ComboBox()
        Me.CmbVendedor = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.MotivoBloqueo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbTipodeCliente = New System.Windows.Forms.ComboBox()
        Me.TipoDeCliente = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmbSubRuta = New System.Windows.Forms.ComboBox()
        Me.SubRutaCliente = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LimCredito = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Disp = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmbBajaCliente = New System.Windows.Forms.ComboBox()
        Me.MotivoBaja = New System.Windows.Forms.TextBox()
        Me.txtobersaciones = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.zona = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Calle/ Avenida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(12, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Colonia o Lugar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(12, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Municipio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(12, 217)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Telefonos"
        '
        'CodCliente
        '
        Me.CodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CodCliente.Location = New System.Drawing.Point(112, 63)
        Me.CodCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.CodCliente.MaxLength = 5
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.Size = New System.Drawing.Size(89, 22)
        Me.CodCliente.TabIndex = 7
        '
        'Direccion
        '
        Me.Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Direccion.Location = New System.Drawing.Point(112, 112)
        Me.Direccion.Margin = New System.Windows.Forms.Padding(2)
        Me.Direccion.MaxLength = 80
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(751, 22)
        Me.Direccion.TabIndex = 10
        Me.Direccion.Text = " "
        '
        'CalleAvenida
        '
        Me.CalleAvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CalleAvenida.Location = New System.Drawing.Point(112, 138)
        Me.CalleAvenida.Margin = New System.Windows.Forms.Padding(2)
        Me.CalleAvenida.MaxLength = 30
        Me.CalleAvenida.Name = "CalleAvenida"
        Me.CalleAvenida.Size = New System.Drawing.Size(178, 22)
        Me.CalleAvenida.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(309, 138)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "No. Casa"
        '
        'NoCasa
        '
        Me.NoCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.NoCasa.Location = New System.Drawing.Point(382, 138)
        Me.NoCasa.Margin = New System.Windows.Forms.Padding(2)
        Me.NoCasa.MaxLength = 6
        Me.NoCasa.Name = "NoCasa"
        Me.NoCasa.Size = New System.Drawing.Size(54, 22)
        Me.NoCasa.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(442, 141)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Apto, No. Puesto, Local"
        '
        'AptoPuestoLocal
        '
        Me.AptoPuestoLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.AptoPuestoLocal.Location = New System.Drawing.Point(593, 139)
        Me.AptoPuestoLocal.Margin = New System.Windows.Forms.Padding(2)
        Me.AptoPuestoLocal.MaxLength = 20
        Me.AptoPuestoLocal.Name = "AptoPuestoLocal"
        Me.AptoPuestoLocal.Size = New System.Drawing.Size(102, 22)
        Me.AptoPuestoLocal.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(718, 142)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Zona"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(657, 66)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Nit"
        '
        'NIT
        '
        Me.NIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.NIT.Location = New System.Drawing.Point(682, 63)
        Me.NIT.Margin = New System.Windows.Forms.Padding(2)
        Me.NIT.MaxLength = 13
        Me.NIT.Name = "NIT"
        Me.NIT.Size = New System.Drawing.Size(181, 22)
        Me.NIT.TabIndex = 19
        '
        'Colonia
        '
        Me.Colonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Colonia.Location = New System.Drawing.Point(112, 164)
        Me.Colonia.Margin = New System.Windows.Forms.Padding(2)
        Me.Colonia.MaxLength = 30
        Me.Colonia.Name = "Colonia"
        Me.Colonia.Size = New System.Drawing.Size(178, 22)
        Me.Colonia.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(299, 165)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Id Municipio"
        '
        'IdMunicipio
        '
        Me.IdMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.IdMunicipio.Location = New System.Drawing.Point(382, 163)
        Me.IdMunicipio.Margin = New System.Windows.Forms.Padding(2)
        Me.IdMunicipio.MaxLength = 3
        Me.IdMunicipio.Name = "IdMunicipio"
        Me.IdMunicipio.Size = New System.Drawing.Size(54, 22)
        Me.IdMunicipio.TabIndex = 22
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.Enabled = False
        Me.cmbMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(112, 190)
        Me.cmbMunicipio.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(303, 24)
        Me.cmbMunicipio.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label13.Location = New System.Drawing.Point(423, 193)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Departamento"
        '
        'Departamento
        '
        Me.Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Departamento.Location = New System.Drawing.Point(520, 190)
        Me.Departamento.Margin = New System.Windows.Forms.Padding(2)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Size = New System.Drawing.Size(32, 22)
        Me.Departamento.TabIndex = 25
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.Enabled = False
        Me.cmbDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(556, 189)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(234, 24)
        Me.cmbDepartamento.TabIndex = 26
        '
        'Telefono
        '
        Me.Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Telefono.Location = New System.Drawing.Point(112, 215)
        Me.Telefono.Margin = New System.Windows.Forms.Padding(2)
        Me.Telefono.MaxLength = 8
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(134, 22)
        Me.Telefono.TabIndex = 27
        Me.Telefono.Text = " "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(423, 217)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "VIP"
        '
        'VIP
        '
        Me.VIP.AutoSize = True
        Me.VIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.VIP.Location = New System.Drawing.Point(448, 216)
        Me.VIP.Margin = New System.Windows.Forms.Padding(2)
        Me.VIP.Name = "VIP"
        Me.VIP.Size = New System.Drawing.Size(67, 20)
        Me.VIP.TabIndex = 31
        Me.VIP.Text = "Si / No"
        Me.VIP.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(11, 9)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(178, 24)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Maestro De Clientes"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(9, 267)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 16)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Días De Crédito"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(12, 293)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 16)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Observaciónes"
        '
        'DiasDeCredito
        '
        Me.DiasDeCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DiasDeCredito.Location = New System.Drawing.Point(113, 264)
        Me.DiasDeCredito.Margin = New System.Windows.Forms.Padding(2)
        Me.DiasDeCredito.MaxLength = 3
        Me.DiasDeCredito.Name = "DiasDeCredito"
        Me.DiasDeCredito.Size = New System.Drawing.Size(193, 22)
        Me.DiasDeCredito.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(12, 315)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 16)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Id Vendedor"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(12, 342)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 16)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Ruta Cliente"
        '
        'IdVendedor
        '
        Me.IdVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.IdVendedor.Location = New System.Drawing.Point(112, 315)
        Me.IdVendedor.Margin = New System.Windows.Forms.Padding(2)
        Me.IdVendedor.MaxLength = 3
        Me.IdVendedor.Name = "IdVendedor"
        Me.IdVendedor.Size = New System.Drawing.Size(39, 22)
        Me.IdVendedor.TabIndex = 40
        '
        'RutaDeCliente
        '
        Me.RutaDeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.RutaDeCliente.Location = New System.Drawing.Point(112, 342)
        Me.RutaDeCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.RutaDeCliente.MaxLength = 3
        Me.RutaDeCliente.Name = "RutaDeCliente"
        Me.RutaDeCliente.Size = New System.Drawing.Size(39, 22)
        Me.RutaDeCliente.TabIndex = 41
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(12, 369)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 16)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Transporte"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(9, 427)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 16)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Bloqueo Temporal"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label23.Location = New System.Drawing.Point(12, 458)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 16)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Estado"
        '
        'Transporte
        '
        Me.Transporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Transporte.Location = New System.Drawing.Point(112, 370)
        Me.Transporte.Margin = New System.Windows.Forms.Padding(2)
        Me.Transporte.MaxLength = 3
        Me.Transporte.Name = "Transporte"
        Me.Transporte.Size = New System.Drawing.Size(39, 22)
        Me.Transporte.TabIndex = 45
        '
        'Estado
        '
        Me.Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Estado.Location = New System.Drawing.Point(114, 451)
        Me.Estado.Margin = New System.Windows.Forms.Padding(2)
        Me.Estado.MaxLength = 3
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(39, 22)
        Me.Estado.TabIndex = 47
        '
        'BloqueoTemporal
        '
        Me.BloqueoTemporal.AutoSize = True
        Me.BloqueoTemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BloqueoTemporal.Location = New System.Drawing.Point(134, 424)
        Me.BloqueoTemporal.Margin = New System.Windows.Forms.Padding(2)
        Me.BloqueoTemporal.Name = "BloqueoTemporal"
        Me.BloqueoTemporal.Size = New System.Drawing.Size(67, 20)
        Me.BloqueoTemporal.TabIndex = 48
        Me.BloqueoTemporal.Text = "Si / No"
        Me.BloqueoTemporal.UseVisualStyleBackColor = True
        '
        'cmbRuta
        '
        Me.cmbRuta.Enabled = False
        Me.cmbRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbRuta.FormattingEnabled = True
        Me.cmbRuta.Location = New System.Drawing.Point(155, 342)
        Me.cmbRuta.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRuta.Name = "cmbRuta"
        Me.cmbRuta.Size = New System.Drawing.Size(279, 24)
        Me.cmbRuta.TabIndex = 49
        '
        'cmbTransporte
        '
        Me.cmbTransporte.Enabled = False
        Me.cmbTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbTransporte.FormattingEnabled = True
        Me.cmbTransporte.Location = New System.Drawing.Point(155, 369)
        Me.cmbTransporte.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTransporte.Name = "cmbTransporte"
        Me.cmbTransporte.Size = New System.Drawing.Size(279, 24)
        Me.cmbTransporte.TabIndex = 50
        '
        'CmbVendedor
        '
        Me.CmbVendedor.Enabled = False
        Me.CmbVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CmbVendedor.FormattingEnabled = True
        Me.CmbVendedor.Location = New System.Drawing.Point(155, 315)
        Me.CmbVendedor.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbVendedor.Name = "CmbVendedor"
        Me.CmbVendedor.Size = New System.Drawing.Size(279, 24)
        Me.CmbVendedor.TabIndex = 51
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(205, 427)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 16)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Motivo Bloqueo"
        '
        'MotivoBloqueo
        '
        Me.MotivoBloqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.MotivoBloqueo.Location = New System.Drawing.Point(312, 424)
        Me.MotivoBloqueo.Margin = New System.Windows.Forms.Padding(2)
        Me.MotivoBloqueo.MaxLength = 60
        Me.MotivoBloqueo.Name = "MotivoBloqueo"
        Me.MotivoBloqueo.Size = New System.Drawing.Size(550, 22)
        Me.MotivoBloqueo.TabIndex = 53
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(442, 316)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 16)
        Me.Label25.TabIndex = 54
        Me.Label25.Text = "Tipo De Cliente"
        '
        'cmbTipodeCliente
        '
        Me.cmbTipodeCliente.Enabled = False
        Me.cmbTipodeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbTipodeCliente.FormattingEnabled = True
        Me.cmbTipodeCliente.Location = New System.Drawing.Point(590, 315)
        Me.cmbTipodeCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipodeCliente.Name = "cmbTipodeCliente"
        Me.cmbTipodeCliente.Size = New System.Drawing.Size(200, 24)
        Me.cmbTipodeCliente.TabIndex = 56
        '
        'TipoDeCliente
        '
        Me.TipoDeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TipoDeCliente.Location = New System.Drawing.Point(547, 315)
        Me.TipoDeCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TipoDeCliente.MaxLength = 3
        Me.TipoDeCliente.Name = "TipoDeCliente"
        Me.TipoDeCliente.Size = New System.Drawing.Size(39, 22)
        Me.TipoDeCliente.TabIndex = 55
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(442, 343)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 16)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "SubRuta Cliente"
        '
        'cmbSubRuta
        '
        Me.cmbSubRuta.Enabled = False
        Me.cmbSubRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbSubRuta.FormattingEnabled = True
        Me.cmbSubRuta.Location = New System.Drawing.Point(590, 342)
        Me.cmbSubRuta.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSubRuta.Name = "cmbSubRuta"
        Me.cmbSubRuta.Size = New System.Drawing.Size(200, 24)
        Me.cmbSubRuta.TabIndex = 59
        '
        'SubRutaCliente
        '
        Me.SubRutaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.SubRutaCliente.Location = New System.Drawing.Point(547, 342)
        Me.SubRutaCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.SubRutaCliente.MaxLength = 3
        Me.SubRutaCliente.Name = "SubRutaCliente"
        Me.SubRutaCliente.Size = New System.Drawing.Size(39, 22)
        Me.SubRutaCliente.TabIndex = 58
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label27.Location = New System.Drawing.Point(465, 267)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 16)
        Me.Label27.TabIndex = 61
        Me.Label27.Text = "Disp"
        '
        'LimCredito
        '
        Me.LimCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LimCredito.Location = New System.Drawing.Point(387, 264)
        Me.LimCredito.Margin = New System.Windows.Forms.Padding(2)
        Me.LimCredito.MaxLength = 3
        Me.LimCredito.Name = "LimCredito"
        Me.LimCredito.Size = New System.Drawing.Size(74, 22)
        Me.LimCredito.TabIndex = 62
        Me.LimCredito.Text = " "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label28.Location = New System.Drawing.Point(307, 267)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 16)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "Lim. Credito"
        '
        'Disp
        '
        Me.Disp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Disp.Location = New System.Drawing.Point(505, 264)
        Me.Disp.Margin = New System.Windows.Forms.Padding(2)
        Me.Disp.MaxLength = 3
        Me.Disp.Name = "Disp"
        Me.Disp.Size = New System.Drawing.Size(74, 22)
        Me.Disp.TabIndex = 64
        Me.Disp.Text = " "
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label29.Location = New System.Drawing.Point(583, 268)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 16)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "Email"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Email.Location = New System.Drawing.Point(629, 264)
        Me.Email.Margin = New System.Windows.Forms.Padding(2)
        Me.Email.MaxLength = 30
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(233, 22)
        Me.Email.TabIndex = 66
        Me.Email.Text = " "
        '
        'cmbEstado
        '
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(156, 450)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(126, 24)
        Me.cmbEstado.TabIndex = 67
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label30.Location = New System.Drawing.Point(286, 453)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(123, 16)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Motivo Baja Cliente"
        '
        'cmbBajaCliente
        '
        Me.cmbBajaCliente.Enabled = False
        Me.cmbBajaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmbBajaCliente.FormattingEnabled = True
        Me.cmbBajaCliente.Location = New System.Drawing.Point(462, 451)
        Me.cmbBajaCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBajaCliente.Name = "cmbBajaCliente"
        Me.cmbBajaCliente.Size = New System.Drawing.Size(400, 24)
        Me.cmbBajaCliente.TabIndex = 70
        '
        'MotivoBaja
        '
        Me.MotivoBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.MotivoBaja.Location = New System.Drawing.Point(413, 452)
        Me.MotivoBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.MotivoBaja.MaxLength = 3
        Me.MotivoBaja.Name = "MotivoBaja"
        Me.MotivoBaja.Size = New System.Drawing.Size(48, 22)
        Me.MotivoBaja.TabIndex = 69
        '
        'txtobersaciones
        '
        Me.txtobersaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtobersaciones.Location = New System.Drawing.Point(112, 290)
        Me.txtobersaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtobersaciones.MaxLength = 100
        Me.txtobersaciones.Name = "txtobersaciones"
        Me.txtobersaciones.Size = New System.Drawing.Size(750, 22)
        Me.txtobersaciones.TabIndex = 78
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtnombre.Location = New System.Drawing.Point(113, 87)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.MaxLength = 60
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(750, 22)
        Me.txtnombre.TabIndex = 79
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(535, 553)
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
        Me.btncancelar.Location = New System.Drawing.Point(431, 553)
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
        Me.btneliminar.Location = New System.Drawing.Point(327, 553)
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
        Me.btnbuscar.Location = New System.Drawing.Point(223, 553)
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
        Me.btnGrabar.Location = New System.Drawing.Point(119, 553)
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
        Me.btnagregar.Location = New System.Drawing.Point(15, 553)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Size = New System.Drawing.Size(100, 35)
        Me.btnagregar.TabIndex = 400
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'zona
        '
        Me.zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.zona.Location = New System.Drawing.Point(761, 139)
        Me.zona.Margin = New System.Windows.Forms.Padding(2)
        Me.zona.MaxLength = 20
        Me.zona.Name = "zona"
        Me.zona.Size = New System.Drawing.Size(102, 22)
        Me.zona.TabIndex = 406
        '
        'Maestro_de_clientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 613)
        Me.Controls.Add(Me.zona)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtobersaciones)
        Me.Controls.Add(Me.cmbBajaCliente)
        Me.Controls.Add(Me.MotivoBaja)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Disp)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.LimCredito)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.cmbSubRuta)
        Me.Controls.Add(Me.SubRutaCliente)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cmbTipodeCliente)
        Me.Controls.Add(Me.TipoDeCliente)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.MotivoBloqueo)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.CmbVendedor)
        Me.Controls.Add(Me.cmbTransporte)
        Me.Controls.Add(Me.cmbRuta)
        Me.Controls.Add(Me.BloqueoTemporal)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Transporte)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.RutaDeCliente)
        Me.Controls.Add(Me.IdVendedor)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DiasDeCredito)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.VIP)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.Departamento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbMunicipio)
        Me.Controls.Add(Me.IdMunicipio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Colonia)
        Me.Controls.Add(Me.NIT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AptoPuestoLocal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NoCasa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CalleAvenida)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.CodCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Maestro_de_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents CalleAvenida As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NoCasa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AptoPuestoLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NIT As System.Windows.Forms.TextBox
    Friend WithEvents Colonia As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IdMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents cmbMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Departamento As System.Windows.Forms.TextBox
    Friend WithEvents cmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents VIP As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DiasDeCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents IdVendedor As System.Windows.Forms.TextBox
    Friend WithEvents RutaDeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Transporte As System.Windows.Forms.TextBox
    Friend WithEvents Estado As System.Windows.Forms.TextBox
    Friend WithEvents BloqueoTemporal As System.Windows.Forms.CheckBox
    Friend WithEvents cmbRuta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents CmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents MotivoBloqueo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbTipodeCliente As System.Windows.Forms.ComboBox
    Friend WithEvents TipoDeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbSubRuta As System.Windows.Forms.ComboBox
    Friend WithEvents SubRutaCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents LimCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Disp As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbBajaCliente As System.Windows.Forms.ComboBox
    Friend WithEvents MotivoBaja As System.Windows.Forms.TextBox
    Friend WithEvents txtobersaciones As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents zona As TextBox
End Class
