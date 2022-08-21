using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSEO MinhaLista = new ListaSEO();

            MinhaLista.Inserir(5);

            MinhaLista.Inserir(2);

            MinhaLista.Inserir(10);

            MinhaLista.Inserir(8);

            MinhaLista.Inserir(7);

            MinhaLista.Mostra();

        }
    }
}
