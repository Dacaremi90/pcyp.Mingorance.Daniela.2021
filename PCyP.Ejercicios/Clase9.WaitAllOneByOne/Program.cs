using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase9.WaitAllOneByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //Lista de tareas
            Task<int>[] tasks = new Task<int>[3];

            //Ejecutar tarea
            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            //Mientras el largo de las tareas sea mayor a 0
            while (tasks.Length > 0)
            {
               
                int i = Task.WaitAny(tasks);   //Guarda la tarea que termina primero en i
                
                Task<int> completedTask = tasks[i]; //La tarea completada la guardo en un  variable task
               
                Console.WriteLine(sum += completedTask.Result);   //el resultado de la task lo sumo en sum
                
                var temp = tasks.ToList(); //hago un arrary temporal que copia atask
               
                temp.RemoveAt(i);   //remuevo la task del del indice i
              
                tasks = temp.ToArray();  //igualo task con la array temporal
            }
            Console.ReadLine();
        }
    }
    
}
