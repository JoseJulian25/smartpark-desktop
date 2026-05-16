namespace SmartPark.UI.Consultas
{
    partial class ConsultasForm
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
            tabControlConsultas = new TabControl();
            tabHistorial = new TabPage();
            groupBoxHistorialResultados = new GroupBox();
            dataGridViewHistorial = new DataGridView();
            groupBoxHistorialFiltros = new GroupBox();
            buttonHistorialAnular = new Button();
            buttonHistorialLimpiar = new Button();
            buttonHistorialBuscar = new Button();
            textBoxHistorialTicket = new TextBox();
            labelHistorialTicket = new Label();
            textBoxHistorialPlaca = new TextBox();
            labelHistorialPlaca = new Label();
            dateTimeHistorialFin = new DateTimePicker();
            labelHistorialFin = new Label();
            dateTimeHistorialInicio = new DateTimePicker();
            labelHistorialInicio = new Label();
            tabPagos = new TabPage();
            groupBoxPagosResultados = new GroupBox();
            dataGridViewPagos = new DataGridView();
            groupBoxPagosFiltros = new GroupBox();
            buttonPagosAnular = new Button();
            buttonPagosLimpiar = new Button();
            buttonPagosBuscar = new Button();
            textBoxPagoTicket = new TextBox();
            labelPagoTicket = new Label();
            comboBoxPagoMetodo = new ComboBox();
            labelPagoMetodo = new Label();
            dateTimePagoFin = new DateTimePicker();
            labelPagoFin = new Label();
            dateTimePagoInicio = new DateTimePicker();
            labelPagoInicio = new Label();
            columnPagoId = new DataGridViewTextBoxColumn();
            columnPagoTicket = new DataGridViewTextBoxColumn();
            columnPagoMetodo = new DataGridViewTextBoxColumn();
            columnPagoMonto = new DataGridViewTextBoxColumn();
            columnPagoRecibido = new DataGridViewTextBoxColumn();
            columnPagoFecha = new DataGridViewTextBoxColumn();
            columnPagoProcesadoPor = new DataGridViewTextBoxColumn();
            columnPagoAnulado = new DataGridViewTextBoxColumn();
            columnPagoFechaAnulacion = new DataGridViewTextBoxColumn();
            columnHistId = new DataGridViewTextBoxColumn();
            columnHistTicket = new DataGridViewTextBoxColumn();
            columnHistPlaca = new DataGridViewTextBoxColumn();
            columnHistTipo = new DataGridViewTextBoxColumn();
            columnHistEspacio = new DataGridViewTextBoxColumn();
            columnHistEntrada = new DataGridViewTextBoxColumn();
            columnHistSalida = new DataGridViewTextBoxColumn();
            columnHistTiempo = new DataGridViewTextBoxColumn();
            columnHistMonto = new DataGridViewTextBoxColumn();
            columnHistCreadoPor = new DataGridViewTextBoxColumn();
            columnHistAnulado = new DataGridViewTextBoxColumn();
            columnHistFechaAnulacion = new DataGridViewTextBoxColumn();
            panelMain.SuspendLayout();
            tabControlConsultas.SuspendLayout();
            tabHistorial.SuspendLayout();
            groupBoxHistorialResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            groupBoxHistorialFiltros.SuspendLayout();
            tabPagos.SuspendLayout();
            groupBoxPagosResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            groupBoxPagosFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(tabControlConsultas);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(1280, 820);
            panelMain.TabIndex = 0;
            // 
            // tabControlConsultas
            // 
            tabControlConsultas.Controls.Add(tabHistorial);
            tabControlConsultas.Controls.Add(tabPagos);
            tabControlConsultas.Dock = DockStyle.Fill;
            tabControlConsultas.Location = new Point(16, 16);
            tabControlConsultas.Name = "tabControlConsultas";
            tabControlConsultas.SelectedIndex = 0;
            tabControlConsultas.Size = new Size(1248, 788);
            tabControlConsultas.TabIndex = 0;
            // 
            // tabHistorial
            // 
            tabHistorial.Controls.Add(groupBoxHistorialResultados);
            tabHistorial.Controls.Add(groupBoxHistorialFiltros);
            tabHistorial.Location = new Point(4, 29);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(8);
            tabHistorial.Size = new Size(1240, 755);
            tabHistorial.TabIndex = 0;
            tabHistorial.Text = "Historial Entradas/Salidas";
            tabHistorial.UseVisualStyleBackColor = true;
            // 
            // groupBoxHistorialResultados
            // 
            groupBoxHistorialResultados.Controls.Add(dataGridViewHistorial);
            groupBoxHistorialResultados.Dock = DockStyle.Fill;
            groupBoxHistorialResultados.Font = new Font("Segoe UI", 9F);
            groupBoxHistorialResultados.Location = new Point(8, 118);
            groupBoxHistorialResultados.Name = "groupBoxHistorialResultados";
            groupBoxHistorialResultados.Padding = new Padding(10, 10, 10, 12);
            groupBoxHistorialResultados.Size = new Size(1224, 629);
            groupBoxHistorialResultados.TabIndex = 1;
            groupBoxHistorialResultados.TabStop = false;
            groupBoxHistorialResultados.Text = "Resultados";
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.AllowUserToAddRows = false;
            dataGridViewHistorial.AllowUserToDeleteRows = false;
            dataGridViewHistorial.AllowUserToResizeRows = false;
            dataGridViewHistorial.BackgroundColor = Color.White;
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.Columns.AddRange(new DataGridViewColumn[] { columnHistId, columnHistTicket, columnHistPlaca, columnHistTipo, columnHistEspacio, columnHistEntrada, columnHistSalida, columnHistTiempo, columnHistMonto, columnHistCreadoPor, columnHistAnulado, columnHistFechaAnulacion });
            dataGridViewHistorial.Dock = DockStyle.Fill;
            dataGridViewHistorial.Location = new Point(10, 30);
            dataGridViewHistorial.MultiSelect = false;
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.ReadOnly = true;
            dataGridViewHistorial.RowHeadersVisible = false;
            dataGridViewHistorial.RowHeadersWidth = 51;
            dataGridViewHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistorial.Size = new Size(1204, 587);
            dataGridViewHistorial.TabIndex = 0;
            // 
            // groupBoxHistorialFiltros
            // 
            groupBoxHistorialFiltros.Controls.Add(buttonHistorialAnular);
            groupBoxHistorialFiltros.Controls.Add(buttonHistorialLimpiar);
            groupBoxHistorialFiltros.Controls.Add(buttonHistorialBuscar);
            groupBoxHistorialFiltros.Controls.Add(textBoxHistorialTicket);
            groupBoxHistorialFiltros.Controls.Add(labelHistorialTicket);
            groupBoxHistorialFiltros.Controls.Add(textBoxHistorialPlaca);
            groupBoxHistorialFiltros.Controls.Add(labelHistorialPlaca);
            groupBoxHistorialFiltros.Controls.Add(dateTimeHistorialFin);
            groupBoxHistorialFiltros.Controls.Add(labelHistorialFin);
            groupBoxHistorialFiltros.Controls.Add(dateTimeHistorialInicio);
            groupBoxHistorialFiltros.Controls.Add(labelHistorialInicio);
            groupBoxHistorialFiltros.Dock = DockStyle.Top;
            groupBoxHistorialFiltros.Font = new Font("Segoe UI", 9F);
            groupBoxHistorialFiltros.Location = new Point(8, 8);
            groupBoxHistorialFiltros.Name = "groupBoxHistorialFiltros";
            groupBoxHistorialFiltros.Padding = new Padding(10, 10, 10, 12);
            groupBoxHistorialFiltros.Size = new Size(1224, 110);
            groupBoxHistorialFiltros.TabIndex = 0;
            groupBoxHistorialFiltros.TabStop = false;
            groupBoxHistorialFiltros.Text = "Criterios de Busqueda";
            // 
            // buttonHistorialAnular
            // 
            buttonHistorialAnular.BackColor = Color.White;
            buttonHistorialAnular.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            buttonHistorialAnular.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 228, 230);
            buttonHistorialAnular.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 239, 241);
            buttonHistorialAnular.FlatStyle = FlatStyle.Flat;
            buttonHistorialAnular.ForeColor = Color.FromArgb(220, 53, 69);
            buttonHistorialAnular.Location = new Point(860, 54);
            buttonHistorialAnular.Name = "buttonHistorialAnular";
            buttonHistorialAnular.Size = new Size(120, 30);
            buttonHistorialAnular.TabIndex = 10;
            buttonHistorialAnular.Text = "Anular Ticket";
            buttonHistorialAnular.UseVisualStyleBackColor = false;
            buttonHistorialAnular.Click += buttonHistorialAnular_Click;
            // 
            // buttonHistorialLimpiar
            // 
            buttonHistorialLimpiar.BackColor = Color.White;
            buttonHistorialLimpiar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonHistorialLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonHistorialLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonHistorialLimpiar.FlatStyle = FlatStyle.Flat;
            buttonHistorialLimpiar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonHistorialLimpiar.Location = new Point(764, 54);
            buttonHistorialLimpiar.Name = "buttonHistorialLimpiar";
            buttonHistorialLimpiar.Size = new Size(90, 30);
            buttonHistorialLimpiar.TabIndex = 9;
            buttonHistorialLimpiar.Text = "Limpiar";
            buttonHistorialLimpiar.UseVisualStyleBackColor = false;
            buttonHistorialLimpiar.Click += buttonHistorialLimpiar_Click_1;
            // 
            // buttonHistorialBuscar
            // 
            buttonHistorialBuscar.BackColor = Color.FromArgb(31, 118, 221);
            buttonHistorialBuscar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonHistorialBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonHistorialBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonHistorialBuscar.FlatStyle = FlatStyle.Flat;
            buttonHistorialBuscar.ForeColor = Color.White;
            buttonHistorialBuscar.Location = new Point(668, 54);
            buttonHistorialBuscar.Name = "buttonHistorialBuscar";
            buttonHistorialBuscar.Size = new Size(90, 30);
            buttonHistorialBuscar.TabIndex = 8;
            buttonHistorialBuscar.Text = "Buscar";
            buttonHistorialBuscar.UseVisualStyleBackColor = false;
            buttonHistorialBuscar.Click += buttonHistorialBuscar_Click_1;
            // 
            // textBoxHistorialTicket
            // 
            textBoxHistorialTicket.Location = new Point(512, 56);
            textBoxHistorialTicket.Name = "textBoxHistorialTicket";
            textBoxHistorialTicket.Size = new Size(120, 27);
            textBoxHistorialTicket.TabIndex = 7;
            // 
            // labelHistorialTicket
            // 
            labelHistorialTicket.AutoSize = true;
            labelHistorialTicket.Location = new Point(512, 32);
            labelHistorialTicket.Name = "labelHistorialTicket";
            labelHistorialTicket.Size = new Size(51, 20);
            labelHistorialTicket.TabIndex = 6;
            labelHistorialTicket.Text = "Ticket:";
            // 
            // textBoxHistorialPlaca
            // 
            textBoxHistorialPlaca.Location = new Point(384, 56);
            textBoxHistorialPlaca.Name = "textBoxHistorialPlaca";
            textBoxHistorialPlaca.Size = new Size(110, 27);
            textBoxHistorialPlaca.TabIndex = 5;
            // 
            // labelHistorialPlaca
            // 
            labelHistorialPlaca.AutoSize = true;
            labelHistorialPlaca.Location = new Point(384, 32);
            labelHistorialPlaca.Name = "labelHistorialPlaca";
            labelHistorialPlaca.Size = new Size(47, 20);
            labelHistorialPlaca.TabIndex = 4;
            labelHistorialPlaca.Text = "Placa:";
            // 
            // dateTimeHistorialFin
            // 
            dateTimeHistorialFin.Format = DateTimePickerFormat.Short;
            dateTimeHistorialFin.Location = new Point(200, 56);
            dateTimeHistorialFin.Name = "dateTimeHistorialFin";
            dateTimeHistorialFin.Size = new Size(160, 27);
            dateTimeHistorialFin.TabIndex = 3;
            // 
            // labelHistorialFin
            // 
            labelHistorialFin.AutoSize = true;
            labelHistorialFin.Location = new Point(200, 32);
            labelHistorialFin.Name = "labelHistorialFin";
            labelHistorialFin.Size = new Size(71, 20);
            labelHistorialFin.TabIndex = 2;
            labelHistorialFin.Text = "Fecha fin:";
            // 
            // dateTimeHistorialInicio
            // 
            dateTimeHistorialInicio.Format = DateTimePickerFormat.Short;
            dateTimeHistorialInicio.Location = new Point(16, 56);
            dateTimeHistorialInicio.Name = "dateTimeHistorialInicio";
            dateTimeHistorialInicio.Size = new Size(160, 27);
            dateTimeHistorialInicio.TabIndex = 1;
            // 
            // labelHistorialInicio
            // 
            labelHistorialInicio.AutoSize = true;
            labelHistorialInicio.Location = new Point(16, 32);
            labelHistorialInicio.Name = "labelHistorialInicio";
            labelHistorialInicio.Size = new Size(90, 20);
            labelHistorialInicio.TabIndex = 0;
            labelHistorialInicio.Text = "Fecha inicio:";
            // 
            // tabPagos
            // 
            tabPagos.Controls.Add(groupBoxPagosResultados);
            tabPagos.Controls.Add(groupBoxPagosFiltros);
            tabPagos.Location = new Point(4, 29);
            tabPagos.Name = "tabPagos";
            tabPagos.Padding = new Padding(8);
            tabPagos.Size = new Size(1240, 755);
            tabPagos.TabIndex = 1;
            tabPagos.Text = "Pagos";
            tabPagos.UseVisualStyleBackColor = true;
            // 
            // groupBoxPagosResultados
            // 
            groupBoxPagosResultados.Controls.Add(dataGridViewPagos);
            groupBoxPagosResultados.Dock = DockStyle.Fill;
            groupBoxPagosResultados.Font = new Font("Segoe UI", 9F);
            groupBoxPagosResultados.Location = new Point(8, 118);
            groupBoxPagosResultados.Name = "groupBoxPagosResultados";
            groupBoxPagosResultados.Padding = new Padding(10, 10, 10, 12);
            groupBoxPagosResultados.Size = new Size(1224, 629);
            groupBoxPagosResultados.TabIndex = 1;
            groupBoxPagosResultados.TabStop = false;
            groupBoxPagosResultados.Text = "Resultados";
            // 
            // dataGridViewPagos
            // 
            dataGridViewPagos.AllowUserToAddRows = false;
            dataGridViewPagos.AllowUserToDeleteRows = false;
            dataGridViewPagos.AllowUserToResizeRows = false;
            dataGridViewPagos.BackgroundColor = Color.White;
            dataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPagos.Columns.AddRange(new DataGridViewColumn[] { columnPagoId, columnPagoTicket, columnPagoMetodo, columnPagoMonto, columnPagoRecibido, columnPagoFecha, columnPagoProcesadoPor, columnPagoAnulado, columnPagoFechaAnulacion });
            dataGridViewPagos.Dock = DockStyle.Fill;
            dataGridViewPagos.Location = new Point(10, 30);
            dataGridViewPagos.MultiSelect = false;
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.ReadOnly = true;
            dataGridViewPagos.RowHeadersVisible = false;
            dataGridViewPagos.RowHeadersWidth = 51;
            dataGridViewPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPagos.Size = new Size(1204, 587);
            dataGridViewPagos.TabIndex = 0;
            // 
            // groupBoxPagosFiltros
            // 
            groupBoxPagosFiltros.Controls.Add(buttonPagosAnular);
            groupBoxPagosFiltros.Controls.Add(buttonPagosLimpiar);
            groupBoxPagosFiltros.Controls.Add(buttonPagosBuscar);
            groupBoxPagosFiltros.Controls.Add(textBoxPagoTicket);
            groupBoxPagosFiltros.Controls.Add(labelPagoTicket);
            groupBoxPagosFiltros.Controls.Add(comboBoxPagoMetodo);
            groupBoxPagosFiltros.Controls.Add(labelPagoMetodo);
            groupBoxPagosFiltros.Controls.Add(dateTimePagoFin);
            groupBoxPagosFiltros.Controls.Add(labelPagoFin);
            groupBoxPagosFiltros.Controls.Add(dateTimePagoInicio);
            groupBoxPagosFiltros.Controls.Add(labelPagoInicio);
            groupBoxPagosFiltros.Dock = DockStyle.Top;
            groupBoxPagosFiltros.Font = new Font("Segoe UI", 9F);
            groupBoxPagosFiltros.Location = new Point(8, 8);
            groupBoxPagosFiltros.Name = "groupBoxPagosFiltros";
            groupBoxPagosFiltros.Padding = new Padding(10, 10, 10, 12);
            groupBoxPagosFiltros.Size = new Size(1224, 110);
            groupBoxPagosFiltros.TabIndex = 0;
            groupBoxPagosFiltros.TabStop = false;
            groupBoxPagosFiltros.Text = "Criterios de Busqueda";
            // 
            // buttonPagosAnular
            // 
            buttonPagosAnular.BackColor = Color.White;
            buttonPagosAnular.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            buttonPagosAnular.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 228, 230);
            buttonPagosAnular.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 239, 241);
            buttonPagosAnular.FlatStyle = FlatStyle.Flat;
            buttonPagosAnular.ForeColor = Color.FromArgb(220, 53, 69);
            buttonPagosAnular.Location = new Point(860, 54);
            buttonPagosAnular.Name = "buttonPagosAnular";
            buttonPagosAnular.Size = new Size(120, 30);
            buttonPagosAnular.TabIndex = 10;
            buttonPagosAnular.Text = "Anular Pago";
            buttonPagosAnular.UseVisualStyleBackColor = false;
            buttonPagosAnular.Click += buttonPagosAnular_Click;
            // 
            // buttonPagosLimpiar
            // 
            buttonPagosLimpiar.BackColor = Color.White;
            buttonPagosLimpiar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonPagosLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonPagosLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonPagosLimpiar.FlatStyle = FlatStyle.Flat;
            buttonPagosLimpiar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonPagosLimpiar.Location = new Point(764, 54);
            buttonPagosLimpiar.Name = "buttonPagosLimpiar";
            buttonPagosLimpiar.Size = new Size(90, 30);
            buttonPagosLimpiar.TabIndex = 9;
            buttonPagosLimpiar.Text = "Limpiar";
            buttonPagosLimpiar.UseVisualStyleBackColor = false;
            buttonPagosLimpiar.Click += buttonPagosLimpiar_Click;
            // 
            // buttonPagosBuscar
            // 
            buttonPagosBuscar.BackColor = Color.FromArgb(31, 118, 221);
            buttonPagosBuscar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonPagosBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonPagosBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonPagosBuscar.FlatStyle = FlatStyle.Flat;
            buttonPagosBuscar.ForeColor = Color.White;
            buttonPagosBuscar.Location = new Point(668, 54);
            buttonPagosBuscar.Name = "buttonPagosBuscar";
            buttonPagosBuscar.Size = new Size(90, 30);
            buttonPagosBuscar.TabIndex = 8;
            buttonPagosBuscar.Text = "Buscar";
            buttonPagosBuscar.UseVisualStyleBackColor = false;
            buttonPagosBuscar.Click += buttonPagosBuscar_Click_1;
            // 
            // textBoxPagoTicket
            // 
            textBoxPagoTicket.Location = new Point(512, 56);
            textBoxPagoTicket.Name = "textBoxPagoTicket";
            textBoxPagoTicket.Size = new Size(120, 27);
            textBoxPagoTicket.TabIndex = 7;
            // 
            // labelPagoTicket
            // 
            labelPagoTicket.AutoSize = true;
            labelPagoTicket.Location = new Point(512, 32);
            labelPagoTicket.Name = "labelPagoTicket";
            labelPagoTicket.Size = new Size(51, 20);
            labelPagoTicket.TabIndex = 6;
            labelPagoTicket.Text = "Ticket:";
            // 
            // comboBoxPagoMetodo
            // 
            comboBoxPagoMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPagoMetodo.FormattingEnabled = true;
            comboBoxPagoMetodo.Items.AddRange(new object[] { "Todos", "Efectivo", "Tarjeta", "Transferencia" });
            comboBoxPagoMetodo.Location = new Point(384, 56);
            comboBoxPagoMetodo.Name = "comboBoxPagoMetodo";
            comboBoxPagoMetodo.Size = new Size(110, 28);
            comboBoxPagoMetodo.TabIndex = 5;
            // 
            // labelPagoMetodo
            // 
            labelPagoMetodo.AutoSize = true;
            labelPagoMetodo.Location = new Point(384, 32);
            labelPagoMetodo.Name = "labelPagoMetodo";
            labelPagoMetodo.Size = new Size(65, 20);
            labelPagoMetodo.TabIndex = 4;
            labelPagoMetodo.Text = "Metodo:";
            // 
            // dateTimePagoFin
            // 
            dateTimePagoFin.Format = DateTimePickerFormat.Short;
            dateTimePagoFin.Location = new Point(200, 56);
            dateTimePagoFin.Name = "dateTimePagoFin";
            dateTimePagoFin.Size = new Size(160, 27);
            dateTimePagoFin.TabIndex = 3;
            // 
            // labelPagoFin
            // 
            labelPagoFin.AutoSize = true;
            labelPagoFin.Location = new Point(200, 32);
            labelPagoFin.Name = "labelPagoFin";
            labelPagoFin.Size = new Size(71, 20);
            labelPagoFin.TabIndex = 2;
            labelPagoFin.Text = "Fecha fin:";
            // 
            // dateTimePagoInicio
            // 
            dateTimePagoInicio.Format = DateTimePickerFormat.Short;
            dateTimePagoInicio.Location = new Point(16, 56);
            dateTimePagoInicio.Name = "dateTimePagoInicio";
            dateTimePagoInicio.Size = new Size(160, 27);
            dateTimePagoInicio.TabIndex = 1;
            // 
            // labelPagoInicio
            // 
            labelPagoInicio.AutoSize = true;
            labelPagoInicio.Location = new Point(16, 32);
            labelPagoInicio.Name = "labelPagoInicio";
            labelPagoInicio.Size = new Size(90, 20);
            labelPagoInicio.TabIndex = 0;
            labelPagoInicio.Text = "Fecha inicio:";
            // 
            // columnPagoId
            // 
            columnPagoId.HeaderText = "ID";
            columnPagoId.MinimumWidth = 6;
            columnPagoId.Name = "columnPagoId";
            columnPagoId.ReadOnly = true;
            // 
            // columnPagoTicket
            // 
            columnPagoTicket.HeaderText = "Ticket";
            columnPagoTicket.MinimumWidth = 6;
            columnPagoTicket.Name = "columnPagoTicket";
            columnPagoTicket.ReadOnly = true;
            columnPagoTicket.Width = 250;
            // 
            // columnPagoMetodo
            // 
            columnPagoMetodo.HeaderText = "Metodo";
            columnPagoMetodo.MinimumWidth = 6;
            columnPagoMetodo.Name = "columnPagoMetodo";
            columnPagoMetodo.ReadOnly = true;
            columnPagoMetodo.Width = 200;
            // 
            // columnPagoMonto
            // 
            columnPagoMonto.HeaderText = "Monto";
            columnPagoMonto.MinimumWidth = 6;
            columnPagoMonto.Name = "columnPagoMonto";
            columnPagoMonto.ReadOnly = true;
            columnPagoMonto.Width = 120;
            // 
            // columnPagoRecibido
            // 
            columnPagoRecibido.HeaderText = "Recibido";
            columnPagoRecibido.MinimumWidth = 6;
            columnPagoRecibido.Name = "columnPagoRecibido";
            columnPagoRecibido.ReadOnly = true;
            columnPagoRecibido.Width = 200;
            // 
            // columnPagoFecha
            // 
            columnPagoFecha.HeaderText = "Fecha Pago";
            columnPagoFecha.MinimumWidth = 6;
            columnPagoFecha.Name = "columnPagoFecha";
            columnPagoFecha.ReadOnly = true;
            columnPagoFecha.Width = 160;
            // 
            // columnPagoProcesadoPor
            // 
            columnPagoProcesadoPor.HeaderText = "Procesado Por";
            columnPagoProcesadoPor.MinimumWidth = 6;
            columnPagoProcesadoPor.Name = "columnPagoProcesadoPor";
            columnPagoProcesadoPor.ReadOnly = true;
            columnPagoProcesadoPor.Width = 160;
            // 
            // columnPagoAnulado
            // 
            columnPagoAnulado.HeaderText = "Anulado";
            columnPagoAnulado.MinimumWidth = 6;
            columnPagoAnulado.Name = "columnPagoAnulado";
            columnPagoAnulado.ReadOnly = true;
            columnPagoAnulado.Width = 90;
            // 
            // columnPagoFechaAnulacion
            // 
            columnPagoFechaAnulacion.HeaderText = "Fecha Anulacion";
            columnPagoFechaAnulacion.MinimumWidth = 6;
            columnPagoFechaAnulacion.Name = "columnPagoFechaAnulacion";
            columnPagoFechaAnulacion.ReadOnly = true;
            columnPagoFechaAnulacion.Width = 160;
            // 
            // columnHistId
            // 
            columnHistId.HeaderText = "ID";
            columnHistId.MinimumWidth = 6;
            columnHistId.Name = "columnHistId";
            columnHistId.ReadOnly = true;
            columnHistId.Width = 60;
            // 
            // columnHistTicket
            // 
            columnHistTicket.HeaderText = "Ticket";
            columnHistTicket.MinimumWidth = 6;
            columnHistTicket.Name = "columnHistTicket";
            columnHistTicket.ReadOnly = true;
            columnHistTicket.Width = 200;
            // 
            // columnHistPlaca
            // 
            columnHistPlaca.HeaderText = "Placa";
            columnHistPlaca.MinimumWidth = 6;
            columnHistPlaca.Name = "columnHistPlaca";
            columnHistPlaca.ReadOnly = true;
            columnHistPlaca.Width = 110;
            // 
            // columnHistTipo
            // 
            columnHistTipo.HeaderText = "Tipo";
            columnHistTipo.MinimumWidth = 6;
            columnHistTipo.Name = "columnHistTipo";
            columnHistTipo.ReadOnly = true;
            columnHistTipo.Width = 120;
            // 
            // columnHistEspacio
            // 
            columnHistEspacio.HeaderText = "Espacio";
            columnHistEspacio.MinimumWidth = 6;
            columnHistEspacio.Name = "columnHistEspacio";
            columnHistEspacio.ReadOnly = true;
            columnHistEspacio.Width = 90;
            // 
            // columnHistEntrada
            // 
            columnHistEntrada.HeaderText = "Entrada";
            columnHistEntrada.MinimumWidth = 6;
            columnHistEntrada.Name = "columnHistEntrada";
            columnHistEntrada.ReadOnly = true;
            columnHistEntrada.Width = 140;
            // 
            // columnHistSalida
            // 
            columnHistSalida.HeaderText = "Salida";
            columnHistSalida.MinimumWidth = 6;
            columnHistSalida.Name = "columnHistSalida";
            columnHistSalida.ReadOnly = true;
            columnHistSalida.Width = 140;
            // 
            // columnHistTiempo
            // 
            columnHistTiempo.HeaderText = "Tiempo";
            columnHistTiempo.MinimumWidth = 6;
            columnHistTiempo.Name = "columnHistTiempo";
            columnHistTiempo.ReadOnly = true;
            columnHistTiempo.Width = 110;
            // 
            // columnHistMonto
            // 
            columnHistMonto.HeaderText = "Monto";
            columnHistMonto.MinimumWidth = 6;
            columnHistMonto.Name = "columnHistMonto";
            columnHistMonto.ReadOnly = true;
            columnHistMonto.Width = 110;
            // 
            // columnHistCreadoPor
            // 
            columnHistCreadoPor.HeaderText = "Creado Por";
            columnHistCreadoPor.MinimumWidth = 6;
            columnHistCreadoPor.Name = "columnHistCreadoPor";
            columnHistCreadoPor.ReadOnly = true;
            columnHistCreadoPor.Width = 160;
            // 
            // columnHistAnulado
            // 
            columnHistAnulado.HeaderText = "Anulado";
            columnHistAnulado.MinimumWidth = 6;
            columnHistAnulado.Name = "columnHistAnulado";
            columnHistAnulado.ReadOnly = true;
            columnHistAnulado.Width = 90;
            // 
            // columnHistFechaAnulacion
            // 
            columnHistFechaAnulacion.HeaderText = "Fecha Anulacion";
            columnHistFechaAnulacion.MinimumWidth = 6;
            columnHistFechaAnulacion.Name = "columnHistFechaAnulacion";
            columnHistFechaAnulacion.ReadOnly = true;
            columnHistFechaAnulacion.Width = 160;
            // 
            // ConsultasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(1280, 820);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 720);
            Name = "ConsultasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Consultas";
            Load += ConsultasForm_Load_1;
            panelMain.ResumeLayout(false);
            tabControlConsultas.ResumeLayout(false);
            tabHistorial.ResumeLayout(false);
            groupBoxHistorialResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            groupBoxHistorialFiltros.ResumeLayout(false);
            groupBoxHistorialFiltros.PerformLayout();
            tabPagos.ResumeLayout(false);
            groupBoxPagosResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            groupBoxPagosFiltros.ResumeLayout(false);
            groupBoxPagosFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private TabControl tabControlConsultas;
        private TabPage tabHistorial;
        private GroupBox groupBoxHistorialResultados;
        private DataGridView dataGridViewHistorial;
        private GroupBox groupBoxHistorialFiltros;
        private Button buttonHistorialAnular;
        private Button buttonHistorialLimpiar;
        private Button buttonHistorialBuscar;
        private TextBox textBoxHistorialTicket;
        private Label labelHistorialTicket;
        private TextBox textBoxHistorialPlaca;
        private Label labelHistorialPlaca;
        private DateTimePicker dateTimeHistorialFin;
        private Label labelHistorialFin;
        private DateTimePicker dateTimeHistorialInicio;
        private Label labelHistorialInicio;
        private TabPage tabPagos;
        private GroupBox groupBoxPagosResultados;
        private DataGridView dataGridViewPagos;
        private GroupBox groupBoxPagosFiltros;
        private Button buttonPagosAnular;
        private Button buttonPagosLimpiar;
        private Button buttonPagosBuscar;
        private TextBox textBoxPagoTicket;
        private Label labelPagoTicket;
        private ComboBox comboBoxPagoMetodo;
        private Label labelPagoMetodo;
        private DateTimePicker dateTimePagoFin;
        private Label labelPagoFin;
        private DateTimePicker dateTimePagoInicio;
        private Label labelPagoInicio;
        private DataGridViewTextBoxColumn columnHistId;
        private DataGridViewTextBoxColumn columnHistTicket;
        private DataGridViewTextBoxColumn columnHistPlaca;
        private DataGridViewTextBoxColumn columnHistTipo;
        private DataGridViewTextBoxColumn columnHistEspacio;
        private DataGridViewTextBoxColumn columnHistEntrada;
        private DataGridViewTextBoxColumn columnHistSalida;
        private DataGridViewTextBoxColumn columnHistTiempo;
        private DataGridViewTextBoxColumn columnHistMonto;
        private DataGridViewTextBoxColumn columnHistCreadoPor;
        private DataGridViewTextBoxColumn columnHistAnulado;
        private DataGridViewTextBoxColumn columnHistFechaAnulacion;
        private DataGridViewTextBoxColumn columnPagoId;
        private DataGridViewTextBoxColumn columnPagoTicket;
        private DataGridViewTextBoxColumn columnPagoMetodo;
        private DataGridViewTextBoxColumn columnPagoMonto;
        private DataGridViewTextBoxColumn columnPagoRecibido;
        private DataGridViewTextBoxColumn columnPagoFecha;
        private DataGridViewTextBoxColumn columnPagoProcesadoPor;
        private DataGridViewTextBoxColumn columnPagoAnulado;
        private DataGridViewTextBoxColumn columnPagoFechaAnulacion;
    }
}
