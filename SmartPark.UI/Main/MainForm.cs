using SmartPark.UI.Espacios;
using SmartPark.UI.Configuracion;
using Microsoft.Extensions.DependencyInjection;
using SmartPark.UI.EntradasSalidas;
using SmartPark.UI.Usuarios;
using SmartPark.UI.Consultas;
using SmartPark.UI.Reservas;
using SmartPark.UI.Services;

namespace SmartPark.UI.Main
{
    public partial class MainForm : Form
    {
        private readonly EspaciosService _espaciosService;
        private readonly TicketService _ticketService;
        private readonly ReservaService _reservaService;

        public MainForm(EspaciosService espaciosService, TicketService ticketService, ReservaService reservaService)
        {
            InitializeComponent();
            _espaciosService = espaciosService;
            _ticketService = ticketService;
            _reservaService = reservaService;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusUsuario.Text = $"Usuario: {Program.UsuarioActual?.Nombre ?? "Desconocido"}";
            toolStripStatusFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            await CargarDashboardAsync();
        }

        private void buttonEspacios_Click(object sender, EventArgs e)
        {
            var espaciosList = Program.ServiceProvider.GetRequiredService<EspaciosList>();
            espaciosList.ShowDialog();
        }

        private void buttonEntradasSalidas_Click(object sender, EventArgs e)
        {
            var entradasSalidasForm = Program.ServiceProvider.GetRequiredService<EntradasSalidasForm>();
            entradasSalidasForm.ShowDialog();
        }

        private void buttonUsuarios_Click(object? sender, EventArgs e)
        {
            var usuariosForm = Program.ServiceProvider.GetRequiredService<UsuariosForm>();
            usuariosForm.ShowDialog();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            var consultasForm = Program.ServiceProvider.GetRequiredService<ConsultasForm>();
            consultasForm.ShowDialog();
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            var configuracionForm = Program.ServiceProvider.GetRequiredService<ConfiguracionForm>();
            configuracionForm.ShowDialog();
        }

        private void buttonReservas_Click(object? sender, EventArgs e)
        {
            var reservasForm = Program.ServiceProvider.GetRequiredService<ReservasForm>();
            reservasForm.ShowDialog();
        }

        private void menuNuevaReserva_Click(object? sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevaReservaForm>();
            form.ShowDialog();
        }

        private void menuCerrarSesion_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void menuSalir_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private async Task CargarDashboardAsync()
        {
            var espacios = await _espaciosService.GetList(_ => true);
            labelKpi1Value.Text = espacios.Count.ToString();
            labelKpi2Value.Text = espacios.Count(e => string.Equals(e.Estado, "LIBRE", StringComparison.OrdinalIgnoreCase)).ToString();
            labelKpi3Value.Text = espacios.Count(e => string.Equals(e.Estado, "OCUPADO", StringComparison.OrdinalIgnoreCase)).ToString();
            labelKpi4Value.Text = espacios.Count(e => string.Equals(e.Estado, "RESERVADO", StringComparison.OrdinalIgnoreCase)).ToString();

            var reservasPendientes = await _reservaService.GetList(r => r.Estado == "PENDIENTE");
            labelKpi5Value.Text = reservasPendientes.Count.ToString();

            await CargarAlertasAsync();
        }

        private async Task CargarAlertasAsync()
        {
            dataGridViewAlertas.Rows.Clear();

            var now = DateTime.Now;
            var ticketsActivos = await _ticketService.GetList(t => t.Estado == "ACTIVO");
            var reservasPendientes = await _reservaService.GetList(r => r.Estado == "PENDIENTE");

            var alertas = new List<(string Tipo, string Detalle, DateTime Hora)>();

            foreach (var ticket in ticketsActivos)
            {
                var duracion = now - ticket.HoraEntrada;
                if (duracion.TotalHours <= 6)
                    continue;

                var horas = (int)duracion.TotalHours;
                var minutos = duracion.Minutes;
                var espacio = ticket.Espacio?.CodigoEspacio ?? "N/A";
                var detalle = $"Ticket {ticket.CodigoTicket} | Placa {ticket.Placa} | Espacio {espacio} | {horas}h {minutos}m";
                alertas.Add(("Estadia larga", detalle, ticket.HoraEntrada));
            }

            var reservasHoy = reservasPendientes
                .Where(r => r.HoraInicio.Date == now.Date)
                .ToList();

            foreach (var reserva in reservasHoy)
            {
                var diff = reserva.HoraInicio - now;
                var minutos = (int)Math.Floor(diff.TotalMinutes);
                var espacio = reserva.Espacio?.CodigoEspacio ?? "N/A";
                var detalle = $"{reserva.ClienteNombreCompleto} | Espacio {espacio} | {reserva.HoraInicio:HH:mm}";

                if (minutos > 0 && minutos <= 60)
                {
                    alertas.Add(("Reserva proxima", $"{detalle} | En {minutos} min", reserva.HoraInicio));
                }
                else if (minutos < 0)
                {
                    alertas.Add(("Reserva vencida", $"{detalle} | {Math.Abs(minutos)} min tarde", reserva.HoraInicio));
                }
            }

            var numero = 1;
            foreach (var alerta in alertas)
            {
                dataGridViewAlertas.Rows.Add(
                    numero++,
                    alerta.Tipo,
                    alerta.Detalle,
                    alerta.Hora.ToString("HH:mm"));
            }
        }

    }
}
