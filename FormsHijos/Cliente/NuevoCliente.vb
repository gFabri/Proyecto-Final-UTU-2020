Imports System.Runtime.InteropServices

Public Class NuevoCliente

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Pagina1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim datos = New Datos
        Dim age = Year(Date.Now) - Year(fechaNac.Value)
        If validarCedula(txtCI) And validarTexto(txtNombre) And validarTexto(txtApellido) And validarTexto(txtDireccion) And validarNumeroTelefono(txtTelefono) Then
            If age > 18 Then
                If datos.agregarCliente(txtCI.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, fechaNac.Value.ToString("yyyy-MM-dd")) Then
                    FormSucess.callFormWithMessage("Se ha guardado con éxito!")
                    Close()
                Else
                    FormInfo.callFormWithMessage("Ha ocurrido un error al guardar el cliente!")
                End If
            Else
                FormInfo.callFormWithMessage("La Fecha de nacimiento es incorrecta")
            End If
        End If
    End Sub

End Class