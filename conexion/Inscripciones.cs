using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace conexion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_cod.Text);
            int ci = int.Parse(txt1.Text);
            string nombre = txt2.Text;
            string apellido = txt3.Text;
            string nacionalidad = txt4.Text;
            int estado_civ = int.Parse(num_estado_civ.Text);
            string direccion = txt6.Text;
            DateTime fecha_nac = date2.Value;
            string lugar_nac = txt7.Text;
            string col_proc = txt8.Text;
            string nombre_padre = txt9.Text;
            string nombre_madre = txt10.Text;
            string nombre_encarg = txt11.Text;
            string nombre_cony = txt12.Text;
            string telef = txt13.Text;
            string correo = txt14.Text;
            string obs = txt15.Text;
            DateTime fecha_insc = date1.Value;

            string sql_guardar = "INSERT INTO alumnos (cod_alumno, ci_alumno, nombres, apellidos, nacionalidad, fkestadociv, direccion, fecha_nac, lugar_nac, col_proc, nombre_padre, nombre_madre, nombre_encarg, nombre_cony, telef, correo, obs, fecha_insc) VALUES ('" + codigo + "', '" + ci + "','" + nombre + "','" + apellido + "','" + nacionalidad + "','" + estado_civ + "','" + direccion + "','" + fecha_nac + "','" + lugar_nac + "','" + col_proc + "','" + nombre_padre + "','" + nombre_madre + "','" + nombre_encarg + "','" + nombre_cony + "','" + telef + "','" + correo + "', '" + obs + "', '" + fecha_insc + "')";

            MySqlConnection conexion = ;

            try
            {
                MySqlCommand comando = new MySqlCommand(sql_guardar);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar " + ex.Message);
            }
        }
    }
}
