namespace WinPOS
{
    partial class Productos
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
            dtProductosLista = new DataGridView();
            txtCodigoProducto = new TextBox();
            txtNombreProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrecioUnitario = new TextBox();
            label4 = new Label();
            txtPrecioMayoreo = new TextBox();
            label5 = new Label();
            txtPrecioTemporada = new TextBox();
            cbCategoria = new ComboBox();
            label1 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtDescripcion = new TextBox();
            btnGuardarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dtProductosLista).BeginInit();
            SuspendLayout();
            // 
            // dtProductosLista
            // 
            dtProductosLista.AllowUserToOrderColumns = true;
            dtProductosLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtProductosLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtProductosLista.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtProductosLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtProductosLista.Location = new Point(12, 180);
            dtProductosLista.Name = "dtProductosLista";
            dtProductosLista.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dtProductosLista.ScrollBars = ScrollBars.None;
            dtProductosLista.Size = new Size(1134, 458);
            dtProductosLista.TabIndex = 0;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Font = new Font("Segoe UI", 12F);
            txtCodigoProducto.Location = new Point(38, 40);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(239, 34);
            txtCodigoProducto.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 12F);
            txtNombreProducto.Location = new Point(319, 40);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(239, 34);
            txtNombreProducto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(332, 9);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 4;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(593, 9);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 5;
            label3.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 12F);
            txtPrecioUnitario.Location = new Point(593, 40);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(239, 34);
            txtPrecioUnitario.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(870, 9);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 7;
            label4.Text = "Precion Mayoreo";
            // 
            // txtPrecioMayoreo
            // 
            txtPrecioMayoreo.Font = new Font("Segoe UI", 12F);
            txtPrecioMayoreo.Location = new Point(870, 40);
            txtPrecioMayoreo.Name = "txtPrecioMayoreo";
            txtPrecioMayoreo.Size = new Size(239, 34);
            txtPrecioMayoreo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(38, 88);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 9;
            label5.Text = "Precio Temporada";
            // 
            // txtPrecioTemporada
            // 
            txtPrecioTemporada.Font = new Font("Segoe UI", 12F);
            txtPrecioTemporada.Location = new Point(38, 119);
            txtPrecioTemporada.Name = "txtPrecioTemporada";
            txtPrecioTemporada.Size = new Size(239, 34);
            txtPrecioTemporada.TabIndex = 10;
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Segoe UI", 12F);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(319, 117);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(237, 36);
            cbCategoria.TabIndex = 11;
            cbCategoria.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 13;
            label1.Text = "Codigo";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.Location = new Point(593, 119);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(237, 34);
            txtStock.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(593, 88);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 15;
            label6.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(870, 88);
            label7.Name = "label7";
            label7.Size = new Size(114, 28);
            label7.TabIndex = 16;
            label7.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(872, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(237, 34);
            txtDescripcion.TabIndex = 17;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.Location = new Point(481, 648);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(239, 50);
            btnGuardarProducto.TabIndex = 19;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1158, 710);
            ControlBox = false;
            Controls.Add(btnGuardarProducto);
            Controls.Add(txtDescripcion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(cbCategoria);
            Controls.Add(txtPrecioTemporada);
            Controls.Add(label5);
            Controls.Add(txtPrecioMayoreo);
            Controls.Add(label4);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCodigoProducto);
            Controls.Add(dtProductosLista);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dtProductosLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtProductosLista;
        private TextBox txtCodigoProducto;
        private TextBox txtNombreProducto;
        private Label label2;
        private Label label3;
        private TextBox txtPrecioUnitario;
        private Label label4;
        private TextBox txtPrecioMayoreo;
        private Label label5;
        private TextBox txtPrecioTemporada;
        private ComboBox cbCategoria;
        private Label label1;
        private TextBox txtStock;
        private Label label6;
        private Label label7;
        private TextBox txtDescripcion;
        private Button btnGuardarProducto;
    }
}