using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data.Modelos;
using SmartPark.UI.Services;

namespace SmartPark.UI.EntradasSalidas
{
    public partial class EntradasSalidasForm : Form
    {
        private readonly EspaciosService? _espaciosService;
        private readonly TicketService? _ticketService;
        private readonly TarifaService? _tarifaService;

        public EntradasSalidasForm()
        {
            InitializeComponent();
        }

        public EntradasSalidasForm(EspaciosService espaciosService, TicketService ticketService, TarifaService tarifaService)
            : this()
        {
            _espaciosService = espaciosService;
            _ticketService = ticketService;
            _tarifaService = tarifaService;
        }

        private async void EntradasSalidasForm_Load(object sender, EventArgs e)
        {
            textBoxHoraEntrada.Text = DateTime.Now.ToString("HH:mm");

            if (_espaciosService is null || _ticketService is null || _tarifaService is null)
            {
                return;
            }

            await CargarTiposVehiculo();
            await CargarEspaciosDisponibles();
            await CargarVehiculosActivos();
        }

        private async void buttonGuardarEntrada_Click(object sender, EventArgs e)
        {
            if (_ticketService is null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPlaca.Text))
            {
                MessageBox.Show("Ingrese la placa del vehículo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTipoVehiculo.SelectedValue == null || comboBoxEspacioAsignado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el tipo de vehículo y el espacio asignado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(comboBoxEspacioAsignado.SelectedValue.ToString(), out var espacioId))
            {
                MessageBox.Show("Seleccione un espacio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ticket = new Ticket
            {
                Placa = textBoxPlaca.Text.Trim().ToUpperInvariant()
            };

            var guardado = await _ticketService.RegistrarEntrada(ticket, espacioId);
            if (guardado)
            {
                MessageBox.Show("Entrada registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPlaca.Clear();
                textBoxHoraEntrada.Text = DateTime.Now.ToString("HH:mm");
                await CargarEspaciosDisponibles();
                await CargarVehiculosActivos();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonCobrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un vehículo para procesar el cobro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(dataGridViewVehiculos.CurrentRow.Cells[0].Value?.ToString(), out var id))
            {
                MessageBox.Show("ID de vehículo no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = Program.ServiceProvider.GetRequiredService<CobrarSalidaForm>();
            var cargado = await form.CargarVehiculo(id);
            if (!cargado)
            {
                return;
            }

            if (form.ShowDialog() == DialogResult.OK)
            {
                await CargarEspaciosDisponibles();
                await CargarVehiculosActivos();
            }
        }

        private async void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (_espaciosService is null || _ticketService is null || _tarifaService is null)
            {
                return;
            }

            await CargarTiposVehiculo();
            await CargarEspaciosDisponibles();
            await CargarVehiculosActivos();
        }

        private async Task CargarTiposVehiculo()
        {
            var tipos = await _tarifaService!.GetTiposVehiculo();
            comboBoxTipoVehiculo.DataSource = null;
            comboBoxTipoVehiculo.DisplayMember = "Nombre";
            comboBoxTipoVehiculo.ValueMember = "Id";
            comboBoxTipoVehiculo.DataSource = tipos;
        }

        private async Task CargarEspaciosDisponibles()
        {
            var tipoId = comboBoxTipoVehiculo.SelectedValue is null
                ? (int?)null
                : Convert.ToInt32(comboBoxTipoVehiculo.SelectedValue);

            var espacios = await _espaciosService!.GetList(e => e.EstadoId == 1 && e.Activo && (!tipoId.HasValue || e.TipoVehiculoId == tipoId.Value));
            comboBoxEspacioAsignado.DataSource = null;
            comboBoxEspacioAsignado.DisplayMember = "CodigoEspacio";
            comboBoxEspacioAsignado.ValueMember = "Id";
            comboBoxEspacioAsignado.DataSource = espacios;
        }

        private async Task CargarVehiculosActivos()
        {
            var tickets = await _ticketService!.GetList(t => t.EstadoId == 1);
            dataGridViewVehiculos.Rows.Clear();

            foreach (var ticket in tickets)
            {
                var minutos = Math.Max(0, (int)Math.Ceiling((DateTime.Now - ticket.HoraEntrada).TotalMinutes));
                var horas = minutos / 60;
                var resto = minutos % 60;
                var tiempo = $"{horas}h {resto}m";

                dataGridViewVehiculos.Rows.Add(
                    ticket.Id,
                    ticket.CodigoTicket,
                    ticket.Placa,
                    ticket.Espacio?.TipoVehiculo?.Nombre ?? "N/A",
                    ticket.Espacio?.CodigoEspacio ?? "N/A",
                    ticket.HoraEntrada.ToString("HH:mm"),
                    tiempo
                );
            }
        }
    }
}

