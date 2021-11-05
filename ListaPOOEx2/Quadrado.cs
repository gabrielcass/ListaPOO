using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx2
{
    class Quadrado
    {
        private int _aresta;
        private int _area;

        public void setAresta(int p)
        {
            _aresta = p;
        }
        public int getAresta()
        {
            return _aresta;
        }

        public void calcularArea()
        {
            _area = _aresta * _aresta;
        }

        public int getArea()
        {
            return _area;
        }
    }
}
