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
            string asd  = "";
            for (int i = 0; i < this.colores.GetLength(0) ; i++)
            {
                asd += this.colores[i].Mostrar(colores[i]);
            }
            return asd;
        }

        public static explicit operator string(Paleta pale)
        {
            return pale.Mostrar();
        }
    }
}