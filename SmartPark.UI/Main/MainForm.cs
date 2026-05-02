using SmartPark.UI.Espacios;
using SmartPark.UI.Configuracion;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SmartPark.UI.EntradasSalidas;

namespace SmartPark.UI.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonConfiguracion.Click += buttonConfiguracion_Click;
        }

        private void buttonEspacios_Click(object sender, EventArgs e)
        {
            var espaciosList = Program.ServiceProvider.GetRequiredService<EspaciosList>();
            espaciosList.ShowDialog();
        }

        private void buttonConfiguracion_Click(object? sender, EventArgs e)
        {
            var configuracionForm = Program.ServiceProvider.GetRequiredService<ConfiguracionForm>();
            configuracionForm.ShowDialog();
        }

        private void buttonEntradasSalidas_Click(object sender, EventArgs e)
        {
            var entradasSalidasForm = Program.ServiceProvider.GetRequiredService<EntradasSalidasForm>();
            entradasSalidasForm.ShowDialog();
        }
    }
}
