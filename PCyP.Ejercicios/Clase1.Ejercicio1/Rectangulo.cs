using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Rectangulo
    {
        private int ancho;
        private int alto;

    public Rectangulo()
        {
            Console.WriteLine("Ingrese la Base: ");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Alto: ");
           alto = int.Parse(Console.ReadLine());
        }
     public double areaRect()
        {
            double vArea;
            vArea = ancho * alto;

            return vArea;

        }

        public double perimetroRect()
        {
            double vPer;
            vPer = 2 * ancho + 2 * alto; 

            return vPer;

        }

    }
}
