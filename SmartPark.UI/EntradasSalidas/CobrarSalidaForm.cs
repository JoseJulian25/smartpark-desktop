using SmartPark.Data.Modelos;

namespace SmartPark.UI.EntradasSalidas
{
    public partial class CobrarSalidaForm : Form
    {
        private int _vehiculoId;

        public CobrarSalidaForm()
        {
            InitializeComponent();
        }

        public void CargarVehiculo(int vehiculoId)
        {
            _vehiculoId = vehiculoId;
            // TODO: Cargar detalles del vehículo desde la base de datos
        }

        private void buttonRegistrarCobro_Click(object sender, EventArgs e)
        {
            // TODO: Registrar el cobro y salida del vehículo
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
