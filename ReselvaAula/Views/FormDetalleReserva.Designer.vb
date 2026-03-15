Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormDetalleReserva
        Inherits System.Windows.Forms.Form

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblReserva = New System.Windows.Forms.Label()
            Me.lblReservaVal = New System.Windows.Forms.Label()
            Me.lblUsuario = New System.Windows.Forms.Label()
            Me.lblUsuarioVal = New System.Windows.Forms.Label()
            Me.lblMotivo = New System.Windows.Forms.Label()
            Me.lblMotivoVal = New System.Windows.Forms.Label()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.lblDesdeVal = New System.Windows.Forms.Label()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.lblHastaVal = New System.Windows.Forms.Label()
            Me.lblTipo = New System.Windows.Forms.Label()
            Me.lblTipoVal = New System.Windows.Forms.Label()
            Me.txtMotivo = New System.Windows.Forms.TextBox()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.btnCerrar = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(350, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(350, 60)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Detalle de Reserva"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblReserva
            '
            Me.lblReserva.AutoSize = True
            Me.lblReserva.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblReserva.ForeColor = System.Drawing.Color.Gray
            Me.lblReserva.Location = New System.Drawing.Point(30, 80)
            Me.lblReserva.Name = "lblReserva"
            Me.lblReserva.Size = New System.Drawing.Size(55, 15)
            Me.lblReserva.TabIndex = 1
            Me.lblReserva.Text = "RECURSO"
            '
            'lblReservaVal
            '
            Me.lblReservaVal.AutoSize = True
            Me.lblReservaVal.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblReservaVal.Location = New System.Drawing.Point(30, 98)
            Me.lblReservaVal.Name = "lblReservaVal"
            Me.lblReservaVal.Size = New System.Drawing.Size(42, 20)
            Me.lblReservaVal.TabIndex = 2
            Me.lblReservaVal.Text = "Valor"
            '
            'lblUsuario
            '
            Me.lblUsuario.AutoSize = True
            Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblUsuario.ForeColor = System.Drawing.Color.Gray
            Me.lblUsuario.Location = New System.Drawing.Point(30, 135)
            Me.lblUsuario.Name = "lblUsuario"
            Me.lblUsuario.Size = New System.Drawing.Size(61, 15)
            Me.lblUsuario.TabIndex = 3
            Me.lblUsuario.Text = "USUARIO"
            '
            'lblUsuarioVal
            '
            Me.lblUsuarioVal.AutoSize = True
            Me.lblUsuarioVal.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblUsuarioVal.Location = New System.Drawing.Point(30, 153)
            Me.lblUsuarioVal.Name = "lblUsuarioVal"
            Me.lblUsuarioVal.Size = New System.Drawing.Size(42, 20)
            Me.lblUsuarioVal.TabIndex = 4
            Me.lblUsuarioVal.Text = "Valor"
            '
            'lblMotivo
            '
            Me.lblMotivo.AutoSize = True
            Me.lblMotivo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblMotivo.ForeColor = System.Drawing.Color.Gray
            Me.lblMotivo.Location = New System.Drawing.Point(30, 190)
            Me.lblMotivo.Name = "lblMotivo"
            Me.lblMotivo.Size = New System.Drawing.Size(53, 15)
            Me.lblMotivo.TabIndex = 5
            Me.lblMotivo.Text = "MOTIVO"
            '
            'lblMotivoVal
            '
            Me.lblMotivoVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblMotivoVal.Location = New System.Drawing.Point(30, 208)
            Me.lblMotivoVal.Name = "lblMotivoVal"
            Me.lblMotivoVal.Size = New System.Drawing.Size(290, 50)
            Me.lblMotivoVal.TabIndex = 6
            Me.lblMotivoVal.Text = "Valor"
            '
            'txtMotivo
            '
            Me.txtMotivo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtMotivo.Location = New System.Drawing.Point(30, 208)
            Me.txtMotivo.Multiline = True
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.Size = New System.Drawing.Size(290, 50)
            Me.txtMotivo.TabIndex = 16
            Me.txtMotivo.Visible = False
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblDesde.ForeColor = System.Drawing.Color.Gray
            Me.lblDesde.Location = New System.Drawing.Point(30, 270)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(46, 15)
            Me.lblDesde.TabIndex = 7
            Me.lblDesde.Text = "DESDE"
            '
            'lblDesdeVal
            '
            Me.lblDesdeVal.AutoSize = True
            Me.lblDesdeVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblDesdeVal.Location = New System.Drawing.Point(30, 288)
            Me.lblDesdeVal.Name = "lblDesdeVal"
            Me.lblDesdeVal.Size = New System.Drawing.Size(42, 19)
            Me.lblDesdeVal.TabIndex = 8
            Me.lblDesdeVal.Text = "Valor"
            '
            'dtpInicio
            '
            Me.dtpInicio.CustomFormat = "dd/MM/yyyy"
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpInicio.Location = New System.Drawing.Point(30, 288)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(120, 23)
            Me.dtpInicio.TabIndex = 17
            Me.dtpInicio.Visible = False
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblHasta.ForeColor = System.Drawing.Color.Gray
            Me.lblHasta.Location = New System.Drawing.Point(180, 270)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(45, 15)
            Me.lblHasta.TabIndex = 9
            Me.lblHasta.Text = "HASTA"
            '
            'lblHastaVal
            '
            Me.lblHastaVal.AutoSize = True
            Me.lblHastaVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblHastaVal.Location = New System.Drawing.Point(180, 288)
            Me.lblHastaVal.Name = "lblHastaVal"
            Me.lblHastaVal.Size = New System.Drawing.Size(42, 19)
            Me.lblHastaVal.TabIndex = 10
            Me.lblHastaVal.Text = "Valor"
            '
            'dtpHasta
            '
            Me.dtpHasta.CustomFormat = "dd/MM/yyyy"
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHasta.Location = New System.Drawing.Point(180, 288)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(120, 23)
            Me.dtpHasta.TabIndex = 18
            Me.dtpHasta.Visible = False
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblTipo.ForeColor = System.Drawing.Color.Gray
            Me.lblTipo.Location = New System.Drawing.Point(30, 325)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(35, 15)
            Me.lblTipo.TabIndex = 11
            Me.lblTipo.Text = "TIPO"
            '
            'lblTipoVal
            '
            Me.lblTipoVal.AutoSize = True
            Me.lblTipoVal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblTipoVal.Location = New System.Drawing.Point(30, 343)
            Me.lblTipoVal.Name = "lblTipoVal"
            Me.lblTipoVal.Size = New System.Drawing.Size(42, 19)
            Me.lblTipoVal.TabIndex = 12
            Me.lblTipoVal.Text = "Valor"
            '
            'btnCerrar
            '
            Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
            Me.btnCerrar.FlatAppearance.BorderSize = 0
            Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnCerrar.ForeColor = System.Drawing.Color.White
            Me.btnCerrar.Location = New System.Drawing.Point(230, 410)
            Me.btnCerrar.Name = "btnCerrar"
            Me.btnCerrar.Size = New System.Drawing.Size(90, 35)
            Me.btnCerrar.TabIndex = 13
            Me.btnCerrar.Text = "Cerrar"
            Me.btnCerrar.UseVisualStyleBackColor = False
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnEliminar.ForeColor = System.Drawing.Color.White
            Me.btnEliminar.Location = New System.Drawing.Point(30, 410)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(90, 35)
            Me.btnEliminar.TabIndex = 14
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'btnModificar
            '
            Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(255, 193, 7)
            Me.btnModificar.FlatAppearance.BorderSize = 0
            Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnModificar.ForeColor = System.Drawing.Color.Black
            Me.btnModificar.Location = New System.Drawing.Point(130, 410)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 35)
            Me.btnModificar.TabIndex = 15
            Me.btnModificar.Text = "Modificar"
            Me.btnModificar.UseVisualStyleBackColor = False
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
            Me.btnGuardar.FlatAppearance.BorderSize = 0
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnGuardar.ForeColor = System.Drawing.Color.White
            Me.btnGuardar.Location = New System.Drawing.Point(130, 410)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(90, 35)
            Me.btnGuardar.TabIndex = 19
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.UseVisualStyleBackColor = False
            Me.btnGuardar.Visible = False
            '
            'FormDetalleReserva
            '
            Me.ClientSize = New System.Drawing.Size(350, 470)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.dtpHasta)
            Me.Controls.Add(Me.dtpInicio)
            Me.Controls.Add(Me.txtMotivo)
            Me.Controls.Add(Me.btnModificar)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.btnCerrar)
            Me.Controls.Add(Me.lblTipoVal)
            Me.Controls.Add(Me.lblTipo)
            Me.Controls.Add(Me.lblHastaVal)
            Me.Controls.Add(Me.lblHasta)
            Me.Controls.Add(Me.lblDesdeVal)
            Me.Controls.Add(Me.lblDesde)
            Me.Controls.Add(Me.lblMotivoVal)
            Me.Controls.Add(Me.lblMotivo)
            Me.Controls.Add(Me.lblUsuarioVal)
            Me.Controls.Add(Me.lblUsuario)
            Me.Controls.Add(Me.lblReservaVal)
            Me.Controls.Add(Me.lblReserva)
            Me.Controls.Add(Me.pnlHeader)
            Me.Name = "FormDetalleReserva"
            Me.pnlHeader.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents pnlHeader As Panel
        Friend WithEvents lblTitle As Label
        Friend WithEvents lblReserva As Label
        Friend WithEvents lblReservaVal As Label
        Friend WithEvents lblUsuario As Label
        Friend WithEvents lblUsuarioVal As Label
        Friend WithEvents lblMotivo As Label
        Friend WithEvents lblMotivoVal As Label
        Friend WithEvents lblDesde As Label
        Friend WithEvents lblDesdeVal As Label
        Friend WithEvents lblHasta As Label
        Friend WithEvents lblHastaVal As Label
        Friend WithEvents lblTipo As Label
        Friend WithEvents lblTipoVal As Label
        Friend WithEvents btnCerrar As Button
        Friend WithEvents btnEliminar As Button
         Friend WithEvents btnModificar As Button
         Friend WithEvents btnGuardar As Button
         Friend WithEvents txtMotivo As TextBox
         Friend WithEvents dtpInicio As DateTimePicker
         Friend WithEvents dtpHasta As DateTimePicker
     End Class
 End Namespace
