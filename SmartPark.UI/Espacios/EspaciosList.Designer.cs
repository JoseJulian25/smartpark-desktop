namespace SmartPark.UI.Espacios
{
    partial class EspaciosList
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
            groupBoxListaEspacios = new GroupBox();
            dataGridViewEspacios = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnCodigo = new DataGridViewTextBoxColumn();
            columnTipo = new DataGridViewTextBoxColumn();
            columnEstado = new DataGridViewTextBoxColumn();
            columnVehiculo = new DataGridViewTextBoxColumn();
            panelToolbar = new Panel();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevoEspacio = new Button();
            groupBoxResumen = new GroupBox();
            tableLayoutPanelResumen = new TableLayoutPanel();
            panelResumenTotal = new Panel();
            labelTotalValue = new Label();
            labelTotalTitle = new Label();
            panelResumenLibres = new Panel();
            labelLibresValue = new Label();
            labelLibresTitle = new Label();
            panelResumenOcupados = new Panel();
            labelOcupadosValue = new Label();
            labelOcupadosTitle = new Label();
            panelResumenReservados = new Panel();
            labelReservadosValue = new Label();
            labelReservadosTitle = new Label();
            panelResumenMantenimiento = new Panel();
            labelMantenimientoValue = new Label();
            labelMantenimientoTitle = new Label();
            statusStripMain = new StatusStrip();
            toolStripStatusUsuario = new ToolStripStatusLabel();
            toolStripStatusSep = new ToolStripStatusLabel();
            toolStripStatusFecha = new ToolStripStatusLabel();
            panelMain.SuspendLayout();
            groupBoxListaEspacios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEspacios).BeginInit();
            panelToolbar.SuspendLayout();
            groupBoxResumen.SuspendLayout();
            tableLayoutPanelResumen.SuspendLayout();
            panelResumenTotal.SuspendLayout();
            panelResumenLibres.SuspendLayout();
            panelResumenOcupados.SuspendLayout();
            panelResumenReservados.SuspendLayout();
            panelResumenMantenimiento.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxListaEspacios);
            panelMain.Controls.Add(panelToolbar);
            panelMain.Controls.Add(groupBoxResumen);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(1364, 761);
            panelMain.TabIndex = 0;
            // 
            // groupBoxListaEspacios
            // 
            groupBoxListaEspacios.Controls.Add(dataGridViewEspacios);
            groupBoxListaEspacios.Dock = DockStyle.Fill;
            groupBoxListaEspacios.Font = new Font("Segoe UI", 9F);
            groupBoxListaEspacios.Location = new Point(16, 222);
            groupBoxListaEspacios.Name = "groupBoxListaEspacios";
            groupBoxListaEspacios.Padding = new Padding(10, 10, 10, 12);
            groupBoxListaEspacios.Size = new Size(1332, 523);
            groupBoxListaEspacios.TabIndex = 2;
            groupBoxListaEspacios.TabStop = false;
            groupBoxListaEspacios.Text = "Espacios Disponibles";
            // 
            // dataGridViewEspacios
            // 
            dataGridViewEspacios.AllowUserToAddRows = false;
            dataGridViewEspacios.AllowUserToDeleteRows = false;
            dataGridViewEspacios.AllowUserToResizeRows = false;
            dataGridViewEspacios.BackgroundColor = Color.White;
            dataGridViewEspacios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEspacios.Columns.AddRange(new DataGridViewColumn[] { columnId, columnCodigo, columnTipo, columnEstado, columnVehiculo });
            dataGridViewEspacios.Dock = DockStyle.Fill;
            dataGridViewEspacios.Location = new Point(10, 30);
            dataGridViewEspacios.MultiSelect = false;
            dataGridViewEspacios.Name = "dataGridViewEspacios";
            dataGridViewEspacios.ReadOnly = true;
            dataGridViewEspacios.RowHeadersVisible = false;
            dataGridViewEspacios.RowHeadersWidth = 51;
            dataGridViewEspacios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEspacios.Size = new Size(1312, 481);
            dataGridViewEspacios.TabIndex = 0;
            // 
            // columnId
            // 
            columnId.HeaderText = "ID";
            columnId.MinimumWidth = 6;
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            columnId.Width = 60;
            // 
            // columnCodigo
            // 
            columnCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCodigo.HeaderText = "Código";
            columnCodigo.MinimumWidth = 6;
            columnCodigo.Name = "columnCodigo";
            columnCodigo.ReadOnly = true;
            // 
            // columnTipo
            // 
            columnTipo.HeaderText = "Tipo";
            columnTipo.MinimumWidth = 6;
            columnTipo.Name = "columnTipo";
            columnTipo.ReadOnly = true;
            columnTipo.Width = 140;
            // 
            // columnEstado
            // 
            columnEstado.HeaderText = "Estado";
            columnEstado.MinimumWidth = 6;
            columnEstado.Name = "columnEstado";
            columnEstado.ReadOnly = true;
            columnEstado.Width = 140;
            // 
            // columnVehiculo
            // 
            columnVehiculo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnVehiculo.HeaderText = "Vehículo Actual";
            columnVehiculo.MinimumWidth = 6;
            columnVehiculo.Name = "columnVehiculo";
            columnVehiculo.ReadOnly = true;
            // 
            // panelToolbar
            // 
            panelToolbar.Controls.Add(buttonActualizar);
            panelToolbar.Controls.Add(buttonEliminar);
            panelToolbar.Controls.Add(buttonEditar);
            panelToolbar.Controls.Add(buttonNuevoEspacio);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(16, 156);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(0, 10, 0, 10);
            panelToolbar.Size = new Size(1332, 66);
            panelToolbar.TabIndex = 1;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.White;
            buttonActualizar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonActualizar.Location = new Point(330, 10);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(100, 36);
            buttonActualizar.TabIndex = 3;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.White;
            buttonEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 228, 230);
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 239, 241);
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.ForeColor = Color.FromArgb(220, 53, 69);
            buttonEliminar.Location = new Point(234, 10);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(90, 36);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.White;
            buttonEditar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonEditar.Location = new Point(138, 10);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(90, 36);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonNuevoEspacio
            // 
            buttonNuevoEspacio.BackColor = Color.FromArgb(31, 118, 221);
            buttonNuevoEspacio.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonNuevoEspacio.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonNuevoEspacio.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonNuevoEspacio.FlatStyle = FlatStyle.Flat;
            buttonNuevoEspacio.ForeColor = Color.White;
            buttonNuevoEspacio.Location = new Point(0, 10);
            buttonNuevoEspacio.Name = "buttonNuevoEspacio";
            buttonNuevoEspacio.Size = new Size(132, 36);
            buttonNuevoEspacio.TabIndex = 0;
            buttonNuevoEspacio.Text = "Nuevo Espacio";
            buttonNuevoEspacio.UseVisualStyleBackColor = false;
            buttonNuevoEspacio.Click += buttonNuevoEspacio_Click;
            // 
            // groupBoxResumen
            // 
            groupBoxResumen.Controls.Add(tableLayoutPanelResumen);
            groupBoxResumen.Dock = DockStyle.Top;
            groupBoxResumen.Font = new Font("Segoe UI", 9F);
            groupBoxResumen.Location = new Point(16, 16);
            groupBoxResumen.Name = "groupBoxResumen";
            groupBoxResumen.Padding = new Padding(10, 10, 10, 12);
            groupBoxResumen.Size = new Size(1332, 140);
            groupBoxResumen.TabIndex = 0;
            groupBoxResumen.TabStop = false;
            groupBoxResumen.Text = "Resumen de Espacios";
            // 
            // tableLayoutPanelResumen
            // 
            tableLayoutPanelResumen.ColumnCount = 5;
            tableLayoutPanelResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelResumen.Controls.Add(panelResumenTotal, 0, 0);
            tableLayoutPanelResumen.Controls.Add(panelResumenLibres, 1, 0);
            tableLayoutPanelResumen.Controls.Add(panelResumenOcupados, 2, 0);
            tableLayoutPanelResumen.Controls.Add(panelResumenReservados, 3, 0);
            tableLayoutPanelResumen.Controls.Add(panelResumenMantenimiento, 4, 0);
            tableLayoutPanelResumen.Dock = DockStyle.Fill;
            tableLayoutPanelResumen.Location = new Point(10, 30);
            tableLayoutPanelResumen.Name = "tableLayoutPanelResumen";
            tableLayoutPanelResumen.RowCount = 1;
            tableLayoutPanelResumen.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelResumen.Size = new Size(1312, 98);
            tableLayoutPanelResumen.TabIndex = 0;
            // 
            // panelResumenTotal
            // 
            panelResumenTotal.BackColor = Color.White;
            panelResumenTotal.BorderStyle = BorderStyle.FixedSingle;
            panelResumenTotal.Controls.Add(labelTotalValue);
            panelResumenTotal.Controls.Add(labelTotalTitle);
            panelResumenTotal.Dock = DockStyle.Fill;
            panelResumenTotal.Location = new Point(3, 3);
            panelResumenTotal.Name = "panelResumenTotal";
            panelResumenTotal.Padding = new Padding(10);
            panelResumenTotal.Size = new Size(256, 92);
            panelResumenTotal.TabIndex = 0;
            // 
            // labelTotalValue
            // 
            labelTotalValue.AutoSize = true;
            labelTotalValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTotalValue.Location = new Point(12, 36);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(52, 41);
            labelTotalValue.TabIndex = 1;
            labelTotalValue.Text = "10";
            // 
            // labelTotalTitle
            // 
            labelTotalTitle.AutoSize = true;
            labelTotalTitle.Location = new Point(12, 12);
            labelTotalTitle.Name = "labelTotalTitle";
            labelTotalTitle.Size = new Size(42, 20);
            labelTotalTitle.TabIndex = 0;
            labelTotalTitle.Text = "Total";
            // 
            // panelResumenLibres
            // 
            panelResumenLibres.BackColor = Color.White;
            panelResumenLibres.BorderStyle = BorderStyle.FixedSingle;
            panelResumenLibres.Controls.Add(labelLibresValue);
            panelResumenLibres.Controls.Add(labelLibresTitle);
            panelResumenLibres.Dock = DockStyle.Fill;
            panelResumenLibres.Location = new Point(265, 3);
            panelResumenLibres.Name = "panelResumenLibres";
            panelResumenLibres.Padding = new Padding(10);
            panelResumenLibres.Size = new Size(256, 92);
            panelResumenLibres.TabIndex = 1;
            // 
            // labelLibresValue
            // 
            labelLibresValue.AutoSize = true;
            labelLibresValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelLibresValue.ForeColor = Color.FromArgb(16, 124, 16);
            labelLibresValue.Location = new Point(12, 36);
            labelLibresValue.Name = "labelLibresValue";
            labelLibresValue.Size = new Size(35, 41);
            labelLibresValue.TabIndex = 1;
            labelLibresValue.Text = "0";
            // 
            // labelLibresTitle
            // 
            labelLibresTitle.AutoSize = true;
            labelLibresTitle.Location = new Point(12, 12);
            labelLibresTitle.Name = "labelLibresTitle";
            labelLibresTitle.Size = new Size(48, 20);
            labelLibresTitle.TabIndex = 0;
            labelLibresTitle.Text = "Libres";
            // 
            // panelResumenOcupados
            // 
            panelResumenOcupados.BackColor = Color.White;
            panelResumenOcupados.BorderStyle = BorderStyle.FixedSingle;
            panelResumenOcupados.Controls.Add(labelOcupadosValue);
            panelResumenOcupados.Controls.Add(labelOcupadosTitle);
            panelResumenOcupados.Dock = DockStyle.Fill;
            panelResumenOcupados.Location = new Point(527, 3);
            panelResumenOcupados.Name = "panelResumenOcupados";
            panelResumenOcupados.Padding = new Padding(10);
            panelResumenOcupados.Size = new Size(256, 92);
            panelResumenOcupados.TabIndex = 2;
            // 
            // labelOcupadosValue
            // 
            labelOcupadosValue.AutoSize = true;
            labelOcupadosValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelOcupadosValue.ForeColor = Color.FromArgb(232, 17, 35);
            labelOcupadosValue.Location = new Point(12, 36);
            labelOcupadosValue.Name = "labelOcupadosValue";
            labelOcupadosValue.Size = new Size(35, 41);
            labelOcupadosValue.TabIndex = 1;
            labelOcupadosValue.Text = "0";
            // 
            // labelOcupadosTitle
            // 
            labelOcupadosTitle.AutoSize = true;
            labelOcupadosTitle.Location = new Point(12, 12);
            labelOcupadosTitle.Name = "labelOcupadosTitle";
            labelOcupadosTitle.Size = new Size(76, 20);
            labelOcupadosTitle.TabIndex = 0;
            labelOcupadosTitle.Text = "Ocupados";
            // 
            // panelResumenReservados
            // 
            panelResumenReservados.BackColor = Color.White;
            panelResumenReservados.BorderStyle = BorderStyle.FixedSingle;
            panelResumenReservados.Controls.Add(labelReservadosValue);
            panelResumenReservados.Controls.Add(labelReservadosTitle);
            panelResumenReservados.Dock = DockStyle.Fill;
            panelResumenReservados.Location = new Point(789, 3);
            panelResumenReservados.Name = "panelResumenReservados";
            panelResumenReservados.Padding = new Padding(10);
            panelResumenReservados.Size = new Size(256, 92);
            panelResumenReservados.TabIndex = 3;
            // 
            // labelReservadosValue
            // 
            labelReservadosValue.AutoSize = true;
            labelReservadosValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelReservadosValue.ForeColor = Color.FromArgb(255, 140, 0);
            labelReservadosValue.Location = new Point(12, 36);
            labelReservadosValue.Name = "labelReservadosValue";
            labelReservadosValue.Size = new Size(35, 41);
            labelReservadosValue.TabIndex = 1;
            labelReservadosValue.Text = "0";
            // 
            // labelReservadosTitle
            // 
            labelReservadosTitle.AutoSize = true;
            labelReservadosTitle.Location = new Point(12, 12);
            labelReservadosTitle.Name = "labelReservadosTitle";
            labelReservadosTitle.Size = new Size(84, 20);
            labelReservadosTitle.TabIndex = 0;
            labelReservadosTitle.Text = "Reservados";
            // 
            // panelResumenMantenimiento
            // 
            panelResumenMantenimiento.BackColor = Color.White;
            panelResumenMantenimiento.BorderStyle = BorderStyle.FixedSingle;
            panelResumenMantenimiento.Controls.Add(labelMantenimientoValue);
            panelResumenMantenimiento.Controls.Add(labelMantenimientoTitle);
            panelResumenMantenimiento.Dock = DockStyle.Fill;
            panelResumenMantenimiento.Location = new Point(1051, 3);
            panelResumenMantenimiento.Name = "panelResumenMantenimiento";
            panelResumenMantenimiento.Padding = new Padding(10);
            panelResumenMantenimiento.Size = new Size(258, 92);
            panelResumenMantenimiento.TabIndex = 4;
            // 
            // labelMantenimientoValue
            // 
            labelMantenimientoValue.AutoSize = true;
            labelMantenimientoValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelMantenimientoValue.ForeColor = Color.FromArgb(109, 109, 109);
            labelMantenimientoValue.Location = new Point(12, 36);
            labelMantenimientoValue.Name = "labelMantenimientoValue";
            labelMantenimientoValue.Size = new Size(35, 41);
            labelMantenimientoValue.TabIndex = 1;
            labelMantenimientoValue.Text = "0";
            // 
            // labelMantenimientoTitle
            // 
            labelMantenimientoTitle.AutoSize = true;
            labelMantenimientoTitle.Location = new Point(12, 12);
            labelMantenimientoTitle.Name = "labelMantenimientoTitle";
            labelMantenimientoTitle.Size = new Size(110, 20);
            labelMantenimientoTitle.TabIndex = 0;
            labelMantenimientoTitle.Text = "Mantenimiento";
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusUsuario, toolStripStatusSep, toolStripStatusFecha });
            statusStripMain.Location = new Point(0, 735);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1364, 26);
            statusStripMain.SizingGrip = false;
            statusStripMain.TabIndex = 1;
            statusStripMain.Text = "statusStripMain";
            // 
            // toolStripStatusUsuario
            // 
            toolStripStatusUsuario.Name = "toolStripStatusUsuario";
            toolStripStatusUsuario.Size = new Size(110, 20);
            toolStripStatusUsuario.Text = "Usuario: Admin";
            // 
            // toolStripStatusSep
            // 
            toolStripStatusSep.Name = "toolStripStatusSep";
            toolStripStatusSep.Size = new Size(13, 20);
            toolStripStatusSep.Text = "|";
            // 
            // toolStripStatusFecha
            // 
            toolStripStatusFecha.Name = "toolStripStatusFecha";
            toolStripStatusFecha.Size = new Size(189, 20);
            toolStripStatusFecha.Text = "martes, 15 de abril de 2026";
            // 
            // EspaciosList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(1364, 761);
            Controls.Add(statusStripMain);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1200, 700);
            Name = "EspaciosList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartPark - Espacios";
            panelMain.ResumeLayout(false);
            groupBoxListaEspacios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEspacios).EndInit();
            panelToolbar.ResumeLayout(false);
            groupBoxResumen.ResumeLayout(false);
            tableLayoutPanelResumen.ResumeLayout(false);
            panelResumenTotal.ResumeLayout(false);
            panelResumenTotal.PerformLayout();
            panelResumenLibres.ResumeLayout(false);
            panelResumenLibres.PerformLayout();
            panelResumenOcupados.ResumeLayout(false);
            panelResumenOcupados.PerformLayout();
            panelResumenReservados.ResumeLayout(false);
            panelResumenReservados.PerformLayout();
            panelResumenMantenimiento.ResumeLayout(false);
            panelResumenMantenimiento.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private GroupBox groupBoxListaEspacios;
        private DataGridView dataGridViewEspacios;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnCodigo;
        private DataGridViewTextBoxColumn columnTipo;
        private DataGridViewTextBoxColumn columnEstado;
        private DataGridViewTextBoxColumn columnVehiculo;
        private GroupBox groupBoxResumen;
        private TableLayoutPanel tableLayoutPanelResumen;
        private Panel panelResumenTotal;
        private Label labelTotalValue;
        private Label labelTotalTitle;
        private Panel panelResumenLibres;
        private Label labelLibresValue;
        private Label labelLibresTitle;
        private Panel panelResumenOcupados;
        private Label labelOcupadosValue;
        private Label labelOcupadosTitle;
        private Panel panelResumenReservados;
        private Label labelReservadosValue;
        private Label labelReservadosTitle;
        private Panel panelResumenMantenimiento;
        private Label labelMantenimientoValue;
        private Label labelMantenimientoTitle;
        private Panel panelToolbar;
        private Button buttonNuevoEspacio;
        private Button buttonEditar;
        private Button buttonEliminar;
        private Button buttonActualizar;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusUsuario;
        private ToolStripStatusLabel toolStripStatusSep;
        private ToolStripStatusLabel toolStripStatusFecha;
    }
}
