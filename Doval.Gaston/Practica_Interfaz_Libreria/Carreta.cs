using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public class Carreta : Vehiculo,IARBA
    {
        public Carreta(double precio)
            :base(precio)
        { 
        }
        public override double Precio
        {
            get { return base._precio; }
        }


        public double CalcularImpuesto()
        {
            double resp = this._precio * 0.18;
            return resp;
        }
    }
}
