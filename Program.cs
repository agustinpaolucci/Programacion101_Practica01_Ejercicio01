using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion101_Practica01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec01 = new Rectangulo();

            Console.WriteLine("Ingrese la altura del rectánguilo en cms...");
            rec01.Alto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la anchura del rectángulo en cms...");
            rec01.Ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El area del rectangulo de medidas " + rec01.ToString() + " es: ");

            Console.WriteLine(rec01.CacularArea(rec01.Alto, rec01.Ancho)+" cm3.");

            Console.ReadKey();
        }
    }
}
