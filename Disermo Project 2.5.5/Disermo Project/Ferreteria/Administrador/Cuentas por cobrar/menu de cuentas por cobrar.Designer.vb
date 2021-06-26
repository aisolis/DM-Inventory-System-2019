<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_de_cuentas_por_cobrar
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
        Me.CuentasPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntiguedadDeSaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaCanceladasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasMorosasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasDeDebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteGeneralDeNotasDeDebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasPorCobrarToolStripMenuItem, Me.NotasDeDebitoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(16, 10, 10, 10)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CuentasPorCobrarToolStripMenuItem
        '
        Me.CuentasPorCobrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AntiguedadDeSaldosToolStripMenuItem, Me.FacturaCanceladasToolStripMenuItem, Me.FacturasMorosasToolStripMenuItem, Me.FacturasPendientesToolStripMenuItem})
        Me.CuentasPorCobrarToolStripMenuItem.Name = "CuentasPorCobrarToolStripMenuItem"
        Me.CuentasPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.CuentasPorCobrarToolStripMenuItem.Text = "Cuentas por cobrar"
        '
        'AntiguedadDeSaldosToolStripMenuItem
        '
        Me.AntiguedadDeSaldosToolStripMenuItem.Name = "AntiguedadDeSaldosToolStripMenuItem"
        Me.AntiguedadDeSaldosToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.AntiguedadDeSaldosToolStripMenuItem.Text = "Antiguedad de saldos"
        '
        'FacturaCanceladasToolStripMenuItem
        '
        Me.FacturaCanceladasToolStripMenuItem.Name = "FacturaCanceladasToolStripMenuItem"
        Me.FacturaCanceladasToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.FacturaCanceladasToolStripMenuItem.Text = "Factura canceladas"
        '
        'FacturasMorosasToolStripMenuItem
        '
        Me.FacturasMorosasToolStripMenuItem.Name = "FacturasMorosasToolStripMenuItem"
        Me.FacturasMorosasToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.FacturasMorosasToolStripMenuItem.Text = "Facturas morosas x vendedor"
        '
        'FacturasPendientesToolStripMenuItem
        '
        Me.FacturasPendientesToolStripMenuItem.Name = "FacturasPendientesToolStripMenuItem"
        Me.FacturasPendientesToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.FacturasPendientesToolStripMenuItem.Text = "Facturas pendientes"
        '
        'NotasDeDebitoToolStripMenuItem
        '
        Me.NotasDeDebitoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteGeneralDeNotasDeDebitoToolStripMenuItem, Me.ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem, Me.ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem})
        Me.NotasDeDebitoToolStripMenuItem.Name = "NotasDeDebitoToolStripMenuItem"
        Me.NotasDeDebitoToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.NotasDeDebitoToolStripMenuItem.Text = "Notas de debito"
        '
        'ReporteGeneralDeNotasDeDebitoToolStripMenuItem
        '
        Me.ReporteGeneralDeNotasDeDebitoToolStripMenuItem.Name = "ReporteGeneralDeNotasDeDebitoToolStripMenuItem"
        Me.ReporteGeneralDeNotasDeDebitoToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.ReporteGeneralDeNotasDeDebitoToolStripMenuItem.Text = "Reporte General de notas de debito"
        '
        'ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem
        '
        Me.ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem.Name = "ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem"
        Me.ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem.Text = "Reporte General de notas de debito por cobrar"
        '
        'ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem
        '
        Me.ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem.Name = "ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem"
        Me.ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem.Size = New System.Drawing.Size(366, 22)
        Me.ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem.Text = "Reporte General de notas de debito exoneradas"
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
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(800, 410)
        Me.PanelContenedor.TabIndex = 1
        '
        'menu_de_cuentas_por_cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "menu_de_cuentas_por_cobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "menu_de_cuentas_por_cobrar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CuentasPorCobrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AntiguedadDeSaldosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaCanceladasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasMorosasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasPendientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasDeDebitoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteGeneralDeNotasDeDebitoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteGeneralDeNotasDeDebitoPorCobrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteGeneralDeNotasDeDebitoExoneradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
End Class
