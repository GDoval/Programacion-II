using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Parcial
{
    public partial class numero1 : Form
    {
        public numero1()
        {
            InitializeComponent();
        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numero1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string coso = this.cmbOperador.Items[this.cmbOperador.SelectedIndex].ToString();
            MessageBox.Show(coso);
        }

    }
}
