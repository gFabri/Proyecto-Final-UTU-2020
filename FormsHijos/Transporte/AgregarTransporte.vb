Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class AgregarTransporte

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
        Dim datos = New Datos
        Dim horario
        If horarios.selectedIndex = 0 Then
            horario = "M"
        ElseIf horarios.selectedIndex = 1 Then
            horario = "Ta"
        Else
            horario = "N"
        End If
        If Not vehiculos.selectedIndex < 0 Then
            If Not tipo.selectedIndex < 0 Then
                If Not horarios.selectedIndex < 0 Then
                    If validarEspacio(direccion) Then

                        If fecha.Value >= Today Then
                            If datos.comprobarSiHayTransporte(horario, fecha.Value, vehiculos.selectedValue) Then
                                isPossible = True
                                Close()
                            Else
                                FormInfo.callFormWithMessage("Seleccione otra fecha o horario, ya se encuentra ocupado!")
                            End If
                        Else
                            FormInfo.callFormWithMessage("¡La fecha de transporte no puede ser menor o igual a hoy!")
                        End If

                    End If

                Else
                        FormInfo.callFormWithMessage("Eliga un horario!")
                    End If
                Else
                    FormInfo.callFormWithMessage("¡Eliga un tipo!")
                End If
            Else
                FormInfo.callFormWithMessage("¡Eliga un vehiculo!")
            End If

    End Sub

    Public Function fill(dgv As DataGridView)
        Dim datos = New Datos
        If isPossible Then
            Dim horario
            Dim tipos
            If horarios.selectedIndex = 0 Then
                horario = "M"
            ElseIf horarios.selectedIndex = 1 Then
                horario = "Ta"
            Else
                horario = "N"
            End If

            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(i).Cells(1).Value = vehiculos.selectedValue And dgv.Rows(i).Cells(2).Value = fecha.Value.ToString("yyyy/MM/dd") And dgv.Rows(i).Cells(3).Value = horario Then

                End If
            Next


            If tipo.selectedIndex = 0 Then
                tipos = "LL"
            Else
                tipos = "T"
            End If
            Dim itemCount As Integer

            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(i).Cells(1).Value = vehiculos.selectedValue And dgv.Rows(i).Cells(2).Value = fecha.Value.ToString("yyyy/MM/dd") And dgv.Rows(i).Cells(3).Value = horario Then
                    itemCount = itemCount + 1
                End If
            Next
            If itemCount >= 3 Then
                FormInfo.callFormWithMessage("¡Esta vehiculo esta lleno, utilize otro!")
                Return False
            End If

            dgv.Rows.Add(mascota.Text, vehiculos.selectedValue, fecha.Value.ToString("yyyy/MM/dd"), horario, tipos, direccion.Text)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AgregarTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha.Value = Today
    End Sub
End Class