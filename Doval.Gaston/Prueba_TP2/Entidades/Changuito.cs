using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Changuito
    {
        private int _espacioDisponible;
        private List<Producto> _productos;
        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        public Changuito()
        {
            this._productos = new List<Producto>();
        }

        public Changuito(int espacioDisponible) :this()
        {
            this._espacioDisponible = espacioDisponible;
        }


        public string ToString()
        {
            return this.Mostrar(this, ETipo.Dulce);
        }

                
        public  string Mostrar(Changuito concencionaria, ETipo tipoDeChanguito)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", concencionaria._productos.Count, concencionaria._espacioDisponible);
            sb.AppendLine("");
            foreach (Producto v in concencionaria._productos)
            {
                switch (tipoDeChanguito)
                {
                    /*case ETipo.Snacks:
                        sb.AppendLine(v.Mostrar());
                        break;*/
                    case ETipo.Dulce:
                        sb.AppendLine(((Dulce)v).Mostrar());
                        break;
                    /*case ETipo.Leche:
                        sb.AppendLine(v.Mostrar());
                        break;*/
                    /*default:
                        sb.AppendLine(v.Mostrar());
                        break;*/
                }
            }
            return Convert.ToString(sb);
        }

        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            foreach (Producto v in c._productos)
            {
                if (v == p)
                    return c;
            }

            c._productos.Add(p);
            return c;
        }
    }
}
