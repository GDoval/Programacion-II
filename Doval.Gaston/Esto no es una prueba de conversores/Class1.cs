using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esto_no_es_una_prueba_de_conversores
{
    class Cosas
    {
        int algo;
        double halgo;
        public Cosas(int num, double aj)
        {
            this.algo = num;
            this.halgo = aj;
        }

        public static implicit operator int(Cosas algo)
        {
            return algo.algo;
        }

        public static implicit operator double(Cosas asd)
        {
            return asd.halgo;
        }
    }
}
