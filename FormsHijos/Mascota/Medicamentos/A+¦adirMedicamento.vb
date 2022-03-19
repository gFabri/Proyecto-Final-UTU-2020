Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class AñadirMedicamento

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
        If validarNumero(dosis) And validarTexto(medicamento) And validarHoras(horario) Then
            isPossible = True
            Me.Close()
        End If
    End Sub

    Public Function fill(dgv As DataGridView)
        Dim datos = New Datos
        If isPossible Then
            If dgv.Rows.Count = 0 Then
                dgv.Rows.Add(datos.getIncrementalMedicamentoNumber + 1, ID.Text, medicamento.Text, dosis.Text, horario.Text)
                Return True
            Else
                Dim index As Integer = dgv.Rows(dgv.Rows.Count - 1).Cells(0).Value
                dgv.Rows.Add(index + 1, ID.Text, medicamento.Text, dosis.Text, horario.Text)
                Return True
            End If

            Return True
        Else
            Return False
        End If
    End Function
End Class