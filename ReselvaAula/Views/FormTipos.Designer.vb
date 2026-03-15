Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormTipos
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
            Me.dgvTipos = New System.Windows.Forms.DataGridView()
            Me.panelAdd = New System.Windows.Forms.Panel()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.btnRefrescar = New System.Windows.Forms.Button()
            CType(Me.dgvTipos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelAdd.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(51, 36)
            Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(432, 45)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Gestión de Tipos de Recurso"
            '
            'dgvTipos
            '
            Me.dgvTipos.AllowUserToAddRows = False
            Me.dgvTipos.AllowUserToDeleteRows = False
            Me.dgvTipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvTipos.BackgroundColor = System.Drawing.Color.White
            Me.dgvTipos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTipos.Location = New System.Drawing.Point(51, 108)
            Me.dgvTipos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dgvTipos.Name = "dgvTipos"
            Me.dgvTipos.ReadOnly = True
            Me.dgvTipos.RowHeadersWidth = 62
            Me.dgvTipos.RowTemplate.Height = 25
            Me.dgvTipos.Size = New System.Drawing.Size(450, 504)
            Me.dgvTipos.TabIndex = 1
            '
            'panelAdd
            '
            Me.panelAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panelAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.panelAdd.Controls.Add(Me.btnLimpiar)
            Me.panelAdd.Controls.Add(Me.btnEliminar)
            Me.panelAdd.Controls.Add(Me.btnModificar)
            Me.panelAdd.Controls.Add(Me.btnGuardar)
            Me.panelAdd.Controls.Add(Me.txtNombre)
            Me.panelAdd.Controls.Add(Me.lblNombre)
            Me.panelAdd.Controls.Add(Me.lblSubtitle)
            Me.panelAdd.Location = New System.Drawing.Point(527, 108)
            Me.panelAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelAdd.Name = "panelAdd"
            Me.panelAdd.Padding = New System.Windows.Forms.Padding(26, 24, 26, 24)
            Me.panelAdd.Size = New System.Drawing.Size(296, 504)
            Me.panelAdd.TabIndex = 2
            '
            'btnLimpiar
            '
            Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.btnLimpiar.FlatAppearance.BorderSize = 0
            Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLimpiar.ForeColor = System.Drawing.Color.White
            Me.btnLimpiar.Location = New System.Drawing.Point(30, 340)
            Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(237, 42)
            Me.btnLimpiar.TabIndex = 8
            Me.btnLimpiar.Text = "Cancelar / Limpiar"
            Me.btnLimpiar.UseVisualStyleBackColor = False
            Me.btnLimpiar.Visible = False
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnEliminar.ForeColor = System.Drawing.Color.White
            Me.btnEliminar.Location = New System.Drawing.Point(30, 290)
            Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(237, 42)
            Me.btnEliminar.TabIndex = 7
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.UseVisualStyleBackColor = False
            Me.btnEliminar.Visible = False
            '
            'btnModificar
            '
            Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.btnModificar.FlatAppearance.BorderSize = 0
            Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnModificar.ForeColor = System.Drawing.Color.White
            Me.btnModificar.Location = New System.Drawing.Point(30, 241)
            Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(237, 42)
            Me.btnModificar.TabIndex = 6
            Me.btnModificar.Text = "Guardar Cambios"
            Me.btnModificar.UseVisualStyleBackColor = False
            Me.btnModificar.Visible = False
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.btnGuardar.FlatAppearance.BorderSize = 0
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnGuardar.ForeColor = System.Drawing.Color.White
            Me.btnGuardar.Location = New System.Drawing.Point(30, 192)
            Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(237, 42)
            Me.btnGuardar.TabIndex = 5
            Me.btnGuardar.Text = "Añadir Tipo"
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(30, 132)
            Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(235, 28)
            Me.txtNombre.TabIndex = 2
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Location = New System.Drawing.Point(30, 108)
            Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(62, 18)
            Me.lblNombre.TabIndex = 1
            Me.lblNombre.Text = "Nombre"
            '
            'lblSubtitle
            '
            Me.lblSubtitle.AutoSize = True
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblSubtitle.Location = New System.Drawing.Point(26, 24)
            Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(118, 28)
            Me.lblSubtitle.TabIndex = 0
            Me.lblSubtitle.Text = "Nuevo Tipo"
            '
            'btnRefrescar
            '
            Me.btnRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.btnRefrescar.FlatAppearance.BorderSize = 0
            Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRefrescar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.btnRefrescar.ForeColor = System.Drawing.Color.White
            Me.btnRefrescar.Location = New System.Drawing.Point(527, 36)
            Me.btnRefrescar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnRefrescar.Name = "btnRefrescar"
            Me.btnRefrescar.Size = New System.Drawing.Size(129, 36)
            Me.btnRefrescar.TabIndex = 3
            Me.btnRefrescar.Text = "Actualizar"
            Me.btnRefrescar.UseVisualStyleBackColor = False
            '
            'FormTipos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(874, 660)
            Me.Controls.Add(Me.btnRefrescar)
            Me.Controls.Add(Me.panelAdd)
            Me.Controls.Add(Me.dgvTipos)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "FormTipos"
            Me.Text = "Gestión de Tipos de Recurso"
            CType(Me.dgvTipos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelAdd.ResumeLayout(False)
            Me.panelAdd.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents dgvTipos As DataGridView
        Friend WithEvents panelAdd As Panel
        Friend WithEvents btnGuardar As Button
        Friend WithEvents btnModificar As Button
        Friend WithEvents btnEliminar As Button
        Friend WithEvents btnLimpiar As Button
        Friend WithEvents txtNombre As TextBox
        Friend WithEvents lblNombre As Label
        Friend WithEvents lblSubtitle As Label
        Friend WithEvents btnRefrescar As Button
    End Class
End Namespace
