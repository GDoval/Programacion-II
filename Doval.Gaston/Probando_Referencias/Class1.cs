using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando_Referencias
{
    class Auto
    {
        private string marca;
        private int patente;
        private string color;

        public Auto() :this("Nada", "Ninguno", 0)
        {
        }

        public Auto(string marca, string color, int patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }

        public int getPatente()  { return this.patente; }
        public string getMarca() { return this.marca; }
        public  string getColor() { return this.color; }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }
    }


    class Marca
    {
        private List<Auto> cochera;
        private int cantidad;

        public Marca() :this(5)
        {
        }

        public Marca(int cantidad)
        {
            this.cantidad = cantidad;
            this.cochera = new List<Auto>();
        }

        public List<Auto> getAutos()
        { return this.cochera; }

        private int getCantidad()
        { return this.cantidad; }

        public void setAuto(Auto coche)
        {
            this.cochera.Add(coche);
        }

        public Auto Mostrar(int index)
        {
            return this.cochera[index];
        }

    }
}
