using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase_7_Ejercicio_29;

namespace Equipo_Jugador
{
    public partial class FrmJugador : Form
    {
        public FrmJugador()
        {
            InitializeComponent();
        }

        private Jugador jugador;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            long dni = long.Parse(this.txtDNI.Text);
            string nombre = this.txtNombre.Text;
            int goles = int.Parse(this.txtGoles.Text);
            int partidos = int.Parse(this.txtJugados.Text);
            this.jugador = new Jugador(nombre, dni, goles, partidos);
            MessageBox.Show(this.jugador.MostrarDatos());
        }

        public Jugador GetJugador()
        {
            return this.jugador;
        }
    }
}
