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
            ' Configuración inicial de UI moderna
            Me.BackColor = Color.FromArgb(240, 244, 248)
            ' ... etc ...
            panelContainer.BackColor = Color.White
            btnAction.BackColor = Color.FromArgb(0, 102, 204)
            btnAction.ForeColor = Color.White
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41)
            
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
                txtNombre.Visible = True
                txtDepartamento.Visible = True
                lblNombre.Visible = True
                lblDepartamento.Visible = True
            Else
                lblTitle.Text = "Bienvenido"
                btnAction.Text = "Iniciar Sesión"
                lblSwitch.Text = "¿No tienes cuenta? Regístrate"
                txtNombre.Visible = False
                txtDepartamento.Visible = False
                lblNombre.Visible = False
                lblDepartamento.Visible = False
            End If
        End Sub

        Private Async Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
            Dim email = txtEmail.Text.Trim()
            Dim password = txtPassword.Text.Trim()

            If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
                MsgBox("Por favor completa los campos obligatorios")
                Return
            End If

            If _isRegistering Then
                Dim nombre = txtNombre.Text.Trim()
                Dim depto = txtDepartamento.Text.Trim()
                If Await _authService.Registrar(nombre, password, depto, email) Then
                    MsgBox("Registro exitoso. Ahora puedes iniciar sesión.")
                    lblSwitch_Click(Nothing, Nothing)
                End If
            Else
                Dim usuario = Await _authService.IniciarSesion(email, password)
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
    End Class
End Namespace
