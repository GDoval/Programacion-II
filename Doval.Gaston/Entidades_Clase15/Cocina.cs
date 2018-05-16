using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase15
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo { get { return this._codigo; } }
        public bool EsIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }

        public Cocina(int codigo, double precio, bool es)
        {
            this._precio = precio;
            this._esIndustrial = es;
            this._codigo = codigo;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            if (a.Codigo == b.Codigo)
                return true;
            else
                return false;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Cocina && ((Cocina)obj) == this)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Codigo: " + this.Codigo + "\n");
            resp.Append("Precio: " + this.Precio + "\n");
            if (this.EsIndustrial)
                resp.Append("Es industrial\n");
            else
                resp.Append("No es industrial\n");
            return resp.ToString();
        }
    }
}
