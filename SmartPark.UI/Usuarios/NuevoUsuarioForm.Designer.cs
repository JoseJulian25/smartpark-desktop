namespace SmartPark.UI.Usuarios
{
    partial class NuevoUsuarioForm
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
            groupBoxFormulario = new GroupBox();
            buttonGuardar = new Button();
            textBoxConfirmar = new TextBox();
            labelConfirmar = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            comboBoxRol = new ComboBox();
            labelRol = new Label();
            textBoxUsuario = new TextBox();
            labelUsuario = new Label();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            panelMain.SuspendLayout();
            groupBoxFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxFormulario);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(760, 360);
            panelMain.TabIndex = 0;
            // 
            // groupBoxFormulario
            // 
            groupBoxFormulario.Controls.Add(buttonGuardar);
            groupBoxFormulario.Controls.Add(textBoxConfirmar);
            groupBoxFormulario.Controls.Add(labelConfirmar);
            groupBoxFormulario.Controls.Add(textBoxPassword);
            groupBoxFormulario.Controls.Add(labelPassword);
            groupBoxFormulario.Controls.Add(comboBoxRol);
            groupBoxFormulario.Controls.Add(labelRol);
            groupBoxFormulario.Controls.Add(textBoxUsuario);
            groupBoxFormulario.Controls.Add(labelUsuario);
            groupBoxFormulario.Controls.Add(textBoxNombre);
            groupBoxFormulario.Controls.Add(labelNombre);
            groupBoxFormulario.Dock = DockStyle.Fill;
            groupBoxFormulario.Font = new Font("Segoe UI", 9F);
            groupBoxFormulario.Location = new Point(16, 16);
            groupBoxFormulario.Name = "groupBoxFormulario";
            groupBoxFormulario.Padding = new Padding(12);
            groupBoxFormulario.Size = new Size(728, 328);
            groupBoxFormulario.TabIndex = 0;
            groupBoxFormulario.TabStop = false;
            groupBoxFormulario.Text = "Nuevo Usuario";
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(303, 281);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(120, 32);
            buttonGuardar.TabIndex = 12;
            buttonGuardar.Text = "Guardar Usuario";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click_1;
            // 
            // textBoxConfirmar
            // 
            textBoxConfirmar.Location = new Point(159, 219);
            textBoxConfirmar.Name = "textBoxConfirmar";
            textBoxConfirmar.Size = new Size(220, 27);
            textBoxConfirmar.TabIndex = 10;
            textBoxConfirmar.UseSystemPasswordChar = true;
            // 
            // labelConfirmar
            // 
            labelConfirmar.AutoSize = true;
            labelConfirmar.Location = new Point(15, 219);
            labelConfirmar.Name = "labelConfirmar";
            labelConfirmar.Size = new Size(118, 20);
            labelConfirmar.TabIndex = 9;
            labelConfirmar.Text = "Confirmar Clave:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(159, 174);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(220, 27);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(15, 174);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 20);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Contrasena:";
            // 
            // comboBoxRol
            // 
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Administrador", "Supervisor", "Operador", "Cajero", "Seguridad" });
            comboBoxRol.Location = new Point(159, 136);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(160, 28);
            comboBoxRol.TabIndex = 6;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(16, 136);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(34, 20);
            labelRol.TabIndex = 5;
            labelRol.Text = "Rol:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(159, 94);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(160, 27);
            textBoxUsuario.TabIndex = 2;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(16, 97);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(62, 20);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(159, 59);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(320, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(16, 59);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(137, 20);
            labelNombre.TabIndex = 14;
            labelNombre.Text = "Nombre Completo:";
            // 
            // NuevoUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(760, 360);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(760, 360);
            Name = "NuevoUsuarioForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Nuevo Usuario";
            Load += NuevoUsuarioForm_Load_1;
            panelMain.ResumeLayout(false);
            groupBoxFormulario.ResumeLayout(false);
            groupBoxFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private GroupBox groupBoxFormulario;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private TextBox textBoxConfirmar;
        private Label labelConfirmar;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private ComboBox comboBoxRol;
        private Label labelRol;
        private TextBox textBoxUsuario;
        private Label labelUsuario;
        private TextBox textBoxNombre;
        private Label labelNombre;
    }
}
