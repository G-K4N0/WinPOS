namespace WinPOS
{
    partial class Cobro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCobro = new Label();
            lblPago = new Label();
            txtEfectivo = new TextBox();
            btnCambio = new Button();
            lblCambio = new Label();
            lblCambioResultado = new Label();
            SuspendLayout();
            // 
            // lblCobro
            // 
            lblCobro.AutoSize = true;
            lblCobro.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCobro.Location = new Point(330, 38);
            lblCobro.Name = "lblCobro";
            lblCobro.Size = new Size(172, 54);
            lblCobro.TabIndex = 0;
            lblCobro.Text = "$000.00";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPago.Location = new Point(81, 112);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(118, 54);
            lblPago.TabIndex = 1;
            lblPago.Text = "Pago";
            // 
            // txtEfectivo
            // 
            txtEfectivo.BorderStyle = BorderStyle.None;
            txtEfectivo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEfectivo.Location = new Point(269, 122);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.PlaceholderText = "Ingresa el Efectivo";
            txtEfectivo.Size = new Size(384, 44);
            txtEfectivo.TabIndex = 2;
            txtEfectivo.TextAlign = HorizontalAlignment.Center;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // btnCambio
            // 
            btnCambio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambio.Location = new Point(329, 336);
            btnCambio.Name = "btnCambio";
            btnCambio.Size = new Size(187, 45);
            btnCambio.TabIndex = 3;
            btnCambio.Text = "Finalizar";
            btnCambio.UseVisualStyleBackColor = true;
            btnCambio.Click += btnCambio_Click;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCambio.Location = new Point(81, 214);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(167, 54);
            lblCambio.TabIndex = 4;
            lblCambio.Text = "Cambio";
            // 
            // lblCambioResultado
            // 
            lblCambioResultado.AutoSize = true;
            lblCambioResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCambioResultado.Location = new Point(329, 214);
            lblCambioResultado.Name = "lblCambioResultado";
            lblCambioResultado.Size = new Size(46, 54);
            lblCambioResultado.TabIndex = 5;
            lblCambioResultado.Text = "$";
            // 
            // Cobro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCambioResultado);
            Controls.Add(lblCambio);
            Controls.Add(btnCambio);
            Controls.Add(txtEfectivo);
            Controls.Add(lblPago);
            Controls.Add(lblCobro);
            Name = "Cobro";
            Text = "Cobro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCobro;
        private Label lblPago;
        private TextBox txtEfectivo;
        private Button btnCambio;
        private Label lblCambio;
        private Label lblCambioResultado;
    }
}