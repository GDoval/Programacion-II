using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public class Familiar : Auto
    {
        private int _cantAsientos;
        public Familiar(double precio, string patente, int cant)
            : base(precio, patente)
        { this._cantAsientos = cant; }
    }
}
