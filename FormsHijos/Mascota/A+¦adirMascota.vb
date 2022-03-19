Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class AñadirMascota

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
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If validarTexto(NombreMascota) And validarTexto(comida) And validarTexto(raza) And validarNumero(peso) Then
            If Not habitaciones.selectedIndex < 0 Then
                If fechaNac.Value < Today Then
                    isPossible = True
                    Close()
                Else
                    FormInfo.callFormWithMessage("La fecha de nacimiento no puede ser mayor o igual a hoy!")
                End If
            Else
                FormInfo.callFormWithMessage("Eliga una habitacion!")
            End If
        End If
    End Sub

    Public Function fill(dgv As DataGridView)
        Dim datos = New Datos
        If isPossible Then
            Dim vacuna
            Dim sexos
            If vacunas.selectedIndex = 0 Then
                vacuna = "T"
            Else
                vacuna = "F"
            End If

            If sexo.selectedIndex = 0 Then
                sexos = "M"
            Else
                sexos = "H"
            End If

            Dim itemCount As Integer

            If dgv.Rows.Count = 0 Then
                dgv.Rows.Add(datos.getIncrementalMascotaNumber() + 1, NombreMascota.Text, fechaNac.Value.ToString("yyyy/MM/dd"), vacuna, comida.Text, peso.Text, raza.Text, sexos, habitaciones.selectedValue, webcam.Checked, dogtv.Checked)
                Return True
                Else
                Dim index As Integer = dgv.Rows(dgv.Rows.Count - 1).Cells(0).Value
                For i As Integer = 0 To dgv.Rows.Count - 1
                    If dgv.Rows(i).Cells(8).Value = habitaciones.selectedValue Then
                        itemCount = itemCount + 1
                    End If
                Next
                If itemCount >= 3 Then
                    FormInfo.callFormWithMessage("Esta habitacion esta llena, usa otra!")
                    Return False
                End If
                dgv.Rows.Add(index + 1, NombreMascota.Text, fechaNac.Value.ToString("yyyy/MM/dd"), vacuna, comida.Text, peso.Text, raza.Text, sexos, habitaciones.selectedValue, webcam.Checked, dogtv.Checked)
                Return True
                End If
            Else
                Return False
        End If
    End Function


    Private Sub AñadirMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechaNac.Value = Today
        Dim datos = New Datos
        datos.cargarHabitaciones(tiposdehabitacion.selectedIndex + 1, habitaciones)
    End Sub

    Private Sub tiposdehabitacion_onItemSelected(sender As Object, e As EventArgs) Handles tiposdehabitacion.onItemSelected
        If tiposdehabitacion.selectedIndex = 0 Then
            serviciosExtra.Visible = True
        Else
            webcam.Checked = False
            dogtv.Checked = False
            serviciosExtra.Visible = False
        End If
        Dim datos = New Datos
        datos.cargarHabitaciones(tiposdehabitacion.selectedIndex + 1, habitaciones)
    End Sub
End Class