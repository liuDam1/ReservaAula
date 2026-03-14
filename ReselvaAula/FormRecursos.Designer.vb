<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRecursos
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
        Me.dgvRecursos = New System.Windows.Forms.DataGridView()
        Me.panelAdd = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
        Me.lblTitle.Location = New System.Drawing.Point(40, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Gestión de Recursos"
        '
        'dgvRecursos
        '
        Me.dgvRecursos.AllowUserToAddRows = False
        Me.dgvRecursos.AllowUserToDeleteRows = False
        Me.dgvRecursos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecursos.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecursos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecursos.Location = New System.Drawing.Point(40, 90)
        Me.dgvRecursos.Name = "dgvRecursos"
        Me.dgvRecursos.ReadOnly = True
        Me.dgvRecursos.RowTemplate.Height = 25
        Me.dgvRecursos.Size = New System.Drawing.Size(350, 420)
        Me.dgvRecursos.TabIndex = 1
        '
        'panelAdd
        '
        Me.panelAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelAdd.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.panelAdd.Controls.Add(Me.btnGuardar)
        Me.panelAdd.Controls.Add(Me.cboTipo)
        Me.panelAdd.Controls.Add(Me.lblTipo)
        Me.panelAdd.Controls.Add(Me.txtNombre)
        Me.panelAdd.Controls.Add(Me.lblNombre)
        Me.panelAdd.Controls.Add(Me.lblSubtitle)
        Me.panelAdd.Location = New System.Drawing.Point(410, 90)
        Me.panelAdd.Name = "panelAdd"
        Me.panelAdd.Padding = New System.Windows.Forms.Padding(20)
        Me.panelAdd.Size = New System.Drawing.Size(230, 420)
        Me.panelAdd.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(23, 190)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(184, 35)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Añadir Recurso"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Aula", "Carrito", "Laboratorio", "Otro"})
        Me.cboTipo.Location = New System.Drawing.Point(23, 140)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(184, 23)
        Me.cboTipo.TabIndex = 4
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(23, 120)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 15)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(23, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(184, 23)
        Me.txtNombre.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(23, 60)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 15)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtitle.Location = New System.Drawing.Point(20, 20)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(100, 19)
        Me.lblSubtitle.TabIndex = 0
        Me.lblSubtitle.Text = "Nuevo Recurso"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnRefrescar.FlatAppearance.BorderSize = 0
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefrescar.ForeColor = System.Drawing.Color.White
        Me.btnRefrescar.Location = New System.Drawing.Point(290, 30)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(100, 30)
        Me.btnRefrescar.TabIndex = 3
        Me.btnRefrescar.Text = "Actualizar"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'FormRecursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 550)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.panelAdd)
        Me.Controls.Add(Me.dgvRecursos)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRecursos"
        Me.Text = "Gestión de Recursos"
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAdd.ResumeLayout(False)
        Me.panelAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvRecursos As DataGridView
    Friend WithEvents panelAdd As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnRefrescar As Button
End Class
