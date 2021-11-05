using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Diagonal diag;
            diag = new Diagonal();

            Console.Write("Informe o valor da Diagonal: ");
            diag.setDiagonal(int.Parse(Console.ReadLine()));

            diag.calcularArea();

            Console.WriteLine("A área do quadrado de diagonal {0} é de {1}", diag.getDiagonal(), diag.getArea());

            Console.ReadKey();
        }
    }
}
