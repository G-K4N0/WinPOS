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
using Entidad;
namespace WinPOS
{
    public partial class Productos : Form
    {
        private Consultas consultas;
        public Productos()
        {
            InitializeComponent();
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            consultas = new Consultas();
            txtPrecioUnitario.KeyPress += new KeyPressEventHandler(txtSoloNumeros_y_punto_KeyPress);
            txtPrecioMayoreo.KeyPress += new KeyPressEventHandler(txtSoloNumeros_y_punto_KeyPress);
            txtPrecioTemporada.KeyPress += new KeyPressEventHandler(txtSoloNumeros_y_punto_KeyPress);
            txtStock.KeyPress += new KeyPressEventHandler(txtSoloNumeros_KeyPress);
            dataOnTable();
        }
        #region validar campos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioMayoreo.Text) ||
                cbCategoria.SelectedIndex == -1 || // Verificar que se haya seleccionado una categoría
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El nombre del Producto, Precio Unitario, Mayoreo, stock y descripcion son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                double precioUnitario = Double.Parse(txtPrecioUnitario.Text);
                double precioMayoreo = Double.Parse(txtPrecioMayoreo.Text);
                double precioTemporada = Double.Parse(txtPrecioTemporada.Text);
                int stockProducto = int.Parse(txtStock.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique los valores numéricos ingresados.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion
        #region solo numeros y punto decimal
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        private void txtSoloNumeros_y_punto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {

            }
            else if (e.KeyChar == '.')
            {
                // Permitir punto decimal solo si no está presente en el TextBox
                TextBox textBox = sender as TextBox;
                if (textBox.Text.Contains('.'))
                {
                    e.Handled = true; // Ya hay un punto decimal
                }
                else
                {
                    // Permitir entrada del punto decimal
                }
            }
            else
            {
                e.Handled = true; // Bloquear cualquier otro carácter
            }
        }
        #endregion
        #region llenado de combobox
        private void Productos_Load(object sender, EventArgs e)
        {
            List<Entidad.Categoria> categorias = consultas.getCategorias();
            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Categorias";
            cbCategoria.ValueMember = "Id";
        }
        #endregion

        #region Guardar productos
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string codigoProducto = txtCodigoProducto.Text;
                string nombreProducto = txtNombreProducto.Text;
                double precioUnitario = Double.Parse(txtPrecioUnitario.Text);
                double precioMayoreo = Double.Parse(txtPrecioMayoreo.Text);
                double precioTemporada = Double.Parse(txtPrecioTemporada.Text);
                int idCategoria = (int)cbCategoria.SelectedIndex + 1 ;
                int stockProducto = int.Parse(txtStock.Text);
                string descripcionProducto = txtDescripcion.Text;
                
              bool seAgrego =  consultas.guardarProductos(codigoProducto,nombreProducto,precioUnitario,precioMayoreo,
                    precioTemporada,idCategoria,stockProducto,descripcionProducto);

                if (!seAgrego)
                {
                    MessageBox.Show("No se pudo completar la operación, verifica los datos ingresados");
                } else
                {
                    MessageBox.Show("El producto " + nombreProducto + "ha sido ingresado con èxito", "Completado");
                }
            }
        }
        #endregion
        #region lista de productos
        private void cargarProductos()
        {
            Controlador.Consultas consultas = new Controlador.Consultas();

            foreach (var item in consultas.getProductos())
            {
                MessageBox.Show(item.Nombre);
            }
        }
        #endregion

        #region Listado de Productos
        private void dataOnTable()
        {
            Controlador.Consultas consultas = new Controlador.Consultas();

            DataTable productosData = consultas.getProductosData();
            if (dtProductosLista != null)
            {
                dtProductosLista.DataSource = productosData;

                //dtProductosLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtProductosLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dtProductosLista.Columns["id"].HeaderText = "ID";
                dtProductosLista.Columns["codigo"].HeaderText = "Código";
                dtProductosLista.Columns["nombre"].HeaderText = "Producto";
                dtProductosLista.Columns["descripcion"].HeaderText = "Descripción";
                dtProductosLista.Columns["categoria"].HeaderText = "Categoría";
                dtProductosLista.Columns["precioUnitario"].HeaderText = "Precio Unitario";
                dtProductosLista.Columns["precioMayoreo"].HeaderText = "Precio Mayoreo";
                dtProductosLista.Columns["precioTemporada"].HeaderText = "Precio Temporada";
                dtProductosLista.Columns["stock"].HeaderText = "Stock";


                foreach (DataGridViewColumn column in dtProductosLista.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dtProductosLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dtProductosLista.RowsDefaultCellStyle.BackColor = Color.White;
                dtProductosLista.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                MessageBox.Show("Error: dtProductosLista no está inicializado.");
            }
        }
        #endregion
    }
}
