using SmartPark.Data.Modelos;
using SmartPark.UI.Services;

namespace SmartPark.UI.Configuracion
{
    public partial class TarifaForm : Form
    {
        private readonly TarifaService? _service;
        private Tarifa? _entidad;

        public TarifaForm()
        {
            InitializeComponent();
            buttonGuardar.Click += buttonGuardar_Click;
            buttonCancelar.Click += buttonCancelar_Click;
        }

        public TarifaForm(TarifaService service)
        {
            InitializeComponent();
            _service = service ?? throw new ArgumentNullException(nameof(service));
            buttonGuardar.Click += buttonGuardar_Click;
            buttonCancelar.Click += buttonCancelar_Click;
        }

        private async void TarifaForm_Load(object sender, EventArgs e)
        {
            if (_service is null)
            {
                return;
            }

            try
            {
                var tipos = await _service.GetTiposVehiculo();
                comboBoxTipo.DataSource = tipos;
                comboBoxTipo.DisplayMember = "Nombre";
                comboBoxTipo.ValueMember = "Id";
                comboBoxTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de vehículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task Cargar(Tarifa? tarifa)
        {
            _entidad = tarifa;
            
            if (_entidad == null)
            {
                // Nueva tarifa: resetear el formulario
                numericUpDownPrecio.Value = 0;
                numericUpDownMinutosFraccion.Value = 15;
                numericUpDownMinutosMinimo.Value = 0;
                numericUpDownMinutosTolerancia.Value = 0;
                if (comboBoxTipo.Items.Count > 0)
                {
                    comboBoxTipo.SelectedIndex = 0;
                }
                return;
            }

            // Editar tarifa existente
            comboBoxTipo.SelectedValue = _entidad.TipoVehiculoId;
            numericUpDownPrecio.Value = _entidad.PrecioPorFraccion;
            numericUpDownMinutosFraccion.Value = _entidad.MinutosFraccion;
            numericUpDownMinutosMinimo.Value = _entidad.MinutosMinimo;
            numericUpDownMinutosTolerancia.Value = _entidad.MinutosTolerancia;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (_service is null)
            {
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                buttonGuardar.Enabled = false;

                var tarifa = _entidad ?? new Tarifa();
                tarifa.TipoVehiculoId = Convert.ToInt32(comboBoxTipo.SelectedValue);
                tarifa.PrecioPorFraccion = numericUpDownPrecio.Value;
                tarifa.MinutosFraccion = Convert.ToInt32(numericUpDownMinutosFraccion.Value);
                tarifa.MinutosMinimo = Convert.ToInt32(numericUpDownMinutosMinimo.Value);
                tarifa.MinutosTolerancia = Convert.ToInt32(numericUpDownMinutosTolerancia.Value);
                tarifa.ActualizadoEn = DateTime.Now;
                tarifa.TipoVehiculoId = comboBoxTipo.SelectedIndex + 1;

                bool ok = await _service.Guardar(tarifa);
                if (ok)
                {
                    MessageBox.Show("Tarifa guardada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la tarifa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar tarifa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonGuardar.Enabled = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateForm()
        {
            if (comboBoxTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de vehículo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numericUpDownPrecio.Value <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
