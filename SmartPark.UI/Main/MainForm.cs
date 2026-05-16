using SmartPark.UI.Espacios;
using SmartPark.UI.Configuracion;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SmartPark.UI.EntradasSalidas;
using SmartPark.UI.Usuarios;
using SmartPark.UI.Consultas;
using SmartPark.UI.Reservas;

namespace SmartPark.UI.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonReservas.Click += buttonReservas_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusUsuario.Text = $"Usuario: {Program.UsuarioActual?.Nombre ?? "Desconocido"}";
        }

        private void buttonEspacios_Click(object sender, EventArgs e)
        {
            var espaciosList = Program.ServiceProvider.GetRequiredService<EspaciosList>();
            espaciosList.ShowDialog();
        }

        private void buttonEntradasSalidas_Click(object sender, EventArgs e)
        {
            var entradasSalidasForm = Program.ServiceProvider.GetRequiredService<EntradasSalidasForm>();
            entradasSalidasForm.ShowDialog();
        }

        private void buttonUsuarios_Click(object? sender, EventArgs e)
        {
            var usuariosForm = Program.ServiceProvider.GetRequiredService<UsuariosForm>();
            usuariosForm.ShowDialog();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            var consultasForm = Program.ServiceProvider.GetRequiredService<ConsultasForm>();
            consultasForm.ShowDialog();
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            var configuracionForm = Program.ServiceProvider.GetRequiredService<ConfiguracionForm>();
            configuracionForm.ShowDialog();
        }

        private void buttonReservas_Click(object? sender, EventArgs e)
        {
            var reservasForm = Program.ServiceProvider.GetRequiredService<ReservasForm>();
            reservasForm.ShowDialog();
        }

    }
}
