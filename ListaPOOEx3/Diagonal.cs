using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx3
{
    class Diagonal
    {
        private double diagonal;
        private double area;

        public void setDiagonal(int p)
        {
            diagonal = p;
        }
        public double getDiagonal()
        {
            return diagonal;
        }
        public void calcularArea()
        {
            area = Math.Pow(diagonal,2) / 2;
        }

        public double getArea()
        {
            return area;
        }
    }
}
