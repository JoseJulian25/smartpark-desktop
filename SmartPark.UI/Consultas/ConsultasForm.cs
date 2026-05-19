using System.Drawing;
using SmartPark.UI.Services;

namespace SmartPark.UI.Consultas
{
    public partial class ConsultasForm : Form
    {
        private readonly ConsultasService _service;
        private readonly PagoService _pagoService;
        private readonly TicketService _ticketService;

        public ConsultasForm(ConsultasService service, PagoService pagoService, TicketService ticketService)
        {
            InitializeComponent();
            _service = service;
            _pagoService = pagoService;
            _ticketService = ticketService;
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

                var rowIndex = dataGridViewHistorial.Rows.Add(
                    item.Id,
                    item.CodigoTicket,
                    item.Placa,
                    tipo,
                    item.Espacio.CodigoEspacio,
                    item.HoraEntrada.ToString("yyyy-MM-dd HH:mm"),
                    item.HoraSalida?.ToString("yyyy-MM-dd HH:mm") ?? string.Empty,
                    tiempo,
                    item.MontoTotal?.ToString("N2") ?? string.Empty,
                    creador,
                    item.Anulado ? "SI" : "NO",
                    item.FechaAnulacion?.ToString("yyyy-MM-dd HH:mm") ?? string.Empty);

                AplicarEstiloAnulado(dataGridViewHistorial.Rows[rowIndex], "columnHistAnulado", item.Anulado);
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
            decimal totalMonto = 0m;

            foreach (var item in items)
            {
                var procesadoPor = item.ProcesadoPorNavigation?.Nombre ?? string.Empty;
                var rowIndex = dataGridViewPagos.Rows.Add(
                    item.Id,
                    item.Ticket.CodigoTicket,
                    item.MetodoPago,
                    item.Monto.ToString("N2"),
                    item.MontoRecibido.ToString("N2"),
                    item.HoraPago.ToString("yyyy-MM-dd HH:mm"),
                    procesadoPor,
                    item.Anulado ? "SI" : "NO",
                    item.FechaAnulacion?.ToString("yyyy-MM-dd HH:mm") ?? string.Empty);

                AplicarEstiloAnulado(dataGridViewPagos.Rows[rowIndex], "columnPagoAnulado", item.Anulado);
                if (!item.Anulado)
                    totalMonto += item.Monto;
            }

            labelPagoTotalValue.Text = totalMonto.ToString("N2");
        }

        private static void AplicarEstiloAnulado(DataGridViewRow row, string columnName, bool anulado)
        {
            if (row.DataGridView == null || !row.DataGridView.Columns.Contains(columnName))
                return;

            var cell = row.Cells[columnName];
            if (!anulado)
            {
                cell.Style.BackColor = Color.FromArgb(232, 245, 233);
                cell.Style.ForeColor = Color.FromArgb(46, 125, 50);
                return;
            }

            cell.Style.BackColor = Color.FromArgb(255, 235, 238);
            cell.Style.ForeColor = Color.FromArgb(183, 28, 28);
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

        private async void buttonPagosAnular_Click(object sender, EventArgs e)
        {
            if (dataGridViewPagos.CurrentRow == null)
                return;

            if (!long.TryParse(Convert.ToString(dataGridViewPagos.CurrentRow.Cells[0].Value), out var pagoId))
                return;

            var confirmacion = MessageBox.Show(
                "¿Deseas anular este pago? El ticket quedara activo y el espacio ocupado.",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            if (await _pagoService.AnularPago(pagoId))
            {
                await CargarPagosAsync();
                await CargarHistorialAsync();
                return;
            }

            MessageBox.Show("No se pudo anular el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void buttonHistorialAnular_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistorial.CurrentRow == null)
                return;

            if (!long.TryParse(Convert.ToString(dataGridViewHistorial.CurrentRow.Cells[0].Value), out var ticketId))
                return;

            var confirmacion = MessageBox.Show(
                "¿Deseas anular este ticket? El espacio quedara libre.",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            if (await _ticketService.AnularTicket(ticketId))
            {
                await CargarHistorialAsync();
                await CargarPagosAsync();
                return;
            }

            MessageBox.Show("No se pudo anular el ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
