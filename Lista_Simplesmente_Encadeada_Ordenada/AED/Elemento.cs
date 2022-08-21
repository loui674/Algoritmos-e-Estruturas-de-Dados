using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    internal class Elemento
    {
        public int Valor;
        public Elemento Prox;

        public Elemento()
        {
            Valor = 0;
            Prox = null;
        }
    }
}
