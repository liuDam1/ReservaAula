Imports Supabase.Postgrest.Attributes
Imports Supabase.Postgrest.Models

Namespace Models
    <Table("Tipo")>
    Public Class Tipo
        Inherits BaseModel

        <PrimaryKey("id")>
        Public Property Id As Long

        <Column("Nombre")>
        Public Property Nombre As String

        Public Overrides Function ToString() As String
            Return Nombre
        End Function
    End Class
End Namespace
