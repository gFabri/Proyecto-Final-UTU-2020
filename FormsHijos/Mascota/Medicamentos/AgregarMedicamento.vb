Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class AgregarMedicamento

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
        If validarNumero(dosis) And validarHoras(horario) Then
            If (medicamentos.selectedIndex >= 0) Then
                isPossible = True
                Close()
            Else
                FormInfo.callFormWithMessage("Selecciona un Medicamento!")
            End If
        End If
    End Sub

    Public Function fill(dgv As DataGridView)
        Dim datos = New Datos
        If isPossible Then
            Dim medicamentosplit = medicamentos.selectedValue.Split(" ")
            If dgv.Rows.Count = 0 Then
                dgv.Rows.Add(medicamentosplit(0), id.Text, medicamentosplit(1), dosis.Text, horario.Text)
                Return True
            Else
                dgv.Rows.Add(medicamentosplit(0), id.Text, medicamentosplit(1), dosis.Text, horario.Text)
                Return True
            End If

            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AgregarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        datos.loadAllMedicamentos(medicamentos)
    End Sub

    Private Sub medicamentos_onItemSelected(sender As Object, e As EventArgs) Handles medicamentos.onItemSelected
        Dim datos = New Datos
        If (medicamentos.selectedValue = "Agregar Medicamento") Then
            Dim nuevoMedicamento = New NuevoMedicamento
            nuevoMedicamento.ShowDialog()
            medicamentos.Clear()
            datos.loadAllMedicamentos(medicamentos)
        End If
    End Sub
End Class