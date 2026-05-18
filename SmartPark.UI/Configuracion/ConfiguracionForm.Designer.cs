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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            panelFooter = new Panel();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            buttonEditarTarifa = new Button();
            buttonAgregarTarifa = new Button();
            dataGridViewTarifas = new DataGridView();
            columnActualizadoEn = new DataGridViewTextBoxColumn();
            columnMinutosTolerancia = new DataGridViewTextBoxColumn();
            columnMinutosMinimo = new DataGridViewTextBoxColumn();
            columnFraccion = new DataGridViewTextBoxColumn();
            columnTarifaHora = new DataGridViewTextBoxColumn();
            columnTipo = new DataGridViewTextBoxColumn();
            columnId = new DataGridViewTextBoxColumn();
            panelTarifas = new Panel();
            panelMain.SuspendLayout();
            tabControlConfiguracion.SuspendLayout();
            tabPageEmpresa.SuspendLayout();
            panelEmpresa.SuspendLayout();
            groupBoxEmpresa.SuspendLayout();
            tableLayoutPanelEmpresa.SuspendLayout();
            tabPageTarifas.SuspendLayout();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).BeginInit();
            panelTarifas.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(tabControlConfiguracion);
            panelMain.Controls.Add(panelFooter);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(12);
            panelMain.Size = new Size(980, 680);
            panelMain.TabIndex = 0;
            // 
            // tabControlConfiguracion
            // 
            tabControlConfiguracion.Controls.Add(tabPageEmpresa);
            tabControlConfiguracion.Controls.Add(tabPageTarifas);
            tabControlConfiguracion.Dock = DockStyle.Fill;
            tabControlConfiguracion.Location = new Point(12, 12);
            tabControlConfiguracion.Margin = new Padding(3, 4, 3, 4);
            tabControlConfiguracion.Name = "tabControlConfiguracion";
            tabControlConfiguracion.SelectedIndex = 0;
            tabControlConfiguracion.Size = new Size(956, 612);
            tabControlConfiguracion.TabIndex = 0;
            // 
            // tabPageEmpresa
            // 
            tabPageEmpresa.BackColor = Color.FromArgb(244, 247, 252);
            tabPageEmpresa.Controls.Add(panelEmpresa);
            tabPageEmpresa.Location = new Point(4, 29);
            tabPageEmpresa.Margin = new Padding(3, 4, 3, 4);
            tabPageEmpresa.Name = "tabPageEmpresa";
            tabPageEmpresa.Padding = new Padding(3, 4, 3, 4);
            tabPageEmpresa.Size = new Size(948, 579);
            tabPageEmpresa.TabIndex = 0;
            tabPageEmpresa.Text = "Empresa";
            // 
            // panelEmpresa
            // 
            panelEmpresa.Controls.Add(groupBoxEmpresa);
            panelEmpresa.Dock = DockStyle.Fill;
            panelEmpresa.Location = new Point(3, 4);
            panelEmpresa.Margin = new Padding(3, 4, 3, 4);
            panelEmpresa.Name = "panelEmpresa";
            panelEmpresa.Padding = new Padding(0, 16, 0, 16);
            panelEmpresa.Size = new Size(942, 571);
            panelEmpresa.TabIndex = 0;
            // 
            // groupBoxEmpresa
            // 
            groupBoxEmpresa.Controls.Add(tableLayoutPanelEmpresa);
            groupBoxEmpresa.Dock = DockStyle.Top;
            groupBoxEmpresa.Font = new Font("Segoe UI", 9F);
            groupBoxEmpresa.Location = new Point(0, 16);
            groupBoxEmpresa.Margin = new Padding(3, 4, 3, 4);
            groupBoxEmpresa.Name = "groupBoxEmpresa";
            groupBoxEmpresa.Padding = new Padding(14, 16, 14, 16);
            groupBoxEmpresa.Size = new Size(942, 260);
            groupBoxEmpresa.TabIndex = 0;
            groupBoxEmpresa.TabStop = false;
            groupBoxEmpresa.Text = "Datos de Empresa";
            // 
            // tableLayoutPanelEmpresa
            // 
            tableLayoutPanelEmpresa.ColumnCount = 2;
            tableLayoutPanelEmpresa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
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
            tableLayoutPanelEmpresa.Location = new Point(14, 36);
            tableLayoutPanelEmpresa.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelEmpresa.Name = "tableLayoutPanelEmpresa";
            tableLayoutPanelEmpresa.RowCount = 5;
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanelEmpresa.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanelEmpresa.Size = new Size(914, 220);
            tableLayoutPanelEmpresa.TabIndex = 0;
            // 
            // labelNombreEmpresa
            // 
            labelNombreEmpresa.Anchor = AnchorStyles.Left;
            labelNombreEmpresa.AutoSize = true;
            labelNombreEmpresa.Location = new Point(3, 12);
            labelNombreEmpresa.Name = "labelNombreEmpresa";
            labelNombreEmpresa.Size = new Size(128, 20);
            labelNombreEmpresa.TabIndex = 0;
            labelNombreEmpresa.Text = "Nombre empresa:";
            // 
            // textBoxNombreEmpresa
            // 
            textBoxNombreEmpresa.Dock = DockStyle.Fill;
            textBoxNombreEmpresa.Location = new Point(197, 4);
            textBoxNombreEmpresa.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreEmpresa.Name = "textBoxNombreEmpresa";
            textBoxNombreEmpresa.Size = new Size(1000, 27);
            textBoxNombreEmpresa.TabIndex = 1;
            // 
            // labelRnc
            // 
            labelRnc.Anchor = AnchorStyles.Left;
            labelRnc.AutoSize = true;
            labelRnc.Location = new Point(3, 56);
            labelRnc.Name = "labelRnc";
            labelRnc.Size = new Size(91, 20);
            labelRnc.TabIndex = 2;
            labelRnc.Text = "RNC / Fiscal:";
            // 
            // textBoxRnc
            // 
            textBoxRnc.Dock = DockStyle.Left;
            textBoxRnc.Location = new Point(197, 48);
            textBoxRnc.Margin = new Padding(3, 4, 3, 4);
            textBoxRnc.Name = "textBoxRnc";
            textBoxRnc.Size = new Size(251, 27);
            textBoxRnc.TabIndex = 3;
            // 
            // labelDireccion
            // 
            labelDireccion.Anchor = AnchorStyles.Left;
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(3, 100);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(75, 20);
            labelDireccion.TabIndex = 4;
            labelDireccion.Text = "Dirección:";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Dock = DockStyle.Fill;
            textBoxDireccion.Location = new Point(197, 92);
            textBoxDireccion.Margin = new Padding(3, 4, 3, 4);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(1000, 27);
            textBoxDireccion.TabIndex = 5;
            // 
            // labelTelefono
            // 
            labelTelefono.Anchor = AnchorStyles.Left;
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(3, 144);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(70, 20);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Dock = DockStyle.Left;
            textBoxTelefono.Location = new Point(197, 136);
            textBoxTelefono.Margin = new Padding(3, 4, 3, 4);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(251, 27);
            textBoxTelefono.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Left;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(3, 191);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(197, 180);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(1000, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // tabPageTarifas
            // 
            tabPageTarifas.BackColor = Color.FromArgb(244, 247, 252);
            tabPageTarifas.Controls.Add(panelTarifas);
            tabPageTarifas.Location = new Point(4, 29);
            tabPageTarifas.Margin = new Padding(3, 4, 3, 4);
            tabPageTarifas.Name = "tabPageTarifas";
            tabPageTarifas.Padding = new Padding(3, 4, 3, 4);
            tabPageTarifas.Size = new Size(948, 579);
            tabPageTarifas.TabIndex = 1;
            tabPageTarifas.Text = "Tarifas";
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(buttonCancelar);
            panelFooter.Controls.Add(buttonGuardar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(12, 624);
            panelFooter.Margin = new Padding(3, 4, 3, 4);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(956, 44);
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
            buttonCancelar.Location = new Point(829, 0);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(127, 43);
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
            buttonGuardar.Location = new Point(694, 0);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(127, 43);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
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
            buttonEditarTarifa.Location = new Point(828, 4);
            buttonEditarTarifa.Margin = new Padding(3, 4, 3, 4);
            buttonEditarTarifa.Name = "buttonEditarTarifa";
            buttonEditarTarifa.Size = new Size(114, 43);
            buttonEditarTarifa.TabIndex = 1;
            buttonEditarTarifa.Text = "Editar";
            buttonEditarTarifa.UseVisualStyleBackColor = false;
            buttonEditarTarifa.Click += buttonEditarTarifa_Click;
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
            buttonAgregarTarifa.Location = new Point(708, 4);
            buttonAgregarTarifa.Margin = new Padding(3, 4, 3, 4);
            buttonAgregarTarifa.Name = "buttonAgregarTarifa";
            buttonAgregarTarifa.Size = new Size(114, 43);
            buttonAgregarTarifa.TabIndex = 2;
            buttonAgregarTarifa.Text = "Agregar";
            buttonAgregarTarifa.UseVisualStyleBackColor = false;
            buttonAgregarTarifa.Click += buttonAgregarTarifa_Click;
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
            dataGridViewTarifas.Location = new Point(0, 68);
            dataGridViewTarifas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTarifas.MultiSelect = false;
            dataGridViewTarifas.Name = "dataGridViewTarifas";
            dataGridViewTarifas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTarifas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTarifas.RowHeadersVisible = false;
            dataGridViewTarifas.RowHeadersWidth = 51;
            dataGridViewTarifas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTarifas.Size = new Size(942, 467);
            dataGridViewTarifas.TabIndex = 0;
            // 
            // columnActualizadoEn
            // 
            columnActualizadoEn.HeaderText = "Actualizado";
            columnActualizadoEn.MinimumWidth = 6;
            columnActualizadoEn.Name = "columnActualizadoEn";
            columnActualizadoEn.ReadOnly = true;
            columnActualizadoEn.Width = 140;
            // 
            // columnMinutosTolerancia
            // 
            columnMinutosTolerancia.HeaderText = "Tolerancia";
            columnMinutosTolerancia.MinimumWidth = 6;
            columnMinutosTolerancia.Name = "columnMinutosTolerancia";
            columnMinutosTolerancia.ReadOnly = true;
            columnMinutosTolerancia.Width = 125;
            // 
            // columnMinutosMinimo
            // 
            columnMinutosMinimo.HeaderText = "Mín. Minutos";
            columnMinutosMinimo.MinimumWidth = 6;
            columnMinutosMinimo.Name = "columnMinutosMinimo";
            columnMinutosMinimo.ReadOnly = true;
            columnMinutosMinimo.Width = 125;
            // 
            // columnFraccion
            // 
            columnFraccion.HeaderText = "Fracción (min)";
            columnFraccion.MinimumWidth = 6;
            columnFraccion.Name = "columnFraccion";
            columnFraccion.ReadOnly = true;
            columnFraccion.Width = 130;
            // 
            // columnTarifaHora
            // 
            columnTarifaHora.HeaderText = "Tarifa por Hora";
            columnTarifaHora.MinimumWidth = 6;
            columnTarifaHora.Name = "columnTarifaHora";
            columnTarifaHora.ReadOnly = true;
            columnTarifaHora.Width = 140;
            // 
            // columnTipo
            // 
            columnTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnTipo.HeaderText = "Tipo de Vehículo";
            columnTipo.MinimumWidth = 6;
            columnTipo.Name = "columnTipo";
            columnTipo.ReadOnly = true;
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
            // panelTarifas
            // 
            panelTarifas.Controls.Add(dataGridViewTarifas);
            panelTarifas.Controls.Add(buttonAgregarTarifa);
            panelTarifas.Controls.Add(buttonEditarTarifa);
            panelTarifas.Dock = DockStyle.Fill;
            panelTarifas.Location = new Point(3, 4);
            panelTarifas.Margin = new Padding(3, 4, 3, 4);
            panelTarifas.Name = "panelTarifas";
            panelTarifas.Padding = new Padding(0, 16, 0, 16);
            panelTarifas.Size = new Size(942, 571);
            panelTarifas.TabIndex = 0;
            // 
            // ConfiguracionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(980, 680);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(900, 620);
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
            panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).EndInit();
            panelTarifas.ResumeLayout(false);
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
