Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormLogin
        Inherits System.Windows.Forms.Form

        ' Form reemplaza a Dispose para limpiar la lista de componentes.
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

        ' Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        ' NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        ' Se puede modificar usando el Diseñador de Windows Forms.  
        ' No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.panelContainer = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblEmail = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.lblDepartamento = New System.Windows.Forms.Label()
            Me.txtDepartamento = New System.Windows.Forms.TextBox()
            Me.btnAction = New System.Windows.Forms.Button()
            Me.lblSwitch = New System.Windows.Forms.Label()
            Me.panelContainer.SuspendLayout()
            Me.SuspendLayout()
            '
            'panelContainer
            '
            Me.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.panelContainer.BackColor = System.Drawing.Color.White
            Me.panelContainer.Controls.Add(Me.lblSwitch)
            Me.panelContainer.Controls.Add(Me.btnAction)
            Me.panelContainer.Controls.Add(Me.txtDepartamento)
            Me.panelContainer.Controls.Add(Me.lblDepartamento)
            Me.panelContainer.Controls.Add(Me.txtNombre)
            Me.panelContainer.Controls.Add(Me.lblNombre)
            Me.panelContainer.Controls.Add(Me.txtPassword)
            Me.panelContainer.Controls.Add(Me.lblPassword)
            Me.panelContainer.Controls.Add(Me.txtEmail)
            Me.panelContainer.Controls.Add(Me.lblEmail)
            Me.panelContainer.Controls.Add(Me.lblTitle)
            Me.panelContainer.Location = New System.Drawing.Point(50, 40)
            Me.panelContainer.Name = "panelContainer"
            Me.panelContainer.Padding = New System.Windows.Forms.Padding(30)
            Me.panelContainer.Size = New System.Drawing.Size(350, 480)
            Me.panelContainer.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.lblTitle.Location = New System.Drawing.Point(30, 30)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(290, 50)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Bienvenido"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblEmail.Location = New System.Drawing.Point(30, 95)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(39, 15)
            Me.lblEmail.TabIndex = 1
            Me.lblEmail.Text = "Email"
            '
            'txtEmail
            '
            Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtEmail.Location = New System.Drawing.Point(30, 115)
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(290, 27)
            Me.txtEmail.TabIndex = 2
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblPassword.Location = New System.Drawing.Point(30, 155)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(70, 15)
            Me.lblPassword.TabIndex = 3
            Me.lblPassword.Text = "Contraseña"
            '
            'txtPassword
            '
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtPassword.Location = New System.Drawing.Point(30, 175)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
            Me.txtPassword.Size = New System.Drawing.Size(290, 27)
            Me.txtPassword.TabIndex = 4
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblNombre.Location = New System.Drawing.Point(30, 215)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(54, 15)
            Me.lblNombre.TabIndex = 5
            Me.lblNombre.Text = "Nombre"
            Me.lblNombre.Visible = False
            '
            'txtNombre
            '
            Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtNombre.Location = New System.Drawing.Point(30, 235)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(290, 27)
            Me.txtNombre.TabIndex = 6
            Me.txtNombre.Visible = False
            '
            'lblDepartamento
            '
            Me.lblDepartamento.AutoSize = True
            Me.lblDepartamento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.lblDepartamento.Location = New System.Drawing.Point(30, 275)
            Me.lblDepartamento.Name = "lblDepartamento"
            Me.lblDepartamento.Size = New System.Drawing.Size(86, 15)
            Me.lblDepartamento.TabIndex = 7
            Me.lblDepartamento.Text = "Departamento"
            Me.lblDepartamento.Visible = False
            '
            'txtDepartamento
            '
            Me.txtDepartamento.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.txtDepartamento.Location = New System.Drawing.Point(30, 295)
            Me.txtDepartamento.Name = "txtDepartamento"
            Me.txtDepartamento.Size = New System.Drawing.Size(290, 27)
            Me.txtDepartamento.TabIndex = 8
            Me.txtDepartamento.Visible = False
            '
            'btnAction
            '
            Me.btnAction.BackColor = System.Drawing.Color.FromArgb(0, 102, 204)
            Me.btnAction.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAction.FlatAppearance.BorderSize = 0
            Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAction.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.btnAction.ForeColor = System.Drawing.Color.White
            Me.btnAction.Location = New System.Drawing.Point(30, 360)
            Me.btnAction.Name = "btnAction"
            Me.btnAction.Size = New System.Drawing.Size(290, 40)
            Me.btnAction.TabIndex = 9
            Me.btnAction.Text = "Iniciar Sesión"
            Me.btnAction.UseVisualStyleBackColor = False
            '
            'lblSwitch
            '
            Me.lblSwitch.AutoSize = True
            Me.lblSwitch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSwitch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
            Me.lblSwitch.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204)
            Me.lblSwitch.Location = New System.Drawing.Point(30, 415)
            Me.lblSwitch.Name = "lblSwitch"
            Me.lblSwitch.Size = New System.Drawing.Size(168, 15)
            Me.lblSwitch.TabIndex = 10
            Me.lblSwitch.Text = "¿No tienes cuenta? Regístrate"
            '
            'FormLogin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(240, 244, 248)
            Me.ClientSize = New System.Drawing.Size(450, 560)
            Me.Controls.Add(Me.panelContainer)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "FormLogin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Reserva Aula - Acceso"
            Me.panelContainer.ResumeLayout(False)
            Me.panelContainer.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents panelContainer As Panel
        Friend WithEvents lblTitle As Label
        Friend WithEvents lblEmail As Label
        Friend WithEvents txtEmail As TextBox
        Friend WithEvents lblPassword As Label
        Friend WithEvents txtPassword As TextBox
        Friend WithEvents lblNombre As Label
        Friend WithEvents txtNombre As TextBox
        Friend WithEvents lblDepartamento As Label
        Friend WithEvents txtDepartamento As TextBox
        Friend WithEvents btnAction As Button
        Friend WithEvents lblSwitch As Label
    End Class
End Namespace
