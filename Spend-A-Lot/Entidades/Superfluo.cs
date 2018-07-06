using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Superfluo :Gastos
    {
        public Superfluo(double monto, string just, ETipoGasto tipo)
            :base(monto, just, tipo)
        { }
    }
}
