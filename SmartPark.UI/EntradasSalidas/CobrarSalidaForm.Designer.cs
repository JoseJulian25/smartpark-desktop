namespace SmartPark.UI.EntradasSalidas
{
    partial class CobrarSalidaForm
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
            groupBoxDetalles = new GroupBox();
            tableLayoutPanel = new TableLayoutPanel();
            labelTicket = new Label();
            textBoxTicket = new TextBox();
            labelPlaca = new Label();
            textBoxPlaca = new TextBox();
            labelTipo = new Label();
            textBoxTipo = new TextBox();
            labelEspacio = new Label();
            textBoxEspacio = new TextBox();
            labelHoraEntrada = new Label();
            textBoxHoraEntrada = new TextBox();
            labelHoraSalida = new Label();
            textBoxHoraSalida = new TextBox();
            labelTiempoTranscurrido = new Label();
            textBoxTiempoTranscurrido = new TextBox();
            labelMontoACobrar = new Label();
            textBoxMontoACobrar = new TextBox();
            panelBotones = new Panel();
            buttonRegistrarCobro = new Button();
            buttonCancelar = new Button();

            panelMain.SuspendLayout();
            groupBoxDetalles.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();

            // panelMain
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxDetalles);
            panelMain.Controls.Add(panelBotones);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(600, 450);
            panelMain.TabIndex = 0;

            // groupBoxDetalles
            groupBoxDetalles.Controls.Add(tableLayoutPanel);
            groupBoxDetalles.Dock = DockStyle.Fill;
            groupBoxDetalles.Font = new Font("Segoe UI", 9F);
            groupBoxDetalles.Location = new Point(16, 16);
            groupBoxDetalles.Name = "groupBoxDetalles";
            groupBoxDetalles.Padding = new Padding(12);
            groupBoxDetalles.Size = new Size(568, 380);
            groupBoxDetalles.TabIndex = 0;
            groupBoxDetalles.TabStop = false;
            groupBoxDetalles.Text = "Detalles del Vehículo";

            // tableLayoutPanel
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelTicket, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxTicket, 1, 0);
            tableLayoutPanel.Controls.Add(labelPlaca, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxPlaca, 1, 1);
            tableLayoutPanel.Controls.Add(labelTipo, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxTipo, 1, 2);
            tableLayoutPanel.Controls.Add(labelEspacio, 0, 3);
            tableLayoutPanel.Controls.Add(textBoxEspacio, 1, 3);
            tableLayoutPanel.Controls.Add(labelHoraEntrada, 0, 4);
            tableLayoutPanel.Controls.Add(textBoxHoraEntrada, 1, 4);
            tableLayoutPanel.Controls.Add(labelHoraSalida, 0, 5);
            tableLayoutPanel.Controls.Add(textBoxHoraSalida, 1, 5);
            tableLayoutPanel.Controls.Add(labelTiempoTranscurrido, 0, 6);
            tableLayoutPanel.Controls.Add(textBoxTiempoTranscurrido, 1, 6);
            tableLayoutPanel.Controls.Add(labelMontoACobrar, 0, 7);
            tableLayoutPanel.Controls.Add(textBoxMontoACobrar, 1, 7);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(12, 32);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 8;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.Size = new Size(544, 336);
            tableLayoutPanel.TabIndex = 0;

            // labelTicket
            labelTicket.Anchor = AnchorStyles.Left;
            labelTicket.AutoSize = true;
            labelTicket.Location = new Point(3, 6);
            labelTicket.Name = "labelTicket";
            labelTicket.Size = new Size(54, 20);
            labelTicket.TabIndex = 0;
            labelTicket.Text = "Ticket:";

            // textBoxTicket
            textBoxTicket.Dock = DockStyle.Fill;
            textBoxTicket.Enabled = false;
            textBoxTicket.Location = new Point(143, 3);
            textBoxTicket.Name = "textBoxTicket";
            textBoxTicket.Size = new Size(398, 27);
            textBoxTicket.TabIndex = 1;

            // labelPlaca
            labelPlaca.Anchor = AnchorStyles.Left;
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(3, 39);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(47, 20);
            labelPlaca.TabIndex = 2;
            labelPlaca.Text = "Placa:";

            // textBoxPlaca
            textBoxPlaca.Dock = DockStyle.Fill;
            textBoxPlaca.Enabled = false;
            textBoxPlaca.Location = new Point(143, 36);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(398, 27);
            textBoxPlaca.TabIndex = 3;

            // labelTipo
            labelTipo.Anchor = AnchorStyles.Left;
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(3, 72);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(38, 20);
            labelTipo.TabIndex = 4;
            labelTipo.Text = "Tipo:";

            // textBoxTipo
            textBoxTipo.Dock = DockStyle.Fill;
            textBoxTipo.Enabled = false;
            textBoxTipo.Location = new Point(143, 69);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(398, 27);
            textBoxTipo.TabIndex = 5;

            // labelEspacio
            labelEspacio.Anchor = AnchorStyles.Left;
            labelEspacio.AutoSize = true;
            labelEspacio.Location = new Point(3, 105);
            labelEspacio.Name = "labelEspacio";
            labelEspacio.Size = new Size(69, 20);
            labelEspacio.TabIndex = 6;
            labelEspacio.Text = "Espacio:";

            // textBoxEspacio
            textBoxEspacio.Dock = DockStyle.Fill;
            textBoxEspacio.Enabled = false;
            textBoxEspacio.Location = new Point(143, 102);
            textBoxEspacio.Name = "textBoxEspacio";
            textBoxEspacio.Size = new Size(398, 27);
            textBoxEspacio.TabIndex = 7;

            // labelHoraEntrada
            labelHoraEntrada.Anchor = AnchorStyles.Left;
            labelHoraEntrada.AutoSize = true;
            labelHoraEntrada.Location = new Point(3, 138);
            labelHoraEntrada.Name = "labelHoraEntrada";
            labelHoraEntrada.Size = new Size(103, 20);
            labelHoraEntrada.TabIndex = 8;
            labelHoraEntrada.Text = "Hora Entrada:";

            // textBoxHoraEntrada
            textBoxHoraEntrada.Dock = DockStyle.Fill;
            textBoxHoraEntrada.Enabled = false;
            textBoxHoraEntrada.Location = new Point(143, 135);
            textBoxHoraEntrada.Name = "textBoxHoraEntrada";
            textBoxHoraEntrada.Size = new Size(398, 27);
            textBoxHoraEntrada.TabIndex = 9;

            // labelHoraSalida
            labelHoraSalida.Anchor = AnchorStyles.Left;
            labelHoraSalida.AutoSize = true;
            labelHoraSalida.Location = new Point(3, 171);
            labelHoraSalida.Name = "labelHoraSalida";
            labelHoraSalida.Size = new Size(90, 20);
            labelHoraSalida.TabIndex = 10;
            labelHoraSalida.Text = "Hora Salida:";

            // textBoxHoraSalida
            textBoxHoraSalida.Dock = DockStyle.Fill;
            textBoxHoraSalida.Enabled = false;
            textBoxHoraSalida.Location = new Point(143, 168);
            textBoxHoraSalida.Name = "textBoxHoraSalida";
            textBoxHoraSalida.Size = new Size(398, 27);
            textBoxHoraSalida.TabIndex = 11;

            // labelTiempoTranscurrido
            labelTiempoTranscurrido.Anchor = AnchorStyles.Left;
            labelTiempoTranscurrido.AutoSize = true;
            labelTiempoTranscurrido.Location = new Point(3, 204);
            labelTiempoTranscurrido.Name = "labelTiempoTranscurrido";
            labelTiempoTranscurrido.Size = new Size(127, 20);
            labelTiempoTranscurrido.TabIndex = 12;
            labelTiempoTranscurrido.Text = "Tiempo Transcurrido:";

            // textBoxTiempoTranscurrido
            textBoxTiempoTranscurrido.Dock = DockStyle.Fill;
            textBoxTiempoTranscurrido.Enabled = false;
            textBoxTiempoTranscurrido.Location = new Point(143, 201);
            textBoxTiempoTranscurrido.Name = "textBoxTiempoTranscurrido";
            textBoxTiempoTranscurrido.Size = new Size(398, 27);
            textBoxTiempoTranscurrido.TabIndex = 13;

            // labelMontoACobrar
            labelMontoACobrar.Anchor = AnchorStyles.Left;
            labelMontoACobrar.AutoSize = true;
            labelMontoACobrar.Location = new Point(3, 237);
            labelMontoACobrar.Name = "labelMontoACobrar";
            labelMontoACobrar.Size = new Size(120, 20);
            labelMontoACobrar.TabIndex = 14;
            labelMontoACobrar.Text = "Monto a Cobrar:";

            // textBoxMontoACobrar
            textBoxMontoACobrar.Dock = DockStyle.Fill;
            textBoxMontoACobrar.Enabled = false;
            textBoxMontoACobrar.Location = new Point(143, 234);
            textBoxMontoACobrar.Name = "textBoxMontoACobrar";
            textBoxMontoACobrar.Size = new Size(398, 27);
            textBoxMontoACobrar.TabIndex = 15;

            // panelBotones
            panelBotones.Controls.Add(buttonRegistrarCobro);
            panelBotones.Controls.Add(buttonCancelar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(16, 396);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(568, 38);
            panelBotones.TabIndex = 1;

            // buttonRegistrarCobro
            buttonRegistrarCobro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRegistrarCobro.BackColor = Color.FromArgb(31, 118, 221);
            buttonRegistrarCobro.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonRegistrarCobro.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonRegistrarCobro.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonRegistrarCobro.FlatStyle = FlatStyle.Flat;
            buttonRegistrarCobro.ForeColor = Color.White;
            buttonRegistrarCobro.Location = new Point(388, 4);
            buttonRegistrarCobro.Name = "buttonRegistrarCobro";
            buttonRegistrarCobro.Size = new Size(140, 32);
            buttonRegistrarCobro.TabIndex = 0;
            buttonRegistrarCobro.Text = "Registrar Cobro";
            buttonRegistrarCobro.UseVisualStyleBackColor = false;
            buttonRegistrarCobro.Click += buttonRegistrarCobro_Click;

            // buttonCancelar
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.Location = new Point(468, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(100, 32);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;

            // CobrarSalidaForm
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(600, 450);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(616, 489);
            Name = "CobrarSalidaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Procesar Cobro";
            panelMain.ResumeLayout(false);
            groupBoxDetalles.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private GroupBox groupBoxDetalles;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelTicket;
        private TextBox textBoxTicket;
        private Label labelPlaca;
        private TextBox textBoxPlaca;
        private Label labelTipo;
        private TextBox textBoxTipo;
        private Label labelEspacio;
        private TextBox textBoxEspacio;
        private Label labelHoraEntrada;
        private TextBox textBoxHoraEntrada;
        private Label labelHoraSalida;
        private TextBox textBoxHoraSalida;
        private Label labelTiempoTranscurrido;
        private TextBox textBoxTiempoTranscurrido;
        private Label labelMontoACobrar;
        private TextBox textBoxMontoACobrar;
        private Panel panelBotones;
        private Button buttonRegistrarCobro;
        private Button buttonCancelar;
    }
}
