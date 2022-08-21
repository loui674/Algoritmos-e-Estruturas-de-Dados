using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_Hashing
{
    internal class Médico
    {
        public string Nome { get; set; }
        public Especialidade Espec { get; set; }

        public void LeDados()
        {
            Console.Write("Nome do(a) Médico: ");
            this.Nome = Console.ReadLine();
        }
        public void MostraDados()
        {
            Console.WriteLine($"Médico(a): {this.Nome} - Especialidade: {this.Espec}");
        }
    }
}
