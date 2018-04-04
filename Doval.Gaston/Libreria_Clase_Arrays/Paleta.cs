using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clase_Arrays
{
    public class Paleta
    {
        private Tempera[] colores;
        private int CantidadMaximaColores;

        private Paleta() :this(5)
        {
        }

        private Paleta(int num)
        {
            this.CantidadMaximaColores = num;
            this.colores = new Tempera[this.CantidadMaximaColores];
       }

        public static implicit operator Paleta(int num)
        {
            Paleta pale = new Paleta(num);
            return pale;
        }

        private string Mostrar()
        {
            string asd  = "La cantidad de colores es de: " + this.CantidadMaximaColores + "\n";
            for (int i = 0; i < this.colores.GetLength(0) ; i++)
            {
                if (this.colores.GetValue(i) != null)
                    asd += Tempera.Mostrar(colores[i]);
            }
            return asd;
        }

        public static explicit operator string(Paleta pale)
        {
            return pale.Mostrar();
        }

        public static bool operator ==(Paleta pale, Tempera temp)
        {
            bool resp = false;
            for (int i = 0; i < pale.CantidadMaximaColores; i++)
            {
                if (pale.colores.GetValue(i) != null)
                {
                    if (pale.colores[i] == temp)
                    {
                        resp = true;
                        break;
                    }
                }
            }
            return resp;
        }

        public static bool operator !=(Paleta pale, Tempera temp)
        {
            return !(pale == temp);
        }


        public static Paleta operator +(Paleta pale, Tempera temp)
        {
            if (pale == temp)
            {
                int indice = pale.colores[pale.ObtenerIndice(temp)];
                pale.colores[indice] += temp;
            }
            return pale;
        }

        private int ObtenerIndice(Tempera temp)
        {
            int indice = -1;
            for (int i = 0; i < this.colores.GetLength(0); i++)
            {
                if (this.colores[i] == temp)
                    return indice = i;
            }
            return indice;
        }

        private int ObtenerIndice()
        {
            int indice = -1;
            for (int i = 0; i < this.colores.GetLength(0); i++)
            {
                if (this.colores.GetValue(i) == null)
                    return indice = i;
            }
            return indice;
        }
    }
}