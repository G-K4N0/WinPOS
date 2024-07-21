namespace WinPOS
{
    partial class VentaVista
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTotal = new Label();
            lblTotalVenta = new Label();
            datosInicioVentas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            PrecioMayoreo = new DataGridViewTextBoxColumn();
            PrecioTemporada = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            Agregar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            tcpBotonesVenta = new TableLayoutPanel();
            btnBuscar = new Button();
            btnCobrar = new Button();
            txtBusqueda = new TextBox();
            rbNormal = new RadioButton();
            rbMayoreo = new RadioButton();
            gbModoCobro = new GroupBox();
            rbTemporada = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)datosInicioVentas).BeginInit();
            tcpBotonesVenta.SuspendLayout();
            gbModoCobro.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(905, 618);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 46);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "$";
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalVenta.AutoSize = true;
            lblTotalVenta.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVenta.Location = new Point(698, 618);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(99, 46);
            lblTotalVenta.TabIndex = 6;
            lblTotalVenta.Text = "Total";
            // 
            // datosInicioVentas
            // 
            datosInicioVentas.AllowUserToAddRows = false;
            datosInicioVentas.AllowUserToDeleteRows = false;
            datosInicioVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datosInicioVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datosInicioVentas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datosInicioVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datosInicioVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosInicioVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Descripcion, Categoria, PrecioUnitario, PrecioMayoreo, PrecioTemporada, Cantidad, subTotal, Agregar, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datosInicioVentas.DefaultCellStyle = dataGridViewCellStyle3;
            datosInicioVentas.Location = new Point(12, 90);
            datosInicioVentas.Name = "datosInicioVentas";
            datosInicioVentas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            datosInicioVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            datosInicioVentas.RowHeadersWidth = 51;
            datosInicioVentas.Size = new Size(1158, 508);
            datosInicioVentas.TabIndex = 5;
            datosInicioVentas.CellClick += datosInicioVentas_CellClick_1;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            // 
            // PrecioMayoreo
            // 
            PrecioMayoreo.HeaderText = "Mayoreo";
            PrecioMayoreo.MinimumWidth = 6;
            PrecioMayoreo.Name = "PrecioMayoreo";
            PrecioMayoreo.ReadOnly = true;
            // 
            // PrecioTemporada
            // 
            PrecioTemporada.HeaderText = "Temporada";
            PrecioTemporada.MinimumWidth = 6;
            PrecioTemporada.Name = "PrecioTemporada";
            PrecioTemporada.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "SubTotal";
            subTotal.MinimumWidth = 6;
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            // 
            // Agregar
            // 
            Agregar.HeaderText = "Agregar";
            Agregar.MinimumWidth = 6;
            Agregar.Name = "Agregar";
            Agregar.ReadOnly = true;
            Agregar.Text = "Aumentar";
            Agregar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // tcpBotonesVenta
            // 
            tcpBotonesVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tcpBotonesVenta.ColumnCount = 3;
            tcpBotonesVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.66346F));
            tcpBotonesVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.33654F));
            tcpBotonesVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 278F));
            tcpBotonesVenta.Controls.Add(btnBuscar, 1, 0);
            tcpBotonesVenta.Controls.Add(btnCobrar, 2, 0);
            tcpBotonesVenta.Controls.Add(txtBusqueda, 0, 0);
            tcpBotonesVenta.Location = new Point(12, 12);
            tcpBotonesVenta.Name = "tcpBotonesVenta";
            tcpBotonesVenta.RowCount = 1;
            tcpBotonesVenta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tcpBotonesVenta.Size = new Size(1158, 70);
            tcpBotonesVenta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscar.BackColor = Color.Yellow;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(572, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(304, 59);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCobrar.BackColor = Color.Lime;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.Location = new Point(882, 3);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(273, 59);
            btnCobrar.TabIndex = 2;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(3, 3);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(563, 51);
            txtBusqueda.TabIndex = 3;
            txtBusqueda.KeyPress += txtBusqueda_KeyPress_1;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Checked = true;
            rbNormal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            rbNormal.Location = new Point(6, 19);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(116, 35);
            rbNormal.TabIndex = 8;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbMayoreo
            // 
            rbMayoreo.AutoSize = true;
            rbMayoreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            rbMayoreo.Location = new Point(166, 19);
            rbMayoreo.Name = "rbMayoreo";
            rbMayoreo.Size = new Size(130, 35);
            rbMayoreo.TabIndex = 9;
            rbMayoreo.TabStop = true;
            rbMayoreo.Text = "Mayoreo";
            rbMayoreo.UseVisualStyleBackColor = true;
            // 
            // gbModoCobro
            // 
            gbModoCobro.Controls.Add(rbTemporada);
            gbModoCobro.Controls.Add(rbNormal);
            gbModoCobro.Controls.Add(rbMayoreo);
            gbModoCobro.Location = new Point(12, 631);
            gbModoCobro.Name = "gbModoCobro";
            gbModoCobro.Size = new Size(491, 62);
            gbModoCobro.TabIndex = 10;
            gbModoCobro.TabStop = false;
            gbModoCobro.Text = "Modo de Cobro";
            // 
            // rbTemporada
            // 
            rbTemporada.AutoSize = true;
            rbTemporada.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbTemporada.Location = new Point(331, 19);
            rbTemporada.Name = "rbTemporada";
            rbTemporada.Size = new Size(154, 35);
            rbTemporada.TabIndex = 10;
            rbTemporada.TabStop = true;
            rbTemporada.Text = "Temporada";
            rbTemporada.UseVisualStyleBackColor = true;
            // 
            // VentaVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 712);
            Controls.Add(gbModoCobro);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalVenta);
            Controls.Add(datosInicioVentas);
            Controls.Add(tcpBotonesVenta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaVista";
            Text = "VentaVista";
            ((System.ComponentModel.ISupportInitialize)datosInicioVentas).EndInit();
            tcpBotonesVenta.ResumeLayout(false);
            tcpBotonesVenta.PerformLayout();
            gbModoCobro.ResumeLayout(false);
            gbModoCobro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblTotalVenta;
        private DataGridView datosInicioVentas;
        private TableLayoutPanel tcpBotonesVenta;
        private Button btnBuscar;
        private Button btnCobrar;
        private TextBox txtBusqueda;
        private RadioButton rbNormal;
        private RadioButton rbMayoreo;
        private GroupBox gbModoCobro;
        private RadioButton rbTemporada;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn PrecioMayoreo;
        private DataGridViewTextBoxColumn PrecioTemporada;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewButtonColumn Agregar;
        private DataGridViewButtonColumn Eliminar;
    }
}