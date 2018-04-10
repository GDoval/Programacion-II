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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            short cant = short.Parse(this.txtCant.Text);
            this.equipo = new Equipo(cant, nombre);
            this.txtNombre.Enabled = false;
            this.txtCant.Enabled = false;
            this.btnAceptar.Visible = false;
            this.btnCancelar.Visible = false;
        }
    }
}
