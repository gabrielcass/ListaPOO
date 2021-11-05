using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dol;
            dol = new Dolar();

            Console.Write("Informe a cotação atual do dólar: ");
            dol.setCotacao(double.Parse(Console.ReadLine()));

            Console.Write("Informe a quantia em dólares para conversão: ");
            dol.setDolar(double.Parse(Console.ReadLine()));

            dol.calcularReal();

            Console.WriteLine("O valor em Reais é {0} para {1} Dólares na Cotação de {2}.", dol.getReal(), dol.getDolar(), dol.getCotacao());

            Console.ReadKey();
        }
    }
}
