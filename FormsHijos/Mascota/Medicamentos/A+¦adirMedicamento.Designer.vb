<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AñadirMedicamento))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.modificar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dosis = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.horario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.medicamento = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.lblDatosCliente.Location = New System.Drawing.Point(282, 9)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(203, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Añadir Medicamento"
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
        Me.btnSalir.Location = New System.Drawing.Point(721, 0)
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
        Me.Panel3.Size = New System.Drawing.Size(753, 42)
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
        Me.btnCerrar.Location = New System.Drawing.Point(716, 5)
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
        Me.modificar.ButtonText = "Agregar"
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.modificar.IdleBorderThickness = 1
        Me.modificar.IdleCornerRadius = 30
        Me.modificar.IdleFillColor = System.Drawing.Color.White
        Me.modificar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.modificar.Location = New System.Drawing.Point(286, 133)
        Me.modificar.Margin = New System.Windows.Forms.Padding(5)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(192, 49)
        Me.modificar.TabIndex = 97
        Me.modificar.TabStop = False
        Me.modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dosis
        '
        Me.dosis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dosis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dosis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dosis.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dosis.HintText = "Ingrese Dosis"
        Me.dosis.isPassword = False
        Me.dosis.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dosis.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dosis.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dosis.LineThickness = 3
        Me.dosis.Location = New System.Drawing.Point(373, 62)
        Me.dosis.Margin = New System.Windows.Forms.Padding(4)
        Me.dosis.Name = "dosis"
        Me.dosis.Size = New System.Drawing.Size(169, 44)
        Me.dosis.TabIndex = 106
        Me.dosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'horario
        '
        Me.horario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.horario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.horario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.horario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.horario.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.horario.HintText = "Ingrese Horario"
        Me.horario.isPassword = False
        Me.horario.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.horario.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.horario.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.horario.LineThickness = 3
        Me.horario.Location = New System.Drawing.Point(550, 62)
        Me.horario.Margin = New System.Windows.Forms.Padding(4)
        Me.horario.Name = "horario"
        Me.horario.Size = New System.Drawing.Size(169, 44)
        Me.horario.TabIndex = 107
        Me.horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'medicamento
        '
        Me.medicamento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.medicamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.medicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.medicamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.medicamento.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.medicamento.HintText = "Ingrese Medicamento"
        Me.medicamento.isPassword = False
        Me.medicamento.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.medicamento.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.medicamento.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.medicamento.LineThickness = 3
        Me.medicamento.Location = New System.Drawing.Point(194, 62)
        Me.medicamento.Margin = New System.Windows.Forms.Padding(4)
        Me.medicamento.Name = "medicamento"
        Me.medicamento.Size = New System.Drawing.Size(169, 44)
        Me.medicamento.TabIndex = 114
        Me.medicamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID
        '
        Me.ID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ID.Enabled = False
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ID.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ID.HintText = "Ingrese ID"
        Me.ID.isPassword = False
        Me.ID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ID.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ID.LineThickness = 3
        Me.ID.Location = New System.Drawing.Point(17, 62)
        Me.ID.Margin = New System.Windows.Forms.Padding(4)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(169, 44)
        Me.ID.TabIndex = 115
        Me.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AñadirMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 192)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.medicamento)
        Me.Controls.Add(Me.horario)
        Me.Controls.Add(Me.dosis)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AñadirMedicamento"
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
    Public WithEvents dosis As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents horario As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents medicamento As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents ID As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
