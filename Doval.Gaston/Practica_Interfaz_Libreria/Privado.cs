using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    public class Privado : Avion
    {
        private int _valorServicioAbordo;
        public Privado(double precio, double velocidad, int valor)
            : base(precio, velocidad)
        { this._valorServicioAbordo = valor; }
    }   
}
