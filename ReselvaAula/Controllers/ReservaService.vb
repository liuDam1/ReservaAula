Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports Supabase.Postgrest
Imports ReselvaAula.Models

Namespace Controllers
    Public Class ReservaService
        Private ReadOnly _client As Client

        Public Sub New(client As Client)
            _client = client
        End Sub

        Public Async Function CargarRecursos() As Task(Of List(Of Recurso))
            Try
                Dim res = Await _client.Table(Of Recurso)().Get()
                Return res.Models
            Catch ex As Exception
                MsgBox("Error al cargar recursos: " & ex.Message)
                Return New List(Of Recurso)()
            End Try
        End Function

        Public Async Function ExisteConflicto(idRecurso As Long, fechaInicio As DateTime, fechaFin As DateTime) As Task(Of Boolean)
            Try
                ' ✅ Ajustado a los nombres de tu captura y usando ID para conflictos
                Dim reservas = Await _client.Table(Of Reserva)() _
                    .Filter("id_recurso", Constants.Operator.Equals, idRecurso) _
                    .Filter("FechaInicio", Constants.Operator.LessThan, fechaFin) _
                    .Filter("FechaFin", Constants.Operator.GreaterThan, fechaInicio) _
                    .Get()
                Return reservas.Models.Count > 0
            Catch ex As Exception
                MsgBox("Error al verificar conflictos: " & ex.Message)
                Return True
            End Try
        End Function

        Public Async Function CrearReserva(idUsuario As Long, idRecurso As Long, fechaInicio As DateTime, fechaFin As DateTime, motivo As String) As Task(Of Boolean)
            If fechaFin <= fechaInicio Then
                MsgBox("Fecha fin debe ser posterior a fecha inicio")
                Return False
            End If

            If Await ExisteConflicto(idRecurso, fechaInicio, fechaFin) Then
                MsgBox("Conflicto: El recurso ya está reservado en ese horario")
                Return False
            End If

            Try
                ' ✅ Guarda por IDs de Usuario y Recurso
                Dim reserva = New Reserva With {
                    .IdUsuario = idUsuario,
                    .IdRecurso = idRecurso,
                    .FechaInicio = fechaInicio,
                    .FechaFin = fechaFin,
                    .Motivo = motivo
                }
                Await _client.Table(Of Reserva)().Insert(reserva)
                Return True
            Catch ex As Exception
                MsgBox("Error al crear reserva: " & ex.Message)
                Return False
            End Try
        End Function
    End Class
End Namespace
