using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lineas = File.ReadAllLines("./File/vial.csv");
            foreach(var linea in lineas)
            {
                var valores = linea.Split(',');
                Console.WriteLine(" Numero de Hoja: " + valores[0]
                    + " Tipo-Objeto: " + valores[1]
                    + " Identificador-Tramo: " + valores[2]
                    + " Tipo-Camino: " + valores[3]
                    + " Longitud: " + valores[4]);
                Console.WriteLine("");
            }
        }
    }
}
