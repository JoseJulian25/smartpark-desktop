using SmartPark.Data.Modelos;
using SmartPark.UI.Services;

namespace SmartPark.UI.Acceso
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService _service;

        public Usuario? UsuarioAutenticado { get; private set; }

        public LoginForm(UsuarioService service)
        {
            InitializeComponent();
            _service = service;

            buttonIniciar.Click += buttonIniciar_Click;

            AcceptButton = buttonIniciar;

            textBoxUsuario.Select();
        }

        private async void buttonIniciar_Click(object? sender, EventArgs e)
        {
            var username = textBoxUsuario.Text.Trim();
            var password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Usuario y clave son obligatorios.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleLoading(true);

            try
            {
                var usuario = await _service.IniciarSesionAsync(username, password);
                if (usuario == null)
                {
                    MessageBox.Show("Credenciales invalidas", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioAutenticado = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            finally
            {
                ToggleLoading(false);
            }
        }

        private void ToggleLoading(bool loading)
        {
            buttonIniciar.Enabled = !loading;
            textBoxUsuario.Enabled = !loading;
            textBoxPassword.Enabled = !loading;
            Cursor = loading ? Cursors.WaitCursor : Cursors.Default;
        }
    }
}
