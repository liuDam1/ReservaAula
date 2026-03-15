Imports Supabase.Postgrest
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ReselvaAula.Models

Namespace Views
    Public Class FormTipos
        Private _client As Client
        Private _tipoSeleccionado As Tipo = Nothing

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
            
            dgvTipos.BackgroundColor = Color.White
            dgvTipos.BorderStyle = BorderStyle.None
            dgvTipos.EnableHeadersVisualStyles = False
            dgvTipos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 55, 72)
            dgvTipos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvTipos.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Bold", 9.0!, FontStyle.Bold)
            
            panelAdd.BackColor = Color.White
            lblSubtitle.ForeColor = Color.FromArgb(45, 55, 72)
            lblSubtitle.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
            
            lblNombre.ForeColor = Color.FromArgb(74, 85, 104)
            
            txtNombre.BackColor = Color.FromArgb(247, 250, 252)
            txtNombre.BorderStyle = BorderStyle.FixedSingle
            
            btnGuardar.BackColor = Color.FromArgb(72, 187, 120) ' Verde moderno
            btnGuardar.FlatStyle = FlatStyle.Flat
            btnGuardar.FlatAppearance.BorderSize = 0
            btnGuardar.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
            
            btnModificar.BackColor = Color.FromArgb(49, 130, 206) ' Azul moderno
            btnModificar.FlatStyle = FlatStyle.Flat
            btnModificar.FlatAppearance.BorderSize = 0
            btnModificar.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
            
            btnEliminar.BackColor = Color.FromArgb(229, 62, 62) ' Rojo moderno
            btnEliminar.FlatStyle = FlatStyle.Flat
            btnEliminar.FlatAppearance.BorderSize = 0
            btnEliminar.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
            
            btnLimpiar.BackColor = Color.FromArgb(160, 174, 192) ' Gris moderno
            btnLimpiar.FlatStyle = FlatStyle.Flat
            btnLimpiar.FlatAppearance.BorderSize = 0
            btnLimpiar.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        End Sub

        Private Async Sub FormTipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await CargarTipos()
            LimpiarFormulario()
        End Sub

        Private Async Function CargarTipos() As Task
            Try
                Dim res = Await _client.Table(Of Tipo)().Order(Function(t) t.Id, Constants.Ordering.Ascending).Get()
                dgvTipos.DataSource = res.Models
                
                ' Configurar columnas
                If dgvTipos.Columns.Contains("Id") Then 
                    dgvTipos.Columns("Id").Width = 60
                    dgvTipos.Columns("Id").HeaderText = "Id"
                End If
                
                If dgvTipos.Columns.Contains("Nombre") Then 
                    dgvTipos.Columns("Nombre").HeaderText = "Nombre del Tipo"
                    dgvTipos.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
                
                ' Ocultar columnas internas de BaseModel
                If dgvTipos.Columns.Contains("BaseUrl") Then dgvTipos.Columns("BaseUrl").Visible = False
                If dgvTipos.Columns.Contains("RequestClientOptions") Then dgvTipos.Columns("RequestClientOptions").Visible = False
                If dgvTipos.Columns.Contains("TableName") Then dgvTipos.Columns("TableName").Visible = False
                If dgvTipos.Columns.Contains("PrimaryKey") Then dgvTipos.Columns("PrimaryKey").Visible = False
                
                ' Estilo de grid
                dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvTipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvTipos.ReadOnly = True
                
                ' Deseleccionar cualquier fila después de cargar
                dgvTipos.ClearSelection()
                
            Catch ex As Exception
                MsgBox("Error al cargar tipos: " & ex.Message)
            End Try
        End Function

        Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            Dim nombre = txtNombre.Text.Trim()
            If String.IsNullOrEmpty(nombre) Then
                MsgBox("Introduce un nombre para el tipo")
                Return
            End If

            Try
                Dim nuevo = New Tipo With {.Nombre = nombre}
                Await _client.Table(Of Tipo)().Insert(nuevo)
                MsgBox("Tipo creado con éxito")
                LimpiarFormulario()
                Await CargarTipos()
            Catch ex As Exception
                MsgBox("Error al crear tipo: " & ex.Message)
            End Try
        End Sub

        Private Sub dgvTipos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTipos.SelectionChanged
            If dgvTipos.SelectedRows.Count > 0 Then
                Dim filaSeleccionada = dgvTipos.SelectedRows(0)
                If filaSeleccionada IsNot Nothing AndAlso filaSeleccionada.DataBoundItem IsNot Nothing Then
                    _tipoSeleccionado = DirectCast(filaSeleccionada.DataBoundItem, Tipo)
                    If _tipoSeleccionado IsNot Nothing Then
                        txtNombre.Text = _tipoSeleccionado.Nombre
                        
                        ' Modo edición
                        lblSubtitle.Text = "Editar Tipo"
                        btnGuardar.Visible = False
                        btnModificar.Visible = True
                        btnEliminar.Visible = True
                        btnLimpiar.Visible = True
                    End If
                End If
            End If
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            LimpiarFormulario()
        End Sub

        Private Sub LimpiarFormulario()
            _tipoSeleccionado = Nothing
            txtNombre.Clear()
            lblSubtitle.Text = "Nuevo Tipo"
            btnGuardar.Visible = True
            btnModificar.Visible = False
            btnEliminar.Visible = False
            btnLimpiar.Visible = False
            dgvTipos.ClearSelection()
        End Sub

        Private Async Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
            If _tipoSeleccionado Is Nothing Then Return
            Dim nombre = txtNombre.Text.Trim()
            If String.IsNullOrEmpty(nombre) Then
                MsgBox("Introduce un nombre para el tipo")
                Return
            End If

            Try
                _tipoSeleccionado.Nombre = nombre
                Await _client.Table(Of Tipo)().Filter("id", Constants.Operator.Equals, _tipoSeleccionado.Id).Update(_tipoSeleccionado)
                MsgBox("Tipo actualizado correctamente")
                LimpiarFormulario()
                Await CargarTipos()
            Catch ex As Exception
                MsgBox("Error al actualizar: " & ex.Message)
            End Try
        End Sub

        Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            If _tipoSeleccionado Is Nothing Then Return
            
            If MsgBox($"¿Estás seguro de eliminar el tipo '{_tipoSeleccionado.Nombre}'? Esto podría afectar a los recursos asociados.", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Try
                    Await _client.Table(Of Tipo)().Filter("id", Constants.Operator.Equals, _tipoSeleccionado.Id).Delete()
                    MsgBox("Tipo eliminado")
                    LimpiarFormulario()
                    Await CargarTipos()
                Catch ex As Exception
                    MsgBox("Error al eliminar: " & ex.Message)
                End Try
            End If
        End Sub

        Private Async Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
            Await CargarTipos()
            LimpiarFormulario()
        End Sub
    End Class
End Namespace