namespace SmartPark.UI.Espacios
{
    public partial class EspaciosList : Form
    {
        public EspaciosList()
        {
            InitializeComponent();
        }

        private void buttonNuevoEspacio_Click(object sender, EventArgs e)
        {
            EspacioForm espacioForm = new EspacioForm();
            espacioForm.ShowDialog();
        }
    }
}
