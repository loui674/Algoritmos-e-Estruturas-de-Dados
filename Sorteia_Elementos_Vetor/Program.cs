using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Por meio de funções faça um programa que sorteie elementos de um vetor de tamanho “T” 
            fornecido pelo usuário e inverta a ordem de seus elementos.*/
            int t;
            Random x= new Random();

            Console.Write("Insira o tamanho do vetor: ");
            t=int.Parse(Console.ReadLine());
            
            int[] vet= new int [t];

            PreencheVetor(vet,x);

            Console.Write("Vetor na ordem original: ");
            MostraVetor(vet);

            Console.WriteLine();
            InverteVetoreExibe(vet);

            Console.ReadKey();
        }
        static void InverteVetoreExibe(int [] vet)
        {
            Array.Reverse(vet);
            Console.Write("Ordem inversa: ");
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{vet[i],6}");
            }
        }
        static void MostraVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{vet[i],7}");
            }
        }
        static void PreencheVetor(int[] vet, Random x)
        {
            x = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = x.Next(0, 50);
            }
        }
    }
}
