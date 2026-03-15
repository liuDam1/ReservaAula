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
            
            ' Aplicar estilo moderno al FormMain
            Me.BackColor = Color.FromArgb(242, 245, 249)
            panelSidebar.BackColor = Color.FromArgb(45, 55, 72)
            panelContent.BackColor = Color.FromArgb(242, 245, 249)
            
            ' Usuario Info
            lblBienvenido.Text = $"Hola, {_usuario.Nombre}"
            lblBienvenido.Font = New Font("Segoe UI Semibold", 11.0!, FontStyle.Bold)
            lblBienvenido.ForeColor = Color.White
            
            lblDepto.Text = _usuario.Departamento
            lblDepto.Font = New Font("Segoe UI", 9.0!)
            lblDepto.ForeColor = Color.FromArgb(160, 174, 192)
            
            ' Estilo de botones del Sidebar
            Dim navButtons = {btnNuevaReserva, btnVerReservas, btnGestionRecursos, btnLogout}
            For Each btn In navButtons
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 85, 104)
                btn.Font = New Font("Segoe UI Semibold", 10.0!)
                btn.ForeColor = Color.FromArgb(226, 232, 240)
            Next
            
            ' Botón Logout especial (rojo suave al pasar el mouse ya configurado en designer, pero reforzamos texto)
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 62, 62)
            
            ' Cargar vista inicial
            btnVerReservas_Click(Nothing, Nothing)
        End Sub

        Private Sub btnNuevaReserva_Click(sender As Object, e As EventArgs) Handles btnNuevaReserva.Click
            AbrirFormularioHijo(New FormReserva(_usuario, _client))
        End Sub

        Private Sub btnVerReservas_Click(sender As Object, e As EventArgs) Handles btnVerReservas.Click
            AbrirFormularioHijo(New FormListadoReservas(_client, _usuario))
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
