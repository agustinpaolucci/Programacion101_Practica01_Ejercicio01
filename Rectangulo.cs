using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion101_Practica01
{
    public class Rectangulo
    {
        private double ancho;
        private double alto;

        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        public double Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        public Rectangulo()
        {
            ancho = 0.0;
            alto = 0.0;
        }

        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public double CacularArea(double ancho, double alto)
        {
            double area = 0.0;
            area = ancho * alto;
            return area;
        }

        public override string ToString()
        {
            return "alto: "+this.alto+ " y ancho: " + this.ancho;
        }

    }
}
