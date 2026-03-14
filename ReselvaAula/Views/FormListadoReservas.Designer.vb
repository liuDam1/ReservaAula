Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormListadoReservas
        Inherits System.Windows.Forms.Form
        ' ... rest of designer code ...
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
            Me.dgvReservas = New System.Windows.Forms.DataGridView()
            Me.btnRefrescar = New System.Windows.Forms.Button()
            CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
            Me.lblTitle.Location = New System.Drawing.Point(40, 30)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(203, 30)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Todas las Reservas"
            '
            'dgvReservas
            '
            Me.dgvReservas.AllowUserToAddRows = False
            Me.dgvReservas.AllowUserToDeleteRows = False
            Me.dgvReservas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvReservas.BackgroundColor = System.Drawing.Color.White
            Me.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvReservas.Location = New System.Drawing.Point(40, 90)
            Me.dgvReservas.Name = "dgvReservas"
            Me.dgvReservas.ReadOnly = True
            Me.dgvReservas.RowTemplate.Height = 25
            Me.dgvReservas.Size = New System.Drawing.Size(600, 400)
            Me.dgvReservas.TabIndex = 1
            '
            'btnRefrescar
            '
            Me.btnRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
            Me.btnRefrescar.FlatAppearance.BorderSize = 0
            Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRefrescar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnRefrescar.ForeColor = System.Drawing.Color.White
            Me.btnRefrescar.Location = New System.Drawing.Point(540, 30)
            Me.btnRefrescar.Name = "btnRefrescar"
            Me.btnRefrescar.Size = New System.Drawing.Size(100, 30)
            Me.btnRefrescar.TabIndex = 2
            Me.btnRefrescar.Text = "Actualizar"
            Me.btnRefrescar.UseVisualStyleBackColor = False
            '
            'FormListadoReservas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(680, 550)
            Me.Controls.Add(Me.btnRefrescar)
            Me.Controls.Add(Me.dgvReservas)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "FormListadoReservas"
            Me.Text = "Listado de Reservas"
            CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents dgvReservas As DataGridView
        Friend WithEvents btnRefrescar As Button
    End Class
End Namespace
