namespace WinPOS
{
    partial class Categoria
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
            label1 = new Label();
            txtCategoria = new TextBox();
            label2 = new Label();
            btnGuardarCategoria = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(539, 118);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(235, 43);
            txtCategoria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(554, 81);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre de la categoria";
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarCategoria.Location = new Point(593, 371);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(152, 45);
            btnGuardarCategoria.TabIndex = 3;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = true;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(472, 357);
            dataGridView1.TabIndex = 4;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardarCategoria);
            Controls.Add(label2);
            Controls.Add(txtCategoria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoria;
        private Label label2;
        private Button btnGuardarCategoria;
        private DataGridView dataGridView1;
    }
}