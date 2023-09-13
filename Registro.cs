using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace acceso
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server - 127.0.0.1 ; Database = login; user Id-root ; password-lentp123 ");
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            string sql = "isert into users(user,pass) values ('" + n_user.Text + "' , '" + n_pass.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO REGISTRADO");
                this.Hide();
                Form1 n1 = new Form1();
                n1.Show();
            }
            catch (MySqlException ex) { MessageBox.Show("Error " + ex.ToString()); }

        }
        private void Cerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
