using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace conexion
{
    class ConcexionBD
    {
        string servidor = textBox1.Text;
        string puerto = textBox2.Text;
        string usuario = textBox3.Text;
        string contrasena = textBox4.Text;
        string datos = "";


        string cadena = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + contrasena + "; database=upgbd;";

        MySqlConnection conexion = new MySqlConnection(cadena);

            try
            {
                conexion.Open();
                MySqlDataReader reader = null;
        MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexion);
        reader = cmd.ExecuteReader();
                Form2 frm = new Form2();
        frm.Show();
                this.Hide();
                while (reader.Read())

                {
                    datos += reader.GetString(0) + "\n";
                    

                }



} 
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show(datos);
    }
}
