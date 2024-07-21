using Controlador;
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
using System.Drawing.Printing;

namespace WinPOS
{
    public partial class VentaVista : Form
    {
        private Consultas consultas;
        private double precioTotal;
        public VentaVista()
        {
            InitializeComponent();
            consultas = new Consultas();
            txtBusqueda.KeyPress += new KeyPressEventHandler(txtSoloNumeros_KeyPress);
            rbNormal.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbMayoreo.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbTemporada.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (datosInicioVentas.Rows.Count > 0)
            {
                btnCobrar.Enabled = false;

                Cobro cobro = new Cobro(precioTotal, GetDataTableFromDataGridView());

                cobro.FormClosed += (s, args) =>
                {
                    btnCobrar.Enabled = true;
                    imprimir(); 
                };

                cobro.Show();
            }
            else
            {
                MessageBox.Show("No hay articulos para procesar el cobro");
            }
        }

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
        #region Busqueda por codigo
        private void txtBusqueda_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string codigo = txtBusqueda.Text;
                Entidad.Productos producto = consultas.busquedaProducto(codigo);

                if (producto != null)
                {
                    bool productoEncontrado = false;

                    foreach (DataGridViewRow row in datosInicioVentas.Rows)
                    {
                        if (row.Cells["Codigo"].Value != null && row.Cells["Codigo"].Value.ToString() == codigo)
                        {
                            int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            row.Cells["Cantidad"].Value = cantidadActual + 1;
                            row.Cells["subTotal"].Value = (cantidadActual + 1) * Convert.ToDouble(row.Cells[tipoDescuento()].Value);
                            productoEncontrado = true;
                            break;
                        }
                    }

                    if (!productoEncontrado)
                    {

                        datosInicioVentas.Rows.Add(
                            producto.Codigo,
                            producto.Nombre,
                            producto.Descripcion,
                            producto.Categoria,
                            producto.PrecioUnitario,
                            producto.PrecioMayoreo,
                            producto.PrecioTemporada,
                            1, //cantidad
                            producto.PrecioUnitario,
                            "Aumentar",
                            "Eliminar"
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            total();
            datosInicioVentas.RowsDefaultCellStyle.BackColor = Color.SkyBlue;
            datosInicioVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }
        #endregion
        #region Aumento y decremento de cantidad de articulo
        private void datosInicioVentas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == datosInicioVentas.Columns["Agregar"].Index)
                {
                    int cantidadActual = Convert.ToInt32(datosInicioVentas.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    datosInicioVentas.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidadActual + 1;
                    datosInicioVentas.Rows[e.RowIndex].Cells["subTotal"].Value = (cantidadActual + 1) * Convert.ToDouble(datosInicioVentas.Rows[e.RowIndex].Cells[tipoDescuento()].Value);
                    total();
                }
                else if (e.ColumnIndex == datosInicioVentas.Columns["Eliminar"].Index)
                {
                    int cantidadActual = Convert.ToInt32(datosInicioVentas.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    if (cantidadActual > 1)
                    {
                        datosInicioVentas.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidadActual - 1;
                        datosInicioVentas.Rows[e.RowIndex].Cells["subTotal"].Value = (cantidadActual - 1) * Convert.ToDouble(datosInicioVentas.Rows[e.RowIndex].Cells[tipoDescuento()].Value);
                        total();
                    }
                    else
                    {
                        datosInicioVentas.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
        #endregion

        #region radioButtons
        private string tipoDescuento()
        {
            string descuento = string.Empty;

            if (rbNormal.Checked)
            {
                descuento = "precioUnitario";
            }
            if (rbMayoreo.Checked)
            {
                descuento = "precioMayoreo";
            }
            if (rbTemporada.Checked)
            {
                descuento = "precioTemporada";
            }
            return descuento;
        }
        #endregion

        #region Actualizar Precios
        private void ActualizarPrecios()
        {
            foreach (DataGridViewRow row in datosInicioVentas.Rows)
            {
                if (row.Cells["Cantidad"].Value != null && row.Cells["Cantidad"].Value.ToString() != string.Empty)
                {
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    double precio = Convert.ToDouble(row.Cells[tipoDescuento()].Value);
                    row.Cells["subTotal"].Value = cantidad * precio;
                }
            }
        }

        #endregion

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ActualizarPrecios();
                total();
            }
        }

        #region Total
        private void total()
        {
            precioTotal = 0;
            foreach (DataGridViewRow row in datosInicioVentas.Rows)
            {
                if (row.Cells["SubTotal"].Value != null && row.Cells["SubTotal"].Value.ToString() != string.Empty)
                {
                    Double precio = Convert.ToDouble(row.Cells["Subtotal"].Value);
                    precioTotal += precio;
                }
            }
            lblTotal.Text = "$ " + precioTotal.ToString("F2");
        }
        #endregion

        #region pasar datatable
        private DataTable GetDataTableFromDataGridView()
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in datosInicioVentas.Columns)
            {
                Type columnType = column.ValueType ?? typeof(string);
                dt.Columns.Add(column.HeaderText, columnType);
            }
            foreach (DataGridViewRow row in datosInicioVentas.Rows)
            {
                if (row.IsNewRow) continue;
                DataRow dataRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        #endregion

        #region Imprimir

        private void PrintTicketPreview()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0f;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float lineHeight = 12f; // Height of each line
            float pageWidth = e.PageBounds.Width; // Width of the page
            Font printFont = new Font("Arial", 6);
            Font boldFont = new Font("Arial", 7, FontStyle.Bold);

            int maxWidth = (int)(pageWidth - 2 * leftMargin);

            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var lines = new List<Tuple<string, Font>>()
    {
        new Tuple<string, Font>("********************************", printFont),
        new Tuple<string, Font>("       Papeleria D' José      ", boldFont),
        new Tuple<string, Font>("           Fecha y Hora        ", printFont),
        new Tuple<string, Font>($"      {currentTime}      ", printFont),
        new Tuple<string, Font>("********************************", printFont)
    };

            foreach (DataGridViewRow row in datosInicioVentas.Rows)
            {
                if (row.IsNewRow) continue;

                string nombre = row.Cells["Nombre"].Value.ToString();
                string precioUnitario = row.Cells["PrecioUnitario"].Value.ToString();
                string precioMayoreo = row.Cells["PrecioMayoreo"].Value.ToString();
                string precioTemporada = row.Cells["PrecioTemporada"].Value.ToString();
                string cantidad = row.Cells["Cantidad"].Value.ToString();
                string subTotal = row.Cells["SubTotal"].Value.ToString();

                lines.Add(new Tuple<string, Font>($"{nombre}", boldFont));
                lines.Add(new Tuple<string, Font>($"{precioUnitario} | {precioMayoreo} | {precioTemporada} | x{cantidad} = {subTotal}", printFont));
                lines.Add(new Tuple<string, Font>("-------------------------------------", printFont));
            }

            lines.Add(new Tuple<string, Font>($"       Total: {precioTotal}    ", boldFont));
            lines.Add(new Tuple<string, Font>("      La papeleria D´ José      ", printFont));
            lines.Add(new Tuple<string, Font>("   le agradece su preferencia   ", printFont));
            lines.Add(new Tuple<string, Font>("********************************", printFont));

            string portName = "COM1";
            int baudRate = 9600;

            Controlador.Ticket printer = new Controlador.Ticket(portName, baudRate);

            try
            {
                try
                {
                    printer.OpenConnection();
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"No se pudo abrir la conexión al puerto {portName}: {ex.Message}");
                    return;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show($"Acceso no autorizado al puerto {portName}: {ex.Message}");
                    return;
                }

                try
                {
                    printer.PrintTicket(lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al imprimir el ticket: {ex.Message}");
                }
            }
            finally
            {
                try
                {
                    printer.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
                }

                foreach (var line in lines)
                {
                    string formattedLine = TruncateLineToWidth(line.Item1, maxWidth, e.Graphics, line.Item2);
                    e.Graphics.DrawString(formattedLine, line.Item2, Brushes.Black, leftMargin, yPos);
                    yPos += lineHeight;
                }
            }
        }


        private string TruncateLineToWidth(string text, int maxWidth, Graphics graphics, Font font)
        {

            SizeF textSize = graphics.MeasureString(text, font);

            if (textSize.Width > maxWidth)
            {
                int charCount = text.Length;
                for (int i = text.Length; i > 0; i--)
                {
                    string substring = text.Substring(0, i);
                    SizeF substringSize = graphics.MeasureString(substring, font);
                    if (substringSize.Width <= maxWidth)
                    {
                        text = substring + "..."; 
                        break;
                    }
                }
            }

            return text;
        }

        private void imprimir()
        {
            try
            {
                PrintTicketPreview();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        #endregion
    }
}
