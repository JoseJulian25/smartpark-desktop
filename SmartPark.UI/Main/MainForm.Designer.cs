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
            panelSidebar = new Panel();
            panelSidebarNav = new Panel();
            buttonConsultas = new Button();
            buttonConfiguracion = new Button();
            buttonUsuarios = new Button();
            buttonEspacios = new Button();
            buttonReservas = new Button();
            buttonEntradasSalidas = new Button();
            buttonInicio = new Button();
            buttonLogout = new Button();
            panelSidebarTop = new Panel();
            pictureBox1 = new PictureBox();
            labelSystemName = new Label();
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
            panelSidebar.SuspendLayout();
            panelSidebarNav.SuspendLayout();
            panelSidebarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(26, 35, 50);
            panelSidebar.BorderStyle = BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(panelSidebarNav);
            panelSidebar.Controls.Add(buttonLogout);
            panelSidebar.Controls.Add(panelSidebarTop);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(251, 1015);
            panelSidebar.TabIndex = 0;
            // 
            // panelSidebarNav
            // 
            panelSidebarNav.Controls.Add(buttonConsultas);
            panelSidebarNav.Controls.Add(buttonConfiguracion);
            panelSidebarNav.Controls.Add(buttonUsuarios);
            panelSidebarNav.Controls.Add(buttonEspacios);
            panelSidebarNav.Controls.Add(buttonReservas);
            panelSidebarNav.Controls.Add(buttonEntradasSalidas);
            panelSidebarNav.Controls.Add(buttonInicio);
            panelSidebarNav.Dock = DockStyle.Fill;
            panelSidebarNav.Location = new Point(0, 99);
            panelSidebarNav.Margin = new Padding(3, 4, 3, 4);
            panelSidebarNav.Name = "panelSidebarNav";
            panelSidebarNav.Padding = new Padding(5, 8, 5, 8);
            panelSidebarNav.Size = new Size(249, 865);
            panelSidebarNav.TabIndex = 1;
            // 
            // buttonConsultas
            // 
            buttonConsultas.BackColor = Color.FromArgb(26, 35, 50);
            buttonConsultas.Cursor = Cursors.Hand;
            buttonConsultas.Dock = DockStyle.Top;
            buttonConsultas.FlatAppearance.BorderSize = 0;
            buttonConsultas.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 74, 106);
            buttonConsultas.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 57, 82);
            buttonConsultas.FlatStyle = FlatStyle.Flat;
            buttonConsultas.Font = new Font("Segoe UI", 9F);
            buttonConsultas.ForeColor = Color.FromArgb(219, 232, 250);
            buttonConsultas.Location = new Point(5, 302);
            buttonConsultas.Margin = new Padding(3, 4, 3, 4);
            buttonConsultas.Name = "buttonConsultas";
            buttonConsultas.Padding = new Padding(11, 0, 0, 0);
            buttonConsultas.Size = new Size(239, 49);
            buttonConsultas.TabIndex = 7;
            buttonConsultas.Text = "Consultas";
            buttonConsultas.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultas.UseVisualStyleBackColor = false;
            // 
            // buttonConfiguracion
            // 
            buttonConfiguracion.BackColor = Color.FromArgb(26, 35, 50);
            buttonConfiguracion.Cursor = Cursors.Hand;
            buttonConfiguracion.Dock = DockStyle.Top;
            buttonConfiguracion.FlatAppearance.BorderSize = 0;
            buttonConfiguracion.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 74, 106);
            buttonConfiguracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 57, 82);
            buttonConfiguracion.FlatStyle = FlatStyle.Flat;
            buttonConfiguracion.Font = new Font("Segoe UI", 9F);
            buttonConfiguracion.ForeColor = Color.FromArgb(219, 232, 250);
            buttonConfiguracion.Location = new Point(5, 253);
            buttonConfiguracion.Margin = new Padding(3, 4, 3, 4);
            buttonConfiguracion.Name = "buttonConfiguracion";
            buttonConfiguracion.Padding = new Padding(11, 0, 0, 0);
            buttonConfiguracion.Size = new Size(239, 49);
            buttonConfiguracion.TabIndex = 6;
            buttonConfiguracion.Text = "Configuracion";
            buttonConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfiguracion.UseVisualStyleBackColor = false;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.BackColor = Color.FromArgb(26, 35, 50);
            buttonUsuarios.Cursor = Cursors.Hand;
            buttonUsuarios.Dock = DockStyle.Top;
            buttonUsuarios.FlatAppearance.BorderSize = 0;
            buttonUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 74, 106);
            buttonUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 57, 82);
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
            buttonUsuarios.Font = new Font("Segoe UI", 9F);
            buttonUsuarios.ForeColor = Color.FromArgb(219, 232, 250);
            buttonUsuarios.Location = new Point(5, 204);
            buttonUsuarios.Margin = new Padding(3, 4, 3, 4);
            buttonUsuarios.Name = "buttonUsuarios";
            buttonUsuarios.Padding = new Padding(11, 0, 0, 0);
            buttonUsuarios.Size = new Size(239, 49);
            buttonUsuarios.TabIndex = 5;
            buttonUsuarios.Text = "Usuarios";
            buttonUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            buttonUsuarios.UseVisualStyleBackColor = false;
            // 
            // buttonEspacios
            // 
            buttonEspacios.BackColor = Color.FromArgb(26, 35, 50);
            buttonEspacios.Cursor = Cursors.Hand;
            buttonEspacios.Dock = DockStyle.Top;
            buttonEspacios.FlatAppearance.BorderSize = 0;
            buttonEspacios.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 74, 106);
            buttonEspacios.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 57, 82);
            buttonEspacios.FlatStyle = FlatStyle.Flat;
            buttonEspacios.Font = new Font("Segoe UI", 9F);
            buttonEspacios.ForeColor = Color.FromArgb(219, 232, 250);
            buttonEspacios.Location = new Point(5, 155);
            buttonEspacios.Margin = new Padding(3, 4, 3, 4);
            buttonEspacios.Name = "buttonEspacios";
            buttonEspacios.Padding = new Padding(11, 0, 0, 0);
            buttonEspacios.Size = new Size(239, 49);
            buttonEspacios.TabIndex = 4;
            buttonEspacios.Text = "Espacios";
            buttonEspacios.TextAlign = ContentAlignment.MiddleLeft;
            buttonEspacios.UseVisualStyleBackColor = false;
            // 
            // buttonReservas
            // 
            buttonReservas.BackColor = Color.FromArgb(26, 35, 50);
            buttonReservas.Cursor = Cursors.Hand;
            buttonReservas.Dock = DockStyle.Top;
            buttonReservas.FlatAppearance.BorderSize = 0;
            buttonReservas.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 74, 106);
            buttonReservas.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 57, 82);
            buttonReservas.FlatStyle = FlatStyle.Flat;
            buttonReservas.Font = new Font("Segoe UI", 9F);
            buttonReservas.ForeColor = Color.FromArgb(219, 232, 250);
            buttonReservas.Location = new Point(5, 106);
            buttonReservas.Margin = new Padding(3, 4, 3, 4);
            buttonReservas.Name = "buttonReservas";
            buttonReservas.Padding = new Padding(11, 0, 0, 0);
            buttonReservas.Size = new Size(239, 49);
            buttonReservas.TabIndex = 3;
            buttonReservas.Text = "Reservas";
            buttonReservas.TextAlign = ContentAlignment.MiddleLeft;
            buttonReservas.UseVisualStyleBackColor = false;
            // 
            // buttonEntradasSalidas
            // 
            buttonEntradasSalidas.BackColor = Color.FromArgb(26, 35, 50);
            buttonEntradasSalidas.Cursor = Cursors.Hand;
            buttonEntradasSalidas.Dock = DockStyle.Top;
            buttonEntradasSalidas.FlatAppearance.BorderSize = 0;
            buttonEntradasSalidas.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 74, 106);
            buttonEntradasSalidas.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 57, 82);
            buttonEntradasSalidas.FlatStyle = FlatStyle.Flat;
            buttonEntradasSalidas.Font = new Font("Segoe UI", 9F);
            buttonEntradasSalidas.ForeColor = Color.FromArgb(219, 232, 250);
            buttonEntradasSalidas.Location = new Point(5, 57);
            buttonEntradasSalidas.Margin = new Padding(3, 4, 3, 4);
            buttonEntradasSalidas.Name = "buttonEntradasSalidas";
            buttonEntradasSalidas.Padding = new Padding(11, 0, 0, 0);
            buttonEntradasSalidas.Size = new Size(239, 49);
            buttonEntradasSalidas.TabIndex = 2;
            buttonEntradasSalidas.Text = "Entradas y Salidas";
            buttonEntradasSalidas.TextAlign = ContentAlignment.MiddleLeft;
            buttonEntradasSalidas.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.SkyBlue;
            buttonInicio.Dock = DockStyle.Top;
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 170, 159);
            buttonInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 219, 207);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Segoe UI", 9F);
            buttonInicio.ForeColor = Color.FromArgb(16, 28, 48);
            buttonInicio.Location = new Point(5, 8);
            buttonInicio.Margin = new Padding(3, 4, 3, 4);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Padding = new Padding(11, 0, 0, 0);
            buttonInicio.Size = new Size(239, 49);
            buttonInicio.TabIndex = 1;
            buttonInicio.Text = "Inicio";
            buttonInicio.TextAlign = ContentAlignment.MiddleLeft;
            buttonInicio.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(26, 35, 50);
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 74, 106);
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 57, 82);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 9F);
            buttonLogout.ForeColor = Color.FromArgb(219, 232, 250);
            buttonLogout.Location = new Point(0, 964);
            buttonLogout.Margin = new Padding(3, 4, 3, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(11, 0, 0, 0);
            buttonLogout.Size = new Size(249, 49);
            buttonLogout.TabIndex = 8;
            buttonLogout.Text = "Cerrar Sesion";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // panelSidebarTop
            // 
            panelSidebarTop.BackColor = Color.FromArgb(32, 44, 64);
            panelSidebarTop.BorderStyle = BorderStyle.FixedSingle;
            panelSidebarTop.Controls.Add(pictureBox1);
            panelSidebarTop.Controls.Add(labelSystemName);
            panelSidebarTop.Dock = DockStyle.Top;
            panelSidebarTop.Location = new Point(0, 0);
            panelSidebarTop.Margin = new Padding(3, 4, 3, 4);
            panelSidebarTop.Name = "panelSidebarTop";
            panelSidebarTop.Size = new Size(249, 99);
            panelSidebarTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelSystemName
            // 
            labelSystemName.AutoSize = true;
            labelSystemName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSystemName.ForeColor = Color.White;
            labelSystemName.Location = new Point(82, 28);
            labelSystemName.Name = "labelSystemName";
            labelSystemName.Size = new Size(126, 31);
            labelSystemName.TabIndex = 1;
            labelSystemName.Text = "SmartPark";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxAlertas);
            panelMain.Controls.Add(groupBoxPanelControl);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(251, 0);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(18, 21, 18, 21);
            panelMain.Size = new Size(1308, 1015);
            panelMain.TabIndex = 1;
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
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusUsuario, toolStripStatusSep2, toolStripStatusFecha });
            statusStripMain.Location = new Point(251, 989);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new Padding(1, 0, 16, 0);
            statusStripMain.Size = new Size(1308, 26);
            statusStripMain.SizingGrip = false;
            statusStripMain.TabIndex = 2;
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
            Controls.Add(statusStripMain);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1369, 918);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartPark";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelSidebarNav.ResumeLayout(false);
            panelSidebarTop.ResumeLayout(false);
            panelSidebarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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

        private Panel panelSidebar;
        private Panel panelSidebarTop;
        private Label labelSystemName;
        private Panel panelSidebarNav;
        private Button buttonInicio;
        private Button buttonEntradasSalidas;
        private Button buttonReservas;
        private Button buttonEspacios;
        private Button buttonUsuarios;
        private Button buttonConfiguracion;
        private Button buttonConsultas;
        private Button buttonLogout;
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
        private PictureBox pictureBox1;
    }
}
