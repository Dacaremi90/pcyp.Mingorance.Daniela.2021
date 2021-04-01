using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Cuadrado
    {
        private int lado;

        public Cuadrado()
        {
            Console.WriteLine("Ingrese el valor de lado: ");
            lado = int.Parse(Console.ReadLine());
            
        }
        public double areaCuadr()
        {
            double vArea;
            vArea = lado * lado; 

            return vArea;

        }

        public double perimetroCuadr()
        {
            double vPer;
            vPer = 4 * lado;

            return vPer;

        }

    }
}
