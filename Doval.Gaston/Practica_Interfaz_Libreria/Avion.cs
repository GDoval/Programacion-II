using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public class Avion : Vehiculo, IAFIP,IARBA
    {
        protected double _velocidadMaxima;
        public Avion(double precio, double velocidad)
            : base(precio)
        {
            this._velocidadMaxima = velocidad;
        }
      

        public override double Precio
        {
            get { return base._precio; }
        }

        double IAFIP.CalcularImpuesto()
        {
            double resp = 0;
            resp = this._precio * 0.33;
            return resp;
        }

        double IARBA.CalcularImpuesto()
        {
            double resp = 0;
            resp = this._precio * 0.27;
            return resp;
        }
    }
}
