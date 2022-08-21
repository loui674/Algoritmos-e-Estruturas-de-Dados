using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Stack<Produto>> MinhaFIla = new Queue<Stack<Produto>>();

            Stack<Produto> MinhaPilha;

            Produto xProduto;

            MinhaPilha = new Stack<Produto>();

            xProduto = new Produto();

            xProduto.NomeProduto = "Pasta ZIP 20 Furos";
            xProduto.PrecoProduto = 54.30;

            MinhaPilha.Push(xProduto);

            xProduto = new Produto();

            xProduto.NomeProduto = "Caderno Yasuo League of Legends";
            xProduto.PrecoProduto = 24.30;

            MinhaPilha.Push(xProduto);

            xProduto = new Produto();

            xProduto.NomeProduto = "Pasta Rosa Panini";
            xProduto.PrecoProduto = 12.80;

            MinhaPilha.Push(xProduto);

            MinhaFIla.Enqueue(MinhaPilha);


            MinhaPilha = new Stack<Produto>();

            xProduto = new Produto();

            xProduto.NomeProduto = "Whiskey Chivas Regal";
            xProduto.PrecoProduto = 190;

            MinhaPilha.Push(xProduto);

            xProduto = new Produto();

            xProduto.NomeProduto = "Fanta Guaraná Delicinha";
            xProduto.PrecoProduto = 4.00;

            MinhaPilha.Push(xProduto);

            MinhaFIla.Enqueue(MinhaPilha);

            foreach(Stack<Produto> pilha in MinhaFIla)
            {
                Console.WriteLine("Dados da Pilha: ");

                foreach(Produto prod in pilha)
                {
                    Console.WriteLine($"=> {prod.NomeProduto} - R$ {prod.PrecoProduto}");
                }
            }
        }
    }
}
