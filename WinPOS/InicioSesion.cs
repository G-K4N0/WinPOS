using Controlador;
using MySqlConnector;
namespace WinPOS
{
    public partial class FInciarSesion : Form
    {
        private Conexion conexion;
        public FInciarSesion()
        {
            InitializeComponent();
        }

        private void btnInciarSesion_Click(object sender, EventArgs e)
        {
            string result = "";
            conexion = new Conexion();

            MySqlDataReader lector = null;

            string consulta = "select * from personas";

            if (conexion.getConecction() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = conexion.getConecction();
                lector = cmd.ExecuteReader();

                while (lector.Read()) {
                    result = lector.GetInt32("idRol").ToString();
                }
                MessageBox.Show(result);
            }
            //VendedorInicio vendedor = new VendedorInicio();
            //vendedor.Show();
            //this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
