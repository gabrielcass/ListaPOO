using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1;
            ret1 = new Retangulo();

            Console.WriteLine("Informe o valor da Base:");
            ret1.setBase(int.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o valor da Altura");
            ret1.setAltura(int.Parse(Console.ReadLine()));

            ret1.calcularArea();

            Console.WriteLine("O Retângulo de Base {0} e Altura {1} tem a Area de {2}",ret1.getBase(), ret1.getAltura(), ret1.getArea());

            Console.ReadKey();

        }
    }
}
