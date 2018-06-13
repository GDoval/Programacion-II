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

        public void SueldoAltoMejorado(Empleado empleado, EmpleadoEventArgs e)
        { MessageBox.Show("Sueldo muy alto para:\n" + empleado.ToString() + "\nQuiere ganar: " + e.Sueldo); }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int sueldo = int.Parse(this.txtSueldo.Text);
            Empleado emp = new Empleado( this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text));
            emp.SueldoCero += new DelegadoSueldoCero(emp.ManejadorEvento); 
            emp.SueldoMaximo += new DelegadoLimiteSueldo(emp.SueldoAlto);
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
