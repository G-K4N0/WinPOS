namespace WinPOS
{
    partial class AdministradorInicio
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
            menuAdmin = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            gruposToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            ticketToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            impresoraToolStripMenuItem = new ToolStripMenuItem();
            menuAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // menuAdmin
            // 
            menuAdmin.ImageScalingSize = new Size(20, 20);
            menuAdmin.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, productosToolStripMenuItem, usuariosToolStripMenuItem, comprasToolStripMenuItem, clientesToolStripMenuItem, empleadosToolStripMenuItem, reportesToolStripMenuItem, impresoraToolStripMenuItem });
            menuAdmin.Location = new Point(0, 0);
            menuAdmin.Name = "menuAdmin";
            menuAdmin.RenderMode = ToolStripRenderMode.Professional;
            menuAdmin.Size = new Size(1182, 28);
            menuAdmin.TabIndex = 0;
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
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, gruposToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(89, 24);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(158, 26);
            agregarToolStripMenuItem.Text = "Productos";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(158, 26);
            gruposToolStripMenuItem.Text = "Categoria";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventaToolStripMenuItem, ticketToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(66, 24);
            usuariosToolStripMenuItem.Text = "Ventas";
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(131, 26);
            ventaToolStripMenuItem.Text = "Venta";
            ventaToolStripMenuItem.Click += ventaToolStripMenuItem_Click;
            // 
            // ticketToolStripMenuItem
            // 
            ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            ticketToolStripMenuItem.Size = new Size(131, 26);
            ticketToolStripMenuItem.Text = "Ticket";
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(82, 24);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(97, 24);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(12, 42);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1158, 681);
            panelContenedor.TabIndex = 1;
            // 
            // impresoraToolStripMenuItem
            // 
            impresoraToolStripMenuItem.Name = "impresoraToolStripMenuItem";
            impresoraToolStripMenuItem.Size = new Size(90, 24);
            impresoraToolStripMenuItem.Text = "Impresora";
            impresoraToolStripMenuItem.Click += impresoraToolStripMenuItem_Click;
            // 
            // AdministradorInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            ControlBox = false;
            Controls.Add(panelContenedor);
            Controls.Add(menuAdmin);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuAdmin;
            Name = "AdministradorInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            menuAdmin.ResumeLayout(false);
            menuAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuAdmin;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Panel panelContenedor;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem ticketToolStripMenuItem;
        private ToolStripMenuItem impresoraToolStripMenuItem;
    }
}