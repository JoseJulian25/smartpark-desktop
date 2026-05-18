namespace SmartPark.UI.Reservas
{
    partial class CancelarReservaForm
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
            labelMotivo = new Label();
            comboBoxMotivo = new ComboBox();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // labelMotivo
            // 
            labelMotivo.AutoSize = true;
            labelMotivo.Location = new Point(16, 20);
            labelMotivo.Name = "labelMotivo";
            labelMotivo.Size = new Size(164, 20);
            labelMotivo.TabIndex = 0;
            labelMotivo.Text = "Motivo de cancelacion";
            // 
            // comboBoxMotivo
            // 
            comboBoxMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotivo.FormattingEnabled = true;
            comboBoxMotivo.Items.AddRange(new object[] { "Cliente no se presento", "Cliente solicito cancelacion", "Cambio de horario", "Error de datos", "Otro" });
            comboBoxMotivo.Location = new Point(16, 45);
            comboBoxMotivo.Name = "comboBoxMotivo";
            comboBoxMotivo.Size = new Size(360, 28);
            comboBoxMotivo.TabIndex = 1;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.FromArgb(31, 118, 221);
            buttonAceptar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 94, 180);
            buttonAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 131, 232);
            buttonAceptar.FlatStyle = FlatStyle.Flat;
            buttonAceptar.ForeColor = Color.White;
            buttonAceptar.Location = new Point(184, 90);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(90, 32);
            buttonAceptar.TabIndex = 2;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = false;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.White;
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 237, 255);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 246, 255);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.FromArgb(31, 118, 221);
            buttonCancelar.Location = new Point(286, 90);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(90, 32);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // CancelarReservaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 140);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAceptar);
            Controls.Add(comboBoxMotivo);
            Controls.Add(labelMotivo);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CancelarReservaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cancelar reserva";
            AcceptButton = buttonAceptar;
            CancelButton = buttonCancelar;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMotivo;
        private ComboBox comboBoxMotivo;
        private Button buttonAceptar;
        private Button buttonCancelar;
    }
}
