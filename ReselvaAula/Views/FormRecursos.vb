Imports Supabase.Postgrest
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ReselvaAula.Models

Namespace Views
    Public Class FormRecursos
        Private _client As Client
        Private _recursoSeleccionado As Recurso = Nothing

        ' Clase auxiliar para mostrar el nombre del tipo en el DataGridView
        Private Class RecursoViewModel
            Public Property Id As Long
            Public Property Nombre As String
            Public Property TipoId As Long?
            Public Property TipoNombre As String
        End Class

        Public Sub New(client As Client)
            InitializeComponent()
            _client = client
            
            ' Estilo moderno
            Me.BackColor = Color.FromArgb(242, 245, 249)
            lblTitle.ForeColor = Color.FromArgb(45, 55, 72)
            lblTitle.Font = New Font("Segoe UI Semibold", 18.0!, FontStyle.Bold)
            
            btnRefrescar.BackColor = Color.FromArgb(49, 130, 206)
            btnRefrescar.FlatStyle = FlatStyle.Flat
            btnRefrescar.FlatAppearance.BorderSize = 0
            
            dgvRecursos.BackgroundColor = Color.White
            dgvRecursos.BorderStyle = BorderStyle.None
            dgvRecursos.EnableHeadersVisualStyles = False
            dgvRecursos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 55, 72)
            dgvRecursos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvRecursos.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Bold", 9.0!, FontStyle.Bold)
            
            panelAdd.BackColor = Color.White
            lblSubtitle.ForeColor = Color.FromArgb(45, 55, 72)
            lblSubtitle.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
            
            lblNombre.ForeColor = Color.FromArgb(74, 85, 104)
            lblTipo.ForeColor = Color.FromArgb(74, 85, 104)
            
            txtNombre.BackColor = Color.FromArgb(247, 250, 252)
            txtNombre.BorderStyle = BorderStyle.FixedSingle
            cboTipo.BackColor = Color.FromArgb(247, 250, 252)
            
            btnGuardar.BackColor = Color.FromArgb(72, 187, 120) ' Verde moderno
            btnGuardar.FlatStyle = FlatStyle.Flat
            btnGuardar.FlatAppearance.BorderSize = 0
            btnGuardar.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        End Sub

        Private Async Sub FormRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await CargarRecursos()
        End Sub

        Private Async Function CargarRecursos() As Task
            Try
                ' 1. Cargar Tipos para mapear nombres
                Dim resTipos = Await _client.Table(Of Tipo)().Get()
                Dim tiposDict = resTipos.Models.ToDictionary(Function(t) t.Id, Function(t) t.Nombre)

                ' Cargar ComboBox
                cboTipo.DataSource = resTipos.Models
                cboTipo.DisplayMember = "Nombre"
                cboTipo.ValueMember = "Id"
                cboTipo.SelectedIndex = -1

                ' 2. Cargar Recursos
                Dim resRecursos = Await _client.Table(Of Recurso)().Order(Function(r) r.Id, Constants.Ordering.Ascending).Get()
                
                ' 3. Mapear a ViewModel para mostrar nombres en lugar de IDs
                Dim viewModels = resRecursos.Models.Select(Function(r) New RecursoViewModel With {
                    .Id = r.Id,
                    .Nombre = r.Nombre,
                    .TipoId = r.Tipo,
                    .TipoNombre = If(r.Tipo.HasValue AndAlso tiposDict.ContainsKey(r.Tipo.Value), tiposDict(r.Tipo.Value), "Sin Tipo")
                }).ToList()

                dgvRecursos.DataSource = viewModels
                
                ' Configurar columnas
                If dgvRecursos.Columns.Contains("TipoId") Then dgvRecursos.Columns("TipoId").Visible = False
                If dgvRecursos.Columns.Contains("Id") Then dgvRecursos.Columns("Id").Width = 50
                If dgvRecursos.Columns.Contains("Nombre") Then dgvRecursos.Columns("Nombre").Width = 150
                If dgvRecursos.Columns.Contains("TipoNombre") Then dgvRecursos.Columns("TipoNombre").HeaderText = "Tipo"
                
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
            Dim tipoId = If(cboTipo.SelectedValue IsNot Nothing, DirectCast(cboTipo.SelectedValue, Long), 0)

            If String.IsNullOrEmpty(nombre) OrElse tipoId = 0 Then
                MsgBox("Por favor completa todos los campos")
                Return
            End If

            Try
                Dim nuevoRecurso = New Recurso With {
                    .Nombre = nombre,
                    .Tipo = tipoId
                }
                Await _client.Table(Of Recurso)().Insert(nuevoRecurso)
                MsgBox("Recurso creado con éxito")
                LimpiarFormulario()
                Await CargarRecursos()
            Catch ex As Exception
                MsgBox("Error al crear recurso: " & ex.Message)
            End Try
        End Sub

        Private Async Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
            Await CargarRecursos()
        End Sub

        Private Sub dgvRecursos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRecursos.SelectionChanged
            If dgvRecursos.SelectedRows.Count > 0 Then
                Dim row = dgvRecursos.SelectedRows(0)
                Dim viewModel = DirectCast(row.DataBoundItem, RecursoViewModel)
                
                If viewModel IsNot Nothing Then
                    ' Crear objeto Recurso para edición
                    _recursoSeleccionado = New Recurso With {
                        .Id = viewModel.Id,
                        .Nombre = viewModel.Nombre,
                        .Tipo = viewModel.TipoId
                    }

                    txtNombre.Text = _recursoSeleccionado.Nombre
                    cboTipo.SelectedValue = _recursoSeleccionado.Tipo
                    
                    ' Cambiar a modo edición
                    lblSubtitle.Text = "Editar Recurso"
                    btnGuardar.Visible = False
                    btnModificar.Visible = True
                    btnEliminar.Visible = True
                    btnLimpiar.Visible = True
                End If
            End If
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            LimpiarFormulario()
        End Sub

        Private Sub LimpiarFormulario()
            _recursoSeleccionado = Nothing
            txtNombre.Clear()
            cboTipo.SelectedIndex = -1
            lblSubtitle.Text = "Nuevo Recurso"
            btnGuardar.Visible = True
            btnModificar.Visible = False
            btnEliminar.Visible = False
            btnLimpiar.Visible = False
            dgvRecursos.ClearSelection()
        End Sub

        Private Async Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
            If _recursoSeleccionado Is Nothing Then Return

            Dim nombre = txtNombre.Text.Trim()
            Dim tipoId = If(cboTipo.SelectedValue IsNot Nothing, DirectCast(cboTipo.SelectedValue, Long), 0)

            If String.IsNullOrEmpty(nombre) OrElse tipoId = 0 Then
                MsgBox("Por favor completa todos los campos")
                Return
            End If

            Try
                _recursoSeleccionado.Nombre = nombre
                _recursoSeleccionado.Tipo = tipoId
                
                Await _client.Table(Of Recurso)().Filter("id", Constants.Operator.Equals, _recursoSeleccionado.Id).Update(_recursoSeleccionado)
                
                MsgBox("Recurso actualizado con éxito")
                LimpiarFormulario()
                Await CargarRecursos()
            Catch ex As Exception
                MsgBox("Error al actualizar recurso: " & ex.Message)
            End Try
        End Sub

        Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            If _recursoSeleccionado Is Nothing Then Return

            If MsgBox($"¿Estás seguro de que deseas eliminar el recurso '{_recursoSeleccionado.Nombre}'?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmar eliminación") = MsgBoxResult.Yes Then
                Try
                    Await _client.Table(Of Recurso)().Filter("id", Constants.Operator.Equals, _recursoSeleccionado.Id).Delete()
                    MsgBox("Recurso eliminado con éxito")
                    LimpiarFormulario()
                    Await CargarRecursos()
                Catch ex As Exception
                    MsgBox("Error al eliminar recurso: " & ex.Message)
                End Try
            End If
        End Sub
    End Class
End Namespace
