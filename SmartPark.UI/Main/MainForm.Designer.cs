namespace SmartPark.UI.Main
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStripMain = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            menuCerrarSesion = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            menuOperaciones = new ToolStripMenuItem();
            menuEntradasSalidas = new ToolStripMenuItem();
            menuReservas = new ToolStripMenuItem();
            menuNuevaReserva = new ToolStripMenuItem();
            menuAdministracion = new ToolStripMenuItem();
            menuEspacios = new ToolStripMenuItem();
            menuUsuarios = new ToolStripMenuItem();
            menuConfiguracion = new ToolStripMenuItem();
            menuConsultas = new ToolStripMenuItem();
            toolStripMain = new ToolStrip();
            toolStripButtonEntradasSalidas = new ToolStripButton();
            toolStripButtonReservas = new ToolStripButton();
            toolStripButtonNuevaReserva = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonEspacios = new ToolStripButton();
            toolStripButtonConsultas = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            panelMain = new Panel();
            groupBoxAlertas = new GroupBox();
            dataGridViewAlertas = new DataGridView();
            columnNumero = new DataGridViewTextBoxColumn();
            columnTipo = new DataGridViewTextBoxColumn();
            columnDetalle = new DataGridViewTextBoxColumn();
            columnHora = new DataGridViewTextBoxColumn();
            groupBoxPanelControl = new GroupBox();
            tableLayoutPanelKpis = new TableLayoutPanel();
            panelKpi1 = new Panel();
            labelKpi1Value = new Label();
            labelKpi1Title = new Label();
            panelKpi2 = new Panel();
            labelKpi2Value = new Label();
            labelKpi2Title = new Label();
            panelKpi3 = new Panel();
            labelKpi3Value = new Label();
            labelKpi3Title = new Label();
            panelKpi4 = new Panel();
            labelKpi4Value = new Label();
            labelKpi4Title = new Label();
            panelKpi5 = new Panel();
            labelKpi5Value = new Label();
            labelKpi5Title = new Label();
            statusStripMain = new StatusStrip();
            toolStripStatusUsuario = new ToolStripStatusLabel();
            toolStripStatusSep2 = new ToolStripStatusLabel();
            toolStripStatusFecha = new ToolStripStatusLabel();
            menuStripMain.SuspendLayout();
            toolStripMain.SuspendLayout();
            panelMain.SuspendLayout();
            groupBoxAlertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlertas).BeginInit();
            groupBoxPanelControl.SuspendLayout();
            tableLayoutPanelKpis.SuspendLayout();
            panelKpi1.SuspendLayout();
            panelKpi2.SuspendLayout();
            panelKpi3.SuspendLayout();
            panelKpi4.SuspendLayout();
            panelKpi5.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.BackColor = Color.FromArgb(40, 66, 104);
            menuStripMain.ForeColor = Color.White;
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuArchivo, menuOperaciones, menuAdministracion, menuConsultas });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1559, 28);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStripMain";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuCerrarSesion, menuSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(73, 24);
            menuArchivo.Text = "Archivo";
            // 
            // menuCerrarSesion
            // 
            menuCerrarSesion.Name = "menuCerrarSesion";
            menuCerrarSesion.Size = new Size(173, 26);
            menuCerrarSesion.Text = "Cerrar sesion";
            menuCerrarSesion.Click += menuCerrarSesion_Click;
            // 
            // menuSalir
            // 
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(173, 26);
            menuSalir.Text = "Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // menuOperaciones
            // 
            menuOperaciones.DropDownItems.AddRange(new ToolStripItem[] { menuEntradasSalidas, menuReservas, menuNuevaReserva });
            menuOperaciones.Name = "menuOperaciones";
            menuOperaciones.Size = new Size(102, 24);
            menuOperaciones.Text = "Operaciones";
            // 
            // menuEntradasSalidas
            // 
            menuEntradasSalidas.Name = "menuEntradasSalidas";
            menuEntradasSalidas.Size = new Size(203, 26);
            menuEntradasSalidas.Text = "Entradas y Salidas";
            menuEntradasSalidas.Click += buttonEntradasSalidas_Click;
            // 
            // menuReservas
            // 
            menuReservas.Name = "menuReservas";
            menuReservas.Size = new Size(203, 26);
            menuReservas.Text = "Reservas";
            menuReservas.Click += buttonReservas_Click;
            // 
            // menuNuevaReserva
            // 
            menuNuevaReserva.Name = "menuNuevaReserva";
            menuNuevaReserva.Size = new Size(203, 26);
            menuNuevaReserva.Text = "Nueva reserva";
            menuNuevaReserva.Click += menuNuevaReserva_Click;
            // 
            // menuAdministracion
            // 
            menuAdministracion.DropDownItems.AddRange(new ToolStripItem[] { menuEspacios, menuUsuarios, menuConfiguracion });
            menuAdministracion.Name = "menuAdministracion";
            menuAdministracion.Size = new Size(126, 24);
            menuAdministracion.Text = "Administracion";
            // 
            // menuEspacios
            // 
            menuEspacios.Name = "menuEspacios";
            menuEspacios.Size = new Size(183, 26);
            menuEspacios.Text = "Espacios";
            menuEspacios.Click += buttonEspacios_Click;
            // 
            // menuUsuarios
            // 
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(183, 26);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.Click += buttonUsuarios_Click;
            // 
            // menuConfiguracion
            // 
            menuConfiguracion.Name = "menuConfiguracion";
            menuConfiguracion.Size = new Size(183, 26);
            menuConfiguracion.Text = "Configuracion";
            menuConfiguracion.Click += buttonConfiguracion_Click;
            // 
            // menuConsultas
            // 
            menuConsultas.Name = "menuConsultas";
            menuConsultas.Size = new Size(83, 24);
            menuConsultas.Text = "Consultas";
            menuConsultas.Click += buttonConsultas_Click;
            // 
            // toolStripMain
            // 
            toolStripMain.BackColor = Color.FromArgb(40, 66, 104);
            toolStripMain.ForeColor = Color.White;
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripButtonEntradasSalidas, toolStripButtonReservas, toolStripButtonNuevaReserva, toolStripSeparator1, toolStripButtonEspacios, toolStripButtonConsultas, toolStripSeparator2 });
            toolStripMain.Location = new Point(0, 28);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(1559, 27);
            toolStripMain.TabIndex = 1;
            toolStripMain.Text = "toolStripMain";
            // 
            // toolStripButtonEntradasSalidas
            // 
            toolStripButtonEntradasSalidas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonEntradasSalidas.Name = "toolStripButtonEntradasSalidas";
            toolStripButtonEntradasSalidas.Size = new Size(133, 24);
            toolStripButtonEntradasSalidas.Text = "Entradas/Salidas";
            toolStripButtonEntradasSalidas.Click += buttonEntradasSalidas_Click;
            // 
            // toolStripButtonReservas
            // 
            toolStripButtonReservas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonReservas.Name = "toolStripButtonReservas";
            toolStripButtonReservas.Size = new Size(69, 24);
            toolStripButtonReservas.Text = "Reservas";
            toolStripButtonReservas.Click += buttonReservas_Click;
            // 
            // toolStripButtonNuevaReserva
            // 
            toolStripButtonNuevaReserva.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonNuevaReserva.Name = "toolStripButtonNuevaReserva";
            toolStripButtonNuevaReserva.Size = new Size(111, 24);
            toolStripButtonNuevaReserva.Text = "Nueva reserva";
            toolStripButtonNuevaReserva.Click += menuNuevaReserva_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButtonEspacios
            // 
            toolStripButtonEspacios.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonEspacios.Name = "toolStripButtonEspacios";
            toolStripButtonEspacios.Size = new Size(63, 24);
            toolStripButtonEspacios.Text = "Espacios";
            toolStripButtonEspacios.Click += buttonEspacios_Click;
            // 
            // toolStripButtonConsultas
            // 
            toolStripButtonConsultas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonConsultas.Name = "toolStripButtonConsultas";
            toolStripButtonConsultas.Size = new Size(77, 24);
            toolStripButtonConsultas.Text = "Consultas";
            toolStripButtonConsultas.Click += buttonConsultas_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxAlertas);
            panelMain.Controls.Add(groupBoxPanelControl);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 55);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(18, 21, 18, 21);
            panelMain.Size = new Size(1559, 934);
            panelMain.TabIndex = 2;
            // 
            // groupBoxAlertas
            // 
            groupBoxAlertas.Controls.Add(dataGridViewAlertas);
            groupBoxAlertas.Dock = DockStyle.Top;
            groupBoxAlertas.Font = new Font("Segoe UI", 9F);
            groupBoxAlertas.Location = new Point(18, 221);
            groupBoxAlertas.Margin = new Padding(3, 4, 3, 4);
            groupBoxAlertas.Name = "groupBoxAlertas";
            groupBoxAlertas.Padding = new Padding(9, 11, 9, 13);
            groupBoxAlertas.Size = new Size(1272, 368);
            groupBoxAlertas.TabIndex = 2;
            groupBoxAlertas.TabStop = false;
            groupBoxAlertas.Text = "Alertas Operativas";
            // 
            // dataGridViewAlertas
            // 
            dataGridViewAlertas.AllowUserToAddRows = false;
            dataGridViewAlertas.AllowUserToDeleteRows = false;
            dataGridViewAlertas.AllowUserToResizeRows = false;
            dataGridViewAlertas.BackgroundColor = Color.White;
            dataGridViewAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlertas.Columns.AddRange(new DataGridViewColumn[] { columnNumero, columnTipo, columnDetalle, columnHora });
            dataGridViewAlertas.Dock = DockStyle.Fill;
            dataGridViewAlertas.Location = new Point(9, 31);
            dataGridViewAlertas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAlertas.MultiSelect = false;
            dataGridViewAlertas.Name = "dataGridViewAlertas";
            dataGridViewAlertas.ReadOnly = true;
            dataGridViewAlertas.RowHeadersVisible = false;
            dataGridViewAlertas.RowHeadersWidth = 51;
            dataGridViewAlertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlertas.Size = new Size(1254, 324);
            dataGridViewAlertas.TabIndex = 0;
            // 
            // columnNumero
            // 
            columnNumero.HeaderText = "#";
            columnNumero.MinimumWidth = 6;
            columnNumero.Name = "columnNumero";
            columnNumero.ReadOnly = true;
            columnNumero.Width = 40;
            // 
            // columnTipo
            // 
            columnTipo.HeaderText = "Tipo";
            columnTipo.MinimumWidth = 6;
            columnTipo.Name = "columnTipo";
            columnTipo.ReadOnly = true;
            columnTipo.Width = 140;
            // 
            // columnDetalle
            // 
            columnDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnDetalle.HeaderText = "Detalle";
            columnDetalle.MinimumWidth = 6;
            columnDetalle.Name = "columnDetalle";
            columnDetalle.ReadOnly = true;
            // 
            // columnHora
            // 
            columnHora.HeaderText = "Hora";
            columnHora.MinimumWidth = 6;
            columnHora.Name = "columnHora";
            columnHora.ReadOnly = true;
            columnHora.Width = 80;
            // 
            // groupBoxPanelControl
            // 
            groupBoxPanelControl.Controls.Add(tableLayoutPanelKpis);
            groupBoxPanelControl.Dock = DockStyle.Top;
            groupBoxPanelControl.Font = new Font("Segoe UI", 9F);
            groupBoxPanelControl.Location = new Point(18, 21);
            groupBoxPanelControl.Margin = new Padding(3, 4, 3, 4);
            groupBoxPanelControl.Name = "groupBoxPanelControl";
            groupBoxPanelControl.Padding = new Padding(9, 11, 9, 13);
            groupBoxPanelControl.Size = new Size(1272, 200);
            groupBoxPanelControl.TabIndex = 1;
            groupBoxPanelControl.TabStop = false;
            groupBoxPanelControl.Text = "Panel de Control";
            // 
            // tableLayoutPanelKpis
            // 
            tableLayoutPanelKpis.ColumnCount = 5;
            tableLayoutPanelKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelKpis.Controls.Add(panelKpi1, 0, 0);
            tableLayoutPanelKpis.Controls.Add(panelKpi2, 1, 0);
            tableLayoutPanelKpis.Controls.Add(panelKpi3, 2, 0);
            tableLayoutPanelKpis.Controls.Add(panelKpi4, 3, 0);
            tableLayoutPanelKpis.Controls.Add(panelKpi5, 4, 0);
            tableLayoutPanelKpis.Dock = DockStyle.Fill;
            tableLayoutPanelKpis.Location = new Point(9, 31);
            tableLayoutPanelKpis.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelKpis.Name = "tableLayoutPanelKpis";
            tableLayoutPanelKpis.RowCount = 1;
            tableLayoutPanelKpis.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelKpis.Size = new Size(1254, 156);
            tableLayoutPanelKpis.TabIndex = 0;
            // 
            // panelKpi1
            // 
            panelKpi1.BackColor = Color.White;
            panelKpi1.BorderStyle = BorderStyle.FixedSingle;
            panelKpi1.Controls.Add(labelKpi1Value);
            panelKpi1.Controls.Add(labelKpi1Title);
            panelKpi1.Dock = DockStyle.Fill;
            panelKpi1.Location = new Point(3, 4);
            panelKpi1.Margin = new Padding(3, 4, 3, 4);
            panelKpi1.Name = "panelKpi1";
            panelKpi1.Padding = new Padding(11);
            panelKpi1.Size = new Size(244, 148);
            panelKpi1.TabIndex = 0;
            // 
            // labelKpi1Value
            // 
            labelKpi1Value.AutoSize = true;
            labelKpi1Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelKpi1Value.Location = new Point(13, 52);
            labelKpi1Value.Name = "labelKpi1Value";
            labelKpi1Value.Size = new Size(69, 41);
            labelKpi1Value.TabIndex = 1;
            labelKpi1Value.Text = "150";
            // 
            // labelKpi1Title
            // 
            labelKpi1Title.AutoSize = true;
            labelKpi1Title.Location = new Point(13, 16);
            labelKpi1Title.Name = "labelKpi1Title";
            labelKpi1Title.Size = new Size(103, 20);
            labelKpi1Title.TabIndex = 0;
            labelKpi1Title.Text = "Total Espacios";
            // 
            // panelKpi2
            // 
            panelKpi2.BackColor = Color.White;
            panelKpi2.BorderStyle = BorderStyle.FixedSingle;
            panelKpi2.Controls.Add(labelKpi2Value);
            panelKpi2.Controls.Add(labelKpi2Title);
            panelKpi2.Dock = DockStyle.Fill;
            panelKpi2.Location = new Point(253, 4);
            panelKpi2.Margin = new Padding(3, 4, 3, 4);
            panelKpi2.Name = "panelKpi2";
            panelKpi2.Padding = new Padding(11);
            panelKpi2.Size = new Size(244, 148);
            panelKpi2.TabIndex = 1;
            // 
            // labelKpi2Value
            // 
            labelKpi2Value.AutoSize = true;
            labelKpi2Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelKpi2Value.ForeColor = Color.FromArgb(16, 124, 16);
            labelKpi2Value.Location = new Point(13, 52);
            labelKpi2Value.Name = "labelKpi2Value";
            labelKpi2Value.Size = new Size(52, 41);
            labelKpi2Value.TabIndex = 1;
            labelKpi2Value.Text = "45";
            // 
            // labelKpi2Title
            // 
            labelKpi2Title.AutoSize = true;
            labelKpi2Title.Location = new Point(13, 16);
            labelKpi2Title.Name = "labelKpi2Title";
            labelKpi2Title.Size = new Size(109, 20);
            labelKpi2Title.TabIndex = 0;
            labelKpi2Title.Text = "Espacios Libres";
            // 
            // panelKpi3
            // 
            panelKpi3.BackColor = Color.White;
            panelKpi3.BorderStyle = BorderStyle.FixedSingle;
            panelKpi3.Controls.Add(labelKpi3Value);
            panelKpi3.Controls.Add(labelKpi3Title);
            panelKpi3.Dock = DockStyle.Fill;
            panelKpi3.Location = new Point(503, 4);
            panelKpi3.Margin = new Padding(3, 4, 3, 4);
            panelKpi3.Name = "panelKpi3";
            panelKpi3.Padding = new Padding(11);
            panelKpi3.Size = new Size(244, 148);
            panelKpi3.TabIndex = 2;
            // 
            // labelKpi3Value
            // 
            labelKpi3Value.AutoSize = true;
            labelKpi3Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelKpi3Value.ForeColor = Color.FromArgb(232, 17, 35);
            labelKpi3Value.Location = new Point(13, 52);
            labelKpi3Value.Name = "labelKpi3Value";
            labelKpi3Value.Size = new Size(52, 41);
            labelKpi3Value.TabIndex = 1;
            labelKpi3Value.Text = "85";
            // 
            // labelKpi3Title
            // 
            labelKpi3Title.AutoSize = true;
            labelKpi3Title.Location = new Point(13, 16);
            labelKpi3Title.Name = "labelKpi3Title";
            labelKpi3Title.Size = new Size(137, 20);
            labelKpi3Title.TabIndex = 0;
            labelKpi3Title.Text = "Espacios Ocupados";
            // 
            // panelKpi4
            // 
            panelKpi4.BackColor = Color.White;
            panelKpi4.BorderStyle = BorderStyle.FixedSingle;
            panelKpi4.Controls.Add(labelKpi4Value);
            panelKpi4.Controls.Add(labelKpi4Title);
            panelKpi4.Dock = DockStyle.Fill;
            panelKpi4.Location = new Point(753, 4);
            panelKpi4.Margin = new Padding(3, 4, 3, 4);
            panelKpi4.Name = "panelKpi4";
            panelKpi4.Padding = new Padding(11);
            panelKpi4.Size = new Size(244, 148);
            panelKpi4.TabIndex = 3;
            // 
            // labelKpi4Value
            // 
            labelKpi4Value.AutoSize = true;
            labelKpi4Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelKpi4Value.ForeColor = Color.FromArgb(255, 140, 0);
            labelKpi4Value.Location = new Point(13, 52);
            labelKpi4Value.Name = "labelKpi4Value";
            labelKpi4Value.Size = new Size(52, 41);
            labelKpi4Value.TabIndex = 1;
            labelKpi4Value.Text = "20";
            // 
            // labelKpi4Title
            // 
            labelKpi4Title.AutoSize = true;
            labelKpi4Title.Location = new Point(13, 16);
            labelKpi4Title.Name = "labelKpi4Title";
            labelKpi4Title.Size = new Size(145, 20);
            labelKpi4Title.TabIndex = 0;
            labelKpi4Title.Text = "Espacios Reservados";
            // 
            // panelKpi5
            // 
            panelKpi5.BackColor = Color.White;
            panelKpi5.BorderStyle = BorderStyle.FixedSingle;
            panelKpi5.Controls.Add(labelKpi5Value);
            panelKpi5.Controls.Add(labelKpi5Title);
            panelKpi5.Dock = DockStyle.Fill;
            panelKpi5.Location = new Point(1003, 4);
            panelKpi5.Margin = new Padding(3, 4, 3, 4);
            panelKpi5.Name = "panelKpi5";
            panelKpi5.Padding = new Padding(11);
            panelKpi5.Size = new Size(248, 148);
            panelKpi5.TabIndex = 4;
            // 
            // labelKpi5Value
            // 
            labelKpi5Value.AutoSize = true;
            labelKpi5Value.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelKpi5Value.ForeColor = Color.FromArgb(255, 140, 0);
            labelKpi5Value.Location = new Point(13, 52);
            labelKpi5Value.Name = "labelKpi5Value";
            labelKpi5Value.Size = new Size(52, 41);
            labelKpi5Value.TabIndex = 1;
            labelKpi5Value.Text = "12";
            // 
            // labelKpi5Title
            // 
            labelKpi5Title.AutoSize = true;
            labelKpi5Title.Location = new Point(13, 16);
            labelKpi5Title.Name = "labelKpi5Title";
            labelKpi5Title.Size = new Size(141, 20);
            labelKpi5Title.TabIndex = 0;
            labelKpi5Title.Text = "Reservas Pendientes";
            // 
            // statusStripMain
            // 
            statusStripMain.Dock = DockStyle.Bottom;
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusUsuario, toolStripStatusSep2, toolStripStatusFecha });
            statusStripMain.Location = new Point(0, 989);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new Padding(1, 0, 16, 0);
            statusStripMain.Size = new Size(1559, 26);
            statusStripMain.SizingGrip = false;
            statusStripMain.TabIndex = 3;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusUsuario
            // 
            toolStripStatusUsuario.Name = "toolStripStatusUsuario";
            toolStripStatusUsuario.Size = new Size(110, 20);
            toolStripStatusUsuario.Text = "Usuario: Admin";
            // 
            // toolStripStatusSep2
            // 
            toolStripStatusSep2.Name = "toolStripStatusSep2";
            toolStripStatusSep2.Size = new Size(13, 20);
            toolStripStatusSep2.Text = "|";
            // 
            // toolStripStatusFecha
            // 
            toolStripStatusFecha.Name = "toolStripStatusFecha";
            toolStripStatusFecha.Size = new Size(189, 20);
            toolStripStatusFecha.Text = "martes, 15 de abril de 2026";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1559, 1015);
            Controls.Add(panelMain);
            Controls.Add(toolStripMain);
            Controls.Add(menuStripMain);
            Controls.Add(statusStripMain);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1369, 918);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartPark";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            MainMenuStrip = menuStripMain;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            panelMain.ResumeLayout(false);
            groupBoxAlertas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlertas).EndInit();
            groupBoxPanelControl.ResumeLayout(false);
            tableLayoutPanelKpis.ResumeLayout(false);
            panelKpi1.ResumeLayout(false);
            panelKpi1.PerformLayout();
            panelKpi2.ResumeLayout(false);
            panelKpi2.PerformLayout();
            panelKpi3.ResumeLayout(false);
            panelKpi3.PerformLayout();
            panelKpi4.ResumeLayout(false);
            panelKpi4.PerformLayout();
            panelKpi5.ResumeLayout(false);
            panelKpi5.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem menuCerrarSesion;
        private ToolStripMenuItem menuSalir;
        private ToolStripMenuItem menuOperaciones;
        private ToolStripMenuItem menuEntradasSalidas;
        private ToolStripMenuItem menuReservas;
        private ToolStripMenuItem menuNuevaReserva;
        private ToolStripMenuItem menuAdministracion;
        private ToolStripMenuItem menuEspacios;
        private ToolStripMenuItem menuUsuarios;
        private ToolStripMenuItem menuConfiguracion;
        private ToolStripMenuItem menuConsultas;
        private ToolStrip toolStripMain;
        private ToolStripButton toolStripButtonEntradasSalidas;
        private ToolStripButton toolStripButtonReservas;
        private ToolStripButton toolStripButtonNuevaReserva;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonEspacios;
        private ToolStripButton toolStripButtonConsultas;
        private ToolStripSeparator toolStripSeparator2;
        private Panel panelMain;
        private GroupBox groupBoxPanelControl;
        private TableLayoutPanel tableLayoutPanelKpis;
        private Panel panelKpi1;
        private Label labelKpi1Title;
        private Label labelKpi1Value;
        private Panel panelKpi2;
        private Label labelKpi2Value;
        private Label labelKpi2Title;
        private Panel panelKpi3;
        private Label labelKpi3Value;
        private Label labelKpi3Title;
        private Panel panelKpi4;
        private Label labelKpi4Value;
        private Label labelKpi4Title;
        private Panel panelKpi5;
        private Label labelKpi5Value;
        private Label labelKpi5Title;
        private GroupBox groupBoxAlertas;
        private DataGridView dataGridViewAlertas;
        private DataGridViewTextBoxColumn columnNumero;
        private DataGridViewTextBoxColumn columnTipo;
        private DataGridViewTextBoxColumn columnDetalle;
        private DataGridViewTextBoxColumn columnHora;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusUsuario;
        private ToolStripStatusLabel toolStripStatusSep2;
        private ToolStripStatusLabel toolStripStatusFecha;
    }
}
