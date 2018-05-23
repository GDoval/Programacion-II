using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public class Deportivo : Auto, IAFIP,IARBA
    {
        private int _caballosFuerza;
        public Deportivo(double precio, string patente, int caba)
            :base(precio, patente)
        {this._caballosFuerza = caba;}



        double IAFIP.CalcularImpuesto()
        {
            double resp = this._precio * 0.28;
            return resp;
        }

        double IARBA.CalcularImpuesto()
        {
            double resp = this._precio * 0.23;
            return resp;
        }
    }
}
