using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Triangulo
    {
        private int lado;
        private int ancho;
        private int alto;

        
        public Triangulo()
        {
            Console.WriteLine("Ingrese el valor de lado: ");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de lado: ");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de lado: ");
            alto = int.Parse(Console.ReadLine());
        }
        public double areaTri()
        {
            double vArea;
            vArea = (ancho * alto) / 2; 

            return vArea;

        }

        public double perimetroTri()
        {
            double vPer;
            vPer = lado + lado + lado;

            return vPer;

        }

     }
        
    
  }

