<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas_Canceladas_Clientes
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
        Me.lbl_FacturasCanceladasClientes = New System.Windows.Forms.Label()
        Me.lbl_idclien = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_fechInicial = New System.Windows.Forms.Label()
        Me.txt_idCliente = New System.Windows.Forms.TextBox()
        Me.cbx_nombre = New System.Windows.Forms.ComboBox()
        Me.lbl_fechFinal = New System.Windows.Forms.Label()
        Me.msktbx_fechFinal = New System.Windows.Forms.MaskedTextBox()
        Me.msktbx_fechInicial = New System.Windows.Forms.MaskedTextBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_FacturasCanceladasClientes
        '
        Me.lbl_FacturasCanceladasClientes.AutoSize = True
        Me.lbl_FacturasCanceladasClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FacturasCanceladasClientes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_FacturasCanceladasClientes.Location = New System.Drawing.Point(12, 9)
        Me.lbl_FacturasCanceladasClientes.Name = "lbl_FacturasCanceladasClientes"
        Me.lbl_FacturasCanceladasClientes.Size = New System.Drawing.Size(216, 25)
        Me.lbl_FacturasCanceladasClientes.TabIndex = 0
        Me.lbl_FacturasCanceladasClientes.Text = "Facturas Canceladas"
        '
        'lbl_idclien
        '
        Me.lbl_idclien.AutoSize = True
        Me.lbl_idclien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_idclien.Location = New System.Drawing.Point(14, 69)
        Me.lbl_idclien.Name = "lbl_idclien"
        Me.lbl_idclien.Size = New System.Drawing.Size(69, 16)
        Me.lbl_idclien.TabIndex = 2
        Me.lbl_idclien.Text = "Id. Cliente:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_nombre.Location = New System.Drawing.Point(14, 94)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(60, 16)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_fechInicial
        '
        Me.lbl_fechInicial.AutoSize = True
        Me.lbl_fechInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_fechInicial.Location = New System.Drawing.Point(14, 120)
        Me.lbl_fechInicial.Name = "lbl_fechInicial"
        Me.lbl_fechInicial.Size = New System.Drawing.Size(86, 16)
        Me.lbl_fechInicial.TabIndex = 4
        Me.lbl_fechInicial.Text = "Fecha Inicial:"
        '
        'txt_idCliente
        '
        Me.txt_idCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_idCliente.Location = New System.Drawing.Point(101, 63)
        Me.txt_idCliente.Name = "txt_idCliente"
        Me.txt_idCliente.Size = New System.Drawing.Size(100, 22)
        Me.txt_idCliente.TabIndex = 5
        '
        'cbx_nombre
        '
        Me.cbx_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cbx_nombre.FormattingEnabled = True
        Me.cbx_nombre.Location = New System.Drawing.Point(101, 88)
        Me.cbx_nombre.Name = "cbx_nombre"
        Me.cbx_nombre.Size = New System.Drawing.Size(349, 24)
        Me.cbx_nombre.TabIndex = 8
        '
        'lbl_fechFinal
        '
        Me.lbl_fechFinal.AutoSize = True
        Me.lbl_fechFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_fechFinal.Location = New System.Drawing.Point(221, 121)
        Me.lbl_fechFinal.Name = "lbl_fechFinal"
        Me.lbl_fechFinal.Size = New System.Drawing.Size(123, 16)
        Me.lbl_fechFinal.TabIndex = 9
        Me.lbl_fechFinal.Text = "Fecha Finalizacion:"
        '
        'msktbx_fechFinal
        '
        Me.msktbx_fechFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.msktbx_fechFinal.Location = New System.Drawing.Point(348, 117)
        Me.msktbx_fechFinal.Mask = "00/00/0000"
        Me.msktbx_fechFinal.Name = "msktbx_fechFinal"
        Me.msktbx_fechFinal.Size = New System.Drawing.Size(100, 22)
        Me.msktbx_fechFinal.TabIndex = 14
        Me.msktbx_fechFinal.ValidatingType = GetType(Date)
        '
        'msktbx_fechInicial
        '
        Me.msktbx_fechInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.msktbx_fechInicial.Location = New System.Drawing.Point(101, 115)
        Me.msktbx_fechInicial.Mask = "00/00/0000"
        Me.msktbx_fechInicial.Name = "msktbx_fechInicial"
        Me.msktbx_fechInicial.Size = New System.Drawing.Size(100, 22)
        Me.msktbx_fechInicial.TabIndex = 15
        Me.msktbx_fechInicial.ValidatingType = GetType(Date)
        '
        'btnreporte
        '
        Me.btnreporte.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.Image = Global.Disermo_Project.My.Resources.Resources.btnReporte
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.Location = New System.Drawing.Point(17, 182)
        Me.btnreporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Padding = New System.Windows.Forms.Padding(4)
        Me.btnreporte.Size = New System.Drawing.Size(100, 35)
        Me.btnreporte.TabIndex = 400
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
        Me.btncancelar.Location = New System.Drawing.Point(121, 182)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Padding = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Size = New System.Drawing.Size(100, 35)
        Me.btncancelar.TabIndex = 401
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Facturas_Canceladas_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 234)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.msktbx_fechInicial)
        Me.Controls.Add(Me.msktbx_fechFinal)
        Me.Controls.Add(Me.lbl_fechFinal)
        Me.Controls.Add(Me.cbx_nombre)
        Me.Controls.Add(Me.txt_idCliente)
        Me.Controls.Add(Me.lbl_fechInicial)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_idclien)
        Me.Controls.Add(Me.lbl_FacturasCanceladasClientes)
        Me.MaximizeBox = False
        Me.Name = "Facturas_Canceladas_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Pago de clientes (Disermo, S.A. DM DM DM)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_FacturasCanceladasClientes As Label
    Friend WithEvents lbl_idclien As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_fechInicial As Label
    Friend WithEvents txt_idCliente As TextBox
    Friend WithEvents cbx_nombre As ComboBox
    Friend WithEvents lbl_fechFinal As Label
    Friend WithEvents msktbx_fechFinal As MaskedTextBox
    Friend WithEvents msktbx_fechInicial As MaskedTextBox
    Friend WithEvents btnreporte As Button
    Friend WithEvents btncancelar As Button
End Class
