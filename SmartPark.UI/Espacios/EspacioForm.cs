using SmartPark.Data.Modelos;
using SmartPark.UI.Services;

namespace SmartPark.UI.Espacios
{
    public partial class EspacioForm : Form
    {
        private readonly EspaciosService _service;
        private readonly ErrorProvider _errorProvider = new ErrorProvider();
        private Espacio? _entidad;

        public EspacioForm(EspaciosService service)
        {
            InitializeComponent();
            _service = service;

            buttonGuardar.Click += buttonGuardar_Click;
            buttonCancelar.Click += btnCancel_Click;
            comboBoxTipo.SelectedIndex = 0;
        }

        public async Task Buscar(long? id)
        {
            if (id is null)
                return;

            var espacio = await _service.Buscar(id.Value);
            if (espacio is null)
                return;

            _entidad = espacio;
            textBoxCodigo.Text = espacio.CodigoEspacio;
            comboBoxTipo.SelectedIndex = ObtenerIndiceTipo(espacio.TipoVehiculoId);
        }

        private bool validateForm()
        {
            _errorProvider.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(textBoxCodigo.Text))
            {
                _errorProvider.SetError(textBoxCodigo, "El código es obligatorio.");
                valid = false;
            }

            if (comboBoxTipo.SelectedIndex < 0)
            {
                _errorProvider.SetError(comboBoxTipo, "El tipo es obligatorio.");
                valid = false;
            }

            return valid;
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private static int ObtenerIndiceTipo(int tipoVehiculoId)
        {
            return tipoVehiculoId > 0 ? tipoVehiculoId - 1 : 0;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!validateForm()) return;

            try
            {
                buttonGuardar.Enabled = false;

                var espacio = _entidad ?? new Espacio
                {
                    FechaCreacion = DateTime.Now,
                    Activo = true,
                    EstadoId = 1
                };


                espacio.CodigoEspacio = textBoxCodigo.Text.Trim();
                espacio.TipoVehiculoId = comboBoxTipo.SelectedIndex + 1;

                bool paso = await _service.Guardar(espacio);

                if (paso)
                {
                    MessageBox.Show("Espacio guardado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el espacio.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonGuardar.Enabled = true;
            }
        }

    }
}
