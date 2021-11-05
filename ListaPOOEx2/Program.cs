using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad1;
            quad1 = new Quadrado();

            Console.WriteLine("Informe o valor da Aresta: ");
            quad1.setAresta(int.Parse(Console.ReadLine()));

            quad1.calcularArea();

            Console.WriteLine("A Área do quadrado de aresta {0} é de {1}", quad1.getAresta(), quad1.getArea());

            Console.ReadKey();

        }
    }
}
