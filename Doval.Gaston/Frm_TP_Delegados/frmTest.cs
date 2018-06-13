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
    public partial class frmTest : frmPrincipal
    {
        //Se crea el evento que se va a asociar a un Delegado dentro de frmPrincipal
        public event frmPrincipal.DelCambiarNombre EventoCambiarNombre;

        public frmTest()
        {
            InitializeComponent();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            string nom = this.txtNombre.Text;

            //Se hace la llamada al Evento, que llama al Delegado, que ejecuta los Métodos en su lista de Métodos.
            this.EventoCambiarNombre(nom);
        }
    }
}
