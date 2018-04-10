using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(int num)
        {
            string resp = "";
            while (num > 1)
            {
                int resto = num % 2;
                resp = Convert.ToString(resto) + resp;
                num /= 2;
            }
            resp = Convert.ToString(num) + resp;
            return resp;
        }

        public static int BinarioDecimal(string num)
        {
            int resp = Convert.ToInt32(num, 2);
            return resp;

        }
    }
}
