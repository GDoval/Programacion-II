using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        /// <summary>
        /// Establece un valor para un atributo de la clase
        /// </summary>
        /// <param name="param">Parametro para inicializar el atributo entero de la clase</param>
        public void EstablecerValor(int param)
        {
            this.entero = param;
        }


        /// <summary>
        /// Establece un valor para un atributo de la clase
        /// </summary>
        /// <param name="param">Incializa el atributo de tipo string de la clase</param>
        public void EstablecerValor(string param)
        {
            this.cadena = param;
        }


        /// <summary>
        /// Establece un valor para un atributo de la clase
        /// </summary>
        /// <param name="param">Incializa la fecha de la clase</param>
        public void EstablecerValor(DateTime param)
        {
            this.fecha = param;
        }

        /// <summary>
        /// Muestra los valores actuales de los atributos de la instancia de la clase 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            string retorno = "";
            retorno += this.entero + "\n" + this.cadena + "\n" + this.fecha;
            return retorno;
        }
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(int num, string cadena, DateTime fecha)
        {
            this.entero = num;
            this.cadena = cadena;
            this.fecha = fecha;
        }


    }
}