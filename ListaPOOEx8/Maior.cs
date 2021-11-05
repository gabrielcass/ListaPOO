using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOEx8
{
    class Maior
    {
        #region Atributos
        private int num1;
        private int num2;
        private int maior;
        #endregion

        #region Construtores
        public Maior()
        {
            this.num1 = 1;
            this.num2 = 1;
        }

        public Maior(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        #endregion

        #region Setter's & Getter's
        public void setNum1(int p)
        {
            this.num1 = p;
        }

        public void setNum2 (int p)
        {
            this.num2 = p;
        }
        public int getNum1()
        {
            return this.num1;
        }

        public int getNum2()
        {
            return this.num2;
        }

        public int getMaior()
        {
            return this.maior;
        }
        #endregion

        #region Funcionais
        public void descobrirMaior()
        {
            if (this.num1 > num2)
                this.maior = num1;
            else
                this.maior = num2;

        }
        #endregion
    }
}
