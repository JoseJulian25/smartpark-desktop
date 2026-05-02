using Microsoft.Extensions.DependencyInjection;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.EntradasSalidas
{
    public partial class EntradasSalidasForm : Form
    {
        public EntradasSalidasForm()
        {
            InitializeComponent();
        }

        private void EntradasSalidasForm_Load(object sender, EventArgs e)
        {
            textBoxHoraEntrada.Text = DateTime.Now.ToString("HH:mm");
        }

        private void buttonGuardarEntrada_Click(object sender, EventArgs e)
        {

        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un vehículo para procesar el cobro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dataGridViewVehiculos.CurrentRow.Cells[0].Value?.ToString(), out var id))
            {
                MessageBox.Show("ID de vehículo no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = Program.ServiceProvider.GetRequiredService<CobrarSalidaForm>();
            form.CargarVehiculo(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _ = Task.Run(() => buttonActualizar_Click(null, null));
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}

