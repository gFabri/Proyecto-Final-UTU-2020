﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class General
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(General))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHSalida = New FontAwesome.Sharp.IconButton()
        Me.btnHEntrada = New FontAwesome.Sharp.IconButton()
        Me.btnReservas = New FontAwesome.Sharp.IconButton()
        Me.btnModificarPrecio = New FontAwesome.Sharp.IconButton()
        Me.btnGestion = New FontAwesome.Sharp.IconButton()
        Me.gestionClientes = New FontAwesome.Sharp.IconButton()
        Me.btnInicio = New FontAwesome.Sharp.IconButton()
        Me.txtNombreUsuario = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnCerarSesion = New FontAwesome.Sharp.IconButton()
        Me.picture = New System.Windows.Forms.PictureBox()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.edit = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nombre = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gerenteSalir = New FontAwesome.Sharp.IconPictureBox()
        Me.gerenteMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.phototrasparent = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.horayfecha = New System.Windows.Forms.Timer(Me.components)
        Me.PanelDesktop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.pbLogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picture.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.photo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gerenteMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.txtNombreUsuario)
        Me.PanelMenu.Controls.Add(Me.btnCerarSesion)
        Me.PanelMenu.Controls.Add(Me.picture)
        resources.ApplyResources(Me.PanelMenu, "PanelMenu")
        Me.PanelMenu.Name = "PanelMenu"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnHSalida)
        Me.Panel1.Controls.Add(Me.btnHEntrada)
        Me.Panel1.Controls.Add(Me.btnReservas)
        Me.Panel1.Controls.Add(Me.btnModificarPrecio)
        Me.Panel1.Controls.Add(Me.btnGestion)
        Me.Panel1.Controls.Add(Me.gestionClientes)
        Me.Panel1.Controls.Add(Me.btnInicio)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btnHSalida
        '
        Me.btnHSalida.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnHSalida, "btnHSalida")
        Me.btnHSalida.FlatAppearance.BorderSize = 0
        Me.btnHSalida.ForeColor = System.Drawing.Color.White
        Me.btnHSalida.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        Me.btnHSalida.IconColor = System.Drawing.Color.White
        Me.btnHSalida.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHSalida.IconSize = 32
        Me.btnHSalida.Name = "btnHSalida"
        Me.btnHSalida.TabStop = False
        Me.btnHSalida.UseVisualStyleBackColor = True
        '
        'btnHEntrada
        '
        Me.btnHEntrada.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnHEntrada, "btnHEntrada")
        Me.btnHEntrada.FlatAppearance.BorderSize = 0
        Me.btnHEntrada.ForeColor = System.Drawing.Color.White
        Me.btnHEntrada.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        Me.btnHEntrada.IconColor = System.Drawing.Color.White
        Me.btnHEntrada.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHEntrada.IconSize = 32
        Me.btnHEntrada.Name = "btnHEntrada"
        Me.btnHEntrada.TabStop = False
        Me.btnHEntrada.UseVisualStyleBackColor = True
        '
        'btnReservas
        '
        Me.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnReservas, "btnReservas")
        Me.btnReservas.FlatAppearance.BorderSize = 0
        Me.btnReservas.ForeColor = System.Drawing.Color.White
        Me.btnReservas.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnReservas.IconColor = System.Drawing.Color.White
        Me.btnReservas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReservas.IconSize = 32
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.TabStop = False
        Me.btnReservas.UseVisualStyleBackColor = True
        '
        'btnModificarPrecio
        '
        Me.btnModificarPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnModificarPrecio, "btnModificarPrecio")
        Me.btnModificarPrecio.FlatAppearance.BorderSize = 0
        Me.btnModificarPrecio.ForeColor = System.Drawing.Color.White
        Me.btnModificarPrecio.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnModificarPrecio.IconColor = System.Drawing.Color.White
        Me.btnModificarPrecio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnModificarPrecio.IconSize = 32
        Me.btnModificarPrecio.Name = "btnModificarPrecio"
        Me.btnModificarPrecio.TabStop = False
        Me.btnModificarPrecio.UseVisualStyleBackColor = True
        '
        'btnGestion
        '
        Me.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnGestion, "btnGestion")
        Me.btnGestion.FlatAppearance.BorderSize = 0
        Me.btnGestion.ForeColor = System.Drawing.Color.White
        Me.btnGestion.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btnGestion.IconColor = System.Drawing.Color.White
        Me.btnGestion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGestion.IconSize = 32
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.TabStop = False
        Me.btnGestion.UseVisualStyleBackColor = True
        '
        'gestionClientes
        '
        Me.gestionClientes.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.gestionClientes, "gestionClientes")
        Me.gestionClientes.FlatAppearance.BorderSize = 0
        Me.gestionClientes.ForeColor = System.Drawing.Color.White
        Me.gestionClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.gestionClientes.IconColor = System.Drawing.Color.White
        Me.gestionClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.gestionClientes.IconSize = 32
        Me.gestionClientes.Name = "gestionClientes"
        Me.gestionClientes.TabStop = False
        Me.gestionClientes.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnInicio, "btnInicio")
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnInicio.IconColor = System.Drawing.Color.White
        Me.btnInicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInicio.IconSize = 32
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.TabStop = False
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'txtNombreUsuario
        '
        resources.ApplyResources(Me.txtNombreUsuario, "txtNombreUsuario")
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        '
        'btnCerarSesion
        '
        resources.ApplyResources(Me.btnCerarSesion, "btnCerarSesion")
        Me.btnCerarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnCerarSesion.IconColor = System.Drawing.Color.White
        Me.btnCerarSesion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerarSesion.IconSize = 32
        Me.btnCerarSesion.Name = "btnCerarSesion"
        Me.btnCerarSesion.TabStop = False
        Me.btnCerarSesion.UseVisualStyleBackColor = True
        '
        'picture
        '
        Me.picture.Controls.Add(Me.photo)
        Me.picture.Image = Global.ProyectoProgramacion.My.Resources.Resources.imagenPrueba2
        resources.ApplyResources(Me.picture, "picture")
        Me.picture.Name = "picture"
        Me.picture.TabStop = False
        '
        'photo
        '
        Me.photo.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.photo.Controls.Add(Me.edit)
        resources.ApplyResources(Me.photo, "photo")
        Me.photo.Name = "photo"
        Me.photo.TabStop = False
        '
        'edit
        '
        resources.ApplyResources(Me.edit, "edit")
        Me.edit.BackColor = System.Drawing.Color.Transparent
        Me.edit.Name = "edit"
        '
        'nombre
        '
        resources.ApplyResources(Me.nombre, "nombre")
        Me.nombre.ForeColor = System.Drawing.Color.White
        Me.nombre.Name = "nombre"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.gerenteSalir)
        Me.Panel3.Controls.Add(Me.gerenteMinimizar)
        Me.Panel3.Controls.Add(Me.lblGeneral)
        Me.Panel3.Controls.Add(Me.IconCurrentForm)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'gerenteSalir
        '
        resources.ApplyResources(Me.gerenteSalir, "gerenteSalir")
        Me.gerenteSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gerenteSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gerenteSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.gerenteSalir.IconColor = System.Drawing.Color.White
        Me.gerenteSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.gerenteSalir.IconSize = 34
        Me.gerenteSalir.Name = "gerenteSalir"
        Me.gerenteSalir.TabStop = False
        '
        'gerenteMinimizar
        '
        resources.ApplyResources(Me.gerenteMinimizar, "gerenteMinimizar")
        Me.gerenteMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gerenteMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gerenteMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.gerenteMinimizar.IconColor = System.Drawing.Color.White
        Me.gerenteMinimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.gerenteMinimizar.IconSize = 34
        Me.gerenteMinimizar.Name = "gerenteMinimizar"
        Me.gerenteMinimizar.TabStop = False
        '
        'lblGeneral
        '
        resources.ApplyResources(Me.lblGeneral, "lblGeneral")
        Me.lblGeneral.ForeColor = System.Drawing.Color.Transparent
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.UseCompatibleTextRendering = True
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.White
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 35
        resources.ApplyResources(Me.IconCurrentForm, "IconCurrentForm")
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.TabStop = False
        '
        'phototrasparent
        '
        Me.phototrasparent.ElipseRadius = 175
        Me.phototrasparent.TargetControl = Me.picture
        '
        'horayfecha
        '
        Me.horayfecha.Enabled = True
        '
        'PanelDesktop
        '
        resources.ApplyResources(Me.PanelDesktop, "PanelDesktop")
        Me.PanelDesktop.Controls.Add(Me.lblfecha)
        Me.PanelDesktop.Controls.Add(Me.lblhora)
        Me.PanelDesktop.Controls.Add(Me.pbLogoEmpresa)
        Me.PanelDesktop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelDesktop.GradientTopRight = System.Drawing.Color.White
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Quality = 10
        '
        'lblfecha
        '
        resources.ApplyResources(Me.lblfecha, "lblfecha")
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.ForeColor = System.Drawing.Color.White
        Me.lblfecha.Name = "lblfecha"
        '
        'lblhora
        '
        resources.ApplyResources(Me.lblhora, "lblhora")
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.ForeColor = System.Drawing.Color.White
        Me.lblhora.Name = "lblhora"
        '
        'pbLogoEmpresa
        '
        resources.ApplyResources(Me.pbLogoEmpresa, "pbLogoEmpresa")
        Me.pbLogoEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.pbLogoEmpresa.Image = Global.ProyectoProgramacion.My.Resources.Resources.Logo_HotelCanino
        Me.pbLogoEmpresa.Name = "pbLogoEmpresa"
        Me.pbLogoEmpresa.TabStop = False
        '
        'General
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "General"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picture.ResumeLayout(False)
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.photo.ResumeLayout(False)
        Me.photo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.gerenteSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gerenteMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.pbLogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnGestion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents pbLogoEmpresa As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGeneral As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents picture As PictureBox
    Friend WithEvents btnModificarPrecio As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents edit As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents photo As PictureBox
    Friend WithEvents nombre As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents phototrasparent As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtNombreUsuario As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents btnReservas As FontAwesome.Sharp.IconButton
    Friend WithEvents horayfecha As Timer
    Friend WithEvents gerenteMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents gerenteSalir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnHSalida As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHEntrada As FontAwesome.Sharp.IconButton
    Friend WithEvents gestionClientes As FontAwesome.Sharp.IconButton
End Class