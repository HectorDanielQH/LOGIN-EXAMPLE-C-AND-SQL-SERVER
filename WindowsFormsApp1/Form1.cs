using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String cadena = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = "", contra = "";
            login = textBox1.Text;
            contra = textBox2.Text;
            cadena = "Data Source=.;initial catalog=pruebilla;user=" + login + ";password=" + contra;
            SqlConnection conex = new SqlConnection(cadena);
            try
            {
                conex.Open();
                MessageBox.Show("se ingreso con exito");
                VENDEDOR x = new VENDEDOR();
                x.identidicador(login);
                x.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show("no ingreso con exito "+ee.Message);
            }
            finally
            {
                conex.Close();
            }
        
        }
    }
}
