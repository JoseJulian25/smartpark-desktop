namespace SmartPark.UI.Espacios
{
    partial class EspacioForm
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
            groupBoxDatosEspacio = new GroupBox();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            comboBoxTipo = new ComboBox();
            textBoxCodigo = new TextBox();
            labelTipo = new Label();
            labelCodigo = new Label();
            panelMain.SuspendLayout();
            groupBoxDatosEspacio.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 252);
            panelMain.Controls.Add(groupBoxDatosEspacio);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(16);
            panelMain.Size = new Size(618, 382);
            panelMain.TabIndex = 0;
            // 
            // groupBoxDatosEspacio
            // 
            groupBoxDatosEspacio.Controls.Add(buttonCancelar);
            groupBoxDatosEspacio.Controls.Add(buttonGuardar);
            groupBoxDatosEspacio.Controls.Add(comboBoxTipo);
            groupBoxDatosEspacio.Controls.Add(textBoxCodigo);
            groupBoxDatosEspacio.Controls.Add(labelTipo);
            groupBoxDatosEspacio.Controls.Add(labelCodigo);
            groupBoxDatosEspacio.Dock = DockStyle.Fill;
            groupBoxDatosEspacio.Font = new Font("Segoe UI", 9F);
            groupBoxDatosEspacio.Location = new Point(16, 16);
            groupBoxDatosEspacio.Name = "groupBoxDatosEspacio";
            groupBoxDatosEspacio.Padding = new Padding(14);
            groupBoxDatosEspacio.Size = new Size(586, 350);
            groupBoxDatosEspacio.TabIndex = 0;
            groupBoxDatosEspacio.TabStop = false;
            groupBoxDatosEspacio.Text = "Espacio";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.Location = new Point(270, 297);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(110, 36);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(154, 297);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(110, 36);
            buttonGuardar.TabIndex = 8;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Carro", "Moto" });
            comboBoxTipo.Location = new Point(150, 94);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(180, 28);
            comboBoxTipo.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(150, 50);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(180, 27);
            textBoxCodigo.TabIndex = 1;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(18, 98);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(42, 20);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Tipo:";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(18, 54);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(61, 20);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código:";
            // 
            // EspacioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(618, 382);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(636, 429);
            Name = "EspacioForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SmartPark - Espacio";
            panelMain.ResumeLayout(false);
            groupBoxDatosEspacio.ResumeLayout(false);
            groupBoxDatosEspacio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private GroupBox groupBoxDatosEspacio;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private ComboBox comboBoxTipo;
        private TextBox textBoxCodigo;
        private Label labelTipo;
        private Label labelCodigo;
    }
}
