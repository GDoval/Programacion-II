using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clase_Arrays
{
    public class Tempera
    {
        private string marca;
        private int cantidad;
        private ConsoleColor color;
        public Tempera(ConsoleColor color, int cantidad, string marca)
        {
            this.color = color;
            this.cantidad = cantidad;
            this.marca = marca;
        }

        private string Mostrar()
        {
            return this.color + "," + this.marca + "," + this.cantidad + "\n";
        }

        public string Mostrar(Tempera tempera)
        {
            string resp = tempera.Mostrar();
            return resp;
        }

        public static bool operator ==(Tempera temp1, Tempera temp2)
        {
            bool resp = false;
            if (temp1.color == temp2.color && temp1.marca == temp2.marca)
                resp = true;
            return resp;
        }

        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static implicit operator int (Tempera temp)
        {
            return temp.cantidad;
        }

        public static explicit operator string(Tempera temp)
        {
            return temp.Mostrar();
        }

        public static Tempera operator +(Tempera temp, int cant)
        {
            temp.cantidad += cant;
            return temp;
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
            {
                temp1 += temp2.cantidad;
            }
            return temp1;
        }
    }
}
