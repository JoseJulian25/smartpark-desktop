namespace SmartPark.UI.Acceso
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelRoot;
        private Panel panelLeft;
        private Panel panelRight;
        private PictureBox pictureBoxLogo;
        private Label labelApp;
        private Label labelSubtitle;
        private Label labelTitle;
        private Label labelUsuario;
        private TextBox textBoxUsuario;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonIniciar;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelRoot = new Panel();
            panelRight = new Panel();
            buttonIniciar = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsuario = new TextBox();
            labelUsuario = new Label();
            labelTitle = new Label();
            panelLeft = new Panel();
            labelSubtitle = new Label();
            labelApp = new Label();
            pictureBoxLogo = new PictureBox();
            panelRoot.SuspendLayout();
            panelRight.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelRoot
            // 
            panelRoot.BackColor = Color.FromArgb(236, 241, 247);
            panelRoot.Controls.Add(panelRight);
            panelRoot.Controls.Add(panelLeft);
            panelRoot.Dock = DockStyle.Fill;
            panelRoot.Location = new Point(0, 0);
            panelRoot.Name = "panelRoot";
            panelRoot.Size = new Size(807, 425);
            panelRoot.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(buttonIniciar);
            panelRight.Controls.Add(textBoxPassword);
            panelRight.Controls.Add(labelPassword);
            panelRight.Controls.Add(textBoxUsuario);
            panelRight.Controls.Add(labelUsuario);
            panelRight.Controls.Add(labelTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(343, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(46, 48, 46, 40);
            panelRight.Size = new Size(464, 425);
            panelRight.TabIndex = 1;
            // 
            // buttonIniciar
            // 
            buttonIniciar.BackColor = Color.FromArgb(40, 66, 104);
            buttonIniciar.FlatAppearance.BorderColor = Color.FromArgb(40, 66, 104);
            buttonIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 52, 86);
            buttonIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 81, 123);
            buttonIniciar.FlatStyle = FlatStyle.Flat;
            buttonIniciar.ForeColor = Color.White;
            buttonIniciar.Location = new Point(148, 332);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(171, 40);
            buttonIniciar.TabIndex = 5;
            buttonIniciar.Text = "Acceder";
            buttonIniciar.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(46, 252);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(365, 27);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = Color.FromArgb(40, 66, 104);
            labelPassword.Location = new Point(46, 224);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(45, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Clave";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(46, 172);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(365, 27);
            textBoxUsuario.TabIndex = 2;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.ForeColor = Color.FromArgb(40, 66, 104);
            labelUsuario.Location = new Point(46, 144);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 20);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(40, 66, 104);
            labelTitle.Location = new Point(46, 72);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(184, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Iniciar sesion";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(40, 66, 104);
            panelLeft.Controls.Add(labelSubtitle);
            panelLeft.Controls.Add(labelApp);
            panelLeft.Controls.Add(pictureBoxLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(27, 24, 27, 24);
            panelLeft.Size = new Size(343, 425);
            panelLeft.TabIndex = 0;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.ForeColor = Color.FromArgb(208, 222, 236);
            labelSubtitle.Location = new Point(85, 332);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(126, 20);
            labelSubtitle.TabIndex = 2;
            labelSubtitle.Text = "Acceso al sistema";
            // 
            // labelApp
            // 
            labelApp.AutoSize = true;
            labelApp.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelApp.ForeColor = Color.White;
            labelApp.Location = new Point(80, 290);
            labelApp.Name = "labelApp";
            labelApp.Size = new Size(165, 41);
            labelApp.TabIndex = 1;
            labelApp.Text = "SmartPark";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(54, 90);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(229, 180);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 425);
            Controls.Add(panelRoot);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartPark - Inicio de sesion";
            Load += LoginForm_Load;
            panelRoot.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
