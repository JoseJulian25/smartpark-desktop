using SmartPark.UI.Espacios;

namespace SmartPark.UI.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEspacios_Click(object sender, EventArgs e)
        {
            EspaciosList espaciosList = new EspaciosList();
            espaciosList.ShowDialog();
        }
    }
}
