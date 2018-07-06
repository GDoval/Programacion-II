using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Necesarios : Gastos
    {
        private DateTime inicio;
        private DateTime fin;
        private DateTime duracionTotal;

        public DateTime Inicio { get { return this.inicio; } set { this.inicio = value; } }
        public DateTime Fin { get { return this.fin; } set { this.fin = value; } }
        public DateTime DuracionTotal { get { return this.duracionTotal; } set { this.duracionTotal = value; } }

        public Necesarios(double monto, string just, DateTime incio, ETipoGasto tipo)
            :base(monto, just, tipo)
        {
            this.Inicio = incio;
        }
        
    }
}
