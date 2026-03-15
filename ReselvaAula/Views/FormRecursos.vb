Imports Supabase.Postgrest
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ReselvaAula.Models

Namespace Views
    Public Class FormRecursos
        Private _client As Client
        Private _recursoSeleccionado As Recurso = Nothing

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
                Dim res = Await _client.Table(Of Recurso)().Order(Function(r) r.Id, Constants.Ordering.Ascending).Get()
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

        Private Sub dgvRecursos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRecursos.SelectionChanged
            If dgvRecursos.SelectedRows.Count > 0 Then
                _recursoSeleccionado = DirectCast(dgvRecursos.SelectedRows(0).DataBoundItem, Recurso)
                
                If _recursoSeleccionado IsNot Nothing Then
                    txtNombre.Text = _recursoSeleccionado.Nombre
                    cboTipo.SelectedItem = _recursoSeleccionado.Tipo
                    
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
            Dim tipo = cboTipo.Text.Trim()

            If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(tipo) Then
                MsgBox("Por favor completa todos los campos")
                Return
            End If

            Try
                _recursoSeleccionado.Nombre = nombre
                _recursoSeleccionado.Tipo = tipo
                
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
