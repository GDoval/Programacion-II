using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Delegados
{
    public class ExcepcionSueldoNegativo : Exception
    {
        public ExcepcionSueldoNegativo(string message)
            : base(message)
        { }
    }
}
