using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();

            Console.Write("Informe o valor da base do triângulo: ");
            tri.setBase(int.Parse(Console.ReadLine()));

            Console.Write("Informe o valor da altura do triângulo: ");
            tri.setAltura(int.Parse(Console.ReadLine()));

            tri.calcularArea();

            Console.WriteLine("A área de um triangulo de base {0} e altura {1}, possui uma área de {2}", tri.getBase(), tri.getAltura(), tri.getArea());

            Console.ReadKey();
        }
    }
}
