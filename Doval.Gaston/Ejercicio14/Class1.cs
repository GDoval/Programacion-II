using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double num)
        {
            return num * num;
        }

        public static double CalcularTriangulo(double base1, double altura)
        {
            return 0.5 * (base1 * altura); 
        }

        public static double CalcularCirculo(double radio)
        {
            double pi = Math.PI;
            return pi * (radio * radio);
        }
    }
}
