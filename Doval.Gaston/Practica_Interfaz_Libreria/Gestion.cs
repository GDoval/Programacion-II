using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Interfaz_Libreria
{
    static class Gestion
    {
        static double MostrarImpuestoNacional(IAFIP bienPunible) //recibe solo objetos que implementen la interfaz (Avion, Privado, Comercial, Deportivo)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
