namespace SmartPark.UI.Reservas
{
    partial class NuevaReservaForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelMain;
        private GroupBox groupBoxFormulario;
        private TextBox textBoxCliente;
        private Label labelCliente;
        private TextBox textBoxPlaca;
        private Label labelPlaca;
        private ComboBox comboBoxTipoVehiculo;
        private Label labelTipoVehiculo;
        private ComboBox comboBoxEspacio;
        private Label labelEspacio;
        private DateTimePicker dateTimeFecha;
        private Label labelFecha;
        private DateTimePicker dateTimeHoraInicio;
        private Label labelHoraInicio;
        private TextBox textBoxCelular;
        private Label labelCelular;
        private Panel panelButtons;
        private Button buttonGuardar;

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
            groupBoxFormulario = new GroupBox();
            textBoxCelular = new TextBox();
            labelCelular = new Label();
            dateTimeHoraInicio = new DateTimePicker();
            labelHoraInicio = new Label();
            dateTimeFecha = new DateTimePicker();
            labelFecha = new Label();
            comboBoxEspacio = new ComboBox();
            labelEspacio = new Label();
            comboBoxTipoVehiculo = new ComboBox();
            labelTipoVehiculo = new Label();
            textBoxPlaca = new TextBox();
            labelPlaca = new Label();
            textBoxCliente = new TextBox();
            labelCliente = new Label();
            panelButtons = new Panel();
            buttonGuardar = new Button();
            panelMain.SuspendLayout();
            groupBoxFormulario.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxFormulario);
            panelMain.Controls.Add(panelButtons);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(640, 520);
            panelMain.TabIndex = 0;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Controls.Add(textBoxCelular);
            groupBoxFormulario.Controls.Add(labelCelular);
            groupBoxFormulario.Controls.Add(dateTimeHoraInicio);
            groupBoxFormulario.Controls.Add(labelHoraInicio);
            groupBoxFormulario.Controls.Add(dateTimeFecha);
            groupBoxFormulario.Controls.Add(labelFecha);
            groupBoxFormulario.Controls.Add(comboBoxEspacio);
            groupBoxFormulario.Controls.Add(labelEspacio);
            groupBoxFormulario.Controls.Add(comboBoxTipoVehiculo);
            groupBoxFormulario.Controls.Add(labelTipoVehiculo);
            groupBoxFormulario.Controls.Add(textBoxPlaca);
            groupBoxFormulario.Controls.Add(labelPlaca);
            groupBoxFormulario.Controls.Add(textBoxCliente);
            groupBoxFormulario.Controls.Add(labelCliente);
            groupBoxFormulario.Dock = DockStyle.Fill;
            groupBoxFormulario.Font = new Font("Segoe UI", 9F);
            groupBoxFormulario.Location = new Point(16, 16);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Padding = new Padding(12, 10, 12, 12);
            groupBoxFormulario.Size = new Size(608, 424);
            groupBoxFormulario.TabIndex = 0;
            groupBoxFormulario.TabStop = false;
            groupBoxFormulario.Text = "Nueva Reserva";
            // 
            // textBoxCelular
            // 
            textBoxCelular.Location = new Point(152, 276);
            textBoxCelular.Name = "textBoxCelular";
            textBoxCelular.Size = new Size(200, 27);
            textBoxCelular.TabIndex = 13;
            // 
            // labelCelular
            // 
            labelCelular.AutoSize = true;
            labelCelular.Location = new Point(24, 280);
            labelCelular.Name = "labelCelular";
            labelCelular.Size = new Size(114, 20);
            labelCelular.TabIndex = 12;
            labelCelular.Text = "Numero celular:";
            // 
            // dateTimeHoraInicio
            // 
            dateTimeHoraInicio.Format = DateTimePickerFormat.Time;
            dateTimeHoraInicio.Location = new Point(152, 232);
            dateTimeHoraInicio.Name = "dateTimeHoraInicio";
            dateTimeHoraInicio.ShowUpDown = true;
            dateTimeHoraInicio.Size = new Size(120, 27);
            dateTimeHoraInicio.TabIndex = 11;
            // 
            // labelHoraInicio
            // 
            labelHoraInicio.AutoSize = true;
            labelHoraInicio.Location = new Point(24, 236);
            labelHoraInicio.Name = "labelHoraInicio";
            labelHoraInicio.Size = new Size(85, 20);
            labelHoraInicio.TabIndex = 10;
            labelHoraInicio.Text = "Hora inicio:";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(152, 188);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(160, 27);
            dateTimeFecha.TabIndex = 9;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(24, 192);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(50, 20);
            labelFecha.TabIndex = 8;
            labelFecha.Text = "Fecha:";
            // 
            // comboBoxEspacio
            // 
            comboBoxEspacio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEspacio.FormattingEnabled = true;
            comboBoxEspacio.Items.AddRange(new object[] { "A-012", "B-025", "C-008" });
            comboBoxEspacio.Location = new Point(152, 144);
            comboBoxEspacio.Name = "comboBoxEspacio";
            comboBoxEspacio.Size = new Size(200, 28);
            comboBoxEspacio.TabIndex = 7;
            // 
            // labelEspacio
            // 
            labelEspacio.AutoSize = true;
            labelEspacio.Location = new Point(24, 148);
            labelEspacio.Name = "labelEspacio";
            labelEspacio.Size = new Size(63, 20);
            labelEspacio.TabIndex = 6;
            labelEspacio.Text = "Espacio:";
            // 
            // comboBoxTipoVehiculo
            // 
            comboBoxTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoVehiculo.FormattingEnabled = true;
            comboBoxTipoVehiculo.Items.AddRange(new object[] { "Auto", "Moto", "Camioneta", "SUV" });
            comboBoxTipoVehiculo.Location = new Point(152, 100);
            comboBoxTipoVehiculo.Name = "comboBoxTipoVehiculo";
            comboBoxTipoVehiculo.Size = new Size(200, 28);
            comboBoxTipoVehiculo.TabIndex = 5;
            // 
            // labelTipoVehiculo
            // 
            labelTipoVehiculo.AutoSize = true;
            labelTipoVehiculo.Location = new Point(24, 104);
            labelTipoVehiculo.Name = "labelTipoVehiculo";
            labelTipoVehiculo.Size = new Size(122, 20);
            labelTipoVehiculo.TabIndex = 4;
            labelTipoVehiculo.Text = "Tipo de vehiculo:";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(152, 64);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(150, 27);
            textBoxPlaca.TabIndex = 3;
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(24, 68);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(47, 20);
            labelPlaca.TabIndex = 2;
            labelPlaca.Text = "Placa:";
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(152, 28);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(320, 27);
            textBoxCliente.TabIndex = 1;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(24, 32);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(58, 20);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente:";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonGuardar);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(16, 440);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(0, 10, 0, 0);
            panelButtons.Size = new Size(608, 64);
            panelButtons.TabIndex = 1;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(232, 13);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(130, 36);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // NuevaReservaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 520);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NuevaReservaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Nueva Reserva";
            panelMain.ResumeLayout(false);
            groupBoxFormulario.ResumeLayout(false);
            groupBoxFormulario.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
