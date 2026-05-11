using SmartPark.Data.Modelos;
using SmartPark.UI.Services;

namespace SmartPark.UI.Usuarios
{
    public partial class NuevoUsuarioForm : Form
    {
        private readonly UsuarioService _service;
        private Usuario? _editingUsuario;
        private int? _pendingRolId;

        public NuevoUsuarioForm(UsuarioService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void SetUsuario(Usuario usuario)
        {
            _editingUsuario = usuario;
            textBoxNombre.Text = usuario.Nombre;
            textBoxUsuario.Text = usuario.Username;
            _pendingRolId = usuario.RolId;
            textBoxPassword.Text = string.Empty;
            textBoxConfirmar.Text = string.Empty;
            Text = "SmartPark - Editar Usuario";
            groupBoxFormulario.Text = "Editar Usuario";
        }

        private async void NuevoUsuarioForm_Load_1(object sender, EventArgs e)
        {
            var roles = await _service.GetRoles();
            comboBoxRol.DisplayMember = "Nombre";
            comboBoxRol.ValueMember = "Id";
            comboBoxRol.DataSource = roles;

            if (_pendingRolId.HasValue)
            {
                comboBoxRol.SelectedValue = _pendingRolId.Value;
            }
        }

        private async void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            var nombre = textBoxNombre.Text.Trim();
            var username = textBoxUsuario.Text.Trim();
            var password = textBoxPassword.Text;
            var confirmar = textBoxConfirmar.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Nombre y usuario son obligatorios.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editingUsuario == null && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("La clave es obligatoria.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(password)
                && !string.Equals(password, confirmar, StringComparison.Ordinal))
            {
                MessageBox.Show("Las claves no coinciden.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxRol.SelectedValue is not int rolId)
            {
                MessageBox.Show("Seleccione un rol.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario;

            if (_editingUsuario == null)
            {
                usuario = new Usuario
                {
                    Nombre = nombre,
                    Username = username.ToLowerInvariant(),
                    Password = password,
                    RolId = rolId,
                    Activo = true,
                    Eliminado = false,
                    FechaCreacion = DateTime.Now
                };
            }
            else
            {
                usuario = new Usuario
                {
                    Id = _editingUsuario.Id,
                    Nombre = nombre,
                    Username = username.ToLowerInvariant(),
                    Password = string.IsNullOrWhiteSpace(password) ? _editingUsuario.Password : password,
                    RolId = rolId,
                    Activo = _editingUsuario.Activo,
                    Eliminado = _editingUsuario.Eliminado,
                    FechaCreacion = _editingUsuario.FechaCreacion,
                    FechaEliminacion = _editingUsuario.FechaEliminacion
                };
            }

            if (await _service.Guardar(usuario))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("No se pudo guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
