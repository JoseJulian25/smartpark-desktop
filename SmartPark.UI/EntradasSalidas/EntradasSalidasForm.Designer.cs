namespace SmartPark.UI.EntradasSalidas
{
    partial class EntradasSalidasForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelMain = new Panel();
            groupBoxVehiculos = new GroupBox();
            dataGridViewVehiculos = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnTicket = new DataGridViewTextBoxColumn();
            columnPlaca = new DataGridViewTextBoxColumn();
            columnTipo = new DataGridViewTextBoxColumn();
            columnEspacio = new DataGridViewTextBoxColumn();
            columnEntrada = new DataGridViewTextBoxColumn();
            columnTiempo = new DataGridViewTextBoxColumn();
            panelBotonesVehiculos = new Panel();
            buttonCobrar = new Button();
            buttonActualizar = new Button();
            groupBoxEntrada = new GroupBox();
            tableLayoutPanelEntrada = new TableLayoutPanel();
            labelPlaca = new Label();
            textBoxPlaca = new TextBox();
            labelTipoVehiculo = new Label();
            comboBoxTipoVehiculo = new ComboBox();
            labelEspacioAsignado = new Label();
            comboBoxEspacioAsignado = new ComboBox();
            labelHoraEntrada = new Label();
            textBoxHoraEntrada = new TextBox();
            panelBotoneEntrada = new Panel();
            buttonGuardarEntrada = new Button();
            panelMain.SuspendLayout();
            groupBoxVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            panelBotonesVehiculos.SuspendLayout();
            groupBoxEntrada.SuspendLayout();
            tableLayoutPanelEntrada.SuspendLayout();
            panelBotoneEntrada.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxVehiculos);
            panelMain.Controls.Add(groupBoxEntrada);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(1207, 800);
            panelMain.TabIndex = 0;
            // 
            // groupBoxVehiculos
            // 
            groupBoxVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxVehiculos.Controls.Add(dataGridViewVehiculos);
            groupBoxVehiculos.Controls.Add(panelBotonesVehiculos);
            groupBoxVehiculos.Font = new Font("Segoe UI", 9F);
            groupBoxVehiculos.Location = new Point(12, 264);
            groupBoxVehiculos.MinimumSize = new Size(1168, 467);
            groupBoxVehiculos.Name = "groupBoxVehiculos";
            groupBoxVehiculos.Padding = new Padding(11, 12, 11, 12);
            groupBoxVehiculos.Size = new Size(1179, 517);
            groupBoxVehiculos.TabIndex = 1;
            groupBoxVehiculos.TabStop = false;
            groupBoxVehiculos.Text = "Vehículos Actuales en el Parqueo";
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.AllowUserToAddRows = false;
            dataGridViewVehiculos.AllowUserToDeleteRows = false;
            dataGridViewVehiculos.AllowUserToResizeRows = false;
            dataGridViewVehiculos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVehiculos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Columns.AddRange(new DataGridViewColumn[] { columnId, columnTicket, columnPlaca, columnTipo, columnEspacio, columnEntrada, columnTiempo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewVehiculos.Location = new Point(11, 25);
            dataGridViewVehiculos.MinimumSize = new Size(1155, 429);
            dataGridViewVehiculos.MultiSelect = false;
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.ReadOnly = true;
            dataGridViewVehiculos.RowHeadersVisible = false;
            dataGridViewVehiculos.RowHeadersWidth = 51;
            dataGridViewVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVehiculos.Size = new Size(1156, 429);
            dataGridViewVehiculos.TabIndex = 0;
            // 
            // columnId
            // 
            columnId.HeaderText = "ID";
            columnId.MinimumWidth = 6;
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            columnId.Visible = false;
            columnId.Width = 50;
            // 
            // columnTicket
            // 
            columnTicket.HeaderText = "Ticket";
            columnTicket.MinimumWidth = 6;
            columnTicket.Name = "columnTicket";
            columnTicket.ReadOnly = true;
            columnTicket.Width = 200;
            // 
            // columnPlaca
            // 
            columnPlaca.HeaderText = "Placa";
            columnPlaca.MinimumWidth = 6;
            columnPlaca.Name = "columnPlaca";
            columnPlaca.ReadOnly = true;
            columnPlaca.Width = 150;
            // 
            // columnTipo
            // 
            columnTipo.HeaderText = "Tipo";
            columnTipo.MinimumWidth = 6;
            columnTipo.Name = "columnTipo";
            columnTipo.ReadOnly = true;
            columnTipo.Width = 125;
            // 
            // columnEspacio
            // 
            columnEspacio.HeaderText = "Espacio";
            columnEspacio.MinimumWidth = 6;
            columnEspacio.Name = "columnEspacio";
            columnEspacio.ReadOnly = true;
            columnEspacio.Width = 170;
            // 
            // columnEntrada
            // 
            columnEntrada.HeaderText = "Entrada";
            columnEntrada.MinimumWidth = 6;
            columnEntrada.Name = "columnEntrada";
            columnEntrada.ReadOnly = true;
            columnEntrada.Width = 170;
            // 
            // columnTiempo
            // 
            columnTiempo.HeaderText = "Tiempo Transcurrido";
            columnTiempo.MinimumWidth = 6;
            columnTiempo.Name = "columnTiempo";
            columnTiempo.ReadOnly = true;
            columnTiempo.Width = 200;
            // 
            // panelBotonesVehiculos
            // 
            panelBotonesVehiculos.Controls.Add(buttonCobrar);
            panelBotonesVehiculos.Controls.Add(buttonActualizar);
            panelBotonesVehiculos.Dock = DockStyle.Bottom;
            panelBotonesVehiculos.Location = new Point(11, 460);
            panelBotonesVehiculos.Name = "panelBotonesVehiculos";
            panelBotonesVehiculos.Size = new Size(1157, 45);
            panelBotonesVehiculos.TabIndex = 1;
            // 
            // buttonCobrar
            // 
            buttonCobrar.BackColor = Color.FromArgb(31, 118, 221);
            buttonCobrar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonCobrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonCobrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonCobrar.FlatStyle = FlatStyle.Flat;
            buttonCobrar.ForeColor = Color.White;
            buttonCobrar.Location = new Point(0, 0);
            buttonCobrar.Name = "buttonCobrar";
            buttonCobrar.Size = new Size(101, 43);
            buttonCobrar.TabIndex = 0;
            buttonCobrar.Text = "Cobrar";
            buttonCobrar.UseVisualStyleBackColor = false;
            buttonCobrar.Click += buttonCobrar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.White;
            buttonActualizar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonActualizar.Location = new Point(106, 0);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(110, 43);
            buttonActualizar.TabIndex = 1;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // groupBoxEntrada
            // 
            groupBoxEntrada.Controls.Add(tableLayoutPanelEntrada);
            groupBoxEntrada.Controls.Add(panelBotoneEntrada);
            groupBoxEntrada.Dock = DockStyle.Top;
            groupBoxEntrada.Font = new Font("Segoe UI", 9F);
            groupBoxEntrada.Location = new Point(16, 16);
            groupBoxEntrada.Name = "groupBoxEntrada";
            groupBoxEntrada.Padding = new Padding(11, 12, 11, 12);
            groupBoxEntrada.Size = new Size(1175, 221);
            groupBoxEntrada.TabIndex = 0;
            groupBoxEntrada.TabStop = false;
            groupBoxEntrada.Text = "Registrar Entrada de Vehículo";
            // 
            // tableLayoutPanelEntrada
            // 
            tableLayoutPanelEntrada.ColumnCount = 2;
            tableLayoutPanelEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanelEntrada.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEntrada.Controls.Add(labelPlaca, 0, 0);
            tableLayoutPanelEntrada.Controls.Add(textBoxPlaca, 1, 0);
            tableLayoutPanelEntrada.Controls.Add(labelTipoVehiculo, 0, 1);
            tableLayoutPanelEntrada.Controls.Add(comboBoxTipoVehiculo, 1, 1);
            tableLayoutPanelEntrada.Controls.Add(labelEspacioAsignado, 0, 2);
            tableLayoutPanelEntrada.Controls.Add(comboBoxEspacioAsignado, 1, 2);
            tableLayoutPanelEntrada.Controls.Add(labelHoraEntrada, 0, 3);
            tableLayoutPanelEntrada.Controls.Add(textBoxHoraEntrada, 1, 3);
            tableLayoutPanelEntrada.Dock = DockStyle.Fill;
            tableLayoutPanelEntrada.Location = new Point(11, 32);
            tableLayoutPanelEntrada.Name = "tableLayoutPanelEntrada";
            tableLayoutPanelEntrada.RowCount = 4;
            tableLayoutPanelEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEntrada.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEntrada.Size = new Size(1153, 132);
            tableLayoutPanelEntrada.TabIndex = 0;
            // 
            // labelPlaca
            // 
            labelPlaca.Anchor = AnchorStyles.Left;
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(3, 6);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(47, 20);
            labelPlaca.TabIndex = 0;
            labelPlaca.Text = "Placa:";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.CharacterCasing = CharacterCasing.Upper;
            textBoxPlaca.Dock = DockStyle.Fill;
            textBoxPlaca.Location = new Point(173, 3);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(977, 27);
            textBoxPlaca.TabIndex = 1;
            // 
            // labelTipoVehiculo
            // 
            labelTipoVehiculo.Anchor = AnchorStyles.Left;
            labelTipoVehiculo.AutoSize = true;
            labelTipoVehiculo.Location = new Point(3, 39);
            labelTipoVehiculo.Name = "labelTipoVehiculo";
            labelTipoVehiculo.Size = new Size(123, 20);
            labelTipoVehiculo.TabIndex = 2;
            labelTipoVehiculo.Text = "Tipo de Vehículo:";
            // 
            // comboBoxTipoVehiculo
            // 
            comboBoxTipoVehiculo.Dock = DockStyle.Fill;
            comboBoxTipoVehiculo.Items.AddRange(new object[] { "Auto", "Moto", "Camioneta", "SUV" });
            comboBoxTipoVehiculo.Location = new Point(173, 36);
            comboBoxTipoVehiculo.Name = "comboBoxTipoVehiculo";
            comboBoxTipoVehiculo.Size = new Size(977, 28);
            comboBoxTipoVehiculo.TabIndex = 3;
            comboBoxTipoVehiculo.SelectedIndexChanged += comboBoxTipoVehiculo_SelectedIndexChanged;
            // 
            // labelEspacioAsignado
            // 
            labelEspacioAsignado.Anchor = AnchorStyles.Left;
            labelEspacioAsignado.AutoSize = true;
            labelEspacioAsignado.Location = new Point(3, 72);
            labelEspacioAsignado.Name = "labelEspacioAsignado";
            labelEspacioAsignado.Size = new Size(130, 20);
            labelEspacioAsignado.TabIndex = 4;
            labelEspacioAsignado.Text = "Espacio Asignado:";
            // 
            // comboBoxEspacioAsignado
            // 
            comboBoxEspacioAsignado.Dock = DockStyle.Fill;
            comboBoxEspacioAsignado.Items.AddRange(new object[] { "Seleccionar espacio...", "A-001", "A-002", "B-001", "C-001" });
            comboBoxEspacioAsignado.Location = new Point(173, 69);
            comboBoxEspacioAsignado.Name = "comboBoxEspacioAsignado";
            comboBoxEspacioAsignado.Size = new Size(977, 28);
            comboBoxEspacioAsignado.TabIndex = 5;
            // 
            // labelHoraEntrada
            // 
            labelHoraEntrada.Anchor = AnchorStyles.Left;
            labelHoraEntrada.AutoSize = true;
            labelHoraEntrada.Location = new Point(3, 105);
            labelHoraEntrada.Name = "labelHoraEntrada";
            labelHoraEntrada.Size = new Size(121, 20);
            labelHoraEntrada.TabIndex = 6;
            labelHoraEntrada.Text = "Hora de Entrada:";
            // 
            // textBoxHoraEntrada
            // 
            textBoxHoraEntrada.Dock = DockStyle.Left;
            textBoxHoraEntrada.Enabled = false;
            textBoxHoraEntrada.Location = new Point(173, 102);
            textBoxHoraEntrada.Name = "textBoxHoraEntrada";
            textBoxHoraEntrada.Size = new Size(121, 27);
            textBoxHoraEntrada.TabIndex = 7;
            // 
            // panelBotoneEntrada
            // 
            panelBotoneEntrada.Controls.Add(buttonGuardarEntrada);
            panelBotoneEntrada.Dock = DockStyle.Bottom;
            panelBotoneEntrada.Location = new Point(11, 164);
            panelBotoneEntrada.Name = "panelBotoneEntrada";
            panelBotoneEntrada.Size = new Size(1153, 45);
            panelBotoneEntrada.TabIndex = 1;
            // 
            // buttonGuardarEntrada
            // 
            buttonGuardarEntrada.BackColor = Color.FromArgb(31, 118, 221);
            buttonGuardarEntrada.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonGuardarEntrada.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonGuardarEntrada.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonGuardarEntrada.FlatStyle = FlatStyle.Flat;
            buttonGuardarEntrada.ForeColor = Color.White;
            buttonGuardarEntrada.Location = new Point(3, 5);
            buttonGuardarEntrada.Name = "buttonGuardarEntrada";
            buttonGuardarEntrada.Size = new Size(139, 32);
            buttonGuardarEntrada.TabIndex = 0;
            buttonGuardarEntrada.Text = "Guardar Entrada";
            buttonGuardarEntrada.UseVisualStyleBackColor = false;
            buttonGuardarEntrada.Click += buttonGuardarEntrada_Click;
            // 
            // EntradasSalidasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(1207, 800);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1216, 836);
            Name = "EntradasSalidasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Entradas y Salidas";
            Load += EntradasSalidasForm_Load;
            panelMain.ResumeLayout(false);
            groupBoxVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            panelBotonesVehiculos.ResumeLayout(false);
            groupBoxEntrada.ResumeLayout(false);
            tableLayoutPanelEntrada.ResumeLayout(false);
            tableLayoutPanelEntrada.PerformLayout();
            panelBotoneEntrada.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private GroupBox groupBoxEntrada;
        private TableLayoutPanel tableLayoutPanelEntrada;
        private Label labelPlaca;
        private TextBox textBoxPlaca;
        private Label labelTipoVehiculo;
        private ComboBox comboBoxTipoVehiculo;
        private Label labelEspacioAsignado;
        private ComboBox comboBoxEspacioAsignado;
        private Label labelHoraEntrada;
        private TextBox textBoxHoraEntrada;
        private Panel panelBotoneEntrada;
        private Button buttonGuardarEntrada;
        
        private GroupBox groupBoxVehiculos;
        private DataGridView dataGridViewVehiculos;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnTicket;
        private DataGridViewTextBoxColumn columnPlaca;
        private DataGridViewTextBoxColumn columnTipo;
        private DataGridViewTextBoxColumn columnEspacio;
        private DataGridViewTextBoxColumn columnEntrada;
        private DataGridViewTextBoxColumn columnTiempo;
        private Panel panelBotonesVehiculos;
        private Button buttonCobrar;
        private Button buttonActualizar;
    }
}

