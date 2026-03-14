Imports System.Threading.Tasks
Imports Supabase.Postgrest

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

    Public Async Function IniciarSesion(email As String, password As String) As Task(Of Usuario)
        Try
            ' ✅ Cambio a .Filter para mayor estabilidad en VB.NET y evitar error de BaseModel
            Dim res = Await _client.Table(Of Usuario)().Filter("Email", Constants.Operator.Equals, email).Single()
            
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