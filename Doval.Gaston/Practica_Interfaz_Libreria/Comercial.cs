using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public class Comercial : Avion
    {
        private int _capacidadPasajeros;
        public Comercial(double precio, double velocidad, int cant)
            : base(precio, velocidad)
        { this._capacidadPasajeros = cant; }
    }
}
