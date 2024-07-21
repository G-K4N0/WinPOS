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
    public partial class Impresora : Form
    {
        public Impresora()
        {
            InitializeComponent();
            cargarImpresoras();
        }

        private void cargarImpresoras()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmbImpresoras.Items.Add(printer);
            }

            if (cmbImpresoras.Items.Count > 0)
            {
                cmbImpresoras.SelectedIndex = 0;
            }
        }

        private void btnGuardarConf_Click(object sender, EventArgs e)
        {
            string selectedPrinter = cmbImpresoras.SelectedItem.ToString();

            // Guardar la impresora seleccionada en la configuración
            Properties.Settings.Default.SelectedPrinter = selectedPrinter;
            Properties.Settings.Default.Save();
        }
    }
}
