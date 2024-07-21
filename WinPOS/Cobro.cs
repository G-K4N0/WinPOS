using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPOS
{
    public partial class Cobro : Form
    {
        private double totalPago;

        public Cobro(double total, DataTable datosTabla)
        {
            InitializeComponent();
            lblCobro.Text = "$ " + total.ToString();
            totalPago = total;
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            double pago;

            if (string.IsNullOrWhiteSpace(txtEfectivo.Text) || !double.TryParse(txtEfectivo.Text, out pago))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }

            if (pago < totalPago)
            {
                MessageBox.Show("El monto ingresado es insuficiente.");
                return;
            }

            this.Close();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            double pago;
            if (double.TryParse(txtEfectivo.Text, out pago))
            {
                pago = pago - totalPago;
                lblCambioResultado.Text = "$ " + pago.ToString("F2");
            }
            else
            {
                lblCambioResultado.Text = "$ 0.00";
            }
        }
    }
}
