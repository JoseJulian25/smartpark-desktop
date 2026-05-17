using System;
using System.Windows.Forms;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Reservas
{
    public partial class NuevaReservaForm : Form
    {
        private readonly Services.ReservaService _service;
        private readonly Services.TarifaService _tarifaService;
        private readonly Services.EspaciosService _espaciosService;
        private bool _loading;
        private Reserva? _editingReserva;

        public NuevaReservaForm(Services.ReservaService service, Services.TarifaService tarifaService, Services.EspaciosService espaciosService)
        {
            InitializeComponent();
            _service = service;
            _tarifaService = tarifaService;
            _espaciosService = espaciosService;
        }

        private async void NuevaReservaForm_Load(object sender, EventArgs e)
        {
            _loading = true;
            dateTimeFecha.Value = DateTime.Today;
            dateTimeHoraInicio.Value = DateTime.Now;

            var tipos = await _tarifaService.GetTiposVehiculo();
            comboBoxTipoVehiculo.DisplayMember = "Nombre";
            comboBoxTipoVehiculo.ValueMember = "Id";
            comboBoxTipoVehiculo.DataSource = tipos;

            if (_editingReserva != null)
            {
                comboBoxTipoVehiculo.SelectedValue = _editingReserva.TipoVehiculoId;
                await CargarEspaciosPorTipoAsync(_editingReserva.EspacioId);
                AplicarReservaEnFormulario(_editingReserva);
            }
            else
            {
                await CargarEspaciosPorTipoAsync();
            }
            _loading = false;
        }

        private async void comboBoxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading)
                return;

            await CargarEspaciosPorTipoAsync();
        }

        private async Task CargarEspaciosPorTipoAsync(long? selectedEspacioId = null)
        {
            if (comboBoxTipoVehiculo.SelectedValue is not int tipoVehiculoId)
            {
                comboBoxEspacio.DataSource = null;
                return;
            }

            var espacios = await _espaciosService.GetList(e => e.Activo && e.TipoVehiculoId == tipoVehiculoId);
            comboBoxEspacio.DisplayMember = "CodigoEspacio";
            comboBoxEspacio.ValueMember = "Id";
            comboBoxEspacio.DataSource = espacios;

            if (selectedEspacioId.HasValue)
            {
                comboBoxEspacio.SelectedValue = selectedEspacioId.Value;
            }
        }

        public void SetReserva(Reserva reserva)
        {
            _editingReserva = reserva;

            if (IsHandleCreated && !_loading)
            {
                AplicarReservaEnFormulario(reserva);
            }
        }

        private void AplicarReservaEnFormulario(Reserva reserva)
        {
            textBoxCliente.Text = reserva.ClienteNombreCompleto;
            textBoxEmail.Text = reserva.ClienteEmail;
            textBoxPlaca.Text = reserva.Placa;
            textBoxCelular.Text = reserva.ClienteTelefono;
            dateTimeFecha.Value = reserva.HoraInicio.Date;
            dateTimeHoraInicio.Value = reserva.HoraInicio;
            buttonGuardar.Text = "Guardar Cambios";
            Text = "SmartPark - Editar Reserva";
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            var cliente = textBoxCliente.Text.Trim();
            var email = textBoxEmail.Text.Trim();
            var placa = textBoxPlaca.Text.Trim().ToUpperInvariant();
            var celular = textBoxCelular.Text.Trim();

            if (string.IsNullOrWhiteSpace(cliente) || string.IsNullOrWhiteSpace(placa))
            {
                MessageBox.Show("Cliente y placa son obligatorios.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTipoVehiculo.SelectedValue is not int tipoVehiculoId)
            {
                MessageBox.Show("Seleccione un tipo de vehiculo.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxEspacio.SelectedValue is not long espacioId)
            {
                MessageBox.Show("Seleccione un espacio.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fecha = dateTimeFecha.Value.Date;
            var hora = dateTimeHoraInicio.Value.TimeOfDay;

            var reserva = _editingReserva == null
                ? new Data.Modelos.Reserva()
                : new Data.Modelos.Reserva
                {
                    Id = _editingReserva.Id,
                    CodigoReserva = _editingReserva.CodigoReserva,
                    FechaCreacion = _editingReserva.FechaCreacion,
                    HoraFin = _editingReserva.HoraFin,
                    Estado = _editingReserva.Estado,
                    CreadoPor = _editingReserva.CreadoPor,
                    CanceladoPor = _editingReserva.CanceladoPor,
                    MotivoCancelacion = _editingReserva.MotivoCancelacion
                };

            reserva.ClienteNombreCompleto = cliente;
            reserva.ClienteTelefono = celular;
            reserva.ClienteEmail = email;
            reserva.CodigoReserva = string.IsNullOrWhiteSpace(reserva.CodigoReserva)
                ? $"R-{DateTime.Now:yyyyMMddHHmmssfff}"
                : reserva.CodigoReserva;
            reserva.FechaCreacion ??= DateTime.Now;
            reserva.HoraInicio = fecha.Add(hora);
            reserva.Placa = placa;
            reserva.EspacioId = espacioId;
            reserva.TipoVehiculoId = tipoVehiculoId;
            reserva.Estado = string.IsNullOrWhiteSpace(reserva.Estado) ? "PENDIENTE" : reserva.Estado;
            reserva.CreadoPor ??= Program.UsuarioActual?.Id;

            if (await _service.Guardar(reserva))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("No se pudo guardar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
