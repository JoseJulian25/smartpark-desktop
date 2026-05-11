namespace SmartPark.UI.Usuarios
{
    partial class UsuariosForm
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
            groupBoxUsuarios = new GroupBox();
            dataGridViewUsuarios = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnNombre = new DataGridViewTextBoxColumn();
            columnUsuario = new DataGridViewTextBoxColumn();
            columnRol = new DataGridViewTextBoxColumn();
            columnEstado = new DataGridViewTextBoxColumn();
            columnFechaCreacion = new DataGridViewTextBoxColumn();
            groupBoxBusqueda = new GroupBox();
            buttonLimpiar = new Button();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            labelBuscar = new Label();
            panelToolbar = new Panel();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            panelMain.SuspendLayout();
            groupBoxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            groupBoxBusqueda.SuspendLayout();
            panelToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxUsuarios);
            panelMain.Controls.Add(groupBoxBusqueda);
            panelMain.Controls.Add(panelToolbar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(1220, 820);
            panelMain.TabIndex = 0;
            // 
            // groupBoxUsuarios
            // 
            groupBoxUsuarios.Controls.Add(dataGridViewUsuarios);
            groupBoxUsuarios.Dock = DockStyle.Fill;
            groupBoxUsuarios.Font = new Font("Segoe UI", 9F);
            groupBoxUsuarios.Location = new Point(16, 188);
            groupBoxUsuarios.Name = "groupBoxUsuarios";
            groupBoxUsuarios.Padding = new Padding(10, 10, 10, 12);
            groupBoxUsuarios.Size = new Size(1188, 616);
            groupBoxUsuarios.TabIndex = 3;
            groupBoxUsuarios.TabStop = false;
            groupBoxUsuarios.Text = "Usuarios Registrados";
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AllowUserToResizeRows = false;
            dataGridViewUsuarios.BackgroundColor = Color.White;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { columnId, columnNombre, columnUsuario, columnRol, columnEstado, columnFechaCreacion });
            dataGridViewUsuarios.Dock = DockStyle.Fill;
            dataGridViewUsuarios.Location = new Point(10, 30);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(1168, 574);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // columnId
            // 
            columnId.HeaderText = "ID";
            columnId.MinimumWidth = 6;
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            columnId.Width = 60;
            // 
            // columnNombre
            // 
            columnNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnNombre.HeaderText = "Nombre";
            columnNombre.MinimumWidth = 6;
            columnNombre.Name = "columnNombre";
            columnNombre.ReadOnly = true;
            // 
            // columnUsuario
            // 
            columnUsuario.HeaderText = "Usuario";
            columnUsuario.MinimumWidth = 6;
            columnUsuario.Name = "columnUsuario";
            columnUsuario.ReadOnly = true;
            columnUsuario.Width = 140;
            // 
            // columnRol
            // 
            columnRol.HeaderText = "Rol";
            columnRol.MinimumWidth = 6;
            columnRol.Name = "columnRol";
            columnRol.ReadOnly = true;
            columnRol.Width = 140;
            // 
            // columnEstado
            // 
            columnEstado.HeaderText = "Estado";
            columnEstado.MinimumWidth = 6;
            columnEstado.Name = "columnEstado";
            columnEstado.ReadOnly = true;
            columnEstado.Width = 110;
            // 
            // columnFechaCreacion
            // 
            columnFechaCreacion.HeaderText = "Fecha Creacion";
            columnFechaCreacion.MinimumWidth = 6;
            columnFechaCreacion.Name = "columnFechaCreacion";
            columnFechaCreacion.ReadOnly = true;
            columnFechaCreacion.Width = 160;
            // 
            // groupBoxBusqueda
            // 
            groupBoxBusqueda.Controls.Add(buttonLimpiar);
            groupBoxBusqueda.Controls.Add(buttonBuscar);
            groupBoxBusqueda.Controls.Add(textBoxBuscar);
            groupBoxBusqueda.Controls.Add(labelBuscar);
            groupBoxBusqueda.Dock = DockStyle.Top;
            groupBoxBusqueda.Font = new Font("Segoe UI", 9F);
            groupBoxBusqueda.Location = new Point(16, 94);
            groupBoxBusqueda.Name = "groupBoxBusqueda";
            groupBoxBusqueda.Padding = new Padding(10, 10, 10, 12);
            groupBoxBusqueda.Size = new Size(1188, 94);
            groupBoxBusqueda.TabIndex = 2;
            groupBoxBusqueda.TabStop = false;
            groupBoxBusqueda.Text = "Busqueda Rapida";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.White;
            buttonLimpiar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonLimpiar.Location = new Point(512, 42);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(92, 32);
            buttonLimpiar.TabIndex = 3;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.FromArgb(31, 118, 221);
            buttonBuscar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(414, 42);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(92, 32);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(16, 46);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(384, 27);
            textBoxBuscar.TabIndex = 1;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(16, 24);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(55, 20);
            labelBuscar.TabIndex = 0;
            labelBuscar.Text = "Buscar:";
            // 
            // panelToolbar
            // 
            panelToolbar.Controls.Add(buttonEliminar);
            panelToolbar.Controls.Add(buttonEditar);
            panelToolbar.Controls.Add(buttonNuevo);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(16, 16);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(0, 10, 0, 10);
            panelToolbar.Size = new Size(1188, 78);
            panelToolbar.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.White;
            buttonEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69);
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 228, 230);
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 239, 241);
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.ForeColor = Color.FromArgb(220, 53, 69);
            buttonEliminar.Location = new Point(220, 18);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(90, 36);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Desactivar";
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
            buttonEditar.Location = new Point(124, 18);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(90, 36);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = Color.FromArgb(31, 118, 221);
            buttonNuevo.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonNuevo.FlatStyle = FlatStyle.Flat;
            buttonNuevo.ForeColor = Color.White;
            buttonNuevo.Location = new Point(0, 18);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(118, 36);
            buttonNuevo.TabIndex = 0;
            buttonNuevo.Text = "Nuevo Usuario";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(1220, 820);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 720);
            Name = "UsuariosForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Usuarios";
            Load += UsuariosForm_Load_1;
            panelMain.ResumeLayout(false);
            groupBoxUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            groupBoxBusqueda.ResumeLayout(false);
            groupBoxBusqueda.PerformLayout();
            panelToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private GroupBox groupBoxUsuarios;
        private DataGridView dataGridViewUsuarios;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnNombre;
        private DataGridViewTextBoxColumn columnUsuario;
        private DataGridViewTextBoxColumn columnRol;
        private DataGridViewTextBoxColumn columnEstado;
        private DataGridViewTextBoxColumn columnUltimoAcceso;
        private GroupBox groupBoxBusqueda;
        private Button buttonLimpiar;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private Label labelBuscar;
        private Panel panelToolbar;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private DataGridViewTextBoxColumn columnFechaCreacion;
    }
}
