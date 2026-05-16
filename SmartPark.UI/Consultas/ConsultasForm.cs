using SmartPark.UI.Services;

namespace SmartPark.UI.Consultas
{
    public partial class ConsultasForm : Form
    {
        private readonly ConsultasService _service;

        public ConsultasForm(ConsultasService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void ConsultasForm_Load_1(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            dateTimeHistorialFin.Value = today;
            dateTimeHistorialInicio.Value = today.AddDays(-15);
            dateTimePagoFin.Value = today;
            dateTimePagoInicio.Value = today.AddDays(-15);
            comboBoxPagoMetodo.SelectedItem ??= "Todos";

            await CargarHistorialAsync();
            await CargarPagosAsync();
        }


        private async Task CargarHistorialAsync()
        {
            var items = await _service.GetHistorialEntradasSalidas(
                dateTimeHistorialInicio.Value,
                dateTimeHistorialFin.Value,
                textBoxHistorialPlaca.Text.Trim().ToUpperInvariant(),
                textBoxHistorialTicket.Text.Trim().ToUpperInvariant());

            dataGridViewHistorial.Rows.Clear();

            foreach (var item in items)
            {
                var tiempo = ConsultasService.BuildTiempo(item.HoraEntrada, item.HoraSalida);
                var tipo = item.Espacio.TipoVehiculo != null ? item.Espacio.TipoVehiculo.Nombre : string.Empty;
                var creador = item.CreadoPorNavigation?.Nombre ?? string.Empty;

                dataGridViewHistorial.Rows.Add(
                    item.Id,
                    item.CodigoTicket,
                    item.Placa,
                    tipo,
                    item.Espacio.CodigoEspacio,
                    item.HoraEntrada.ToString("yyyy-MM-dd HH:mm"),
                    item.HoraSalida?.ToString("yyyy-MM-dd HH:mm") ?? string.Empty,
                    tiempo,
                    item.MontoTotal?.ToString("N2") ?? string.Empty,
                    creador);
            }
        }

        private async Task CargarPagosAsync()
        {
            var metodo = comboBoxPagoMetodo.SelectedItem?.ToString() ?? "Todos";
            var items = await _service.GetPagos(
                dateTimePagoInicio.Value,
                dateTimePagoFin.Value,
                metodo,
                textBoxPagoTicket.Text.Trim().ToUpperInvariant());

            dataGridViewPagos.Rows.Clear();

            foreach (var item in items)
            {
                var procesadoPor = item.ProcesadoPorNavigation?.Nombre ?? string.Empty;
                dataGridViewPagos.Rows.Add(
                    item.Id,
                    item.Ticket.CodigoTicket,
                    item.MetodoPago,
                    item.Monto.ToString("N2"),
                    item.MontoRecibido.ToString("N2"),
                    item.HoraPago.ToString("yyyy-MM-dd HH:mm"),
                    procesadoPor);
            }
        }


        private async void buttonHistorialBuscar_Click_1(object sender, EventArgs e)
        {
            await CargarHistorialAsync();
        }

        private async void buttonHistorialLimpiar_Click_1(object sender, EventArgs e)
        {
            textBoxHistorialPlaca.Text = string.Empty;
            textBoxHistorialTicket.Text = string.Empty;
            await CargarHistorialAsync();
        }

        private async void buttonPagosBuscar_Click_1(object sender, EventArgs e)
        {
            await CargarPagosAsync();
        }

        private async void buttonPagosLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPagoTicket.Text = string.Empty;
            comboBoxPagoMetodo.SelectedItem = "Todos";
            await CargarPagosAsync();

        }
    }
}
