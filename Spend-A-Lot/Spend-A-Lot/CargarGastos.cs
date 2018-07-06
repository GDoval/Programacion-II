using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Spend_A_Lot
{
    public partial class CargarGastos : Form
    {

        private Gastos gasto;

        public CargarGastos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Gastos_Click(object sender, EventArgs e)
        {
            this.gasto = new Gastos(Convert.ToDouble(this.txtGasto.Text), this.rtxtObservaciones.Text, (Entidades.ETipoGasto)this.cmbTipo.SelectedItem);

        }


    }
}
