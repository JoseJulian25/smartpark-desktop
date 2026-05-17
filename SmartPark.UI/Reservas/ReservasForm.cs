using Microsoft.Extensions.DependencyInjection;

namespace SmartPark.UI.Reservas
{
    public partial class ReservasForm : Form
    {
        private readonly Services.ReservaService _service;

        public ReservasForm(Services.ReservaService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void ReservasForm_Load_1(object sender, EventArgs e)
        {
            dateTimeFecha.Value = DateTime.Today;
            comboBoxEstado.SelectedItem ??= "Todos";
            await CargarAsync();
        }

        private void buttonNuevaReserva_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevaReservaForm>();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = CargarAsync();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservas.CurrentRow == null)
                return;

            if (!long.TryParse(Convert.ToString(dataGridViewReservas.CurrentRow.Cells[0].Value), out var id))
                return;

            _ = EditarReservaAsync(id);
        }

        private async Task EditarReservaAsync(long id)
        {
            var reserva = await _service.Buscar(id);
            if (reserva == null)
                return;

            var form = Program.ServiceProvider.GetRequiredService<NuevaReservaForm>();
            form.SetReserva(reserva);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                await CargarAsync();
            }
        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            await CargarAsync();
        }

        private async void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservas.CurrentRow == null)
                return;

            if (!long.TryParse(Convert.ToString(dataGridViewReservas.CurrentRow.Cells[0].Value), out var id))
                return;

            var confirmacion = MessageBox.Show(
                "¿Deseas confirmar esta reserva?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            if (await _service.ConfirmarReserva(id))
            {
                await CargarAsync();
                return;
            }

            MessageBox.Show("No se pudo confirmar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task CargarAsync()
        {
            var estado = comboBoxEstado.SelectedItem?.ToString() ?? "Todos";
            var cliente = textBoxCliente.Text.Trim();
            var fecha = dateTimeFecha.Value;

            var items = await _service.GetReservas(fecha, estado, cliente);
            dataGridViewReservas.Rows.Clear();

            foreach (var item in items)
            {
                dataGridViewReservas.Rows.Add(
                    item.Id,
                    item.ClienteNombreCompleto,
                    item.Placa,
                    item.TipoVehiculo?.Nombre ?? string.Empty,
                    item.Espacio?.CodigoEspacio ?? string.Empty,
                    item.HoraInicio.ToString("yyyy-MM-dd"),
                    item.HoraInicio.ToString("HH:mm"),
                    item.HoraFin?.ToString("HH:mm") ?? string.Empty,
                    item.Estado,
                    string.Empty);
            }
        }

       
    }
}
