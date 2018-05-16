using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase15
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int cant)
        {
            this._capacidadMaxima = cant;
            this._lista = new List<Cocina>();
        }

        private int GetIndice(Cocina c)
        {
            foreach (Cocina co in this._lista)
            {
                if (co == c)
                    return this._lista.IndexOf(co);
            }
            return -1;
        }

        public bool Remover(Cocina a)
        {
            return this - a;
        }
        public bool Agregar(Cocina a)
        {
            return this + a;
        }

        public static bool operator +(DepositoDeCocinas dep, Cocina c)
        {
            if (dep._lista.Count < dep._capacidadMaxima)
            {
                dep._lista.Add(c);
                return true;
            }
            else
                return false;
        }

        public static bool operator -(DepositoDeCocinas dep, Cocina c)
        {
            int index = 0;
            foreach (Cocina cu in dep._lista)
            {
                if (cu == c)
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
            resp.Append("Capacidad maxima de cocinas: ");
            resp.Append(this._capacidadMaxima);
            resp.Append("\nDetalle de cada cocina: \n");
            foreach (Cocina a in this._lista)
            {
                resp.Append(a.ToString());
                resp.Append("\n");
            }
            return resp.ToString();
        }
        
    }
}
