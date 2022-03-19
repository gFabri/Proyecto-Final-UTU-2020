Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class NuevoMedicamento

    Dim isPossible = False

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
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If validarTexto(medicamento) Then
            Dim datos = New Datos
            If datos.agregarMedicamento(medicamento.Text) Then
                FormSucess.callFormWithMessage("Se ha añadido el medicamento correctamente")
                Close()
            Else
                FormInfo.callFormWithMessage("Ocurrio un error al añadir el medicamento")
            End If
        End If
    End Sub
End Class