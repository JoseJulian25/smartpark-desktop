using SmartPark.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Configuracion
{
    public partial class ConfiguracionForm : Form
    {
        private readonly EmpresaService? _empresaService;
        private readonly TarifaService? _tarifaService;
        private Empresa? _empresaActual;

        public ConfiguracionForm()
        {
            InitializeComponent();
        }

        public ConfiguracionForm(EmpresaService empresaService, TarifaService tarifaService)
        {
            InitializeComponent();
            _empresaService = empresaService;
            _tarifaService = tarifaService;
        }

        private async void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            await CargarEmpresa();
            await CargarTarifas();
        }

        private async Task CargarEmpresa()
        {

            try
            {
                var empresas = await _empresaService.GetList(_ => true);
                if (empresas.Count > 0)
                {
                    _empresaActual = empresas[0];
                    textBoxNombreEmpresa.Text = _empresaActual.Nombre ?? "";
                    textBoxRnc.Text = _empresaActual.Rnc ?? "";
                    textBoxDireccion.Text = _empresaActual.Direccion ?? "";
                    textBoxTelefono.Text = _empresaActual.Telefono ?? "";
                    textBoxEmail.Text = _empresaActual.Email ?? "";
                }
                else
                {
                    _empresaActual = new Empresa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la empresa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarTarifas()
        {
            try
            {
                var tarifas = await _tarifaService.GetList(_ => true);
                dataGridViewTarifas.Rows.Clear();
                
                foreach (var tarifa in tarifas)
                {
                    dataGridViewTarifas.Rows.Add(
                        tarifa.Id,
                        tarifa.TipoVehiculo?.Nombre ?? "N/A",
                        tarifa.PrecioPorFraccion.ToString("C2"),
                        tarifa.MinutosFraccion,
                        tarifa.MinutosMinimo,
                        tarifa.MinutosTolerancia,
                        tarifa.ActualizadoEn?.ToString("yyyy-MM-dd HH:mm") ?? "N/A"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las tarifas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _empresaActual ??= new Empresa();
                _empresaActual.Nombre = textBoxNombreEmpresa.Text;
                _empresaActual.Rnc = textBoxRnc.Text;
                _empresaActual.Direccion = textBoxDireccion.Text;
                _empresaActual.Telefono = textBoxTelefono.Text;
                _empresaActual.Email = textBoxEmail.Text;

                bool guardado = await _empresaService.Guardar(_empresaActual);
                if (guardado)
                {
                    MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAgregarTarifa_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<TarifaForm>();
            _ = form.Cargar(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _ = CargarTarifas();
            }
        }

        private async void buttonEditarTarifa_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una tarifa para editar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dataGridViewTarifas.CurrentRow.Cells[0].Value?.ToString(), out var id))
            {
                MessageBox.Show("ID de tarifa no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var tarifa = await _tarifaService.Buscar(id);
                if (tarifa == null)
                {
                    MessageBox.Show("La tarifa no fue encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var form = Program.ServiceProvider.GetRequiredService<TarifaForm>();
                await form.Cargar(tarifa);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await CargarTarifas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar tarifa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
