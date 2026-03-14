Imports Supabase.Postgrest
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ReselvaAula.Models

Namespace Views
    Public Class FormRecursos
        Private _client As Client

        Public Sub New(client As Client)
            InitializeComponent()
            _client = client
        End Sub

        Private Async Sub FormRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await CargarRecursos()
        End Sub

        Private Async Function CargarRecursos() As Task
            Try
                Dim res = Await _client.Table(Of Recurso)().Get()
                dgvRecursos.DataSource = res.Models
                
                ' ✅ Ocultar columnas internas de BaseModel de Supabase
                If dgvRecursos.Columns.Contains("BaseUrl") Then dgvRecursos.Columns("BaseUrl").Visible = False
                If dgvRecursos.Columns.Contains("RequestClientOptions") Then dgvRecursos.Columns("RequestClientOptions").Visible = False
                If dgvRecursos.Columns.Contains("TableName") Then dgvRecursos.Columns("TableName").Visible = False
                If dgvRecursos.Columns.Contains("PrimaryKey") Then dgvRecursos.Columns("PrimaryKey").Visible = False
                
                ' Estilo de grid
                dgvRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvRecursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvRecursos.ReadOnly = True
            Catch ex As Exception
                MsgBox("Error al cargar recursos: " & ex.Message)
            End Try
        End Function

        Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            Dim nombre = txtNombre.Text.Trim()
            Dim tipo = cboTipo.Text.Trim()

            If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(tipo) Then
                MsgBox("Por favor completa todos los campos")
                Return
            End If

            Try
                Dim nuevoRecurso = New Recurso With {
                    .Nombre = nombre,
                    .Tipo = tipo
                }
                Await _client.Table(Of Recurso)().Insert(nuevoRecurso)
                MsgBox("Recurso creado con éxito")
                txtNombre.Clear()
                cboTipo.SelectedIndex = -1
                Await CargarRecursos()
            Catch ex As Exception
                MsgBox("Error al crear recurso: " & ex.Message)
            End Try
        End Sub

        Private Async Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
            Await CargarRecursos()
        End Sub
    End Class
End Namespace
