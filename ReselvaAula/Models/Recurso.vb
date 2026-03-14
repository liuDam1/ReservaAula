Imports Supabase.Postgrest.Attributes
Imports Supabase.Postgrest.Models

' Modelo que coincide con tu tabla "Recursos" en Supabase
Namespace Models
    <Table("Recursos")>
    Public Class Recurso
        Inherits BaseModel

        <PrimaryKey("id")>
        Public Property Id As Long

        <Column("Nombre")>
        Public Property Nombre As String

        <Column("Tipo")>
        Public Property Tipo As String
    End Class
End Namespace
