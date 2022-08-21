using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    internal class ListaSEO
    {
        public Elemento Inicio;
        public Elemento Fim;
        public Elemento Aux;
        public Elemento Anterior;

        public ListaSEO()
        {
            Inicio = null;
            Fim = null;
        }
        public void Inserir(int x)
        {
            Elemento Novo= new Elemento();

            Novo.Valor = x;

            if(Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Anterior = null;

                Aux = Inicio;
                while(Aux != null && Novo.Valor > Aux.Valor)
                {
                    Anterior = Aux;

                    Aux = Aux.Prox;
                }

                if(Anterior == null)
                {
                    Novo.Prox = Inicio;

                    Inicio = Novo;
                }
                else if (Aux == null)
                {
                    Fim.Prox = Novo;

                    Fim = Novo;
                }
                else
                {
                    Anterior.Prox = Novo;

                    Novo.Prox = Aux;
                }
            }
        }
        public void Mostra()
        {
            Aux = Inicio;

            while(Aux != null)
            {
                Console.Write($"{Aux.Valor,6}");

                Aux = Aux.Prox;
            }

            Console.ReadKey();
        }
    }
}
