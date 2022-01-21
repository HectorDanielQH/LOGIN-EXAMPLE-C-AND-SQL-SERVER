using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VENDEDOR : Form
    {
        private String identifica="";
        public VENDEDOR()
        {
            InitializeComponent();
        }
        public void identidicador(String x)
        {
            identifica = x;
        }
        private void VENDEDOR_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(identifica);
        }
    }
}
