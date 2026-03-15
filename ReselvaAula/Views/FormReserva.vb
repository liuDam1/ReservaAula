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
            
            ' Estilo moderno
            Me.BackColor = Color.FromArgb(242, 245, 249)
            lblTitle.ForeColor = Color.FromArgb(45, 55, 72)
            lblTitle.Font = New Font("Segoe UI Semibold", 18.0!, FontStyle.Bold)
            
            Dim labels = {lblRecurso, lblFechaInicio, lblFechaFin, lblMotivo}
            For Each lbl In labels
                lbl.ForeColor = Color.FromArgb(74, 85, 104)
                lbl.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
            Next
            
            cboRecursos.BackColor = Color.FromArgb(247, 250, 252)
            txtMotivo.BackColor = Color.FromArgb(247, 250, 252)
            txtMotivo.BorderStyle = BorderStyle.FixedSingle
            
            btnReservar.BackColor = Color.FromArgb(49, 130, 206)
            btnReservar.FlatStyle = FlatStyle.Flat
            btnReservar.FlatAppearance.BorderSize = 0
            btnReservar.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
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
            
            ' Tomamos la fecha seleccionada y forzamos que sea medianoche local
            ' Al guardar en Supabase (PostgreSQL date), esto evitará desfases por zona horaria
            Dim fechaInicio = New DateTime(dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, dtpFechaInicio.Value.Day, 0, 0, 0)
            Dim fechaFin = New DateTime(dtpFechaFin.Value.Year, dtpFechaFin.Value.Month, dtpFechaFin.Value.Day, 0, 0, 0)
            
            Dim motivo = txtMotivo.Text.Trim()

            If Await _reservaService.CrearReserva(idUsuario, idRecurso, fechaInicio, fechaFin, motivo) Then
                MsgBox("Reserva creada con éxito")
                txtMotivo.Clear()
            End If
        End Sub
    End Class
End Namespace
