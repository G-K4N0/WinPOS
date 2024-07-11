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
    public partial class Cobro : Form
    {
        public Cobro()
        {
            InitializeComponent();
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {

            Ticket ticket = new Ticket();
            ticket.Show();
            this.Close();
        }
    }
}
