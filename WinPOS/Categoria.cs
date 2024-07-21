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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permite que el formulario capture las teclas
            this.KeyDown += new KeyEventHandler(FCategoria_KeyDown);
        }
        private void FCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            string categoria = txtCategoria.Text;

            if (!categoria.Equals(""))
            {
                bool seAgrego = consultas.agregarCategoria(categoria);
                if (seAgrego)
                {
                    MessageBox.Show("Categoria " + categoria + "  agregado con éxito");
                } else
                {
                    MessageBox.Show("La Categoria " + categoria + "  ya existe");
                }
                txtCategoria.Clear();
            }else {
                MessageBox.Show("Es necesario agregar una categoria");
            }
        }
    }
}
