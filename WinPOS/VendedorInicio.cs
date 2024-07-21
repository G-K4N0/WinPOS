using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace WinPOS
{
    public partial class VendedorInicio : Form
    {
        private int idUsuario;
        public VendedorInicio(int id)
        {
            InitializeComponent();
            this.idUsuario = id;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FInciarSesion sesion = new FInciarSesion();
            sesion.Show();
            this.Close();
        }

        private void abrirFormDentroPanel(object formHijo)
        {
            if (this.paneContenedorEmpleado.Controls.Count > 0)
                this.paneContenedorEmpleado.Controls.RemoveAt(0);

            Form form = formHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.paneContenedorEmpleado.Controls.Add(form);
            this.paneContenedorEmpleado.Tag = form;
            form.Show();
        }

        private void reimprimirTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormDentroPanel(new VentaVista());
        }
    }
}
