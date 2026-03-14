<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReserva
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRecurso = New System.Windows.Forms.Label()
        Me.cboRecursos = New System.Windows.Forms.ComboBox()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
        Me.lblTitle.Location = New System.Drawing.Point(40, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(161, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Nueva Reserva"
        '
        'lblRecurso
        '
        Me.lblRecurso.AutoSize = True
        Me.lblRecurso.Location = New System.Drawing.Point(45, 90)
        Me.lblRecurso.Name = "lblRecurso"
        Me.lblRecurso.Size = New System.Drawing.Size(49, 15)
        Me.lblRecurso.TabIndex = 1
        Me.lblRecurso.Text = "Recurso"
        '
        'cboRecursos
        '
        Me.cboRecursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecursos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboRecursos.Location = New System.Drawing.Point(45, 110)
        Me.cboRecursos.Name = "cboRecursos"
        Me.cboRecursos.Size = New System.Drawing.Size(350, 25)
        Me.cboRecursos.TabIndex = 2
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(45, 160)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(70, 15)
        Me.lblFechaInicio.TabIndex = 3
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(45, 180)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(200, 23)
        Me.dtpFechaInicio.TabIndex = 4
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(45, 230)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 15)
        Me.lblFechaFin.TabIndex = 5
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(45, 250)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 23)
        Me.dtpFechaFin.TabIndex = 6
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(45, 300)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(45, 15)
        Me.lblMotivo.TabIndex = 7
        Me.lblMotivo.Text = "Motivo"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(45, 320)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(500, 80)
        Me.txtMotivo.TabIndex = 8
        '
        'btnReservar
        '
        Me.btnReservar.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnReservar.FlatAppearance.BorderSize = 0
        Me.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReservar.ForeColor = System.Drawing.Color.White
        Me.btnReservar.Location = New System.Drawing.Point(45, 430)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(200, 40)
        Me.btnReservar.TabIndex = 9
        Me.btnReservar.Text = "Crear Reserva"
        Me.btnReservar.UseVisualStyleBackColor = False
        '
        'FormReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 550)
        Me.Controls.Add(Me.btnReservar)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.cboRecursos)
        Me.Controls.Add(Me.lblRecurso)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReserva"
        Me.Text = "Nueva Reserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRecurso As Label
    Friend WithEvents cboRecursos As ComboBox
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblMotivo As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents btnReservar As Button
End Class
