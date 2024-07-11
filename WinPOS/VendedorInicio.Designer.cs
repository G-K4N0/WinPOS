namespace WinPOS
{
    partial class VendedorInicio
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendedorInicio));
            menuVendedor = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            reimprimirTicketToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            cajaToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            paneVentas = new Panel();
            lblTotal = new Label();
            lblTotalVenta = new Label();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Mayoreo = new DataGridViewTextBoxColumn();
            Temporada = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Agregar = new DataGridViewButtonColumn();
            Quitar = new DataGridViewButtonColumn();
            tcpBotonesVenta = new TableLayoutPanel();
            btnImprimir = new Button();
            btnCobrar = new Button();
            txtBusqueda = new TextBox();
            menuVendedor.SuspendLayout();
            paneVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tcpBotonesVenta.SuspendLayout();
            SuspendLayout();
            // 
            // menuVendedor
            // 
            menuVendedor.ImageScalingSize = new Size(20, 20);
            menuVendedor.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, ventasToolStripMenuItem, clientesToolStripMenuItem, cajaToolStripMenuItem });
            menuVendedor.Location = new Point(0, 0);
            menuVendedor.Name = "menuVendedor";
            menuVendedor.Size = new Size(1182, 28);
            menuVendedor.TabIndex = 0;
            menuVendedor.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(179, 26);
            salirToolStripMenuItem.Text = "Cerrar Sesión";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reimprimirTicketToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(66, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // reimprimirTicketToolStripMenuItem
            // 
            reimprimirTicketToolStripMenuItem.Name = "reimprimirTicketToolStripMenuItem";
            reimprimirTicketToolStripMenuItem.Size = new Size(209, 26);
            reimprimirTicketToolStripMenuItem.Text = "Reimprimir Ticket";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(135, 26);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // cajaToolStripMenuItem
            // 
            cajaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem });
            cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            cajaToolStripMenuItem.Size = new Size(52, 24);
            cajaToolStripMenuItem.Text = "Caja";
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(132, 26);
            cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // paneVentas
            // 
            paneVentas.BackColor = SystemColors.ControlDark;
            paneVentas.Controls.Add(lblTotal);
            paneVentas.Controls.Add(lblTotalVenta);
            paneVentas.Controls.Add(dataGridView1);
            paneVentas.Controls.Add(tcpBotonesVenta);
            paneVentas.Dock = DockStyle.Fill;
            paneVentas.Location = new Point(0, 28);
            paneVentas.Name = "paneVentas";
            paneVentas.Size = new Size(1182, 725);
            paneVentas.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(906, 670);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 46);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "$";
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalVenta.AutoSize = true;
            lblTotalVenta.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVenta.Location = new Point(104, 670);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(99, 46);
            lblTotalVenta.TabIndex = 2;
            lblTotalVenta.Text = "Total";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Mayoreo, Temporada, Cantidad, Descripcion, Agregar, Quitar });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1158, 565);
            dataGridView1.TabIndex = 1;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // Mayoreo
            // 
            Mayoreo.HeaderText = "Mayoreo";
            Mayoreo.MinimumWidth = 6;
            Mayoreo.Name = "Mayoreo";
            // 
            // Temporada
            // 
            Temporada.HeaderText = "Temporada";
            Temporada.MinimumWidth = 6;
            Temporada.Name = "Temporada";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripión";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // Agregar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = Color.Lime;
            Agregar.DefaultCellStyle = dataGridViewCellStyle2;
            Agregar.HeaderText = "";
            Agregar.MinimumWidth = 6;
            Agregar.Name = "Agregar";
            Agregar.Text = "Agregar";
            // 
            // Quitar
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            Quitar.DefaultCellStyle = dataGridViewCellStyle3;
            Quitar.HeaderText = "";
            Quitar.MinimumWidth = 6;
            Quitar.Name = "Quitar";
            Quitar.Text = "Quitar";
            // 
            // tcpBotonesVenta
            // 
            tcpBotonesVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tcpBotonesVenta.ColumnCount = 3;
            tcpBotonesVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.66346F));
            tcpBotonesVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.33654F));
            tcpBotonesVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 278F));
            tcpBotonesVenta.Controls.Add(btnImprimir, 1, 0);
            tcpBotonesVenta.Controls.Add(btnCobrar, 2, 0);
            tcpBotonesVenta.Controls.Add(txtBusqueda, 0, 0);
            tcpBotonesVenta.Location = new Point(0, 0);
            tcpBotonesVenta.Name = "tcpBotonesVenta";
            tcpBotonesVenta.RowCount = 1;
            tcpBotonesVenta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tcpBotonesVenta.Size = new Size(1182, 70);
            tcpBotonesVenta.TabIndex = 0;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnImprimir.BackColor = Color.Yellow;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.Location = new Point(587, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(313, 59);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCobrar.BackColor = Color.Lime;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.Location = new Point(906, 3);
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
            txtBusqueda.Size = new Size(578, 51);
            txtBusqueda.TabIndex = 3;
            txtBusqueda.KeyPress += txtBusqueda_KeyPress;
            // 
            // VendedorInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            ControlBox = false;
            Controls.Add(paneVentas);
            Controls.Add(menuVendedor);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuVendedor;
            Name = "VendedorInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            menuVendedor.ResumeLayout(false);
            menuVendedor.PerformLayout();
            paneVentas.ResumeLayout(false);
            paneVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tcpBotonesVenta.ResumeLayout(false);
            tcpBotonesVenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuVendedor;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem reimprimirTicketToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem cajaToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Panel paneVentas;
        private TableLayoutPanel tcpBotonesVenta;
        private Button btnImprimir;
        private Button btnCobrar;
        private DataGridView dataGridView1;
        private Label lblTotal;
        private Label lblTotalVenta;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Mayoreo;
        private DataGridViewTextBoxColumn Temporada;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewButtonColumn Agregar;
        private DataGridViewButtonColumn Quitar;
        private TextBox txtBusqueda;
    }
}