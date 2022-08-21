using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base2Para10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mudança de Base 10 para Base 2
            int n;
            string result;

            Console.Write("Digite um número na Base 10: ");
            n=int.Parse(Console.ReadLine());


        }
        static string ConvertenRecursiva(int n)
        {
            string r = "";

            if(n>= 1)
            {
                r = (n % 2) + r;
                return ConvertenRecursiva(n / 2) + r;
            }
            return r;
        }
        static string ConverteN(int n)
        {
            string r = "";

            while(n>=1)
            {
                r = (n % 2) + r;
                n = n / 2;

            }
            return r;
        }
    }
}
