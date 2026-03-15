Imports System.Threading.Tasks
Imports Supabase.Postgrest
Imports ReselvaAula.Models

Namespace Controllers
    Public Class AuthService
        Private ReadOnly _client As Client

        Public Sub New(client As Client)
            _client = client
        End Sub

        Public Async Function Registrar(nombre As String, password As String, departamento As String, email As String) As Task(Of Boolean)
            Try
                Dim hash = BCrypt.Net.BCrypt.HashPassword(password)
                Dim usuario = New Usuario With {
                    .Nombre = nombre,
                    .Password = hash,
                    .Departamento = departamento,
                    .Email = email
                }
                Await _client.Table(Of Usuario)().Insert(usuario)
                Return True
            Catch ex As Exception
                MsgBox("Error al registrar: " & ex.Message)
                Return False
            End Try
        End Function

        Public Async Function IniciarSesion(nombreUsuario As String, password As String) As Task(Of Usuario)
            Try
                ' ✅ Ahora iniciamos sesión por Nombre de usuario
                Dim res = Await _client.Table(Of Usuario)().Filter("Nombre", Constants.Operator.Equals, nombreUsuario).Single()
                
                If res IsNot Nothing AndAlso BCrypt.Net.BCrypt.Verify(password, res.Password) Then
                    Return res
                End If
                Return Nothing
            Catch ex As Exception
                MsgBox("Error al iniciar sesión: " & ex.Message)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace
