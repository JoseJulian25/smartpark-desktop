namespace SmartPark.UI.Reservas
{
    partial class ReservasForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelMain;
        private Panel panelToolbar;
        private Button buttonNuevaReserva;
        private Button buttonConfirmar;
        private Button buttonEditar;
        private Button buttonCancelar;
        private GroupBox groupBoxFiltros;
        private ComboBox comboBoxEstado;
        private Label labelEstado;
        private DateTimePicker dateTimeFecha;
        private Label labelFecha;
        private TextBox textBoxCliente;
        private Label labelCliente;
        private Button buttonBuscar;
        private GroupBox groupBoxResultados;
        private DataGridView dataGridViewReservas;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnCliente;
        private DataGridViewTextBoxColumn columnPlaca;
        private DataGridViewTextBoxColumn columnTipo;
        private DataGridViewTextBoxColumn columnEspacio;
        private DataGridViewTextBoxColumn columnFecha;
        private DataGridViewTextBoxColumn columnInicio;
        private DataGridViewTextBoxColumn columnFin;
        private DataGridViewTextBoxColumn columnEstado;
        private DataGridViewTextBoxColumn columnMotivoCancelacion;

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
            groupBoxResultados = new GroupBox();
            dataGridViewReservas = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnCliente = new DataGridViewTextBoxColumn();
            columnPlaca = new DataGridViewTextBoxColumn();
            columnTipo = new DataGridViewTextBoxColumn();
            columnEspacio = new DataGridViewTextBoxColumn();
            columnFecha = new DataGridViewTextBoxColumn();
            columnInicio = new DataGridViewTextBoxColumn();
            columnFin = new DataGridViewTextBoxColumn();
            columnEstado = new DataGridViewTextBoxColumn();
            columnMotivoCancelacion = new DataGridViewTextBoxColumn();
            groupBoxFiltros = new GroupBox();
            buttonBuscar = new Button();
            textBoxCliente = new TextBox();
            labelCliente = new Label();
            dateTimeFecha = new DateTimePicker();
            labelFecha = new Label();
            comboBoxEstado = new ComboBox();
            labelEstado = new Label();
            panelToolbar = new Panel();
            buttonConfirmar = new Button();
            buttonEditar = new Button();
            buttonNuevaReserva = new Button();
            buttonCancelar = new Button();
            panelMain.SuspendLayout();
            groupBoxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).BeginInit();
            groupBoxFiltros.SuspendLayout();
            panelToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxResultados);
            panelMain.Controls.Add(groupBoxFiltros);
            panelMain.Controls.Add(panelToolbar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(1280, 820);
            panelMain.TabIndex = 0;
            // 
            // groupBoxResultados
            // 
            groupBoxResultados.Controls.Add(dataGridViewReservas);
            groupBoxResultados.Dock = DockStyle.Fill;
            groupBoxResultados.Font = new Font("Segoe UI", 9F);
            groupBoxResultados.Location = new Point(16, 198);
            groupBoxResultados.Name = "groupBoxResultados";
            groupBoxResultados.Padding = new Padding(10, 10, 10, 12);
            groupBoxResultados.Size = new Size(1248, 606);
            groupBoxResultados.TabIndex = 2;
            groupBoxResultados.TabStop = false;
            groupBoxResultados.Text = "Reservas Registradas";
            // 
            // dataGridViewReservas
            // 
            dataGridViewReservas.AllowUserToAddRows = false;
            dataGridViewReservas.AllowUserToDeleteRows = false;
            dataGridViewReservas.AllowUserToResizeRows = false;
            dataGridViewReservas.BackgroundColor = Color.White;
            dataGridViewReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservas.Columns.AddRange(new DataGridViewColumn[] { columnId, columnCliente, columnPlaca, columnTipo, columnEspacio, columnFecha, columnInicio, columnFin, columnEstado, columnMotivoCancelacion });
            dataGridViewReservas.Dock = DockStyle.Fill;
            dataGridViewReservas.Location = new Point(10, 30);
            dataGridViewReservas.MultiSelect = false;
            dataGridViewReservas.Name = "dataGridViewReservas";
            dataGridViewReservas.ReadOnly = true;
            dataGridViewReservas.RowHeadersVisible = false;
            dataGridViewReservas.RowHeadersWidth = 51;
            dataGridViewReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservas.Size = new Size(1228, 564);
            dataGridViewReservas.TabIndex = 0;
            dataGridViewReservas.CellFormatting += dataGridViewReservas_CellFormatting;
            // 
            // columnId
            // 
            columnId.HeaderText = "ID";
            columnId.MinimumWidth = 6;
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            columnId.Width = 60;
            // 
            // columnCliente
            // 
            columnCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCliente.HeaderText = "Cliente";
            columnCliente.MinimumWidth = 6;
            columnCliente.Name = "columnCliente";
            columnCliente.ReadOnly = true;
            // 
            // columnPlaca
            // 
            columnPlaca.HeaderText = "Placa";
            columnPlaca.MinimumWidth = 6;
            columnPlaca.Name = "columnPlaca";
            columnPlaca.ReadOnly = true;
            columnPlaca.Width = 110;
            // 
            // columnTipo
            // 
            columnTipo.HeaderText = "Tipo";
            columnTipo.MinimumWidth = 6;
            columnTipo.Name = "columnTipo";
            columnTipo.ReadOnly = true;
            columnTipo.Width = 120;
            // 
            // columnEspacio
            // 
            columnEspacio.HeaderText = "Espacio";
            columnEspacio.MinimumWidth = 6;
            columnEspacio.Name = "columnEspacio";
            columnEspacio.ReadOnly = true;
            columnEspacio.Width = 90;
            // 
            // columnFecha
            // 
            columnFecha.HeaderText = "Fecha";
            columnFecha.MinimumWidth = 6;
            columnFecha.Name = "columnFecha";
            columnFecha.ReadOnly = true;
            columnFecha.Width = 120;
            // 
            // columnInicio
            // 
            columnInicio.HeaderText = "Inicio";
            columnInicio.MinimumWidth = 6;
            columnInicio.Name = "columnInicio";
            columnInicio.ReadOnly = true;
            columnInicio.Width = 90;
            // 
            // columnFin
            // 
            columnFin.HeaderText = "Fin";
            columnFin.MinimumWidth = 6;
            columnFin.Name = "columnFin";
            columnFin.ReadOnly = true;
            columnFin.Width = 90;
            // 
            // columnEstado
            // 
            columnEstado.HeaderText = "Estado";
            columnEstado.MinimumWidth = 6;
            columnEstado.Name = "columnEstado";
            columnEstado.ReadOnly = true;
            columnEstado.Width = 110;
            // 
            // columnMotivoCancelacion
            // 
            columnMotivoCancelacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnMotivoCancelacion.HeaderText = "Motivo cancelacion";
            columnMotivoCancelacion.MinimumWidth = 6;
            columnMotivoCancelacion.Name = "columnMotivoCancelacion";
            columnMotivoCancelacion.ReadOnly = true;
            // 
            // groupBoxFiltros
            // 
            groupBoxFiltros.Controls.Add(buttonBuscar);
            groupBoxFiltros.Controls.Add(textBoxCliente);
            groupBoxFiltros.Controls.Add(labelCliente);
            groupBoxFiltros.Controls.Add(dateTimeFecha);
            groupBoxFiltros.Controls.Add(labelFecha);
            groupBoxFiltros.Controls.Add(comboBoxEstado);
            groupBoxFiltros.Controls.Add(labelEstado);
            groupBoxFiltros.Dock = DockStyle.Top;
            groupBoxFiltros.Font = new Font("Segoe UI", 9F);
            groupBoxFiltros.Location = new Point(16, 94);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Padding = new Padding(10, 10, 10, 12);
            groupBoxFiltros.Size = new Size(1248, 104);
            groupBoxFiltros.TabIndex = 1;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "Filtros";
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.FromArgb(31, 118, 221);
            buttonBuscar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(733, 52);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(92, 30);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(476, 54);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(210, 27);
            textBoxCliente.TabIndex = 5;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(476, 30);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(58, 20);
            labelCliente.TabIndex = 4;
            labelCliente.Text = "Cliente:";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(282, 54);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(170, 27);
            dateTimeFecha.TabIndex = 3;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(282, 30);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(50, 20);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "Fecha:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Activa", "Finalizada", "Cancelada" });
            comboBoxEstado.Location = new Point(16, 54);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(240, 28);
            comboBoxEstado.TabIndex = 1;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(16, 30);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(57, 20);
            labelEstado.TabIndex = 0;
            labelEstado.Text = "Estado:";
            // 
            // panelToolbar
            // 
            panelToolbar.Controls.Add(buttonCancelar);
            panelToolbar.Controls.Add(buttonConfirmar);
            panelToolbar.Controls.Add(buttonEditar);
            panelToolbar.Controls.Add(buttonNuevaReserva);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(16, 16);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(0, 10, 0, 10);
            panelToolbar.Size = new Size(1248, 78);
            panelToolbar.TabIndex = 0;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.White;
            buttonConfirmar.FlatAppearance.BorderColor = Color.FromArgb(40, 66, 104);
            buttonConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 234, 243);
            buttonConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 246, 252);
            buttonConfirmar.FlatStyle = FlatStyle.Flat;
            buttonConfirmar.ForeColor = Color.FromArgb(40, 66, 104);
            buttonConfirmar.Location = new Point(260, 18);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(120, 36);
            buttonConfirmar.TabIndex = 2;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 228, 230);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 239, 241);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.FromArgb(220, 53, 69);
            buttonCancelar.Location = new Point(390, 18);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(130, 36);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Cancelar reserva";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.White;
            buttonEditar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonEditar.Location = new Point(150, 18);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(100, 36);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonNuevaReserva
            // 
            buttonNuevaReserva.BackColor = Color.FromArgb(31, 118, 221);
            buttonNuevaReserva.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonNuevaReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonNuevaReserva.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonNuevaReserva.FlatStyle = FlatStyle.Flat;
            buttonNuevaReserva.ForeColor = Color.White;
            buttonNuevaReserva.Location = new Point(0, 18);
            buttonNuevaReserva.Name = "buttonNuevaReserva";
            buttonNuevaReserva.Size = new Size(140, 36);
            buttonNuevaReserva.TabIndex = 0;
            buttonNuevaReserva.Text = "Nueva Reserva";
            buttonNuevaReserva.UseVisualStyleBackColor = false;
            buttonNuevaReserva.Click += buttonNuevaReserva_Click;
            // 
            // ReservasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(1280, 820);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 720);
            Name = "ReservasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Gestion de Reservas";
            Load += ReservasForm_Load_1;
            panelMain.ResumeLayout(false);
            groupBoxResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).EndInit();
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
            panelToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
