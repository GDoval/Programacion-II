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
    public partial class FrmEquipo : Form
    {
        public FrmEquipo()
        {
            InitializeComponent();
        }

        private Equipo equipo;
        private Jugador jug;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            short cant = short.Parse(this.txtCant.Text);
            this.equipo = new Equipo(cant, nombre);
            this.txtNombre.Enabled = false;
            this.txtCant.Enabled = false;
            this.btnAceptar.Visible = false;
            this.btnCancelar.Visible = false;

            this.btnMas.Visible = true;
            this.listUno.Visible = true;
            this.btnMenos.Visible = true;
        }
        /// <summary>
        /// Muestra los elementos en la coleccion dentro de la clase Equipo a traves de un ListBox
        /// </summary>
        private void TeMuestro()
        {
            listUno.Items.Clear();
            foreach(Jugador jug in this.equipo.GetJugadores())
            {
                this.listUno.Items.Add(jug.MostrarDatos());
            }
        }


        private void btnMas_Click(object sender, EventArgs e)
        {
            FrmJugador miFormulario = new FrmJugador();
            miFormulario.ShowDialog(); //abre el nuevo formulario y no deja hace otra cosa hasta que no se cierre
            if (miFormulario.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                jug = miFormulario.GetJugador();
                bool validar = this.equipo + jug;
                if (validar)
                {
                    MessageBox.Show("Jugador ingresado");
                    this.TeMuestro();
                }
                else
                {
                    MessageBox.Show("No  se pudo ingresar al jugador");
                }
            }
            
        }

        private void listUno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int index = this.listUno.SelectedIndex;
            List<Jugador> lista = this.equipo.GetJugadores();
            if (index > -1)
                MessageBox.Show(lista[index].MostrarDatos());
        }

       
    }
}
