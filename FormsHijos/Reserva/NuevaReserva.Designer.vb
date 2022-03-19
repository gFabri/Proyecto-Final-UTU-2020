<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaReserva
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaReserva))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.fechaTerminacion = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.cantidadmascotas = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.fechainicio = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.metodoDePago = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clientes = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvMascotas = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vacunas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebCam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogTV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoAgregar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Transportes = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Borrar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.IDM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MascotaDGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvTransportes = New System.Windows.Forms.DataGridView()
        Me.Mascota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.agregarMascota = New System.Windows.Forms.Button()
        Me.registrar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.Color.White
        Me.lblDatosCliente.Location = New System.Drawing.Point(503, 8)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(219, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Añadir Nueva Reserva"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNacimiento.Location = New System.Drawing.Point(878, 52)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(163, 20)
        Me.lblNacimiento.TabIndex = 72
        Me.lblNacimiento.Text = "Fecha de Finalización"
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
        Me.Panel3.Size = New System.Drawing.Size(1260, 42)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1223, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.TabStop = False
        '
        'fechaTerminacion
        '
        Me.fechaTerminacion.BackColor = System.Drawing.Color.White
        Me.fechaTerminacion.BorderRadius = 2
        Me.fechaTerminacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.fechaTerminacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaTerminacion.FormatCustom = "yyyy/MM/dd HH:mm"
        Me.fechaTerminacion.Location = New System.Drawing.Point(872, 75)
        Me.fechaTerminacion.Name = "fechaTerminacion"
        Me.fechaTerminacion.Size = New System.Drawing.Size(199, 29)
        Me.fechaTerminacion.TabIndex = 5
        Me.fechaTerminacion.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'cantidadmascotas
        '
        Me.cantidadmascotas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cantidadmascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cantidadmascotas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.cantidadmascotas.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cantidadmascotas.HintText = "Ingrese Cantidad de Mascotas"
        Me.cantidadmascotas.isPassword = False
        Me.cantidadmascotas.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cantidadmascotas.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cantidadmascotas.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cantidadmascotas.LineThickness = 3
        Me.cantidadmascotas.Location = New System.Drawing.Point(225, 74)
        Me.cantidadmascotas.Margin = New System.Windows.Forms.Padding(4)
        Me.cantidadmascotas.Name = "cantidadmascotas"
        Me.cantidadmascotas.Size = New System.Drawing.Size(199, 29)
        Me.cantidadmascotas.TabIndex = 1
        Me.cantidadmascotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fechainicio
        '
        Me.fechainicio.BackColor = System.Drawing.Color.White
        Me.fechainicio.BorderRadius = 2
        Me.fechainicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechainicio.FormatCustom = "yyyy/MM/dd HH:mm"
        Me.fechainicio.Location = New System.Drawing.Point(652, 74)
        Me.fechainicio.Name = "fechainicio"
        Me.fechainicio.Size = New System.Drawing.Size(199, 29)
        Me.fechainicio.TabIndex = 100
        Me.fechainicio.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(654, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Fecha de Inicio"
        '
        'metodoDePago
        '
        Me.metodoDePago.BackColor = System.Drawing.Color.Transparent
        Me.metodoDePago.BorderRadius = 3
        Me.metodoDePago.ForeColor = System.Drawing.Color.White
        Me.metodoDePago.Items = New String() {"Contado", "Tarjeta de Credito"}
        Me.metodoDePago.Location = New System.Drawing.Point(442, 75)
        Me.metodoDePago.Name = "metodoDePago"
        Me.metodoDePago.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.metodoDePago.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.metodoDePago.selectedIndex = 0
        Me.metodoDePago.Size = New System.Drawing.Size(199, 29)
        Me.metodoDePago.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(440, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Método de Pago"
        '
        'clientes
        '
        Me.clientes.BackColor = System.Drawing.Color.Transparent
        Me.clientes.BorderRadius = 3
        Me.clientes.Font = New System.Drawing.Font("Impact", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.ForeColor = System.Drawing.Color.White
        Me.clientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.clientes.Items = New String(-1) {}
        Me.clientes.Location = New System.Drawing.Point(12, 74)
        Me.clientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.clientes.Name = "clientes"
        Me.clientes.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.clientes.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.clientes.selectedIndex = -1
        Me.clientes.Size = New System.Drawing.Size(206, 29)
        Me.clientes.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(11, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Elegir Cliente"
        '
        'dgvMascotas
        '
        Me.dgvMascotas.AllowUserToAddRows = False
        Me.dgvMascotas.AllowUserToDeleteRows = False
        Me.dgvMascotas.AllowUserToResizeColumns = False
        Me.dgvMascotas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvMascotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMascotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMascotas.BackgroundColor = System.Drawing.Color.White
        Me.dgvMascotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMascotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvMascotas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvMascotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMascotas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMascotas.ColumnHeadersHeight = 27
        Me.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMascotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.FechaNac, Me.Vacunas, Me.Comida, Me.Peso, Me.Raza, Me.Sexo, Me.Habitacion, Me.WebCam, Me.DogTV, Me.MedicamentoAgregar, Me.Transportes, Me.Borrar})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMascotas.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMascotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMascotas.EnableHeadersVisualStyles = False
        Me.dgvMascotas.GridColor = System.Drawing.Color.White
        Me.dgvMascotas.Location = New System.Drawing.Point(18, 136)
        Me.dgvMascotas.MultiSelect = False
        Me.dgvMascotas.Name = "dgvMascotas"
        Me.dgvMascotas.ReadOnly = True
        Me.dgvMascotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMascotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvMascotas.RowHeadersVisible = False
        Me.dgvMascotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvMascotas.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvMascotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMascotas.ShowEditingIcon = False
        Me.dgvMascotas.Size = New System.Drawing.Size(813, 323)
        Me.dgvMascotas.TabIndex = 111
        Me.dgvMascotas.TabStop = False
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 44
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Nombre.Width = 81
        '
        'FechaNac
        '
        Me.FechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FechaNac.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaNac.HeaderText = "Fecha Nac"
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.ReadOnly = True
        Me.FechaNac.Width = 98
        '
        'Vacunas
        '
        Me.Vacunas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Vacunas.DefaultCellStyle = DataGridViewCellStyle5
        Me.Vacunas.HeaderText = "Vacunas"
        Me.Vacunas.Name = "Vacunas"
        Me.Vacunas.ReadOnly = True
        Me.Vacunas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Vacunas.Width = 84
        '
        'Comida
        '
        Me.Comida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Comida.DefaultCellStyle = DataGridViewCellStyle6
        Me.Comida.HeaderText = "Comida"
        Me.Comida.Name = "Comida"
        Me.Comida.ReadOnly = True
        Me.Comida.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Comida.Width = 79
        '
        'Peso
        '
        Me.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle7
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        Me.Peso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Peso.Width = 62
        '
        'Raza
        '
        Me.Raza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Raza.DefaultCellStyle = DataGridViewCellStyle8
        Me.Raza.HeaderText = "Raza"
        Me.Raza.Name = "Raza"
        Me.Raza.ReadOnly = True
        Me.Raza.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Raza.Width = 63
        '
        'Sexo
        '
        Me.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        Me.Sexo.Width = 62
        '
        'Habitacion
        '
        Me.Habitacion.HeaderText = "Habitacion"
        Me.Habitacion.Name = "Habitacion"
        Me.Habitacion.ReadOnly = True
        '
        'WebCam
        '
        Me.WebCam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.WebCam.HeaderText = "WebCam"
        Me.WebCam.Name = "WebCam"
        Me.WebCam.ReadOnly = True
        Me.WebCam.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WebCam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.WebCam.Visible = False
        Me.WebCam.Width = 70
        '
        'DogTV
        '
        Me.DogTV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DogTV.HeaderText = "DogTV"
        Me.DogTV.Name = "DogTV"
        Me.DogTV.ReadOnly = True
        Me.DogTV.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DogTV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DogTV.Visible = False
        Me.DogTV.Width = 55
        '
        'MedicamentoAgregar
        '
        Me.MedicamentoAgregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MedicamentoAgregar.HeaderText = ""
        Me.MedicamentoAgregar.Image = Global.ProyectoProgramacion.My.Resources.Resources.medicamento
        Me.MedicamentoAgregar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.MedicamentoAgregar.Name = "MedicamentoAgregar"
        Me.MedicamentoAgregar.ReadOnly = True
        Me.MedicamentoAgregar.Width = 5
        '
        'Transportes
        '
        Me.Transportes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Transportes.HeaderText = ""
        Me.Transportes.Image = Global.ProyectoProgramacion.My.Resources.Resources.transporte
        Me.Transportes.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Transportes.Name = "Transportes"
        Me.Transportes.ReadOnly = True
        Me.Transportes.Width = 5
        '
        'Borrar
        '
        Me.Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Borrar.HeaderText = ""
        Me.Borrar.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Borrar.Name = "Borrar"
        Me.Borrar.ReadOnly = True
        Me.Borrar.Width = 5
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToAddRows = False
        Me.dgvMedicamentos.AllowUserToDeleteRows = False
        Me.dgvMedicamentos.AllowUserToResizeColumns = False
        Me.dgvMedicamentos.AllowUserToResizeRows = False
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvMedicamentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvMedicamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMedicamentos.BackgroundColor = System.Drawing.Color.White
        Me.dgvMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMedicamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvMedicamentos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvMedicamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMedicamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvMedicamentos.ColumnHeadersHeight = 27
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDM, Me.MascotaDGV, Me.Medicamento, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Eliminar})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedicamentos.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvMedicamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMedicamentos.EnableHeadersVisualStyles = False
        Me.dgvMedicamentos.GridColor = System.Drawing.Color.White
        Me.dgvMedicamentos.Location = New System.Drawing.Point(851, 136)
        Me.dgvMedicamentos.MultiSelect = False
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.ReadOnly = True
        Me.dgvMedicamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMedicamentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvMedicamentos.RowHeadersVisible = False
        Me.dgvMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvMedicamentos.RowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvMedicamentos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMedicamentos.ShowEditingIcon = False
        Me.dgvMedicamentos.Size = New System.Drawing.Size(397, 323)
        Me.dgvMedicamentos.TabIndex = 122
        Me.dgvMedicamentos.TabStop = False
        '
        'IDM
        '
        Me.IDM.HeaderText = "IDM"
        Me.IDM.Name = "IDM"
        Me.IDM.ReadOnly = True
        Me.IDM.Visible = False
        '
        'MascotaDGV
        '
        Me.MascotaDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MascotaDGV.DefaultCellStyle = DataGridViewCellStyle14
        Me.MascotaDGV.HeaderText = "Mascota"
        Me.MascotaDGV.Name = "MascotaDGV"
        Me.MascotaDGV.ReadOnly = True
        Me.MascotaDGV.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MascotaDGV.Width = 84
        '
        'Medicamento
        '
        Me.Medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Medicamento.HeaderText = "Medicamento"
        Me.Medicamento.Name = "Medicamento"
        Me.Medicamento.ReadOnly = True
        Me.Medicamento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Medicamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Medicamento.Width = 98
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dosis"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 66
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Horario"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 78
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(849, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Medicamentos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(20, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Mascotas"
        '
        'dgvTransportes
        '
        Me.dgvTransportes.AllowUserToAddRows = False
        Me.dgvTransportes.AllowUserToDeleteRows = False
        Me.dgvTransportes.AllowUserToResizeColumns = False
        Me.dgvTransportes.AllowUserToResizeRows = False
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvTransportes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvTransportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransportes.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransportes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvTransportes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvTransportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransportes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvTransportes.ColumnHeadersHeight = 27
        Me.dgvTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTransportes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mascota, Me.Vehiculo, Me.Fecha, Me.Horario, Me.Tipo, Me.Direccion, Me.DataGridViewImageColumn5})
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransportes.DefaultCellStyle = DataGridViewCellStyle26
        Me.dgvTransportes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransportes.EnableHeadersVisualStyles = False
        Me.dgvTransportes.GridColor = System.Drawing.Color.White
        Me.dgvTransportes.Location = New System.Drawing.Point(12, 482)
        Me.dgvTransportes.MultiSelect = False
        Me.dgvTransportes.Name = "dgvTransportes"
        Me.dgvTransportes.ReadOnly = True
        Me.dgvTransportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransportes.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvTransportes.RowHeadersVisible = False
        Me.dgvTransportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvTransportes.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvTransportes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvTransportes.ShowEditingIcon = False
        Me.dgvTransportes.Size = New System.Drawing.Size(609, 115)
        Me.dgvTransportes.TabIndex = 127
        Me.dgvTransportes.TabStop = False
        '
        'Mascota
        '
        Me.Mascota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Mascota.DefaultCellStyle = DataGridViewCellStyle20
        Me.Mascota.HeaderText = "Mascota"
        Me.Mascota.Name = "Mascota"
        Me.Mascota.ReadOnly = True
        Me.Mascota.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mascota.Width = 84
        '
        'Vehiculo
        '
        Me.Vehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Vehiculo.DefaultCellStyle = DataGridViewCellStyle21
        Me.Vehiculo.HeaderText = "Vehiculo"
        Me.Vehiculo.Name = "Vehiculo"
        Me.Vehiculo.ReadOnly = True
        Me.Vehiculo.Width = 85
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle22
        Me.Fecha.HeaderText = "Fecha De Transporte"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.Width = 164
        '
        'Horario
        '
        Me.Horario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Horario.DefaultCellStyle = DataGridViewCellStyle23
        Me.Horario.HeaderText = "Horario"
        Me.Horario.Name = "Horario"
        Me.Horario.ReadOnly = True
        Me.Horario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Horario.Width = 78
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Tipo.DefaultCellStyle = DataGridViewCellStyle24
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tipo.Width = 58
        '
        'Direccion
        '
        Me.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Direccion.DefaultCellStyle = DataGridViewCellStyle25
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Direccion.Width = 91
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewImageColumn5.HeaderText = ""
        Me.DataGridViewImageColumn5.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.ReadOnly = True
        Me.DataGridViewImageColumn5.Width = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 462)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Transportes"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle29.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewImageColumn1.HeaderText = "Modificar"
        Me.DataGridViewImageColumn1.Image = Global.ProyectoProgramacion.My.Resources.Resources.editar
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle30.NullValue = Nothing
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewImageColumn2.HeaderText = "Dar de baja"
        Me.DataGridViewImageColumn2.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle31.NullValue = Nothing
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewImageColumn3.HeaderText = "Ver Mascotas"
        Me.DataGridViewImageColumn3.Image = Global.ProyectoProgramacion.My.Resources.Resources.huella
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn4.HeaderText = ""
        Me.DataGridViewImageColumn4.Image = Global.ProyectoProgramacion.My.Resources.Resources.eliminar
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'agregarMascota
        '
        Me.agregarMascota.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agregarMascota.BackColor = System.Drawing.Color.White
        Me.agregarMascota.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.agregarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarMascota.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.agregarMascota.Image = Global.ProyectoProgramacion.My.Resources.Resources.huella
        Me.agregarMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregarMascota.Location = New System.Drawing.Point(1115, 47)
        Me.agregarMascota.Name = "agregarMascota"
        Me.agregarMascota.Size = New System.Drawing.Size(140, 32)
        Me.agregarMascota.TabIndex = 126
        Me.agregarMascota.TabStop = False
        Me.agregarMascota.Text = "Agregar Mascota"
        Me.agregarMascota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.agregarMascota.UseVisualStyleBackColor = False
        '
        'registrar
        '
        Me.registrar.ActiveBorderThickness = 1
        Me.registrar.ActiveCornerRadius = 20
        Me.registrar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.registrar.ActiveForecolor = System.Drawing.Color.White
        Me.registrar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.registrar.BackColor = System.Drawing.Color.White
        Me.registrar.BackgroundImage = CType(resources.GetObject("registrar.BackgroundImage"), System.Drawing.Image)
        Me.registrar.ButtonText = "Registrar"
        Me.registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.registrar.IdleBorderThickness = 1
        Me.registrar.IdleCornerRadius = 30
        Me.registrar.IdleFillColor = System.Drawing.Color.White
        Me.registrar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.registrar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.registrar.Location = New System.Drawing.Point(963, 548)
        Me.registrar.Margin = New System.Windows.Forms.Padding(5)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(192, 49)
        Me.registrar.TabIndex = 97
        Me.registrar.TabStop = False
        Me.registrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnSalir.Location = New System.Drawing.Point(1228, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 32)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 94
        Me.btnSalir.TabStop = False
        '
        'NuevaReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1260, 611)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvTransportes)
        Me.Controls.Add(Me.agregarMascota)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMedicamentos)
        Me.Controls.Add(Me.dgvMascotas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.metodoDePago)
        Me.Controls.Add(Me.fechainicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cantidadmascotas)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.fechaTerminacion)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblNacimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevaReserva"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents fechaTerminacion As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents registrar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cantidadmascotas As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents fechainicio As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label2 As Label
    Friend WithEvents metodoDePago As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label3 As Label
    Friend WithEvents clientes As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label7 As Label
    Public WithEvents dgvMascotas As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Public WithEvents dgvMedicamentos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents agregarMascota As Button
    Public WithEvents dgvTransportes As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Mascota As DataGridViewTextBoxColumn
    Friend WithEvents Vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Horario As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaNac As DataGridViewTextBoxColumn
    Friend WithEvents Vacunas As DataGridViewTextBoxColumn
    Friend WithEvents Comida As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Raza As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Habitacion As DataGridViewTextBoxColumn
    Friend WithEvents WebCam As DataGridViewTextBoxColumn
    Friend WithEvents DogTV As DataGridViewTextBoxColumn
    Friend WithEvents MedicamentoAgregar As DataGridViewImageColumn
    Friend WithEvents Transportes As DataGridViewImageColumn
    Friend WithEvents Borrar As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents IDM As DataGridViewTextBoxColumn
    Friend WithEvents MascotaDGV As DataGridViewTextBoxColumn
    Friend WithEvents Medicamento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
