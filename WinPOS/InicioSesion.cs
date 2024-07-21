using Controlador;
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
            string user = txtUserName.Text;
            string passwd = txtPassword.Text;

            iniciarSesion(user, passwd);
        }

        private void iniciarSesion(string user, string passwd)
        {
            Consultas consultas = new Consultas();

            Dictionary<string, object> resultado = consultas.checkUser(user, passwd);

            if (resultado.ContainsKey("error"))
            {
                MessageBox.Show(resultado["error"].ToString());
            }
            else
            {
                string rol = resultado["rol"].ToString();
                int id = (int)resultado["id"];

                if (rol == "admin")
                {
                    this.Hide();
                    AdministradorInicio admin = new AdministradorInicio(id);
                    admin.Show();
                }
                else if (rol == "vendedor")
                {
                    VendedorInicio vendedor = new VendedorInicio(id);
                    vendedor.Show();
                    this.Hide();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            string user = txtUserName.Text;
            string pass = txtPassword.Text;
            if (e.KeyChar == (char)Keys.Enter) {

                iniciarSesion(user, pass);
            }
        }
    }
}
