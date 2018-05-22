using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public void MostrarPrecio()
        {
            Console.WriteLine("El precio es: {0}", this._precio);
        }
        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        public abstract double Precio { get; }
    }
}
