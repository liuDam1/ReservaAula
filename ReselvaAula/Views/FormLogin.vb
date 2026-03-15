Imports System.Threading.Tasks
Imports Supabase.Postgrest
Imports ReselvaAula.Controllers
Imports ReselvaAula.Models

Namespace Views
    Public Class FormLogin
        Private _client As Client
        Private _authService As AuthService
        ' ... rest of the code ...
        Private _isRegistering As Boolean = False

        Public Sub New()
            InitializeComponent()
            ' Configuración inicial de UI moderna y elegante
            Me.BackColor = Color.FromArgb(242, 245, 249) ' Fondo suave
            Me.Text = "Reserva Aula - Acceso"
            
            panelContainer.BackColor = Color.White
            panelContainer.BorderStyle = BorderStyle.None ' Quitamos el borde para usar una sombra o estilo más limpio
            
            ' Título
            lblTitle.ForeColor = Color.FromArgb(45, 55, 72)
            lblTitle.Font = New Font("Segoe UI Semibold", 22.0!, FontStyle.Bold)
            
            ' Etiquetas
            Dim labels = {lblUsuario, lblPassword, lblRepeatPassword, lblEmail, lblDepartamento}
            For Each lbl In labels
                lbl.ForeColor = Color.FromArgb(74, 85, 104)
                lbl.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
            Next
            
            ' Campos de texto (estilo moderno)
            Dim textboxes = {txtUsuario, txtPassword, txtRepeatPassword, txtEmail, txtDepartamento}
            For Each txt In textboxes
                txt.BackColor = Color.FromArgb(247, 250, 252)
                txt.BorderStyle = BorderStyle.FixedSingle
                txt.Font = New Font("Segoe UI", 10.5!)
            Next
            
            ' Botón Principal (Azul Profundo con bordes redondeados simulados por flatstyle)
            btnAction.BackColor = Color.FromArgb(49, 130, 206)
            btnAction.ForeColor = Color.White
            btnAction.FlatStyle = FlatStyle.Flat
            btnAction.FlatAppearance.BorderSize = 0
            btnAction.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
            btnAction.Cursor = Cursors.Hand
            
            ' Enlace inferior
            lblSwitch.ForeColor = Color.FromArgb(49, 130, 206)
            lblSwitch.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold Or FontStyle.Underline)
            
            ' Inicializar Supabase
            Try
                Dim options = New ClientOptions()
                options.Headers.Add("apikey", AppConfig.SupabaseKey)
                options.Headers.Add("Authorization", $"Bearer {AppConfig.SupabaseKey}")
                _client = New Client($"{AppConfig.SupabaseUrl}/rest/v1", options)
                _authService = New AuthService(_client)
            Catch ex As Exception
                MsgBox("Error de conexión: " & ex.Message)
            End Try
        End Sub

        Private Sub lblSwitch_Click(sender As Object, e As EventArgs) Handles lblSwitch.Click
            _isRegistering = Not _isRegistering
            If _isRegistering Then
                lblTitle.Text = "Crear Cuenta"
                btnAction.Text = "Registrar"
                lblSwitch.Text = "¿Ya tienes cuenta? Inicia sesión"
                txtEmail.Visible = True
                lblEmail.Visible = True
                txtDepartamento.Visible = True
                lblDepartamento.Visible = True
                lblRepeatPassword.Visible = True
                txtRepeatPassword.Visible = True
                
                lblUsuario.Text = "Nombre de Usuario"
            Else
                lblTitle.Text = "Bienvenido"
                btnAction.Text = "Iniciar Sesión"
                lblSwitch.Text = "¿No tienes cuenta? Regístrate"
                txtEmail.Visible = False
                lblEmail.Visible = False
                txtDepartamento.Visible = False
                lblDepartamento.Visible = False
                lblRepeatPassword.Visible = False
                txtRepeatPassword.Visible = False
                
                lblUsuario.Text = "Usuario"
            End If
        End Sub

        Private Async Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
            Dim usuarioStr = txtUsuario.Text.Trim()
            Dim password = txtPassword.Text.Trim()

            If String.IsNullOrEmpty(usuarioStr) OrElse String.IsNullOrEmpty(password) Then
                MsgBox("Por favor completa los campos obligatorios")
                Return
            End If

            If _isRegistering Then
                Dim repeatPassword = txtRepeatPassword.Text.Trim()
                If password <> repeatPassword Then
                    MsgBox("Las contraseñas no coinciden")
                    Return
                End If

                Dim email = txtEmail.Text.Trim()
                Dim depto = txtDepartamento.Text.Trim()
                If Await _authService.Registrar(usuarioStr, password, depto, email) Then
                    MsgBox("Registro exitoso. Ahora puedes iniciar sesión.")
                    lblSwitch_Click(Nothing, Nothing)
                End If
            Else
                Dim usuario = Await _authService.IniciarSesion(usuarioStr, password)
                If usuario IsNot Nothing Then
                    ' Guardar usuario global o pasar a FormMain
                    Dim mainForm = New FormMain(usuario, _client)
                    mainForm.Show()
                    Me.Hide()
                Else
                    MsgBox("Credenciales incorrectas")
                End If
            End If
        End Sub

        Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
            If chkShowPassword.Checked Then
                txtPassword.PasswordChar = ControlChars.NullChar
                txtRepeatPassword.PasswordChar = ControlChars.NullChar
            Else
                txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
                txtRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
            End If
        End Sub
    End Class
End Namespace
