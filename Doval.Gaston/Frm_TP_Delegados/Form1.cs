using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_TP_Delegados
{

    

    public partial class frmPrincipal : Form
    {
        public delegate void DelCambiarNombre(string nombre);

        public frmTest test;
        public frmDatos datos;

        public frmTest Test { get { return this.test; } set { this.test = value;} }

        public frmDatos Datos { get { return this.datos; } set { this.datos = value;} }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void testAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Test = new frmTest() { Owner = this };
            this.test.Show();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Datos = new frmDatos() { Owner = this };

            //Se le asigna el manejador al Delegado y se lo asocia al Evento.
            this.test.EventoCambiarNombre += new DelCambiarNombre(datos.CambiarNombre);
            datos.Show();
        }


    }
}
