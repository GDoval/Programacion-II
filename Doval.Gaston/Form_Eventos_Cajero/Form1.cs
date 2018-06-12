using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Eventos_Cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Manejador_Load);
        }

        private void Manejador_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(Calcular);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBillete100_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Click -= new EventHandler(Calcular);
            this.btnLimpiar.Click += new EventHandler(Limpiar);
            this.btnAceptar.Click += new EventHandler(Informar);
        }

        private void Limpiar(object sender, EventArgs e) //ver como hacer esto con un foreach usando Control y this.Controls
        {
            this.btnLimpiar.Click -= new EventHandler(Limpiar);
            this.btnAceptar.Click -= new EventHandler(Calcular);
            this.btnAceptar.Click -= new EventHandler(Informar);
            this.btnAceptar.Click += new EventHandler(Calcular);
            this.txtBillete10.Clear();
            this.txtBilleteDos.Clear();
            this.txtBillete5.Clear();
            this.txtBillete20.Clear();
            this.txtBillete50.Clear();
            this.txtBillete100.Clear();
        }

        private void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpiar la pantalla para seguir operando");
        }

        private void Calcular(object sender, EventArgs e)
        {
            int retirar;
            int cont2 = 0, cont5 = 0, cont10 = 0, cont20 = 0, cont50 = 0, cont100 = 0;
            retirar = int.Parse(this.txtRetirar.Text);
            while (retirar >= 100)
            {
                cont100++;
                retirar -= 100;
            }
            while (retirar >= 50)
            {
                cont50++;
                retirar -= 50;
            }
            while (retirar >= 20)
            {
                cont20++;
                retirar -= 20;
            }
            while (retirar >= 10)
            {
                cont10++;
                retirar -= 10;
            }
            while (retirar >= 5)
            {
                cont5++;
                retirar -= 5;
            }
            while (retirar >= 2)
            {
                cont2++;
                retirar -= 2;
            }
            this.txtBillete10.Text = Convert.ToString(cont10);
            this.txtBilleteDos.Text = Convert.ToString(cont2);
            this.txtBillete5.Text = Convert.ToString(cont5);
            this.txtBillete20.Text = Convert.ToString(cont20);
            this.txtBillete50.Text = Convert.ToString(cont50);
            this.txtBillete100.Text = Convert.ToString(cont100);
            if (retirar == 1)
                MessageBox.Show("Quedo un peso");
        }
    }
}
