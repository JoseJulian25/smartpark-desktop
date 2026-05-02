namespace SmartPark.UI.Configuracion
{
    partial class TarifaForm
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
            groupBoxTarifa = new GroupBox();
            labelTipo = new Label();
            comboBoxTipo = new ComboBox();
            labelPrecio = new Label();
            numericUpDownPrecio = new NumericUpDown();
            labelMinFraccion = new Label();
            numericUpDownMinutosFraccion = new NumericUpDown();
            labelMinimo = new Label();
            numericUpDownMinutosMinimo = new NumericUpDown();
            labelTolerancia = new Label();
            numericUpDownMinutosTolerancia = new NumericUpDown();
            panelFooter = new Panel();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            groupBoxTarifa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutosFraccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutosMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutosTolerancia).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTarifa
            // 
            groupBoxTarifa.Controls.Add(labelTipo);
            groupBoxTarifa.Controls.Add(comboBoxTipo);
            groupBoxTarifa.Controls.Add(labelPrecio);
            groupBoxTarifa.Controls.Add(numericUpDownPrecio);
            groupBoxTarifa.Controls.Add(labelMinFraccion);
            groupBoxTarifa.Controls.Add(numericUpDownMinutosFraccion);
            groupBoxTarifa.Controls.Add(labelMinimo);
            groupBoxTarifa.Controls.Add(numericUpDownMinutosMinimo);
            groupBoxTarifa.Controls.Add(labelTolerancia);
            groupBoxTarifa.Controls.Add(numericUpDownMinutosTolerancia);
            groupBoxTarifa.Dock = DockStyle.Top;
            groupBoxTarifa.Location = new Point(12, 12);
            groupBoxTarifa.Name = "groupBoxTarifa";
            groupBoxTarifa.Padding = new Padding(12);
            groupBoxTarifa.Size = new Size(560, 220);
            groupBoxTarifa.TabIndex = 0;
            groupBoxTarifa.TabStop = false;
            groupBoxTarifa.Text = "Tarifa";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(16, 32);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(120, 20);
            labelTipo.TabIndex = 0;
            labelTipo.Text = "Tipo de vehículo:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(160, 28);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(380, 28);
            comboBoxTipo.TabIndex = 1;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(16, 72);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(118, 20);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "Precio por fracción:";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.DecimalPlaces = 2;
            numericUpDownPrecio.Location = new Point(160, 70);
            numericUpDownPrecio.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(120, 27);
            numericUpDownPrecio.TabIndex = 3;
            // 
            // labelMinFraccion
            // 
            labelMinFraccion.AutoSize = true;
            labelMinFraccion.Location = new Point(16, 112);
            labelMinFraccion.Name = "labelMinFraccion";
            labelMinFraccion.Size = new Size(121, 20);
            labelMinFraccion.TabIndex = 4;
            labelMinFraccion.Text = "Minutos fracción:";
            // 
            // numericUpDownMinutosFraccion
            // 
            numericUpDownMinutosFraccion.Location = new Point(160, 110);
            numericUpDownMinutosFraccion.Maximum = new decimal(new int[] {1440, 0, 0, 0});
            numericUpDownMinutosFraccion.Name = "numericUpDownMinutosFraccion";
            numericUpDownMinutosFraccion.Size = new Size(120, 27);
            numericUpDownMinutosFraccion.TabIndex = 5;
            numericUpDownMinutosFraccion.Value = new decimal(new int[] {15, 0, 0, 0});
            // 
            // labelMinimo
            // 
            labelMinimo.AutoSize = true;
            labelMinimo.Location = new Point(16, 152);
            labelMinimo.Name = "labelMinimo";
            labelMinimo.Size = new Size(119, 20);
            labelMinimo.TabIndex = 6;
            labelMinimo.Text = "Minutos mínimo:";
            // 
            // numericUpDownMinutosMinimo
            // 
            numericUpDownMinutosMinimo.Location = new Point(160, 150);
            numericUpDownMinutosMinimo.Maximum = new decimal(new int[] {1440, 0, 0, 0});
            numericUpDownMinutosMinimo.Name = "numericUpDownMinutosMinimo";
            numericUpDownMinutosMinimo.Size = new Size(120, 27);
            numericUpDownMinutosMinimo.TabIndex = 7;
            numericUpDownMinutosMinimo.Value = new decimal(new int[] {15, 0, 0, 0});
            // 
            // labelTolerancia
            // 
            labelTolerancia.AutoSize = true;
            labelTolerancia.Location = new Point(300, 112);
            labelTolerancia.Name = "labelTolerancia";
            labelTolerancia.Size = new Size(144, 20);
            labelTolerancia.TabIndex = 8;
            labelTolerancia.Text = "Minutos tolerancia:";
            // 
            // numericUpDownMinutosTolerancia
            // 
            numericUpDownMinutosTolerancia.Location = new Point(450, 110);
            numericUpDownMinutosTolerancia.Maximum = new decimal(new int[] {1440, 0, 0, 0});
            numericUpDownMinutosTolerancia.Name = "numericUpDownMinutosTolerancia";
            numericUpDownMinutosTolerancia.Size = new Size(90, 27);
            numericUpDownMinutosTolerancia.TabIndex = 9;
            numericUpDownMinutosTolerancia.Value = new decimal(new int[] {15, 0, 0, 0});
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(buttonCancelar);
            panelFooter.Controls.Add(buttonGuardar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(12, 240);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(560, 56);
            panelFooter.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(436, 12);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(111, 32);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGuardar.Location = new Point(319, 12);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(111, 32);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // TarifaForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 308);
            Controls.Add(panelFooter);
            Controls.Add(groupBoxTarifa);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TarifaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar / Editar Tarifa";
            Load += TarifaForm_Load;
            groupBoxTarifa.ResumeLayout(false);
            groupBoxTarifa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutosFraccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutosMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutosTolerancia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTarifa;
        private Label labelTipo;
        private ComboBox comboBoxTipo;
        private Label labelPrecio;
        private NumericUpDown numericUpDownPrecio;
        private Label labelMinFraccion;
        private NumericUpDown numericUpDownMinutosFraccion;
        private Label labelMinimo;
        private NumericUpDown numericUpDownMinutosMinimo;
        private Label labelTolerancia;
        private NumericUpDown numericUpDownMinutosTolerancia;
        private Panel panelFooter;
        private Button buttonCancelar;
        private Button buttonGuardar;
    }
}
