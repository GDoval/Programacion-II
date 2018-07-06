using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fijos: Gastos
    {
        public enum ETipoFijo
        {
            Permanente, Accesorio
        }
        
        private DateTime _fechaDebito;
        private ETipoFijo _tipo;

        public DateTime Debito { get { return this._fechaDebito; } set { this._fechaDebito = value; } }
        public ETipoFijo Tipo_Gasto { get { return this._tipo; } set { this._tipo = value; } }

        public Fijos(double monto, string just, DateTime debito, ETipoFijo tipo, ETipoGasto gastoTipo)
            : base(monto, just, gastoTipo)
        {
            this.Debito = debito;
            this.Tipo_Gasto = tipo;
        }
    }
}
