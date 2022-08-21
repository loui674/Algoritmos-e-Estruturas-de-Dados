using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_Construtores
{
    class Pessoa
    {
        int idade;
        //Método Construtor com e sem uso de parâmetros
        public Pessoa()
        {
            Console.WriteLine("Objeto Pessoa criado.");
        }
        public Pessoa(int idade) : this ()
        {
            this.idade = idade;
        }
        //Método Destrutor
       ~Pessoa()
        {
            Console.WriteLine("Objeto Pessoa Destruído. ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
