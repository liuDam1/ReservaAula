Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormMain
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
            Me.panelSidebar = New System.Windows.Forms.Panel()
            Me.btnLogout = New System.Windows.Forms.Button()
            Me.btnVerReservas = New System.Windows.Forms.Button()
            Me.btnGestionRecursos = New System.Windows.Forms.Button()
            Me.btnNuevaReserva = New System.Windows.Forms.Button()
            Me.panelUser = New System.Windows.Forms.Panel()
            Me.lblDepto = New System.Windows.Forms.Label()
            Me.lblBienvenido = New System.Windows.Forms.Label()
            Me.panelContent = New System.Windows.Forms.Panel()
            Me.panelSidebar.SuspendLayout()
            Me.panelUser.SuspendLayout()
            Me.SuspendLayout()
            '
            'panelSidebar
            '
            Me.panelSidebar.BackColor = System.Drawing.Color.FromArgb(33, 37, 41)
            Me.panelSidebar.Controls.Add(Me.btnLogout)
            Me.panelSidebar.Controls.Add(Me.btnVerReservas)
            Me.panelSidebar.Controls.Add(Me.btnGestionRecursos)
            Me.panelSidebar.Controls.Add(Me.btnNuevaReserva)
            Me.panelSidebar.Controls.Add(Me.panelUser)
            Me.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelSidebar.Location = New System.Drawing.Point(0, 0)
            Me.panelSidebar.Name = "panelSidebar"
            Me.panelSidebar.Size = New System.Drawing.Size(220, 600)
            Me.panelSidebar.TabIndex = 0
            '
            'btnLogout
            '
            Me.btnLogout.BackColor = System.Drawing.Color.Transparent
            Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.btnLogout.FlatAppearance.BorderSize = 0
            Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 53, 69)
            Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(0, 550)
            Me.btnLogout.Name = "btnLogout"
            Me.btnLogout.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
            Me.btnLogout.Size = New System.Drawing.Size(220, 50)
            Me.btnLogout.TabIndex = 3
            Me.btnLogout.Text = "Cerrar Sesión"
            Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLogout.UseVisualStyleBackColor = False
            '
            'btnVerReservas
            '
            Me.btnVerReservas.BackColor = System.Drawing.Color.Transparent
            Me.btnVerReservas.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnVerReservas.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnVerReservas.FlatAppearance.BorderSize = 0
            Me.btnVerReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(73, 80, 87)
            Me.btnVerReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnVerReservas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnVerReservas.ForeColor = System.Drawing.Color.White
            Me.btnVerReservas.Location = New System.Drawing.Point(0, 100)
            Me.btnVerReservas.Name = "btnVerReservas"
            Me.btnVerReservas.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
            Me.btnVerReservas.Size = New System.Drawing.Size(220, 50)
            Me.btnVerReservas.TabIndex = 2
            Me.btnVerReservas.Text = "Toda las reservas"
            Me.btnVerReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVerReservas.UseVisualStyleBackColor = False
            '
            'btnGestionRecursos
            '
            Me.btnGestionRecursos.BackColor = System.Drawing.Color.Transparent
            Me.btnGestionRecursos.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGestionRecursos.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnGestionRecursos.FlatAppearance.BorderSize = 0
            Me.btnGestionRecursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(73, 80, 87)
            Me.btnGestionRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGestionRecursos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnGestionRecursos.ForeColor = System.Drawing.Color.White
            Me.btnGestionRecursos.Location = New System.Drawing.Point(0, 200)
            Me.btnGestionRecursos.Name = "btnGestionRecursos"
            Me.btnGestionRecursos.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
            Me.btnGestionRecursos.Size = New System.Drawing.Size(220, 50)
            Me.btnGestionRecursos.TabIndex = 4
            Me.btnGestionRecursos.Text = "Gestión de Recursos"
            Me.btnGestionRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGestionRecursos.UseVisualStyleBackColor = False
            '
            'btnNuevaReserva
            '
            Me.btnNuevaReserva.BackColor = System.Drawing.Color.Transparent
            Me.btnNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNuevaReserva.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNuevaReserva.FlatAppearance.BorderSize = 0
            Me.btnNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(73, 80, 87)
            Me.btnNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNuevaReserva.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.btnNuevaReserva.ForeColor = System.Drawing.Color.White
            Me.btnNuevaReserva.Location = New System.Drawing.Point(0, 150)
            Me.btnNuevaReserva.Name = "btnNuevaReserva"
            Me.btnNuevaReserva.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
            Me.btnNuevaReserva.Size = New System.Drawing.Size(220, 50)
            Me.btnNuevaReserva.TabIndex = 1
            Me.btnNuevaReserva.Text = "Nueva Reserva"
            Me.btnNuevaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevaReserva.UseVisualStyleBackColor = False
            '
            'panelUser
            '
            Me.panelUser.Controls.Add(Me.lblDepto)
            Me.panelUser.Controls.Add(Me.lblBienvenido)
            Me.panelUser.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelUser.Location = New System.Drawing.Point(0, 0)
            Me.panelUser.Name = "panelUser"
            Me.panelUser.Size = New System.Drawing.Size(220, 100)
            Me.panelUser.TabIndex = 0
            '
            'lblDepto
            '
            Me.lblDepto.AutoSize = True
            Me.lblDepto.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblDepto.ForeColor = System.Drawing.Color.FromArgb(173, 181, 189)
            Me.lblDepto.Location = New System.Drawing.Point(15, 55)
            Me.lblDepto.Name = "lblDepto"
            Me.lblDepto.Size = New System.Drawing.Size(81, 13)
            Me.lblDepto.TabIndex = 1
            Me.lblDepto.Text = "Departamento"
            '
            'lblBienvenido
            '
            Me.lblBienvenido.AutoSize = True
            Me.lblBienvenido.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblBienvenido.ForeColor = System.Drawing.Color.White
            Me.lblBienvenido.Location = New System.Drawing.Point(15, 30)
            Me.lblBienvenido.Name = "lblBienvenido"
            Me.lblBienvenido.Size = New System.Drawing.Size(78, 19)
            Me.lblBienvenido.TabIndex = 0
            Me.lblBienvenido.Text = "Hola, User"
            '
            'panelContent
            '
            Me.panelContent.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
            Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelContent.Location = New System.Drawing.Point(220, 0)
            Me.panelContent.Name = "panelContent"
            Me.panelContent.Size = New System.Drawing.Size(680, 600)
            Me.panelContent.TabIndex = 1
            '
            'FormMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(900, 600)
            Me.Controls.Add(Me.panelContent)
            Me.Controls.Add(Me.panelSidebar)
            Me.MinimumSize = New System.Drawing.Size(900, 600)
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sistema de Reserva de Recursos"
            Me.panelSidebar.ResumeLayout(False)
            Me.panelUser.ResumeLayout(False)
            Me.panelUser.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents panelSidebar As Panel
        Friend WithEvents btnLogout As Button
        Friend WithEvents btnVerReservas As Button
        Friend WithEvents btnGestionRecursos As Button
        Friend WithEvents btnNuevaReserva As Button
        Friend WithEvents panelUser As Panel
        Friend WithEvents lblDepto As Label
        Friend WithEvents lblBienvenido As Label
        Friend WithEvents panelContent As Panel
    End Class
End Namespace
