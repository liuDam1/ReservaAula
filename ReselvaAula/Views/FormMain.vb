Imports Supabase.Postgrest
Imports ReselvaAula.Models

Namespace Views
    Public Class FormMain
        Private _usuario As Usuario
        Private _client As Client

        Public Sub New(usuario As Usuario, client As Client)
            InitializeComponent()
            _usuario = usuario
            _client = client
            
            lblBienvenido.Text = $"Hola, {_usuario.Nombre}"
            lblDepto.Text = _usuario.Departamento
        End Sub

        Private Sub btnNuevaReserva_Click(sender As Object, e As EventArgs) Handles btnNuevaReserva.Click
            AbrirFormularioHijo(New FormReserva(_usuario, _client))
        End Sub

        Private Sub btnVerReservas_Click(sender As Object, e As EventArgs) Handles btnVerReservas.Click
            AbrirFormularioHijo(New FormListadoReservas(_client))
        End Sub

        Private Sub btnGestionRecursos_Click(sender As Object, e As EventArgs) Handles btnGestionRecursos.Click
            AbrirFormularioHijo(New FormRecursos(_client))
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            Application.Restart()
        End Sub

        Private Sub AbrirFormularioHijo(formHijo As Form)
            panelContent.Controls.Clear()
            formHijo.TopLevel = False
            formHijo.FormBorderStyle = FormBorderStyle.None
            formHijo.Dock = DockStyle.Fill
            panelContent.Controls.Add(formHijo)
            formHijo.Show()
        End Sub
    End Class
End Namespace
