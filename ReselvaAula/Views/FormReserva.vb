Imports Supabase.Postgrest
Imports System.Collections.Generic
Imports ReselvaAula.Models
Imports ReselvaAula.Controllers

Namespace Views
    Public Class FormReserva
        Private _usuario As Usuario
        Private _client As Client
        Private _reservaService As ReservaService

        Public Sub New(usuario As Usuario, client As Client)
            InitializeComponent()
            _usuario = usuario
            _client = client
            _reservaService = New ReservaService(_client)
        End Sub

        Private Async Sub FormReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Dim recursos = Await _reservaService.CargarRecursos()
                cboRecursos.DataSource = recursos
                cboRecursos.DisplayMember = "Nombre"
                cboRecursos.ValueMember = "Id"
            Catch ex As Exception
                MsgBox("Error al cargar recursos: " & ex.Message)
            End Try
        End Sub

        Private Async Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
            If cboRecursos.SelectedItem Is Nothing Then
                MsgBox("Selecciona un recurso")
                Return
            End If

            ' ✅ Se usa el ID del recurso y el ID del usuario actual para guardar
            Dim idRecurso = DirectCast(cboRecursos.SelectedItem, Recurso).Id
            Dim idUsuario = _usuario.Id
            Dim fechaInicio = dtpFechaInicio.Value
            Dim fechaFin = dtpFechaFin.Value
            Dim motivo = txtMotivo.Text.Trim()

            If Await _reservaService.CrearReserva(idUsuario, idRecurso, fechaInicio, fechaFin, motivo) Then
                MsgBox("Reserva creada con éxito")
                txtMotivo.Clear()
            End If
        End Sub
    End Class
End Namespace
