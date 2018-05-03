using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float _porcentajeInteres;
        public float Interes { get { return this.CalcularInteres(); } }

        private float CalcularInteres()
        {
            float resp = 0;
            resp = (base.Monto * _porcentajeInteres) + base.Monto;
            return resp;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            if (nuevoVencimiento > this.Vencimiento)
            {
                while (!(DateTime.Equals(nuevoVencimiento, this.Vencimiento)))
                {
                    this.Vencimiento = this.vencimiento.AddDays(1);
                    this._porcentajeInteres += 0.25f;
                }
            }
            else
                return;
            this.Vencimiento = nuevoVencimiento;
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            : base(monto, vencimiento)
        {
            this._porcentajeInteres = interes;
        }
        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
            : base(prestamo.Monto, prestamo.Vencimiento)
        {
            this._porcentajeInteres = porcentajeInteres;
        }
        public override string Mostrar()
        {
            StringBuilder resp = new StringBuilder();
            resp.Append(base.Mostrar());
            resp.Append("\nEl procentaje de interes aplicado fue: ");
            resp.Append(this._porcentajeInteres);
            resp.Append("\nEl monto total es de: \n");
            resp.Append(this.Interes);
            return resp.ToString();
        }
    }
}
