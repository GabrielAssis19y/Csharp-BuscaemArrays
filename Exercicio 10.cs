using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int x = 2;
            Random rnd = new Random();
            int num = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = num;
                num = num + rnd.Next(1, 10);

            }
            int result = BuscaRecursiva(vet, x, 0, vet.Length-1);
            if (result == -1)
            {
                Console.WriteLine("Valor não encontrado.");
            }
            else
            {
                Console.WriteLine($"Valor encontrado na posição {result}.");
            }

        }
        static int BuscaRecursiva(int[] array, int x, int esq, int dir)
        {
            if (esq > dir)
            {
                return -1; 
            }

            int meio = (esq + dir) / 2;

            if (x == array[meio]) 
            {
                return meio;
            }
            else if (x > array[meio]) 
            {
                return BuscaRecursiva(array, x, meio + 1, dir);
            }
            else 
            {
                return BuscaRecursiva(array, x, esq, meio - 1);
            }
        }
    }
}
