using SmartPark.Data.Modelos;
using SmartPark.UI.Services;

namespace SmartPark.UI.EntradasSalidas
{
    public partial class CobrarSalidaForm : Form
    {
        private readonly TicketService? _ticketService;
        private readonly PagoService? _pagoService;
        private readonly TarifaService? _tarifaService;
        private Ticket? _ticket;
        private decimal _montoCalculado;

        public CobrarSalidaForm()
        {
            InitializeComponent();
        }

        public CobrarSalidaForm(TicketService ticketService, PagoService pagoService, TarifaService tarifaService)
            : this()
        {
            _ticketService = ticketService;
            _pagoService = pagoService;
            _tarifaService = tarifaService;
        }

        public async Task<bool> CargarVehiculo(long vehiculoId)
        {
            if (_ticketService is null)
            {
                return false;
            }

            _ticket = await _ticketService.Buscar(vehiculoId);
            if (_ticket == null)
            {
                MessageBox.Show("No se encontró el vehículo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            textBoxTicket.Text = _ticket.CodigoTicket;
            textBoxPlaca.Text = _ticket.Placa;
            textBoxTipo.Text = _ticket.Espacio?.TipoVehiculo?.Nombre ?? "N/A";
            textBoxEspacio.Text = _ticket.Espacio?.CodigoEspacio ?? "N/A";
            textBoxHoraEntrada.Text = _ticket.HoraEntrada.ToString("HH:mm");
            textBoxHoraSalida.Text = DateTime.Now.ToString("HH:mm");
            textBoxTiempoTranscurrido.Text = CalcularTiempoTranscurrido(_ticket.HoraEntrada);
            _montoCalculado = await CalcularMontoTotal();
            textBoxMontoACobrar.Text = _montoCalculado.ToString("0.00");

            return true;
        }

        private async void buttonRegistrarCobro_Click(object sender, EventArgs e)
        {
            if (_pagoService is null || _ticket is null)
            {
                return;
            }

            buttonRegistrarCobro.Enabled = false;

            try
            {
                var pago = new Pago
                {
                    MetodoPago = "Efectivo",
                    Monto = _montoCalculado,
                    MontoRecibido = _montoCalculado
                };

                var guardado = await _pagoService.RegistrarCobro(pago, _ticket.Id);
                if (guardado)
                {
                    MessageBox.Show("Cobro registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cobro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                buttonRegistrarCobro.Enabled = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private static string CalcularTiempoTranscurrido(DateTime horaEntrada)
        {
            var minutos = Math.Max(0, (int)Math.Ceiling((DateTime.Now - horaEntrada).TotalMinutes));
            var horas = minutos / 60;
            var resto = minutos % 60;
            return $"{horas}h {resto}m";
        }

        private async Task<decimal> CalcularMontoTotal()
        {
            if (_ticket is null || _tarifaService is null)
            {
                return 0m;
            }

            var tipoVehiculoId = _ticket.Espacio?.TipoVehiculoId;
            if (!tipoVehiculoId.HasValue)
            {
                MessageBox.Show("No se pudo determinar el tipo de vehículo desde el espacio asignado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0m;
            }

            var tarifa = (await _tarifaService.GetList(t => t.TipoVehiculoId == tipoVehiculoId.Value)).FirstOrDefault();
            if (tarifa is null)
            {
                MessageBox.Show("No existe una tarifa configurada para este tipo de vehículo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0m;
            }

            var minutosTranscurridos = Math.Max(0, (int)Math.Ceiling((DateTime.Now - _ticket.HoraEntrada).TotalMinutes));
            if (minutosTranscurridos <= tarifa.MinutosTolerancia)
            {
                return 0m;
            }

            var minutosCobro = Math.Max(minutosTranscurridos, tarifa.MinutosMinimo);
            var fracciones = (int)Math.Ceiling((decimal)minutosCobro / tarifa.MinutosFraccion);
            return fracciones * tarifa.PrecioPorFraccion;
        }
    }
}
