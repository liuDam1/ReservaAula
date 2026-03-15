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
            Me.txtRepeatPassword = New System.Windows.Forms.TextBox()
            Me.lblRepeatPassword = New System.Windows.Forms.Label()
            Me.chkShowPassword = New System.Windows.Forms.CheckBox()
            Me.lblSwitch = New System.Windows.Forms.Label()
            Me.btnAction = New System.Windows.Forms.Button()
            Me.txtDepartamento = New System.Windows.Forms.TextBox()
            Me.lblDepartamento = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.lblEmail = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.lblUsuario = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.panelContainer.SuspendLayout()
            Me.SuspendLayout()
            '
            'panelContainer
            '
            Me.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.panelContainer.BackColor = System.Drawing.Color.White
            Me.panelContainer.Controls.Add(Me.txtRepeatPassword)
            Me.panelContainer.Controls.Add(Me.chkShowPassword)
            Me.panelContainer.Controls.Add(Me.lblSwitch)
            Me.panelContainer.Controls.Add(Me.btnAction)
            Me.panelContainer.Controls.Add(Me.txtDepartamento)
            Me.panelContainer.Controls.Add(Me.lblDepartamento)
            Me.panelContainer.Controls.Add(Me.txtEmail)
            Me.panelContainer.Controls.Add(Me.lblEmail)
            Me.panelContainer.Controls.Add(Me.txtPassword)
            Me.panelContainer.Controls.Add(Me.lblPassword)
            Me.panelContainer.Controls.Add(Me.txtUsuario)
            Me.panelContainer.Controls.Add(Me.lblUsuario)
            Me.panelContainer.Controls.Add(Me.lblTitle)
            Me.panelContainer.Controls.Add(Me.lblRepeatPassword)
            Me.panelContainer.Location = New System.Drawing.Point(110, 57)
            Me.panelContainer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelContainer.Name = "panelContainer"
            Me.panelContainer.Padding = New System.Windows.Forms.Padding(39, 36, 39, 36)
            Me.panelContainer.Size = New System.Drawing.Size(514, 672)
            Me.panelContainer.TabIndex = 0
            '
            'txtRepeatPassword
            '
            Me.txtRepeatPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.txtRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtRepeatPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtRepeatPassword.Location = New System.Drawing.Point(51, 294)
            Me.txtRepeatPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtRepeatPassword.Name = "txtRepeatPassword"
            Me.txtRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
            Me.txtRepeatPassword.Size = New System.Drawing.Size(411, 37)
            Me.txtRepeatPassword.TabIndex = 13
            Me.txtRepeatPassword.Visible = False
            '
            'lblRepeatPassword
            '
            Me.lblRepeatPassword.AutoSize = True
            Me.lblRepeatPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblRepeatPassword.Location = New System.Drawing.Point(51, 270)
            Me.lblRepeatPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblRepeatPassword.Name = "lblRepeatPassword"
            Me.lblRepeatPassword.Size = New System.Drawing.Size(175, 25)
            Me.lblRepeatPassword.TabIndex = 12
            Me.lblRepeatPassword.Text = "Repetir Contraseña"
            Me.lblRepeatPassword.Visible = False
            '
            'chkShowPassword
            '
            Me.chkShowPassword.AutoSize = True
            Me.chkShowPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.chkShowPassword.Location = New System.Drawing.Point(51, 336)
            Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.chkShowPassword.Name = "chkShowPassword"
            Me.chkShowPassword.Size = New System.Drawing.Size(184, 27)
            Me.chkShowPassword.TabIndex = 11
            Me.chkShowPassword.Text = "Mostrar contraseña"
            Me.chkShowPassword.UseVisualStyleBackColor = True
            '
            'lblSwitch
            '
            Me.lblSwitch.AutoSize = True
            Me.lblSwitch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblSwitch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblSwitch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(206, Byte), Integer))
            Me.lblSwitch.Location = New System.Drawing.Point(51, 612)
            Me.lblSwitch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblSwitch.Name = "lblSwitch"
            Me.lblSwitch.Size = New System.Drawing.Size(264, 25)
            Me.lblSwitch.TabIndex = 10
            Me.lblSwitch.Text = "¿No tienes cuenta? Regístrate"
            '
            'btnAction
            '
            Me.btnAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(206, Byte), Integer))
            Me.btnAction.FlatAppearance.BorderSize = 0
            Me.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAction.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnAction.ForeColor = System.Drawing.Color.White
            Me.btnAction.Location = New System.Drawing.Point(51, 540)
            Me.btnAction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnAction.Name = "btnAction"
            Me.btnAction.Size = New System.Drawing.Size(411, 54)
            Me.btnAction.TabIndex = 9
            Me.btnAction.Text = "Iniciar Sesión"
            Me.btnAction.UseVisualStyleBackColor = False
            '
            'txtDepartamento
            '
            Me.txtDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDepartamento.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtDepartamento.Location = New System.Drawing.Point(51, 468)
            Me.txtDepartamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtDepartamento.Name = "txtDepartamento"
            Me.txtDepartamento.Size = New System.Drawing.Size(411, 37)
            Me.txtDepartamento.TabIndex = 8
            Me.txtDepartamento.Visible = False
            '
            'lblDepartamento
            '
            Me.lblDepartamento.AutoSize = True
            Me.lblDepartamento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblDepartamento.Location = New System.Drawing.Point(51, 444)
            Me.lblDepartamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblDepartamento.Name = "lblDepartamento"
            Me.lblDepartamento.Size = New System.Drawing.Size(136, 25)
            Me.lblDepartamento.TabIndex = 7
            Me.lblDepartamento.Text = "Departamento"
            Me.lblDepartamento.Visible = False
            '
            'txtEmail
            '
            Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtEmail.Location = New System.Drawing.Point(51, 396)
            Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(411, 37)
            Me.txtEmail.TabIndex = 6
            Me.txtEmail.Visible = False
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblEmail.Location = New System.Drawing.Point(51, 372)
            Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(58, 25)
            Me.lblEmail.TabIndex = 5
            Me.lblEmail.Text = "Email"
            Me.lblEmail.Visible = False
            '
            'txtPassword
            '
            Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtPassword.Location = New System.Drawing.Point(51, 222)
            Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
            Me.txtPassword.Size = New System.Drawing.Size(411, 37)
            Me.txtPassword.TabIndex = 4
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblPassword.Location = New System.Drawing.Point(51, 198)
            Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(108, 25)
            Me.lblPassword.TabIndex = 3
            Me.lblPassword.Text = "Contraseña"
            '
            'txtUsuario
            '
            Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!)
            Me.txtUsuario.Location = New System.Drawing.Point(51, 144)
            Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.Size = New System.Drawing.Size(411, 37)
            Me.txtUsuario.TabIndex = 2
            '
            'lblUsuario
            '
            Me.lblUsuario.AutoSize = True
            Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblUsuario.Location = New System.Drawing.Point(51, 120)
            Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblUsuario.Name = "lblUsuario"
            Me.lblUsuario.Size = New System.Drawing.Size(77, 25)
            Me.lblUsuario.TabIndex = 1
            Me.lblUsuario.Text = "Usuario"
            '
            'lblTitle
            '
            Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Location = New System.Drawing.Point(39, 36)
            Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(436, 72)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Bienvenido"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FormLogin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(748, 810)
            Me.Controls.Add(Me.panelContainer)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Friend WithEvents lblUsuario As Label
        Friend WithEvents txtUsuario As TextBox
        Friend WithEvents chkShowPassword As CheckBox
        Friend WithEvents lblPassword As Label
        Friend WithEvents txtPassword As TextBox
        Friend WithEvents lblRepeatPassword As Label
        Friend WithEvents txtRepeatPassword As TextBox
        Friend WithEvents lblEmail As Label
        Friend WithEvents txtEmail As TextBox
        Friend WithEvents lblDepartamento As Label
        Friend WithEvents txtDepartamento As TextBox
        Friend WithEvents btnAction As Button
        Friend WithEvents lblSwitch As Label
    End Class
End Namespace
