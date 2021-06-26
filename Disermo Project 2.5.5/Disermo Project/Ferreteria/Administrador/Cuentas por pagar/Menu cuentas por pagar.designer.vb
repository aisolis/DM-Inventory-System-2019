<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuCuentasPorPagar
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
        Me.CuentasPorPagarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosEnMoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosCanceladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeAntiguedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasPorPagarToolStripMenuItem1, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 9, 9, 9)
        Me.MenuStrip1.Size = New System.Drawing.Size(617, 38)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CuentasPorPagarToolStripMenuItem1
        '
        Me.CuentasPorPagarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentosEnMoraToolStripMenuItem, Me.DocumentosPorPagarToolStripMenuItem, Me.DocumentosCanceladosToolStripMenuItem, Me.ReporteDeAntiguedadToolStripMenuItem})
        Me.CuentasPorPagarToolStripMenuItem1.Name = "CuentasPorPagarToolStripMenuItem1"
        Me.CuentasPorPagarToolStripMenuItem1.Size = New System.Drawing.Size(129, 20)
        Me.CuentasPorPagarToolStripMenuItem1.Text = "cuentas por pagar"
        '
        'DocumentosEnMoraToolStripMenuItem
        '
        Me.DocumentosEnMoraToolStripMenuItem.Name = "DocumentosEnMoraToolStripMenuItem"
        Me.DocumentosEnMoraToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DocumentosEnMoraToolStripMenuItem.Text = "Documentos en mora "
        '
        'DocumentosPorPagarToolStripMenuItem
        '
        Me.DocumentosPorPagarToolStripMenuItem.Name = "DocumentosPorPagarToolStripMenuItem"
        Me.DocumentosPorPagarToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DocumentosPorPagarToolStripMenuItem.Text = "Documentos por pagar"
        '
        'DocumentosCanceladosToolStripMenuItem
        '
        Me.DocumentosCanceladosToolStripMenuItem.Name = "DocumentosCanceladosToolStripMenuItem"
        Me.DocumentosCanceladosToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DocumentosCanceladosToolStripMenuItem.Text = "Documentos cancelados"
        '
        'ReporteDeAntiguedadToolStripMenuItem
        '
        Me.ReporteDeAntiguedadToolStripMenuItem.Name = "ReporteDeAntiguedadToolStripMenuItem"
        Me.ReporteDeAntiguedadToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ReporteDeAntiguedadToolStripMenuItem.Text = "Reporte de antiguedad"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(45, 20)
        Me.SalirToolStripMenuItem1.Text = "salir"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.Transparent
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 38)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(617, 396)
        Me.PanelContenedor.TabIndex = 2
        '
        'MenuCuentasPorPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 434)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MenuCuentasPorPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "menu_cuentas_por_pagar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CuentasPorPagarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DocumentosEnMoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentosPorPagarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentosCanceladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeAntiguedadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
End Class
