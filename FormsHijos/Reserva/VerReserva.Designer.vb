<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerReserva))
        Me.nombreApellido = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.Label()
        Me.fechaV = New System.Windows.Forms.Label()
        Me.mascotas = New System.Windows.Forms.Label()
        Me.servicios = New System.Windows.Forms.Label()
        Me.reserva = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.final = New System.Windows.Forms.Label()
        Me.dogtv = New System.Windows.Forms.Label()
        Me.webcam = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.metodo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.celular = New System.Windows.Forms.Label()
        Me.reservado = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator7 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator8 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator9 = New Bunifu.Framework.UI.BunifuSeparator()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombreApellido
        '
        Me.nombreApellido.AutoSize = True
        Me.nombreApellido.BackColor = System.Drawing.Color.Transparent
        Me.nombreApellido.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.nombreApellido.Location = New System.Drawing.Point(113, 268)
        Me.nombreApellido.Name = "nombreApellido"
        Me.nombreApellido.Size = New System.Drawing.Size(136, 23)
        Me.nombreApellido.TabIndex = 41
        Me.nombreApellido.Text = "Fabrizio Bravo"
        '
        'direccion
        '
        Me.direccion.AutoSize = True
        Me.direccion.BackColor = System.Drawing.Color.Transparent
        Me.direccion.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.direccion.Location = New System.Drawing.Point(113, 296)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(138, 23)
        Me.direccion.TabIndex = 42
        Me.direccion.Text = "Avenida Millan"
        '
        'fechaV
        '
        Me.fechaV.AutoSize = True
        Me.fechaV.BackColor = System.Drawing.Color.Transparent
        Me.fechaV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.fechaV.Location = New System.Drawing.Point(685, 128)
        Me.fechaV.Name = "fechaV"
        Me.fechaV.Size = New System.Drawing.Size(140, 18)
        Me.fechaV.TabIndex = 43
        Me.fechaV.Text = "Fecha: 2000/01/06"
        '
        'mascotas
        '
        Me.mascotas.AutoSize = True
        Me.mascotas.BackColor = System.Drawing.Color.Transparent
        Me.mascotas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mascotas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.mascotas.Location = New System.Drawing.Point(134, 499)
        Me.mascotas.Name = "mascotas"
        Me.mascotas.Size = New System.Drawing.Size(96, 18)
        Me.mascotas.TabIndex = 44
        Me.mascotas.Text = "x3 Mascotas"
        '
        'servicios
        '
        Me.servicios.AutoSize = True
        Me.servicios.BackColor = System.Drawing.Color.Transparent
        Me.servicios.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.servicios.Location = New System.Drawing.Point(88, 518)
        Me.servicios.Name = "servicios"
        Me.servicios.Size = New System.Drawing.Size(178, 18)
        Me.servicios.TabIndex = 47
        Me.servicios.Text = "Servicios Extra: Ninguno"
        '
        'reserva
        '
        Me.reserva.AutoSize = True
        Me.reserva.BackColor = System.Drawing.Color.Transparent
        Me.reserva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reserva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.reserva.Location = New System.Drawing.Point(549, 128)
        Me.reserva.Name = "reserva"
        Me.reserva.Size = New System.Drawing.Size(26, 18)
        Me.reserva.TabIndex = 48
        Me.reserva.Text = "#1"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 120
        Me.BunifuSeparator1.Location = New System.Drawing.Point(519, 89)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(323, 36)
        Me.BunifuSeparator1.TabIndex = 50
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(529, 95)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(77, 20)
        Me.BunifuCustomLabel1.TabIndex = 51
        Me.BunifuCustomLabel1.Text = "Reserva #"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(742, 95)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(47, 20)
        Me.BunifuCustomLabel2.TabIndex = 52
        Me.BunifuCustomLabel2.Text = "Fecha"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 120
        Me.BunifuSeparator2.Location = New System.Drawing.Point(512, 234)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(330, 36)
        Me.BunifuSeparator2.TabIndex = 53
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(735, 241)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(57, 20)
        Me.BunifuCustomLabel3.TabIndex = 55
        Me.BunifuCustomLabel3.Text = "Metodo"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(527, 241)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(55, 20)
        Me.BunifuCustomLabel4.TabIndex = 54
        Me.BunifuCustomLabel4.Text = "Cliente"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 120
        Me.BunifuSeparator3.Location = New System.Drawing.Point(28, 461)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(330, 36)
        Me.BunifuSeparator3.TabIndex = 56
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(134, 465)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(117, 26)
        Me.BunifuCustomLabel6.TabIndex = 57
        Me.BunifuCustomLabel6.Text = "Informacion"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(134, 234)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(62, 26)
        Me.BunifuCustomLabel5.TabIndex = 59
        Me.BunifuCustomLabel5.Text = "Datos"
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 120
        Me.BunifuSeparator4.Location = New System.Drawing.Point(28, 230)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(330, 36)
        Me.BunifuSeparator4.TabIndex = 58
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 120
        Me.BunifuSeparator5.Location = New System.Drawing.Point(512, 461)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(330, 36)
        Me.BunifuSeparator5.TabIndex = 60
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(661, 465)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(55, 26)
        Me.BunifuCustomLabel7.TabIndex = 61
        Me.BunifuCustomLabel7.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Direccion:"
        '
        'pbLogoEmpresa
        '
        Me.pbLogoEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLogoEmpresa.BackColor = System.Drawing.Color.White
        Me.pbLogoEmpresa.Image = Global.ProyectoProgramacion.My.Resources.Resources.huella_logo
        Me.pbLogoEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbLogoEmpresa.Location = New System.Drawing.Point(-249, 34)
        Me.pbLogoEmpresa.Name = "pbLogoEmpresa"
        Me.pbLogoEmpresa.Size = New System.Drawing.Size(382, 190)
        Me.pbLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogoEmpresa.TabIndex = 40
        Me.pbLogoEmpresa.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(139, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 33)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Hotel Canino Guau"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(154, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 24)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "hotelguau@gmail.com"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(164, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 18)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Calle 8 y Atanasio Sierra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(603, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 70
        Me.Label3.Tag = ""
        Me.Label3.Text = "WebCam:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(603, 518)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 18)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "DogTV:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(603, 539)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 18)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Final:"
        '
        'final
        '
        Me.final.AutoSize = True
        Me.final.BackColor = System.Drawing.Color.Transparent
        Me.final.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.final.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.final.Location = New System.Drawing.Point(684, 539)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(17, 18)
        Me.final.TabIndex = 73
        Me.final.Text = "0"
        '
        'dogtv
        '
        Me.dogtv.AutoSize = True
        Me.dogtv.BackColor = System.Drawing.Color.Transparent
        Me.dogtv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dogtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dogtv.Location = New System.Drawing.Point(684, 518)
        Me.dogtv.Name = "dogtv"
        Me.dogtv.Size = New System.Drawing.Size(17, 18)
        Me.dogtv.TabIndex = 74
        Me.dogtv.Text = "0"
        '
        'webcam
        '
        Me.webcam.AutoSize = True
        Me.webcam.BackColor = System.Drawing.Color.Transparent
        Me.webcam.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webcam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.webcam.Location = New System.Drawing.Point(684, 500)
        Me.webcam.Name = "webcam"
        Me.webcam.Size = New System.Drawing.Size(17, 18)
        Me.webcam.TabIndex = 75
        Me.webcam.Text = "0"
        '
        'cliente
        '
        Me.cliente.AutoSize = True
        Me.cliente.BackColor = System.Drawing.Color.Transparent
        Me.cliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cliente.Location = New System.Drawing.Point(526, 283)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(80, 18)
        Me.cliente.TabIndex = 76
        Me.cliente.Text = "00000000"
        '
        'metodo
        '
        Me.metodo.AutoSize = True
        Me.metodo.BackColor = System.Drawing.Color.Transparent
        Me.metodo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.metodo.Location = New System.Drawing.Point(720, 283)
        Me.metodo.Name = "metodo"
        Me.metodo.Size = New System.Drawing.Size(110, 18)
        Me.metodo.TabIndex = 77
        Me.metodo.Text = "Tarjeta Credito"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(26, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Telefono:"
        '
        'celular
        '
        Me.celular.AutoSize = True
        Me.celular.BackColor = System.Drawing.Color.Transparent
        Me.celular.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.celular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.celular.Location = New System.Drawing.Point(113, 324)
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(109, 23)
        Me.celular.TabIndex = 79
        Me.celular.Text = "098987343"
        '
        'reservado
        '
        Me.reservado.AutoSize = True
        Me.reservado.BackColor = System.Drawing.Color.Transparent
        Me.reservado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.reservado.Location = New System.Drawing.Point(88, 539)
        Me.reservado.Name = "reservado"
        Me.reservado.Size = New System.Drawing.Size(154, 18)
        Me.reservado.TabIndex = 80
        Me.reservado.Text = "Reservado por: 1 dia"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Gray
        Me.IconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 21
        Me.IconPictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IconPictureBox1.Location = New System.Drawing.Point(852, 0)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(21, 23)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 38
        Me.IconPictureBox1.TabStop = False
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 120
        Me.BunifuSeparator6.Location = New System.Drawing.Point(-2, 0)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(877, 10)
        Me.BunifuSeparator6.TabIndex = 81
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'BunifuSeparator7
        '
        Me.BunifuSeparator7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator7.LineThickness = 120
        Me.BunifuSeparator7.Location = New System.Drawing.Point(865, -3)
        Me.BunifuSeparator7.Name = "BunifuSeparator7"
        Me.BunifuSeparator7.Size = New System.Drawing.Size(10, 590)
        Me.BunifuSeparator7.TabIndex = 82
        Me.BunifuSeparator7.Transparency = 255
        Me.BunifuSeparator7.Vertical = True
        '
        'BunifuSeparator8
        '
        Me.BunifuSeparator8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator8.LineThickness = 120
        Me.BunifuSeparator8.Location = New System.Drawing.Point(-2, 573)
        Me.BunifuSeparator8.Name = "BunifuSeparator8"
        Me.BunifuSeparator8.Size = New System.Drawing.Size(877, 10)
        Me.BunifuSeparator8.TabIndex = 83
        Me.BunifuSeparator8.Transparency = 255
        Me.BunifuSeparator8.Vertical = False
        '
        'BunifuSeparator9
        '
        Me.BunifuSeparator9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator9.LineThickness = 120
        Me.BunifuSeparator9.Location = New System.Drawing.Point(-2, -5)
        Me.BunifuSeparator9.Name = "BunifuSeparator9"
        Me.BunifuSeparator9.Size = New System.Drawing.Size(10, 590)
        Me.BunifuSeparator9.TabIndex = 84
        Me.BunifuSeparator9.Transparency = 255
        Me.BunifuSeparator9.Vertical = True
        '
        'VerReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(873, 581)
        Me.Controls.Add(Me.BunifuSeparator9)
        Me.Controls.Add(Me.BunifuSeparator8)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.BunifuSeparator7)
        Me.Controls.Add(Me.BunifuSeparator6)
        Me.Controls.Add(Me.reservado)
        Me.Controls.Add(Me.celular)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.metodo)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.webcam)
        Me.Controls.Add(Me.dogtv)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuSeparator5)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuSeparator4)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.reserva)
        Me.Controls.Add(Me.servicios)
        Me.Controls.Add(Me.mascotas)
        Me.Controls.Add(Me.fechaV)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.nombreApellido)
        Me.Controls.Add(Me.pbLogoEmpresa)
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerReserva"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLogoEmpresa As PictureBox
    Friend WithEvents nombreApellido As Label
    Friend WithEvents direccion As Label
    Friend WithEvents fechaV As Label
    Friend WithEvents mascotas As Label
    Friend WithEvents servicios As Label
    Friend WithEvents reserva As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents final As Label
    Friend WithEvents dogtv As Label
    Friend WithEvents webcam As Label
    Friend WithEvents cliente As Label
    Friend WithEvents metodo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents celular As Label
    Friend WithEvents reservado As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator7 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator8 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator9 As Bunifu.Framework.UI.BunifuSeparator
End Class
