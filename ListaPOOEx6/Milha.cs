using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx6
{
    class Milha
    {
        private int milha;
        private double km;

        public void setMilha(int p)
        {
            milha = p;
        }
        
        public int getMilha()
        {
            return milha;
        }

        public void calcularKm()
        {
            km = (double)(milha * 1852) / 1000;
        }

        public double getKm()
        {
            return km;
        }
    }
}
