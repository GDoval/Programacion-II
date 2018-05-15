using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clase_Excepciones
{
    public class Numero
    {
        protected int _numero;
        public int _Numero { get { return this._numero; } }

        public Numero(int num)
        { this._numero = num; }

        public static int operator +(Numero num1, Numero num2)
        {return num1._Numero + num2._Numero; }

        public static int operator -(Numero num1, Numero num2)
        {return num1._Numero - num2._Numero; }

        public static double operator /(Numero num1, Numero num2)
        { return num1._Numero / num2._Numero; }

        public static int operator *(Numero num1, Numero num2)
        { return num1._Numero * num2._Numero; }

        public static bool Parse(string var, out Numero numero)
        {
            bool resp = true;
            int num = 0;
            try
            {
                num = int.Parse(var);
            }
            catch(Exception e)
            {
                resp = false;
            }
            if (resp)
                numero = new Numero(num);
            else
                numero = null;
            return resp;
        }


    }
}
