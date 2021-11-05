using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx4
{
    class Triangulo
    {
        private int _base;
        private int _altura;
        private int _area;

        public void setBase (int p)
        {
            _base = p;
        }
        public int getBase()
        {
            return _base;
        }
        public void setAltura(int p)
        {
            _altura = p;
        }

        public int getAltura()
        {
            return _altura;
        }

        public void calcularArea()
        {
            _area = (_base * _altura) / 2;
        }

        public int getArea()
        {
            return _area;
        }
    }
}
