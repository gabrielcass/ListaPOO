using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx8
{
    class Program
    {
        static void Main(string[] args)
        {
            Maior mai;
            mai = new Maior();

            Console.Write("Informe o primeiro valor: ");
            mai.setNum1(int.Parse(Console.ReadLine()));

            Console.Write("Informe o segundo valor: ");
            mai.setNum2(int.Parse(Console.ReadLine()));

            mai.descobrirMaior();

            Console.WriteLine("O maior numero é: {0}", mai.getMaior());

            Console.ReadKey();
        }
    }
}
