using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx7
{
    class Dolar
    {
        private double cotacao;
        private double dolar;
        private double real;

        public void setCotacao(double p)
        {
            cotacao = p;
        } 

        public double getCotacao()
        {
            return cotacao;
        }

        public void setDolar(double p)
        {
            dolar = p;
        }

        public double getDolar()
        {
            return dolar;
        }

        public void calcularReal()
        {
            real = dolar * cotacao;
        }

        public double getReal()
        {
            return real;
        }

    }
}
