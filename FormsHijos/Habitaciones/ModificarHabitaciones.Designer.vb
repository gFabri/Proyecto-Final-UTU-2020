<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarHabitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarHabitaciones))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.modificar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtPrecio = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAmount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.Color.White
        Me.lblDatosCliente.Location = New System.Drawing.Point(204, 9)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(200, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Modificar Habitación"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnSalir.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSalir.IconSize = 34
        Me.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalir.Location = New System.Drawing.Point(576, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 32)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 94
        Me.btnSalir.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Controls.Add(Me.lblDatosCliente)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(608, 42)
        Me.Panel3.TabIndex = 96
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCerrar.IconColor = System.Drawing.Color.White
        Me.btnCerrar.IconSize = 34
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(571, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.TabStop = False
        '
        'modificar
        '
        Me.modificar.ActiveBorderThickness = 1
        Me.modificar.ActiveCornerRadius = 20
        Me.modificar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.ActiveForecolor = System.Drawing.Color.White
        Me.modificar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.BackColor = System.Drawing.Color.White
        Me.modificar.BackgroundImage = CType(resources.GetObject("modificar.BackgroundImage"), System.Drawing.Image)
        Me.modificar.ButtonText = "Modificar"
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.modificar.IdleBorderThickness = 1
        Me.modificar.IdleCornerRadius = 30
        Me.modificar.IdleFillColor = System.Drawing.Color.White
        Me.modificar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.Location = New System.Drawing.Point(201, 145)
        Me.modificar.Margin = New System.Windows.Forms.Padding(5)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(192, 49)
        Me.modificar.TabIndex = 97
        Me.modificar.TabStop = False
        Me.modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio
        '
        Me.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtPrecio.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPrecio.HintText = "Ingrese Nuevo Precio"
        Me.txtPrecio.isPassword = False
        Me.txtPrecio.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPrecio.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPrecio.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPrecio.LineThickness = 3
        Me.txtPrecio.Location = New System.Drawing.Point(309, 77)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(286, 44)
        Me.txtPrecio.TabIndex = 4
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmount
        '
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.Enabled = False
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtAmount.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtAmount.HintText = "Ingrese Cantidad Mascotas"
        Me.txtAmount.isPassword = False
        Me.txtAmount.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtAmount.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtAmount.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtAmount.LineThickness = 3
        Me.txtAmount.Location = New System.Drawing.Point(13, 77)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(264, 44)
        Me.txtAmount.TabIndex = 98
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModificarHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(608, 208)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarHabitaciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents modificar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtPrecio As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtAmount As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
