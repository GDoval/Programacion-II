using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase15
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Marca { get { return this._marca; } }
        public string Color { get { return this._color; } }

        public Auto(string color, string marca)
        {
            this._marca = marca;
            this._color = color;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            if (a.Marca == b.Marca && a.Color == b.Color)
                return true;
            else
                return false;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            string resp = "";
            resp += "Marca: " + this.Marca + "\nColor: " + this.Color;
            return resp;
        }

        public override bool Equals(object obj)
        {
            if (obj is Auto)
                if (((Auto)obj) == this)
                    return true;
                else
                    return false;
            else
                return false;
        }


    }
}
