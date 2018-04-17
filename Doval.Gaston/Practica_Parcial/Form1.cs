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
            this.lblResultado.Text = muestra;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "";
            this.cmbOperador.Text = "";
        }

        private static double Operar(string num1, string num2, string operador)
        {
            Calculadora calcu = new Calculadora();
            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);
            double resp = calcu.Operar(numero1, numero2, operador);
            return resp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string buff = this.lblResultado.Text;
            long num = long.Parse(buff);
            num = BitConverter.DoubleToInt64Bits(num);
            buff = Convert.ToString(num, 2);
            this.lblResultado.Text = buff;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

    }
}
