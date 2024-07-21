namespace WinPOS
{
    partial class Impresora
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
            cmbImpresoras = new ComboBox();
            btnGuardarConf = new Button();
            SuspendLayout();
            // 
            // cmbImpresoras
            // 
            cmbImpresoras.FormattingEnabled = true;
            cmbImpresoras.Location = new Point(31, 52);
            cmbImpresoras.Name = "cmbImpresoras";
            cmbImpresoras.Size = new Size(269, 28);
            cmbImpresoras.TabIndex = 0;
            // 
            // btnGuardarConf
            // 
            btnGuardarConf.Location = new Point(99, 153);
            btnGuardarConf.Name = "btnGuardarConf";
            btnGuardarConf.Size = new Size(94, 29);
            btnGuardarConf.TabIndex = 1;
            btnGuardarConf.Text = "Guardar";
            btnGuardarConf.UseVisualStyleBackColor = true;
            btnGuardarConf.Click += btnGuardarConf_Click;
            // 
            // Impresora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 681);
            ControlBox = false;
            Controls.Add(btnGuardarConf);
            Controls.Add(cmbImpresoras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Impresora";
            Text = "Impresora";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbImpresoras;
        private Button btnGuardarConf;
    }
}