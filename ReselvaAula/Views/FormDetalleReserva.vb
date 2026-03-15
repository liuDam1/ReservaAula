Imports Supabase.Postgrest
Imports ReselvaAula.Models
Imports ReselvaAula.Controllers
Imports System.Windows.Forms
Imports System.Linq

Namespace Views
    Public Class FormDetalleReserva
        Inherits Form

        Private _reservaView As Object
        Private _client As Client
        Private _usuarioLogueado As Usuario
        Private _reservaService As ReservaService
        Private _tipoNombre As String = ""

        Public Sub New(reservaView As Object, client As Client, usuarioLogueado As Usuario)
            InitializeComponent()
            _reservaView = reservaView
            _client = client
            _usuarioLogueado = usuarioLogueado
            _reservaService = New ReservaService(_client)
            
            ' Cargar datos básicos
            lblReservaVal.Text = _reservaView.Recurso.ToString()
            lblUsuarioVal.Text = _reservaView.Usuario.ToString()
            lblMotivoVal.Text = _reservaView.Motivo.ToString()
            lblDesdeVal.Text = CDate(_reservaView.Inicio).ToString("dd/MM/yyyy")
            lblHastaVal.Text = CDate(_reservaView.Fin).ToString("dd/MM/yyyy")
            
            ' El tipo se cargará asíncronamente
            lblTipoVal.Text = "Cargando..."
            
            ' Cargar el nombre del tipo
            CargarNombreTipo()

            ' Inicializar controles de edición
            txtMotivo.Text = _reservaView.Motivo.ToString()
            dtpInicio.Value = CDate(_reservaView.Inicio)
            dtpHasta.Value = CDate(_reservaView.Fin)

            ' Como medida de seguridad, habilitamos botones solo si el nombre coincide
            Dim esDuenio = (_reservaView.Usuario.ToString() = _usuarioLogueado.Nombre)
            btnEliminar.Visible = esDuenio
            btnModificar.Visible = esDuenio

            ' Estética moderna
            Me.BackColor = Color.FromArgb(242, 245, 249)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "Detalle de Reserva"
            
            pnlHeader.BackColor = Color.FromArgb(45, 55, 72)
            lblTitle.Font = New Font("Segoe UI Semibold", 14.0!, FontStyle.Bold)
            
            ' Etiquetas de título de campo
            Dim headers = {lblReserva, lblUsuario, lblMotivo, lblDesde, lblHasta, lblTipo}
            For Each h In headers
                h.ForeColor = Color.FromArgb(113, 128, 150)
                h.Font = New Font("Segoe UI", 8.5!, FontStyle.Bold)
            Next
            
            ' Valores
            Dim values = {lblReservaVal, lblUsuarioVal, lblMotivoVal, lblDesdeVal, lblHastaVal, lblTipoVal}
            For Each v In values
                v.ForeColor = Color.FromArgb(45, 55, 72)
                v.Font = New Font("Segoe UI Semibold", 10.5!, FontStyle.Bold)
            Next
            
            ' Botones
            btnCerrar.BackColor = Color.FromArgb(160, 174, 192)
            btnCerrar.FlatStyle = FlatStyle.Flat
            btnCerrar.FlatAppearance.BorderSize = 0
            
            btnEliminar.BackColor = Color.FromArgb(229, 62, 62)
            btnEliminar.FlatStyle = FlatStyle.Flat
            btnEliminar.FlatAppearance.BorderSize = 0
            btnEliminar.ForeColor = Color.White
            
            btnModificar.BackColor = Color.FromArgb(49, 130, 206)
            btnModificar.FlatStyle = FlatStyle.Flat
            btnModificar.FlatAppearance.BorderSize = 0
            btnModificar.ForeColor = Color.White
            
            btnGuardar.BackColor = Color.FromArgb(72, 187, 120)
            btnGuardar.FlatStyle = FlatStyle.Flat
            btnGuardar.FlatAppearance.BorderSize = 0
            btnGuardar.ForeColor = Color.White
            
            txtMotivo.BackColor = Color.White
            txtMotivo.BorderStyle = BorderStyle.FixedSingle
        End Sub

        Private Async Sub CargarNombreTipo()
            Try
                ' Obtener el ID del tipo desde _reservaView.Tipo
                Dim tipoId As Integer
                If Integer.TryParse(_reservaView.Tipo.ToString(), tipoId) Then
                    ' Buscar el tipo por ID
                    Dim response = Await _client.Table(Of Tipo)().Filter("id", Constants.Operator.Equals, tipoId).Get()
                    Dim tipo = response.Models.FirstOrDefault()
                    
                    If tipo IsNot Nothing Then
                        _tipoNombre = tipo.Nombre
                        lblTipoVal.Text = tipo.Nombre
                    Else
                        lblTipoVal.Text = "Tipo no encontrado"
                    End If
                Else
                    lblTipoVal.Text = _reservaView.Tipo.ToString()
                End If
            Catch ex As Exception
                lblTipoVal.Text = "Error al cargar tipo"
                ' Opcional: MsgBox("Error al cargar nombre del tipo: " & ex.Message)
            End Try
        End Sub

        Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            If MsgBox("¿Estás seguro de que deseas eliminar esta reserva?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmar") = MsgBoxResult.Yes Then
                Try
                    Await _client.Table(Of Reserva)().Filter("id", Constants.Operator.Equals, _reservaView.ID).Delete()
                    MsgBox("Reserva eliminada con éxito", MsgBoxStyle.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Error al eliminar: " & ex.Message)
                End Try
            End If
        End Sub

        Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
            ' Cambiar a modo edición
            lblMotivoVal.Visible = False
            lblDesdeVal.Visible = False
            lblHastaVal.Visible = False
            
            txtMotivo.Visible = True
            dtpInicio.Visible = True
            dtpHasta.Visible = True
            
            btnModificar.Visible = False
            btnGuardar.Visible = True
        End Sub

        Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            Try
                Dim nuevoMotivo = txtMotivo.Text.Trim()
                Dim nuevaFechaInicio = dtpInicio.Value.Date
                Dim nuevaFechaFin = dtpHasta.Value.Date

                If nuevaFechaFin < nuevaFechaInicio Then
                    MsgBox("La fecha de fin no puede ser anterior a la de inicio")
                    Return
                End If

                ' Primero recuperamos la reserva actual para obtener el ID del recurso y otros datos
                Dim response = Await _client.Table(Of Reserva)().Filter("id", Constants.Operator.Equals, _reservaView.ID).Get()
                Dim resActual = response.Models.FirstOrDefault()
                
                If resActual IsNot Nothing Then
                    ' Verificamos conflictos (excluyendo la reserva actual)
                    If Await _reservaService.ExisteConflicto(resActual.IdRecurso, nuevaFechaInicio, nuevaFechaFin, resActual.Id) Then
                        MsgBox("Conflicto: El recurso ya está reservado en ese horario por otro usuario.")
                        Return
                    End If

                    ' Actualizamos los campos
                    resActual.Motivo = nuevoMotivo
                    resActual.FechaInicio = nuevaFechaInicio.ToString("yyyy-MM-dd")
                    resActual.FechaFin = nuevaFechaFin.ToString("yyyy-MM-dd")
                    
                    ' Guardamos los cambios filtrando por ID para mayor seguridad
                    Await _client.Table(Of Reserva)().Filter("id", Constants.Operator.Equals, resActual.Id).Update(resActual)
                    
                    MsgBox("Reserva actualizada con éxito", MsgBoxStyle.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("No se encontró la reserva en la base de datos.")
                End If
            Catch ex As Exception
                MsgBox("Error al actualizar: " & ex.Message)
            End Try
        End Sub

        Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
            Me.Close()
        End Sub
    End Class
End Namespace
