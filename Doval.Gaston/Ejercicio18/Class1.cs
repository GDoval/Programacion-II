﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Punto
    {
        private int x;
        private int y;
        public  int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            int x = vertice1.GetX();
            int y = vertice3.GetY();
            vertice2 = new Punto(x, y);
            x = vertice3.GetX();
            y = vertice1.GetY();
            vertice4 = new Punto(x, y);
        }
        public float GetArea()
        {
            float area;
            int vert1 = this.vertice1.GetY();
            int vert2 = this.vertice2.GetY();
            float base = 
            return area;
        }

    }

}
