using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangulo: --------------------------------");
            double vr;
            Rectangulo Rec = new Rectangulo();
            vr = Rec.areaRect();
            Console.WriteLine("El area del Rectangulo es: {0}", vr);
            Console.ReadLine();
            vr = Rec.perimetroRect();
            Console.WriteLine("El perimetro del Rectangulo es: {0}", vr);
            Console.ReadLine();


            Console.WriteLine("Cuadrado: --------------------------------");
            double vc;
            Cuadrado Cuad = new Cuadrado();
            vc = Cuad.areaCuadr();
            Console.WriteLine("El area del Cuadrado es: {0}", vc);
            Console.ReadLine();
            vc = Cuad.perimetroCuadr();
            Console.WriteLine("El perimetro del Cuadrado es: {0}", vc);
            Console.ReadLine();

            Console.WriteLine("Triangulo: --------------------------------");
            double vt;
            Triangulo Tri = new Triangulo();
            vt = Tri.areaTri();
            Console.WriteLine("El area del Triangulo es: {0}", vt);
            Console.ReadLine();
            vt = Tri.perimetroTri();
            Console.WriteLine("El perimetro del Triangulo es: {0}", vt);
            Console.ReadLine();
        }
    }
}
