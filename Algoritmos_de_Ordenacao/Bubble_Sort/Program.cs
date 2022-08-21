using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            int i;

            for(i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Vetor Desordenado: {vetor,6}");

            InsertionSort(vetor);

            Console.WriteLine($"Algortimo ordenado pelo Insertion Sort: {vetor,6}");

            Console.ReadKey();
        }
        //========== INSERTION SORT =============
        public static int[] InsertionSort(int[] vetor)
        {
            int i, j, atual;

            for(i=0;i<vetor.Length;i++)
            {
                atual = vetor[i];
                j = i;

                while((j>0) && (vetor[j-1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
            return vetor;
        }
        //============ SELECTION SORT =================
        public static int[] SelectionSort(int[] vetor)
        {
            int min, aux;

            for(int i = 0; i<vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++) 
                {
                    if(vetor[j] < vetor[min])
                    {
                        min = j;
                    }    

                    if(min != i)
                    {
                        aux = vetor[min];
                        vetor[min] = vetor[i];
                        vetor[i] = aux;
                    }
                }
            }
            return vetor;
        }
        // =========== QUICK SORT ==============
        public static int[] QuickSort(int[] vetor)
        {
            int inicio = 0;
            int fim=vetor.Length-1;

            QuickSort(vetor, inicio, fim);

            return vetor;
        }
        private static void QuickSort(int[] vetor, int inicio, int fim)
        {
            if(inicio<fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }
        }
        //========= BUBBLE SORT ============
        public static int[] BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comp = 0;
            int troca = 0;

            for(int i = 1;i <= tamanho;i++)
            {
                for(int j = 0; j<i;j++)
                {
                    comp++;
                    if(vetor[j] > vetor[i+1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j+1];
                        vetor[j+1] = aux;
                        troca++;
                    }
                }
            }
            return vetor;
        }
    }
}
