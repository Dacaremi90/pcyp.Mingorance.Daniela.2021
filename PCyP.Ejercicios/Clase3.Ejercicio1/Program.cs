using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase3.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

            /*1- Revisar en el diccionario si existe un índice llamado “Juan”.
             En caso de que exista, mostrar su valor (utilice el método ContainsKey)*/
            if (values.ContainsKey("Juan") == true)
            {

                Console.WriteLine(values["Juan"]);
            }

            /*2- Revisar en el diccionario si existe un índice llamado “Pedro”. En caso de que exista, mostrar su valor, 
            si no existe imprimir por pantalla “No contiene la llave” (utilice el método TryGetValue)*/
            string value;
            if (values.TryGetValue("Pedro", out value))
            {
                Console.WriteLine("For key = \"Pedro\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }

            /*3- Recorrer el diccionario y mostrar todos sus datos (índice y valor).*/
            foreach (KeyValuePair<string, string> item in values)
            {
                Console.WriteLine("{0} , {1}", item.Key, item.Value);
            }

            /*4- Alterar el valor cuyo índice es “Mariana” por “58251425”. Imprimir el nuevo valor.*/

            values.Remove("Mariana");
            values.Add("Mariana","58251425");


             foreach (KeyValuePair<string, string> item in values)
             {

                 if (item.Key == "Mariana")
                 {
                     Console.WriteLine("{0},  Nuevo telefono de Mariana = {1}", item.Key, item.Value);
                 }
             }


             Console.ReadKey();
         }

        }


    }
    

