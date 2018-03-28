using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace CosaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            int numero =  int.Parse (this.textBox1.Text);
            string cadena = this.textBox2.Text;
            DateTime fecha = DateTime.Parse (this.textBox3.Text);
            Cosa objeto = new Cosa(numero, cadena, fecha);
            MessageBox.Show(objeto.Mostrar());
        }
    }
}
