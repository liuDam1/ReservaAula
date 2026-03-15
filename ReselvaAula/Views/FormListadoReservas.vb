Imports Supabase.Postgrest
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports ReselvaAula.Models
Imports System.Globalization

Namespace Views
    Public Class FormListadoReservas
        Private _client As Client
        Private _fechaActual As DateTime
        Private _usuarioLogueado As Usuario

        Public Sub New(client As Client, usuario As Usuario)
            InitializeComponent()
            _client = client
            _usuarioLogueado = usuario
            _fechaActual = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            
            ' Aplicar estilo moderno
            Me.BackColor = Color.FromArgb(242, 245, 249)
            lblTitle.ForeColor = Color.FromArgb(45, 55, 72)
            lblTitle.Font = New Font("Segoe UI Semibold", 18.0!, FontStyle.Bold)
            
            btnRefrescar.BackColor = Color.FromArgb(49, 130, 206)
            btnRefrescar.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
            btnRefrescar.FlatStyle = FlatStyle.Flat
            btnRefrescar.FlatAppearance.BorderSize = 0
            
            pnlCalendarHeader.BackColor = Color.White
            lblMesActual.ForeColor = Color.FromArgb(45, 55, 72)
            lblMesActual.Font = New Font("Segoe UI Bold", 12.0!, FontStyle.Bold)
            
            btnAnterior.ForeColor = Color.FromArgb(49, 130, 206)
            btnSiguiente.ForeColor = Color.FromArgb(49, 130, 206)
        End Sub

        Private Async Sub FormListadoReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await RenderizarCalendario()
        End Sub

        Private Async Function RenderizarCalendario() As Task
            ' Limpiar calendario
            tlpCalendario.Controls.Clear()
            lblMesActual.Text = _fechaActual.ToString("MMMM yyyy", New CultureInfo("es-ES")).ToUpper()

            ' Añadir cabeceras de días
            Dim diasSemana = {"Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom"}
            For i As Integer = 0 To 6
                Dim lbl = New Label With {
                    .Text = diasSemana(i),
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                    .BackColor = Color.FromArgb(237, 242, 247),
                    .ForeColor = Color.FromArgb(74, 85, 104)
                }
                tlpCalendario.Controls.Add(lbl, i, 0)
            Next

            ' Calcular días
            Dim primerDiaMes = _fechaActual
            Dim diasEnMes = DateTime.DaysInMonth(_fechaActual.Year, _fechaActual.Month)
            
            ' DayOfWeek: Sunday=0, Monday=1, ... Saturday=6
            ' Queremos que el lunes sea 0
            Dim offset = (CInt(primerDiaMes.DayOfWeek) + 6) Mod 7

            ' Cargar reservas del mes
            Dim reservas = Await CargarReservasDelMes()

            ' Generar celdas de días
            Dim diaContador = 1
            For row As Integer = 1 To 6
                For col As Integer = 0 To 6
                    If (row = 1 AndAlso col < offset) OrElse diaContador > diasEnMes Then
                        ' Celda vacía
                        Dim pnlVacio = New Panel With {.Dock = DockStyle.Fill, .BackColor = Color.FromArgb(250, 250, 250)}
                        tlpCalendario.Controls.Add(pnlVacio, col, row)
                    Else
                        ' Celda con día
                        Dim pnlDia = CrearPanelDia(diaContador, reservas)
                        tlpCalendario.Controls.Add(pnlDia, col, row)
                        diaContador += 1
                    End If
                Next
            Next
        End Function

        Private Function CrearPanelDia(dia As Integer, todasLasReservas As List(Of ReservationView)) As Panel
            Dim pnl = New Panel With {
                .Dock = DockStyle.Fill,
                .BorderStyle = BorderStyle.FixedSingle,
                .BackColor = Color.White
            }

            ' Etiqueta del número de día
            Dim lblDia = New Label With {
                .Text = dia.ToString(),
                .Dock = DockStyle.Top,
                .Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold),
                .Height = 25,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Padding = New Padding(5, 0, 0, 0),
                .BackColor = Color.FromArgb(247, 250, 252),
                .ForeColor = Color.FromArgb(74, 85, 104)
            }
            pnl.Controls.Add(lblDia)

            ' Resaltar si es hoy
            If dia = DateTime.Now.Day AndAlso _fechaActual.Month = DateTime.Now.Month AndAlso _fechaActual.Year = DateTime.Now.Year Then
                lblDia.BackColor = Color.FromArgb(49, 130, 206)
                lblDia.ForeColor = Color.White
            End If

            ' Contenedor para las reservas (usaremos un Panel con AutoScroll para mayor control)
            Dim pnlContenedorReservas = New Panel With {
                .Dock = DockStyle.Fill,
                .AutoScroll = True,
                .Padding = New Padding(2)
            }
            pnl.Controls.Add(pnlContenedorReservas)
            pnlContenedorReservas.BringToFront() ' Para que no se solape con lblDia si lblDia no es Dock.Top

            ' Filtrar reservas para este día (comparamos solo Año, Mes, Día)
            Dim fechaDia = New DateTime(_fechaActual.Year, _fechaActual.Month, dia)
            Dim reservasHoy = todasLasReservas.Where(Function(r) r.Inicio.Year = fechaDia.Year AndAlso 
                                                         r.Inicio.Month = fechaDia.Month AndAlso 
                                                         r.Inicio.Day = fechaDia.Day).OrderBy(Function(r) r.Inicio).ToList()

            ' Añadir reservas de abajo hacia arriba (o usar Dock.Top para apilarlas)
            ' Invertimos el orden para que al usar Dock.Top queden en orden cronológico
            reservasHoy.Reverse() 

            For Each res In reservasHoy
                Dim lblRes = New Label With {
                    .Text = $"{res.Usuario} ({res.Recurso})",
                    .Dock = DockStyle.Top,
                    .AutoSize = True,
                    .Font = New Font("Segoe UI", 7.5!),
                    .BackColor = Color.FromArgb(235, 248, 255),
                    .ForeColor = Color.FromArgb(43, 108, 176),
                    .Margin = New Padding(2),
                    .Padding = New Padding(4),
                    .Cursor = Cursors.Hand,
                    .TextAlign = ContentAlignment.MiddleLeft
                }
                ' Pequeño borde o separador visual
                Dim pnlSpacer = New Panel With {.Height = 2, .Dock = DockStyle.Top}
                
                AddHandler lblRes.Click, Async Sub() 
                                             Dim detailForm = New FormDetalleReserva(res, _client, _usuarioLogueado)
                                             If detailForm.ShowDialog() = DialogResult.OK Then
                                                 Await RenderizarCalendario()
                                             End If
                                         End Sub
                
                pnlContenedorReservas.Controls.Add(pnlSpacer)
                pnlContenedorReservas.Controls.Add(lblRes)
            Next

            Return pnl
        End Function

        Private Async Function CargarReservasDelMes() As Task(Of List(Of ReservationView))
            Try
                ' 1. Limpieza automática: Eliminar reservas pasadas antes de cargar
                Await LimpiarReservasPasadas()

                ' 2. Cargar datos de Supabase
                Dim resReservas = Await _client.Table(Of Reserva)().Get()
                Dim resRecursos = Await _client.Table(Of Recurso)().Get()
                Dim resUsuarios = Await _client.Table(Of Usuario)().Get()

                Dim recursosDict = resRecursos.Models.ToDictionary(Function(r) r.Id, Function(r) r)
                Dim usuariosDict = resUsuarios.Models.ToDictionary(Function(u) u.Id, Function(u) u.Nombre)

                Return resReservas.Models.Select(Function(r) New ReservationView With {
                    .ID = r.Id,
                    .IdUsuario = r.IdUsuario,
                    .IdRecurso = r.IdRecurso,
                    .Usuario = If(usuariosDict.ContainsKey(r.IdUsuario), usuariosDict(r.IdUsuario), $"ID: {r.IdUsuario}"),
                    .Recurso = If(recursosDict.ContainsKey(r.IdRecurso), recursosDict(r.IdRecurso).Nombre, $"ID: {r.IdRecurso}"),
                    .Tipo = If(recursosDict.ContainsKey(r.IdRecurso), recursosDict(r.IdRecurso).Tipo, "N/A"),
                    .Inicio = DateTime.ParseExact(r.FechaInicio, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    .Fin = DateTime.ParseExact(r.FechaFin, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    .Motivo = r.Motivo
                }).ToList()
            Catch ex As Exception
                MsgBox("Error al cargar datos: " & ex.Message)
                Return New List(Of ReservationView)()
            End Try
        End Function

        Private Async Function LimpiarReservasPasadas() As Task
            Try
                ' Obtenemos la fecha de hoy en formato string ISO para comparar
                Dim hoyStr = DateTime.Now.ToString("yyyy-MM-dd")

                ' Buscamos reservas donde FechaFin sea menor que hoy
                ' Nota: Usamos Filter directamente para identificar las que deben borrarse
                Dim resPasadas = Await _client.Table(Of Reserva)() _
                    .Filter("FechaFin", Constants.Operator.LessThan, hoyStr) _
                    .Get()

                If resPasadas.Models.Count > 0 Then
                    ' Eliminamos cada reserva pasada
                    For Each res In resPasadas.Models
                        Await _client.Table(Of Reserva)().Filter("id", Constants.Operator.Equals, res.Id).Delete()
                    Next
                End If
            Catch ex As Exception
                ' Fallo silencioso o log para no interrumpir la experiencia del usuario
                Console.WriteLine("Error en limpieza de reservas: " & ex.Message)
            End Try
        End Function

        Private Async Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
            _fechaActual = _fechaActual.AddMonths(-1)
            Await RenderizarCalendario()
        End Sub

        Private Async Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
            _fechaActual = _fechaActual.AddMonths(1)
            Await RenderizarCalendario()
        End Sub

        Private Async Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
            Await RenderizarCalendario()
        End Sub

        ' Clase auxiliar para la vista
        Private Class ReservationView
            Public Property ID As Long
            Public Property IdUsuario As Long
            Public Property IdRecurso As Long
            Public Property Usuario As String
            Public Property Recurso As String
            Public Property Tipo As String
            Public Property Inicio As DateTime
            Public Property Fin As DateTime
            Public Property Motivo As String
        End Class
    End Class
End Namespace
