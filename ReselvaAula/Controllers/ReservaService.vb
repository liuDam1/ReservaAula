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

        Public Async Function ExisteConflicto(idRecurso As Long, fechaInicio As DateTime, fechaFin As DateTime, Optional idReservaAExcluir As Long? = Nothing) As Task(Of Boolean)
            Try
                ' ✅ Convertimos a string ISO para el filtro
                Dim strInicio = fechaInicio.ToString("yyyy-MM-dd")
                Dim strFin = fechaFin.ToString("yyyy-MM-dd")

                Dim query = _client.Table(Of Reserva)() _
                    .Filter("id_recurso", Constants.Operator.Equals, idRecurso) _
                    .Filter("FechaInicio", Constants.Operator.LessThan, strFin) _
                    .Filter("FechaFin", Constants.Operator.GreaterThan, strInicio)

                If idReservaAExcluir.HasValue Then
                    query = query.Filter("id", Constants.Operator.NotEqual, idReservaAExcluir.Value)
                End If

                Dim reservas = Await query.Get()
                Return reservas.Models.Count > 0
            Catch ex As Exception
                MsgBox("Error al verificar conflictos: " & ex.Message)
                Return True
            End Try
        End Function

        Public Async Function CrearReserva(idUsuario As Long, idRecurso As Long, fechaInicio As DateTime, fechaFin As DateTime, motivo As String) As Task(Of Boolean)
            If fechaFin < fechaInicio Then
                MsgBox("Fecha fin debe ser posterior o igual a fecha inicio")
                Return False
            End If

            If Await ExisteConflicto(idRecurso, fechaInicio, fechaFin) Then
                MsgBox("Conflicto: El recurso ya está reservado en ese horario")
                Return False
            End If

            Try
                ' ✅ Guardamos como string ISO "yyyy-MM-dd" para evitar desfases UTC
                Dim reserva = New Reserva With {
                    .IdUsuario = idUsuario,
                    .IdRecurso = idRecurso,
                    .FechaInicio = fechaInicio.ToString("yyyy-MM-dd"),
                    .FechaFin = fechaFin.ToString("yyyy-MM-dd"),
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
