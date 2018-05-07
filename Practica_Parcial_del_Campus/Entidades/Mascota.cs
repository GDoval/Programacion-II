using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre { get { return this.nombre; } }
        public string Raza { get { return this.raza; } }

        protected virtual string DatosCompletos()
        {
            string resp = "";
            resp += "Nombre: " + this.Nombre + "\n" + "Raza: " + this.Raza + "\n";
            return resp;
        }

        protected abstract string Ficha();

        public  Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        
    }
}
