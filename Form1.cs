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
            string sql = "select user,pass from users where user = '" + nombre + "' AND pass = '" + contraseña + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido" + nombre);
            }
            else
            {
                MessageBox.Show("No existe este usuario " + nombre);
            }


    }
        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Ingrese su usuario";
                user.ForeColor = Color.Black;
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Ingrese su usuario")
            {
                user.Text = "";
                user.ForeColor = Color.Black;
            }

        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Ingrese su contraseña";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = false;

            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Ingrese su contraseña")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = true;
            }
        }
    }
}