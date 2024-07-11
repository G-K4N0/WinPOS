namespace WinPOS
{
    partial class FInciarSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInciarSesion));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnInciarSesion = new Button();
            pbLogo = new PictureBox();
            lblNameService = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BackColor = SystemColors.ScrollBar;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(196, 311);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Usuario";
            txtUserName.Size = new Size(273, 31);
            txtUserName.TabIndex = 0;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(196, 363);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(273, 31);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnInciarSesion
            // 
            btnInciarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInciarSesion.BackColor = Color.Lime;
            btnInciarSesion.Cursor = Cursors.Hand;
            btnInciarSesion.FlatAppearance.BorderSize = 0;
            btnInciarSesion.Location = new Point(391, 420);
            btnInciarSesion.Name = "btnInciarSesion";
            btnInciarSesion.Size = new Size(177, 47);
            btnInciarSesion.TabIndex = 2;
            btnInciarSesion.Text = "Iniciar";
            btnInciarSesion.UseVisualStyleBackColor = false;
            btnInciarSesion.Click += btnInciarSesion_Click;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(185, 5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(294, 285);
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // lblNameService
            // 
            lblNameService.Anchor = AnchorStyles.None;
            lblNameService.AutoSize = true;
            lblNameService.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameService.Location = new Point(242, -159);
            lblNameService.Name = "lblNameService";
            lblNameService.Size = new Size(209, 41);
            lblNameService.TabIndex = 4;
            lblNameService.Text = "Bienvenido a...";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(122, 420);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(177, 47);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FInciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 548);
            ControlBox = false;
            Controls.Add(btnCerrar);
            Controls.Add(lblNameService);
            Controls.Add(pbLogo);
            Controls.Add(btnInciarSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(690, 595);
            MinimumSize = new Size(690, 595);
            Name = "FInciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnInciarSesion;
        private PictureBox pbLogo;
        private Label lblNameService;
        private Button btnCerrar;
    }
}
