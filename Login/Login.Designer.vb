﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.panelDebajo = New System.Windows.Forms.Panel()
        Me.panelBienvenido = New System.Windows.Forms.Panel()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ipbMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.ipbSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.panelPrincipal.SuspendLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelPrincipal
        '
        Me.panelPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.panelPrincipal.Controls.Add(Me.txtContraseña)
        Me.panelPrincipal.Controls.Add(Me.txtUsuario)
        Me.panelPrincipal.Controls.Add(Me.btnIniciar)
        Me.panelPrincipal.Controls.Add(Me.lblContraseña)
        Me.panelPrincipal.Controls.Add(Me.lblUsuario)
        Me.panelPrincipal.Controls.Add(Me.panelDebajo)
        Me.panelPrincipal.Controls.Add(Me.panelBienvenido)
        Me.panelPrincipal.Controls.Add(Me.lblBienvenido)
        Me.panelPrincipal.Location = New System.Drawing.Point(479, 38)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(282, 390)
        Me.panelPrincipal.TabIndex = 30
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtContraseña.Location = New System.Drawing.Point(48, 255)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(181, 24)
        Me.txtContraseña.TabIndex = 2
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(49, 137)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(181, 24)
        Me.txtUsuario.TabIndex = 1
        '
        'btnIniciar
        '
        Me.btnIniciar.ActiveBorderThickness = 1
        Me.btnIniciar.ActiveCornerRadius = 20
        Me.btnIniciar.ActiveFillColor = System.Drawing.SystemColors.Control
        Me.btnIniciar.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.btnIniciar.BackColor = System.Drawing.SystemColors.Control
        Me.btnIniciar.BackgroundImage = CType(resources.GetObject("btnIniciar.BackgroundImage"), System.Drawing.Image)
        Me.btnIniciar.ButtonText = "Ingresar"
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.IdleBorderThickness = 1
        Me.btnIniciar.IdleCornerRadius = 20
        Me.btnIniciar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.IdleForecolor = System.Drawing.SystemColors.Control
        Me.btnIniciar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnIniciar.Location = New System.Drawing.Point(49, 313)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(181, 41)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.TabStop = False
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblContraseña.Location = New System.Drawing.Point(44, 210)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(100, 20)
        Me.lblContraseña.TabIndex = 11
        Me.lblContraseña.Text = "Constraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(44, 98)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 10
        Me.lblUsuario.Text = "Usuario"
        '
        'panelDebajo
        '
        Me.panelDebajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.panelDebajo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelDebajo.Location = New System.Drawing.Point(0, 386)
        Me.panelDebajo.Name = "panelDebajo"
        Me.panelDebajo.Size = New System.Drawing.Size(282, 7)
        Me.panelDebajo.TabIndex = 4
        '
        'panelBienvenido
        '
        Me.panelBienvenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.panelBienvenido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelBienvenido.Location = New System.Drawing.Point(64, 56)
        Me.panelBienvenido.Name = "panelBienvenido"
        Me.panelBienvenido.Size = New System.Drawing.Size(150, 4)
        Me.panelBienvenido.TabIndex = 3
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblBienvenido.Location = New System.Drawing.Point(66, 24)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(144, 29)
        Me.lblBienvenido.TabIndex = 29
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "ThinButton"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.White
        Me.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.Location = New System.Drawing.Point(239, 281)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(192, 36)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.TabStop = False
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ipbMinimizar
        '
        Me.ipbMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ipbMinimizar.IconColor = System.Drawing.Color.White
        Me.ipbMinimizar.IconSize = 34
        Me.ipbMinimizar.Location = New System.Drawing.Point(769, -1)
        Me.ipbMinimizar.Name = "ipbMinimizar"
        Me.ipbMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.ipbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ipbMinimizar.TabIndex = 5
        Me.ipbMinimizar.TabStop = False
        '
        'ipbSalir
        '
        Me.ipbSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ipbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ipbSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.ipbSalir.IconColor = System.Drawing.Color.White
        Me.ipbSalir.IconSize = 34
        Me.ipbSalir.Location = New System.Drawing.Point(795, -1)
        Me.ipbSalir.Name = "ipbSalir"
        Me.ipbSalir.Size = New System.Drawing.Size(32, 32)
        Me.ipbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ipbSalir.TabIndex = 4
        Me.ipbSalir.TabStop = False
        '
        'pcbImagen
        '
        Me.pcbImagen.Image = Global.ProyectoProgramacion.My.Resources.Resources.Diseno_Login
        Me.pcbImagen.Location = New System.Drawing.Point(-2, 0)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(831, 471)
        Me.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagen.TabIndex = 1
        Me.pcbImagen.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 469)
        Me.Controls.Add(Me.ipbMinimizar)
        Me.Controls.Add(Me.ipbSalir)
        Me.Controls.Add(Me.panelPrincipal)
        Me.Controls.Add(Me.pcbImagen)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Canino"
        Me.panelPrincipal.ResumeLayout(False)
        Me.panelPrincipal.PerformLayout()
        CType(Me.ipbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbImagen As PictureBox
    Friend WithEvents panelPrincipal As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents panelDebajo As Panel
    Friend WithEvents panelBienvenido As Panel
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents ipbMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ipbSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnIniciar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
End Class
