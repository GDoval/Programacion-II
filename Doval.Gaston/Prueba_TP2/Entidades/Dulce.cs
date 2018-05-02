using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dulce : Producto
    {
        protected override short CantidadCalorias { get { return 80; } }

        public Dulce(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
        }

        public override sealed string Mostrar()
        {

            /*string resp = "";
            resp += "Calorias: " + Convert.ToString(this.CantidadCalorias) + "  " + this._codigoDeBarras;
            return resp;*/
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(this.Mostrar());
            sb.AppendLine("CALORIAS : {0}");
            sb.AppendLine(Convert.ToString(this.CantidadCalorias));
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return Convert.ToString(sb);
        }
    }
}
