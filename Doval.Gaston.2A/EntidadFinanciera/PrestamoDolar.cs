using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriocidadDePago periocidad;
        public float Interes { get { return this.CalcularInteres(); } }

        private float CalcularInteres()
        {
            float resp = 0;
            switch (this.periocidad)
            {
                case PeriocidadDePago.Mensual:
                    resp = (base.Monto * 0.25f) + base.Monto;
                    break;
                case PeriocidadDePago.Bimestral:
                    resp = (base.Monto * 0.35f) + base.Monto;
                    break;
                case PeriocidadDePago.Trimestral:
                    resp = (base.Monto * 0.40f) + base.Monto;
                    break;
            }
            return resp;
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriocidadDePago periodicidad)
            :base (monto, vencimiento)
        {
            this.periocidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriocidadDePago periodicidad)
            : base(prestamo.Monto, prestamo.Vencimiento)
        {
            this.periocidad = periodicidad;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {

            {
                if (nuevoVencimiento > this.Vencimiento)
                {
                    while (!(DateTime.Equals(nuevoVencimiento, this.Vencimiento)))
                    {
                        this.Vencimiento = this.vencimiento.AddDays(1);
                        this.monto += 2.5f;
                    }
                }
                else
                    return;
                this.Vencimiento = nuevoVencimiento;
            }
        }



        public override string Mostrar()
        {
            float inte = 0;
            switch (this.periocidad)
            {
                case PeriocidadDePago.Mensual:
                    inte = 0.25f;
                    break;
                case PeriocidadDePago.Bimestral:
                    inte = 0.30f;;
                    break;
                case PeriocidadDePago.Trimestral:
                    inte = 0.40f;;
                    break;
            }
            StringBuilder resp = new StringBuilder();
            resp.Append(base.Mostrar());
            resp.Append("\nEl procentaje de interes aplicado fue: ");
            resp.Append(inte);
            resp.Append("\nEl monto total es de: \n");
            resp.Append(this.Interes);
            return resp.ToString();
        }
    }
}
