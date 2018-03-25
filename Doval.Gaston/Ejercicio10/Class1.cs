using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    class Validar
    {
        public static bool Validacion(int num, int max, int min)
        {
            bool resp = false;
            if (num <= max && num >= min)
                resp = true;
            return resp;
        }
    }
}
