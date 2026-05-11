using Microsoft.Extensions.DependencyInjection;
using SmartPark.Data.Modelos;
using SmartPark.UI.Services;

namespace SmartPark.UI.Usuarios
{
    public partial class UsuariosForm : Form
    {
        private readonly UsuarioService _service;

        public UsuariosForm(UsuarioService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void UsuariosForm_Load_1(object sender, EventArgs e)
        {
            await CargarAsync();
        }

        private async Task CargarAsync(string? filtro = null)
        {
            var texto = filtro?.Trim();
            List<Usuario> usuarios;

            if (string.IsNullOrWhiteSpace(texto))
            {
                usuarios = await _service.GetList(u => !u.Eliminado);
            }
            else
            {
                usuarios = await _service.GetList(u => !u.Eliminado
                    && (u.Nombre.Contains(texto) || u.Username.Contains(texto)));
            }

            dataGridViewUsuarios.Rows.Clear();

            foreach (var usuario in usuarios)
            {
                var estado = usuario.Activo ? "Activo" : "Inactivo";
                var fecha = usuario.FechaCreacion?.ToString("yyyy-MM-dd HH:mm") ?? string.Empty;

                dataGridViewUsuarios.Rows.Add(
                    usuario.Id,
                    usuario.Nombre,
                    usuario.Username,
                    usuario.Rol?.Nombre ?? string.Empty,
                    estado,
                    fecha);
            }
        }

        private void buttonLimpiar_Click(object? sender, EventArgs e)
        {
            textBoxBuscar.Text = string.Empty;
            _ = CargarAsync();
        }


        private void buttonNuevo_Click(object? sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<NuevoUsuarioForm>();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = CargarAsync(textBoxBuscar.Text);
            }
        }

        private async void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            _ = CargarAsync(textBoxBuscar.Text);
        }

        private async void buttonEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.CurrentRow == null)
                return;

            if (!long.TryParse(Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells[0].Value), out var id))
                return;

            var usuario = await _service.Buscar(id);
            if (usuario == null)
                return;

            var form = Program.ServiceProvider.GetRequiredService<NuevoUsuarioForm>();
            form.SetUsuario(usuario);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = CargarAsync(textBoxBuscar.Text);
            }
        }

        private async void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.CurrentRow == null)
                return;

            if (!long.TryParse(Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells[0].Value), out var id))
                return;

            var confirmacion = MessageBox.Show(
                "¿Deseas desactivar este usuario?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            if (await _service.Eliminar(id))
            {
                await CargarAsync(textBoxBuscar.Text);
            }
        }
    }
}
