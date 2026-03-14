Imports Supabase.Postgrest.Attributes
Imports Supabase.Postgrest.Models

' Modelo que coincide con tu tabla "Usuario" en Supabase
Namespace Models
    <Table("Usuario")>
    Public Class Usuario
        Inherits BaseModel

        <PrimaryKey("id")>
        Public Property Id As Long

        <Column("Nombre")>
        Public Property Nombre As String

        <Column("Password")>
        Public Property Password As String

        <Column("Departamento")>
        Public Property Departamento As String

        <Column("Email")>
        Public Property Email As String
    End Class
End Namespace
