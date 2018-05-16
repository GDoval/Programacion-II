using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase15
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int cap)
        {
            this._capacidadMaxima = cap;
            this._lista = new List<Auto>();
        }

        public static bool operator +(DepositoDeAutos dep, Auto a)
        {
            if (dep._lista.Count < dep._capacidadMaxima)
            {
                dep._lista.Add(a);
                return true;
            }
            else
                return false;
        }
                

        private int GetIndice(Auto a)
        {
            foreach (Auto au in this._lista)
            {
                if (au == a)
                    return this._lista.IndexOf(au);
            }
            return -1;
        }

        public static bool operator -(DepositoDeAutos dep, Auto a)
        {
            int index = 0;
            foreach (Auto au in dep._lista)
            {
                if (au == a)
                {
                    index = dep.GetIndice(au);
                    dep._lista.RemoveAt(index);
                    return true;
                }
            }
            return false;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }
        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public override string ToString()
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Capacidad maxima de autos: ");
            resp.Append(Convert.ToString(this._capacidadMaxima));
            resp.Append("\nDetalle de cada auto: ");
            foreach (Auto a in this._lista)
            {
                resp.Append(a.ToString());
                resp.Append("\n");
            }
            return resp.ToString();
        }
    }
}
