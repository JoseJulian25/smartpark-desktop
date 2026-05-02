using System.Linq;
using SmartPark.UI.Services;

namespace SmartPark.UI.Espacios
{
    public partial class EspaciosList : Form
    {
        private readonly EspaciosService _service;

        public EspaciosList(EspaciosService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void EspaciosList_Load(object sender, EventArgs e)
        {
            await CargarAsync();
        }

        private void EspaciosList_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // No dispose here - service is managed by DI container
        }

        private async Task CargarAsync()
        {
            var espacios = await _service.GetList(_ => true);

            labelTotalValue.Text = espacios.Count.ToString();
            labelLibresValue.Text = espacios.Count(x => x.Estado != null && x.Estado.Nombre == "LIBRE").ToString();
            labelOcupadosValue.Text = espacios.Count(x => x.Estado != null && x.Estado.Nombre == "OCUPADO").ToString();
            labelReservadosValue.Text = espacios.Count(x => x.Estado != null && x.Estado.Nombre == "RESERVADO").ToString();

            dataGridViewEspacios.Rows.Clear();

            foreach (var espacio in espacios)
            {
                dataGridViewEspacios.Rows.Add(
                    espacio.Id,
                    espacio.CodigoEspacio,
                    espacio.TipoVehiculo?.Nombre ?? string.Empty,
                    espacio.Estado?.Nombre ?? string.Empty,
                    string.Empty);
            }
        }

        private async void buttonEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewEspacios.CurrentRow == null)
                return;

            if (!long.TryParse(Convert.ToString(dataGridViewEspacios.CurrentRow.Cells[0].Value), out var id))
                return;

            using var servicio = new EspaciosService();
            using var espacioForm = new EspacioForm(servicio);
            await espacioForm.Buscar(id);

            if (espacioForm.ShowDialog() == DialogResult.OK)
                await CargarAsync();
        }

        private async void buttonNuevoEspacio_Click(object sender, EventArgs e)
        {
            using var servicio = new EspaciosService();
            using var espacioForm = new EspacioForm(servicio);

            if (espacioForm.ShowDialog() == DialogResult.OK)
                await CargarAsync();
        }

        private async void buttonEliminar_Click(object? sender, EventArgs e)
        {
            if (dataGridViewEspacios.CurrentRow == null) return;

            if (!long.TryParse(Convert.ToString(dataGridViewEspacios.CurrentRow.Cells[0].Value), out var id))
                return;

            var confirmacion = MessageBox.Show("¿Deseas eliminar este espacio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            if (await _service.Eliminar(id))
                await CargarAsync();
        }
    }
}
