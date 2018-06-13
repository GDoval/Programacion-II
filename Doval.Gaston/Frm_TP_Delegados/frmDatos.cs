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
    public partial class frmDatos : frmPrincipal
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EventHandler para cambiar el Text del label
        /// </summary>
        /// <param name="nombre"></param>
        public void CambiarNombre(string nombre)
        {
            this.lblLabel.Text = nombre;
        }
    }
}
