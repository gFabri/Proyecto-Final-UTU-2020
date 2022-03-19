Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class EditarReserva

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles editar.Click
        Dim datos = New Datos
        Dim metodo
        If metodoDePago.selectedIndex = 1 Then
            metodo = "T"
        Else
            metodo = "C"
        End If
        If fechainicio.Value >= Today Then
            If fechaTerminacion.Value > fechainicio.Value Then
                If datos.editarReserva(cliente.Text, metodo, fechaTerminacion.Value, fechainicio.Value) Then
                    FormSucess.callFormWithMessage("La reserva se ha registrado con éxito!")
                    Close()
                Else
                    FormInfo.callFormWithMessage("Ha ocurrido un error al editar la reserva!")
                End If
            Else
                FormInfo.callFormWithMessage("¡La Fecha de terminación tiene que ser superior a la fecha de inicio!")
            End If
        Else
            FormInfo.callFormWithMessage("¡La Fecha de inicio no puede ser menor a hoy!")
        End If

    End Sub
End Class