using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase6.Abecedario
{
    class Program
    {
        
        private static int conteo = 64;
        private static bool ejecutar = true;

        //uso este objeto para crear un lock
        private static object control = new object();
        private static int id1 = 0;
        private static int id2 = 0;

        static void Main(string[] args)
        {

            Thread hilo1 = new Thread(Incremento);

            hilo1.Start();

            //obtener el id del hilo
            id1 = hilo1.ManagedThreadId;

            Thread hilo2 = new Thread(Incremento);

            hilo2.Start();
            id2 = hilo2.ManagedThreadId;

            while (ejecutar)
            {
                if (conteo == 89)
                {
                    ejecutar = false;
                }
            }



            Console.ReadLine();

        }

        static void Incremento()

        {


            while (ejecutar)
            {


                lock (control)
                {
                    if (Thread.CurrentThread.ManagedThreadId == id1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("hilo1");
                    }

                    if (Thread.CurrentThread.ManagedThreadId == id2)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("hilo2");
                    }


                    conteo += 1;
                    byte a;
                    a = (byte)conteo;

                    Console.WriteLine(" letra " + (char)a);
                    Thread.Sleep(100);
                }
            }
        }
    }
}
    

