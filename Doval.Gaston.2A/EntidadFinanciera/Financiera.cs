using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;
namespace EntidadFinanciera
{
    class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresEnDolares {
            get {
                float acum = 0;
                foreach (Prestamo p in this.listaDePrestamos)
                {
                    if (p is PrestamoDolar)
                    {
                        acum += ((PrestamoDolar)p).Interes;
                    }
                }
                return acum;
            } 
        }

        public float InteresEnPesos
        {
            get {
                float acum = 0;
                foreach (Prestamo p in this.listaDePrestamos)
                {
                    if (p is PrestamoPesos)
                    {
                        acum += ((PrestamoPesos)p).Interes;
                    }
                }
                return acum;
                } 
        }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float resp = 0;
            switch (tipoPrestamo)
            {
                case TipoDePrestamo.Dolares:
                    resp = this.InteresEnDolares;
                    break;
                case TipoDePrestamo.Pesos:
                    resp = this.InteresEnPesos;
                    break;
                case TipoDePrestamo.Todos:
                    resp = this.InteresEnPesos;
                    resp += this.InteresEnDolares;
                    break;
            }
            return resp;
        }

        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha(
        }


        public static explicit operator string(Financiera financiera)
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Razon social: ");
            resp.Append(financiera.razonSocial);
            resp.Append("\nGanancia total: ");
            resp.Append(financiera.CalcularInteresGanado(TipoDePrestamo.Todos));
            resp.Append("\nGanancia por prestamos en dolares: ");
            resp.Append(financiera.CalcularInteresGanado(TipoDePrestamo.Dolares));
            resp.Append("\nGanancia por prestamos en pesos: ");
            resp.Append(financiera.CalcularInteresGanado(TipoDePrestamo.Pesos));

            
        }
    }
}
