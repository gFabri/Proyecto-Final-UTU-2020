<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservasConfirmadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservasConfirmadas))
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvConfirmadas = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebCam = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DogTv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Registradopor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.filtro = New Bunifu.Framework.UI.BunifuDropdown()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConfirmadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtBuscar.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.HintText = "Buscar"
        Me.txtBuscar.isPassword = False
        Me.txtBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtBuscar.LineThickness = 3
        Me.txtBuscar.Location = New System.Drawing.Point(48, 14)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(645, 40)
        Me.txtBuscar.TabIndex = 20
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ProyectoProgramacion.My.Resources.Resources.Buscar
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(12, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'dgvConfirmadas
        '
        Me.dgvConfirmadas.AllowUserToAddRows = False
        Me.dgvConfirmadas.AllowUserToDeleteRows = False
        Me.dgvConfirmadas.AllowUserToResizeColumns = False
        Me.dgvConfirmadas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvConfirmadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConfirmadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConfirmadas.BackgroundColor = System.Drawing.Color.White
        Me.dgvConfirmadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvConfirmadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvConfirmadas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvConfirmadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConfirmadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConfirmadas.ColumnHeadersHeight = 27
        Me.dgvConfirmadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvConfirmadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CI, Me.Nombre, Me.Apellido, Me.Direccion, Me.Telefono, Me.FechaNac, Me.MetodoPago, Me.WebCam, Me.DogTv, Me.Registradopor})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConfirmadas.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvConfirmadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvConfirmadas.EnableHeadersVisualStyles = False
        Me.dgvConfirmadas.GridColor = System.Drawing.Color.White
        Me.dgvConfirmadas.Location = New System.Drawing.Point(12, 73)
        Me.dgvConfirmadas.MultiSelect = False
        Me.dgvConfirmadas.Name = "dgvConfirmadas"
        Me.dgvConfirmadas.ReadOnly = True
        Me.dgvConfirmadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConfirmadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvConfirmadas.RowHeadersVisible = False
        Me.dgvConfirmadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvConfirmadas.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvConfirmadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvConfirmadas.ShowEditingIcon = False
        Me.dgvConfirmadas.Size = New System.Drawing.Size(836, 463)
        Me.dgvConfirmadas.TabIndex = 25
        Me.dgvConfirmadas.TabStop = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'CI
        '
        Me.CI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CI.DefaultCellStyle = DataGridViewCellStyle3
        Me.CI.HeaderText = "Cliente"
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        Me.CI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CI.Width = 79
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.Nombre.HeaderText = "Estado"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Nombre.Width = 80
        '
        'Apellido
        '
        Me.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Apellido.DefaultCellStyle = DataGridViewCellStyle5
        Me.Apellido.HeaderText = "Mascotas"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Apellido.Width = 98
        '
        'Direccion
        '
        Me.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Direccion.DefaultCellStyle = DataGridViewCellStyle6
        Me.Direccion.HeaderText = "Fecha registrada"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Direccion.Width = 149
        '
        'Telefono
        '
        Me.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Telefono.DefaultCellStyle = DataGridViewCellStyle7
        Me.Telefono.HeaderText = "Desde"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Telefono.Width = 77
        '
        'FechaNac
        '
        Me.FechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FechaNac.DefaultCellStyle = DataGridViewCellStyle8
        Me.FechaNac.HeaderText = "Hasta"
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.ReadOnly = True
        Me.FechaNac.Width = 72
        '
        'MetodoPago
        '
        Me.MetodoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MetodoPago.HeaderText = "Método de Pago"
        Me.MetodoPago.Name = "MetodoPago"
        Me.MetodoPago.ReadOnly = True
        Me.MetodoPago.Width = 146
        '
        'WebCam
        '
        Me.WebCam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.WebCam.HeaderText = "WebCam"
        Me.WebCam.Name = "WebCam"
        Me.WebCam.ReadOnly = True
        Me.WebCam.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WebCam.Width = 75
        '
        'DogTv
        '
        Me.DogTv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DogTv.HeaderText = "DogTv"
        Me.DogTv.Name = "DogTv"
        Me.DogTv.ReadOnly = True
        Me.DogTv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DogTv.Width = 59
        '
        'Registradopor
        '
        Me.Registradopor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Registradopor.HeaderText = "Registrado Por"
        Me.Registradopor.Name = "Registradopor"
        Me.Registradopor.ReadOnly = True
        Me.Registradopor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Registradopor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Registradopor.Width = 117
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(715, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Filtro"
        '
        'filtro
        '
        Me.filtro.BackColor = System.Drawing.Color.Transparent
        Me.filtro.BorderRadius = 3
        Me.filtro.ForeColor = System.Drawing.Color.White
        Me.filtro.Items = New String() {"Ninguno", "Ultimo Mes", "Fecha de Alquier MiniSuite"}
        Me.filtro.Location = New System.Drawing.Point(710, 25)
        Me.filtro.Name = "filtro"
        Me.filtro.NomalColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.filtro.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.filtro.selectedIndex = 0
        Me.filtro.Size = New System.Drawing.Size(138, 29)
        Me.filtro.TabIndex = 107
        '
        'ReservasConfirmadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(860, 548)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.dgvConfirmadas)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReservasConfirmadas"
        Me.ShowInTaskbar = False
        Me.Text = "Hotel Canino"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConfirmadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents dgvConfirmadas As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CI As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents FechaNac As DataGridViewTextBoxColumn
    Friend WithEvents MetodoPago As DataGridViewTextBoxColumn
    Friend WithEvents WebCam As DataGridViewCheckBoxColumn
    Friend WithEvents DogTv As DataGridViewCheckBoxColumn
    Friend WithEvents Registradopor As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents filtro As Bunifu.Framework.UI.BunifuDropdown
End Class
