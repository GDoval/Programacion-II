using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clase_Arrays;

namespace Libreria_Paleta
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

        public static implicit operator Tempera(int num)
        {

        }
    }
}
