<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maestro_de_supervicion_
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtidsupervisor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDescripcion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmetadeventas = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtcomisionmeta = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtcomisionbajo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.chkbSupervisorActivo = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(163, 21)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(404, 38)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Maestro de Supervisores"
        '
        'txtidsupervisor
        '
        Me.txtidsupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidsupervisor.Location = New System.Drawing.Point(200, 86)
        Me.txtidsupervisor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidsupervisor.Name = "txtidsupervisor"
        Me.txtidsupervisor.Size = New System.Drawing.Size(112, 27)
        Me.txtidsupervisor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Id Supervisor:"
        '
        'cmbDescripcion
        '
        Me.cmbDescripcion.Enabled = False
        Me.cmbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmbDescripcion.FormattingEnabled = True
        Me.cmbDescripcion.Location = New System.Drawing.Point(200, 120)
        Me.cmbDescripcion.Name = "cmbDescripcion"
        Me.cmbDescripcion.Size = New System.Drawing.Size(512, 28)
        Me.cmbDescripcion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Descripción:"
        '
        'txtmetadeventas
        '
        Me.txtmetadeventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmetadeventas.Location = New System.Drawing.Point(200, 229)
        Me.txtmetadeventas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmetadeventas.Name = "txtmetadeventas"
        Me.txtmetadeventas.Size = New System.Drawing.Size(126, 27)
        Me.txtmetadeventas.TabIndex = 5
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(27, 232)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(135, 20)
        Me.Label32.TabIndex = 111
        Me.Label32.Text = "Meta De Ventas:"
        '
        'txtcomisionmeta
        '
        Me.txtcomisionmeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomisionmeta.Location = New System.Drawing.Point(200, 194)
        Me.txtcomisionmeta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcomisionmeta.Name = "txtcomisionmeta"
        Me.txtcomisionmeta.Size = New System.Drawing.Size(126, 27)
        Me.txtcomisionmeta.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(27, 197)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(126, 20)
        Me.Label31.TabIndex = 110
        Me.Label31.Text = "Comisión Meta:"
        '
        'txtcomisionbajo
        '
        Me.txtcomisionbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomisionbajo.Location = New System.Drawing.Point(200, 159)
        Me.txtcomisionbajo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcomisionbajo.Name = "txtcomisionbajo"
        Me.txtcomisionbajo.Size = New System.Drawing.Size(126, 27)
        Me.txtcomisionbajo.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(27, 162)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(165, 20)
        Me.Label30.TabIndex = 109
        Me.Label30.Text = "Comisión Bajo Meta:"
        '
        'chkbSupervisorActivo
        '
        Me.chkbSupervisorActivo.AutoSize = True
        Me.chkbSupervisorActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.chkbSupervisorActivo.Location = New System.Drawing.Point(640, 231)
        Me.chkbSupervisorActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbSupervisorActivo.Name = "chkbSupervisorActivo"
        Me.chkbSupervisorActivo.Size = New System.Drawing.Size(72, 24)
        Me.chkbSupervisorActivo.TabIndex = 6
        Me.chkbSupervisorActivo.Text = "Sí/No"
        Me.chkbSupervisorActivo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(497, 232)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 20)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Supervisor Activo"
        '
        'btnreporte
        '
        Me.btnreporte.Location = New System.Drawing.Point(630, 294)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 69)
        Me.btnreporte.TabIndex = 12
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(516, 294)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 69)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(398, 294)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(82, 69)
        Me.btneliminar.TabIndex = 10
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(279, 294)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(82, 69)
        Me.btnbuscar.TabIndex = 9
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(159, 294)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(82, 69)
        Me.btnGrabar.TabIndex = 8
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(31, 294)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(82, 69)
        Me.btnagregar.TabIndex = 7
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Maestro_de_supervicion_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 385)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.chkbSupervisorActivo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtmetadeventas)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtcomisionmeta)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtcomisionbajo)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cmbDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtidsupervisor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Maestro_de_supervicion_"
        Me.Text = "Maestro_de_supervicion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents txtidsupervisor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDescripcion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmetadeventas As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtcomisionmeta As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtcomisionbajo As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents chkbSupervisorActivo As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnagregar As Button
End Class
