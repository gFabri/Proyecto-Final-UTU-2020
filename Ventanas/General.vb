﻿Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class General
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Ventana_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = SystemInformation.VirtualScreen.Width - 250
        Height = SystemInformation.VirtualScreen.Height - 250
        ActivateButton(btnInicio, Color.FromArgb(255, 255, 255))
    End Sub

    Public Sub New()
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 46)
        Panel1.Controls.Add(leftBorderBtn)
        DoubleBuffered = True
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()

            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(218, 111, 22)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Top = senderBtn.Top
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(238, 126, 44)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Public Sub OpenChildForm(childForm As Form)

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        If currentBtn IsNot Nothing Then
            lblGeneral.Text = currentBtn.Text
        End If

        PanelDesktop.Controls.Remove(pbLogoEmpresa)
    End Sub

    Private Sub Reset()
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.FromArgb(255, 255, 255)
        lblGeneral.Text = "Inicio"
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        If (PanelDesktop.Controls.Contains(pbLogoEmpresa)) Then
            Return
        End If
        PanelDesktop.Controls.Clear()
        PanelDesktop.Controls.Add(pbLogoEmpresa)
        PanelDesktop.Controls.Add(lblhora)
        PanelDesktop.Controls.Add(lblfecha)
        Reset()
    End Sub

    Private Sub ipbMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ipbSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnModificarPrecio_Click(sender As Object, e As EventArgs) Handles btnModificarPrecio.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ModificarPrecioHabitacion)
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnReservas.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ReservasConfirmadas)
    End Sub

    Private Sub btnCerarSesion_Click(sender As Object, e As EventArgs) Handles btnCerarSesion.Click
        Dim result As DialogResult = New DialogResult()
        result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro de cerrar sesión?")
        If result = DialogResult.OK Then
            Me.Close()
            Login.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles picture.MouseEnter
        photo.Visible = True
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click 'Cambia la foto del empleado'
        photo.Visible = False
        Dim datos As Datos = New Datos
        Dim opn = New OpenFileDialog()
        opn.Filter = "Elige una Imagen(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg"
        If opn.ShowDialog().Equals(DialogResult.OK) Then
            If datos.saveImage(Datos.CILogged, Image.FromFile(opn.FileName)) Then
                picture.Image = Image.FromFile(opn.FileName)
            End If
        End If
    End Sub

    Private Sub photo_Click(sender As Object, e As EventArgs) Handles photo.Click 'Cambia la foto del empleado'
        photo.Visible = False
        Dim datos As Datos = New Datos
        Dim opn = New OpenFileDialog()
        opn.Filter = "Elige una Imagen(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg"
        If opn.ShowDialog().Equals(DialogResult.OK) Then
            If datos.saveImage(Datos.CILogged, Image.FromFile(opn.FileName)) Then
                picture.Image = Image.FromFile(opn.FileName)
            End If
        End If
    End Sub

    Private Sub PanelMenu_MouseEnter(sender As Object, e As EventArgs) Handles PanelMenu.MouseEnter
        photo.Visible = False
    End Sub

    Private Sub PanelDesktop_MouseEnter(sender As Object, e As EventArgs) Handles PanelDesktop.MouseEnter
        photo.Visible = False
    End Sub

    Private Sub horayfecha_Tick(sender As Object, e As EventArgs) Handles horayfecha.Tick 'Obtiene la hora y fecha en tiempo real'
        lblhora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblfecha.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub gerenteSalir_Click(sender As Object, e As EventArgs) Handles gerenteSalir.Click
        Application.Exit()
    End Sub

    Private Sub gerenteMinimizar_Click(sender As Object, e As EventArgs) Handles gerenteMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New GestionReservas)
    End Sub

    Private Sub btnHEntrada_Click(sender As Object, e As EventArgs) Handles btnHEntrada.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ReservasEntradaConfirmada)
    End Sub

    Private Sub btnHSalida_Click(sender As Object, e As EventArgs) Handles btnHSalida.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New ReservasSalidaConfirmada)
    End Sub

    Private Sub gestionClientes_Click(sender As Object, e As EventArgs) Handles gestionClientes.Click
        ActivateButton(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New GestionClientes)
    End Sub
End Class