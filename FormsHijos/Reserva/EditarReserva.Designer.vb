<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarReserva
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarReserva))
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.fechaTerminacion = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.fechainicio = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.metodoDePago = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.editar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.cliente = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.lblDatosCliente.Location = New System.Drawing.Point(331, 9)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(146, 24)
        Me.lblDatosCliente.TabIndex = 65
        Me.lblDatosCliente.Text = "Editar Reserva"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNacimiento.Location = New System.Drawing.Point(650, 45)
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
        Me.Panel3.Size = New System.Drawing.Size(858, 42)
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
        Me.btnCerrar.Location = New System.Drawing.Point(821, 7)
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
        Me.fechaTerminacion.Location = New System.Drawing.Point(644, 68)
        Me.fechaTerminacion.Name = "fechaTerminacion"
        Me.fechaTerminacion.Size = New System.Drawing.Size(199, 29)
        Me.fechaTerminacion.TabIndex = 5
        Me.fechaTerminacion.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'fechainicio
        '
        Me.fechainicio.BackColor = System.Drawing.Color.White
        Me.fechainicio.BorderRadius = 2
        Me.fechainicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechainicio.FormatCustom = "yyyy/MM/dd HH:mm"
        Me.fechainicio.Location = New System.Drawing.Point(424, 67)
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
        Me.Label2.Location = New System.Drawing.Point(426, 45)
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
        Me.metodoDePago.Location = New System.Drawing.Point(221, 68)
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
        Me.Label3.Location = New System.Drawing.Point(219, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Método de Pago"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewImageColumn1.HeaderText = "Modificar"
        Me.DataGridViewImageColumn1.Image = Global.ProyectoProgramacion.My.Resources.Resources.editar
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewImageColumn3.DefaultCellStyle = DataGridViewCellStyle6
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
        'editar
        '
        Me.editar.ActiveBorderThickness = 1
        Me.editar.ActiveCornerRadius = 20
        Me.editar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.editar.ActiveForecolor = System.Drawing.Color.White
        Me.editar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.editar.BackColor = System.Drawing.Color.White
        Me.editar.BackgroundImage = CType(resources.GetObject("editar.BackgroundImage"), System.Drawing.Image)
        Me.editar.ButtonText = "Editar"
        Me.editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.editar.IdleBorderThickness = 1
        Me.editar.IdleCornerRadius = 30
        Me.editar.IdleFillColor = System.Drawing.Color.White
        Me.editar.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.editar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.editar.Location = New System.Drawing.Point(335, 126)
        Me.editar.Margin = New System.Windows.Forms.Padding(5)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(192, 49)
        Me.editar.TabIndex = 97
        Me.editar.TabStop = False
        Me.editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnSalir.Location = New System.Drawing.Point(826, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 32)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 94
        Me.btnSalir.TabStop = False
        '
        'cliente
        '
        Me.cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cliente.Enabled = False
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.cliente.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cliente.HintText = "Cliente"
        Me.cliente.isPassword = False
        Me.cliente.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cliente.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cliente.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cliente.LineThickness = 3
        Me.cliente.Location = New System.Drawing.Point(13, 67)
        Me.cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(199, 29)
        Me.cliente.TabIndex = 129
        Me.cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EditarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(858, 210)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.metodoDePago)
        Me.Controls.Add(Me.fechainicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.editar)
        Me.Controls.Add(Me.fechaTerminacion)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblNacimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarReserva"
        Me.ShowInTaskbar = False
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
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents fechaTerminacion As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents editar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents fechainicio As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label2 As Label
    Friend WithEvents metodoDePago As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents cliente As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
