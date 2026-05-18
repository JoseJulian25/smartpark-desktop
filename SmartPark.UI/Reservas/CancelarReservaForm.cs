using System;
using System.Windows.Forms;

namespace SmartPark.UI.Reservas
{
    public partial class CancelarReservaForm : Form
    {
        public CancelarReservaForm()
        {
            InitializeComponent();
            comboBoxMotivo.SelectedIndex = 0;
        }

        public string MotivoSeleccionado => comboBoxMotivo.SelectedItem?.ToString() ?? string.Empty;

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MotivoSeleccionado))
            {
                MessageBox.Show("Seleccione un motivo de cancelacion.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
