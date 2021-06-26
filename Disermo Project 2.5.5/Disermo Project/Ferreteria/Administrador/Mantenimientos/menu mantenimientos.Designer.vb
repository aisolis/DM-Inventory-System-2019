<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_mantenimientos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeCombinacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeSupervicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroDeVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeRutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeSubRutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MunicipiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestroDeClientesToolStripMenuItem, Me.MaestroDeCombinacionesToolStripMenuItem, Me.MaestroDeProductosToolStripMenuItem, Me.MaestroDeProveedoresToolStripMenuItem, Me.MaestroDeSupervicionToolStripMenuItem, Me.MaestroDeUsuariosToolStripMenuItem, Me.MaestroDeVendedoresToolStripMenuItem, Me.MantenimientoDeRutasToolStripMenuItem, Me.MantenimientoDeSubRutasToolStripMenuItem, Me.MunicipiosToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'MaestroDeClientesToolStripMenuItem
        '
        Me.MaestroDeClientesToolStripMenuItem.Name = "MaestroDeClientesToolStripMenuItem"
        Me.MaestroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MaestroDeClientesToolStripMenuItem.Text = "Maestro de clientes"
        '
        'MaestroDeCombinacionesToolStripMenuItem
        '
        Me.MaestroDeCombinacionesToolStripMenuItem.Name = "MaestroDeCombinacionesToolStripMenuItem"
        Me.MaestroDeCombinacionesToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MaestroDeCombinacionesToolStripMenuItem.Text = "Maestro de combinaciones"
        '
        'MaestroDeProductosToolStripMenuItem
        '
        Me.MaestroDeProductosToolStripMenuItem.Name = "MaestroDeProductosToolStripMenuItem"
        Me.MaestroDeProductosToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MaestroDeProductosToolStripMenuItem.Text = "Maestro de productos"
        '
        'MaestroDeProveedoresToolStripMenuItem
        '
        Me.MaestroDeProveedoresToolStripMenuItem.Name = "MaestroDeProveedoresToolStripMenuItem"
        Me.MaestroDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MaestroDeProveedoresToolStripMenuItem.Text = "Maestro de proveedores"
        '
        'MaestroDeSupervicionToolStripMenuItem
        '
        Me.MaestroDeSupervicionToolStripMenuItem.Name = "MaestroDeSupervicionToolStripMenuItem"
        Me.MaestroDeSupervicionToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MaestroDeSupervicionToolStripMenuItem.Text = "Maestro de supervicion"
        '
        'MaestroDeUsuariosToolStripMenuItem
        '
        Me.MaestroDeUsuariosToolStripMenuItem.Name = "MaestroDeUsuariosToolStripMenuItem"
        Me.MaestroDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MaestroDeUsuariosToolStripMenuItem.Text = "Maestro de usuarios"
        '
        'MaestroDeVendedoresToolStripMenuItem
        '
        Me.MaestroDeVendedoresToolStripMenuItem.Name = "MaestroDeVendedoresToolStripMenuItem"
        Me.MaestroDeVendedoresToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MaestroDeVendedoresToolStripMenuItem.Text = "Maestro de vendedores"
        '
        'MantenimientoDeRutasToolStripMenuItem
        '
        Me.MantenimientoDeRutasToolStripMenuItem.Name = "MantenimientoDeRutasToolStripMenuItem"
        Me.MantenimientoDeRutasToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MantenimientoDeRutasToolStripMenuItem.Text = "Mantenimiento de rutas"
        '
        'MantenimientoDeSubRutasToolStripMenuItem
        '
        Me.MantenimientoDeSubRutasToolStripMenuItem.Name = "MantenimientoDeSubRutasToolStripMenuItem"
        Me.MantenimientoDeSubRutasToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MantenimientoDeSubRutasToolStripMenuItem.Text = "Mantenimiento de sub rutas"
        '
        'MunicipiosToolStripMenuItem
        '
        Me.MunicipiosToolStripMenuItem.Name = "MunicipiosToolStripMenuItem"
        Me.MunicipiosToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.MunicipiosToolStripMenuItem.Text = "Municipios"
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
        Me.PanelContenedor.TabIndex = 1
        '
        'menu_mantenimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "menu_mantenimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "menu_mantenimientos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeCombinacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeSupervicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroDeVendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoDeRutasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoDeSubRutasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MunicipiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
End Class
