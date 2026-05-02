namespace SmartPark.UI.Espacios
{
    partial class EspacioForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            groupBoxDatosEspacio = new GroupBox();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            comboBoxEstado = new ComboBox();
            comboBoxTipo = new ComboBox();
            textBoxVehiculoActual = new TextBox();
            textBoxCodigo = new TextBox();
            labelVehiculoActual = new Label();
            labelEstado = new Label();
            labelTipo = new Label();
            labelCodigo = new Label();
            panelMain.SuspendLayout();
            groupBoxDatosEspacio.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxDatosEspacio);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(620, 390);
            panelMain.TabIndex = 0;
            // 
            // groupBoxDatosEspacio
            // 
            groupBoxDatosEspacio.Controls.Add(buttonCancelar);
            groupBoxDatosEspacio.Controls.Add(buttonGuardar);
            groupBoxDatosEspacio.Controls.Add(comboBoxEstado);
            groupBoxDatosEspacio.Controls.Add(comboBoxTipo);
            groupBoxDatosEspacio.Controls.Add(textBoxVehiculoActual);
            groupBoxDatosEspacio.Controls.Add(textBoxCodigo);
            groupBoxDatosEspacio.Controls.Add(labelVehiculoActual);
            groupBoxDatosEspacio.Controls.Add(labelEstado);
            groupBoxDatosEspacio.Controls.Add(labelTipo);
            groupBoxDatosEspacio.Controls.Add(labelCodigo);
            groupBoxDatosEspacio.Dock = DockStyle.Fill;
            groupBoxDatosEspacio.Font = new Font("Segoe UI", 9F);
            groupBoxDatosEspacio.Location = new Point(16, 16);
            groupBoxDatosEspacio.Name = "groupBoxDatosEspacio";
            groupBoxDatosEspacio.Padding = new Padding(14);
            groupBoxDatosEspacio.Size = new Size(588, 358);
            groupBoxDatosEspacio.TabIndex = 0;
            groupBoxDatosEspacio.TabStop = false;
            groupBoxDatosEspacio.Text = "Espacio";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(18, 38);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(58, 20);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(150, 34);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(180, 27);
            textBoxCodigo.TabIndex = 1;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(18, 82);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(42, 20);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Auto", "Moto", "Camioneta", "SUV" });
            comboBoxTipo.Location = new Point(150, 78);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(180, 28);
            comboBoxTipo.TabIndex = 3;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(18, 126);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(58, 20);
            labelEstado.TabIndex = 4;
            labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Libre", "Ocupado", "Reservado", "Mantenimiento" });
            comboBoxEstado.Location = new Point(150, 122);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(180, 28);
            comboBoxEstado.TabIndex = 5;
            // 
            // labelVehiculoActual
            // 
            labelVehiculoActual.AutoSize = true;
            labelVehiculoActual.Location = new Point(18, 170);
            labelVehiculoActual.Name = "labelVehiculoActual";
            labelVehiculoActual.Size = new Size(115, 20);
            labelVehiculoActual.TabIndex = 6;
            labelVehiculoActual.Text = "Vehículo actual:";
            // 
            // textBoxVehiculoActual
            // 
            textBoxVehiculoActual.Location = new Point(150, 166);
            textBoxVehiculoActual.Name = "textBoxVehiculoActual";
            textBoxVehiculoActual.Size = new Size(260, 27);
            textBoxVehiculoActual.TabIndex = 7;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(150, 224);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(110, 36);
            buttonGuardar.TabIndex = 8;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.Location = new Point(266, 224);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(110, 36);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // EspacioEditorForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(620, 390);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(636, 429);
            Name = "EspacioEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Espacio";
            panelMain.ResumeLayout(false);
            groupBoxDatosEspacio.ResumeLayout(false);
            groupBoxDatosEspacio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private GroupBox groupBoxDatosEspacio;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private ComboBox comboBoxEstado;
        private ComboBox comboBoxTipo;
        private TextBox textBoxVehiculoActual;
        private TextBox textBoxCodigo;
        private Label labelVehiculoActual;
        private Label labelEstado;
        private Label labelTipo;
        private Label labelCodigo;
    }
}
