Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormListadoReservas
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
            Me.btnRefrescar = New System.Windows.Forms.Button()
            Me.pnlCalendarHeader = New System.Windows.Forms.Panel()
            Me.btnSiguiente = New System.Windows.Forms.Button()
            Me.btnAnterior = New System.Windows.Forms.Button()
            Me.lblMesActual = New System.Windows.Forms.Label()
            Me.tlpCalendario = New System.Windows.Forms.TableLayoutPanel()
            Me.pnlCalendarHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
            Me.lblTitle.Location = New System.Drawing.Point(40, 20)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(203, 30)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Calendario de Reservas"
            '
            'btnRefrescar
            '
            Me.btnRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
            Me.btnRefrescar.FlatAppearance.BorderSize = 0
            Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRefrescar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnRefrescar.ForeColor = System.Drawing.Color.White
            Me.btnRefrescar.Location = New System.Drawing.Point(540, 20)
            Me.btnRefrescar.Name = "btnRefrescar"
            Me.btnRefrescar.Size = New System.Drawing.Size(100, 30)
            Me.btnRefrescar.TabIndex = 2
            Me.btnRefrescar.Text = "Actualizar"
            Me.btnRefrescar.UseVisualStyleBackColor = False
            '
            'pnlCalendarHeader
            '
            Me.pnlCalendarHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlCalendarHeader.Controls.Add(Me.btnSiguiente)
            Me.pnlCalendarHeader.Controls.Add(Me.btnAnterior)
            Me.pnlCalendarHeader.Controls.Add(Me.lblMesActual)
            Me.pnlCalendarHeader.Location = New System.Drawing.Point(40, 60)
            Me.pnlCalendarHeader.Name = "pnlCalendarHeader"
            Me.pnlCalendarHeader.Size = New System.Drawing.Size(600, 40)
            Me.pnlCalendarHeader.TabIndex = 3
            '
            'btnSiguiente
            '
            Me.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnSiguiente.FlatAppearance.BorderSize = 0
            Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnSiguiente.Location = New System.Drawing.Point(560, 0)
            Me.btnSiguiente.Name = "btnSiguiente"
            Me.btnSiguiente.Size = New System.Drawing.Size(40, 40)
            Me.btnSiguiente.TabIndex = 2
            Me.btnSiguiente.Text = ">"
            Me.btnSiguiente.UseVisualStyleBackColor = True
            '
            'btnAnterior
            '
            Me.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAnterior.FlatAppearance.BorderSize = 0
            Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAnterior.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnAnterior.Location = New System.Drawing.Point(0, 0)
            Me.btnAnterior.Name = "btnAnterior"
            Me.btnAnterior.Size = New System.Drawing.Size(40, 40)
            Me.btnAnterior.TabIndex = 1
            Me.btnAnterior.Text = "<"
            Me.btnAnterior.UseVisualStyleBackColor = True
            '
            'lblMesActual
            '
            Me.lblMesActual.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblMesActual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblMesActual.Location = New System.Drawing.Point(0, 0)
            Me.lblMesActual.Name = "lblMesActual"
            Me.lblMesActual.Size = New System.Drawing.Size(600, 40)
            Me.lblMesActual.TabIndex = 0
            Me.lblMesActual.Text = "Marzo 2026"
            Me.lblMesActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tlpCalendario
            '
            Me.tlpCalendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tlpCalendario.ColumnCount = 7
            Me.tlpCalendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tlpCalendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tlpCalendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tlpCalendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tlpCalendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tlpCalendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tlpCalendario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tlpCalendario.Location = New System.Drawing.Point(40, 110)
            Me.tlpCalendario.Name = "tlpCalendario"
            Me.tlpCalendario.RowCount = 7
            Me.tlpCalendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.tlpCalendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.tlpCalendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.tlpCalendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.tlpCalendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.tlpCalendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.tlpCalendario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.tlpCalendario.Size = New System.Drawing.Size(600, 420)
            Me.tlpCalendario.TabIndex = 4
            '
            'FormListadoReservas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(680, 550)
            Me.Controls.Add(Me.tlpCalendario)
            Me.Controls.Add(Me.pnlCalendarHeader)
            Me.Controls.Add(Me.btnRefrescar)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "FormListadoReservas"
            Me.Text = "Listado de Reservas"
            Me.pnlCalendarHeader.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents btnRefrescar As Button
        Friend WithEvents pnlCalendarHeader As Panel
        Friend WithEvents btnSiguiente As Button
        Friend WithEvents btnAnterior As Button
        Friend WithEvents lblMesActual As Label
        Friend WithEvents tlpCalendario As TableLayoutPanel
    End Class
End Namespace
