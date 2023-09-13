using MySql.Data.MySqlClient;

namespace acceso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void entrar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = user.Text;
            contraseña = pass.Text;
            MySqlConnection con = new MySqlConnection("server - 127.0.0.1 ; Database = login; user Id-root ; password-lentp123 ");
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Eror" + ex.ToString());
                throw;
            }

        }
    }
}