Imports Supabase.Postgrest
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ReselvaAula.Models

Namespace Views
    Public Class FormListadoReservas
        Private _client As Client

        Public Sub New(client As Client)
            InitializeComponent()
            _client = client
        End Sub

        Private Async Sub FormListadoReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await CargarReservas()
        End Sub

        Private Async Function CargarReservas() As Task
            Try
                ' ✅ Cargar reservas, recursos y usuarios para cruzar los nombres (JOIN manual)
                Dim resReservas = Await _client.Table(Of Reserva)().Get()
                Dim resRecursos = Await _client.Table(Of Recurso)().Get()
                Dim resUsuarios = Await _client.Table(Of Usuario)().Get()

                ' Crear diccionarios para búsqueda rápida por ID
                Dim recursosDict = resRecursos.Models.ToDictionary(Function(r) r.Id, Function(r) r.Nombre)
                Dim usuariosDict = resUsuarios.Models.ToDictionary(Function(u) u.Id, Function(u) u.Nombre)

                ' Mapear a una vista legible mostrando nombres en lugar de IDs
                Dim vistaReservas = resReservas.Models.Select(Function(r) New With {
                    .ID = r.Id,
                    .Usuario = If(usuariosDict.ContainsKey(r.IdUsuario), usuariosDict(r.IdUsuario), $"ID: {r.IdUsuario}"),
                    .Recurso = If(recursosDict.ContainsKey(r.IdRecurso), recursosDict(r.IdRecurso), $"ID: {r.IdRecurso}"),
                    .Inicio = r.FechaInicio,
                    .Fin = r.FechaFin,
                    .Motivo = r.Motivo
                }).OrderByDescending(Function(x) x.Inicio).ToList()

                dgvReservas.DataSource = vistaReservas
                
                ' Estilo de grid
                dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvReservas.ReadOnly = True
                
            Catch ex As Exception
                MsgBox("Error al cargar el listado: " & ex.Message)
            End Try
        End Function

        Private Async Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
            Await CargarReservas()
        End Sub
    End Class
End Namespace
