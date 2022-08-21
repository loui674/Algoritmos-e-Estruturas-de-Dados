using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elaborar uma Solução (SLN) através do Visual Studio .NET C# que opere sobre os temas apresentados no conjunto de grupo do 
             * Canvas, menu Pessoas. O programa deverá possuir funções de inclusão, exclusão e listagem de registros e, obrigatoriamente,
             * deve conter algum relacionamento entre as classes mostradas.
                >>>>> Médicos e Especialidades
                O usuário entra todas as categorias de produtos em uma estrutura. 
            Ao cadastrar um produto o programa pede o código (chave) da categoria e a valida na estrutura de categorias. 
            Na listagem a operação é análoga. Ao se listar um produto uma consulta é feita na estrutura de categorias e a descrição dela 
            é mostrada.*/

            Hashtable meuHashtable = new Hashtable(); //posições, fator de carga (o quanto que eu admito que possam haver conflitos em cada posição)

            meuHashtable.Add("123", "João");
            meuHashtable.Add("456", "Maria");
            meuHashtable.Add("789", "Pedro");
            meuHashtable.Add("909", "Antonio");

            int op;
            Console.WriteLine("Bem vindo ao programa!");
            Console.WriteLine("Por favor, selecione a opção desejada: ");
            Console.WriteLine("1 - Listagem de Médicos");
            Console.WriteLine("2 - Listagem de Especialidades");
            Console.WriteLine("3 - Inclusão de Registros");
            Console.WriteLine("4 - Exclusão de Registros");
            Console.WriteLine("0 - Sair do programa");
            op = int.Parse(Console.ReadLine());

            foreach (DictionaryEntry Item in meuHashtable) //é uma entrada de dicionario que a estrutura hashtable respeita
            {
                Console.WriteLine($"{Item.Key} => {Item.Value}"); //vasculhar as entradas do meu hashtable
            }

            Console.ReadKey();
            Console.WriteLine();

            foreach(string Chave in meuHashtable.Keys)
            {
                Console.WriteLine($"{Chave}");
            }
            foreach (string Valor in meuHashtable.Keys)
            {
                Console.WriteLine($"{Valor}");
            }

            Console.ReadKey();

            Console.WriteLine($"Registros: {meuHashtable.Count}");

            Console.ReadKey();

            Console.Clear();

            string aux;
            Console.Write("Digite uma chave: ");
            aux = Console.ReadLine();  

            if(meuHashtable.ContainsKey(aux))
            {
                Console.WriteLine($"=> {meuHashtable[aux]}");
            }
            else
            {
                Console.WriteLine("Registro não existe!");
            }

            Console.ReadKey();

            meuHashtable.Remove(aux);
        }
    }
}
