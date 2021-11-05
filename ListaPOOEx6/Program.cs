using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            Milha mi;
            mi = new Milha();

            Console.Write("Informe o valor em milhas náuticas: ");
            mi.setMilha(int.Parse(Console.ReadLine()));

            mi.calcularKm();

            Console.WriteLine("{0} Milhas equivale a {1} Quilômetros", mi.getMilha(), mi.getKm());

            Console.ReadKey();
        }
    }
}
