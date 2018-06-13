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
        //Definir delegado aca o en el namespace
        //Se le asigna el manejador cuando se hace click en los menu de frmPrincipal, y se instancia la clase de frmDatos o Test. Xq el metodo que se pasa como parametro
        // a ese delegado se tiene que hacer dentro de la clase frmDatos, por lo que hay que instanciar esa clase para tener la direccion de memoria del metodo

        //El delegado se invoca al hacer click en aceptar en el frmTest
        public frmPrincipal()
        {
            InitializeComponent();
            frmDatos dat = new frmDatos();

        }

        private void testAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
