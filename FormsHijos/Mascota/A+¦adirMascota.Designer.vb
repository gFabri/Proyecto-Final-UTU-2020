<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirMascota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AñadirMascota))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.modificar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.NombreMascota = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.vacunas = New Bunifu.Framework.UI.BunifuDropdown()
        Me.sexo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.fechaNac = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.comida = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.peso = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.raza = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tiposdehabitacion = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.habitaciones = New Bunifu.Framework.UI.BunifuDropdown()
        Me.serviciosExtra = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.webcam = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.dogtv = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.serviciosExtra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.Color.White
        Me.lblDatosCliente.Location = New System.Drawing.Point(282, 9)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(154, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Añadir Mascota"
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
        Me.modificar.Location = New System.Drawing.Point(286, 266)
        Me.modificar.Margin = New System.Windows.Forms.Padding(5)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(192, 49)
        Me.modificar.TabIndex = 97
        Me.modificar.TabStop = False
        Me.modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreMascota
        '
        Me.NombreMascota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NombreMascota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NombreMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.NombreMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.NombreMascota.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.HintText = "Nombre de la Mascota"
        Me.NombreMascota.isPassword = False
        Me.NombreMascota.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.NombreMascota.LineThickness = 3
        Me.NombreMascota.Location = New System.Drawing.Point(8, 62)
        Me.NombreMascota.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreMascota.Name = "NombreMascota"
        Me.NombreMascota.Size = New System.Drawing.Size(169, 44)
        Me.NombreMascota.TabIndex = 105
        Me.NombreMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vacunas
        '
        Me.vacunas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vacunas.BackColor = System.Drawing.Color.Transparent
        Me.vacunas.BorderRadius = 50
        Me.vacunas.ForeColor = System.Drawing.Color.White
        Me.vacunas.Items = New String() {"Si", "No"}
        Me.vacunas.Location = New System.Drawing.Point(368, 80)
        Me.vacunas.Name = "vacunas"
        Me.vacunas.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.vacunas.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.vacunas.selectedIndex = 0
        Me.vacunas.Size = New System.Drawing.Size(174, 26)
        Me.vacunas.TabIndex = 103
        '
        'sexo
        '
        Me.sexo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.sexo.BackColor = System.Drawing.Color.Transparent
        Me.sexo.BorderRadius = 50
        Me.sexo.ForeColor = System.Drawing.Color.White
        Me.sexo.Items = New String() {"Macho", "Henbra"}
        Me.sexo.Location = New System.Drawing.Point(369, 151)
        Me.sexo.Name = "sexo"
        Me.sexo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sexo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sexo.selectedIndex = 0
        Me.sexo.Size = New System.Drawing.Size(173, 26)
        Me.sexo.TabIndex = 102
        '
        'fechaNac
        '
        Me.fechaNac.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fechaNac.BackColor = System.Drawing.Color.White
        Me.fechaNac.BorderRadius = 2
        Me.fechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaNac.FormatCustom = "yyyy/MM/dd"
        Me.fechaNac.Location = New System.Drawing.Point(185, 77)
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.Size = New System.Drawing.Size(177, 29)
        Me.fechaNac.TabIndex = 98
        Me.fechaNac.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'comida
        '
        Me.comida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.comida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.comida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.comida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.comida.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.comida.HintText = "Comida Especifica"
        Me.comida.isPassword = False
        Me.comida.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.comida.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.comida.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.comida.LineThickness = 3
        Me.comida.Location = New System.Drawing.Point(551, 62)
        Me.comida.Margin = New System.Windows.Forms.Padding(4)
        Me.comida.Name = "comida"
        Me.comida.Size = New System.Drawing.Size(169, 44)
        Me.comida.TabIndex = 106
        Me.comida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'peso
        '
        Me.peso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.peso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.peso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.peso.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.peso.HintText = "Ingrese el Peso"
        Me.peso.isPassword = False
        Me.peso.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.peso.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.peso.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.peso.LineThickness = 3
        Me.peso.Location = New System.Drawing.Point(13, 133)
        Me.peso.Margin = New System.Windows.Forms.Padding(4)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(169, 44)
        Me.peso.TabIndex = 107
        Me.peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'raza
        '
        Me.raza.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.raza.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.raza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.raza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.raza.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.raza.HintText = "Ingrese la Raza"
        Me.raza.isPassword = False
        Me.raza.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.raza.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.raza.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.raza.LineThickness = 3
        Me.raza.Location = New System.Drawing.Point(193, 133)
        Me.raza.Margin = New System.Windows.Forms.Padding(4)
        Me.raza.Name = "raza"
        Me.raza.Size = New System.Drawing.Size(169, 44)
        Me.raza.TabIndex = 108
        Me.raza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(367, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Vacunas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(369, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Sexo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(543, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 20)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Elegir Tipo de Habitacion"
        '
        'tiposdehabitacion
        '
        Me.tiposdehabitacion.BackColor = System.Drawing.Color.Transparent
        Me.tiposdehabitacion.BorderRadius = 3
        Me.tiposdehabitacion.Font = New System.Drawing.Font("Impact", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiposdehabitacion.ForeColor = System.Drawing.Color.White
        Me.tiposdehabitacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tiposdehabitacion.Items = New String() {"Suite", "Junior Suite", "Mini Suite", "Estándar"}
        Me.tiposdehabitacion.Location = New System.Drawing.Point(547, 148)
        Me.tiposdehabitacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tiposdehabitacion.Name = "tiposdehabitacion"
        Me.tiposdehabitacion.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.tiposdehabitacion.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.tiposdehabitacion.selectedIndex = 0
        Me.tiposdehabitacion.Size = New System.Drawing.Size(206, 29)
        Me.tiposdehabitacion.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(282, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 20)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Elegir Habitacion"
        '
        'habitaciones
        '
        Me.habitaciones.BackColor = System.Drawing.Color.Transparent
        Me.habitaciones.BorderRadius = 3
        Me.habitaciones.Font = New System.Drawing.Font("Impact", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.habitaciones.ForeColor = System.Drawing.Color.White
        Me.habitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.habitaciones.Items = New String(-1) {}
        Me.habitaciones.Location = New System.Drawing.Point(282, 218)
        Me.habitaciones.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.habitaciones.Name = "habitaciones"
        Me.habitaciones.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.habitaciones.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.habitaciones.selectedIndex = -1
        Me.habitaciones.Size = New System.Drawing.Size(206, 29)
        Me.habitaciones.TabIndex = 116
        '
        'serviciosExtra
        '
        Me.serviciosExtra.Controls.Add(Me.Label5)
        Me.serviciosExtra.Controls.Add(Me.Label4)
        Me.serviciosExtra.Controls.Add(Me.webcam)
        Me.serviciosExtra.Controls.Add(Me.dogtv)
        Me.serviciosExtra.Controls.Add(Me.Label6)
        Me.serviciosExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, CType(0, Byte))
        Me.serviciosExtra.Location = New System.Drawing.Point(13, 258)
        Me.serviciosExtra.Name = "serviciosExtra"
        Me.serviciosExtra.Size = New System.Drawing.Size(200, 57)
        Me.serviciosExtra.TabIndex = 122
        Me.serviciosExtra.TabStop = False
        Me.serviciosExtra.Text = "GroupBox1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(122, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Webcam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(26, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "DogTV"
        '
        'webcam
        '
        Me.webcam.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.webcam.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.webcam.Checked = False
        Me.webcam.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.webcam.ForeColor = System.Drawing.Color.White
        Me.webcam.Location = New System.Drawing.Point(105, 34)
        Me.webcam.Margin = New System.Windows.Forms.Padding(0)
        Me.webcam.Name = "webcam"
        Me.webcam.Size = New System.Drawing.Size(20, 20)
        Me.webcam.TabIndex = 103
        '
        'dogtv
        '
        Me.dogtv.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.dogtv.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.dogtv.Checked = False
        Me.dogtv.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dogtv.ForeColor = System.Drawing.Color.White
        Me.dogtv.Location = New System.Drawing.Point(9, 34)
        Me.dogtv.Margin = New System.Windows.Forms.Padding(0)
        Me.dogtv.Name = "dogtv"
        Me.dogtv.Size = New System.Drawing.Size(20, 20)
        Me.dogtv.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(41, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Servicios Extras"
        '
        'AñadirMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 329)
        Me.Controls.Add(Me.serviciosExtra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tiposdehabitacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.habitaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.raza)
        Me.Controls.Add(Me.peso)
        Me.Controls.Add(Me.comida)
        Me.Controls.Add(Me.NombreMascota)
        Me.Controls.Add(Me.vacunas)
        Me.Controls.Add(Me.sexo)
        Me.Controls.Add(Me.fechaNac)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AñadirMascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.serviciosExtra.ResumeLayout(False)
        Me.serviciosExtra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents modificar As Bunifu.Framework.UI.BunifuThinButton2
    Public WithEvents NombreMascota As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents vacunas As Bunifu.Framework.UI.BunifuDropdown
    Public WithEvents sexo As Bunifu.Framework.UI.BunifuDropdown
    Public WithEvents fechaNac As Bunifu.Framework.UI.BunifuDatepicker
    Public WithEvents comida As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents peso As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents raza As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tiposdehabitacion As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label8 As Label
    Friend WithEvents habitaciones As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents serviciosExtra As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents webcam As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents dogtv As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label6 As Label
End Class
