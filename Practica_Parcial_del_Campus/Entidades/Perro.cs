using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public bool EsAlfa { get { return this.esAlfa; } set { this.esAlfa = value; } }

        protected override string Ficha()
        {
            string resp = "";
            if (this.esAlfa == true)
            {
                resp += base.Nombre + " el alfa de la manada. Edad: " + this.Edad + "\n";
            }
            else
            {
                resp += "Nombre: " + base.Nombre + "Edad: " + this.Edad + "\n";
            }
            return resp;
        }
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool resp = false;
            if (p1.Nombre == p2.Nombre && p1.Edad == p2.Edad && p1.Raza == p2.Raza)
                resp = true;
            return resp;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro perro)
        {
            int resp = 0;
            resp = perro.Edad;
            return resp;
        }


    }
}
