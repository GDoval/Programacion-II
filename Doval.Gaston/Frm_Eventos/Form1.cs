using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Delegados;
namespace Frm_Eventos
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de Eventos (EventHandler). Es el método que se le pasa al Delegado para que después ejecute.
        /// </summary>
        /// <param name="empleado"></param>
        /// <param name="e"></param>
        public void SueldoAltoMejorado(Empleado empleado, EmpleadoEventArgs e)
        { MessageBox.Show("Sueldo muy alto para:\n" + empleado.ToString() + "\nQuiere ganar: " + e.Sueldo); }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int sueldo = int.Parse(this.txtSueldo.Text);
            Empleado emp = new Empleado( this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text));

            //El Evento que se declara dentro de la clase Empleado, aca se lo incicializa pasandole el Método SueldoAltoMejorado como parametro al Delegado
            emp.SueldoMaximoMejorado += new DelegadoLimiteSueldoMejorado(SueldoAltoMejorado);
            try
            {
                emp.Sueldo = sueldo;
            }
            catch (ExcepcionSueldoNegativo me)
            {
                MessageBox.Show(me.Message);
            }
            
        }
    }
}
