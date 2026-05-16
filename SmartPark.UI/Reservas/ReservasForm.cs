namespace SmartPark.UI.Reservas
{
    public partial class ReservasForm : Form
    {
        public ReservasForm()
        {
            InitializeComponent();
        }

        private void buttonNuevaReserva_Click(object sender, EventArgs e)
        {
            using var form = new NuevaReservaForm();
            form.ShowDialog(this);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
