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
        public VendedorInicio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FBusqueda busqueda = new FBusqueda();
            busqueda.Show();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Cobro cobro = new Cobro();
            cobro.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string codigo = txtBusqueda.Text;
                Consultas consultas = new Consultas();
                consultas.productoVenta(codigo);
            }
        }
    }
}
