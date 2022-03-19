Imports System.Runtime.InteropServices

Public Class ModificarHabitaciones

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Dim idHab

    Public Sub setDataGridView(id As Integer, precio As Double, amount As Integer)
        idHab = id
        txtPrecio.Text = precio
        txtAmount.Text = amount
    End Sub

    Private Sub Pagina1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim datos = New Datos
        If validarNumero(txtPrecio) Then
            If datos.modificarHabitacion(idHab, txtPrecio.Text, txtAmount.Text) Then
                FormSucess.callFormWithMessage("El precio de la habitación se ha modificado con éxito!")
                Close()
            Else
                FormInfo.callFormWithMessage("Ha ocurrido un error al modificar el precio de la habitación!")
            End If
        End If
    End Sub

End Class