using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Practica_Parcial1
{
    public class Comercio
    {
        private string _duenio;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;

        public Comercio(string duenio)
        {
            this._duenio = duenio;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
            int estoy = 0;
            foreach (Articulo art in this._misArticulos)
            {
                if (art == articuloComprado)
                {
                    art.Stock = art + articuloComprado;
                    estoy = 1;
                    break;
                }
            }
            if (estoy == 0)
                this._misArticulos.Add(articuloComprado);
        }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        {
            Venta vendido;
            int noHay = 0;
            int estoy = 1;
            string resp = "";
            foreach (Articulo art in this._misArticulos)
            {
                if (art == articuloSolicitado && art.HayStock(cantidad))
                {
                    art.Stock = art - cantidad;
                    vendido = new Venta(articuloSolicitado, cantidad);
                    this._misVentas.Add(vendido);
                    estoy = 0;
                    break;
                }
                else if (art == articuloSolicitado && !(art.HayStock(cantidad)))
                {
                    noHay = 1;
                    estoy = 0;
                    resp = "El siguiente producto no tiene stock disponible! " + "\n" + art.NombreYCodigo + "\n";
                }                    
            }
            if (noHay == 1)
                Console.WriteLine("{0}", resp);
            if (estoy == 1)
            {
                resp = "El siguiente producto no existe! " + "\n" + articuloSolicitado.NombreYCodigo + "\n";
                Console.WriteLine("{0}", resp);
            }
        }

        public static void MostrarArticulos(Comercio comercioAMostrar)
        {
            foreach (Articulo art in comercioAMostrar._misArticulos)
                Console.WriteLine(art.NombreYCodigo);
        }
        public static void MostrarGanancia(Comercio ComercioParaResumen)
        {
            float ganancia = 0;
            foreach (Venta vent in ComercioParaResumen._misVentas)
            {
                ganancia += vent.RetornarGanancia();
            }
            Console.WriteLine("La ganancia total es de: {0}", Convert.ToString(ganancia));
        }
    }
}
