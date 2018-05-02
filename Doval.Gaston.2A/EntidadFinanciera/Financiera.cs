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

        public float InteresEnDolares { get { } }






        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }




        public static explicit operator string(Financiera financiera)
        {
            StringBuilder resp = new StringBuilder();
            
        }
    }
}
