using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum TipoDePrestamo
    {
        Pesos, Dolares, Todos
    }

    public enum PeriocidadDePago
    {
        Mensual, Bimestral, Trimestral
    }
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto { get { return this.monto; } }
        public DateTime Vencimiento { get { return this.vencimiento; }
            set {
                DateTime ahora = DateTime.Now;
                if (value > ahora)
                {
                    this.vencimiento = value;
                }
                else
                    this.vencimiento = ahora;
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2) //Hacer con la List de la clase Financiera
        {
            if (p1.Vencimiento > p2.Vencimiento)
                return 1;
            else
                return -1;
            
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            string resp = "";
            resp += "  Monto: " + this.monto + "\n-----\nVencimiento: " + this.vencimiento + "\n";
            return resp;
        }

    }
}
