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
            InitializeComponent(); // instancia los elementos (botones, etc) que se ponga en el formulario
        }

        private Jugador jugador;


        /// <summary>
        /// Constructor que recibe un jugador ya cargado y guarda la informacion en los TextBox del formulario FrmJugador
        /// </summary>
        /// <param name="jug"></param>
        public FrmJugador(Jugador jug): this()
        {
            this.jugador = jug;

            //Se llaman a las propiedades que traen los valores desde el objeto que se pasa como parametro

            this.txtNombre.Text = jug.Nombre;
            this.txtDNI.Text = Convert.ToString(jug.Dni);
            this.txtGoles.Text = Convert.ToString(jug.TotalGoles);
            this.txtJugados.Text = Convert.ToString(jug.PartidosJugados);


        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            long dni = long.Parse(this.txtDNI.Text);
            string nombre = this.txtNombre.Text;
            int goles = int.Parse(this.txtGoles.Text);
            int partidos = int.Parse(this.txtJugados.Text);
            this.jugador = new Jugador(nombre, dni, goles, partidos);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public Jugador GetJugador()
        {
            return this.jugador;
        }
    }
}
