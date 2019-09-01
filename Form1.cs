using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_punto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lblradio_Click(object sender, EventArgs e)
        {

        }

        private void Btncalculo_Click(object sender, EventArgs e)
        {
            string radioc = txtradio.Text;
            string areac = txtarea.Text;

            float radio = float.Parse(radioc);
            float resultado = 3.1415F * (radio * radio);


            txtarea.Text = resultado.ToString();

        }
    }
}
