<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Movimientos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mov10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 9, 9, 9)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 38)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mov3, Me.mov4, Me.mov5, Me.mov6, Me.mov7, Me.mov8, Me.mov9, Me.mov10})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Movimientos"
        '
        'mov3
        '
        Me.mov3.Name = "mov3"
        Me.mov3.Size = New System.Drawing.Size(257, 22)
        Me.mov3.Text = "Envios De Entrada"
        '
        'mov4
        '
        Me.mov4.Name = "mov4"
        Me.mov4.Size = New System.Drawing.Size(257, 22)
        Me.mov4.Text = "Envios De Salida"
        '
        'mov5
        '
        Me.mov5.Name = "mov5"
        Me.mov5.Size = New System.Drawing.Size(257, 22)
        Me.mov5.Text = "Facturas Compra"
        '
        'mov6
        '
        Me.mov6.Name = "mov6"
        Me.mov6.Size = New System.Drawing.Size(257, 22)
        Me.mov6.Text = "Notas de credito clientes"
        '
        'mov7
        '
        Me.mov7.Name = "mov7"
        Me.mov7.Size = New System.Drawing.Size(257, 22)
        Me.mov7.Text = "Notas de credito Proveedores"
        '
        'mov8
        '
        Me.mov8.Name = "mov8"
        Me.mov8.Size = New System.Drawing.Size(257, 22)
        Me.mov8.Text = "Recibo a clientes"
        '
        'mov9
        '
        Me.mov9.Name = "mov9"
        Me.mov9.Size = New System.Drawing.Size(257, 22)
        Me.mov9.Text = "Recibos  a proveedor"
        '
        'mov10
        '
        Me.mov10.Name = "mov10"
        Me.mov10.Size = New System.Drawing.Size(257, 22)
        Me.mov10.Text = "Facturas venta"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 38)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(600, 328)
        Me.PanelContenedor.TabIndex = 2
        '
        'Menu_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Menu_Movimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Movimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mov3 As ToolStripMenuItem
    Friend WithEvents mov4 As ToolStripMenuItem
    Friend WithEvents mov10 As ToolStripMenuItem
    Friend WithEvents mov6 As ToolStripMenuItem
    Friend WithEvents mov7 As ToolStripMenuItem
    Friend WithEvents mov8 As ToolStripMenuItem
    Friend WithEvents mov9 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents mov5 As ToolStripMenuItem
End Class
