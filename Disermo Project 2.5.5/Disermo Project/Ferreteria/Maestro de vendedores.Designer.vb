<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maestro_de_vendedores
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
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbNombreVendedor = New System.Windows.Forms.ComboBox()
        Me.txtcomabajo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdSupervisor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdSubGerente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdRegion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreSupervisor = New System.Windows.Forms.TextBox()
        Me.txtNombreSubGerente = New System.Windows.Forms.TextBox()
        Me.txtNombreRegion = New System.Windows.Forms.TextBox()
        Me.ChkbVendActivo = New System.Windows.Forms.CheckBox()
        Me.txtcommeta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMetaVentas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdRuta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreRuta = New System.Windows.Forms.TextBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVendedor.Location = New System.Drawing.Point(179, 77)
        Me.txtIdVendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(91, 27)
        Me.txtIdVendedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Vendedor:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(277, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(406, 39)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Maestro De Vendedores"
        '
        'cmbNombreVendedor
        '
        Me.cmbNombreVendedor.Enabled = False
        Me.cmbNombreVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbNombreVendedor.FormattingEnabled = True
        Me.cmbNombreVendedor.Location = New System.Drawing.Point(277, 77)
        Me.cmbNombreVendedor.Name = "cmbNombreVendedor"
        Me.cmbNombreVendedor.Size = New System.Drawing.Size(634, 28)
        Me.cmbNombreVendedor.TabIndex = 2
        '
        'txtcomabajo
        '
        Me.txtcomabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomabajo.Location = New System.Drawing.Point(179, 114)
        Me.txtcomabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcomabajo.Name = "txtcomabajo"
        Me.txtcomabajo.Size = New System.Drawing.Size(91, 27)
        Me.txtcomabajo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(25, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Com. Abajo Meta:"
        '
        'txtIdSupervisor
        '
        Me.txtIdSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSupervisor.Location = New System.Drawing.Point(179, 150)
        Me.txtIdSupervisor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdSupervisor.Name = "txtIdSupervisor"
        Me.txtIdSupervisor.Size = New System.Drawing.Size(91, 27)
        Me.txtIdSupervisor.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Id Supervisor:"
        '
        'txtIdSubGerente
        '
        Me.txtIdSubGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSubGerente.Location = New System.Drawing.Point(179, 186)
        Me.txtIdSubGerente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdSubGerente.Name = "txtIdSubGerente"
        Me.txtIdSubGerente.Size = New System.Drawing.Size(91, 27)
        Me.txtIdSubGerente.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 189)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Id SubGerente:"
        '
        'txtIdRegion
        '
        Me.txtIdRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRegion.Location = New System.Drawing.Point(179, 221)
        Me.txtIdRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdRegion.Name = "txtIdRegion"
        Me.txtIdRegion.Size = New System.Drawing.Size(91, 27)
        Me.txtIdRegion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 224)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Id Región:"
        '
        'txtNombreSupervisor
        '
        Me.txtNombreSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSupervisor.Location = New System.Drawing.Point(278, 150)
        Me.txtNombreSupervisor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreSupervisor.Name = "txtNombreSupervisor"
        Me.txtNombreSupervisor.Size = New System.Drawing.Size(632, 27)
        Me.txtNombreSupervisor.TabIndex = 8
        '
        'txtNombreSubGerente
        '
        Me.txtNombreSubGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSubGerente.Location = New System.Drawing.Point(277, 186)
        Me.txtNombreSubGerente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreSubGerente.Name = "txtNombreSubGerente"
        Me.txtNombreSubGerente.Size = New System.Drawing.Size(633, 27)
        Me.txtNombreSubGerente.TabIndex = 10
        '
        'txtNombreRegion
        '
        Me.txtNombreRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreRegion.Location = New System.Drawing.Point(277, 221)
        Me.txtNombreRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreRegion.Name = "txtNombreRegion"
        Me.txtNombreRegion.Size = New System.Drawing.Size(203, 27)
        Me.txtNombreRegion.TabIndex = 12
        '
        'ChkbVendActivo
        '
        Me.ChkbVendActivo.AutoSize = True
        Me.ChkbVendActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ChkbVendActivo.Location = New System.Drawing.Point(757, 116)
        Me.ChkbVendActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkbVendActivo.Name = "ChkbVendActivo"
        Me.ChkbVendActivo.Size = New System.Drawing.Size(153, 24)
        Me.ChkbVendActivo.TabIndex = 6
        Me.ChkbVendActivo.Text = "Vendedor Activo"
        Me.ChkbVendActivo.UseVisualStyleBackColor = True
        '
        'txtcommeta
        '
        Me.txtcommeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcommeta.Location = New System.Drawing.Point(396, 114)
        Me.txtcommeta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcommeta.Name = "txtcommeta"
        Me.txtcommeta.Size = New System.Drawing.Size(91, 27)
        Me.txtcommeta.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Com. Meta:"
        '
        'txtMetaVentas
        '
        Me.txtMetaVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMetaVentas.Location = New System.Drawing.Point(642, 114)
        Me.txtMetaVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMetaVentas.Name = "txtMetaVentas"
        Me.txtMetaVentas.Size = New System.Drawing.Size(91, 27)
        Me.txtMetaVentas.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(526, 117)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Meta Ventas:"
        '
        'txtIdRuta
        '
        Me.txtIdRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRuta.Location = New System.Drawing.Point(619, 221)
        Me.txtIdRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdRuta.Name = "txtIdRuta"
        Me.txtIdRuta.Size = New System.Drawing.Size(48, 27)
        Me.txtIdRuta.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label8.Location = New System.Drawing.Point(488, 224)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Ruta Asignada:"
        '
        'txtNombreRuta
        '
        Me.txtNombreRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreRuta.Location = New System.Drawing.Point(675, 221)
        Me.txtNombreRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreRuta.Name = "txtNombreRuta"
        Me.txtNombreRuta.Size = New System.Drawing.Size(235, 27)
        Me.txtNombreRuta.TabIndex = 14
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(828, 287)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 69)
        Me.btnreporte.TabIndex = 20
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(675, 287)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 69)
        Me.btncancelar.TabIndex = 19
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(514, 287)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(82, 69)
        Me.btneliminar.TabIndex = 18
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(347, 287)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(82, 69)
        Me.btnbuscar.TabIndex = 17
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(179, 287)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(82, 69)
        Me.btnGrabar.TabIndex = 16
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(29, 287)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(82, 69)
        Me.btnagregar.TabIndex = 15
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Maestro_de_vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 380)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtNombreRuta)
        Me.Controls.Add(Me.txtIdRuta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMetaVentas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcommeta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChkbVendActivo)
        Me.Controls.Add(Me.txtNombreRegion)
        Me.Controls.Add(Me.txtNombreSubGerente)
        Me.Controls.Add(Me.txtNombreSupervisor)
        Me.Controls.Add(Me.txtIdRegion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdSubGerente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdSupervisor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcomabajo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNombreVendedor)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Maestro_de_vendedores"
        Me.Text = "Maestro_de_vendedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbNombreVendedor As ComboBox
    Friend WithEvents txtcomabajo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdSupervisor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdSubGerente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdRegion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreSupervisor As TextBox
    Friend WithEvents txtNombreSubGerente As TextBox
    Friend WithEvents txtNombreRegion As TextBox
    Friend WithEvents ChkbVendActivo As CheckBox
    Friend WithEvents txtcommeta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMetaVentas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreRuta As TextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
End Class
