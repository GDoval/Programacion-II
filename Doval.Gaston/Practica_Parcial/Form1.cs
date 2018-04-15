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

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string num1 = this.txtNumero1.Text;
            string num2 = this.txtNumero2.Text;
            string operador = this.cmbOperador.Text;
            double resp = numero1.Operar(num1, num2, operador);
            string muestra = Convert.ToString(resp);
            MessageBox.Show(muestra);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private static double Operar(string num1, string num2, string operador)
        {
            Calculadora calcu = new Calculadora();
            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);
            double resp = calcu.Operar(numero1, numero2, operador);
            return resp;
        }

    }
}
