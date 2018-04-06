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
            this.combo.Items.Add("+");
            this.combo.Items.Add("/");
            this.combo.Items.Add("*");
            this.combo.Items.Add("-");
        }


    }
}
