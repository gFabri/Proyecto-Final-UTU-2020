<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrevisualizarHabitacion
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
        Dim leftImage As FontAwesome.Sharp.IconPictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrevisualizarHabitacion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rightImage = New FontAwesome.Sharp.IconPictureBox()
        Me.gerenteSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.picture = New System.Windows.Forms.PictureBox()
        leftImage = New FontAwesome.Sharp.IconPictureBox()
        CType(leftImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.rightImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftImage
        '
        leftImage.BackColor = System.Drawing.Color.Transparent
        leftImage.Cursor = System.Windows.Forms.Cursors.Hand
        leftImage.ErrorImage = Nothing
        leftImage.IconChar = FontAwesome.Sharp.IconChar.CaretLeft
        leftImage.IconColor = System.Drawing.Color.White
        leftImage.Location = New System.Drawing.Point(0, 1)
        leftImage.Name = "leftImage"
        leftImage.Size = New System.Drawing.Size(32, 35)
        leftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        leftImage.TabIndex = 4
        leftImage.TabStop = False
        AddHandler leftImage.Click, AddressOf Me.left_Click
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(leftImage)
        Me.Panel1.Controls.Add(Me.rightImage)
        Me.Panel1.Controls.Add(Me.gerenteSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 36)
        Me.Panel1.TabIndex = 1
        '
        'rightImage
        '
        Me.rightImage.BackColor = System.Drawing.Color.Transparent
        Me.rightImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rightImage.ErrorImage = Nothing
        Me.rightImage.IconChar = FontAwesome.Sharp.IconChar.CaretRight
        Me.rightImage.IconColor = System.Drawing.Color.White
        Me.rightImage.IconSize = 34
        Me.rightImage.Location = New System.Drawing.Point(23, 1)
        Me.rightImage.Name = "rightImage"
        Me.rightImage.Size = New System.Drawing.Size(34, 36)
        Me.rightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rightImage.TabIndex = 3
        Me.rightImage.TabStop = False
        '
        'gerenteSalir
        '
        Me.gerenteSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gerenteSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gerenteSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gerenteSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.gerenteSalir.IconColor = System.Drawing.Color.White
        Me.gerenteSalir.IconSize = 34
        Me.gerenteSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gerenteSalir.Location = New System.Drawing.Point(822, 2)
        Me.gerenteSalir.Name = "gerenteSalir"
        Me.gerenteSalir.Size = New System.Drawing.Size(32, 32)
        Me.gerenteSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gerenteSalir.TabIndex = 9
        Me.gerenteSalir.TabStop = False
        '
        'picture
        '
        Me.picture.BackColor = System.Drawing.Color.Transparent
        Me.picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picture.Location = New System.Drawing.Point(0, 36)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(856, 530)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picture.TabIndex = 2
        Me.picture.TabStop = False
        '
        'PrevisualizarHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 566)
        Me.Controls.Add(Me.picture)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrevisualizarHabitacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(leftImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.rightImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picture As PictureBox
    Friend WithEvents gerenteSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents rightImage As FontAwesome.Sharp.IconPictureBox
End Class
