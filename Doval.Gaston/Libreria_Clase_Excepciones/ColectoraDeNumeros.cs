using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clase_Excepciones
{
    public enum ETipoNumero
    {
        Par, Impar, Positivo, Negativo, Cero
    }
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;
        public ETipoNumero Tipo { get; set; }


        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipo)
            :this()
        {
            this.Tipo = tipo;
        }

        public static bool operator ==(ColectoraDeNumeros colec, Numero num)
        {
            foreach (Numero n in colec._numeros)
            {
                if (n._Numero == num._Numero)
                    return true;
            }
            return false;
        }

        public static bool operator !=(ColectoraDeNumeros colec, Numero num)
        { return !(colec == num); }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros colec, Numero num)
        {
            bool validar = Verificadora.VerificarNumero(colec.Tipo, num);
            if (!(validar))
                throw new Exception("El numero no es del tipo de la coleccion");
            else
            {
                colec._numeros.Add(num);
                return colec;
            }
        }

        public static ColectoraDeNumeros operator -(ColectoraDeNumeros colec, Numero num)
        {
            if (colec == num)
                colec._numeros.Remove(num);
            else
            {
                string resp = "El numero no se encuentra en la coleccion: \n" + colec.ToString();
                throw new Exception(resp);
            }
                return colec;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Colectora tipo: ");
            sb.Append(Convert.ToString(this.Tipo));
            foreach(Numero n in this._numeros)
            {
                sb.Append("\nNumero: ");
                sb.Append(Convert.ToString(n._Numero));
            }
            return sb.ToString();
        }
    }
}
