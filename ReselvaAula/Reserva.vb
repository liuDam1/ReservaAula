Imports Supabase.Postgrest.Attributes
Imports Supabase.Postgrest.Models

' Modelo que coincide exactamente con tu tabla "Reservas" en Supabase
<Table("Reservas")>
Public Class Reserva
    Inherits BaseModel

    <PrimaryKey("id")>
    Public Property Id As Long

    <Column("id_usuario")>
    Public Property IdUsuario As Long

    <Column("id_recurso")>
    Public Property IdRecurso As Long

    <Column("FechaInicio")> 
    Public Property FechaInicio As DateTime

    <Column("FechaFin")>
    Public Property FechaFin As DateTime

    <Column("Motivo")>
    Public Property Motivo As String
End Class