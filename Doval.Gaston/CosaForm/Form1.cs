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
            int numero =  int.Parse (this.txtEntero.Text);
            string cadena = this.txtCadena.Text;
            DateTime fecha = DateTime.Parse (this.textFecha.Text);
            Cosa objeto = new Cosa(numero, cadena, fecha);
            MessageBox.Show(objeto.Mostrar());
        }
    }
}
