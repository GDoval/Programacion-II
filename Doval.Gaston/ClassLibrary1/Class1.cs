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
        public Cosa() : this(10, "Sin valor", DateTime.Now) // esto solo funciona con constructores no estaticos, no con metodos
        {
            this.entero = 10;
            this.cadena = "";
            this.fecha = DateTime.Now;
        }

        public Cosa(int num, string cadena, DateTime fecha)
        {
            this.entero = num;
            this.cadena = cadena;
            this.fecha = fecha;
        }
        public Cosa(int num) : this() 
        {
            this.entero = num;
        }

        public Cosa(int num, string cadena): this(num)
        {
            this.cadena = cadena;
        }
        //Cuando se hace la llamada :this(params) despues de cada constructor, se ejecuta primero el constructor
        //que se llama con el this y _despues_ se ejecuta el constructor que se llamo la primera vez.
        //So, si en el constructor del this se incializa un valor, ese mismo valor se puede pisar despues cuando
        // el compilador vuelve al constructor original. 
    }
}