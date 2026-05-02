namespace SmartPark.UI.Configuracion
{
    partial class ConfiguracionForm
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
            tabControlConfiguracion = new TabControl();
            tabPageEmpresa = new TabPage();
            panelEmpresa = new Panel();
            groupBoxEmpresa = new GroupBox();
            tableLayoutPanelEmpresa = new TableLayoutPanel();
            labelNombreEmpresa = new Label();
            textBoxNombreEmpresa = new TextBox();
            labelRnc = new Label();
            textBoxRnc = new TextBox();
            labelDireccion = new Label();
            textBoxDireccion = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            tabPageTarifas = new TabPage();
            panelTarifas = new Panel();
            dataGridViewTarifas = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnTipo = new DataGridViewTextBoxColumn();
            columnTarifaHora = new DataGridViewTextBoxColumn();
            columnFraccion = new DataGridViewTextBoxColumn();
            columnMinutosMinimo = new DataGridViewTextBoxColumn();
            columnMinutosTolerancia = new DataGridViewTextBoxColumn();
            columnActualizadoEn = new DataGridViewTextBoxColumn();
            buttonAgregarTarifa = new Button();
            buttonEditarTarifa = new Button();
            groupBoxReglas = new GroupBox();
            labelTiempoGracia = new Label();
            numericUpDownTiempoGracia = new NumericUpDown();
            panelFooter = new Panel();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            panelMain.SuspendLayout();
            tabControlConfiguracion.SuspendLayout();
            tabPageEmpresa.SuspendLayout();
            panelEmpresa.SuspendLayout();
            groupBoxEmpresa.SuspendLayout();
            tableLayoutPanelEmpresa.SuspendLayout();
            tabPageTarifas.SuspendLayout();
            panelTarifas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).BeginInit();
            groupBoxReglas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempoGracia).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(tabControlConfiguracion);
            panelMain.Controls.Add(panelFooter);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(1120, 760);
            panelMain.TabIndex = 0;
            // 
            // tabControlConfiguracion
            // 
            tabControlConfiguracion.Controls.Add(tabPageEmpresa);
            tabControlConfiguracion.Controls.Add(tabPageTarifas);
            tabControlConfiguracion.Dock = DockStyle.Fill;
            tabControlConfiguracion.Location = new Point(16, 16);
            tabControlConfiguracion.Name = "tabControlConfiguracion";
            tabControlConfiguracion.SelectedIndex = 0;
            tabControlConfiguracion.Size = new Size(1088, 690);
            tabControlConfiguracion.TabIndex = 0;
            // 
            // tabPageEmpresa
            // 
            tabPageEmpresa.BackColor = Color.FromArgb(244, 247, 252);
            tabPageEmpresa.Controls.Add(panelEmpresa);
            tabPageEmpresa.Location = new Point(4, 29);
            tabPageEmpresa.Name = "tabPageEmpresa";
            tabPageEmpresa.Padding = new Padding(3);
            tabPageEmpresa.Size = new Size(1080, 657);
            tabPageEmpresa.TabIndex = 0;
            tabPageEmpresa.Text = "Empresa";
            // 
            // panelEmpresa
            // 
            panelEmpresa.Controls.Add(groupBoxEmpresa);
            panelEmpresa.Dock = DockStyle.Fill;
            panelEmpresa.Location = new Point(3, 3);
            panelEmpresa.Name = "panelEmpresa";
            panelEmpresa.Padding = new Padding(0, 12, 0, 12);
            panelEmpresa.Size = new Size(1074, 651);
            panelEmpresa.TabIndex = 0;
            // 
            // groupBoxEmpresa
            // 
            groupBoxEmpresa.Controls.Add(tableLayoutPanelEmpresa);
            groupBoxEmpresa.Dock = DockStyle.Top;
            groupBoxEmpresa.Font = new Font("Segoe UI", 9F);
            groupBoxEmpresa.Location = new Point(0, 12);
            groupBoxEmpresa.Name = "groupBoxEmpresa";
            groupBoxEmpresa.Padding = new Padding(12);
            groupBoxEmpresa.Size = new Size(1074, 209);
            groupBoxEmpresa.TabIndex = 0;
            groupBoxEmpresa.TabStop = false;
            groupBoxEmpresa.Text = "Datos de Empresa";
            // 
            // tableLayoutPanelEmpresa
            // 
            tableLayoutPanelEmpresa.ColumnCount = 2;
            tableLayoutPanelEmpresa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanelEmpresa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEmpresa.Controls.Add(labelNombreEmpresa, 0, 0);
            tableLayoutPanelEmpresa.Controls.Add(textBoxNombreEmpresa, 1, 0);
            tableLayoutPanelEmpresa.Controls.Add(labelRnc, 0, 1);
            tableLayoutPanelEmpresa.Controls.Add(textBoxRnc, 1, 1);
            tableLayoutPanelEmpresa.Controls.Add(labelDireccion, 0, 2);
            tableLayoutPanelEmpresa.Controls.Add(textBoxDireccion, 1, 2);
            tableLayoutPanelEmpresa.Controls.Add(labelTelefono, 0, 3);
            tableLayoutPanelEmpresa.Controls.Add(textBoxTelefono, 1, 3);
            tableLayoutPanelEmpresa.Controls.Add(labelEmail, 0, 4);
            tableLayoutPanelEmpresa.Controls.Add(textBoxEmail, 1, 4);
            tableLayoutPanelEmpresa.Dock = DockStyle.Fill;
            tableLayoutPanelEmpresa.Location = new Point(12, 32);
            tableLayoutPanelEmpresa.Name = "tableLayoutPanelEmpresa";
            tableLayoutPanelEmpresa.RowCount = 5;
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanelEmpresa.Size = new Size(1050, 165);
            tableLayoutPanelEmpresa.TabIndex = 0;
            // 
            // labelNombreEmpresa
            // 
            labelNombreEmpresa.Anchor = AnchorStyles.Left;
            labelNombreEmpresa.AutoSize = true;
            labelNombreEmpresa.Location = new Point(3, 6);
            labelNombreEmpresa.Name = "labelNombreEmpresa";
            labelNombreEmpresa.Size = new Size(128, 20);
            labelNombreEmpresa.TabIndex = 0;
            labelNombreEmpresa.Text = "Nombre empresa:";
            // 
            // textBoxNombreEmpresa
            // 
            textBoxNombreEmpresa.Dock = DockStyle.Fill;
            textBoxNombreEmpresa.Location = new Point(173, 3);
            textBoxNombreEmpresa.Name = "textBoxNombreEmpresa";
            textBoxNombreEmpresa.Size = new Size(874, 27);
            textBoxNombreEmpresa.TabIndex = 1;
            // 
            // labelRnc
            // 
            labelRnc.Anchor = AnchorStyles.Left;
            labelRnc.AutoSize = true;
            labelRnc.Location = new Point(3, 39);
            labelRnc.Name = "labelRnc";
            labelRnc.Size = new Size(93, 20);
            labelRnc.TabIndex = 2;
            labelRnc.Text = "RNC / Fiscal:";
            // 
            // textBoxRnc
            // 
            textBoxRnc.Dock = DockStyle.Left;
            textBoxRnc.Location = new Point(173, 36);
            textBoxRnc.Name = "textBoxRnc";
            textBoxRnc.Size = new Size(220, 27);
            textBoxRnc.TabIndex = 3;
            // 
            // labelDireccion
            // 
            labelDireccion.Anchor = AnchorStyles.Left;
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(3, 72);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(75, 20);
            labelDireccion.TabIndex = 4;
            labelDireccion.Text = "Dirección:";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Dock = DockStyle.Fill;
            textBoxDireccion.Location = new Point(173, 69);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(874, 27);
            textBoxDireccion.TabIndex = 5;
            // 
            // labelTelefono
            // 
            labelTelefono.Anchor = AnchorStyles.Left;
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(3, 105);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(79, 20);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Dock = DockStyle.Left;
            textBoxTelefono.Location = new Point(173, 102);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(220, 27);
            textBoxTelefono.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Left;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(3, 139);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 20);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(173, 135);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(874, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // tabPageTarifas
            // 
            tabPageTarifas.BackColor = Color.FromArgb(244, 247, 252);
            tabPageTarifas.Controls.Add(panelTarifas);
            tabPageTarifas.Location = new Point(4, 29);
            tabPageTarifas.Name = "tabPageTarifas";
            tabPageTarifas.Padding = new Padding(3);
            tabPageTarifas.Size = new Size(1080, 657);
            tabPageTarifas.TabIndex = 1;
            tabPageTarifas.Text = "Tarifas";
            // 
            // panelTarifas
            // 
            panelTarifas.Controls.Add(dataGridViewTarifas);
            panelTarifas.Controls.Add(buttonAgregarTarifa);
            panelTarifas.Controls.Add(buttonEditarTarifa);
            panelTarifas.Controls.Add(groupBoxReglas);
            panelTarifas.Dock = DockStyle.Fill;
            panelTarifas.Location = new Point(3, 3);
            panelTarifas.Name = "panelTarifas";
            panelTarifas.Padding = new Padding(0, 12, 0, 12);
            panelTarifas.Size = new Size(1074, 651);
            panelTarifas.TabIndex = 0;
            // 
            // dataGridViewTarifas
            // 
            dataGridViewTarifas.AllowUserToAddRows = false;
            dataGridViewTarifas.AllowUserToDeleteRows = false;
            dataGridViewTarifas.AllowUserToResizeRows = false;
            dataGridViewTarifas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTarifas.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTarifas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifas.Columns.AddRange(new DataGridViewColumn[] { columnId, columnTipo, columnTarifaHora, columnFraccion, columnMinutosMinimo, columnMinutosTolerancia, columnActualizadoEn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTarifas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTarifas.Location = new Point(0, 178);
            dataGridViewTarifas.MultiSelect = false;
            dataGridViewTarifas.Name = "dataGridViewTarifas";
            dataGridViewTarifas.ReadOnly = true;
            dataGridViewTarifas.RowHeadersVisible = false;
            dataGridViewTarifas.RowHeadersWidth = 51;
            dataGridViewTarifas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTarifas.Size = new Size(1074, 461);
            dataGridViewTarifas.TabIndex = 0;
            // 
            // columnTipo
            // 
            columnTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnTipo.HeaderText = "Tipo de Vehículo";
            columnTipo.MinimumWidth = 6;
            columnTipo.Name = "columnTipo";
            columnTipo.ReadOnly = true;
            // 
            // columnTarifaHora
            // 
            columnTarifaHora.HeaderText = "Tarifa por Hora";
            columnTarifaHora.MinimumWidth = 6;
            columnTarifaHora.Name = "columnTarifaHora";
            columnTarifaHora.ReadOnly = true;
            columnTarifaHora.Width = 140;
            // 
            // columnFraccion
            // 
            columnFraccion.HeaderText = "Fracción (min)";
            columnFraccion.MinimumWidth = 6;
            columnFraccion.Name = "columnFraccion";
            columnFraccion.ReadOnly = true;
            columnFraccion.Width = 130;
            // 
            // columnMinutosMinimo
            // 
            columnMinutosMinimo.HeaderText = "Mín. Minutos";
            columnMinutosMinimo.MinimumWidth = 6;
            columnMinutosMinimo.Name = "columnMinutosMinimo";
            columnMinutosMinimo.ReadOnly = true;
            columnMinutosMinimo.Width = 100;
            // 
            // columnMinutosTolerancia
            // 
            columnMinutosTolerancia.HeaderText = "Tolerancia";
            columnMinutosTolerancia.MinimumWidth = 6;
            columnMinutosTolerancia.Name = "columnMinutosTolerancia";
            columnMinutosTolerancia.ReadOnly = true;
            columnMinutosTolerancia.Width = 100;
            // 
            // columnActualizadoEn
            // 
            columnActualizadoEn.HeaderText = "Actualizado";
            columnActualizadoEn.MinimumWidth = 6;
            columnActualizadoEn.Name = "columnActualizadoEn";
            columnActualizadoEn.ReadOnly = true;
            columnActualizadoEn.Width = 140;
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
            // buttonAgregarTarifa
            // 
            buttonAgregarTarifa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAgregarTarifa.BackColor = Color.FromArgb(31, 118, 221);
            buttonAgregarTarifa.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonAgregarTarifa.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonAgregarTarifa.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonAgregarTarifa.FlatStyle = FlatStyle.Flat;
            buttonAgregarTarifa.ForeColor = Color.White;
            buttonAgregarTarifa.Location = new Point(868, 140);
            buttonAgregarTarifa.Name = "buttonAgregarTarifa";
            buttonAgregarTarifa.Size = new Size(100, 32);
            buttonAgregarTarifa.TabIndex = 2;
            buttonAgregarTarifa.Text = "Agregar";
            buttonAgregarTarifa.UseVisualStyleBackColor = false;
            buttonAgregarTarifa.Click += buttonAgregarTarifa_Click;
            // 
            // buttonEditarTarifa
            // 
            buttonEditarTarifa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditarTarifa.BackColor = Color.FromArgb(31, 118, 221);
            buttonEditarTarifa.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonEditarTarifa.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonEditarTarifa.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonEditarTarifa.FlatStyle = FlatStyle.Flat;
            buttonEditarTarifa.ForeColor = Color.White;
            buttonEditarTarifa.Location = new Point(974, 140);
            buttonEditarTarifa.Name = "buttonEditarTarifa";
            buttonEditarTarifa.Size = new Size(100, 32);
            buttonEditarTarifa.TabIndex = 1;
            buttonEditarTarifa.Text = "Editar";
            buttonEditarTarifa.UseVisualStyleBackColor = false;
            buttonEditarTarifa.Click += buttonEditarTarifa_Click;
            // 
            // groupBoxReglas
            // 
            groupBoxReglas.Controls.Add(labelTiempoGracia);
            groupBoxReglas.Controls.Add(numericUpDownTiempoGracia);
            groupBoxReglas.Dock = DockStyle.Top;
            groupBoxReglas.Font = new Font("Segoe UI", 9F);
            groupBoxReglas.Location = new Point(0, 12);
            groupBoxReglas.Name = "groupBoxReglas";
            groupBoxReglas.Padding = new Padding(12);
            groupBoxReglas.Size = new Size(1074, 122);
            groupBoxReglas.TabIndex = 0;
            groupBoxReglas.TabStop = false;
            groupBoxReglas.Text = "Reglas de Estadía";
            // 
            // labelTiempoGracia
            // 
            labelTiempoGracia.AutoSize = true;
            labelTiempoGracia.Location = new Point(16, 31);
            labelTiempoGracia.Name = "labelTiempoGracia";
            labelTiempoGracia.Size = new Size(127, 20);
            labelTiempoGracia.TabIndex = 0;
            labelTiempoGracia.Text = "Tiempo de gracia:";
            // 
            // numericUpDownTiempoGracia
            // 
            numericUpDownTiempoGracia.Location = new Point(153, 27);
            numericUpDownTiempoGracia.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            numericUpDownTiempoGracia.Name = "numericUpDownTiempoGracia";
            numericUpDownTiempoGracia.Size = new Size(90, 27);
            numericUpDownTiempoGracia.TabIndex = 1;
            numericUpDownTiempoGracia.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(buttonCancelar);
            panelFooter.Controls.Add(buttonGuardar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(16, 706);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1088, 38);
            panelFooter.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.Location = new Point(977, 1);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(111, 32);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGuardar.BackColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(860, 1);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(111, 32);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // ConfiguracionForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(1120, 760);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1136, 799);
            Name = "ConfiguracionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Configuración";
            Load += ConfiguracionForm_Load;
            panelMain.ResumeLayout(false);
            tabControlConfiguracion.ResumeLayout(false);
            tabPageEmpresa.ResumeLayout(false);
            panelEmpresa.ResumeLayout(false);
            groupBoxEmpresa.ResumeLayout(false);
            tableLayoutPanelEmpresa.ResumeLayout(false);
            tableLayoutPanelEmpresa.PerformLayout();
            tabPageTarifas.ResumeLayout(false);
            panelTarifas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).EndInit();
            groupBoxReglas.ResumeLayout(false);
            groupBoxReglas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempoGracia).EndInit();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private TabControl tabControlConfiguracion;
        private TabPage tabPageEmpresa;
        private Panel panelEmpresa;
        private GroupBox groupBoxEmpresa;
        private TableLayoutPanel tableLayoutPanelEmpresa;
        private Label labelNombreEmpresa;
        private TextBox textBoxNombreEmpresa;
        private Label labelRnc;
        private TextBox textBoxRnc;
        private Label labelDireccion;
        private TextBox textBoxDireccion;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TabPage tabPageTarifas;
        private Panel panelTarifas;
        private DataGridView dataGridViewTarifas;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnTipo;
        private DataGridViewTextBoxColumn columnTarifaHora;
        private DataGridViewTextBoxColumn columnFraccion;
        private DataGridViewTextBoxColumn columnMinutosMinimo;
        private DataGridViewTextBoxColumn columnMinutosTolerancia;
        private DataGridViewTextBoxColumn columnActualizadoEn;
        private Button buttonAgregarTarifa;
        private Button buttonEditarTarifa;
        private GroupBox groupBoxReglas;
        private Label labelTiempoGracia;
        private NumericUpDown numericUpDownTiempoGracia;
        private Panel panelFooter;
        private Button buttonCancelar;
        private Button buttonGuardar;
    }
}
