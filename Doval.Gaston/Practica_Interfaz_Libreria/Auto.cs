using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;
        public Auto(double precio, string patente)
            : base(precio)
        { this._patente = patente; }

        public void MostrarPatente()
        {
            Console.WriteLine("La patente es: {0}", this._patente);
        }
        public override double Precio
        {
            get { return base._precio; }
        }
    }
}
