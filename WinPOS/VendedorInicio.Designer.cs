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
            paneContenedorEmpleado = new Panel();
            ticketsToolStripMenuItem = new ToolStripMenuItem();
            menuVendedor.SuspendLayout();
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
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reimprimirTicketToolStripMenuItem, ticketsToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(66, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // reimprimirTicketToolStripMenuItem
            // 
            reimprimirTicketToolStripMenuItem.Name = "reimprimirTicketToolStripMenuItem";
            reimprimirTicketToolStripMenuItem.Size = new Size(224, 26);
            reimprimirTicketToolStripMenuItem.Text = "Venta";
            reimprimirTicketToolStripMenuItem.Click += reimprimirTicketToolStripMenuItem_Click;
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
            // paneContenedorEmpleado
            // 
            paneContenedorEmpleado.BackColor = SystemColors.ControlDark;
            paneContenedorEmpleado.Dock = DockStyle.Fill;
            paneContenedorEmpleado.Location = new Point(0, 28);
            paneContenedorEmpleado.Name = "paneContenedorEmpleado";
            paneContenedorEmpleado.Size = new Size(1182, 725);
            paneContenedorEmpleado.TabIndex = 1;
            // 
            // ticketsToolStripMenuItem
            // 
            ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            ticketsToolStripMenuItem.Size = new Size(224, 26);
            ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // VendedorInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            ControlBox = false;
            Controls.Add(paneContenedorEmpleado);
            Controls.Add(menuVendedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuVendedor;
            Name = "VendedorInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            menuVendedor.ResumeLayout(false);
            menuVendedor.PerformLayout();
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
        private Panel paneContenedorEmpleado;
        private ToolStripMenuItem ticketsToolStripMenuItem;
    }
}