using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProcesarGastos : CalcularGastos<Gastos>
    {
        private List<Superfluo> listaSuperfluo;
        private List<Necesarios> listaNecesarios;
        private List<Fijos> listaFijos;
        private double total;

        public ProcesarGastos()
        {
            this.listaFijos = new List<Fijos>();
            this.listaNecesarios = new List<Necesarios>();
            this.listaSuperfluo = new List<Superfluo>();
        }

        public double Calcular(List<Gastos> lista)
        {
            this.total = 0;
            foreach (Gastos g in lista)
                this.total += g.Gasto;
            return this.total;
        }
    }
}
