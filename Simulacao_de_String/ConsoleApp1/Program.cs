using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simulação de Length
            //Calcula o tamanho de uma string

            string frase;
            string result;

            int posincial;
            int tam;

            Console.Write("Digite uma Frase: ");
            frase = Console.ReadLine();

            Console.Write("Posição inicial: ");
            posincial = int.Parse(Console.ReadLine());

            Console.Write("Tamanho: ");
            tam= int.Parse(Console.ReadLine());

            result = MySubstring(frase, posincial, tam);

            Console.WriteLine($"Substring = {result}");
            Console.ReadKey();
        }
        static string MySubstring(string f, int pos1,int tam)
        {
            string r = "";

            if(tam == 0)
            {
                r = "";
            }
            else r= f[pos1] + MySubstring (f,pos1+1,tam-1);
                return r;
            }
        }
    }

