using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPOS
{
    public partial class AdministradorInicio : Form
    {
        private int idUsuario;
        public AdministradorInicio(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FInciarSesion sesion = new FInciarSesion();
            sesion.Show();
            this.Close();
        }

        private void abrirFormDentroPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form form = formHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormDentroPanel(new Productos());
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormDentroPanel(new Usuarios());
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormDentroPanel(new VentaVista());
        }

        private void impresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormDentroPanel(new Impresora());
        }
    }
}
