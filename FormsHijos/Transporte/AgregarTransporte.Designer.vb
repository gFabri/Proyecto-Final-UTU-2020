<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarTransporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarTransporte))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.direccion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tipo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.fecha = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vehiculos = New Bunifu.Framework.UI.BunifuDropdown()
        Me.mascota = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.horarios = New Bunifu.Framework.UI.BunifuDropdown()
        Me.modificar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.Color.White
        Me.lblDatosCliente.Location = New System.Drawing.Point(282, 9)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(188, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Añadir Transportes"
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
        Me.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrar.IconSize = 34
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(716, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.TabStop = False
        '
        'direccion
        '
        Me.direccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.direccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.direccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.direccion.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.direccion.HintText = "Ingrese Dirección"
        Me.direccion.isPassword = False
        Me.direccion.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.direccion.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.direccion.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.direccion.LineThickness = 3
        Me.direccion.Location = New System.Drawing.Point(369, 62)
        Me.direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(169, 44)
        Me.direccion.TabIndex = 105
        Me.direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipo
        '
        Me.tipo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tipo.BackColor = System.Drawing.Color.Transparent
        Me.tipo.BorderRadius = 50
        Me.tipo.ForeColor = System.Drawing.Color.White
        Me.tipo.Items = New String() {"Lleva", "Trae"}
        Me.tipo.Location = New System.Drawing.Point(555, 85)
        Me.tipo.Name = "tipo"
        Me.tipo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.tipo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.tipo.selectedIndex = 0
        Me.tipo.Size = New System.Drawing.Size(173, 26)
        Me.tipo.TabIndex = 102
        '
        'fecha
        '
        Me.fecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fecha.BackColor = System.Drawing.Color.White
        Me.fecha.BorderRadius = 2
        Me.fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.FormatCustom = "yyyy/MM/dd"
        Me.fecha.Location = New System.Drawing.Point(185, 77)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(177, 29)
        Me.fecha.TabIndex = 98
        Me.fecha.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Vehículo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(555, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Tipo de Viaje"
        '
        'vehiculos
        '
        Me.vehiculos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vehiculos.BackColor = System.Drawing.Color.Transparent
        Me.vehiculos.BorderRadius = 50
        Me.vehiculos.ForeColor = System.Drawing.Color.White
        Me.vehiculos.Items = New String() {"1", "2"}
        Me.vehiculos.Location = New System.Drawing.Point(13, 77)
        Me.vehiculos.Name = "vehiculos"
        Me.vehiculos.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.vehiculos.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.vehiculos.selectedIndex = -1
        Me.vehiculos.Size = New System.Drawing.Size(174, 26)
        Me.vehiculos.TabIndex = 120
        '
        'mascota
        '
        Me.mascota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mascota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.mascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.mascota.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.mascota.HintText = "Ingrese la Mascota"
        Me.mascota.isPassword = False
        Me.mascota.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.mascota.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.mascota.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.mascota.LineThickness = 3
        Me.mascota.Location = New System.Drawing.Point(559, 118)
        Me.mascota.Margin = New System.Windows.Forms.Padding(4)
        Me.mascota.Name = "mascota"
        Me.mascota.Size = New System.Drawing.Size(169, 44)
        Me.mascota.TabIndex = 121
        Me.mascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mascota.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Horarios"
        '
        'horarios
        '
        Me.horarios.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.horarios.BackColor = System.Drawing.Color.Transparent
        Me.horarios.BorderRadius = 50
        Me.horarios.ForeColor = System.Drawing.Color.White
        Me.horarios.Items = New String() {"Mañana", "Tarde", "Noche"}
        Me.horarios.Location = New System.Drawing.Point(16, 134)
        Me.horarios.Name = "horarios"
        Me.horarios.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.horarios.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.horarios.selectedIndex = 0
        Me.horarios.Size = New System.Drawing.Size(173, 26)
        Me.horarios.TabIndex = 122
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
        Me.modificar.Location = New System.Drawing.Point(278, 177)
        Me.modificar.Margin = New System.Windows.Forms.Padding(5)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(192, 49)
        Me.modificar.TabIndex = 97
        Me.modificar.TabStop = False
        Me.modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnSalir.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.IconSize = 34
        Me.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalir.Location = New System.Drawing.Point(721, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 32)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 94
        Me.btnSalir.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(192, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 20)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Fecha de Transporte"
        '
        'AgregarTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 234)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.horarios)
        Me.Controls.Add(Me.mascota)
        Me.Controls.Add(Me.vehiculos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarTransporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents modificar As Bunifu.Framework.UI.BunifuThinButton2
    Public WithEvents direccion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents tipo As Bunifu.Framework.UI.BunifuDropdown
    Public WithEvents fecha As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents vehiculos As Bunifu.Framework.UI.BunifuDropdown
    Public WithEvents mascota As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Public WithEvents horarios As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label3 As Label
End Class
