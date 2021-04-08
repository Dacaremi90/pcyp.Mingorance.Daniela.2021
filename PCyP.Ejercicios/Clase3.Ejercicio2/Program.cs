using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2
{
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };

        static void Main(string[] args)
        {
            List<string> colores = new List<string>();
            List<string> removerColores = new List<string>();



            for (int i = 0; i <= colors.Length - 1; i++)
            {
                colores.Add(colors[i]);


            }

            for (int i = 0; i <= removeColors.Length - 1; i++)
            {
                removerColores.Add(removeColors[i]);

            }

            /*Mostrar colores por pantalla*/
            Console.WriteLine("Ejercicio B");

            foreach (string e in colores)
            {
                Console.Write(e + " ");
            }



            for (int i = 0; i <= removerColores.Count - 1; i++)
            {
                colores.Remove(removerColores.ElementAt(i));

            }


            /*Volver a mostrar lista*/
            Console.WriteLine("\nColores: ");
            foreach (string e in colores)
            {
                Console.Write(e + " ");
            }

        }
        
            
    }
}



