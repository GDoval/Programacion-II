using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clase_Excepciones
{
    static class Verificadora
    {
        public static bool VerificarNumero(ETipoNumero tipo, Numero num)
        {
            bool resp = false;
            switch (tipo)
            {
                case ETipoNumero.Cero:
                    if (num._Numero == 0)
                        resp = true;
                    break;
                case ETipoNumero.Impar:
                    if (num._Numero % 2 != 0)
                        resp = true;
                    break;
                case ETipoNumero.Negativo:
                    if (num._Numero < 0)
                        resp = true;
                    break;
                case ETipoNumero.Positivo:
                    if (num._Numero > 0)
                        resp = true;
                    break;
                case ETipoNumero.Par:
                    if (num._Numero % 2 == 0)
                        resp = true;
                    break;                        
            }
            return resp;
        }
    }
}
