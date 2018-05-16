using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase15
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int cant)
        {
            this._capacidadMaxima = cant;
            this._lista = new List<T>();
        }

        private int GetIndice(T c)
        {
            foreach (T co in this._lista)
            {
                if (co.Equals(c))
                    return this._lista.IndexOf(co);
            }
            return -1;
        }

        public bool Remover(T a)
        {
            return this - a;
        }
        public bool Agregar(T a)
        {
            return this + a;
        }

        public static bool operator +(Deposito<T> dep, T c)
        {
            if (dep._lista.Count < dep._capacidadMaxima)
            {
                dep._lista.Add(c);
                return true;
            }
            else
                return false;
        }

        public static bool operator -(Deposito<T> dep, T c)
        {
            int index = 0;
            foreach (T cu in dep._lista)
            {
                if (cu.Equals(c))
                {
                    index = dep.GetIndice(cu);
                    dep._lista.RemoveAt(index);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Capacidad maxima: ");
            resp.Append(this._capacidadMaxima + "\n");
            foreach (T a in this._lista)
            {
                resp.Append(a);
            }
            return resp.ToString();
        }
    }
}
