<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Camara))
        Me.WebCam1 = New WebCAM.WebCam()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelImagen = New System.Windows.Forms.Panel()
        Me.PicFoto = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.cmdcamara = New System.Windows.Forms.Button()
        Me.btnGuardarFotoBase = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.PanelCamara = New System.Windows.Forms.Panel()
        Me.picPrev = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelarFoto = New System.Windows.Forms.Button()
        Me.cmdCapturar = New System.Windows.Forms.Button()
        Me.PanelImagen.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCamara.SuspendLayout()
        CType(Me.picPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebCam1
        '
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(23, 44)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(291, 141)
        Me.WebCam1.TabIndex = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(18, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 192
        Me.Label3.Text = "Actualizar imagen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "Fotografia actual:"
        '
        'PanelImagen
        '
        Me.PanelImagen.Controls.Add(Me.PicFoto)
        Me.PanelImagen.Controls.Add(Me.cmdcamara)
        Me.PanelImagen.Controls.Add(Me.btnGuardarFotoBase)
        Me.PanelImagen.Controls.Add(Me.Button4)
        Me.PanelImagen.Controls.Add(Me.Label2)
        Me.PanelImagen.Controls.Add(Me.Button1)
        Me.PanelImagen.Controls.Add(Me.cmdBorrar)
        Me.PanelImagen.Location = New System.Drawing.Point(23, 42)
        Me.PanelImagen.Name = "PanelImagen"
        Me.PanelImagen.Size = New System.Drawing.Size(364, 292)
        Me.PanelImagen.TabIndex = 196
        '
        'PicFoto
        '
        Me.PicFoto.BackColor = System.Drawing.Color.DarkGray
        Me.PicFoto.Location = New System.Drawing.Point(16, 44)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(146, 146)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 195
        Me.PicFoto.TabStop = False
        '
        'cmdcamara
        '
        Me.cmdcamara.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdcamara.FlatAppearance.BorderSize = 0
        Me.cmdcamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdcamara.Image = Global.Disermo_Project.My.Resources.Resources.cmrCamara
        Me.cmdcamara.Location = New System.Drawing.Point(194, 117)
        Me.cmdcamara.Name = "cmdcamara"
        Me.cmdcamara.Size = New System.Drawing.Size(148, 35)
        Me.cmdcamara.TabIndex = 174
        Me.cmdcamara.Text = "Abrir camara"
        Me.cmdcamara.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdcamara.UseVisualStyleBackColor = False
        '
        'btnGuardarFotoBase
        '
        Me.btnGuardarFotoBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGuardarFotoBase.FlatAppearance.BorderSize = 0
        Me.btnGuardarFotoBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarFotoBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarFotoBase.ForeColor = System.Drawing.Color.White
        Me.btnGuardarFotoBase.Location = New System.Drawing.Point(243, 242)
        Me.btnGuardarFotoBase.Name = "btnGuardarFotoBase"
        Me.btnGuardarFotoBase.Size = New System.Drawing.Size(99, 35)
        Me.btnGuardarFotoBase.TabIndex = 178
        Me.btnGuardarFotoBase.Text = "Guardar"
        Me.btnGuardarFotoBase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGuardarFotoBase.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(168, 242)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 36)
        Me.Button4.TabIndex = 191
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Disermo_Project.My.Resources.Resources.cmrNueva
        Me.Button1.Location = New System.Drawing.Point(194, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 35)
        Me.Button1.TabIndex = 186
        Me.Button1.Text = "Elegir nueva"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.BackColor = System.Drawing.Color.Transparent
        Me.cmdBorrar.BackgroundImage = Global.Disermo_Project.My.Resources.Resources.cmrEliminar
        Me.cmdBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdBorrar.FlatAppearance.BorderSize = 0
        Me.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBorrar.Location = New System.Drawing.Point(76, 192)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(28, 34)
        Me.cmdBorrar.TabIndex = 176
        Me.cmdBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdBorrar.UseVisualStyleBackColor = False
        '
        'PanelCamara
        '
        Me.PanelCamara.Controls.Add(Me.picPrev)
        Me.PanelCamara.Controls.Add(Me.btnSig)
        Me.PanelCamara.Controls.Add(Me.Label1)
        Me.PanelCamara.Controls.Add(Me.btnCancelarFoto)
        Me.PanelCamara.Controls.Add(Me.WebCam1)
        Me.PanelCamara.Controls.Add(Me.cmdCapturar)
        Me.PanelCamara.Location = New System.Drawing.Point(450, 42)
        Me.PanelCamara.Name = "PanelCamara"
        Me.PanelCamara.Size = New System.Drawing.Size(364, 248)
        Me.PanelCamara.TabIndex = 197
        '
        'picPrev
        '
        Me.picPrev.BackColor = System.Drawing.Color.DarkGray
        Me.picPrev.Location = New System.Drawing.Point(270, 19)
        Me.picPrev.Name = "picPrev"
        Me.picPrev.Size = New System.Drawing.Size(70, 70)
        Me.picPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrev.TabIndex = 196
        Me.picPrev.TabStop = False
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSig.FlatAppearance.BorderSize = 0
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSig.ForeColor = System.Drawing.Color.White
        Me.btnSig.Location = New System.Drawing.Point(142, 191)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(76, 35)
        Me.btnSig.TabIndex = 197
        Me.btnSig.Text = "Continuar"
        Me.btnSig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Videocamara:"
        '
        'btnCancelarFoto
        '
        Me.btnCancelarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancelarFoto.FlatAppearance.BorderSize = 0
        Me.btnCancelarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarFoto.Location = New System.Drawing.Point(269, 191)
        Me.btnCancelarFoto.Name = "btnCancelarFoto"
        Me.btnCancelarFoto.Size = New System.Drawing.Size(71, 35)
        Me.btnCancelarFoto.TabIndex = 191
        Me.btnCancelarFoto.Text = "Cancelar"
        Me.btnCancelarFoto.UseVisualStyleBackColor = False
        '
        'cmdCapturar
        '
        Me.cmdCapturar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmdCapturar.FlatAppearance.BorderSize = 0
        Me.cmdCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCapturar.ForeColor = System.Drawing.Color.White
        Me.cmdCapturar.Image = Global.Disermo_Project.My.Resources.Resources.cmrFoto
        Me.cmdCapturar.Location = New System.Drawing.Point(23, 191)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.Size = New System.Drawing.Size(113, 35)
        Me.cmdCapturar.TabIndex = 175
        Me.cmdCapturar.Text = "   Capturar"
        Me.cmdCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCapturar.UseVisualStyleBackColor = False
        '
        'Camara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 346)
        Me.Controls.Add(Me.PanelCamara)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelImagen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Camara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar imagen"
        Me.PanelImagen.ResumeLayout(False)
        Me.PanelImagen.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCamara.ResumeLayout(False)
        Me.PanelCamara.PerformLayout()
        CType(Me.picPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardarFotoBase As System.Windows.Forms.Button
    Friend WithEvents cmdcamara As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdCapturar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebCam1 As WebCAM.WebCam
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelImagen As Panel
    Friend WithEvents PicFoto As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents PanelCamara As Panel
    Friend WithEvents btnCancelarFoto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSig As Button
    Friend WithEvents picPrev As PictureBoxAbouAmmar.صورة_دائرة
End Class
